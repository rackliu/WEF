﻿/*****************************************************************************************************
 * 本代码版权归Wenli所有，All Rights Reserved (C) 2015-2019
 *****************************************************************************************************
 * 所属域：WENLI-PC
 * 登录用户：yswenli
 * CLR版本：4.0.30319.17929
 * 唯一标识：1e7ab7e0-8733-46b2-a556-1fbb0ad96298
 * 机器名称：WENLI-PC
 * 联系人邮箱：wenguoli_520@qq.com
 *****************************************************************************************************
 * 命名空间：WEF.ModelGenerator
 * 类名称：SQLForm
 * 文件名：SQLForm
 * 创建年份：2015
 * 创建时间：2015-09-23 14:54:06
 * 创建人：Wenli
 * 创建说明：
 *****************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WEF.ModelGenerator.Common;
using WEF.ModelGenerator.Controls;

namespace WEF.ModelGenerator
{
    public partial class SQLForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public SQLForm()
        {
            InitializeComponent();
        }

        public Model.Connection ConnectionModel
        {
            get; set;
        }

        Stopwatch stopwatch = new Stopwatch();

        AutoTextBox autoTextBox1 = null;

        public AutoTextBox AutoTextBox
        {
            get
            {
                if (autoTextBox1 == null)
                    autoTextBox1 = new AutoTextBox();
                return autoTextBox1;
            }
        }

        private void SQLForm_Load(object sender, System.EventArgs e)
        {
            cnnTxt.Text = ConnectionModel.ConnectionString;

            AutoTextBox.Dock = DockStyle.Fill;

            AutoTextBox.KeyUp += autoTextBox1_KeyUp;

            AutoTextBox.TabIndex = 0;

            splitContainer1.Panel1.Controls.Add(AutoTextBox);

            stopwatch.Start();
        }


        /// <summary>
        /// 执行sql
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void autoTextBox1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            ShortcutKeyHelper.AllSelect(sender, e);

            ShortcutKeyHelper.Run(sender, e, () => RunSql());
        }

        public void RunSql()
        {
            var sql = AutoTextBox.TextBox.Text;

            stopwatch.Restart();

            LoadForm.ShowLoading(this);

            Task.Factory.StartNew(() =>
            {
                WEF.DbDAL.IDbObject dbObject = null;

                if (ConnectionModel.DbType.Equals(DatabaseType.SqlServer.ToString()))
                {
                    dbObject = new WEF.DbDAL.SQL2000.DbObject(ConnectionModel.ConnectionString);
                }
                else if (ConnectionModel.DbType.Equals(DatabaseType.SqlServer9.ToString()))
                {
                    dbObject = new WEF.DbDAL.SQL2005.DbObject(ConnectionModel.ConnectionString);
                }
                else if (ConnectionModel.DbType.Equals(DatabaseType.MsAccess.ToString()))
                {
                    dbObject = new WEF.DbDAL.OleDb.DbObject(ConnectionModel.ConnectionString);
                }
                else if (ConnectionModel.DbType.Equals(DatabaseType.Oracle.ToString()))
                {
                    dbObject = new WEF.DbDAL.Oracle.DbObject(ConnectionModel.ConnectionString);
                }
                else if (ConnectionModel.DbType.Equals(DatabaseType.Sqlite3.ToString()))
                {
                    dbObject = new WEF.DbDAL.SQLite.DbObject(ConnectionModel.ConnectionString);
                }
                else if (ConnectionModel.DbType.Equals(DatabaseType.MySql.ToString()))
                {
                    dbObject = new WEF.DbDAL.MySql.DbObject(ConnectionModel.ConnectionString);
                }
                else
                {
                    LoadForm.HideLoading(1);
                    this.Invoke(new Action(() =>
                    {
                        MessageBox.Show(this, "不支持的数据库类型!");
                    }));
                    return;
                }

                if (string.IsNullOrEmpty(sql))
                {
                    LoadForm.HideLoading(1);

                    this.Invoke(new Action(() =>
                    {
                        MessageBox.Show(this, "sql内容不能为空!");
                    }));

                    return;
                }

                this.Invoke(new Action(() =>
                {
                    if (!string.IsNullOrWhiteSpace(AutoTextBox.TextBox.SelectedText))
                    {
                        sql = AutoTextBox.TextBox.SelectedText.Trim();

                        if (string.IsNullOrEmpty(sql))
                        {
                            LoadForm.HideLoading(1);
                            MessageBox.Show(this, "sql内容不能为空!");
                            return;
                        }
                    }

                    dataGridView1.DataSource = null;

                }));

                if (sql.IndexOf("select", StringComparison.InvariantCultureIgnoreCase) >= 0)
                {
                    try
                    {
                        int max = 50;

                        var ds = dbObject.Query(ConnectionModel.Database, sql);

                        if (ds != null && ds.Tables != null)
                        {
                            var dt = ds.Tables[0];

                            if (dt != null && dt.Rows.Count > 0)
                            {
                                var count = dt.Rows.Count;

                                if (count > max)
                                {
                                    for (int i = max; i < count; i++)
                                    {
                                        dt.Rows.RemoveAt(max);
                                    }
                                }


                                var dList = new List<int>();

                                for (int i = 0; i < dt.Columns.Count; i++)
                                {
                                    if (dt.Columns[i].DataType == typeof(DateTime))
                                    {
                                        dList.Add(i);
                                    }
                                }


                                dataGridView1.Invoke(new Action(() =>
                                {
                                    dataGridView1.DataSource = dt;

                                    if (dList.Any())
                                    {
                                        foreach (var item in dList)
                                        {
                                            dataGridView1.Columns[item].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss.fff";
                                        }
                                    }

                                    lbl_execute.Text = $"当前显示{(max > count ? count : max)}行，影响数据行数：{count} 耗时：{stopwatch.Elapsed.TotalSeconds} 秒";
                                }));
                            }
                        }
                        LoadForm.HideLoading();
                    }
                    catch (Exception ex)
                    {
                        LoadForm.HideLoading();
                        this.Invoke(new Action(() =>
                        {
                            MessageBox.Show(this, $"查询发生异常，ex:" + ex.Message);
                        }));
                    }
                }
                else
                {
                    try
                    {
                        var count = dbObject.ExecuteSql(ConnectionModel.Database, sql);

                        lbl_execute.Invoke(new Action(() =>
                        {
                            lbl_execute.Text = $"影响数据行数：{count} 耗时：{stopwatch.Elapsed.TotalMilliseconds} 毫秒";
                        }));

                        LoadForm.HideLoading();
                    }
                    catch (Exception ex)
                    {
                        LoadForm.HideLoading();
                        this.Invoke(new Action(() =>
                        {
                            MessageBox.Show(this, $"操作发生异常，ex:" + ex.Message);
                        }));
                    }
                }

            });
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cells = dataGridView1.SelectedCells;

            if (cells != null)
            {
                StringBuilder sb = new StringBuilder();

                foreach (DataGridViewCell cell in cells)
                {
                    if (cell == cells[cells.Count - 1])
                    {
                        sb.Append($"{cell.Value}");
                    }
                    else
                    {
                        sb.Append($"{cell.Value},");
                    }
                }

                Clipboard.SetText(sb.ToString());
            }
        }
    }
}

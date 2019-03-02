﻿/****************************************************************************
*项目名称：WEF.ModelGenerator.Forms
*CLR 版本：4.0.30319.42000
*机器名称：WENLI-PC
*命名空间：WEF.ModelGenerator.Forms
*类 名 称：SQLTemplateForm
*版 本 号：V1.0.0.0
*创建人： yswenli
*电子邮箱：wenguoli_520@qq.com
*创建时间：2019/2/19 9:35:47
*描述：
*=====================================================================
*修改时间：2019/2/19 9:35:47
*修 改 人： yswenli
*版 本 号： V1.0.0.0
*描    述：
*****************************************************************************/
using System;
using System.Diagnostics;
using System.Windows.Forms;
using WEF.ModelGenerator.Forms;

namespace WEF.ModelGenerator
{
    public partial class MainForm : CCWin.Skin_Mac
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region 打开数据库视图

        private void MainForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        LeftPanel lp = new LeftPanel();

        SQLTemplateForm sqlTemplateForm = new SQLTemplateForm();

        /// <summary>
        /// 左侧加载数据库列表
        /// </summary>
        private void Init()
        {
            lp.newcontentForm += new LeftPanel.NewContentForm(lp_newcontentForm);
            lp.newsqlForm += lp_newsqlForm;
            lp.Show(dpleft);
            lp.DockTo(dpleft, DockStyle.Left);

            sqlTemplateForm.Show(dpleft);
            sqlTemplateForm.DockTo(dpleft, DockStyle.Right);
        }

        /// <summary>
        /// 创建生成
        /// </summary>
        /// <param name="conModel"></param>
        /// <param name="tableName"></param>
        void lp_newcontentForm(WEF.ModelGenerator.Model.Connection conModel, string tableName, string databaseName, bool isView)
        {
            ContentForm s = new ContentForm();
            s.Text = "(" + databaseName + ")" + tableName;
            s.TableName = tableName;
            s.DatabaseName = databaseName;
            s.IsView = isView;
            s.ConnectionModel = conModel;
            s.Show(dpleft);
        }

        void lp_newsqlForm(WEF.ModelGenerator.Model.Connection conModel)
        {
            SQLForm s = new SQLForm();
            s.Text = "(" + conModel.Database + ")" + "sql查询窗口";
            s.ConnectionModel = conModel;
            s.Show(dpleft);
        }

        /// <summary>
        /// 数据库视图打开
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 数据库视图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lp.Show();
        }

        #endregion


        #region 菜单

        private void newDBConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lp.ShowDbSelect();
        }
        private void sQL查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var node = lp.Treeview.SelectedNode;

            if (node != null && node.Level == 2)
            {
                lp.ShowSQLForm();
            }
            else
                MessageBox.Show("请先选择具体数据库！");
        }

        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lp.ShowLogs();
        }

        #endregion

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/yswenli/WEF");
        }

        
    }
}

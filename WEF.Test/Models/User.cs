﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由WEF.ModelGenerator, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null生成;时间 2017-07-27 14:01:39.905
//     运行时版本:4.0.30319.42000
//     不建议手动更改此代码，如有需要请自行扩展partial类
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Runtime.Serialization;
using WEF;
using WEF.Common;
using WEF.Section;
using System.Collections.Generic;

namespace WEF.Models
{

    /// <summary>
    /// 实体类User
    /// </summary>
    [Serializable, DataContract]
    public partial class User : Entity
    {
        private static string m_tableName;
        public User() : base("User") { m_tableName = "User"; }
        public User(string tableName) : base(tableName) { m_tableName = tableName; }

        #region Model
        private Guid _ID;
        private string _ImUserID;
        private string _NickName;
        /// <summary>
        /// ID 
        /// </summary>
        [DataMember]
        public Guid ID
        {
            get
            {
                return _ID;
            }
            set
            {
                this.OnPropertyValueChange(_.ID, _ID, value);
                this._ID = value;
            }
        }
        /// <summary>
        /// ImUserID 
        /// </summary>
        [DataMember]
        public string ImUserID
        {
            get
            {
                return _ImUserID;
            }
            set
            {
                this.OnPropertyValueChange(_.ImUserID, _ImUserID, value);
                this._ImUserID = value;
            }
        }
        /// <summary>
        /// NickName 
        /// </summary>
        [DataMember]
        public string NickName
        {
            get
            {
                return _NickName;
            }
            set
            {
                this.OnPropertyValueChange(_.NickName, _NickName, value);
                this._NickName = value;
            }
        }
        #endregion

        #region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
                _.ID};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
                _.ID,
                _.ImUserID,
                _.NickName};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._ID,
                this._ImUserID,
                this._NickName};
        }
        #endregion

        #region _Field
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
            /// <summary>
            /// User 
            /// </summary>
            public readonly static Field All = new Field("*", m_tableName);
            /// <summary>
            /// ID 
            /// </summary>
            public readonly static Field ID = new Field("ID", m_tableName, "ID");
            /// <summary>
            /// ImUserID 
            /// </summary>
            public readonly static Field ImUserID = new Field("ImUserID", m_tableName, "ImUserID");
            /// <summary>
            /// NickName 
            /// </summary>
            public readonly static Field NickName = new Field("NickName", m_tableName, "NickName");
        }
        #endregion


    }
    /// <summary>
    /// 实体类User操作类
    /// </summary>
    public partial class UserRepository
    {
        DBContext db;
        /// <summary>
        /// 当前实体查询上下文
        /// </summary>
        public ISearch<User> Search(string tableName = "")
        {
            if (string.IsNullOrEmpty(tableName))
            {
                tableName = "User";
            }
            return db.Search<User>(tableName);
        }
        /// <summary>
        /// 构造方法
        /// </summary>
        public UserRepository()
        {
            db = new DBContext();
        }
        /// <summary>
        /// 构造方法
        /// <param name="connStrName">连接字符串中的名称</param>
        /// </summary>
        public UserRepository(string connStrName)
        {
            db = new DBContext(connStrName);
        }
        /// <summary>
        /// 当前db操作上下文
        /// </summary>
        public DBContext DBContext
        {
            get
            {
                return db;
            }
        }
        /// <summary>
        /// 获取列表
        /// <param name="pageIndex">分页第几页</param>
        /// <param name="pageSize">分页一页取值</param>
        /// </summary>
        public List<User> GetList(int pageIndex, int pageSize)
        {
            return this.Search().Page(pageIndex, pageSize).ToList();
        }
        /// <summary>
        /// 获取列表
        /// <param name="tableName">表名</param>
        /// <param name="pageIndex">分页第几页</param>
        /// <param name="pageSize">分页一页取值</param>
        /// </summary>
        public List<User> GetList(string tableName, int pageIndex = 1, int pageSize = 12)
        {
            return this.Search(tableName).Page(pageIndex, pageSize).ToList();
        }
        /// <summary>
        /// 添加实体
        /// <param name="obj">传进的实体</param>
        /// </summary>
        public int Insert(User obj)
        {
            return db.Insert(obj);
        }
        /// <summary>
        /// 更新实体
        /// <param name="obj">传进的实体</param>
        /// </summary>
        public int Update(User obj)
        {
            return db.Update(obj);
        }
        /// <summary>
        /// 删除实体
        /// <param name="obj">传进的实体</param>
        /// </summary>
        public int Delete(User obj)
        {
            return db.Delete(obj);
        }
        /// <summary>
        /// 批量删除实体
        /// <param name="obj">传进的实体列表</param>
        /// </summary>
        public int Deletes(List<User> objs)
        {
            return db.Delete<User>(objs);
        }
        /// <summary>
        /// 执行sql语句
        /// <param name="sql"></param>
        /// </summary>
        public SqlSection ExecuteSQL(string sql)
        {
            return db.FromSql(sql);
        }
        /// <summary>
        /// 执行存储过程
        /// <param name="sql"></param>
        /// </summary>
        public ProcSection ExcuteProc(string procName)
        {
            return db.FromProc(procName);
        }
    }

}


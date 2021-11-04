﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由WEF数据库工具, Version=3.8.6.6, Culture=neutral, PublicKeyToken=null生成;时间 2019-11-05 11:15:03.989
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
    /// 实体类Users
    /// </summary>
    [Serializable, DataContract, TableAttribute("Users")]
    public partial class Users : Entity
    {
        private static string m_tableName;
        public Users() : base("Users") { m_tableName = "Users"; }
        public Users(string tableName) : base(tableName) { m_tableName = tableName; }

        #region Model
        private long _Id;
        private string _Name;
        private string _Pwd;
        private DateTime _Created;
        /// <summary>
        /// Id 
        /// </summary>
        [DataMember]
        public long Id
        {
            get { return _Id; }
            set
            {
                this.OnPropertyValueChange(_.Id, _Id, value);
                this._Id = value;
            }
        }
        /// <summary>
        /// Name 
        /// </summary>
        [DataMember]
        public string Name
        {
            get { return _Name; }
            set
            {
                this.OnPropertyValueChange(_.Name, _Name, value);
                this._Name = value;
            }
        }
        /// <summary>
        /// Pwd 
        /// </summary>
        [DataMember]
        public string Pwd
        {
            get { return _Pwd; }
            set
            {
                this.OnPropertyValueChange(_.Pwd, _Pwd, value);
                this._Pwd = value;
            }
        }
        /// <summary>
        /// Created 
        /// </summary>
        [DataMember]
        public DateTime Created
        {
            get { return _Created; }
            set
            {
                this.OnPropertyValueChange(_.Created, _Created, value);
                this._Created = value;
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
                _.Id};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
                _.Id,
                _.Name,
                _.Pwd,
                _.Created};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._Id,
                this._Name,
                this._Pwd,
                this._Created};
        }
        #endregion

        #region _Field
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
            /// <summary>
            /// Users 
            /// </summary>
            public readonly static Field All = new Field("*", m_tableName);
            /// <summary>
            /// Id 
            /// </summary>
            public readonly static Field Id = new Field("id", m_tableName, "id");
            /// <summary>
            /// Name 
            /// </summary>
            public readonly static Field Name = new Field("name", m_tableName, "name");
            /// <summary>
            /// Pwd 
            /// </summary>
            public readonly static Field Pwd = new Field("pwd", m_tableName, "pwd");
            /// <summary>
            /// Created 
            /// </summary>
            public readonly static Field Created = new Field("created", m_tableName, "created");
        }
        #endregion


    }
    /// <summary>
    /// 实体类Users操作类
    /// </summary>
    public partial class UsersRepository : BaseRepository<Users>
    {
        DBContext db;
        /// <summary>
        /// 当前实体查询上下文
        /// </summary>
        public ISearch<Users> Search(string tableName = "")
        {
            if (string.IsNullOrEmpty(tableName))
            {
                tableName = "Users";
            }
            return db.Search<Users>(tableName);
        }
        /// <summary>
        /// 当前实体查询上下文
        /// </summary>
        public ISearch<Users> Search(Users entity)
        {
            return db.Search<Users>(entity);
        }
        /// <summary>
        /// 构造方法
        /// </summary>
        public UsersRepository()
        {
            db = new DBContext();
        }
        /// <summary>
        /// 构造方法
        /// </summary>
        public UsersRepository(DBContext dbContext)
        {
            db = dbContext;
        }
        /// <summary>
        /// 构造方法
        /// <param name="connStrName">连接字符串中的名称</param>
        /// </summary>
        public UsersRepository(string connStrName)
        {
            db = new DBContext(connStrName);
        }
        /// <summary>
        /// 构造方法
        /// <param name="dbType">数据库类型</param>
        /// <param name="connStr">连接字符串</param>
        /// </summary>
        public UsersRepository(DatabaseType dbType, string connStr)
        {
            db = new DBContext(dbType, connStr);
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
        /// 获取实体
        /// <param name="pageIndex">分页第几页</param>
        /// <param name="pageSize">分页一页取值</param>
        /// </summary>
        public Users GetUsers(long Id)
        {
            return Search().Where(b => b.Id == Id).First();
        }
        /// <summary>
        /// 获取列表
        /// <param name="pageIndex">分页第几页</param>
        /// <param name="pageSize">分页一页取值</param>
        /// </summary>
        public List<Users> GetList(int pageIndex, int pageSize)
        {
            return this.Search().Page(pageIndex, pageSize).ToList();
        }
        /// <summary>
        /// 获取列表
        /// <param name="tableName">表名</param>
        /// <param name="pageIndex">分页第几页</param>
        /// <param name="pageSize">分页一页取值</param>
        /// </summary>
        public List<Users> GetList(string tableName, int pageIndex = 1, int pageSize = 12)
        {
            return this.Search(tableName).Page(pageIndex, pageSize).ToList();
        }
        /// <summary>
        /// 添加实体
        /// <param name="obj">传进的实体</param>
        /// </summary>
        public int Insert(Users obj)
        {
            return db.Insert(obj);
        }
        /// <summary>
        /// 更新实体
        /// <param name="obj">传进的实体</param>
        /// </summary>
        public int Update(Users obj)
        {
            return db.Update(obj);
        }
        /// <summary>
        /// 删除实体
        /// <param name="obj">传进的实体</param>
        /// </summary>
        public int Delete(Users obj)
        {
            return db.Delete(obj);
        }
        /// <summary>
        /// 删除实体
        /// <param name="Id">Id</param>
        /// </summary>
        public int Delete(long Id)
        {
            var obj = Search().Where(b => b.Id == Id).First();
            return db.Delete(obj);
        }
        /// <summary>
        /// 批量删除实体
        /// <param name="obj">传进的实体列表</param>
        /// </summary>
        public int Deletes(List<Users> objs)
        {
            return db.Delete<Users>(objs);
        }
        /// <summary>
        /// 执行sql语句
        /// <param name="sql"></param>
        /// </summary>
        public SqlSection FromSql(string sql)
        {
            return db.FromSql(sql);
        }
        /// <summary>
        /// 执行存储过程
        /// <param name="sql"></param>
        /// </summary>
        public ProcSection FromProc(string procName)
        {
            return db.FromProc(procName);
        }
    }

}


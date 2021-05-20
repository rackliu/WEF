﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由WEF数据库工具, Version=5.0.0.2, Culture=neutral, PublicKeyToken=null生成;时间 2020-09-21 18:07:06.231
//     运行时版本:4.0.30319.42000
//     不建议手动更改此代码，如有需要请自行扩展partial类
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using WEF.Common;
using WEF.MvcPager;
using WEF.Section;

namespace WEF.Test.Models
{

    /// <summary>
    /// 实体类LiveLog
    /// </summary>
    [Serializable, DataContract, Table("LiveLog")]
    public partial class LiveLog : Entity
    {
        private static string m_tableName;
        public LiveLog() : base("LiveLog") { m_tableName = "LiveLog"; }
        public LiveLog(string tableName) : base(tableName) { m_tableName = tableName; }

        #region Model
        private int _ID;
        private DateTime? _Datetime;
        private string _IP;
        private string _Url;
        private string _Parmas;
        private string _Json;
        private string _SourceIP;
        private string _UserID;
        private string _Device;
        private DateTime? _SortTime;
        private string _MethodName;
        private string _ServiceName;
        private int _ServiceNameType;
        private int? _EnvironmentIdent;
        /// <summary>
        /// ID 
        /// </summary>
        [DataMember]
        public int ID
        {
            get { return _ID; }
            set
            {
                this.OnPropertyValueChange(_.ID, _ID, value);
                this._ID = value;
            }
        }
        /// <summary>
        /// Datetime 
        /// </summary>
        [DataMember]
        public DateTime? Datetime
        {
            get { return _Datetime; }
            set
            {
                this.OnPropertyValueChange(_.Datetime, _Datetime, value);
                this._Datetime = value;
            }
        }
        /// <summary>
        /// IP 
        /// </summary>
        [DataMember]
        public string IP
        {
            get { return _IP; }
            set
            {
                this.OnPropertyValueChange(_.IP, _IP, value);
                this._IP = value;
            }
        }
        /// <summary>
        /// Url 
        /// </summary>
        [DataMember]
        public string Url
        {
            get { return _Url; }
            set
            {
                this.OnPropertyValueChange(_.Url, _Url, value);
                this._Url = value;
            }
        }
        /// <summary>
        /// Parmas 
        /// </summary>
        [DataMember]
        public string Parmas
        {
            get { return _Parmas; }
            set
            {
                this.OnPropertyValueChange(_.Parmas, _Parmas, value);
                this._Parmas = value;
            }
        }
        /// <summary>
        /// Json 
        /// </summary>
        [DataMember]
        public string Json
        {
            get { return _Json; }
            set
            {
                this.OnPropertyValueChange(_.Json, _Json, value);
                this._Json = value;
            }
        }
        /// <summary>
        /// SourceIP 
        /// </summary>
        [DataMember]
        public string SourceIP
        {
            get { return _SourceIP; }
            set
            {
                this.OnPropertyValueChange(_.SourceIP, _SourceIP, value);
                this._SourceIP = value;
            }
        }
        /// <summary>
        /// UserID 
        /// </summary>
        [DataMember]
        public string UserID
        {
            get { return _UserID; }
            set
            {
                this.OnPropertyValueChange(_.UserID, _UserID, value);
                this._UserID = value;
            }
        }
        /// <summary>
        /// Device 
        /// </summary>
        [DataMember]
        public string Device
        {
            get { return _Device; }
            set
            {
                this.OnPropertyValueChange(_.Device, _Device, value);
                this._Device = value;
            }
        }
        /// <summary>
        /// SortTime 
        /// </summary>
        [DataMember]
        public DateTime? SortTime
        {
            get { return _SortTime; }
            set
            {
                this.OnPropertyValueChange(_.SortTime, _SortTime, value);
                this._SortTime = value;
            }
        }
        /// <summary>
        /// MethodName 
        /// </summary>
        [DataMember]
        public string MethodName
        {
            get { return _MethodName; }
            set
            {
                this.OnPropertyValueChange(_.MethodName, _MethodName, value);
                this._MethodName = value;
            }
        }
        /// <summary>
        /// ServiceName 
        /// </summary>
        [DataMember]
        public string ServiceName
        {
            get { return _ServiceName; }
            set
            {
                this.OnPropertyValueChange(_.ServiceName, _ServiceName, value);
                this._ServiceName = value;
            }
        }
        /// <summary>
        /// ServiceNameType 
        /// </summary>
        [DataMember]
        public int ServiceNameType
        {
            get { return _ServiceNameType; }
            set
            {
                this.OnPropertyValueChange(_.ServiceNameType, _ServiceNameType, value);
                this._ServiceNameType = value;
            }
        }
        /// <summary>
        /// EnvironmentIdent 
        /// </summary>
        [DataMember]
        public int? EnvironmentIdent
        {
            get { return _EnvironmentIdent; }
            set
            {
                this.OnPropertyValueChange(_.EnvironmentIdent, _EnvironmentIdent, value);
                this._EnvironmentIdent = value;
            }
        }
        #endregion

        #region Method
        /// <summary>
        /// 获取实体中的标识列
        /// </summary>
        public override Field GetIdentityField()
        {
            return _.ID;
        }
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
                _.Datetime,
                _.IP,
                _.Url,
                _.Parmas,
                _.Json,
                _.SourceIP,
                _.UserID,
                _.Device,
                _.SortTime,
                _.MethodName,
                _.ServiceName,
                _.ServiceNameType,
                _.EnvironmentIdent};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._ID,
                this._Datetime,
                this._IP,
                this._Url,
                this._Parmas,
                this._Json,
                this._SourceIP,
                this._UserID,
                this._Device,
                this._SortTime,
                this._MethodName,
                this._ServiceName,
                this._ServiceNameType,
                this._EnvironmentIdent};
        }
        #endregion

        #region _Field
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
            /// <summary>
            /// LiveLog 
            /// </summary>
            public readonly static Field All = new Field("*", m_tableName);
            /// <summary>
            /// ID 
            /// </summary>
            public readonly static Field ID = new Field("ID", m_tableName, "ID");
            /// <summary>
            /// Datetime 
            /// </summary>
            public readonly static Field Datetime = new Field("Datetime", m_tableName, "Datetime");
            /// <summary>
            /// IP 
            /// </summary>
            public readonly static Field IP = new Field("IP", m_tableName, "IP");
            /// <summary>
            /// Url 
            /// </summary>
            public readonly static Field Url = new Field("Url", m_tableName, "Url");
            /// <summary>
            /// Parmas 
            /// </summary>
            public readonly static Field Parmas = new Field("Parmas", m_tableName, "Parmas");
            /// <summary>
            /// Json 
            /// </summary>
            public readonly static Field Json = new Field("Json", m_tableName, "Json");
            /// <summary>
            /// SourceIP 
            /// </summary>
            public readonly static Field SourceIP = new Field("SourceIP", m_tableName, "SourceIP");
            /// <summary>
            /// UserID 
            /// </summary>
            public readonly static Field UserID = new Field("UserID", m_tableName, "UserID");
            /// <summary>
            /// Device 
            /// </summary>
            public readonly static Field Device = new Field("Device", m_tableName, "Device");
            /// <summary>
            /// SortTime 
            /// </summary>
            public readonly static Field SortTime = new Field("SortTime", m_tableName, "SortTime");
            /// <summary>
            /// MethodName 
            /// </summary>
            public readonly static Field MethodName = new Field("MethodName", m_tableName, "MethodName");
            /// <summary>
            /// ServiceName 
            /// </summary>
            public readonly static Field ServiceName = new Field("ServiceName", m_tableName, "ServiceName");
            /// <summary>
            /// ServiceNameType 
            /// </summary>
            public readonly static Field ServiceNameType = new Field("ServiceNameType", m_tableName, "ServiceNameType");
            /// <summary>
            /// EnvironmentIdent 
            /// </summary>
            public readonly static Field EnvironmentIdent = new Field("EnvironmentIdent", m_tableName, "EnvironmentIdent");
        }
        #endregion


    }
    /// <summary>
    /// 实体类LiveLog操作类
    /// </summary>
    public partial class LiveLogRepository : IRepository<LiveLog>
    {
        DBContext db;
        /// <summary>
        /// 构造方法
        /// </summary>
        public LiveLogRepository()
        {
            db = new DBContext();
        }
        /// <summary>
        /// 构造方法
        /// </summary>
        public LiveLogRepository(DBContext dbContext)
        {
            db = dbContext;
        }
        /// <summary>
        /// 构造方法
        /// <param name="connStrName">连接字符串中的名称</param>
        /// </summary>
        public LiveLogRepository(string connStrName)
        {
            db = new DBContext(connStrName);
        }
        /// <summary>
        /// 构造方法
        /// <param name="dbType">数据库类型</param>
        /// <param name="connStr">连接字符串</param>
        /// </summary>
        public LiveLogRepository(DatabaseType dbType, string connStr)
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
        /// 总数
        /// </summary>
        /// <returns></returns>
        public int Total
        {
            get
            {
                return Search().Count();
            }
        }
        /// <summary>
        /// 当前实体查询上下文
        /// </summary>
        public ISearch<LiveLog> Search(string tableName = "")
        {
            if (string.IsNullOrEmpty(tableName))
            {
                tableName = "LiveLog";
            }
            return db.Search<LiveLog>(tableName);
        }
        /// <summary>
        /// 当前实体查询上下文
        /// </summary>
        public ISearch<LiveLog> Search(LiveLog entity)
        {
            return db.Search<LiveLog>(entity);
        }
        /// <summary>
        /// 获取实体
        /// <param name="ID">ID</param>
        /// <param name="tableName">表名</param>
        /// </summary>
        /// <returns></returns>
        public LiveLog GetLiveLog(int ID, string tableName = "")
        {
            return Search(tableName).Where(b => b.ID == ID).First();
        }
        /// <summary>
        /// 获取列表
        /// <param name="pageIndex">分页第几页</param>
        /// <param name="pageSize">分页一页取值</param>
        /// </summary>
        /// <returns></returns>
        public List<LiveLog> GetList(int pageIndex, int pageSize)
        {
            return this.Search().Page(pageIndex, pageSize).ToList();
        }
        /// <summary>
        /// 获取列表
        /// <param name="tableName">表名</param>
        /// <param name="pageIndex">分页第几页</param>
        /// <param name="pageSize">分页一页取值</param>
        /// </summary>
        /// <returns></returns>
        public List<LiveLog> GetList(string tableName, int pageIndex = 1, int pageSize = 12)
        {
            return this.Search(tableName).Page(pageIndex, pageSize).ToList();
        }
        /// <summary>
        /// 分页查询
        /// <param name="lambdaWhere">查询表达式</param>
        /// <param name="pageIndex">分页第几页</param>
        /// <param name="pageSize">分页一页取值</param>
        /// <param name="orderBy">排序</param>
        /// <param name="asc">升降</param>
        /// </summary>
        /// <returns></returns>
        public PagedList<LiveLog> GetPagedList(Expression<Func<LiveLog, bool>> lambdaWhere, string tableName = "", int pageIndex = 1, int pageSize = 12, string orderBy = "ID", bool asc = true)
        {
            return this.Search(tableName).GetPagedList(lambdaWhere, pageIndex, pageSize, orderBy, asc);
        }
        /// <summary>
        /// 添加实体
        /// <param name="entity">传进的实体</param>
        /// </summary>
        public int Insert(LiveLog entity)
        {
            return db.Insert(entity);
        }
        /// <summary>
        /// 批量添加实体
        /// <param name="entities">传进的实体列表</param>
        /// </summary>
        public int Insert(IEnumerable<LiveLog> entities)
        {
            return db.Insert(entities);
        }
        /// <summary>
        /// 更新实体
        /// <param name="entity">传进的实体</param>
        /// </summary>
        public int Update(LiveLog entity)
        {
            return db.Update(entity);
        }
        /// <summary>
        /// 更新实体
        /// <param name="entities">传进的实体</param>
        /// </summary>
        public int Update(IEnumerable<LiveLog> entities)
        {
            return db.Update(entities);
        }
        /// <summary>
        /// 删除实体
        /// <param name="entity">传进的实体</param>
        /// </summary>
        public int Delete(LiveLog entity)
        {
            return db.Delete(entity);
        }
        /// <summary>
        /// 批量删除实体
        /// <param name="obj">传进的实体列表</param>
        /// </summary>
        public int Deletes(List<LiveLog> entities)
        {
            return db.Delete<LiveLog>(entities);
        }
        /// <summary>
        /// 持久化实体
        /// <param name="entity">传进的实体</param>
        /// </summary>
        public int Save(LiveLog entity)
        {
            return db.Save<LiveLog>(entity);
        }
        /// <summary>
        /// 批量持久化实体
        /// <param name="entities">传进的实体列表</param>
        /// </summary>
        public int Save(List<LiveLog> entities)
        {
            return db.Save<LiveLog>(entities);
        }
        /// <summary>
        /// 持久化实体
        /// <param name="tran">事务</param>
        /// <param name="entity">传进的实体</param>
        /// </summary>
        public int Save(DbTransaction tran, LiveLog entity)
        {
            return db.Save<LiveLog>(tran, entity);
        }
        /// <summary>
        /// 批量持久化实体
        /// <param name="tran">事务</param>
        /// <param name="entity">传进的实体列表</param>
        /// </summary>
        public int Save(DbTransaction tran, List<LiveLog> entities)
        {
            return db.Save<LiveLog>(tran, entities);
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


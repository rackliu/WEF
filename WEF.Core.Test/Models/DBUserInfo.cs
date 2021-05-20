﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由WEF数据库工具, Version=5.0.0.3, Culture=neutral, PublicKeyToken=null生成;时间 2021-04-06 17:09:03.844
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

namespace WEF.Core.Test.Models
{

    /// <summary>
    /// 实体类DBUserInfo
    /// </summary>
    [Serializable, DataContract, Table("userinfo")]
	public partial class DBUserInfo : Entity
	{
		private static string m_tableName;
		public DBUserInfo() : base("userinfo") { m_tableName = "userinfo"; }
		public DBUserInfo(string tableName) : base(tableName) { m_tableName = tableName; }

		#region Model
		private int _Id;
		private string _UserName;
		private string _NickName;
		private bool? _Gender;
		private DateTime _Created;
		/// <summary>
		/// Id auto_increment
		/// </summary>
		[DataMember]
		public int Id
		{
			get { return _Id; }
			set
			{
				this.OnPropertyValueChange(_.Id, _Id, value);
				this._Id = value;
			}
		}
		/// <summary>
		/// UserName 
		/// </summary>
		[DataMember]
		public string UserName
		{
			get { return _UserName; }
			set
			{
				this.OnPropertyValueChange(_.UserName, _UserName, value);
				this._UserName = value;
			}
		}
		/// <summary>
		/// NickName 
		/// </summary>
		[DataMember]
		public string NickName
		{
			get { return _NickName; }
			set
			{
				this.OnPropertyValueChange(_.NickName, _NickName, value);
				this._NickName = value;
			}
		}
		/// <summary>
		/// Gender 
		/// </summary>
		[DataMember]
		public bool? Gender
		{
			get { return _Gender; }
			set
			{
				this.OnPropertyValueChange(_.Gender, _Gender, value);
				this._Gender = value;
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
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.Id;
		}
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
				_.UserName,
				_.NickName,
				_.Gender,
				_.Created};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Id,
				this._UserName,
				this._NickName,
				this._Gender,
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
			/// userinfo 
			/// </summary>
			public readonly static Field All = new Field("*", m_tableName);
			/// <summary>
			/// Id auto_increment
			/// </summary>
			public readonly static Field Id = new Field("id", m_tableName, "auto_increment");
			/// <summary>
			/// UserName 
			/// </summary>
			public readonly static Field UserName = new Field("userName", m_tableName, "userName");
			/// <summary>
			/// NickName 
			/// </summary>
			public readonly static Field NickName = new Field("nickName", m_tableName, "nickName");
			/// <summary>
			/// Gender 
			/// </summary>
			public readonly static Field Gender = new Field("gender", m_tableName, "gender");
			/// <summary>
			/// Created 
			/// </summary>
			public readonly static Field Created = new Field("created", m_tableName, "created");
		}
		#endregion


	}
	/// <summary>
	/// 实体类DBUserInfo操作类
	/// </summary>
	public partial class DBUserInfoRepository : IRepository<DBUserInfo>
	{
		DBContext db;
		/// <summary>
		/// 构造方法
		/// </summary>
		public DBUserInfoRepository()
		{
			db = new DBContext();
		}
		/// <summary>
		/// 构造方法
		/// </summary>
		public DBUserInfoRepository(DBContext dbContext)
		{
			db = dbContext;
		}
		/// <summary>
		/// 构造方法
		/// <param name="connStrName">连接字符串中的名称</param>
		/// </summary>
		public DBUserInfoRepository(string connStrName)
		{
			db = new DBContext(connStrName);
		}
		/// <summary>
		/// 构造方法
		/// <param name="dbType">数据库类型</param>
		/// <param name="connStr">连接字符串</param>
		/// </summary>
		public DBUserInfoRepository(DatabaseType dbType, string connStr)
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
		public ISearch<DBUserInfo> Search(string tableName = "")
		{
			if (string.IsNullOrEmpty(tableName))
			{
				tableName = "userinfo";
			}
			return db.Search<DBUserInfo>(tableName);
		}
		/// <summary>
		/// 当前实体查询上下文
		/// </summary>
		public ISearch<DBUserInfo> Search(DBUserInfo entity)
		{
			return db.Search<DBUserInfo>(entity);
		}
		/// <summary>
		/// 获取实体
		/// <param name="Id">Id</param>
		/// <param name="tableName">表名</param>
		/// </summary>
		/// <returns></returns>
		public DBUserInfo GetDBUserInfo(int Id, string tableName = "")
		{
			return Search(tableName).Where(b => b.Id == Id).First();
		}
		/// <summary>
		/// 获取列表
		/// <param name="pageIndex">分页第几页</param>
		/// <param name="pageSize">分页一页取值</param>
		/// </summary>
		/// <returns></returns>
		public List<DBUserInfo> GetList(int pageIndex, int pageSize)
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
		public List<DBUserInfo> GetList(string tableName, int pageIndex = 1, int pageSize = 12)
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
		public PagedList<DBUserInfo> GetPagedList(Expression<Func<DBUserInfo, bool>> lambdaWhere, string tableName = "", int pageIndex = 1, int pageSize = 12, string orderBy = "Id", bool asc = true)
		{
			return this.Search(tableName).GetPagedList(lambdaWhere, pageIndex, pageSize, orderBy, asc);
		}
		/// <summary>
		/// 添加实体
		/// <param name="entity">传进的实体</param>
		/// </summary>
		public int Insert(DBUserInfo entity)
		{
			return db.Insert(entity);
		}
		/// <summary>
		/// 批量添加实体
		/// <param name="entities">传进的实体列表</param>
		/// </summary>
		public void BulkInsert(IEnumerable<DBUserInfo> entities)
		{
			db.BulkInsert(entities);
		}
		/// <summary>
		/// 更新实体
		/// <param name="entity">传进的实体</param>
		/// </summary>
		public int Update(DBUserInfo entity)
		{
			return db.Update(entity);
		}
		/// <summary>
		/// 更新实体
		/// <param name="entities">传进的实体</param>
		/// </summary>
		public int Update(IEnumerable<DBUserInfo> entities)
		{
			return db.Update(entities);
		}
		/// <summary>
		/// 删除实体
		/// <param name="entity">传进的实体</param>
		/// </summary>
		public int Delete(DBUserInfo entity)
		{
			return db.Delete(entity);
		}
		/// <summary>
		/// 批量删除实体
		/// <param name="obj">传进的实体列表</param>
		/// </summary>
		public int Deletes(List<DBUserInfo> entities)
		{
			return db.Delete<DBUserInfo>(entities);
		}
		/// <summary>
		/// 持久化实体
		/// <param name="entity">传进的实体</param>
		/// </summary>
		public int Save(DBUserInfo entity)
		{
			return db.Save<DBUserInfo>(entity);
		}
		/// <summary>
		/// 批量持久化实体
		/// <param name="entities">传进的实体列表</param>
		/// </summary>
		public int Save(List<DBUserInfo> entities)
		{
			return db.Save<DBUserInfo>(entities);
		}
		/// <summary>
		/// 持久化实体
		/// <param name="tran">事务</param>
		/// <param name="entity">传进的实体</param>
		/// </summary>
		public int Save(DbTransaction tran, DBUserInfo entity)
		{
			return db.Save<DBUserInfo>(tran, entity);
		}
		/// <summary>
		/// 批量持久化实体
		/// <param name="tran">事务</param>
		/// <param name="entity">传进的实体列表</param>
		/// </summary>
		public int Save(DbTransaction tran, List<DBUserInfo> entities)
		{
			return db.Save<DBUserInfo>(tran, entities);
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


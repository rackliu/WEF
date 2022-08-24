﻿/****************************************************************************
*项目名称：WEF.Test
*CLR 版本：4.0.30319.42000
*机器名称：WALLE-PC
*命名空间：WEF.Test
*类 名 称：MutiTablesTest
*版 本 号：V1.0.0.0
*创建人： yswenli
*电子邮箱：yswenli@outlook.com
*创建时间：2020/7/30 9:48:31
*描述：
*=====================================================================
*修改时间：2020/7/30 9:48:31
*修 改 人： yswenli
*版 本 号： V1.0.0.0
*描    述：
*****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Text;

using WEF.Common;
using WEF.MvcPager;
using WEF.Section;

namespace WEF.Test
{
    class MutiTablesTest
    {
        public static void Test()
        {
            Console.ReadLine();

            var rr = new RulesRepository();

            //rr.Insert(new Rules("rules")
            //{
            //    name = "MutiTablesTest4",
            //    created = DateTime.Now,
            //    enabled = true,
            //    json = "",
            //    ruleType = -1,
            //    score = 0,
            //    updated = DateTime.Now
            //});

            var list1 = rr.Search().Where(b => b.enabled == true).ToList();

            var count1 = rr.Search().Count();

            var count2 = rr.Search().Where(b => b.id > 0).Count(b => b.id);

            var pagedlist = rr.GetPagedList(b => b.id > 0);

            //sql转自定义实体
            var rrt1 = rr.FromSql("select * from rules where id=?id").AddInParameter("?id", System.Data.DbType.Int32, 1).ToList<RR>();

            var rrt2 = rr.FromSql("select * from rules").ToList<RR>();


            #region test

            var uid = "5626094170055838";

            var pageIndex = 1;

            var pageSize = 12;

            var count = 0;

            var dbContext = new DBContext();

            var sql = $"select user_recoreds.uid, sum(score) Score from rules right join user_recoreds on rules.id=user_recoreds.rid where uid=?uid1 group by user_recoreds.uid order by Score desc limit {(pageIndex - 1) * pageSize},{pageSize}";

            var sqlCount = "select count(a.uid) from (select user_recoreds.uid, sum(score) Score from rules right join user_recoreds on rules.id=user_recoreds.rid where uid=?uid1 group by user_recoreds.uid) a";

            var userScoreModels1 = dbContext.FromSql(sql).AddInParameter("?uid1", System.Data.DbType.StringFixedLength, 250, uid).ToList<UserScoreModel>();

            var p = dbContext.CreateParameter("?uid1", System.Data.DbType.StringFixedLength, 250, uid);

            int.TryParse(dbContext.ExecuteScalar(sqlCount, p)?.ToString(), out count);

            var sql2 = $"select user_recoreds.uid, sum(score) Score from rules right join user_recoreds on rules.id=user_recoreds.rid group by user_recoreds.uid order by Score desc limit {(pageIndex - 1) * pageSize},{pageSize}";

            var userScoreModels2 = dbContext.FromSql(sql).AddInParameter("?uid1", System.Data.DbType.StringFixedLength, 250, uid).ToList<UserScoreModel>();

            #endregion


            var list2 = rr.Search("rules1").Where(b => b.enabled == true).ToList();

            var list3 = rr.Search("rules1").Where(b => b.enabled == true).ToPagedList(1, 20, "id", true);

            var st1 = rr.Search("rules1").Where(b => b.enabled == true).First();

            var st2 = rr.Search().Where(b => b.enabled == true).First();

            var st11 = new Rules("rules1");

            st1.FillEntity(ref st11);

            st11.name = "update";

            rr.Update(st11);

            st1 = rr.Search("rules1").Where(b => b.enabled == true).First();

            rr.Delete(st1);

            Console.ReadLine();
        }

    }

    public class RR
    {
        public int ID
        {
            get; set;
        }

        public string Name { get; set; }
    }

    #region MyRegion


    //------------------------------------------------------------------------------
    // <auto-generated>
    //     此代码由WEF数据库工具, Version=4.2.0.2, Culture=neutral, PublicKeyToken=null生成;时间 2020-08-04 13:16:49.891
    //     运行时版本:4.0.30319.42000
    //     不建议手动更改此代码，如有需要请自行扩展partial类
    // </auto-generated>
    //------------------------------------------------------------------------------


    /// <summary>
    /// 实体类Rules
    /// </summary>
    [Serializable, DataContract, Table("rules")]
    public partial class Rules : Entity
    {
        private static string m_tableName;
        public Rules() : base("rules") { m_tableName = "rules"; }
        public Rules(string tableName) : base(tableName) { m_tableName = tableName; }

        #region Model
        private int _id;
        private string _name;
        private int _ruleType;
        private string _json;
        private int? _score;
        private bool? _enabled;
        private DateTime _created;
        private DateTime _updated;
        /// <summary>
        /// id auto_increment
        /// </summary>
        [DataMember, Description("")]
        public int id
        {
            get { return _id; }
            set
            {
                this.OnPropertyValueChange(_.id, _id, value);
                this._id = value;
            }
        }
        /// <summary>
        /// name 
        /// </summary>
        [DataMember]
        public string name
        {
            get { return _name; }
            set
            {
                this.OnPropertyValueChange(_.name, _name, value);
                this._name = value;
            }
        }
        /// <summary>
        /// ruleType 
        /// </summary>
        [DataMember]
        public int ruleType
        {
            get { return _ruleType; }
            set
            {
                this.OnPropertyValueChange(_.ruleType, _ruleType, value);
                this._ruleType = value;
            }
        }
        /// <summary>
        /// json 
        /// </summary>
        [DataMember]
        public string json
        {
            get { return _json; }
            set
            {
                this.OnPropertyValueChange(_.json, _json, value);
                this._json = value;
            }
        }
        /// <summary>
        /// score 
        /// </summary>
        [DataMember]
        public int? score
        {
            get { return _score; }
            set
            {
                this.OnPropertyValueChange(_.score, _score, value);
                this._score = value;
            }
        }
        /// <summary>
        /// enabled 
        /// </summary>
        [DataMember]
        public bool? enabled
        {
            get { return _enabled; }
            set
            {
                this.OnPropertyValueChange(_.enabled, _enabled, value);
                this._enabled = value;
            }
        }
        /// <summary>
        /// created 
        /// </summary>
        [DataMember]
        public DateTime created
        {
            get { return _created; }
            set
            {
                this.OnPropertyValueChange(_.created, _created, value);
                this._created = value;
            }
        }
        /// <summary>
        /// updated 
        /// </summary>
        [DataMember]
        public DateTime updated
        {
            get { return _updated; }
            set
            {
                this.OnPropertyValueChange(_.updated, _updated, value);
                this._updated = value;
            }
        }
        #endregion

        #region Method
        /// <summary>
        /// 获取实体中的标识列
        /// </summary>
        public override Field GetIdentityField()
        {
            return _.id;
        }
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
                _.id};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
                _.id,
                _.name,
                _.ruleType,
                _.json,
                _.score,
                _.enabled,
                _.created,
                _.updated};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._id,
                this._name,
                this._ruleType,
                this._json,
                this._score,
                this._enabled,
                this._created,
                this._updated};
        }
        #endregion

        #region _Field
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
            /// <summary>
            /// rules 
            /// </summary>
            public readonly static Field All = new Field("*", m_tableName);
            /// <summary>
            /// id auto_increment
            /// </summary>
            public readonly static Field id = new Field("id", m_tableName, "auto_increment");
            /// <summary>
            /// name 
            /// </summary>
            public readonly static Field name = new Field("name", m_tableName, "name");
            /// <summary>
            /// ruleType 
            /// </summary>
            public readonly static Field ruleType = new Field("ruleType", m_tableName, "ruleType");
            /// <summary>
            /// json 
            /// </summary>
            public readonly static Field json = new Field("json", m_tableName, "json");
            /// <summary>
            /// score 
            /// </summary>
            public readonly static Field score = new Field("score", m_tableName, "score");
            /// <summary>
            /// enabled 
            /// </summary>
            public readonly static Field enabled = new Field("enabled", m_tableName, "enabled");
            /// <summary>
            /// created 
            /// </summary>
            public readonly static Field created = new Field("created", m_tableName, "created");
            /// <summary>
            /// updated 
            /// </summary>
            public readonly static Field updated = new Field("updated", m_tableName, "updated");
        }
        #endregion


    }
    /// <summary>
    /// 实体类Rules操作类
    /// </summary>
    public partial class RulesRepository : BaseRepository<Rules>
    {
        DBContext db;
        /// <summary>
        /// 构造方法
        /// </summary>
        public RulesRepository()
        {
            db = new DBContext();
        }
        /// <summary>
        /// 构造方法
        /// </summary>
        public RulesRepository(DBContext dbContext)
        {
            db = dbContext;
        }
        /// <summary>
        /// 构造方法
        /// <param name="connStrName">连接字符串中的名称</param>
        /// </summary>
        public RulesRepository(string connStrName)
        {
            db = new DBContext(connStrName);
        }
        /// <summary>
        /// 构造方法
        /// <param name="dbType">数据库类型</param>
        /// <param name="connStr">连接字符串</param>
        /// </summary>
        public RulesRepository(DatabaseType dbType, string connStr)
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
        public ISearch<Rules> Search(string tableName = "")
        {
            if (string.IsNullOrEmpty(tableName))
            {
                tableName = "rules";
            }
            return db.Search<Rules>(tableName);
        }
        /// <summary>
        /// 当前实体查询上下文
        /// </summary>
        public ISearch<Rules> Search(Rules entity)
        {
            return db.Search<Rules>(entity);
        }
        /// <summary>
        /// 获取实体
        /// <param name="id">id</param>
        /// <param name="tableName">表名</param>
        /// </summary>
        /// <returns></returns>
        public Rules GetRules(int id, string tableName = "")
        {
            return Search(tableName).Where(b => b.id == id).First();
        }
        /// <summary>
        /// 获取列表
        /// <param name="pageIndex">分页第几页</param>
        /// <param name="pageSize">分页一页取值</param>
        /// </summary>
        /// <returns></returns>
        public List<Rules> GetList(int pageIndex, int pageSize)
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
        public List<Rules> GetList(string tableName, int pageIndex = 1, int pageSize = 12)
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
        public PagedList<Rules> GetPagedList(Expression<Func<Rules, bool>> lambdaWhere, string tableName = "", int pageIndex = 1, int pageSize = 12, string orderBy = "id", bool asc = true)
        {
            return this.Search(tableName).ToPagedList(lambdaWhere, pageIndex, pageSize, orderBy, asc);
        }
        /// <summary>
        /// 添加实体
        /// <param name="entity">传进的实体</param>
        /// </summary>
        public int Insert(Rules entity)
        {
            return db.Insert(entity);
        }
        /// <summary>
        /// 更新实体
        /// <param name="entity">传进的实体</param>
        /// </summary>
        public int Update(Rules entity)
        {
            return db.Update(entity);
        }
        /// <summary>
        /// 删除实体
        /// <param name="entity">传进的实体</param>
        /// </summary>
        public int Delete(Rules entity)
        {
            return db.Delete(entity);
        }
        /// <summary>
        /// 删除实体
        /// <param name="id">id</param>
        /// <param name="tableName">tableName</param>
        /// </summary>
        public int Delete(int id, string tableName = "")
        {
            var entity = Search(tableName).Where(b => b.id == id).First();
            if (entity == null) return -1;
            entity.Attach(EntityState.Deleted);
            return db.Save(entity);
        }
        /// <summary>
        /// 批量删除实体
        /// <param name="obj">传进的实体列表</param>
        /// </summary>
        public int Deletes(List<Rules> entities)
        {
            return db.Delete<Rules>(entities);
        }
        /// <summary>
        /// 持久化实体
        /// <param name="entity">传进的实体</param>
        /// </summary>
        public int Save(Rules entity)
        {
            return db.Save<Rules>(entity);
        }
        /// <summary>
        /// 批量持久化实体
        /// <param name="entities">传进的实体列表</param>
        /// </summary>
        public int Save(List<Rules> entities)
        {
            return db.Save<Rules>(entities);
        }
        /// <summary>
        /// 持久化实体
        /// <param name="tran">事务</param>
        /// <param name="entity">传进的实体</param>
        /// </summary>
        public int Save(DbTransaction tran, Rules entity)
        {
            return db.Save<Rules>(tran, entity);
        }
        /// <summary>
        /// 批量持久化实体
        /// <param name="tran">事务</param>
        /// <param name="entity">传进的实体列表</param>
        /// </summary>
        public int Save(DbTransaction tran, List<Rules> entities)
        {
            return db.Save<Rules>(tran, entities);
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

        public int Deletes(IEnumerable<Rules> objs)
        {
            throw new NotImplementedException();
        }
    }


    [DataContract]
    public class UserScoreModel
    {
        /// <summary>
        /// 通行证用户
        /// </summary>
        [DataMember]
        public string Uid { get; set; }
        /// <summary>
        /// 积分
        /// </summary>
        [DataMember]
        public long Score { get; set; }
    }


    #endregion
}


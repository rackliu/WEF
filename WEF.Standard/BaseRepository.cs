﻿/****************************************************************************
*Copyright (c) 2021 Oceania All Rights Reserved.
*CLR版本： 4.0.30319.42000
*机器名称：LP20210416002
*公司名称：Oceania
*命名空间：WEF
*文件名： BaseRepository
*版本号： V1.0.0.0
*唯一标识：565b31a1-4753-4ffb-bbae-f0dc1eae1b38
*当前的用户域：OCEANIA
*创建人： Mason.Wen
*电子邮箱：Mason.Wen@oceania-inc.com
*创建时间：2019/5/20 15:11:37
*描述：
*
*=====================================================================
*修改标记
*修改时间：2022/9/14 15:11:37
*修改人： Mason.Wen
*版本号： V1.0.0.0
*描述：
*
*****************************************************************************/
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;

using WEF.Common;
using WEF.Db;
using WEF.Expressions;
using WEF.MvcPager;
using WEF.Section;

namespace WEF
{
    /// <summary>
    /// Repository基础类，具体业务可以继承此类，或直接使用此类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseRepository<T> : IDisposable
        where T : Entity, new()
    {
        /// <summary>
        /// DBContext
        /// </summary>
        protected DBContext _dbContext;

        private T _entity;

        /// <summary>
        /// Repository基础类，具体业务可以继承此类，或直接使用此类
        /// </summary>
        public BaseRepository(DBContext dbContext) : base()
        {
            _dbContext = dbContext;

            _entity = new T();
        }

        /// <summary>
        /// Repository基础类，具体业务可以继承此类，或直接使用此类
        /// </summary>
        public BaseRepository() : this(new DBContext())
        {

        }

        /// <summary>
        /// Repository基础类，具体业务可以继承此类，或直接使用此类
        /// <param name="connStrName">连接字符串中的名称</param>
        /// </summary>
        public BaseRepository(string connStrName) : this(new DBContext(connStrName))
        {

        }

        /// <summary>
        /// Repository基础类，具体业务可以继承此类，或直接使用此类
        /// <param name="dbType">数据库类型</param>
        /// <param name="connStr">连接字符串</param>
        /// </summary>
        public BaseRepository(DatabaseType dbType, string connStr) : this(new DBContext(dbType, connStr))
        {

        }

        /// <summary>
        /// 当前db操作上下文
        /// </summary>
        public DBContext DBContext
        {
            get
            {
                return _dbContext;
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
        /// <param name="tableName"></param>
        /// <returns></returns>
        public Search<T> Search(string tableName = "")
        {
            if (string.IsNullOrEmpty(tableName))
            {
                tableName = TableAttribute.GetTableName<T>();
            }
            return _dbContext.Search<T>(tableName);
        }


        /// <summary>
        /// 获取实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T Get(string id)
        {
            return _dbContext.FromSql($"select * from {_entity.GetTableName()} where {_entity.GetIdentityField().Name}=@{_entity.GetIdentityField().Name}")
                .AddInParameter($"@{_entity.GetIdentityField().Name}", id)
                .First<T>();
        }

        /// <summary>
        /// 获取实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T Get(int id)
        {
            return _dbContext.FromSql($"select * from {_entity.GetTableName()} where {_entity.GetIdentityField().Name}=@{_entity.GetIdentityField().Name}")
                .AddInParameter($"@{_entity.GetIdentityField().Name}", id)
                .First<T>();
        }

        /// <summary>
        /// 获取实体
        /// </summary>
        /// <param name="lambdaWhere"></param>
        /// <returns></returns>
        public T Get(Expression<Func<T, bool>> lambdaWhere)
        {
            return Search().First(lambdaWhere);
        }

        /// <summary>
        /// 返回全部
        /// </summary>
        /// <returns></returns>
        public List<T> GetAll()
        {
            return Search().ToList();
        }

        /// <summary>
        /// 返回总数
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return Search().Count();
        }

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public List<T> GetList(IEnumerable<string> ids)
        {
            var idsStr = $"'{string.Join("','", ids.ToArray())}'";
            return _dbContext.FromSql($"select * from {_entity.GetTableName()} where {_entity.GetIdentityField().Name} in({idsStr})").ToList<T>();
        }

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public List<T> GetList(IEnumerable<int> ids)
        {
            var idsStr = $"'{string.Join("','", ids.ToArray())}'";
            return _dbContext.FromSql($"select * from {_entity.GetTableName()} where {_entity.GetIdentityField().Name} in({idsStr})").ToList<T>();
        }
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="lambdaWhere"></param>
        /// <returns></returns>
        public List<T> GetList(Expression<Func<T, bool>> lambdaWhere)
        {
            return Search().ToList(lambdaWhere);
        }
        /// <summary>
        /// 获取列表
        /// <param name="pageIndex">分页第几页</param>
        /// <param name="pageSize">分页一页取值</param>
        /// </summary>
        /// <returns></returns>
        public List<T> GetList(int pageIndex, int pageSize)
        {
            return Search().Page(pageIndex, pageSize).ToList();
        }

        /// <summary>
        /// 获取列表
        /// <param name="tableName">表名</param>
        /// <param name="pageIndex">分页第几页</param>
        /// <param name="pageSize">分页一页取值</param>
        /// </summary>
        /// <returns></returns>
        public List<T> GetList(string tableName, int pageIndex = 1, int pageSize = 12)
        {
            return Search(tableName).Page(pageIndex, pageSize).ToList();
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="orderBy"></param>
        /// <param name="asc"></param>
        /// <returns></returns>
        public PagedList<T> GetPagedList(int pageIndex, int pageSize, string orderBy = "ID", bool asc = true)
        {
            return Search().ToPagedList(pageIndex, pageSize, orderBy, asc);
        }
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="lambdaWhere"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="orderBy"></param>
        /// <param name="asc"></param>
        /// <returns></returns>
        public PagedList<T> GetPagedList(Expression<Func<T, bool>> lambdaWhere, int pageIndex = 1, int pageSize = 12, string orderBy = "ID", bool asc = true)
        {
            return Search().ToPagedList(lambdaWhere, pageIndex, pageSize, orderBy, asc);
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="lambdaWhere"></param>
        /// <param name="tableName"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="orderBy"></param>
        /// <param name="asc"></param>
        /// <returns></returns>
        public PagedList<T> GetPagedList(Expression<Func<T, bool>> lambdaWhere, string tableName = "", int pageIndex = 1, int pageSize = 12, string orderBy = "ID", bool asc = true)
        {
            return Search(tableName).ToPagedList(lambdaWhere, pageIndex, pageSize, orderBy, asc);
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <typeparam name="Model">自定义模型</typeparam>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="orderBy"></param>
        /// <param name="asc"></param>
        /// <returns></returns>
        public PagedList<Model> GetPagedList<Model>(int pageIndex, int pageSize, string orderBy = "ID", bool asc = true)
        {
            return Search().ToPagedList<Model>(pageIndex, pageSize, orderBy, asc);
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <typeparam name="Model">自定义模型</typeparam>
        /// <param name="lambdaWhere"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="orderBy"></param>
        /// <param name="asc"></param>
        /// <returns></returns>
        public PagedList<Model> GetPagedList<Model>(Expression<Func<T, bool>> lambdaWhere, int pageIndex = 1, int pageSize = 12, string orderBy = "ID", bool asc = true)
        {
            return Search().ToPagedList<Model>(lambdaWhere, pageIndex, pageSize, orderBy, asc);
        }

        /// <summary>
        /// 分页查询
        /// <typeparam name="Model">自定义模型</typeparam>
        /// <param name="lambdaWhere">查询表达式</param>
        /// <param name="tableName">表名</param>
        /// <param name="pageIndex">分页第几页</param>
        /// <param name="pageSize">分页一页取值</param>
        /// <param name="orderBy">排序</param>
        /// <param name="asc">升降</param>
        /// </summary>
        /// <returns></returns>
        public PagedList<Model> GetPagedList<Model>(Expression<Func<T, bool>> lambdaWhere, string tableName = "", int pageIndex = 1, int pageSize = 12, string orderBy = "ID", bool asc = true)
        {
            return Search(tableName).ToPagedList<Model>(lambdaWhere, pageIndex, pageSize, orderBy, asc);
        }


        /// <summary>
        /// 是否存在
        /// </summary>
        /// <param name="lambdaWhere"></param>
        /// <returns></returns>
        public bool Exists(Expression<Func<T, bool>> lambdaWhere)
        {
            return Search().Top(1).Where(lambdaWhere).First() != null;
        }

        /// <summary>
        /// 添加实体
        /// <param name="entity">传进的实体</param>
        /// </summary>
        public int Insert(T entity)
        {
            return _dbContext.Insert(entity);
        }

        /// <summary>
        /// 添加实体
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public List<int> Insert(IEnumerable<T> entities)
        {
            return _dbContext.Insert(entities);
        }

        /// <summary>
        /// 批量添加实体
        /// <param name="entities">传进的实体列表</param>
        /// </summary>
        public void BulkInsert(IEnumerable<T> entities)
        {
            _dbContext.BulkInsert(entities);
        }
        /// <summary>
        /// 更新实体
        /// <param name="entity">传进的实体</param>
        /// </summary>
        public int Update(T entity)
        {
            return _dbContext.Update(entity);
        }

        /// <summary>
        /// 更新实体
        /// <param name="entities">传进的实体</param>
        /// </summary>
        public List<int> Update(IEnumerable<T> entities)
        {
            return _dbContext.Update(entities);
        }

        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="lambdaWhere"></param>
        /// <returns></returns>
        public int Update(T entity, Expression<Func<T, bool>> lambdaWhere)
        {
            return _dbContext.Update<T>(entity, lambdaWhere);
        }

        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="whereSql"></param>
        /// <returns></returns>
        public int Update(T entity, string whereSql)
        {
            return _dbContext.Update<T>(entity, whereSql);
        }

        /// <summary>
        /// 多表关联更新
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        /// <param name="joinOn"></param>
        /// <param name="lambdaWhere"></param>
        /// <returns></returns>
        public int Update<TEntity>(T entity,
            JoinOn<T, TEntity> joinOn,
            Expression<Func<T, TEntity, bool>> lambdaWhere)
        {
            var where = ExpressionToOperation<T>.ToWhereOperation(lambdaWhere);
            return _dbContext.Update(entity, joinOn, where);
        }

        /// <summary>
        /// 多表关联更新
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        /// <param name="joinOn"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public int Update<TEntity>(T entity,
           JoinOn<T, TEntity> joinOn,
           Where where)
        {
            return _dbContext.Update(entity, joinOn, where.ToWhereClip());
        }

        /// <summary>
        /// 多表关联更新
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        /// <param name="joinOn"></param>
        /// <param name="joinType"></param>
        /// <param name="lambdaWhere"></param>
        /// <returns></returns>
        public int Update<TEntity>(T entity,
            Expression<Func<T, TEntity, bool>> joinOn,
            JoinType joinType,
            Expression<Func<T, TEntity, bool>> lambdaWhere)
        {
            var jo = new JoinOn<T, TEntity>(joinOn, joinType);
            var where = ExpressionToOperation<T>.ToWhereOperation(lambdaWhere);
            return _dbContext.Update(entity, jo, where);
        }

        /// <summary>
        /// 多表关联更新
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        /// <param name="joinOn"></param>
        /// <param name="joinType"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public int Update<TEntity>(T entity,
           Expression<Func<T, TEntity, bool>> joinOn,
           JoinType joinType,
           Where where)
        {
            var jo = new JoinOn<T, TEntity>(joinOn, joinType);
            return _dbContext.Update(entity, jo, where.ToWhereClip());
        }

        /// <summary>
        /// 删除实体
        /// <param name="entity">传进的实体</param>
        /// </summary>
        public int Delete(T entity)
        {
            return _dbContext.Delete(entity);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(string id)
        {
            var entity = Get(id);
            if (entity != null)
            {
                return Delete(entity);
            }
            return -1;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            var entity = Get(id);
            if (entity != null)
            {
                return Delete(entity);
            }
            return -1;
        }

        /// <summary>
        /// 批量删除实体
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public int Deletes(IEnumerable<T> entities)
        {
            var list = System.Linq.Enumerable.ToList(entities);
            return _dbContext.Delete(list);
        }

        /// <summary>
        /// 批量删除实体
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public int Delete(IEnumerable<string> ids)
        {
            var list = GetList(ids);
            return Deletes(list);
        }

        /// <summary>
        /// 批量删除实体
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public int Delete(IEnumerable<int> ids)
        {
            var list = GetList(ids);
            return Deletes(list);
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="lambdaWhere"></param>
        /// <returns></returns>
        public int Delete(Expression<Func<T, bool>> lambdaWhere)
        {
            return _dbContext.Delete<T>(lambdaWhere);
        }


        #region sql

        /// <summary>
        /// 执行sql语句
        /// <param name="sql"></param>
        /// </summary>
        public SqlSection FromSql(string sql)
        {
            return _dbContext.FromSql(sql);
        }
        /// <summary>
        /// 执行sql语句,带参数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="inputParamas"></param>
        /// <returns></returns>
        public SqlSection FromSql(string sql, Dictionary<string, object> inputParamas)
        {
            return _dbContext.FromSqlWithdAutomatic(sql, inputParamas.ToArray());
        }
        /// <summary>
        /// 执行sql语句,带参数
        /// </summary>
        /// <typeparam name="Model"></typeparam>
        /// <param name="sql"></param>
        /// <param name="inputParamas"></param>
        /// <returns></returns>
        public SqlSection FromSql<Model>(string sql, Model inputParamas) where Model : class, new()
        {
            return _dbContext.FromSqlWithdModel(sql, inputParamas);
        }
        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="orderBy"></param>
        /// <param name="asc"></param>
        /// <param name="keyValuePairs"></param>
        /// <returns></returns>
        public SqlSection FromSql(string sql, int pageIndex, int pageSize, string orderBy, bool asc = true, Dictionary<string, dynamic> keyValuePairs = null)
        {
            var sqlSection = _dbContext.FromSql(sql, pageIndex, pageSize, orderBy, asc);
            if (keyValuePairs != null && keyValuePairs.Count > 0)
            {
                foreach (var item in keyValuePairs)
                {
                    sqlSection = sqlSection.AddInParameter(item.Key, item.Value);
                }
            }
            return sqlSection;
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="inputParamas"></param>
        /// <returns></returns>
        public DataTable GetDataTable(string tableName, Dictionary<string, dynamic> inputParamas)
        {
            var sp = new StringPlus();
            sp.Append($"SELECT * FROM [{tableName}] WHERE 1=1");
            foreach (var item in inputParamas)
            {
                sp.Append($" AND [{item.Key}]=@{item.Key}");
            }
            var sqlSection = FromSql(sp.ToString());
            foreach (var item in inputParamas)
            {
                sqlSection = sqlSection.AddInParameter($"@{item.Key}", item.Value);
            }
            return sqlSection.ToDataTable();
        }


        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="inputParamas"></param>
        /// <returns></returns>
        public bool Update(string tableName, Dictionary<string, dynamic> inputParamas)
        {
            var sp = new StringPlus();
            sp.Append($"UPDATE [{tableName}] SET");
            foreach (var item in inputParamas)
            {
                if (!item.Key.Equals("ID"))
                {
                    sp.Append($" [{item.Key}]=@{item.Key},");
                }
            }
            sp.Remove(sp.Length - 1, 1);
            sp.Append(" WHERE [ID]=@ID");

            var sqlSection = FromSql(sp.ToString());

            foreach (var item in inputParamas)
            {
                if (item.Key.Equals("ID"))
                {
                    sqlSection = sqlSection.AddInParameter($"@{item.Key}", DbType.String, item.Value.ToString());
                }
                else
                {
                    sqlSection = sqlSection.AddInParameter($"@{item.Key}", item.Value);
                }
            }
            return sqlSection.ExecuteNonQuery() > 0;
        }

        /// <summary>
        /// 执行存储过程
        /// <param name="procName"></param>
        /// </summary>
        public ProcSection FromProc(string procName)
        {
            return _dbContext.FromProc(procName);
        }

        /// <summary>
        /// 执行存储过程，带参数
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="inputParamas"></param>
        /// <returns></returns>
        public ProcSection FromProc(string procName, Dictionary<string, object> inputParamas)
        {
            return _dbContext.FromProc(procName, inputParamas);
        }
        /// <summary>
        /// 执行存储过程，带参数
        /// </summary>
        /// <typeparam name="Model"></typeparam>
        /// <param name="procName"></param>
        /// <param name="inputParamas"></param>
        /// <returns></returns>
        public ProcSection FromProc<Model>(string procName, Model inputParamas) where Model : class, new()
        {
            return _dbContext.FromProc(procName, inputParamas);
        }

        #endregion


        /// <summary>
        /// 创建事务，使用事务curd时推荐方式 using(var tran=CreateTransaction()) 方式
        /// </summary>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public DbTrans CreateTransaction(int timeout = 30)
        {
            return _dbContext.BeginTransaction(timeout);
        }

        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}

﻿/*****************************************************************************************************
 * 本代码版权归Wenli所有，All Rights Reserved (C) 2015-2019
 *****************************************************************************************************
 * 所属域：WENLI-PC
 * 登录用户：yswenli
 * CLR版本：4.0.30319.17929
 * 唯一标识：fc2b3c60-82bd-4265-bf8c-051e512a1035
 * 机器名称：WENLI-PC
 * 联系人邮箱：wenguoli_520@qq.com
 *****************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using WEF.Common;
using WEF.Expressions;
using WEF.Provider;

namespace WEF.Db
{
    /// <summary>
    /// Command Creator
    /// </summary>
    public class CommandCreator
    {

        private Database db;

        public CommandCreator(Database db)
        {
            this.db = db;
        }


        #region 更新

        /// <summary>
        /// 创建更新DbCommand
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public DbCommand CreateUpdateCommand<TEntity>(TEntity entity, WhereOperation where)
            where TEntity : Entity
        {
            var mfields = entity.GetModifyFields();
            if (null == mfields || mfields.Count == 0)
                return null;
            var fields = new Field[mfields.Count];
            var values = new object[mfields.Count];
            var i = 0;
            foreach (ModifyField mf in mfields)
            {
                fields[i] = mf.Field;
                values[i] = mf.NewValue;
                i++;
            }
            return CreateUpdateCommand<TEntity>(entity.GetTableName(), fields, values, where);
        }

        /// <summary>
        /// 创建更新DbCommand
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="fields"></param>
        /// <param name="values"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public DbCommand CreateUpdateCommand<TEntity>(string tableName, Field[] fields, object[] values, WhereOperation where)
            where TEntity : Entity
        {
            if (string.IsNullOrEmpty(tableName))
            {
                tableName = EntityCache.GetTableName<TEntity>();
            }

            Check.Require(!EntityCache.IsReadOnly<TEntity>(), string.Concat("Entity(", tableName, ") is readonly!"));

            if (null == fields || fields.Length == 0 || null == values || values.Length == 0)
                return null;

            Check.Require(fields.Length == values.Length, "fields.Length must be equal values.Length");

            var length = fields.Length;

            if (WhereOperation.IsNullOrEmpty(where))
                where = WhereOperation.All;

            var sql = new StringBuilder();
            sql.Append("UPDATE ");
            sql.Append(db.DbProvider.BuildTableName(tableName, EntityCache.GetUserName<TEntity>()));
            sql.Append(" SET ");

            var identityField = EntityCache.GetIdentityField<TEntity>();
            var identityExist = !Field.IsNullOrEmpty(identityField);
            var list = new List<Parameter>();
            var colums = new StringBuilder();
            for (var i = 0; i < length; i++)
            {
                if (identityExist)
                {
                    //标识列  排除
                    if (fields[i].PropertyName.Equals(identityField.PropertyName))
                        continue;
                }

                colums.Append(",");
                colums.Append(fields[i].FieldName);
                colums.Append("=");

                if (values[i] is Expression)
                {
                    var expression = (Expression)values[i];
                    colums.Append(expression);
                    list.AddRange(expression.Parameters);
                }
                else if (values[i] is Field)
                {
                    var fieldValue = (Field)values[i];
                    colums.Append(fieldValue.TableFieldName);
                }
                else
                {
                    var pname = DataUtils.MakeUniqueKey(fields[i]);
                    //var pname = string.Concat("@", fields[i].Name, i);
                    colums.Append(pname);
                    var p = new Parameter(pname, values[i], fields[i].ParameterDbType, fields[i].ParameterSize);
                    list.Add(p);
                }
            }
            sql.Append(colums.ToString().Substring(1));
            sql.Append(where.WhereString);
            list.AddRange(where.Parameters);

            var cmd = db.GetSqlStringCommand(sql.ToString());

            db.AddCommandParameter(cmd, list.ToArray());

            return cmd;
        }

        #endregion

        #region 删除

        /// <summary>
        /// 创建删除DbCommand
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="userName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public DbCommand CreateDeleteCommand(string tableName, string userName, WhereOperation where)
        {
            if (WhereOperation.IsNullOrEmpty(where))
                throw new Exception("请传入删除条件，删除整表数据请使用.DeleteAll<T>()方法。");
            StringBuilder sql = new StringBuilder();
            sql.Append("DELETE FROM ");
            sql.Append(db.DbProvider.BuildTableName(tableName, userName));
            sql.Append(where.WhereString);
            DbCommand cmd = db.GetSqlStringCommand(sql.ToString());
            db.AddCommandParameter(cmd, where.Parameters.ToArray());

            return cmd;
        }

        /// <summary>
        /// 创建删除DbCommand
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public DbCommand CreateDeleteCommand<TEntity>(WhereOperation where)
             where TEntity : Entity
        {
            return CreateDeleteCommand(EntityCache.GetTableName<TEntity>(), EntityCache.GetUserName<TEntity>(), where);
        }

        #endregion

        #region 添加

        /// <summary>
        /// 创建添加DbCommand
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="fields"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public DbCommand CreateInsertCommand<TEntity>(string tableName, Field[] fields, object[] values)
            where TEntity : Entity
        {
            if (string.IsNullOrEmpty(tableName))
            {
                tableName = EntityCache.GetTableName<TEntity>();
            }

            Check.Require(!EntityCache.IsReadOnly<TEntity>(), string.Concat("Entity(", tableName, ") is readonly!"));

            if (null == fields || fields.Length == 0 || null == values || values.Length == 0)

                return null;

            var sql = new StringBuilder();

            sql.Append("INSERT INTO ");

            if (db.DbProvider.DatabaseType == DatabaseType.PostgreSQL)
            {
                sql.Append($"public.\"{tableName}\"");
            }
            else
            {
                sql.Append(db.DbProvider.BuildTableName(tableName, EntityCache.GetUserName<TEntity>()));
            }


            sql.Append(" (");

            var identityField = EntityCache.GetIdentityField<TEntity>();
            var identityExist = !Field.IsNullOrEmpty(identityField);
            var isSequence = false;

            if (db.DbProvider is OracleProvider)
            {
                if (!string.IsNullOrEmpty(EntityCache.GetSequence<TEntity>()))
                    isSequence = true;
            }

            var insertFields = new Dictionary<string, string>();
            var parameters = new List<Parameter>();

            var length = fields.Length;
            for (var i = 0; i < length; i++)
            {
                if (identityExist)
                {
                    if (fields[i].PropertyName.Equals(identityField.PropertyName))
                    {
                        if (isSequence)
                        {
                            insertFields.Add(fields[i].FieldName, string.Concat(EntityCache.GetSequence<TEntity>(), ".nextval"));
                        }
                        continue;
                    }
                }
                string panme = DataUtils.MakeUniqueKey(fields[i]);
                insertFields.Add(fields[i].FieldName, panme);
                var p = new Parameter(panme, values[i], fields[i].ParameterDbType, fields[i].ParameterSize);
                parameters.Add(p);
            }
            var fs = new StringBuilder();
            var ps = new StringBuilder();

            foreach (var kv in insertFields)
            {
                fs.Append(",");
                fs.Append(kv.Key);

                ps.Append(",");
                ps.Append(kv.Value);
            }

            sql.Append(fs.ToString().Substring(1));
            sql.Append(") VALUES (");
            sql.Append(ps.ToString().Substring(1));
            sql.Append(")");

            var cmd = db.GetSqlStringCommand(sql.ToString());
            db.AddCommandParameter(cmd, parameters.ToArray());
            return cmd;
        }

        /// <summary>
        /// 创建添加DbCommand
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public DbCommand CreateInsertCommand<TEntity>(TEntity entity)
            where TEntity : Entity
        {
            if (null == entity)
                return null;

            var mfields = entity.GetModifyFields();

            if (null == mfields || mfields.Count == 0)
            {
                return CreateInsertCommand<TEntity>(entity.GetTableName(), entity.GetFields(), entity.GetValues());
            }
            else
            {
                List<Field> fields = new List<Field>();

                List<object> values = new List<object>();

                foreach (ModifyField m in mfields)
                {
                    fields.Add(m.Field);
                    values.Add(m.NewValue);
                }

                return CreateInsertCommand<TEntity>(entity.GetTableName(), fields.ToArray(), values.ToArray());
            }
        }

        #endregion
    }
}

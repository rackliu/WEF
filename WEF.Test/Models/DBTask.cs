﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由WEF数据库工具, Version=3.6.3.5, Culture=neutral, PublicKeyToken=null生成;时间 2019-08-27 16:44:01.534
//     运行时版本:4.0.30319.42000
//     不建议手动更改此代码，如有需要请自行扩展partial类
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using WEF.Common;
using WEF.Section;

namespace WEF.Models
{

    /// <summary>
    /// 实体类DBTask
    /// </summary>
    [Serializable, DataContract, TableAttribute("tb_task")]
    public partial class DBTask : Entity
    {
        private static string m_tableName;
        public DBTask() : base("tb_task") { m_tableName = "tb_task"; }
        public DBTask(string tableName) : base(tableName) { m_tableName = tableName; }

        #region Model
        private string _Taskid;
        private string _Name;
        private string _Description;
        private int? _Platformid;
        private string _Businid;
        private string _Pointvalue;
        private int? _Daytimes;
        private int? _Totaltimes;
        private int? _Daylimit;
        private int? _Totallimit;
        private DateTime? _Begintime;
        private DateTime? _Endtime;
        private DateTime? _Taskbeginshowdate;
        private int? _Taskexpiredays;
        private string _Operator;
        private int? _Crc32;
        private DateTime? _Createtime;
        private DateTime? _Updatetime;
        private bool? _Isenabled;
        private bool? _Isdel;
        private int? _Taskstate;
        private string _Companyid;
        private int? _Tasktype;
        private string _Taskstrategyid;
        private int? _Tasksubtype;
        private int? _Flowtype;
        private int? _Taskminpoint;
        private int? _Taskmaxpoint;
        private int? _Taskrewardtype;
        private int? _Taskstrategytype;
        private string _Taskiconurl;
        private string _Taskurl;
        private string _Taskbuttontext;
        private string _Allowusergroup;
        private string _Groupname;
        private int? _Tasksort;
        private int? _Tagid;
        private bool? _Isneedget;
        /// <summary>
        /// Taskid 
        /// </summary>
        [DataMember]
        public string Taskid
        {
            get { return _Taskid; }
            set
            {
                this.OnPropertyValueChange(_.Taskid, _Taskid, value);
                this._Taskid = value;
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
        /// Description 
        /// </summary>
        [DataMember]
        public string Description
        {
            get { return _Description; }
            set
            {
                this.OnPropertyValueChange(_.Description, _Description, value);
                this._Description = value;
            }
        }
        /// <summary>
        /// Platformid 
        /// </summary>
        [DataMember]
        public int? Platformid
        {
            get { return _Platformid; }
            set
            {
                this.OnPropertyValueChange(_.Platformid, _Platformid, value);
                this._Platformid = value;
            }
        }
        /// <summary>
        /// Businid 
        /// </summary>
        [DataMember]
        public string Businid
        {
            get { return _Businid; }
            set
            {
                this.OnPropertyValueChange(_.Businid, _Businid, value);
                this._Businid = value;
            }
        }
        /// <summary>
        /// Pointvalue 
        /// </summary>
        [DataMember]
        public string Pointvalue
        {
            get { return _Pointvalue; }
            set
            {
                this.OnPropertyValueChange(_.Pointvalue, _Pointvalue, value);
                this._Pointvalue = value;
            }
        }
        /// <summary>
        /// Daytimes 
        /// </summary>
        [DataMember]
        public int? Daytimes
        {
            get { return _Daytimes; }
            set
            {
                this.OnPropertyValueChange(_.Daytimes, _Daytimes, value);
                this._Daytimes = value;
            }
        }
        /// <summary>
        /// Totaltimes 
        /// </summary>
        [DataMember]
        public int? Totaltimes
        {
            get { return _Totaltimes; }
            set
            {
                this.OnPropertyValueChange(_.Totaltimes, _Totaltimes, value);
                this._Totaltimes = value;
            }
        }
        /// <summary>
        /// Daylimit 
        /// </summary>
        [DataMember]
        public int? Daylimit
        {
            get { return _Daylimit; }
            set
            {
                this.OnPropertyValueChange(_.Daylimit, _Daylimit, value);
                this._Daylimit = value;
            }
        }
        /// <summary>
        /// Totallimit 
        /// </summary>
        [DataMember]
        public int? Totallimit
        {
            get { return _Totallimit; }
            set
            {
                this.OnPropertyValueChange(_.Totallimit, _Totallimit, value);
                this._Totallimit = value;
            }
        }
        /// <summary>
        /// Begintime 
        /// </summary>
        [DataMember]
        public DateTime? Begintime
        {
            get { return _Begintime; }
            set
            {
                this.OnPropertyValueChange(_.Begintime, _Begintime, value);
                this._Begintime = value;
            }
        }
        /// <summary>
        /// Endtime 
        /// </summary>
        [DataMember]
        public DateTime? Endtime
        {
            get { return _Endtime; }
            set
            {
                this.OnPropertyValueChange(_.Endtime, _Endtime, value);
                this._Endtime = value;
            }
        }
        /// <summary>
        /// Taskbeginshowdate 
        /// </summary>
        [DataMember]
        public DateTime? Taskbeginshowdate
        {
            get { return _Taskbeginshowdate; }
            set
            {
                this.OnPropertyValueChange(_.Taskbeginshowdate, _Taskbeginshowdate, value);
                this._Taskbeginshowdate = value;
            }
        }
        /// <summary>
        /// Taskexpiredays 
        /// </summary>
        [DataMember]
        public int? Taskexpiredays
        {
            get { return _Taskexpiredays; }
            set
            {
                this.OnPropertyValueChange(_.Taskexpiredays, _Taskexpiredays, value);
                this._Taskexpiredays = value;
            }
        }
        /// <summary>
        /// Operator 
        /// </summary>
        [DataMember]
        public string Operator
        {
            get { return _Operator; }
            set
            {
                this.OnPropertyValueChange(_.Operator, _Operator, value);
                this._Operator = value;
            }
        }
        /// <summary>
        /// Crc32 
        /// </summary>
        [DataMember]
        public int? Crc32
        {
            get { return _Crc32; }
            set
            {
                this.OnPropertyValueChange(_.Crc32, _Crc32, value);
                this._Crc32 = value;
            }
        }
        /// <summary>
        /// Createtime 
        /// </summary>
        [DataMember]
        public DateTime? Createtime
        {
            get { return _Createtime; }
            set
            {
                this.OnPropertyValueChange(_.Createtime, _Createtime, value);
                this._Createtime = value;
            }
        }
        /// <summary>
        /// Updatetime 
        /// </summary>
        [DataMember]
        public DateTime? Updatetime
        {
            get { return _Updatetime; }
            set
            {
                this.OnPropertyValueChange(_.Updatetime, _Updatetime, value);
                this._Updatetime = value;
            }
        }
        /// <summary>
        /// Isenabled 
        /// </summary>
        [DataMember]
        public bool? Isenabled
        {
            get { return _Isenabled; }
            set
            {
                this.OnPropertyValueChange(_.Isenabled, _Isenabled, value);
                this._Isenabled = value;
            }
        }
        /// <summary>
        /// Isdel 
        /// </summary>
        [DataMember]
        public bool? Isdel
        {
            get { return _Isdel; }
            set
            {
                this.OnPropertyValueChange(_.Isdel, _Isdel, value);
                this._Isdel = value;
            }
        }
        /// <summary>
        /// Taskstate 
        /// </summary>
        [DataMember]
        public int? Taskstate
        {
            get { return _Taskstate; }
            set
            {
                this.OnPropertyValueChange(_.Taskstate, _Taskstate, value);
                this._Taskstate = value;
            }
        }
        /// <summary>
        /// Companyid 
        /// </summary>
        [DataMember]
        public string Companyid
        {
            get { return _Companyid; }
            set
            {
                this.OnPropertyValueChange(_.Companyid, _Companyid, value);
                this._Companyid = value;
            }
        }
        /// <summary>
        /// Tasktype 
        /// </summary>
        [DataMember]
        public int? Tasktype
        {
            get { return _Tasktype; }
            set
            {
                this.OnPropertyValueChange(_.Tasktype, _Tasktype, value);
                this._Tasktype = value;
            }
        }
        /// <summary>
        /// Taskstrategyid 
        /// </summary>
        [DataMember]
        public string Taskstrategyid
        {
            get { return _Taskstrategyid; }
            set
            {
                this.OnPropertyValueChange(_.Taskstrategyid, _Taskstrategyid, value);
                this._Taskstrategyid = value;
            }
        }
        /// <summary>
        /// Tasksubtype 
        /// </summary>
        [DataMember]
        public int? Tasksubtype
        {
            get { return _Tasksubtype; }
            set
            {
                this.OnPropertyValueChange(_.Tasksubtype, _Tasksubtype, value);
                this._Tasksubtype = value;
            }
        }
        /// <summary>
        /// Flowtype 
        /// </summary>
        [DataMember]
        public int? Flowtype
        {
            get { return _Flowtype; }
            set
            {
                this.OnPropertyValueChange(_.Flowtype, _Flowtype, value);
                this._Flowtype = value;
            }
        }
        /// <summary>
        /// Taskminpoint 
        /// </summary>
        [DataMember]
        public int? Taskminpoint
        {
            get { return _Taskminpoint; }
            set
            {
                this.OnPropertyValueChange(_.Taskminpoint, _Taskminpoint, value);
                this._Taskminpoint = value;
            }
        }
        /// <summary>
        /// Taskmaxpoint 
        /// </summary>
        [DataMember]
        public int? Taskmaxpoint
        {
            get { return _Taskmaxpoint; }
            set
            {
                this.OnPropertyValueChange(_.Taskmaxpoint, _Taskmaxpoint, value);
                this._Taskmaxpoint = value;
            }
        }
        /// <summary>
        /// Taskrewardtype 
        /// </summary>
        [DataMember]
        public int? Taskrewardtype
        {
            get { return _Taskrewardtype; }
            set
            {
                this.OnPropertyValueChange(_.Taskrewardtype, _Taskrewardtype, value);
                this._Taskrewardtype = value;
            }
        }
        /// <summary>
        /// Taskstrategytype 
        /// </summary>
        [DataMember]
        public int? Taskstrategytype
        {
            get { return _Taskstrategytype; }
            set
            {
                this.OnPropertyValueChange(_.Taskstrategytype, _Taskstrategytype, value);
                this._Taskstrategytype = value;
            }
        }
        /// <summary>
        /// Taskiconurl 
        /// </summary>
        [DataMember]
        public string Taskiconurl
        {
            get { return _Taskiconurl; }
            set
            {
                this.OnPropertyValueChange(_.Taskiconurl, _Taskiconurl, value);
                this._Taskiconurl = value;
            }
        }
        /// <summary>
        /// Taskurl 
        /// </summary>
        [DataMember]
        public string Taskurl
        {
            get { return _Taskurl; }
            set
            {
                this.OnPropertyValueChange(_.Taskurl, _Taskurl, value);
                this._Taskurl = value;
            }
        }
        /// <summary>
        /// Taskbuttontext 
        /// </summary>
        [DataMember]
        public string Taskbuttontext
        {
            get { return _Taskbuttontext; }
            set
            {
                this.OnPropertyValueChange(_.Taskbuttontext, _Taskbuttontext, value);
                this._Taskbuttontext = value;
            }
        }
        /// <summary>
        /// Allowusergroup 
        /// </summary>
        [DataMember]
        public string Allowusergroup
        {
            get { return _Allowusergroup; }
            set
            {
                this.OnPropertyValueChange(_.Allowusergroup, _Allowusergroup, value);
                this._Allowusergroup = value;
            }
        }
        /// <summary>
        /// Groupname 
        /// </summary>
        [DataMember]
        public string Groupname
        {
            get { return _Groupname; }
            set
            {
                this.OnPropertyValueChange(_.Groupname, _Groupname, value);
                this._Groupname = value;
            }
        }
        /// <summary>
        /// Tasksort 
        /// </summary>
        [DataMember]
        public int? Tasksort
        {
            get { return _Tasksort; }
            set
            {
                this.OnPropertyValueChange(_.Tasksort, _Tasksort, value);
                this._Tasksort = value;
            }
        }
        /// <summary>
        /// Tagid 
        /// </summary>
        [DataMember]
        public int? Tagid
        {
            get { return _Tagid; }
            set
            {
                this.OnPropertyValueChange(_.Tagid, _Tagid, value);
                this._Tagid = value;
            }
        }
        /// <summary>
        /// Isneedget 
        /// </summary>
        [DataMember]
        public bool? Isneedget
        {
            get { return _Isneedget; }
            set
            {
                this.OnPropertyValueChange(_.Isneedget, _Isneedget, value);
                this._Isneedget = value;
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
                _.Taskid};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
                _.Taskid,
                _.Name,
                _.Description,
                _.Platformid,
                _.Businid,
                _.Pointvalue,
                _.Daytimes,
                _.Totaltimes,
                _.Daylimit,
                _.Totallimit,
                _.Begintime,
                _.Endtime,
                _.Taskbeginshowdate,
                _.Taskexpiredays,
                _.Operator,
                _.Crc32,
                _.Createtime,
                _.Updatetime,
                _.Isenabled,
                _.Isdel,
                _.Taskstate,
                _.Companyid,
                _.Tasktype,
                _.Taskstrategyid,
                _.Tasksubtype,
                _.Flowtype,
                _.Taskminpoint,
                _.Taskmaxpoint,
                _.Taskrewardtype,
                _.Taskstrategytype,
                _.Taskiconurl,
                _.Taskurl,
                _.Taskbuttontext,
                _.Allowusergroup,
                _.Groupname,
                _.Tasksort,
                _.Tagid,
                _.Isneedget};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._Taskid,
                this._Name,
                this._Description,
                this._Platformid,
                this._Businid,
                this._Pointvalue,
                this._Daytimes,
                this._Totaltimes,
                this._Daylimit,
                this._Totallimit,
                this._Begintime,
                this._Endtime,
                this._Taskbeginshowdate,
                this._Taskexpiredays,
                this._Operator,
                this._Crc32,
                this._Createtime,
                this._Updatetime,
                this._Isenabled,
                this._Isdel,
                this._Taskstate,
                this._Companyid,
                this._Tasktype,
                this._Taskstrategyid,
                this._Tasksubtype,
                this._Flowtype,
                this._Taskminpoint,
                this._Taskmaxpoint,
                this._Taskrewardtype,
                this._Taskstrategytype,
                this._Taskiconurl,
                this._Taskurl,
                this._Taskbuttontext,
                this._Allowusergroup,
                this._Groupname,
                this._Tasksort,
                this._Tagid,
                this._Isneedget};
        }
        #endregion

        #region _Field
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
            /// <summary>
            /// tb_task 
            /// </summary>
            public readonly static Field All = new Field("*", m_tableName);
            /// <summary>
            /// Taskid 
            /// </summary>
            public readonly static Field Taskid = new Field("taskid", m_tableName, "taskid");
            /// <summary>
            /// Name 
            /// </summary>
            public readonly static Field Name = new Field("name", m_tableName, "name");
            /// <summary>
            /// Description 
            /// </summary>
            public readonly static Field Description = new Field("description", m_tableName, "description");
            /// <summary>
            /// Platformid 
            /// </summary>
            public readonly static Field Platformid = new Field("platformid", m_tableName, "platformid");
            /// <summary>
            /// Businid 
            /// </summary>
            public readonly static Field Businid = new Field("businid", m_tableName, "businid");
            /// <summary>
            /// Pointvalue 
            /// </summary>
            public readonly static Field Pointvalue = new Field("pointvalue", m_tableName, "pointvalue");
            /// <summary>
            /// Daytimes 
            /// </summary>
            public readonly static Field Daytimes = new Field("daytimes", m_tableName, "daytimes");
            /// <summary>
            /// Totaltimes 
            /// </summary>
            public readonly static Field Totaltimes = new Field("totaltimes", m_tableName, "totaltimes");
            /// <summary>
            /// Daylimit 
            /// </summary>
            public readonly static Field Daylimit = new Field("daylimit", m_tableName, "daylimit");
            /// <summary>
            /// Totallimit 
            /// </summary>
            public readonly static Field Totallimit = new Field("totallimit", m_tableName, "totallimit");
            /// <summary>
            /// Begintime 
            /// </summary>
            public readonly static Field Begintime = new Field("begintime", m_tableName, "begintime");
            /// <summary>
            /// Endtime 
            /// </summary>
            public readonly static Field Endtime = new Field("endtime", m_tableName, "endtime");
            /// <summary>
            /// Taskbeginshowdate 
            /// </summary>
            public readonly static Field Taskbeginshowdate = new Field("taskbeginshowdate", m_tableName, "taskbeginshowdate");
            /// <summary>
            /// Taskexpiredays 
            /// </summary>
            public readonly static Field Taskexpiredays = new Field("taskexpiredays", m_tableName, "taskexpiredays");
            /// <summary>
            /// Operator 
            /// </summary>
            public readonly static Field Operator = new Field("operator", m_tableName, "operator");
            /// <summary>
            /// Crc32 
            /// </summary>
            public readonly static Field Crc32 = new Field("crc32", m_tableName, "crc32");
            /// <summary>
            /// Createtime 
            /// </summary>
            public readonly static Field Createtime = new Field("createtime", m_tableName, "createtime");
            /// <summary>
            /// Updatetime 
            /// </summary>
            public readonly static Field Updatetime = new Field("updatetime", m_tableName, "updatetime");
            /// <summary>
            /// Isenabled 
            /// </summary>
            public readonly static Field Isenabled = new Field("isenabled", m_tableName, "isenabled");
            /// <summary>
            /// Isdel 
            /// </summary>
            public readonly static Field Isdel = new Field("isdel", m_tableName, "isdel");
            /// <summary>
            /// Taskstate 
            /// </summary>
            public readonly static Field Taskstate = new Field("taskstate", m_tableName, "taskstate");
            /// <summary>
            /// Companyid 
            /// </summary>
            public readonly static Field Companyid = new Field("companyid", m_tableName, "companyid");
            /// <summary>
            /// Tasktype 
            /// </summary>
            public readonly static Field Tasktype = new Field("tasktype", m_tableName, "tasktype");
            /// <summary>
            /// Taskstrategyid 
            /// </summary>
            public readonly static Field Taskstrategyid = new Field("taskstrategyid", m_tableName, "taskstrategyid");
            /// <summary>
            /// Tasksubtype 
            /// </summary>
            public readonly static Field Tasksubtype = new Field("tasksubtype", m_tableName, "tasksubtype");
            /// <summary>
            /// Flowtype 
            /// </summary>
            public readonly static Field Flowtype = new Field("flowtype", m_tableName, "flowtype");
            /// <summary>
            /// Taskminpoint 
            /// </summary>
            public readonly static Field Taskminpoint = new Field("taskminpoint", m_tableName, "taskminpoint");
            /// <summary>
            /// Taskmaxpoint 
            /// </summary>
            public readonly static Field Taskmaxpoint = new Field("taskmaxpoint", m_tableName, "taskmaxpoint");
            /// <summary>
            /// Taskrewardtype 
            /// </summary>
            public readonly static Field Taskrewardtype = new Field("taskrewardtype", m_tableName, "taskrewardtype");
            /// <summary>
            /// Taskstrategytype 
            /// </summary>
            public readonly static Field Taskstrategytype = new Field("taskstrategytype", m_tableName, "taskstrategytype");
            /// <summary>
            /// Taskiconurl 
            /// </summary>
            public readonly static Field Taskiconurl = new Field("taskiconurl", m_tableName, "taskiconurl");
            /// <summary>
            /// Taskurl 
            /// </summary>
            public readonly static Field Taskurl = new Field("taskurl", m_tableName, "taskurl");
            /// <summary>
            /// Taskbuttontext 
            /// </summary>
            public readonly static Field Taskbuttontext = new Field("taskbuttontext", m_tableName, "taskbuttontext");
            /// <summary>
            /// Allowusergroup 
            /// </summary>
            public readonly static Field Allowusergroup = new Field("allowusergroup", m_tableName, "allowusergroup");
            /// <summary>
            /// Groupname 
            /// </summary>
            public readonly static Field Groupname = new Field("groupname", m_tableName, "groupname");
            /// <summary>
            /// Tasksort 
            /// </summary>
            public readonly static Field Tasksort = new Field("tasksort", m_tableName, "tasksort");
            /// <summary>
            /// Tagid 
            /// </summary>
            public readonly static Field Tagid = new Field("tagid", m_tableName, "tagid");
            /// <summary>
            /// Isneedget 
            /// </summary>
            public readonly static Field Isneedget = new Field("isneedget", m_tableName, "isneedget");
        }
        #endregion


    }
    /// <summary>
    /// 实体类DBTask操作类
    /// </summary>
    public partial class DBTaskRepository : IRepository<DBTask>
    {
        DBContext db;
        /// <summary>
        /// 当前实体查询上下文
        /// </summary>
        public ISearch<DBTask> Search(string tableName = "")
        {
            if (string.IsNullOrEmpty(tableName))
            {
                tableName = "tb_task";
            }
            return db.Search<DBTask>(tableName);
        }
        /// <summary>
        /// 当前实体查询上下文
        /// </summary>
        public ISearch<DBTask> Search(DBTask entity)
        {
            return db.Search<DBTask>(entity);
        }
        /// <summary>
        /// 构造方法
        /// </summary>
        public DBTaskRepository()
        {
            db = new DBContext();
        }
        /// <summary>
        /// 构造方法
        /// </summary>
        public DBTaskRepository(DBContext dbContext)
        {
            db = dbContext;
        }
        /// <summary>
        /// 构造方法
        /// <param name="connStrName">连接字符串中的名称</param>
        /// </summary>
        public DBTaskRepository(string connStrName)
        {
            db = new DBContext(connStrName);
        }
        /// <summary>
        /// 构造方法
        /// <param name="dbType">数据库类型</param>
        /// <param name="connStr">连接字符串</param>
        /// </summary>
        public DBTaskRepository(DatabaseType dbType, string connStr)
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
        public DBTask GetDBTask(string Taskid)
        {
            return Search().Where(b => b.Taskid == Taskid).First();
        }
        /// <summary>
        /// 获取列表
        /// <param name="pageIndex">分页第几页</param>
        /// <param name="pageSize">分页一页取值</param>
        /// </summary>
        public List<DBTask> GetList(int pageIndex, int pageSize)
        {
            return this.Search().Page(pageIndex, pageSize).ToList();
        }
        /// <summary>
        /// 获取列表
        /// <param name="tableName">表名</param>
        /// <param name="pageIndex">分页第几页</param>
        /// <param name="pageSize">分页一页取值</param>
        /// </summary>
        public List<DBTask> GetList(string tableName, int pageIndex = 1, int pageSize = 12)
        {
            return this.Search(tableName).Page(pageIndex, pageSize).ToList();
        }
        /// <summary>
        /// 添加实体
        /// <param name="obj">传进的实体</param>
        /// </summary>
        public int Insert(DBTask obj)
        {
            return db.Insert(obj);
        }
        /// <summary>
        /// 更新实体
        /// <param name="obj">传进的实体</param>
        /// </summary>
        public int Update(DBTask obj)
        {
            return db.Update(obj);
        }
        /// <summary>
        /// 删除实体
        /// <param name="obj">传进的实体</param>
        /// </summary>
        public int Delete(DBTask obj)
        {
            return db.Delete(obj);
        }
        /// <summary>
        /// 删除实体
        /// <param name="Taskid">Taskid</param>
        /// </summary>
        public int Delete(string Taskid)
        {
            var obj = Search().Where(b => b.Taskid == Taskid).First();
            if (obj == null) return -1;
            return db.Delete(obj);
        }
        /// <summary>
        /// 批量删除实体
        /// <param name="obj">传进的实体列表</param>
        /// </summary>
        public int Deletes(List<DBTask> objs)
        {
            return db.Delete<DBTask>(objs);
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


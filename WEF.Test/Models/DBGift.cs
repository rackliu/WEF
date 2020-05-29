﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由WEF数据库工具, Version=3.3.5.8, Culture=neutral, PublicKeyToken=null生成;时间 2019-04-26 14:13:17.827
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
    /// 实体类DBGift
    /// </summary>
    [Serializable, DataContract, Table("tb_gift")]
    public partial class DBGift : Entity
    {
        private static string m_tableName;
        public DBGift() : base("tb_gift") { m_tableName = "tb_gift"; }
        public DBGift(string tableName) : base(tableName) { m_tableName = tableName; }

        #region Model
        private string _Giftid;
        private string _Name;
        private string _Description;
        private int _Platformid;
        private decimal _Point;
        private decimal? _Giftvalue;
        private int? _Gifttype;
        private int? _Supporttype;
        private int _Daytimes;
        private int _Totaltimes;
        private int _Daylimit;
        private int _Totallimit;
        private decimal _Expireday;
        private DateTime? _Expiretime;
        private DateTime? _Begintime;
        private DateTime? _Endtime;
        private string _Operator;
        private decimal? _Crc32;
        private int? _Giftstate;
        private DateTime? _Createtime;
        private DateTime? _Updatetime;
        private bool _Isenabled;
        private bool _Isdel;
        private string _Remark;
        private string _Consumeurl;
        private string _Ruleurl;
        private string _Companyid;
        private string _Consumercompanyid;
        private string _Giftreference;
        private string _Activestrategyid;
        private string _Shortdesc;
        private string _Applimit;
        private decimal _Giftvalmin;
        private decimal _Giftvalmax;
        private string _Strategy;
        private string _Consumerstrategyid;
        private string _Activename;
        private bool _Useaftersend;
        private string _Chargefcode;
        private decimal? _Fundplantimes;
        private string _Fundplanamount;
        private bool _Issupservice;
        private string _Supservicename;
        private string _Supservicesku;
        private string _Ishomepagedisplay;
        private string _Iconurl;
        private string _Costplatform;
        private string _Giftcategory;
        private decimal _Giftcategorysort;
        private decimal _Amountlimit;
        private int _Paytypelimit;
        /// <summary>
        /// Giftid 
        /// </summary>
        [DataMember]
        public string Giftid
        {
            get { return _Giftid; }
            set
            {
                this.OnPropertyValueChange(_.Giftid, _Giftid, value);
                this._Giftid = value;
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
        public int Platformid
        {
            get { return _Platformid; }
            set
            {
                this.OnPropertyValueChange(_.Platformid, _Platformid, value);
                this._Platformid = value;
            }
        }
        /// <summary>
        /// Point 
        /// </summary>
        [DataMember]
        public decimal Point
        {
            get { return _Point; }
            set
            {
                this.OnPropertyValueChange(_.Point, _Point, value);
                this._Point = value;
            }
        }
        /// <summary>
        /// Giftvalue 
        /// </summary>
        [DataMember]
        public decimal? Giftvalue
        {
            get { return _Giftvalue; }
            set
            {
                this.OnPropertyValueChange(_.Giftvalue, _Giftvalue, value);
                this._Giftvalue = value;
            }
        }
        /// <summary>
        /// Gifttype 
        /// </summary>
        [DataMember]
        public int? Gifttype
        {
            get { return _Gifttype; }
            set
            {
                this.OnPropertyValueChange(_.Gifttype, _Gifttype, value);
                this._Gifttype = value;
            }
        }
        /// <summary>
        /// Supporttype 
        /// </summary>
        [DataMember]
        public int? Supporttype
        {
            get { return _Supporttype; }
            set
            {
                this.OnPropertyValueChange(_.Supporttype, _Supporttype, value);
                this._Supporttype = value;
            }
        }
        /// <summary>
        /// Daytimes 
        /// </summary>
        [DataMember]
        public int Daytimes
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
        public int Totaltimes
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
        public int Daylimit
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
        public int Totallimit
        {
            get { return _Totallimit; }
            set
            {
                this.OnPropertyValueChange(_.Totallimit, _Totallimit, value);
                this._Totallimit = value;
            }
        }
        /// <summary>
        /// Expireday 
        /// </summary>
        [DataMember]
        public decimal Expireday
        {
            get { return _Expireday; }
            set
            {
                this.OnPropertyValueChange(_.Expireday, _Expireday, value);
                this._Expireday = value;
            }
        }
        /// <summary>
        /// Expiretime 
        /// </summary>
        [DataMember]
        public DateTime? Expiretime
        {
            get { return _Expiretime; }
            set
            {
                this.OnPropertyValueChange(_.Expiretime, _Expiretime, value);
                this._Expiretime = value;
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
        public decimal? Crc32
        {
            get { return _Crc32; }
            set
            {
                this.OnPropertyValueChange(_.Crc32, _Crc32, value);
                this._Crc32 = value;
            }
        }
        /// <summary>
        /// Giftstate 
        /// </summary>
        [DataMember]
        public int? Giftstate
        {
            get { return _Giftstate; }
            set
            {
                this.OnPropertyValueChange(_.Giftstate, _Giftstate, value);
                this._Giftstate = value;
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
        public bool Isenabled
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
        public bool Isdel
        {
            get { return _Isdel; }
            set
            {
                this.OnPropertyValueChange(_.Isdel, _Isdel, value);
                this._Isdel = value;
            }
        }
        /// <summary>
        /// Remark 
        /// </summary>
        [DataMember]
        public string Remark
        {
            get { return _Remark; }
            set
            {
                this.OnPropertyValueChange(_.Remark, _Remark, value);
                this._Remark = value;
            }
        }
        /// <summary>
        /// Consumeurl 
        /// </summary>
        [DataMember]
        public string Consumeurl
        {
            get { return _Consumeurl; }
            set
            {
                this.OnPropertyValueChange(_.Consumeurl, _Consumeurl, value);
                this._Consumeurl = value;
            }
        }
        /// <summary>
        /// Ruleurl 
        /// </summary>
        [DataMember]
        public string Ruleurl
        {
            get { return _Ruleurl; }
            set
            {
                this.OnPropertyValueChange(_.Ruleurl, _Ruleurl, value);
                this._Ruleurl = value;
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
        /// Consumercompanyid 
        /// </summary>
        [DataMember]
        public string Consumercompanyid
        {
            get { return _Consumercompanyid; }
            set
            {
                this.OnPropertyValueChange(_.Consumercompanyid, _Consumercompanyid, value);
                this._Consumercompanyid = value;
            }
        }
        /// <summary>
        /// Giftreference 
        /// </summary>
        [DataMember]
        public string Giftreference
        {
            get { return _Giftreference; }
            set
            {
                this.OnPropertyValueChange(_.Giftreference, _Giftreference, value);
                this._Giftreference = value;
            }
        }
        /// <summary>
        /// Activestrategyid 
        /// </summary>
        [DataMember]
        public string Activestrategyid
        {
            get { return _Activestrategyid; }
            set
            {
                this.OnPropertyValueChange(_.Activestrategyid, _Activestrategyid, value);
                this._Activestrategyid = value;
            }
        }
        /// <summary>
        /// Shortdesc 
        /// </summary>
        [DataMember]
        public string Shortdesc
        {
            get { return _Shortdesc; }
            set
            {
                this.OnPropertyValueChange(_.Shortdesc, _Shortdesc, value);
                this._Shortdesc = value;
            }
        }
        /// <summary>
        /// Applimit 
        /// </summary>
        [DataMember]
        public string Applimit
        {
            get { return _Applimit; }
            set
            {
                this.OnPropertyValueChange(_.Applimit, _Applimit, value);
                this._Applimit = value;
            }
        }
        /// <summary>
        /// Giftvalmin 
        /// </summary>
        [DataMember]
        public decimal Giftvalmin
        {
            get { return _Giftvalmin; }
            set
            {
                this.OnPropertyValueChange(_.Giftvalmin, _Giftvalmin, value);
                this._Giftvalmin = value;
            }
        }
        /// <summary>
        /// Giftvalmax 
        /// </summary>
        [DataMember]
        public decimal Giftvalmax
        {
            get { return _Giftvalmax; }
            set
            {
                this.OnPropertyValueChange(_.Giftvalmax, _Giftvalmax, value);
                this._Giftvalmax = value;
            }
        }
        /// <summary>
        /// Strategy 
        /// </summary>
        [DataMember]
        public string Strategy
        {
            get { return _Strategy; }
            set
            {
                this.OnPropertyValueChange(_.Strategy, _Strategy, value);
                this._Strategy = value;
            }
        }
        /// <summary>
        /// Consumerstrategyid 
        /// </summary>
        [DataMember]
        public string Consumerstrategyid
        {
            get { return _Consumerstrategyid; }
            set
            {
                this.OnPropertyValueChange(_.Consumerstrategyid, _Consumerstrategyid, value);
                this._Consumerstrategyid = value;
            }
        }
        /// <summary>
        /// Activename 
        /// </summary>
        [DataMember]
        public string Activename
        {
            get { return _Activename; }
            set
            {
                this.OnPropertyValueChange(_.Activename, _Activename, value);
                this._Activename = value;
            }
        }
        /// <summary>
        /// Useaftersend 
        /// </summary>
        [DataMember]
        public bool Useaftersend
        {
            get { return _Useaftersend; }
            set
            {
                this.OnPropertyValueChange(_.Useaftersend, _Useaftersend, value);
                this._Useaftersend = value;
            }
        }
        /// <summary>
        /// Chargefcode 
        /// </summary>
        [DataMember]
        public string Chargefcode
        {
            get { return _Chargefcode; }
            set
            {
                this.OnPropertyValueChange(_.Chargefcode, _Chargefcode, value);
                this._Chargefcode = value;
            }
        }
        /// <summary>
        /// Fundplantimes 
        /// </summary>
        [DataMember]
        public decimal? Fundplantimes
        {
            get { return _Fundplantimes; }
            set
            {
                this.OnPropertyValueChange(_.Fundplantimes, _Fundplantimes, value);
                this._Fundplantimes = value;
            }
        }
        /// <summary>
        /// Fundplanamount 
        /// </summary>
        [DataMember]
        public string Fundplanamount
        {
            get { return _Fundplanamount; }
            set
            {
                this.OnPropertyValueChange(_.Fundplanamount, _Fundplanamount, value);
                this._Fundplanamount = value;
            }
        }
        /// <summary>
        /// Issupservice 
        /// </summary>
        [DataMember]
        public bool Issupservice
        {
            get { return _Issupservice; }
            set
            {
                this.OnPropertyValueChange(_.Issupservice, _Issupservice, value);
                this._Issupservice = value;
            }
        }
        /// <summary>
        /// Supservicename 
        /// </summary>
        [DataMember]
        public string Supservicename
        {
            get { return _Supservicename; }
            set
            {
                this.OnPropertyValueChange(_.Supservicename, _Supservicename, value);
                this._Supservicename = value;
            }
        }
        /// <summary>
        /// Supservicesku 
        /// </summary>
        [DataMember]
        public string Supservicesku
        {
            get { return _Supservicesku; }
            set
            {
                this.OnPropertyValueChange(_.Supservicesku, _Supservicesku, value);
                this._Supservicesku = value;
            }
        }
        /// <summary>
        /// Ishomepagedisplay 
        /// </summary>
        [DataMember]
        public string Ishomepagedisplay
        {
            get { return _Ishomepagedisplay; }
            set
            {
                this.OnPropertyValueChange(_.Ishomepagedisplay, _Ishomepagedisplay, value);
                this._Ishomepagedisplay = value;
            }
        }
        /// <summary>
        /// Iconurl 
        /// </summary>
        [DataMember]
        public string Iconurl
        {
            get { return _Iconurl; }
            set
            {
                this.OnPropertyValueChange(_.Iconurl, _Iconurl, value);
                this._Iconurl = value;
            }
        }
        /// <summary>
        /// Costplatform 
        /// </summary>
        [DataMember]
        public string Costplatform
        {
            get { return _Costplatform; }
            set
            {
                this.OnPropertyValueChange(_.Costplatform, _Costplatform, value);
                this._Costplatform = value;
            }
        }
        /// <summary>
        /// Giftcategory 
        /// </summary>
        [DataMember]
        public string Giftcategory
        {
            get { return _Giftcategory; }
            set
            {
                this.OnPropertyValueChange(_.Giftcategory, _Giftcategory, value);
                this._Giftcategory = value;
            }
        }
        /// <summary>
        /// Giftcategorysort 
        /// </summary>
        [DataMember]
        public decimal Giftcategorysort
        {
            get { return _Giftcategorysort; }
            set
            {
                this.OnPropertyValueChange(_.Giftcategorysort, _Giftcategorysort, value);
                this._Giftcategorysort = value;
            }
        }
        /// <summary>
        /// Amountlimit 
        /// </summary>
        [DataMember]
        public decimal Amountlimit
        {
            get { return _Amountlimit; }
            set
            {
                this.OnPropertyValueChange(_.Amountlimit, _Amountlimit, value);
                this._Amountlimit = value;
            }
        }
        /// <summary>
        /// Paytypelimit 
        /// </summary>
        [DataMember]
        public int Paytypelimit
        {
            get { return _Paytypelimit; }
            set
            {
                this.OnPropertyValueChange(_.Paytypelimit, _Paytypelimit, value);
                this._Paytypelimit = value;
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
                _.Giftid};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
                _.Giftid,
                _.Name,
                _.Description,
                _.Platformid,
                _.Point,
                _.Giftvalue,
                _.Gifttype,
                _.Supporttype,
                _.Daytimes,
                _.Totaltimes,
                _.Daylimit,
                _.Totallimit,
                _.Expireday,
                _.Expiretime,
                _.Begintime,
                _.Endtime,
                _.Operator,
                _.Crc32,
                _.Giftstate,
                _.Createtime,
                _.Updatetime,
                _.Isenabled,
                _.Isdel,
                _.Remark,
                _.Consumeurl,
                _.Ruleurl,
                _.Companyid,
                _.Consumercompanyid,
                _.Giftreference,
                _.Activestrategyid,
                _.Shortdesc,
                _.Applimit,
                _.Giftvalmin,
                _.Giftvalmax,
                _.Strategy,
                _.Consumerstrategyid,
                _.Activename,
                _.Useaftersend,
                _.Chargefcode,
                _.Fundplantimes,
                _.Fundplanamount,
                _.Issupservice,
                _.Supservicename,
                _.Supservicesku,
                _.Ishomepagedisplay,
                _.Iconurl,
                _.Costplatform,
                _.Giftcategory,
                _.Giftcategorysort,
                _.Amountlimit,
                _.Paytypelimit};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._Giftid,
                this._Name,
                this._Description,
                this._Platformid,
                this._Point,
                this._Giftvalue,
                this._Gifttype,
                this._Supporttype,
                this._Daytimes,
                this._Totaltimes,
                this._Daylimit,
                this._Totallimit,
                this._Expireday,
                this._Expiretime,
                this._Begintime,
                this._Endtime,
                this._Operator,
                this._Crc32,
                this._Giftstate,
                this._Createtime,
                this._Updatetime,
                this._Isenabled,
                this._Isdel,
                this._Remark,
                this._Consumeurl,
                this._Ruleurl,
                this._Companyid,
                this._Consumercompanyid,
                this._Giftreference,
                this._Activestrategyid,
                this._Shortdesc,
                this._Applimit,
                this._Giftvalmin,
                this._Giftvalmax,
                this._Strategy,
                this._Consumerstrategyid,
                this._Activename,
                this._Useaftersend,
                this._Chargefcode,
                this._Fundplantimes,
                this._Fundplanamount,
                this._Issupservice,
                this._Supservicename,
                this._Supservicesku,
                this._Ishomepagedisplay,
                this._Iconurl,
                this._Costplatform,
                this._Giftcategory,
                this._Giftcategorysort,
                this._Amountlimit,
                this._Paytypelimit};
        }
        #endregion

        #region _Field
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
            /// <summary>
            /// tb_gift 
            /// </summary>
            public readonly static Field All = new Field("*", m_tableName);
            /// <summary>
            /// Giftid 
            /// </summary>
            public readonly static Field Giftid = new Field("giftid", m_tableName, "giftid");
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
            /// Point 
            /// </summary>
            public readonly static Field Point = new Field("point", m_tableName, "point");
            /// <summary>
            /// Giftvalue 
            /// </summary>
            public readonly static Field Giftvalue = new Field("giftvalue", m_tableName, "giftvalue");
            /// <summary>
            /// Gifttype 
            /// </summary>
            public readonly static Field Gifttype = new Field("gifttype", m_tableName, "gifttype");
            /// <summary>
            /// Supporttype 
            /// </summary>
            public readonly static Field Supporttype = new Field("supporttype", m_tableName, "supporttype");
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
            /// Expireday 
            /// </summary>
            public readonly static Field Expireday = new Field("expireday", m_tableName, "expireday");
            /// <summary>
            /// Expiretime 
            /// </summary>
            public readonly static Field Expiretime = new Field("expiretime", m_tableName, "expiretime");
            /// <summary>
            /// Begintime 
            /// </summary>
            public readonly static Field Begintime = new Field("begintime", m_tableName, "begintime");
            /// <summary>
            /// Endtime 
            /// </summary>
            public readonly static Field Endtime = new Field("endtime", m_tableName, "endtime");
            /// <summary>
            /// Operator 
            /// </summary>
            public readonly static Field Operator = new Field("operator", m_tableName, "operator");
            /// <summary>
            /// Crc32 
            /// </summary>
            public readonly static Field Crc32 = new Field("crc32", m_tableName, "crc32");
            /// <summary>
            /// Giftstate 
            /// </summary>
            public readonly static Field Giftstate = new Field("giftstate", m_tableName, "giftstate");
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
            /// Remark 
            /// </summary>
            public readonly static Field Remark = new Field("remark", m_tableName, "remark");
            /// <summary>
            /// Consumeurl 
            /// </summary>
            public readonly static Field Consumeurl = new Field("consumeurl", m_tableName, "consumeurl");
            /// <summary>
            /// Ruleurl 
            /// </summary>
            public readonly static Field Ruleurl = new Field("ruleurl", m_tableName, "ruleurl");
            /// <summary>
            /// Companyid 
            /// </summary>
            public readonly static Field Companyid = new Field("companyid", m_tableName, "companyid");
            /// <summary>
            /// Consumercompanyid 
            /// </summary>
            public readonly static Field Consumercompanyid = new Field("consumercompanyid", m_tableName, "consumercompanyid");
            /// <summary>
            /// Giftreference 
            /// </summary>
            public readonly static Field Giftreference = new Field("giftreference", m_tableName, "giftreference");
            /// <summary>
            /// Activestrategyid 
            /// </summary>
            public readonly static Field Activestrategyid = new Field("activestrategyid", m_tableName, "activestrategyid");
            /// <summary>
            /// Shortdesc 
            /// </summary>
            public readonly static Field Shortdesc = new Field("shortdesc", m_tableName, "shortdesc");
            /// <summary>
            /// Applimit 
            /// </summary>
            public readonly static Field Applimit = new Field("applimit", m_tableName, "applimit");
            /// <summary>
            /// Giftvalmin 
            /// </summary>
            public readonly static Field Giftvalmin = new Field("giftvalmin", m_tableName, "giftvalmin");
            /// <summary>
            /// Giftvalmax 
            /// </summary>
            public readonly static Field Giftvalmax = new Field("giftvalmax", m_tableName, "giftvalmax");
            /// <summary>
            /// Strategy 
            /// </summary>
            public readonly static Field Strategy = new Field("strategy", m_tableName, "strategy");
            /// <summary>
            /// Consumerstrategyid 
            /// </summary>
            public readonly static Field Consumerstrategyid = new Field("consumerstrategyid", m_tableName, "consumerstrategyid");
            /// <summary>
            /// Activename 
            /// </summary>
            public readonly static Field Activename = new Field("activename", m_tableName, "activename");
            /// <summary>
            /// Useaftersend 
            /// </summary>
            public readonly static Field Useaftersend = new Field("useaftersend", m_tableName, "useaftersend");
            /// <summary>
            /// Chargefcode 
            /// </summary>
            public readonly static Field Chargefcode = new Field("chargefcode", m_tableName, "chargefcode");
            /// <summary>
            /// Fundplantimes 
            /// </summary>
            public readonly static Field Fundplantimes = new Field("fundplantimes", m_tableName, "fundplantimes");
            /// <summary>
            /// Fundplanamount 
            /// </summary>
            public readonly static Field Fundplanamount = new Field("fundplanamount", m_tableName, "fundplanamount");
            /// <summary>
            /// Issupservice 
            /// </summary>
            public readonly static Field Issupservice = new Field("issupservice", m_tableName, "issupservice");
            /// <summary>
            /// Supservicename 
            /// </summary>
            public readonly static Field Supservicename = new Field("supservicename", m_tableName, "supservicename");
            /// <summary>
            /// Supservicesku 
            /// </summary>
            public readonly static Field Supservicesku = new Field("supservicesku", m_tableName, "supservicesku");
            /// <summary>
            /// Ishomepagedisplay 
            /// </summary>
            public readonly static Field Ishomepagedisplay = new Field("ishomepagedisplay", m_tableName, "ishomepagedisplay");
            /// <summary>
            /// Iconurl 
            /// </summary>
            public readonly static Field Iconurl = new Field("iconurl", m_tableName, "iconurl");
            /// <summary>
            /// Costplatform 
            /// </summary>
            public readonly static Field Costplatform = new Field("costplatform", m_tableName, "costplatform");
            /// <summary>
            /// Giftcategory 
            /// </summary>
            public readonly static Field Giftcategory = new Field("giftcategory", m_tableName, "giftcategory");
            /// <summary>
            /// Giftcategorysort 
            /// </summary>
            public readonly static Field Giftcategorysort = new Field("giftcategorysort", m_tableName, "giftcategorysort");
            /// <summary>
            /// Amountlimit 
            /// </summary>
            public readonly static Field Amountlimit = new Field("amountlimit", m_tableName, "amountlimit");
            /// <summary>
            /// Paytypelimit 
            /// </summary>
            public readonly static Field Paytypelimit = new Field("paytypelimit", m_tableName, "paytypelimit");
        }
        #endregion


    }
    /// <summary>
    /// 实体类DBGift操作类
    /// </summary>
    public partial class DBGiftRepository
    {
        DBContext db;
        /// <summary>
        /// 当前实体查询上下文
        /// </summary>
        public ISearch<DBGift> Search(string tableName = "")
        {
            if (string.IsNullOrEmpty(tableName))
            {
                tableName = "tb_gift";
            }
            return db.Search<DBGift>(tableName);
        }
        /// <summary>
        /// 当前实体查询上下文
        /// </summary>
        public ISearch<DBGift> Search(DBGift entity)
        {
            return db.Search<DBGift>(entity);
        }
        /// <summary>
        /// 构造方法
        /// </summary>
        public DBGiftRepository()
        {
            db = new DBContext();
        }
        /// <summary>
        /// 构造方法
        /// <param name="connStrName">连接字符串中的名称</param>
        /// </summary>
        public DBGiftRepository(string connStrName)
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
        /// 获取实体
        /// <param name="pageIndex">分页第几页</param>
        /// <param name="pageSize">分页一页取值</param>
        /// </summary>
        public DBGift GetDBGift(string Giftid)
        {
            return Search().Where(b => b.Giftid == Giftid).First();
        }
        /// <summary>
        /// 获取列表
        /// <param name="pageIndex">分页第几页</param>
        /// <param name="pageSize">分页一页取值</param>
        /// </summary>
        public List<DBGift> GetList(int pageIndex, int pageSize)
        {
            return this.Search().Page(pageIndex, pageSize).ToList();
        }
        /// <summary>
        /// 获取列表
        /// <param name="tableName">表名</param>
        /// <param name="pageIndex">分页第几页</param>
        /// <param name="pageSize">分页一页取值</param>
        /// </summary>
        public List<DBGift> GetList(string tableName, int pageIndex = 1, int pageSize = 12)
        {
            return this.Search(tableName).Page(pageIndex, pageSize).ToList();
        }
        /// <summary>
        /// 添加实体
        /// <param name="obj">传进的实体</param>
        /// </summary>
        public int Insert(DBGift obj)
        {
            return db.Insert(obj);
        }
        /// <summary>
        /// 更新实体
        /// <param name="obj">传进的实体</param>
        /// </summary>
        public int Update(DBGift obj)
        {
            return db.Update(obj);
        }
        /// <summary>
        /// 删除实体
        /// <param name="obj">传进的实体</param>
        /// </summary>
        public int Delete(DBGift obj)
        {
            obj.Attach(EntityState.Deleted);
            return db.Save(obj);
            //return db.Delete(obj);
        }
        /// <summary>
        /// 删除实体
        /// <param name="Giftid">Giftid</param>
        /// </summary>
        public int Delete(string Giftid)
        {
            var obj = Search().Where(b => b.Giftid == Giftid).First();
            return db.Delete(obj);
        }
        /// <summary>
        /// 批量删除实体
        /// <param name="obj">传进的实体列表</param>
        /// </summary>
        public int Deletes(List<DBGift> objs)
        {
            return db.Delete<DBGift>(objs);
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


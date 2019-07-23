using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text;
namespace WEF.DbDAL.MySql
{
    /// <summary>
    /// ���ݿ���Ϣ�ࡣ
    /// </summary>
    public class DbObject : IDbObject
    {
        bool isdbosp = false;

        #region  ����
        public string DbType
        {
            get { return "MySQL"; }
        }
        private string _dbconnectStr;
        public string DbConnectStr
        {
            set { _dbconnectStr = value; }
            get { return _dbconnectStr; }
        }
        MySqlConnection _connect = new MySqlConnection();

        #endregion

        #region ���캯�������������Ϣ
        public DbObject()
        {
            IsDboSp();
        }

        /// <summary>
        /// ����һ�����ݿ�����
        /// </summary>
        /// <param name="connect"></param>
        public DbObject(string DbConnectStr)
        {
            _dbconnectStr = DbConnectStr;
            _connect.ConnectionString = DbConnectStr;
        }
        /// <summary>
        /// ����һ�������ַ���
        /// </summary>
        /// <param name="SSPI">�Ƿ�windows������֤</param>
        /// <param name="Ip">������IP</param>
        /// <param name="User">�û���</param>
        /// <param name="Pass">����</param>
        public DbObject(bool SSPI, string Ip, string User, string Pass)
            : this(SSPI, Ip, User, Pass, "3306")
        {

        }

        /// <summary>
        /// ����һ�������ַ���
        /// </summary>
        /// <param name="SSPI">�Ƿ�windows������֤</param>
        /// <param name="Ip">������IP</param>
        /// <param name="User">�û���</param>
        /// <param name="Pass">����</param>
        /// <param name="port">�˿�</param>
        /// <param name="dataBase">dataBase</param>
        public DbObject(bool SSPI, string Ip, string User, string Pass, string port, string dataBase = "")
        {
            _connect = new MySqlConnection();

            if (!string.IsNullOrEmpty(dataBase) && dataBase != "ȫ��")
            {
                if (SSPI)
                {
                    _dbconnectStr = String.Format("server={0};user id={1}; password={2}; Port={3};database={4}; pooling=false", Ip, User, Pass, port, dataBase);//database=mysql
                }
                else
                {
                    _dbconnectStr = String.Format("server={0};user id={1}; password={2}; Port={3};database={4}; pooling=false", Ip, User, Pass, port, dataBase);//database=mysql
                }
            }
            else
            {
                if (SSPI)
                {
                    _dbconnectStr = String.Format("server={0};user id={1}; password={2}; Port={3};database=; pooling=false", Ip, User, Pass, port);//database=mysql
                }
                else
                {
                    _dbconnectStr = String.Format("server={0};user id={1}; password={2}; Port={3};database=; pooling=false", Ip, User, Pass, port);//database=mysql
                }
            }
            _connect.ConnectionString = _dbconnectStr;
        }


        #endregion

        #region  �Ƿ����sp(�洢����)�ķ�ʽ��ȡ���ݽṹ��Ϣ
        /// <summary>
        /// �Ƿ����sp�ķ�ʽ��ȡ���ݽṹ��Ϣ
        /// </summary>
        /// <returns></returns>
        private bool IsDboSp()
        {
            return isdbosp;
        }

        #endregion

        #region �����ݿ� OpenDB(string DbName)

        /// <summary>
        /// �����ݿ�
        /// </summary>
        /// <param name="DbName">Ҫ�򿪵����ݿ�</param>
        /// <returns></returns>
        private MySqlCommand OpenDB(string DbName)
        {
            if (string.IsNullOrEmpty(DbName)) throw new Exception("DbName ����Ϊ��!");

            if (_connect.ConnectionString == "")
            {
                _connect.ConnectionString = _dbconnectStr;
            }

            if (_connect.ConnectionString != _dbconnectStr)
            {
                _connect.Close();
                _connect.ConnectionString = _dbconnectStr;
            }

            MySqlCommand dbCommand = new MySqlCommand();
            
            if (_connect.State == System.Data.ConnectionState.Closed)
            {
                _connect.Open();
            }

            dbCommand.Connection = _connect;
            dbCommand.CommandTimeout = 1200;
            dbCommand.CommandText = "use " + DbName + "";
            dbCommand.ExecuteNonQuery();
            return dbCommand;

        }
        #endregion

        #region ADO.NET ����

        public int ExecuteSql(string DbName, string SQLString)
        {
            MySqlCommand dbCommand = OpenDB(DbName);
            dbCommand.CommandText = SQLString;
            return dbCommand.ExecuteNonQuery();
        }


        public DataSet Query(string DbName, string SQLString)
        {
            DataSet ds = new DataSet();
            OpenDB(DbName);
            MySqlDataAdapter command = new MySqlDataAdapter(SQLString, _connect);
            command.Fill(ds, "ds");
            return ds;
        }


        public MySqlDataReader ExecuteReader(string DbName, string strSQL)
        {
            OpenDB(DbName);
            MySqlCommand cmd = new MySqlCommand(strSQL, _connect);
            MySqlDataReader myReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return myReader;
        }


        public object GetSingle(string DbName, string SQLString)
        {
            MySqlCommand dbCommand = OpenDB(DbName);
            dbCommand.CommandText = SQLString;
            object obj = dbCommand.ExecuteScalar();
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
            {
                return null;
            }
            else
            {
                return obj;
            }
        }


        /// <summary>
        /// ִ�д洢����
        /// </summary>
        /// <param name="storedProcName">�洢������</param>
        /// <param name="parameters">�洢���̲���</param>
        /// <param name="tableName">DataSet����еı���</param>
        /// <returns>DataSet</returns>
        public DataSet RunProcedure(string DbName, string storedProcName, IDataParameter[] parameters, string tableName)
        {

            OpenDB(DbName);
            DataSet dataSet = new DataSet();
            MySqlDataAdapter sqlDA = new MySqlDataAdapter();
            sqlDA.SelectCommand = BuildQueryCommand(_connect, storedProcName, parameters);
            sqlDA.Fill(dataSet, tableName);
            return dataSet;

        }


        private MySqlCommand BuildQueryCommand(MySqlConnection connection, string storedProcName, IDataParameter[] parameters)
        {
            MySqlCommand command = new MySqlCommand(storedProcName, connection);
            command.CommandType = CommandType.StoredProcedure;
            foreach (MySqlParameter parameter in parameters)
            {
                if (parameter != null)
                {
                    // ���δ����ֵ���������,���������DBNull.Value.
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                        (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    command.Parameters.Add(parameter);
                }
            }

            return command;
        }
        #endregion

        #region ��������

        /// <summary>
        /// List�����ַ�������
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>0������ȣ�-1����y����x��1����x����y</returns>
        private int CompareStrByOrder(string x, string y)
        {
            if (x == "")
            {
                if (y == "")
                {
                    return 0;// If x is null and y is null, they're equal. 
                }
                else
                {
                    return -1;// If x is null and y is not null, y is greater. 
                }
            }
            else
            {
                if (y == "")  // ...and y is null, x is greater.
                {
                    return 1;
                }
                else
                {
                    int retval = x.CompareTo(y);
                    return retval;
                }
            }
        }

        #endregion


        #region �õ����ݿ�������б� GetDBList()


        /// <summary>
        /// �õ����ݿ�������б�
        /// </summary>
        /// <returns></returns>
        public DataTable GetDBList()
        {
            DataTable dt = new DataTable();
            DataColumn dc = new DataColumn("name", typeof(string));
            dt.Columns.Add(dc);
            string strSql = "SHOW DATABASES";
            using (MySqlDataReader reader = ExecuteReader("mysql", strSql))
            {
                while (reader.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = reader.GetString(0);
                    dt.Rows.Add(dr);
                }
                reader.Close();
            }
            return dt;

        }
        #endregion

        #region  �õ����ݿ�����б����ͼ ������



        /// <summary>
        /// �õ����ݿ�����б���
        /// </summary>
        /// <param name="DbName">���ݿ�</param>
        /// <returns></returns>
        public DataTable GetTables(string DbName)
        {
            string strSql = "SHOW TABLE STATUS";//order by id
            DataTable dt = Query(DbName, strSql).Tables[0];
            dt.Columns[0].ColumnName = "name";
            DataRow[] drs = dt.Select("Comment<>'VIEW' and Engine is not null");
            DataTable newdt = dt.Clone();
            foreach (DataRow dr in drs)
            {
                DataRow newdr = newdt.NewRow();
                newdr["name"] = dr["name"];
                newdt.Rows.Add(newdr);
            }

            return newdt;
        }
        public DataTable GetTablesSP(string DbName)
        {
            MySqlParameter[] parameters = {
                    new MySqlParameter("@table_name", MySqlDbType.VarChar,384),
                    new MySqlParameter("@table_owner", MySqlDbType.VarChar,384),
                    new MySqlParameter("@table_qualifier", MySqlDbType.VarChar,384),
                    new MySqlParameter("@table_type", MySqlDbType.VarChar,100)
            };
            parameters[0].Value = null;
            parameters[1].Value = null;
            parameters[2].Value = null;
            parameters[3].Value = "'TABLE'";

            DataSet ds = RunProcedure(DbName, "sp_tables", parameters, "ds");
            if (ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                dt.Columns["TABLE_QUALIFIER"].ColumnName = "db";
                dt.Columns["TABLE_OWNER"].ColumnName = "cuser";
                dt.Columns["TABLE_NAME"].ColumnName = "name";
                dt.Columns["TABLE_TYPE"].ColumnName = "type";
                dt.Columns["REMARKS"].ColumnName = "remarks";
                return dt;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// �õ����ݿ��������ͼ��
        /// </summary>
        /// <param name="DbName">���ݿ�</param>
        /// <returns></returns>
        public DataTable GetVIEWs(string DbName)
        {
            string strSql = "SHOW TABLE STATUS";//order by id
            DataTable dt = Query(DbName, strSql).Tables[0];
            dt.Columns[0].ColumnName = "name";
            DataRow[] drs = dt.Select("Comment='VIEW' and Engine is  null");
            DataTable newdt = dt.Clone();
            foreach (DataRow dr in drs)
            {
                DataRow newdr = newdt.NewRow();
                newdr["name"] = dr["name"];
                newdt.Rows.Add(newdr);
            }

            return newdt;
        }
        /// <summary>
        /// �õ����ݿ��������ͼ��
        /// </summary>
        /// <param name="DbName">���ݿ�</param>
        /// <returns></returns>
        public DataTable GetVIEWsSP(string DbName)
        {
            MySqlParameter[] parameters = {
                    new MySqlParameter("@table_name", MySqlDbType.VarChar,384),
                    new MySqlParameter("@table_owner", MySqlDbType.VarChar,384),
                    new MySqlParameter("@table_qualifier", MySqlDbType.VarChar,384),
                    new MySqlParameter("@table_type", MySqlDbType.VarChar,100)
            };
            parameters[0].Value = null;
            parameters[1].Value = null;
            parameters[2].Value = null;
            parameters[3].Value = "'VIEW'";

            DataSet ds = RunProcedure(DbName, "sp_tables", parameters, "ds");
            if (ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                dt.Columns["TABLE_QUALIFIER"].ColumnName = "db";
                dt.Columns["TABLE_OWNER"].ColumnName = "cuser";
                dt.Columns["TABLE_NAME"].ColumnName = "name";
                dt.Columns["TABLE_TYPE"].ColumnName = "type";
                dt.Columns["REMARKS"].ColumnName = "remarks";
                return dt;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// �õ����ݿ�����б����ͼ��
        /// </summary>
        /// <param name="DbName">���ݿ�</param>
        /// <returns></returns>
        public DataTable GetTabViews(string DbName)
        {
            string strSql = "SHOW TABLES";//order by id
            DataTable dt = Query(DbName, strSql).Tables[0];
            dt.Columns[0].ColumnName = "name";
            return dt;
        }
        /// <summary>
        /// �õ����ݿ�����б����ͼ��
        /// </summary>
        /// <param name="DbName">���ݿ�</param>
        /// <returns></returns>
        public DataTable GetTabViewsSP(string DbName)
        {
            return GetTabViews(DbName);
        }

        /// <summary>
        /// �õ����ݿ�����д洢������
        /// </summary>
        /// <param name="DbName">���ݿ�</param>
        /// <returns></returns>
        public DataTable GetProcs(string DbName)
        {
            return null;
        }
        #endregion

        #region  �õ����ݿ�����б����ͼ ���б���Ϣ
        /// <summary>
        /// �õ����ݿ�����б����ϸ��Ϣ
        /// </summary>
        /// <param name="DbName">���ݿ�</param>
        /// <returns></returns>
        public DataTable GetTablesInfo(string DbName)
        {
            string strSql = "SHOW TABLE STATUS";//order by id
            DataTable dt = Query(DbName, strSql).Tables[0];
            dt.Columns[0].ColumnName = "name";
            DataRow[] drs = dt.Select("Comment<>'VIEW' and Engine is not null");
            DataTable newdt = dt.Clone();
            foreach (DataRow dr in drs)
            {
                DataRow newdr = newdt.NewRow();
                newdr["name"] = dr["name"];
                newdt.Rows.Add(newdr);
            }

            return newdt;
        }
        /// <summary>
        /// �õ����ݿ��������ͼ����ϸ��Ϣ
        /// </summary>
        /// <param name="DbName">���ݿ�</param>
        /// <returns></returns>
        public DataTable GetVIEWsInfo(string DbName)
        {
            string strSql = "SHOW TABLE STATUS";//order by id
            DataTable dt = Query(DbName, strSql).Tables[0];
            dt.Columns[0].ColumnName = "name";
            DataRow[] drs = dt.Select("Comment='VIEW' and Engine is null");
            DataTable newdt = dt.Clone();
            foreach (DataRow dr in drs)
            {
                DataRow newdr = newdt.NewRow();
                newdr["name"] = dr["name"];
                newdt.Rows.Add(newdr);
            }

            return newdt;
        }
        /// <summary>
        /// �õ����ݿ�����б����ͼ����ϸ��Ϣ
        /// </summary>
        /// <param name="DbName">���ݿ�</param>
        /// <returns></returns>
        public DataTable GetTabViewsInfo(string DbName)
        {
            string strSql = "SHOW TABLE STATUS";//order by id
            DataTable dt = Query(DbName, strSql).Tables[0];
            dt.Columns[0].ColumnName = "name";
            return dt;
        }
        /// <summary>
        /// �õ����ݿ�����д洢���̵���ϸ��Ϣ
        /// </summary>
        /// <param name="DbName">���ݿ�</param>
        /// <returns></returns>
        public DataTable GetProcInfo(string DbName)
        {
            return null;
        }
        #endregion

        #region �õ����������
        /// <summary>
        /// �õ���ͼ��洢���̵Ķ������
        /// </summary>
        /// <param name="DbName">���ݿ�</param>
        /// <returns></returns>
        public string GetObjectInfo(string DbName, string objName)
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append("select a.name,'',a.xtype,a.crdate,b.text ");
            strSql.Append("select b.text ");
            strSql.Append("from sysobjects a, syscomments b  ");
            strSql.Append("where a.xtype='p' and a.id = b.id  ");
            strSql.Append(" and a.name= '" + objName + "'");
            return GetSingle(DbName, strSql.ToString()).ToString();
        }
        #endregion

        #region �õ�(����)���ݿ��������������� GetColumnList(string DbName,string TableName)

        /// <summary>
        /// �õ����ݿ�������ͼ������������
        /// </summary>
        /// <param name="DbName">��</param>
        /// <param name="TableName">��</param>
        /// <returns></returns>
        public DataTable GetColumnList(string DbName, string TableName)
        {
            return GetColumnInfoList(DbName, TableName);

        }
        public DataTable GetColumnListSP(string DbName, string TableName)
        {
            return GetColumnInfoList(DbName, TableName);
        }
        #endregion


        #region �õ�����е���ϸ��Ϣ GetColumnInfoList(string DbName,string TableName)
        /// <summary>
        /// �õ����ݿ�������ͼ���е���ϸ��Ϣ
        /// </summary>
        /// <param name="DbName">��</param>
        /// <param name="TableName">��</param>
        /// <returns></returns>
        public DataTable GetColumnInfoList(string DbName, string TableName)
        {
            try
            {
                string strSql = "SHOW COLUMNS FROM " + TableName;
                DataTable columnsTables = CreateColumnTable();
                DataRow dr;
                MySqlDataReader reader = ExecuteReader(DbName, strSql);
                int n = 1;
                while (reader.Read())
                {
                    dr = columnsTables.NewRow();
                    dr[0] = n.ToString();
                    if ((!Object.Equals(reader["Field"], null)) && (!Object.Equals(reader["Field"], System.DBNull.Value)))
                    {
                        string tname = reader["Field"].GetType().Name;
                        switch (tname)
                        {
                            case "Byte[]":
                                dr["ColumnName"] = Encoding.Default.GetString((Byte[])reader["Field"]);
                                break;
                            case "":
                                break;
                            default:
                                dr["ColumnName"] = reader["Field"].ToString();
                                break;
                        }
                    }
                    string typename = string.Empty;
                    if ((!Object.Equals(reader["Type"], null)) && (!Object.Equals(reader["Type"], System.DBNull.Value)))
                    {
                        string tname = reader["Type"].GetType().Name;
                        switch (tname)
                        {
                            case "Byte[]":
                                typename = Encoding.Default.GetString((Byte[])reader["Type"]);
                                break;
                            case "":
                                break;
                            default:
                                typename = reader["Type"].ToString();
                                break;
                        }
                    }
                    string len = "", pre = "", scal = "";
                    TypeNameProcess(typename, out typename, out len, out pre, out scal);
                    dr["TypeName"] = typename;

                    dr["Length"] = len;
                    dr["Preci"] = pre;
                    dr["Scale"] = scal;
                    if ((!Object.Equals(reader["Key"], null)) && (!Object.Equals(reader["Key"], System.DBNull.Value)))
                    {
                        string skey = "";
                        string tname = reader["Key"].GetType().Name;
                        switch (tname)
                        {
                            case "Byte[]":
                                skey = Encoding.Default.GetString((Byte[])reader["Key"]);
                                break;
                            case "":
                                break;
                            default:
                                skey = reader["Key"].ToString();
                                break;
                        }
                        dr["isPK"] = (skey.Trim() == "PRI") ? "��" : "";
                    }
                    if ((!Object.Equals(reader["Null"], null)) && (!Object.Equals(reader["Null"], System.DBNull.Value)))
                    {
                        string snull = "";
                        string tname = reader["Null"].GetType().Name;
                        switch (tname)
                        {
                            case "Byte[]":
                                snull = Encoding.Default.GetString((Byte[])reader["Null"]);
                                break;
                            case "":
                                break;
                            default:
                                snull = reader["Null"].ToString();
                                break;
                        }
                        dr["cisNull"] = (snull.Trim() == "YES") ? "��" : "";
                    }
                    if ((!Object.Equals(reader["Default"], null)) && (!Object.Equals(reader["Default"], System.DBNull.Value)))
                    {
                        string tname = reader["Default"].GetType().Name;
                        switch (tname)
                        {
                            case "Byte[]":
                                dr["DefaultVal"] = Encoding.Default.GetString((Byte[])reader["Default"]);
                                break;
                            case "":
                                break;
                            default:
                                dr["DefaultVal"] = reader["Default"].ToString();
                                break;
                        }
                    }
                    dr["IsIdentity"] = "";
                    if ((!Object.Equals(reader["Extra"], null)) && (!Object.Equals(reader["Extra"], System.DBNull.Value)))
                    {

                        string tname = reader["Extra"].GetType().Name;
                        switch (tname)
                        {
                            case "Byte[]":
                                dr["DeText"] = Encoding.Default.GetString((Byte[])reader["Extra"]);
                                break;
                            case "":
                                dr["DeText"] = "";
                                break;
                            default:
                                dr["DeText"] = reader["Extra"].ToString();
                                break;
                        }
                        if (dr["DeText"].ToString().Trim() == "auto_increment")
                        {
                            dr["IsIdentity"] = "��";
                        }
                    }

                    columnsTables.Rows.Add(dr);
                    n++;
                }
                reader.Close();
                return columnsTables;
            }
            catch (System.Exception ex)
            {
                throw new Exception("��ȡ������ʧ��" + ex.Message);
            }

        }



        //���������� ����
        private void TypeNameProcess(string strName, out string TypeName, out string Length, out string Preci, out string Scale)
        {
            TypeName = strName;
            int n = strName.IndexOf("(");
            Length = "";
            Preci = "";
            Scale = "";
            if (n > 0)
            {
                TypeName = strName.Substring(0, n);
                switch (TypeName.Trim().ToUpper())
                {
                    //ֻ�д�С(M)
                    case "TINYINT":
                    case "SMALLINT":
                    case "MEDIUMINT":
                    case "INT":
                    case "INTEGER":
                    case "BIGINT":
                    case "TIMESTAMP":
                    case "CHAR":
                    case "VARCHAR":
                        {
                            int m = strName.IndexOf(")");
                            Length = strName.Substring(n + 1, m - n - 1);
                        }
                        break;
                    case "FLOAT"://(M,D)
                    case "DOUBLE":
                    case "REAL":
                    case "DECIMAL":
                    case "DEC":
                    case "NUMERIC":
                        {
                            int m = strName.IndexOf(")");
                            string strlen = strName.Substring(n + 1, m - n - 1);
                            int i = strlen.IndexOf(",");
                            Length = strlen.Substring(0, i);
                            Scale = strlen.Substring(i + 1);
                        }
                        break;
                    case "ENUM"://(M1,M2,M3)
                    case "SET":
                        {
                        }
                        break;
                    default:
                        break;
                }
            }

        }

        public DataTable GetColumnInfoListSP(string DbName, string TableName)
        {
            return null;
        }

        #endregion


        #region �õ����ݿ��������� GetKeyName(string DbName,string TableName)

        //��������Ϣ��
        public DataTable CreateColumnTable()
        {
            DataTable table = new DataTable();
            DataColumn col;

            col = new DataColumn();
            col.DataType = Type.GetType("System.String");
            col.ColumnName = "colorder";
            table.Columns.Add(col);

            col = new DataColumn();
            col.DataType = Type.GetType("System.String");
            col.ColumnName = "ColumnName";
            table.Columns.Add(col);

            col = new DataColumn();
            col.DataType = Type.GetType("System.String");
            col.ColumnName = "deText";
            table.Columns.Add(col);

            col = new DataColumn();
            col.DataType = Type.GetType("System.String");
            col.ColumnName = "TypeName";
            table.Columns.Add(col);

            col = new DataColumn();
            col.DataType = Type.GetType("System.String");
            col.ColumnName = "Length";
            table.Columns.Add(col);

            col = new DataColumn();
            col.DataType = Type.GetType("System.String");
            col.ColumnName = "Preci";
            table.Columns.Add(col);

            col = new DataColumn();
            col.DataType = Type.GetType("System.String");
            col.ColumnName = "Scale";
            table.Columns.Add(col);

            col = new DataColumn();
            col.DataType = Type.GetType("System.String");
            col.ColumnName = "IsIdentity";
            table.Columns.Add(col);

            col = new DataColumn();
            col.DataType = Type.GetType("System.String");
            col.ColumnName = "isPK";
            table.Columns.Add(col);

            col = new DataColumn();
            col.DataType = Type.GetType("System.String");
            col.ColumnName = "cisNull";
            table.Columns.Add(col);

            col = new DataColumn();
            col.DataType = Type.GetType("System.String");
            col.ColumnName = "defaultVal";
            table.Columns.Add(col);



            return table;
        }

        /// <summary>
        /// �õ����ݿ���������
        /// </summary>
        /// <param name="DbName">��</param>
        /// <param name="TableName">��</param>
        /// <returns></returns>
        public DataTable GetKeyName(string DbName, string TableName)
        {
            DataTable dtkey = CreateColumnTable();
            DataTable dt = GetColumnInfoList(DbName, TableName);
            DataRow[] rows = dt.Select(" isPK='��' ");
            foreach (DataRow row in rows)
            {
                DataRow nrow = dtkey.NewRow();
                nrow["colorder"] = row["colorder"];
                nrow["ColumnName"] = row["ColumnName"];
                nrow["TypeName"] = row["TypeName"];
                nrow["Length"] = row["Length"];
                nrow["Preci"] = row["Preci"];
                nrow["Scale"] = row["Scale"];
                nrow["IsIdentity"] = row["IsIdentity"];
                nrow["isPK"] = row["isPK"];
                nrow["cisNull"] = row["cisNull"];
                nrow["defaultVal"] = row["defaultVal"];
                nrow["deText"] = row["deText"];
                dtkey.Rows.Add(nrow);
            }
            return dtkey;


        }
        #endregion

        #region �õ����ݱ�������� GetTabData(string DbName,string TableName)

        /// <summary>
        /// �õ����ݱ��������
        /// </summary>
        /// <param name="DbName"></param>
        /// <param name="TableName"></param>
        /// <returns></returns>
        public DataTable GetTabData(string DbName, string TableName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from " + TableName + "");
            return Query(DbName, strSql.ToString()).Tables[0];
        }
        /// <summary>
        /// ����SQL��ѯ�õ����ݱ��������
        /// </summary>
        /// <param name="DbName"></param>
        /// <param name="TableName"></param>
        /// <returns></returns>
        public DataTable GetTabDataBySQL(string DbName, string strSQL)
        {
            return Query(DbName, strSQL).Tables[0];
        }

        public DataTable GetTabData(string DbName, string TableName, int TopNum)
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("select  * from [" + TableName + "]");
            if (TopNum > 0)
            {
                builder.Append(" limit 0," + TopNum.ToString());
            }
            return this.Query(DbName, builder.ToString()).Tables[0];
        }


        #endregion


        #region ���ݿ����Բ���

        /// <summary>
        /// �޸ı�����
        /// </summary>
        /// <param name="OldName"></param>
        /// <param name="NewName"></param>
        /// <returns></returns>
        public bool RenameTable(string DbName, string OldName, string NewName)
        {
            try
            {
                MySqlCommand dbCommand = OpenDB(DbName);
                dbCommand.CommandText = "RENAME TABLE " + OldName + " TO " + NewName + "";
                dbCommand.ExecuteNonQuery();
                return true;
            }
            catch//(System.Exception ex)
            {
                //string str=ex.Message;	
                return false;
            }
        }

        /// <summary>
        /// ɾ����
        /// </summary>	
        public bool DeleteTable(string DbName, string TableName)
        {
            try
            {
                MySqlCommand dbCommand = OpenDB(DbName);
                dbCommand.CommandText = "DROP TABLE " + TableName + "";
                dbCommand.ExecuteNonQuery();
                return true;
            }
            catch//(System.Exception ex)
            {
                //string str=ex.Message;	
                return false;
            }
        }

        /// <summary>
        /// �õ��汾��
        /// </summary>
        /// <returns></returns>
        public string GetVersion()
        {
            try
            {
                string strSql = "execute master..sp_msgetversion ";//select @@version
                return Query("master", strSql).Tables[0].Rows[0][0].ToString();
            }
            catch//(System.Exception ex)
            {
                //string str=ex.Message;	
                return "";
            }
        }


        /// <summary>
        /// �õ������� �Ľű�
        /// </summary>
        /// <returns></returns>
        public string GetTableScript(string DbName, string TableName)
        {
            string strScript = "";
            string strSql = "SHOW CREATE TABLE " + TableName;
            MySqlDataReader reader = ExecuteReader(DbName, strSql);
            while (reader.Read())
            {
                strScript = reader.GetString(1);
            }
            reader.Close();
            return strScript;

        }
        #endregion



    }
}

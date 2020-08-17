using HNK.Infrustracture;
using HNK.Infrustracture.Auxiliary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;

namespace HNK.BLL
{
    public class SqlAccess:
        DbAccessLayer
    {
        private string m_connectionString;
        private SqlConnection m_sqlConnection;
        private Boolean m_log;

        #region CTOR
        public
            SqlAccess()
        {
            m_connectionString = AppConfig.ConnectionString;
            m_sqlConnection = new SqlConnection(m_connectionString);
            m_log = false;
        }

        public
            SqlAccess(string connectionString)
        {
            m_connectionString = connectionString;
            m_sqlConnection = new SqlConnection(m_connectionString);
            m_log = false;
        }
        #endregion

        #region INTERFACE IMPLEMENTATION
        public override int 
            Insert<E>(E e)
        {
            string sql = InsertSql<E>(e, typeof(E).Name);
            if (sql.IsEffective())
            {
                int r = SqlHelper.ExecuteNonQuery(m_connectionString, System.Data.CommandType.Text, sql);
                return r;
            }
            else if (m_log)
            {
                Log.Write("SQL is Empty.");
                return -1;
            }
            else return -1;
        }
        public override int 
            Insert<E>(List<E> EntityCollection)
        {
            string sql = BulkInsertSql<E>(EntityCollection, typeof(E).Name);
            if (sql.IsEffective())
            {
                int r = SqlHelper.ExecuteNonQuery(m_connectionString, System.Data.CommandType.Text, sql);
                if (m_log)
                {
                    Log.Write(sql + " ->{0} row(s) affected".FormatWith(r));
                }
                return r;
            }
            else if (m_log)
            {
                Log.Write("SQL is Empty");
                return -1;
            }
            else return -1;
        }

        public override List<E> 
            Select<E>(string querySQL)
        {
            List<E> lst = new List<E>();
            if (m_log)
            {
                Log.Write("SQL->" + querySQL);
            }
            SqlDataReader reader = SqlHelper.ExecuteReader(m_connectionString, System.Data.CommandType.Text, querySQL);
            if (reader == null || (!reader.HasRows)) return lst;
            PropertyInfo[] fields = typeof(E).GetProperties();
            while (reader.Read())
            {
                E e = new E();
                foreach (var field in fields)
                {
                    try
                    {
                        string fieldName = field.Name;
                        if (!ExistField(reader, fieldName)) continue;
                        if (reader[fieldName] == null) continue;
                        if (!field.PropertyType.IsGenericType)
                            field.SetValue(e, reader[fieldName] == DBNull.Value ?
                                null : Convert.ChangeType(reader[fieldName],
                                field.PropertyType), null);
                        else
                        {
                            Type genericTypeDefinition = field.PropertyType.GetGenericTypeDefinition();
                            if (genericTypeDefinition == typeof(Nullable<>))
                                field.SetValue(e, reader[fieldName] == DBNull.Value ?
                                    null : Convert.ChangeType(reader[fieldName], field.PropertyType.GetGenericArguments()[0]), null);
                        }
                    }catch(Exception ex)
                    {
                        continue;
                    }
                }
                lst.Add(e);
            }
            return lst;
        }

        public override E Find<E>(string querySQL)
        {
            return Select<E>(querySQL).FirstOrDefault<E>();
        }

        public override int 
            Update<E>(string condition, E e)
        {
            string updateSql = UpdateSqlBuilder<E>(condition, e);
            if (updateSql.IsNullOrEmprty())
            {
                if (m_log)
                {
                    Log.Write("SQL is Empty");
                    return -1;
                }
                else return -1;
            }
            int r = SqlHelper.ExecuteNonQuery(m_connectionString, System.Data.CommandType.Text, updateSql);
            if (m_log)
            {
                Log.Write(updateSql + " -> {0} row(s) affected".FormatWith(r));
            }
            return r;
        }

        public override Boolean 
            Exist(string fieldName, string fieldValue, string tableName)
        {
            string query = string.Format("SELECT * FROM {0} WHERE {1} LIKE '%{2}%'", tableName, fieldName, fieldValue);
            m_sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(query, m_sqlConnection);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            if (i > 1) return false;
            else return false;
        }

        public override int 
            ExcuteSqlNonQuery(string commandText)
        {
            int r = 0;
            r = SqlHelper.ExecuteNonQuery(m_connectionString, System.Data.CommandType.Text, commandText);
            if (m_log)
            {
                Log.Write(commandText + " ->{0} row(s) affected".FormatWith(r));
            }
            return r;
        }
        #endregion

        public override System.Data.DataTable ExcuteDataTable(string commandText){
            System.Data.DataTable result = new System.Data.DataTable();
            m_sqlConnection.Open();
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(commandText, m_sqlConnection);
                dataAdapter.Fill(result);
                dataAdapter.Dispose();
                m_sqlConnection.Close();
                return result;
            }
            catch (Exception ex)
            {
                m_sqlConnection.Close();
                throw ex;
            }
        }

        #region SQL COMMAND HELPERS
        /// <summary>
        /// Create Update SQL with Conditioin
        /// </summary>
        /// <typeparam name="E">Entity Type</typeparam>
        /// <param name="condition">Update Condition</param>
        /// <param name="e">Entity Object</param>
        /// <returns>
        /// string.Empty
        /// a effective SQL Command Text
        /// </returns>
        public string UpdateSqlBuilder<E>(string condition, E e)
            where E : Entity
        {
            if (condition.IsNullOrEmprty())
                return string.Empty;
            Type t = typeof(E);
            string tableName = t.Name;
            PropertyInfo[] fields = t.GetProperties();
            string updates = "";
            foreach (var p in fields)
            {
                object val = p.GetValue(e, null);
                updates += " {0} = '{1}', ".FormatWith(p.Name, val);
            }
            string sql = "UPDATE {0} SET ".FormatWith(tableName)
                + updates.TrimEnd(',')
                + " WHERE {0} ".FormatWith(condition);
            return sql;
        }
        /// <summary>
        /// Insert to MSSQL Database
        /// </summary>
        /// <param name="obj">要转换的对象，不可空</param>
        /// <param name="tableName">要添加的表明，不可空</param>
        /// <returns>
        /// 空
        /// sql语句
        /// </returns>
        public string InsertSql<E>(E e, string tableName) where E : Entity
        {
            if (e == null || string.IsNullOrEmpty(tableName))
            {
                return string.Empty;
            }
            string columns = GetColmons(e);
            if (string.IsNullOrEmpty(columns))
            {
                return string.Empty;
            }
            string values = GetValues(e);
            if (string.IsNullOrEmpty(values))
            {
                return string.Empty;
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into " + tableName);
            sql.Append("(" + columns + ")");
            sql.Append(" values(" + values + ")");
            return sql.ToString();
        }

        /// <summary>
        /// BulkInsert to MSSQL Command Text
        /// </summary>
        /// <typeparam name="T">Entity Class Type</typeparam>
        /// <param name="objs">要转换的对象集合，不可空</param>
        /// <param name="tableName">>要添加的表明，不可空</param>
        /// <returns>
        /// 空
        /// sql语句
        /// </returns>
        public string BulkInsertSql<E>(List<E> objs, string tableName) where E : Entity
        {
            if (objs == null || objs.Count == 0 || string.IsNullOrEmpty(tableName))
            {
                return string.Empty;
            }
            string columns = GetColmons(objs[0]);
            if (string.IsNullOrEmpty(columns))
            {
                return string.Empty;
            }
            string values = string.Join(",", objs.Select(p => string.Format("({0})", GetValues(p))).ToArray());
            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into " + tableName);
            sql.Append("(" + columns + ")");
            sql.Append(" values " + values + "");
            return sql.ToString();
        }

        /// <summary>
        /// 获得类型的列名
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private string GetColmons<T>(T obj)
        {
            if (obj == null)
            {
                return string.Empty;
            }
            return string.Join(",", obj.GetType().GetProperties().Select(p => p.Name).ToList());
        }

        /// <summary>
        /// 获得值
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private string GetValues<T>(T obj)
        {
            if (obj == null)
            {
                return string.Empty;
            }
            return string.Join(",", obj.GetType().GetProperties().Select(p => string.Format("'{0}'", Convert.ToString(p.GetValue(obj, null)))).ToArray());
        }

        private static bool ExistField(SqlDataReader dr, string field)
        {
            dr.GetSchemaTable().DefaultView.RowFilter = "ColumnName= '" + field + "'";
            return (dr.GetSchemaTable().DefaultView.Count > 0);
        }
        #endregion
    }
}

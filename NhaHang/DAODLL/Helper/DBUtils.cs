using System;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections.Generic;
using Cas.Areas.Vietcon.Models;
using System.Reflection;

namespace Cas.Areas.Vietcon.Helpers
{
    public class DBUtils
    {
        public static string connectionStr = System.Configuration.ConfigurationManager.ConnectionStrings["vietcondbConnectionString"].ConnectionString;

        public static DataTable ExecDataTable(VietconDataContext pContext, object pLINQQuery)
        {
            DataTable dt = new DataTable();
            try
            {
                if (pLINQQuery == null)
                {
                    throw new ArgumentNullException("pLINQQuery");
                }
                IDbCommand cmd = pContext.GetCommand(pLINQQuery as IQueryable);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = (SqlCommand)cmd;

                try
                {
                    cmd.Connection.Open();
                    da.FillSchema(dt, SchemaType.Source);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (cmd.Connection.State == ConnectionState.Open)
                    {
                        cmd.Connection.Close();
                    }
                    cmd.Dispose();
                    da.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public static DataTable ExecDataTableQuery(VietconDataContext pContext, string pQueryString)
        {
            pContext = new VietconDataContext();
            DataTable dt = new DataTable();
            try
            {
                SqlConnection conn = new SqlConnection(pContext == null ? connectionStr : pContext.Connection.ConnectionString);
                SqlCommand cmd = new SqlCommand(pQueryString, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                try
                {
                    if (cmd.Connection.State == ConnectionState.Open)
                    {
                        cmd.Connection.Close();
                    }
                    cmd.Connection.Open();
                    //da.FillSchema(dt, SchemaType.Mapped);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (cmd.Connection.State == ConnectionState.Open)
                    {
                        cmd.Connection.Close();
                    }
                    cmd.Dispose();
                    da.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public static DataSet ExecDataSetSP(VietconDataContext pContext, string pSPName, List<SqlParameter> pParams)
        {
            pContext = new VietconDataContext();
            DataSet ds = new DataSet();
            try
            {
                SqlConnection conn = new SqlConnection(pContext == null ? connectionStr : pContext.Connection.ConnectionString);
                SqlCommand cmd = new SqlCommand(pSPName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                //add parameters
                if (pParams != null)
                {
                    foreach (SqlParameter param in pParams)
                    {
                        cmd.Parameters.Add(param);
                    }
                }

                try
                {
                    if (cmd.Connection.State == ConnectionState.Open)
                    {
                        cmd.Connection.Close();
                    }
                    cmd.Connection.Open();
                    da.Fill(ds);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (cmd.Connection.State == ConnectionState.Open)
                    {
                        cmd.Connection.Close();
                    }
                    cmd.Dispose();
                    da.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }

        public static int ExecQuery(VietconDataContext pContext, string pQueryString)
        {
            int result = 0;
            pContext = new VietconDataContext();
            try
            {
                SqlConnection conn = new SqlConnection(pContext == null ? connectionStr : pContext.Connection.ConnectionString);
                SqlCommand cmd = new SqlCommand(pQueryString, conn);
                cmd.CommandType = CommandType.Text;

                try
                {
                    if (cmd.Connection.State == ConnectionState.Open)
                    {
                        cmd.Connection.Close();
                    }
                    cmd.Connection.Open();
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (cmd.Connection.State == ConnectionState.Open)
                    {
                        cmd.Connection.Close();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public static object ExecSP(VietconDataContext pContext, string pSPName, List<SqlParameter> pParams)
        {
            object result = 0;
            pContext = new VietconDataContext();
            try
            {
                SqlConnection conn = new SqlConnection(pContext == null ? connectionStr : pContext.Connection.ConnectionString);
                SqlCommand cmd = new SqlCommand(pSPName, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                //add parameters
                SqlParameter returnParam = new SqlParameter();
                if (pParams != null)
                {
                    foreach (SqlParameter param in pParams)
                    {
                        cmd.Parameters.Add(param);

                        if (param.Direction == ParameterDirection.ReturnValue)
                        {
                            returnParam = param;
                        }
                    }
                }

                try
                {
                    if (cmd.Connection.State == ConnectionState.Open)
                    {
                        cmd.Connection.Close();
                    }
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();

                    result = returnParam.Value == null ? -1000 : returnParam.Value;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (cmd.Connection.State == ConnectionState.Open)
                    {
                        cmd.Connection.Close();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public static T ExecuteSP<T>(string pSPName, List<SqlParameter> pParameters) where T : new()
        {
            try
            {
                DataTable datatable = ExecDataSetSP(null, pSPName, pParameters).Tables[0];
                datatable = datatable ?? new DataTable();

                T Temp = new T();
                try
                {
                    List<string> columnsNames = new List<string>();
                    foreach (DataColumn DataColumn in datatable.Columns)
                        columnsNames.Add(DataColumn.ColumnName);
                    Temp = datatable.AsEnumerable().ToList().ConvertAll<T>(row => getObject<T>(row, columnsNames)).FirstOrDefault();
                    return Temp;
                }
                catch
                {
                    return Temp;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<T> ExecuteSPList<T>(string pSPName, List<SqlParameter> pParameters) where T : new()
        {
            try
            {
                DataTable datatable = ExecDataSetSP(null, pSPName, pParameters).Tables[0];
                datatable = datatable ?? new DataTable();

                List<T> Temp = new List<T>();
                try
                {
                    List<string> columnsNames = new List<string>();
                    foreach (DataColumn DataColumn in datatable.Columns)
                        columnsNames.Add(DataColumn.ColumnName);
                    Temp = datatable.AsEnumerable().ToList().ConvertAll<T>(row => getObject<T>(row, columnsNames));
                    return Temp;
                }
                catch
                {
                    return Temp;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected static T getObject<T>(DataRow row, List<string> columnsName) where T : new()
        {
            T obj = new T();
            try
            {
                string columnname = "";
                string value = "";
                PropertyInfo[] Properties;
                Properties = typeof(T).GetProperties();
                foreach (PropertyInfo objProperty in Properties)
                {
                    columnname = columnsName.Find(name => name.ToLower() == objProperty.Name.ToLower());
                    if (!string.IsNullOrEmpty(columnname))
                    {
                        if (objProperty.PropertyType.Name == "Guid")
                        {
                            value = new Guid((byte[])row[columnname]).ToString();
                        }
                        else
                        {
                            value = row[columnname].ToString();
                        }
                        if (!string.IsNullOrEmpty(value))
                        {
                            if (Nullable.GetUnderlyingType(objProperty.PropertyType) != null)
                            {
                                if (objProperty.PropertyType.Name == "Guid")
                                {
                                    value = new Guid((byte[])row[columnname]).ToString().Replace("$", "").Replace(",", "");
                                    objProperty.SetValue(obj, new Guid((byte[])row[columnname]), null);
                                }
                                else
                                {
                                    value = row[columnname].ToString().Replace("$", "").Replace(",", "");
                                    objProperty.SetValue(obj, Convert.ChangeType(value, Type.GetType(Nullable.GetUnderlyingType(objProperty.PropertyType).ToString())), null);
                                }
                            }
                            else
                            {
                                if (objProperty.PropertyType.Name == "Guid")
                                {
                                    value = new Guid((byte[])row[columnname]).ToString().Replace("%", "");
                                    objProperty.SetValue(obj, new Guid((byte[])row[columnname]), null);
                                }
                                else
                                {
                                    value = row[columnname].ToString().Replace("%", "");
                                    objProperty.SetValue(obj, Convert.ChangeType(value, Type.GetType(objProperty.PropertyType.ToString())), null);
                                }
                            }
                        }
                    }
                }
                return obj;
            }
            catch
            {
                return obj;
            }
        }

        public static List<T> ConvertTo<T>(DataTable datatable) where T : new()
        {
            List<T> Temp = new List<T>();
            try
            {
                List<string> columnsNames = new List<string>();
                foreach (DataColumn DataColumn in datatable.Columns)
                    columnsNames.Add(DataColumn.ColumnName);
                Temp = datatable.AsEnumerable().ToList().ConvertAll<T>(row => getObject<T>(row, columnsNames));
                return Temp;
            }
            catch
            {
                return Temp;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace DAODLL
{
    public class DAO_QL_NguoiDung
    {
        private static DAO_QL_NguoiDung instance;
        public static DAO_QL_NguoiDung Instances
        {
            get
            {
                if (instance == null)
                    instance = new DAO_QL_NguoiDung();
                return instance;
            }
        }

        //string con = ConfigurationManager.ConnectionStrings["connectionStrings"].ConnectionString;
        public int Check_Config()
        {
            if (DAODLL.Properties.Settings.Default.NhaHangConnectionString == string.Empty)
                return 1;// Chuỗi cấu hình không tồn tại
            SqlConnection Sqlconn = new SqlConnection(DAODLL.Properties.Settings.Default.NhaHangConnectionString);
            try
            {
                if (Sqlconn.State == System.Data.ConnectionState.Closed)
                    Sqlconn.Open();
                return 0;// Kết nối thành công chuỗi cấu hình hợp lệ
            }
            catch
            {
                return 2;// Chuỗi cấu hình không phù hợp.
            }
        }
        public string Check_User(string pUser, string pPass)
        {

            SqlDataAdapter daUser = new SqlDataAdapter("select * from NguoiDung where TenDangNhap='" + pUser + "' and MatKhau = '" + pPass + "'", DAODLL.Properties.Settings.Default.NhaHangConnectionString);
            DataTable dt = new DataTable();
            try
            {
                daUser.Fill(dt);
            }
            catch (Exception) { }
            if (dt.Rows.Count == 0)
                return "Invalid";// User không tồn tại
            else if (dt.Rows[0][2] == null||dt.Rows[0][2].ToString()=="False")
            {
                return "Disabled";
            }
                return "Success";// Đăng nhập thành công
        }
        public DataTable GetServerName()
        {
            SqlDataSourceEnumerator instance =
            SqlDataSourceEnumerator.Instance;
            System.Data.DataTable table = instance.GetDataSources();
            return table;
        }
        public List<string> GetDatabaseName(string pServerName, string pUser, string pPass)
        {
            List<string> list = new List<string>();
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT name FROM sys.databases", "Data Source=" + pServerName +";Initial Catalog=master;User ID=" + pUser + ";Password=" + pPass + "");
                //Data Source=DESKTOP-ELPES6T\SQLEXPRESS;Initial Catalog=dangnhap;User ID=sa;Password=anhdai
                da.Fill(dt);
                foreach (System.Data.DataRow row in dt.Rows)
                {
                    foreach (System.Data.DataColumn col in dt.Columns)
                    {
                        list.Add(row[col].ToString());
                    }
                }
            }
            catch
            {
                return null;
            }
            return list;
        }
        public void ChangeConnectionString(string pServerName, string pDataBase, string pUser,string pPass)
        {
            DAODLL.Properties.Settings.Default.NhaHangConnectionString = "Data Source=" + pServerName + ";Initial Catalog=" + pDataBase + ";User ID=" + pUser + ";PassWord = " + pPass + "";
            DAODLL.Properties.Settings.Default.Save();
        }
    }
}

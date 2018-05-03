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
    public class DAO_KhachHang
    {
        private static DAO_KhachHang instance;
        public static DAO_KhachHang Instances
        {
            get
            {
                if (instance == null)
                    instance = new DAO_KhachHang();
                return instance;
            }
        }

        public void insertkhachhang(KhachHang model)
        {
            using (NhaHangDoriEntities kh = new NhaHangDoriEntities())
            {
                kh.KhachHangs.Add(model);
                kh.SaveChanges();
                
            }
        }

    }
}

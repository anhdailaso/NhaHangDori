using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DTODLL;
using DAODLL;
namespace BUSDLL
{
    public class BUS_KhachHang
    {
        private static BUS_KhachHang instance;
        public static BUS_KhachHang Instance
        { get
            { if (instance == null)
                    instance = new BUS_KhachHang();
                return instance;
            }
        }
        public void insert()
        {
            KhachHang kh = new KhachHang();
        }
    }
}

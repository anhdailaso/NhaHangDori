using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
namespace BUSDLL
{
    public class xulianhien
    {
        private static xulianhien instance;
        public static xulianhien Instance
        {
            get
            {
                if (instance == null)
                    instance = new xulianhien();
                return instance;
            }
        }
        public void battac(ButtonX them, ButtonX xoa, ButtonX sua, ButtonX huy, ButtonX luu ,Panel dulieu, bool a)
        {
            them.Enabled = xoa.Enabled = sua.Enabled = a;
            luu.Enabled = dulieu.Enabled = huy.Enabled = !a;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace NhaHang
{
    public partial class Form_TonKho : Office2007RibbonForm
    {
        public Form_TonKho()
        {
            InitializeComponent();
        }

        private void nGUYENLIEUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nGUYENLIEUBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDori);

        }

        private void Form_TonKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDori.NGUYENLIEU' table. You can move, or remove it, as needed.
            this.nGUYENLIEUTableAdapter.Fill(this.dataDori.NGUYENLIEU);

        }
    }
}

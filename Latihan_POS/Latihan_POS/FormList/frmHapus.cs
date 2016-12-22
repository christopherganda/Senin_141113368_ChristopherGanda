using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_POS.FormList
{
    public partial class frmHapus : MetroFramework.Forms.MetroForm
    {
        public frmHapus()
        {
            InitializeComponent();
        }

        private void btnHapusBarang_Click(object sender, EventArgs e)
        {
            if (browseItemUserControl1.idItem != 0)
            {

                GlobalSql.DeleteData("item", browseItemUserControl1.idItem);
                function.ClearAllText(this);
                MessageBox.Show("Barang berhasil dihapus");
            }
            else MessageBox.Show("Harap isi barang yang akan dihapus");
        }

        private void btnHapusCust_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(browseCustomerUserControl1.noHp);
            if (browseCustomerUserControl1.idItem != 0)
            {

                GlobalSql.DeleteData("customer", browseCustomerUserControl1.idItem);
                function.ClearAllText(this);
                MessageBox.Show("Customer berhasil dihapus");
            }
            else MessageBox.Show("Harap isi customer yang akan dihapus");
        }

        private void mtpSupplier_Click(object sender, EventArgs e)
        {

        }

        private void btnHapusSupplier_Click(object sender, EventArgs e)
        {
            if (browseSupplierUserControl1.idItem != 0)
            {

                GlobalSql.DeleteData("supplier", browseSupplierUserControl1.idItem);
                function.ClearAllText(this);
                MessageBox.Show("Supplier berhasil dihapus");
            }
            else MessageBox.Show("Harap isi supplier yang akan dihapus");
        }
        

    }
}

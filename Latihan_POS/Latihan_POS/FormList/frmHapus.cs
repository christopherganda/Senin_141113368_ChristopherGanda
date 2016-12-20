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
            if (browseItem.isEmpty())
            {
                GlobalSql.DeleteData("item", browseItem.idItem);
                function.ClearAllText(this);
                MessageBox.Show("Barang berhasil dihapus");
            }
            else MessageBox.Show("Harap isi barang yang akan dihapus");
        }
        

    }
}

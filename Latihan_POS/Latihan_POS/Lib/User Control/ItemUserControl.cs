using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Common;
namespace Latihan_POS.Lib.User_Control
{
    public partial class ItemUserControl : UserControl
    {
        private int _idItem = 0;

        public  int idItem
        {
            get
            {
                if (_idItem == 0) return 0;
                else return _idItem ;
            }
        }
        public  string kodeItem
        {
            get
            {
                return txtItem.Text;
            }
        }
        public string namaItem
        {
            get
            {
                return txtNamaBarang.Text;
            }
        }
        public ItemUserControl()
        {
            InitializeComponent();
        }
        protected void handleBrowse()
        {
            string query = "select * from item";
            frmBrowse browse = new frmBrowse("Item",query);
            DataGridViewRow row =  browse.ShowDialog();
            if (row != null)
            {
                this.txtItem.Text = row.Cells["kode_barang"].Value.ToString();
                _idItem = Convert.ToInt32(txtItem.Text);
                this.txtNamaBarang.Text  = row.Cells["nama_barang"].Value.ToString();
            }
        }
        public Boolean isEmpty()
        {
            if (txtNamaBarang.Text == null || txtItem.Text == null) return false;
            return true;
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            handleBrowse();
        }
    }
}

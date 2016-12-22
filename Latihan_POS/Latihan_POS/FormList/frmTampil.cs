using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework;namespace Latihan_POS.FormList
{
    public partial class frmTampil : MetroFramework.Forms.MetroForm
    {
        public frmTampil()
        {
            InitializeComponent();
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            dgvTampil.Refresh();
            if (cmbBoxTabel.SelectedIndex != -1)
                dgvTampil.DataSource = GlobalSql.GetDataTable("select * from " + cmbBoxTabel.SelectedItem.ToString());
            else MessageBox.Show("Harap masukkan nama tabel","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

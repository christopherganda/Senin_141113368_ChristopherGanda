using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_POS.Lib.Custom_Form
{
    public partial class frmViewGlobal : MetroFramework.Forms.MetroForm
    {
        DataTable dt;
        public frmViewGlobal()
        {
            InitializeComponent();
            loadComboBox();
            cmbBoxTabel.SelectedIndex = 0;
        }
        protected virtual void loadComboBox()
        {

        }
        protected virtual void HandleTampil()
        {
            dgvBrowse.Refresh();
            dt = GlobalSql.SelectData(cmbBoxTabel.SelectedItem.ToString());
            dgvBrowse.DataSource = dt;
            
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            HandleTampil();
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            
            int i = 0;
            
            string filter = "";
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvBrowse.DataSource;
            foreach (DataColumn dc in dt.Columns  )
            {
                if (i > 0)
                {
                    filter += " or ";
                }
                filter += dc.ColumnName + " like '%" + txtFilter.Text + "%'";
                i++;
            }
            bs.Filter = filter;
            dgvBrowse.DataSource = bs;
        }
    }
}

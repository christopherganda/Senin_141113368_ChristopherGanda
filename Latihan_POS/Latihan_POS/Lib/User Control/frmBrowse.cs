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
using MetroFramework.Forms;

namespace Latihan_POS.Lib.User_Control
{
    public partial class frmBrowse : MetroForm  
    {
        private string tabel;
        private Dictionary<string, string> data;
        private DataView _allData;
        private Action<DataGridViewRow> _handleSelect;
        private Boolean _isSelected = false;
        private DataTable dt ;
        public frmBrowse(string tabel,string query,Action<DataGridViewRow> overrideHandleSelect = null)
        {
            InitializeComponent();
            this.tabel = tabel;
            dt = GlobalSql.SelectData("pos." + this.tabel);
            dgvBrowse.DataSource = dt ;
            dgvBrowse.Refresh();
            data = new Dictionary<string, string> { };
            if (overrideHandleSelect == null)
                _handleSelect = defaultHandleSelect;
            else _handleSelect = overrideHandleSelect;
        }
        private void defaultHandleSelect(DataGridViewRow row)
        {
            this._isSelected = true;
            this.Close();
        }

        private void dgvBrowseClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>-1){
                if(this.dgvBrowse.SelectedRows.Count>0){
                    _handleSelect(this.dgvBrowse.SelectedRows[0]);

                }
            }
        }
        public new DataGridViewRow ShowDialog()
        {
            base.ShowDialog();
            if(this._isSelected && this.dgvBrowse.SelectedRows.Count>0)
                return this.dgvBrowse.SelectedRows[0];
            else
                return null;
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string filter = "";
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvBrowse.DataSource;
            foreach (DataColumn dc in dt.Columns)
            {
                if (i > 0)
                {
                    filter += " or ";
                }
                filter += dc.ColumnName + " like '%" + txtFilter.Text + "%'";
                i++;
            }
            bs.Filter = filter;
            //Console.WriteLine(bs.Filter);
            dgvBrowse.DataSource = bs;

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Latihan_POS.Lib.User_Control
{
    public partial class BrowseSupplierUserControl : Latihan_POS.Lib.User_Control.KeyBrowseValueUserControl
    {
        private int _idSup = 0;
        private string _noHp;
        private string _jenisKel;
        public int idItem
        {
            get
            {
                if (_idSup == 0) return 0;
                else return _idSup;
            }
        }
        public string namaSup
        {
            get
            {
                return txtValue.Text;
            }
        }
        public string noHp
        {
            get
            {
                return _noHp;
            }
        }
        public string jenisKelamin
        {
            get
            {
                return _jenisKel;
            }
        }
        public BrowseSupplierUserControl()
        {
            InitializeComponent();
        }
        protected override void HandleBrowse()
        {
            base.HandleBrowse();
            string query = "select * from supplier";
            frmBrowse browse = new frmBrowse("Supplier", query);
            DataGridViewRow row = browse.ShowDialog();

            if (row != null)
            {
                this.txtKey.Text = row.Cells["id"].Value.ToString();
                _idSup = Convert.ToInt32(txtKey.Text);
                this.txtValue.Text = row.Cells["nama"].Value.ToString();
            }
        }
        protected override void HandlePerubahanKey()
        {
            base.HandlePerubahanKey();
            clsSupplier cust = new clsSupplier(txtKey.Text);
            _noHp = cust.nomorHp;
            _jenisKel = Convert.ToString(cust.jenisKelamin);
        }
    }
}

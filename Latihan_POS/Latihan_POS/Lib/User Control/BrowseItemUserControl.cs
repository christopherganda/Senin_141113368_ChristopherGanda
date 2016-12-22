using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Latihan_POS.Lib.User_Control
{
    public partial class BrowseItemUserControl : Latihan_POS.Lib.User_Control.KeyBrowseValueUserControl
    {
        private int _idItem = 0;
        private double _hargaHpp = 0;
        private double _hargaJual = 0;
        private double _jumlahAwal = 0;
        private string _namaBarang;
        public int idItem
        {
            get
            {
                if (_idItem == 0) return 0;
                else return _idItem;
            }
        }
        public string kodeItem
        {
            get
            {
                return txtValue.Text;
            }
        }
        public string namaItem
        {
            get
            {
                return _namaBarang ;
            }
        }
        public double hargaJual
        {
            get
            {
                return _hargaJual;
            }
        }
        public double jumlahAwal
        {
            get
            {
                return _jumlahAwal;
            }
        }
        public double hargaHpp
        {
            get
            {
                return _hargaHpp;
            }
        }
        public BrowseItemUserControl()
        {
            InitializeComponent();
        }
        protected override void HandleBrowse()
        {
            base.HandleBrowse();
            string query = "select * from item";
            frmBrowse browse = new frmBrowse("Item", query);
            DataGridViewRow row = browse.ShowDialog();

            if (row != null)
            {
                this.txtKey.Text = row.Cells["id"].Value.ToString();
                _idItem = Convert.ToInt32(txtKey.Text);
                this.txtValue.Text = row.Cells["kode_barang"].Value.ToString();
            }
        }
        protected override void HandlePerubahanKey()
        {
            base.HandlePerubahanKey();
            clsItem it = new clsItem(txtKey.Text);
            _hargaHpp = it.hargaHpp;
            _hargaJual = it.hargaJual;
            _namaBarang = it.namaBarang;
            _jumlahAwal = it.jumlahAwal;
            
        }
    }
}

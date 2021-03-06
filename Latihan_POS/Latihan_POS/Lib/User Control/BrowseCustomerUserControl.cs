﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Latihan_POS.Lib.User_Control
{
    public partial class BrowseCustomerUserControl : Latihan_POS.Lib.User_Control.KeyBrowseValueUserControl
    {
        private int _idCust = 0;
        private string _noHp;
        private string _jenisKel;
        public int idItem
        {
            get
            {
                if (_idCust == 0) return 0;
                else return _idCust;
            }
        }
        public string namaCust
        {
            get
            {
                return txtValue.Text ;
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
        public BrowseCustomerUserControl()
        {
            InitializeComponent();
        }
        protected override void HandleBrowse()
        { 
            base.HandleBrowse();
            string query = "select * from customer";
            frmBrowse browse = new frmBrowse("Customer", query);
            DataGridViewRow row = browse.ShowDialog();
            
            if (row != null)
            {
                this.txtKey.Text = row.Cells["id"].Value.ToString();
                _idCust = Convert.ToInt32(txtKey.Text);
                this.txtValue.Text = row.Cells["nama"].Value.ToString();
            }
        }
        protected override void HandlePerubahanKey()
        {
            base.HandlePerubahanKey();
            clsCustomer cust = new clsCustomer(txtKey.Text );
            _noHp = cust.nomorHp;
            _jenisKel = Convert.ToString(cust.jenisKelamin);
        }
    }
}

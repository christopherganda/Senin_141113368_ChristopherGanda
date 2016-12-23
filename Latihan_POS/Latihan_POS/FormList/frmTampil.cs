using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Latihan_POS.FormList
{
    public partial class frmTampil : Latihan_POS.Lib.Custom_Form.frmViewGlobal
    {
        protected override void loadComboBox()
        {
            base.loadComboBox();
            cmbBoxTabel.Items.Add("customer");
            cmbBoxTabel.Items.Add("supplier");
            cmbBoxTabel.Items.Add("item");
        }
        public frmTampil()
        {
            InitializeComponent();
        }
        
    }
}

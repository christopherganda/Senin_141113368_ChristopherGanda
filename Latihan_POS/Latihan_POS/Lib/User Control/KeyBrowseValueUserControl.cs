using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_POS.Lib.User_Control
{
    public partial class KeyBrowseValueUserControl : UserControl
    {
        
        public KeyBrowseValueUserControl()
        {
            InitializeComponent();
        }
        public void SetKey(string value)
        {
            this.txtKey.Text = value;
        }
        public void ResetValue()
        {
            this.txtKey.Text = string.Empty;
            this.txtValue.Text = string.Empty;
        }
        private  void txtKey_TextChanged(object sender, EventArgs e)
        {
            HandlePerubahanKey();
        }
        protected virtual void HandlePerubahanKey()
        {

        }
        protected virtual void HandleBrowse()
        {

        }
        protected virtual void HandleTidakAdaData()
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            HandleBrowse();
        }

        private void KeyBrowseValueUserControl_Validating(object sender, CancelEventArgs e)
        {
            if (this.txtValue.Text.Equals(""))
            {
                e.Cancel = true;
                HandleTidakAdaData();
            }
        }

        private void KeyBrowseValueUserControl_Validated(object sender, EventArgs e)
        {
            //_errorProvider.SetError(this.txtKey, "");
        }
        protected void SetErrorProvider(string pesan)
        {
            //this._errorProvider.SetError(this.txtKey, pesan);
        }
    }
}

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
namespace Latihan_POS.FormList
{
    public partial class frmRegister : MetroFramework.Forms.MetroForm 
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            var cekKosong = this.Controls.OfType<MetroFramework.Controls.MetroTextBox>().Where((txt) => txt.Text.Length == 0 && txt.Visible == true);
            if (cekKosong.Any()) MessageBox.Show("Harap masukkan input-input yang tersedia", "Pesan");
            else
            {
                try
                {
                    Dictionary<string, object> parameters = new Dictionary<string, object> { };
                    parameters.Add("kode_barang", txtKode.Text.ToString());
                    parameters.Add("nama_barang", txtNama.Text.ToString());
                    parameters.Add("jumlah_awal", Convert.ToDouble(txtJumlah.Text));
                    parameters.Add("harga_hpp", Convert.ToDouble(txtHpp.Text));
                    parameters.Add("harga_jual", Convert.ToDouble(txtHargaJual.Text));
                    GlobalSql.InsertData("pos.item", parameters);
                    function.ClearAllText(this);
                    MessageBox.Show("Barang berhasil di-input", "Informasi");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }


        private void txtHargaJual_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtHpp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtJumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void mBtnInputSup_Click(object sender, EventArgs e)
        {
            var cekKosong = this.Controls.OfType<MetroFramework.Controls.MetroTextBox>().Where((txt) => txt.Text.Length == 0 && txt.Visible == true);
            if (cekKosong.Any() || !rboPriaSup.Checked && !rboWanitaSup.Checked ) MessageBox.Show("Harap masukkan input-input yang tersedia", "Pesan");
            else
            {
                try
                {


                    Dictionary<string, object> parameters = new Dictionary<string, object> { };
                    parameters.Add("nama", mTxtNamaSup.Text.ToString());
                    parameters.Add("alamat", mTxtAlamatSup.Text.ToString());
                    parameters.Add("no_hp", mTxtNoHpSup.Text.ToString());
                    parameters.Add("jenis_kelamin", rboPriaSup.Checked? 1 : 0);
                    GlobalSql.InsertData("supplier", parameters);
                    function.ClearAllText(this);
                    MessageBox.Show("Data supplier berhasil diinput", "Informasi");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnInputCust_Click(object sender, EventArgs e)
        {
            var cekKosong = this.Controls.OfType<MetroFramework.Controls.MetroTextBox>().Where((txt) => txt.Text.Length == 0 && txt.Visible == true);
            if (cekKosong.Any() || !rboPriaCust.Checked && !rboWanitaCust.Checked) MessageBox.Show("Harap masukkan input-input yang tersedia", "Pesan");
            else
            {
                try
                {

                    Dictionary<string, object> parameters = new Dictionary<string, object> { };
                    parameters.Add("nama", txtNamaCust.Text.ToString());
                    parameters.Add("alamat", txtAlamatCust.Text.ToString());
                    parameters.Add("no_hp", txtNoHpCust.Text.ToString());
                    parameters.Add("jenis_kelamin", rboPriaCust.Checked ? 1 : 0);
                    GlobalSql.InsertData("customer", parameters);
                    function.ClearAllText(this);
                    MessageBox.Show("Data customer berhasil diinput", "Informasi");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void txtNamaCust_Click(object sender, EventArgs e)
        {

        }

        private void mTxtNoHpSup_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtNoHpCust_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}

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
                    GlobalSql.bukaKoneksi();
                    string query = "insert into item values(@id,@kode,@nama,@jlh,@hpp,@hrg) ";
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = GlobalSql.mySqlConn;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@id", "NULL");
                    cmd.Parameters.AddWithValue("@kode", txtKode.Text.ToString());
                    cmd.Parameters.AddWithValue("@nama", txtNama.Text.ToString());
                    cmd.Parameters.AddWithValue("@jlh", Convert.ToDouble(txtJumlah.Text));
                    cmd.Parameters.AddWithValue("@hpp", Convert.ToDouble(txtHpp.Text));
                    cmd.Parameters.AddWithValue("@hrg", Convert.ToDouble(txtHargaJual.Text));
                    cmd.ExecuteNonQuery();
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
                    
                    GlobalSql.bukaKoneksi();
                    string query = "insert into supplier values(@id,@nama,@alamat,@nohp,@jenis) ";
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = GlobalSql.mySqlConn;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@id", "NULL");
                    cmd.Parameters.AddWithValue("@nama", mTxtNamaSup.Text.ToString());
                    cmd.Parameters.AddWithValue("@alamat", mTxtAlamatSup.Text.ToString());
                    cmd.Parameters.AddWithValue("@nohp", mTxtNoHpSup.Text.ToString());
                    cmd.Parameters.AddWithValue("@jenis", rboPriaSup.Checked? 1 : 0);
                    cmd.ExecuteNonQuery();
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

                    GlobalSql.bukaKoneksi();
                    string query = "insert into customer values(@id,@nama,@alamat,@nohp,@jenis) ";
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = GlobalSql.mySqlConn;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@id", "NULL");
                    cmd.Parameters.AddWithValue("@nama", txtNamaCust.Text.ToString());
                    cmd.Parameters.AddWithValue("@alamat", txtAlamatCust.Text.ToString());
                    cmd.Parameters.AddWithValue("@nohp", txtNoHpCust.Text.ToString());
                    cmd.Parameters.AddWithValue("@jenis", rboPriaCust.Checked ? 1 : 0);
                    cmd.ExecuteNonQuery();
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
    }
}

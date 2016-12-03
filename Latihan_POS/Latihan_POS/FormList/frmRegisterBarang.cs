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
    public partial class frmRegisterBarang : MetroFramework.Forms.MetroForm 
    {
        public frmRegisterBarang()
        {
            InitializeComponent();
        }

        private void frmRegisterBarang_Load(object sender, EventArgs e)
        {
            
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            var cekKosong = this.Controls.OfType<MetroFramework.Controls.MetroTextBox >().Where((txt) => txt.Text.Length == 0 && txt.Visible == true);
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

        private void txtJumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtHpp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar==(char)Keys.Back );
        }

        private void txtHargaJual_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}

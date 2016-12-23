using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_POS.FormList
{
    public partial class frmUpdate : MetroFramework.Forms.MetroForm
    {
        int idItem=0;
        int idCust = 0;
        int idSup = 0;
        public frmUpdate()
        {
            InitializeComponent();

        }
        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            if (idItem != 0)
            {
                var cekKosong = this.Controls.OfType<MetroFramework.Controls.MetroTextBox>().Where((txt) => txt.Text.Length == 0 && txt.Visible == true);
                if (cekKosong.Any()) MessageBox.Show("Harap masukkan input-input yang tersedia", "Pesan");
                else
                {
                    try
                    {

                        Dictionary<string, object> parameters = new Dictionary<string, object> { };
                        parameters.Add("kode_barang", txtKodeBarang.Text);
                        parameters.Add("nama_barang", txtNama.Text);
                        parameters.Add("harga_hpp", Convert.ToDecimal(txtHpp.Text));
                        parameters.Add("harga_jual", Convert.ToDecimal(txtHargaJual.Text));
                        parameters.Add("jumlah_awal", Convert.ToDecimal(txtJumlah.Text));
                        GlobalSql.UpdateData("pos.item", parameters, idItem);
                        function.ClearAllText(this);
                        MessageBox.Show("Barang berhasil di update", "Informasi");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            else MessageBox.Show("Harap lakukan pencarian dari tombol browse");
            
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Latihan_POS.Lib.User_Control.frmBrowse browse = new Lib.User_Control.frmBrowse("item", "select * from item");
            DataGridViewRow row = browse.ShowDialog();

            if (row != null)
            {
                idItem = Convert.ToInt32(row.Cells["id"].Value.ToString());
                txtKodeBarang.Text = row.Cells["kode_barang"].Value.ToString();
                txtNama.Text = row.Cells["nama_barang"].Value.ToString();
                txtJumlah.Text = row.Cells["jumlah_awal"].Value.ToString();
                txtHargaJual.Text = row.Cells["harga_jual"].Value.ToString();
                txtHpp.Text = row.Cells["harga_hpp"].Value.ToString();
            }
            

        }

        private void txtJumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtHpp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtHargaJual_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void mTxtNoHpSup_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtNoHpCust_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void btnUpdateCust_Click(object sender, EventArgs e)
        {
            if (idCust != 0)
            {
                var cekKosong = this.Controls.OfType<MetroFramework.Controls.MetroTextBox>().Where((txt) => txt.Text.Length == 0 && txt.Visible == true);
                if (cekKosong.Any()) MessageBox.Show("Harap masukkan input-input yang tersedia", "Pesan");
                else
                {
                    try
                    {

                        Dictionary<string, object> parameters = new Dictionary<string, object> { };
                        parameters.Add("nama", txtNamaCust.Text);
                        parameters.Add("no_hp", txtNoHpCust.Text);
                        parameters.Add("alamat", txtAlamatCust.Text);
                        parameters.Add("jenis_kelamin", rboPriaCust.Checked ? 1 : 0);
                        GlobalSql.UpdateData("pos.customer", parameters, idCust);
                        function.ClearAllText(this);
                        MessageBox.Show("Customer berhasil di update", "Informasi");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            else MessageBox.Show("Harap lakukan pencarian dari tombol browse");
        }

        private void btnUpdateSup_Click(object sender, EventArgs e)
        {
            if (idCust != 0)
            {
                var cekKosong = this.Controls.OfType<MetroFramework.Controls.MetroTextBox>().Where((txt) => txt.Text.Length == 0 && txt.Visible == true);
                if (cekKosong.Any()) MessageBox.Show("Harap masukkan input-input yang tersedia", "Pesan");
                else
                {
                    try
                    {

                        Dictionary<string, object> parameters = new Dictionary<string, object> { };
                        parameters.Add("nama", txtNamaSupplier.Text);
                        parameters.Add("no_hp", mTxtNoHpSup.Text);
                        parameters.Add("alamat", mTxtAlamatSup.Text);
                        parameters.Add("jenis_kelamin", rboPriaSup.Checked ? 1 : 0);
                        GlobalSql.UpdateData("pos.customer", parameters, idCust);
                        function.ClearAllText(this);
                        MessageBox.Show("Customer berhasil di update", "Informasi");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            else MessageBox.Show("Harap lakukan pencarian dari tombol browse");
        }

        private void browseSupplier_Click(object sender, EventArgs e)
        {
            Latihan_POS.Lib.User_Control.frmBrowse browse = new Lib.User_Control.frmBrowse("Supplier", "select * from supplier");
            DataGridViewRow row = browse.ShowDialog();
            if (row != null)
            {
                idSup = Convert.ToInt32(row.Cells["id"].Value.ToString());
                txtNamaSupplier.Text = row.Cells["nama"].Value.ToString();
                mTxtAlamatSup.Text = row.Cells["alamat"].Value.ToString();
                mTxtNoHpSup.Text = row.Cells["no_hp"].Value.ToString();
                if (row.Cells["jenis_kelamin"].Value.ToString() == "False") rboWanitaSup.Select();
                else rboPriaSup.Select();
            }
        }

        private void browseCust_Click(object sender, EventArgs e)
        {
            Latihan_POS.Lib.User_Control.frmBrowse browse = new Lib.User_Control.frmBrowse("Customer", "select * from customer");
            DataGridViewRow row = browse.ShowDialog();
            if (row != null)
            {
                idCust = Convert.ToInt32(row.Cells["id"].Value.ToString());
                txtNamaCust.Text = row.Cells["nama"].Value.ToString();
                txtAlamatCust.Text = row.Cells["alamat"].Value.ToString();
                txtNoHpCust.Text = row.Cells["no_hp"].Value.ToString();
                if (row.Cells["jenis_kelamin"].Value.ToString() == "False") rboWanitaCust.Select();
                else rboPriaCust.Select();
            }
        }
        
        
    }
}

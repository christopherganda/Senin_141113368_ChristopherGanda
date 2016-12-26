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
    public partial class frmTransaksi : MetroFramework.Forms.MetroForm
    {
        Dictionary<string, string> dataItem;
        Dictionary<string, string> dataSupplier;
        Dictionary<string, string> dataCustomer;
        public frmTransaksi()
        {
            InitializeComponent();
        }

        private void browseBarang_Click(object sender, EventArgs e)
        {
            Latihan_POS.Lib.User_Control.frmBrowse browse = new Lib.User_Control.frmBrowse("item", "select * from item");
            browse.ShowDialog();
            dataItem = browse.getData();
            if (dataItem.Count > 0) txtBarang.Text = dataItem["nama_barang"];
        }

        private void customBrowseButton1_Click(object sender, EventArgs e)
        {
            Latihan_POS.Lib.User_Control.frmBrowse browse = new Lib.User_Control.frmBrowse("supplier", "select * from supplier");
            browse.ShowDialog();
            dataSupplier = browse.getData();
            if (dataSupplier.Count > 0) txtSupplier.Text = dataSupplier["nama"];
        }

        private void txtJumlahBarang_TextChanged(object sender, EventArgs e)
        {
            if (dataItem.Count > 0)
            {
                decimal jlh = Convert.ToDecimal(txtJumlahBarang.Text);
                txtTotalHarga.Text  = Convert.ToString(jlh * Convert.ToDecimal(dataItem["harga_hpp"]));
            }
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            if (dataItem.Count <= 0) MessageBox.Show("Harap memilih item", "Informasi");
            else if (dataSupplier.Count <= 0) MessageBox.Show("Harap memilih supplier", "Informasi");
            else if (txtJumlahBarang.Text == "") MessageBox.Show("Harap mengisi jumlah barang", "Informasi");
            else
            {
                try
                {
                    Dictionary<string, object> parameters = new Dictionary<string, object> { };
                    parameters.Add("id_item", Convert.ToInt16(dataItem["id"]));
                    parameters.Add("id_supplier", Convert.ToInt16(dataSupplier["id"]));
                    parameters.Add("jumlah_barang", Convert.ToInt16(txtJumlahBarang.Text));
                    GlobalSql.InsertData("pos.pembelian", parameters);
                    parameters = new Dictionary<string, object> { };
                    parameters.Add("jumlah_awal", Convert.ToInt16(txtJumlahBarang.Text) + Convert.ToInt16(dataItem["jumlah_awal"]));
                    GlobalSql.UpdateData("pos.item", parameters,Convert.ToInt16(dataItem["id"]));
                    dataItem.Clear();
                    dataSupplier.Clear();
                    function.ClearAllText(this);
                    MessageBox.Show("Transaksi berhasil", "Informasi");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            
        }

        private void browseBarangJual_Click(object sender, EventArgs e)
        {
            Latihan_POS.Lib.User_Control.frmBrowse browse = new Lib.User_Control.frmBrowse("item", "select * from item");
            browse.ShowDialog();
            dataItem = browse.getData();
            if (dataItem.Count > 0) txtBarangJual.Text = dataItem["nama_barang"];
        }

        private void browseCustomer_Click(object sender, EventArgs e)
        {
            Latihan_POS.Lib.User_Control.frmBrowse browse = new Lib.User_Control.frmBrowse("customer", "select * from customer");
            browse.ShowDialog();
            dataCustomer = browse.getData();
            if (dataCustomer.Count > 0) txtCustomer.Text = dataCustomer["nama"];
        }

        private void txtJumlahBarangJual_TextChanged(object sender, EventArgs e)
        {
            if (dataItem.Count > 0)
            {
                decimal jlh = Convert.ToDecimal(txtJumlahBarangJual.Text);
                txtTotalHargaJual.Text = Convert.ToString(jlh * Convert.ToDecimal(dataItem["harga_jual"]));
            }
        }

        private void btnJual_Click(object sender, EventArgs e)
        {
            if (dataItem.Count <= 0) MessageBox.Show("Harap memilih item", "Informasi");
            else if (dataCustomer.Count <= 0) MessageBox.Show("Harap memilih customer", "Informasi");
            else if (txtJumlahBarangJual.Text == "") MessageBox.Show("Harap mengisi jumlah barang", "Informasi");
            else if (Convert.ToInt16(dataItem["jumlah_awal"]) < Convert.ToInt16(txtJumlahBarangJual.Text)) MessageBox.Show("Stok item hanya tersisa : " + dataItem["jumlah_awal"], "Informasi");
            else
            {
                try
                {
                    Dictionary<string, object> parameters = new Dictionary<string, object> { };
                    parameters.Add("id_item", Convert.ToInt16(dataItem["id"]));
                    parameters.Add("id_customer", Convert.ToInt16(dataCustomer["id"]));
                    parameters.Add("jumlah_barang", Convert.ToInt16(txtJumlahBarangJual.Text));
                    GlobalSql.InsertData("pos.penjualan", parameters);
                    parameters = new Dictionary<string, object> { };
                    int sisa = Convert.ToInt16(dataItem["jumlah_awal"]) - Convert.ToInt16(txtJumlahBarangJual.Text);
                    parameters.Add("jumlah_awal", sisa);
                    GlobalSql.UpdateData("pos.item", parameters, Convert.ToInt16(dataItem["id"]));
                    dataItem.Clear();
                    dataCustomer.Clear();
                    function.ClearAllText(this);
                    MessageBox.Show("Transaksi berhasil", "Informasi");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

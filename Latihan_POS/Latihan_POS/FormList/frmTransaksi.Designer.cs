namespace Latihan_POS.FormList
{
    partial class frmTransaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tpPembelian = new System.Windows.Forms.TabPage();
            this.btnBeli = new MetroFramework.Controls.MetroButton();
            this.txtTotalHarga = new MetroFramework.Controls.MetroTextBox();
            this.txtJumlahBarang = new MetroFramework.Controls.MetroTextBox();
            this.customBrowseButton1 = new Latihan_POS.Lib.User_Control.CustomBrowseButton();
            this.txtSupplier = new MetroFramework.Controls.MetroTextBox();
            this.browseBarang = new Latihan_POS.Lib.User_Control.CustomBrowseButton();
            this.txtBarang = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tpPenjualan = new System.Windows.Forms.TabPage();
            this.btnJual = new MetroFramework.Controls.MetroButton();
            this.txtTotalHargaJual = new MetroFramework.Controls.MetroTextBox();
            this.txtJumlahBarangJual = new MetroFramework.Controls.MetroTextBox();
            this.browseCustomer = new Latihan_POS.Lib.User_Control.CustomBrowseButton();
            this.txtCustomer = new MetroFramework.Controls.MetroTextBox();
            this.browseBarangJual = new Latihan_POS.Lib.User_Control.CustomBrowseButton();
            this.txtBarangJual = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.tpPembelian.SuspendLayout();
            this.tpPenjualan.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tpPembelian);
            this.metroTabControl1.Controls.Add(this.tpPenjualan);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(548, 449);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tpPembelian
            // 
            this.tpPembelian.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tpPembelian.Controls.Add(this.btnBeli);
            this.tpPembelian.Controls.Add(this.txtTotalHarga);
            this.tpPembelian.Controls.Add(this.txtJumlahBarang);
            this.tpPembelian.Controls.Add(this.customBrowseButton1);
            this.tpPembelian.Controls.Add(this.txtSupplier);
            this.tpPembelian.Controls.Add(this.browseBarang);
            this.tpPembelian.Controls.Add(this.txtBarang);
            this.tpPembelian.Controls.Add(this.metroLabel4);
            this.tpPembelian.Controls.Add(this.metroLabel3);
            this.tpPembelian.Controls.Add(this.metroLabel2);
            this.tpPembelian.Controls.Add(this.metroLabel1);
            this.tpPembelian.Location = new System.Drawing.Point(4, 38);
            this.tpPembelian.Name = "tpPembelian";
            this.tpPembelian.Size = new System.Drawing.Size(540, 407);
            this.tpPembelian.TabIndex = 0;
            this.tpPembelian.Text = "Pembelian";
            // 
            // btnBeli
            // 
            this.btnBeli.Location = new System.Drawing.Point(240, 190);
            this.btnBeli.Name = "btnBeli";
            this.btnBeli.Size = new System.Drawing.Size(145, 23);
            this.btnBeli.TabIndex = 10;
            this.btnBeli.Text = "Beli";
            this.btnBeli.UseSelectable = true;
            this.btnBeli.Click += new System.EventHandler(this.btnBeli_Click);
            // 
            // txtTotalHarga
            // 
            // 
            // 
            // 
            this.txtTotalHarga.CustomButton.Image = null;
            this.txtTotalHarga.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.txtTotalHarga.CustomButton.Name = "";
            this.txtTotalHarga.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalHarga.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalHarga.CustomButton.TabIndex = 1;
            this.txtTotalHarga.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalHarga.CustomButton.UseSelectable = true;
            this.txtTotalHarga.CustomButton.Visible = false;
            this.txtTotalHarga.Enabled = false;
            this.txtTotalHarga.Lines = new string[0];
            this.txtTotalHarga.Location = new System.Drawing.Point(240, 135);
            this.txtTotalHarga.MaxLength = 32767;
            this.txtTotalHarga.Name = "txtTotalHarga";
            this.txtTotalHarga.PasswordChar = '\0';
            this.txtTotalHarga.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalHarga.SelectedText = "";
            this.txtTotalHarga.SelectionLength = 0;
            this.txtTotalHarga.SelectionStart = 0;
            this.txtTotalHarga.ShortcutsEnabled = true;
            this.txtTotalHarga.Size = new System.Drawing.Size(145, 23);
            this.txtTotalHarga.TabIndex = 9;
            this.txtTotalHarga.UseSelectable = true;
            this.txtTotalHarga.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalHarga.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtJumlahBarang
            // 
            // 
            // 
            // 
            this.txtJumlahBarang.CustomButton.Image = null;
            this.txtJumlahBarang.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.txtJumlahBarang.CustomButton.Name = "";
            this.txtJumlahBarang.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtJumlahBarang.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtJumlahBarang.CustomButton.TabIndex = 1;
            this.txtJumlahBarang.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtJumlahBarang.CustomButton.UseSelectable = true;
            this.txtJumlahBarang.CustomButton.Visible = false;
            this.txtJumlahBarang.Lines = new string[0];
            this.txtJumlahBarang.Location = new System.Drawing.Point(240, 100);
            this.txtJumlahBarang.MaxLength = 32767;
            this.txtJumlahBarang.Name = "txtJumlahBarang";
            this.txtJumlahBarang.PasswordChar = '\0';
            this.txtJumlahBarang.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtJumlahBarang.SelectedText = "";
            this.txtJumlahBarang.SelectionLength = 0;
            this.txtJumlahBarang.SelectionStart = 0;
            this.txtJumlahBarang.ShortcutsEnabled = true;
            this.txtJumlahBarang.Size = new System.Drawing.Size(145, 23);
            this.txtJumlahBarang.TabIndex = 8;
            this.txtJumlahBarang.UseSelectable = true;
            this.txtJumlahBarang.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtJumlahBarang.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtJumlahBarang.TextChanged += new System.EventHandler(this.txtJumlahBarang_TextChanged);
            // 
            // customBrowseButton1
            // 
            this.customBrowseButton1.BackColor = System.Drawing.Color.LightGray;
            this.customBrowseButton1.Location = new System.Drawing.Point(355, 65);
            this.customBrowseButton1.Name = "customBrowseButton1";
            this.customBrowseButton1.Size = new System.Drawing.Size(30, 25);
            this.customBrowseButton1.TabIndex = 7;
            this.customBrowseButton1.UseSelectable = true;
            this.customBrowseButton1.Click += new System.EventHandler(this.customBrowseButton1_Click);
            // 
            // txtSupplier
            // 
            // 
            // 
            // 
            this.txtSupplier.CustomButton.Image = null;
            this.txtSupplier.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.txtSupplier.CustomButton.Name = "";
            this.txtSupplier.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSupplier.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSupplier.CustomButton.TabIndex = 1;
            this.txtSupplier.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSupplier.CustomButton.UseSelectable = true;
            this.txtSupplier.CustomButton.Visible = false;
            this.txtSupplier.Enabled = false;
            this.txtSupplier.Lines = new string[0];
            this.txtSupplier.Location = new System.Drawing.Point(240, 65);
            this.txtSupplier.MaxLength = 32767;
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.PasswordChar = '\0';
            this.txtSupplier.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSupplier.SelectedText = "";
            this.txtSupplier.SelectionLength = 0;
            this.txtSupplier.SelectionStart = 0;
            this.txtSupplier.ShortcutsEnabled = true;
            this.txtSupplier.Size = new System.Drawing.Size(117, 23);
            this.txtSupplier.TabIndex = 6;
            this.txtSupplier.UseSelectable = true;
            this.txtSupplier.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSupplier.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // browseBarang
            // 
            this.browseBarang.BackColor = System.Drawing.Color.LightGray;
            this.browseBarang.Location = new System.Drawing.Point(355, 30);
            this.browseBarang.Name = "browseBarang";
            this.browseBarang.Size = new System.Drawing.Size(30, 25);
            this.browseBarang.TabIndex = 5;
            this.browseBarang.UseSelectable = true;
            this.browseBarang.Click += new System.EventHandler(this.browseBarang_Click);
            // 
            // txtBarang
            // 
            // 
            // 
            // 
            this.txtBarang.CustomButton.Image = null;
            this.txtBarang.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.txtBarang.CustomButton.Name = "";
            this.txtBarang.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBarang.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBarang.CustomButton.TabIndex = 1;
            this.txtBarang.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBarang.CustomButton.UseSelectable = true;
            this.txtBarang.CustomButton.Visible = false;
            this.txtBarang.Enabled = false;
            this.txtBarang.Lines = new string[0];
            this.txtBarang.Location = new System.Drawing.Point(240, 30);
            this.txtBarang.MaxLength = 32767;
            this.txtBarang.Name = "txtBarang";
            this.txtBarang.PasswordChar = '\0';
            this.txtBarang.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBarang.SelectedText = "";
            this.txtBarang.SelectionLength = 0;
            this.txtBarang.SelectionStart = 0;
            this.txtBarang.ShortcutsEnabled = true;
            this.txtBarang.Size = new System.Drawing.Size(117, 23);
            this.txtBarang.TabIndex = 4;
            this.txtBarang.UseSelectable = true;
            this.txtBarang.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBarang.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(100, 135);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(76, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Total Harga";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(100, 100);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(96, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Jumlah Barang";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(100, 65);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Supplier";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(100, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Barang";
            // 
            // tpPenjualan
            // 
            this.tpPenjualan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tpPenjualan.Controls.Add(this.btnJual);
            this.tpPenjualan.Controls.Add(this.txtTotalHargaJual);
            this.tpPenjualan.Controls.Add(this.txtJumlahBarangJual);
            this.tpPenjualan.Controls.Add(this.browseCustomer);
            this.tpPenjualan.Controls.Add(this.txtCustomer);
            this.tpPenjualan.Controls.Add(this.browseBarangJual);
            this.tpPenjualan.Controls.Add(this.txtBarangJual);
            this.tpPenjualan.Controls.Add(this.metroLabel5);
            this.tpPenjualan.Controls.Add(this.metroLabel6);
            this.tpPenjualan.Controls.Add(this.metroLabel7);
            this.tpPenjualan.Controls.Add(this.metroLabel8);
            this.tpPenjualan.Location = new System.Drawing.Point(4, 38);
            this.tpPenjualan.Name = "tpPenjualan";
            this.tpPenjualan.Size = new System.Drawing.Size(540, 407);
            this.tpPenjualan.TabIndex = 1;
            this.tpPenjualan.Text = "Penjualan";
            // 
            // btnJual
            // 
            this.btnJual.Location = new System.Drawing.Point(268, 184);
            this.btnJual.Name = "btnJual";
            this.btnJual.Size = new System.Drawing.Size(145, 23);
            this.btnJual.TabIndex = 21;
            this.btnJual.Text = "Jual";
            this.btnJual.UseSelectable = true;
            this.btnJual.Click += new System.EventHandler(this.btnJual_Click);
            // 
            // txtTotalHargaJual
            // 
            // 
            // 
            // 
            this.txtTotalHargaJual.CustomButton.Image = null;
            this.txtTotalHargaJual.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.txtTotalHargaJual.CustomButton.Name = "";
            this.txtTotalHargaJual.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalHargaJual.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalHargaJual.CustomButton.TabIndex = 1;
            this.txtTotalHargaJual.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalHargaJual.CustomButton.UseSelectable = true;
            this.txtTotalHargaJual.CustomButton.Visible = false;
            this.txtTotalHargaJual.Enabled = false;
            this.txtTotalHargaJual.Lines = new string[0];
            this.txtTotalHargaJual.Location = new System.Drawing.Point(268, 129);
            this.txtTotalHargaJual.MaxLength = 32767;
            this.txtTotalHargaJual.Name = "txtTotalHargaJual";
            this.txtTotalHargaJual.PasswordChar = '\0';
            this.txtTotalHargaJual.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalHargaJual.SelectedText = "";
            this.txtTotalHargaJual.SelectionLength = 0;
            this.txtTotalHargaJual.SelectionStart = 0;
            this.txtTotalHargaJual.ShortcutsEnabled = true;
            this.txtTotalHargaJual.Size = new System.Drawing.Size(145, 23);
            this.txtTotalHargaJual.TabIndex = 20;
            this.txtTotalHargaJual.UseSelectable = true;
            this.txtTotalHargaJual.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalHargaJual.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtJumlahBarangJual
            // 
            // 
            // 
            // 
            this.txtJumlahBarangJual.CustomButton.Image = null;
            this.txtJumlahBarangJual.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.txtJumlahBarangJual.CustomButton.Name = "";
            this.txtJumlahBarangJual.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtJumlahBarangJual.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtJumlahBarangJual.CustomButton.TabIndex = 1;
            this.txtJumlahBarangJual.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtJumlahBarangJual.CustomButton.UseSelectable = true;
            this.txtJumlahBarangJual.CustomButton.Visible = false;
            this.txtJumlahBarangJual.Lines = new string[0];
            this.txtJumlahBarangJual.Location = new System.Drawing.Point(268, 94);
            this.txtJumlahBarangJual.MaxLength = 32767;
            this.txtJumlahBarangJual.Name = "txtJumlahBarangJual";
            this.txtJumlahBarangJual.PasswordChar = '\0';
            this.txtJumlahBarangJual.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtJumlahBarangJual.SelectedText = "";
            this.txtJumlahBarangJual.SelectionLength = 0;
            this.txtJumlahBarangJual.SelectionStart = 0;
            this.txtJumlahBarangJual.ShortcutsEnabled = true;
            this.txtJumlahBarangJual.Size = new System.Drawing.Size(145, 23);
            this.txtJumlahBarangJual.TabIndex = 19;
            this.txtJumlahBarangJual.UseSelectable = true;
            this.txtJumlahBarangJual.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtJumlahBarangJual.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtJumlahBarangJual.TextChanged += new System.EventHandler(this.txtJumlahBarangJual_TextChanged);
            // 
            // browseCustomer
            // 
            this.browseCustomer.BackColor = System.Drawing.Color.LightGray;
            this.browseCustomer.Location = new System.Drawing.Point(383, 59);
            this.browseCustomer.Name = "browseCustomer";
            this.browseCustomer.Size = new System.Drawing.Size(30, 25);
            this.browseCustomer.TabIndex = 18;
            this.browseCustomer.UseSelectable = true;
            this.browseCustomer.Click += new System.EventHandler(this.browseCustomer_Click);
            // 
            // txtCustomer
            // 
            // 
            // 
            // 
            this.txtCustomer.CustomButton.Image = null;
            this.txtCustomer.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.txtCustomer.CustomButton.Name = "";
            this.txtCustomer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCustomer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomer.CustomButton.TabIndex = 1;
            this.txtCustomer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomer.CustomButton.UseSelectable = true;
            this.txtCustomer.CustomButton.Visible = false;
            this.txtCustomer.Enabled = false;
            this.txtCustomer.Lines = new string[0];
            this.txtCustomer.Location = new System.Drawing.Point(268, 59);
            this.txtCustomer.MaxLength = 32767;
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.PasswordChar = '\0';
            this.txtCustomer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomer.SelectedText = "";
            this.txtCustomer.SelectionLength = 0;
            this.txtCustomer.SelectionStart = 0;
            this.txtCustomer.ShortcutsEnabled = true;
            this.txtCustomer.Size = new System.Drawing.Size(117, 23);
            this.txtCustomer.TabIndex = 17;
            this.txtCustomer.UseSelectable = true;
            this.txtCustomer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // browseBarangJual
            // 
            this.browseBarangJual.BackColor = System.Drawing.Color.LightGray;
            this.browseBarangJual.Location = new System.Drawing.Point(383, 24);
            this.browseBarangJual.Name = "browseBarangJual";
            this.browseBarangJual.Size = new System.Drawing.Size(30, 25);
            this.browseBarangJual.TabIndex = 16;
            this.browseBarangJual.UseSelectable = true;
            this.browseBarangJual.Click += new System.EventHandler(this.browseBarangJual_Click);
            // 
            // txtBarangJual
            // 
            // 
            // 
            // 
            this.txtBarangJual.CustomButton.Image = null;
            this.txtBarangJual.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.txtBarangJual.CustomButton.Name = "";
            this.txtBarangJual.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBarangJual.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBarangJual.CustomButton.TabIndex = 1;
            this.txtBarangJual.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBarangJual.CustomButton.UseSelectable = true;
            this.txtBarangJual.CustomButton.Visible = false;
            this.txtBarangJual.Enabled = false;
            this.txtBarangJual.Lines = new string[0];
            this.txtBarangJual.Location = new System.Drawing.Point(268, 24);
            this.txtBarangJual.MaxLength = 32767;
            this.txtBarangJual.Name = "txtBarangJual";
            this.txtBarangJual.PasswordChar = '\0';
            this.txtBarangJual.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBarangJual.SelectedText = "";
            this.txtBarangJual.SelectionLength = 0;
            this.txtBarangJual.SelectionStart = 0;
            this.txtBarangJual.ShortcutsEnabled = true;
            this.txtBarangJual.Size = new System.Drawing.Size(117, 23);
            this.txtBarangJual.TabIndex = 15;
            this.txtBarangJual.UseSelectable = true;
            this.txtBarangJual.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBarangJual.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(128, 129);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(76, 19);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Total Harga";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(128, 94);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(96, 19);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Jumlah Barang";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(128, 59);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(66, 19);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "Customer";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(128, 24);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(51, 19);
            this.metroLabel8.TabIndex = 11;
            this.metroLabel8.Text = "Barang";
            // 
            // frmTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 529);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "frmTransaksi";
            this.Text = "frmTransaksi";
            this.metroTabControl1.ResumeLayout(false);
            this.tpPembelian.ResumeLayout(false);
            this.tpPembelian.PerformLayout();
            this.tpPenjualan.ResumeLayout(false);
            this.tpPenjualan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tpPembelian;
        private MetroFramework.Controls.MetroButton btnBeli;
        private MetroFramework.Controls.MetroTextBox txtTotalHarga;
        private MetroFramework.Controls.MetroTextBox txtJumlahBarang;
        private Lib.User_Control.CustomBrowseButton customBrowseButton1;
        private MetroFramework.Controls.MetroTextBox txtSupplier;
        private Lib.User_Control.CustomBrowseButton browseBarang;
        private MetroFramework.Controls.MetroTextBox txtBarang;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TabPage tpPenjualan;
        private MetroFramework.Controls.MetroButton btnJual;
        private MetroFramework.Controls.MetroTextBox txtTotalHargaJual;
        private MetroFramework.Controls.MetroTextBox txtJumlahBarangJual;
        private Lib.User_Control.CustomBrowseButton browseCustomer;
        private MetroFramework.Controls.MetroTextBox txtCustomer;
        private Lib.User_Control.CustomBrowseButton browseBarangJual;
        private MetroFramework.Controls.MetroTextBox txtBarangJual;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
    }
}
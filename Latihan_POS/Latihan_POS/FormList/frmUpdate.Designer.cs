﻿namespace Latihan_POS.FormList
{
    partial class frmUpdate
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
            this.btnUpdateCust = new MetroFramework.Controls.MetroButton();
            this.rboWanitaCust = new MetroFramework.Controls.MetroRadioButton();
            this.rboPriaCust = new MetroFramework.Controls.MetroRadioButton();
            this.txtNoHpCust = new MetroFramework.Controls.MetroTextBox();
            this.txtAlamatCust = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.mtpCust = new System.Windows.Forms.TabPage();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.rboWanitaSup = new MetroFramework.Controls.MetroRadioButton();
            this.rboPriaSup = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.btnUpdateSup = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.mtpBarang = new System.Windows.Forms.TabPage();
            this.btnBrowse = new Latihan_POS.Lib.User_Control.CustomBrowseButton();
            this.txtKodeBarang = new MetroFramework.Controls.MetroTextBox();
            this.btnUpdateItem = new MetroFramework.Controls.MetroButton();
            this.txtHargaJual = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtHpp = new MetroFramework.Controls.MetroTextBox();
            this.txtJumlah = new MetroFramework.Controls.MetroTextBox();
            this.txtNama = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtpSupplier = new System.Windows.Forms.TabPage();
            this.mTxtNoHpSup = new MetroFramework.Controls.MetroTextBox();
            this.mTxtAlamatSup = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtNamaSupplier = new MetroFramework.Controls.MetroTextBox();
            this.browseSupplier = new Latihan_POS.Lib.User_Control.CustomBrowseButton();
            this.browseCust = new Latihan_POS.Lib.User_Control.CustomBrowseButton();
            this.txtNamaCust = new MetroFramework.Controls.MetroTextBox();
            this.mtpCust.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.mtpBarang.SuspendLayout();
            this.mtpSupplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateCust
            // 
            this.btnUpdateCust.Location = new System.Drawing.Point(240, 158);
            this.btnUpdateCust.Name = "btnUpdateCust";
            this.btnUpdateCust.Size = new System.Drawing.Size(133, 23);
            this.btnUpdateCust.TabIndex = 9;
            this.btnUpdateCust.Text = "Update";
            this.btnUpdateCust.UseSelectable = true;
            this.btnUpdateCust.Click += new System.EventHandler(this.btnUpdateCust_Click);
            // 
            // rboWanitaCust
            // 
            this.rboWanitaCust.AutoSize = true;
            this.rboWanitaCust.Location = new System.Drawing.Point(298, 115);
            this.rboWanitaCust.Name = "rboWanitaCust";
            this.rboWanitaCust.Size = new System.Drawing.Size(60, 15);
            this.rboWanitaCust.TabIndex = 8;
            this.rboWanitaCust.Text = "Wanita";
            this.rboWanitaCust.UseSelectable = true;
            // 
            // rboPriaCust
            // 
            this.rboPriaCust.AutoSize = true;
            this.rboPriaCust.Location = new System.Drawing.Point(240, 115);
            this.rboPriaCust.Name = "rboPriaCust";
            this.rboPriaCust.Size = new System.Drawing.Size(43, 15);
            this.rboPriaCust.TabIndex = 7;
            this.rboPriaCust.Text = "Pria";
            this.rboPriaCust.UseSelectable = true;
            // 
            // txtNoHpCust
            // 
            // 
            // 
            // 
            this.txtNoHpCust.CustomButton.Image = null;
            this.txtNoHpCust.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.txtNoHpCust.CustomButton.Name = "";
            this.txtNoHpCust.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNoHpCust.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNoHpCust.CustomButton.TabIndex = 1;
            this.txtNoHpCust.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNoHpCust.CustomButton.UseSelectable = true;
            this.txtNoHpCust.CustomButton.Visible = false;
            this.txtNoHpCust.Lines = new string[0];
            this.txtNoHpCust.Location = new System.Drawing.Point(240, 77);
            this.txtNoHpCust.MaxLength = 32767;
            this.txtNoHpCust.Name = "txtNoHpCust";
            this.txtNoHpCust.PasswordChar = '\0';
            this.txtNoHpCust.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNoHpCust.SelectedText = "";
            this.txtNoHpCust.SelectionLength = 0;
            this.txtNoHpCust.SelectionStart = 0;
            this.txtNoHpCust.ShortcutsEnabled = true;
            this.txtNoHpCust.Size = new System.Drawing.Size(133, 23);
            this.txtNoHpCust.TabIndex = 6;
            this.txtNoHpCust.UseSelectable = true;
            this.txtNoHpCust.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNoHpCust.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNoHpCust.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoHpCust_KeyPress);
            // 
            // txtAlamatCust
            // 
            // 
            // 
            // 
            this.txtAlamatCust.CustomButton.Image = null;
            this.txtAlamatCust.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.txtAlamatCust.CustomButton.Name = "";
            this.txtAlamatCust.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAlamatCust.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAlamatCust.CustomButton.TabIndex = 1;
            this.txtAlamatCust.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAlamatCust.CustomButton.UseSelectable = true;
            this.txtAlamatCust.CustomButton.Visible = false;
            this.txtAlamatCust.Lines = new string[0];
            this.txtAlamatCust.Location = new System.Drawing.Point(240, 45);
            this.txtAlamatCust.MaxLength = 32767;
            this.txtAlamatCust.Name = "txtAlamatCust";
            this.txtAlamatCust.PasswordChar = '\0';
            this.txtAlamatCust.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAlamatCust.SelectedText = "";
            this.txtAlamatCust.SelectionLength = 0;
            this.txtAlamatCust.SelectionStart = 0;
            this.txtAlamatCust.ShortcutsEnabled = true;
            this.txtAlamatCust.Size = new System.Drawing.Size(133, 23);
            this.txtAlamatCust.TabIndex = 5;
            this.txtAlamatCust.UseSelectable = true;
            this.txtAlamatCust.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAlamatCust.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(75, 115);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(86, 19);
            this.metroLabel13.TabIndex = 3;
            this.metroLabel13.Text = "Jenis Kelamin";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(75, 80);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(48, 19);
            this.metroLabel12.TabIndex = 2;
            this.metroLabel12.Text = "No Hp";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(75, 10);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(45, 19);
            this.metroLabel9.TabIndex = 0;
            this.metroLabel9.Text = "Nama";
            // 
            // mtpCust
            // 
            this.mtpCust.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mtpCust.Controls.Add(this.txtNamaCust);
            this.mtpCust.Controls.Add(this.browseCust);
            this.mtpCust.Controls.Add(this.btnUpdateCust);
            this.mtpCust.Controls.Add(this.rboWanitaCust);
            this.mtpCust.Controls.Add(this.rboPriaCust);
            this.mtpCust.Controls.Add(this.txtNoHpCust);
            this.mtpCust.Controls.Add(this.txtAlamatCust);
            this.mtpCust.Controls.Add(this.metroLabel13);
            this.mtpCust.Controls.Add(this.metroLabel12);
            this.mtpCust.Controls.Add(this.metroLabel10);
            this.mtpCust.Controls.Add(this.metroLabel9);
            this.mtpCust.Location = new System.Drawing.Point(4, 38);
            this.mtpCust.Name = "mtpCust";
            this.mtpCust.Size = new System.Drawing.Size(474, 255);
            this.mtpCust.TabIndex = 2;
            this.mtpCust.Text = "Customer";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(75, 45);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(51, 19);
            this.metroLabel10.TabIndex = 1;
            this.metroLabel10.Text = "Alamat";
            // 
            // rboWanitaSup
            // 
            this.rboWanitaSup.AutoSize = true;
            this.rboWanitaSup.Location = new System.Drawing.Point(300, 130);
            this.rboWanitaSup.Name = "rboWanitaSup";
            this.rboWanitaSup.Size = new System.Drawing.Size(60, 15);
            this.rboWanitaSup.TabIndex = 9;
            this.rboWanitaSup.Text = "Wanita";
            this.rboWanitaSup.UseSelectable = true;
            // 
            // rboPriaSup
            // 
            this.rboPriaSup.AutoSize = true;
            this.rboPriaSup.Location = new System.Drawing.Point(230, 130);
            this.rboPriaSup.Name = "rboPriaSup";
            this.rboPriaSup.Size = new System.Drawing.Size(43, 15);
            this.rboPriaSup.TabIndex = 8;
            this.rboPriaSup.Text = "Pria";
            this.rboPriaSup.UseSelectable = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(72, 120);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(86, 19);
            this.metroLabel11.TabIndex = 7;
            this.metroLabel11.Text = "Jenis Kelamin";
            // 
            // btnUpdateSup
            // 
            this.btnUpdateSup.Location = new System.Drawing.Point(233, 158);
            this.btnUpdateSup.Name = "btnUpdateSup";
            this.btnUpdateSup.Size = new System.Drawing.Size(164, 23);
            this.btnUpdateSup.TabIndex = 6;
            this.btnUpdateSup.Text = "Update";
            this.btnUpdateSup.UseSelectable = true;
            this.btnUpdateSup.Click += new System.EventHandler(this.btnUpdateSup_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.mtpBarang);
            this.metroTabControl1.Controls.Add(this.mtpSupplier);
            this.metroTabControl1.Controls.Add(this.mtpCust);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(482, 297);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // mtpBarang
            // 
            this.mtpBarang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mtpBarang.Controls.Add(this.btnBrowse);
            this.mtpBarang.Controls.Add(this.txtKodeBarang);
            this.mtpBarang.Controls.Add(this.btnUpdateItem);
            this.mtpBarang.Controls.Add(this.txtHargaJual);
            this.mtpBarang.Controls.Add(this.metroLabel5);
            this.mtpBarang.Controls.Add(this.txtHpp);
            this.mtpBarang.Controls.Add(this.txtJumlah);
            this.mtpBarang.Controls.Add(this.txtNama);
            this.mtpBarang.Controls.Add(this.metroLabel4);
            this.mtpBarang.Controls.Add(this.metroLabel3);
            this.mtpBarang.Controls.Add(this.metroLabel2);
            this.mtpBarang.Controls.Add(this.metroLabel1);
            this.mtpBarang.Location = new System.Drawing.Point(4, 38);
            this.mtpBarang.Name = "mtpBarang";
            this.mtpBarang.Size = new System.Drawing.Size(474, 255);
            this.mtpBarang.TabIndex = 0;
            this.mtpBarang.Text = "Barang";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.LightGray;
            this.btnBrowse.Location = new System.Drawing.Point(353, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(30, 25);
            this.btnBrowse.TabIndex = 23;
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtKodeBarang
            // 
            // 
            // 
            // 
            this.txtKodeBarang.CustomButton.Image = null;
            this.txtKodeBarang.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtKodeBarang.CustomButton.Name = "";
            this.txtKodeBarang.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKodeBarang.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKodeBarang.CustomButton.TabIndex = 1;
            this.txtKodeBarang.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKodeBarang.CustomButton.UseSelectable = true;
            this.txtKodeBarang.CustomButton.Visible = false;
            this.txtKodeBarang.Lines = new string[0];
            this.txtKodeBarang.Location = new System.Drawing.Point(233, 13);
            this.txtKodeBarang.MaxLength = 32767;
            this.txtKodeBarang.Name = "txtKodeBarang";
            this.txtKodeBarang.PasswordChar = '\0';
            this.txtKodeBarang.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKodeBarang.SelectedText = "";
            this.txtKodeBarang.SelectionLength = 0;
            this.txtKodeBarang.SelectionStart = 0;
            this.txtKodeBarang.ShortcutsEnabled = true;
            this.txtKodeBarang.Size = new System.Drawing.Size(121, 23);
            this.txtKodeBarang.TabIndex = 22;
            this.txtKodeBarang.UseSelectable = true;
            this.txtKodeBarang.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKodeBarang.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.Location = new System.Drawing.Point(231, 224);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(149, 23);
            this.btnUpdateItem.TabIndex = 21;
            this.btnUpdateItem.Text = "Update";
            this.btnUpdateItem.UseSelectable = true;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // txtHargaJual
            // 
            // 
            // 
            // 
            this.txtHargaJual.CustomButton.Image = null;
            this.txtHargaJual.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtHargaJual.CustomButton.Name = "";
            this.txtHargaJual.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHargaJual.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHargaJual.CustomButton.TabIndex = 1;
            this.txtHargaJual.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHargaJual.CustomButton.UseSelectable = true;
            this.txtHargaJual.CustomButton.Visible = false;
            this.txtHargaJual.Lines = new string[0];
            this.txtHargaJual.Location = new System.Drawing.Point(231, 180);
            this.txtHargaJual.MaxLength = 32767;
            this.txtHargaJual.Name = "txtHargaJual";
            this.txtHargaJual.PasswordChar = '\0';
            this.txtHargaJual.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHargaJual.SelectedText = "";
            this.txtHargaJual.SelectionLength = 0;
            this.txtHargaJual.SelectionStart = 0;
            this.txtHargaJual.ShortcutsEnabled = true;
            this.txtHargaJual.Size = new System.Drawing.Size(149, 23);
            this.txtHargaJual.TabIndex = 20;
            this.txtHargaJual.UseSelectable = true;
            this.txtHargaJual.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHargaJual.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtHargaJual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHargaJual_KeyPress);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel5.Location = new System.Drawing.Point(75, 180);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(71, 19);
            this.metroLabel5.TabIndex = 19;
            this.metroLabel5.Text = "Harga Jual";
            // 
            // txtHpp
            // 
            // 
            // 
            // 
            this.txtHpp.CustomButton.Image = null;
            this.txtHpp.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtHpp.CustomButton.Name = "";
            this.txtHpp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHpp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHpp.CustomButton.TabIndex = 1;
            this.txtHpp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHpp.CustomButton.UseSelectable = true;
            this.txtHpp.CustomButton.Visible = false;
            this.txtHpp.Lines = new string[0];
            this.txtHpp.Location = new System.Drawing.Point(231, 136);
            this.txtHpp.MaxLength = 32767;
            this.txtHpp.Name = "txtHpp";
            this.txtHpp.PasswordChar = '\0';
            this.txtHpp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHpp.SelectedText = "";
            this.txtHpp.SelectionLength = 0;
            this.txtHpp.SelectionStart = 0;
            this.txtHpp.ShortcutsEnabled = true;
            this.txtHpp.Size = new System.Drawing.Size(149, 23);
            this.txtHpp.TabIndex = 18;
            this.txtHpp.UseSelectable = true;
            this.txtHpp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHpp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtHpp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHpp_KeyPress);
            // 
            // txtJumlah
            // 
            // 
            // 
            // 
            this.txtJumlah.CustomButton.Image = null;
            this.txtJumlah.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtJumlah.CustomButton.Name = "";
            this.txtJumlah.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtJumlah.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtJumlah.CustomButton.TabIndex = 1;
            this.txtJumlah.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtJumlah.CustomButton.UseSelectable = true;
            this.txtJumlah.CustomButton.Visible = false;
            this.txtJumlah.Lines = new string[0];
            this.txtJumlah.Location = new System.Drawing.Point(231, 92);
            this.txtJumlah.MaxLength = 32767;
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.PasswordChar = '\0';
            this.txtJumlah.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtJumlah.SelectedText = "";
            this.txtJumlah.SelectionLength = 0;
            this.txtJumlah.SelectionStart = 0;
            this.txtJumlah.ShortcutsEnabled = true;
            this.txtJumlah.Size = new System.Drawing.Size(149, 23);
            this.txtJumlah.TabIndex = 17;
            this.txtJumlah.UseSelectable = true;
            this.txtJumlah.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtJumlah.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtJumlah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJumlah_KeyPress);
            // 
            // txtNama
            // 
            // 
            // 
            // 
            this.txtNama.CustomButton.Image = null;
            this.txtNama.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtNama.CustomButton.Name = "";
            this.txtNama.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNama.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNama.CustomButton.TabIndex = 1;
            this.txtNama.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNama.CustomButton.UseSelectable = true;
            this.txtNama.CustomButton.Visible = false;
            this.txtNama.Lines = new string[0];
            this.txtNama.Location = new System.Drawing.Point(231, 50);
            this.txtNama.MaxLength = 32767;
            this.txtNama.Name = "txtNama";
            this.txtNama.PasswordChar = '\0';
            this.txtNama.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNama.SelectedText = "";
            this.txtNama.SelectionLength = 0;
            this.txtNama.SelectionStart = 0;
            this.txtNama.ShortcutsEnabled = true;
            this.txtNama.Size = new System.Drawing.Size(149, 23);
            this.txtNama.TabIndex = 16;
            this.txtNama.UseSelectable = true;
            this.txtNama.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNama.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.metroLabel4.Location = new System.Drawing.Point(75, 136);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(74, 19);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "Harga HPP";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.metroLabel3.Location = new System.Drawing.Point(75, 92);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(82, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Jumlah Awal";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.metroLabel2.Location = new System.Drawing.Point(75, 50);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Nama";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.metroLabel1.Location = new System.Drawing.Point(75, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(39, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Kode";
            // 
            // mtpSupplier
            // 
            this.mtpSupplier.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mtpSupplier.Controls.Add(this.browseSupplier);
            this.mtpSupplier.Controls.Add(this.txtNamaSupplier);
            this.mtpSupplier.Controls.Add(this.rboWanitaSup);
            this.mtpSupplier.Controls.Add(this.rboPriaSup);
            this.mtpSupplier.Controls.Add(this.metroLabel11);
            this.mtpSupplier.Controls.Add(this.btnUpdateSup);
            this.mtpSupplier.Controls.Add(this.mTxtNoHpSup);
            this.mtpSupplier.Controls.Add(this.mTxtAlamatSup);
            this.mtpSupplier.Controls.Add(this.metroLabel8);
            this.mtpSupplier.Controls.Add(this.metroLabel7);
            this.mtpSupplier.Controls.Add(this.metroLabel6);
            this.mtpSupplier.Location = new System.Drawing.Point(4, 38);
            this.mtpSupplier.Name = "mtpSupplier";
            this.mtpSupplier.Size = new System.Drawing.Size(474, 255);
            this.mtpSupplier.TabIndex = 1;
            this.mtpSupplier.Text = "Supplier";
            // 
            // mTxtNoHpSup
            // 
            // 
            // 
            // 
            this.mTxtNoHpSup.CustomButton.Image = null;
            this.mTxtNoHpSup.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.mTxtNoHpSup.CustomButton.Name = "";
            this.mTxtNoHpSup.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTxtNoHpSup.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtNoHpSup.CustomButton.TabIndex = 1;
            this.mTxtNoHpSup.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtNoHpSup.CustomButton.UseSelectable = true;
            this.mTxtNoHpSup.CustomButton.Visible = false;
            this.mTxtNoHpSup.Lines = new string[0];
            this.mTxtNoHpSup.Location = new System.Drawing.Point(232, 94);
            this.mTxtNoHpSup.MaxLength = 32767;
            this.mTxtNoHpSup.Name = "mTxtNoHpSup";
            this.mTxtNoHpSup.PasswordChar = '\0';
            this.mTxtNoHpSup.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtNoHpSup.SelectedText = "";
            this.mTxtNoHpSup.SelectionLength = 0;
            this.mTxtNoHpSup.SelectionStart = 0;
            this.mTxtNoHpSup.ShortcutsEnabled = true;
            this.mTxtNoHpSup.Size = new System.Drawing.Size(166, 23);
            this.mTxtNoHpSup.TabIndex = 5;
            this.mTxtNoHpSup.UseSelectable = true;
            this.mTxtNoHpSup.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtNoHpSup.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mTxtNoHpSup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mTxtNoHpSup_KeyPress);
            // 
            // mTxtAlamatSup
            // 
            // 
            // 
            // 
            this.mTxtAlamatSup.CustomButton.Image = null;
            this.mTxtAlamatSup.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.mTxtAlamatSup.CustomButton.Name = "";
            this.mTxtAlamatSup.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTxtAlamatSup.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtAlamatSup.CustomButton.TabIndex = 1;
            this.mTxtAlamatSup.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtAlamatSup.CustomButton.UseSelectable = true;
            this.mTxtAlamatSup.CustomButton.Visible = false;
            this.mTxtAlamatSup.Lines = new string[0];
            this.mTxtAlamatSup.Location = new System.Drawing.Point(231, 52);
            this.mTxtAlamatSup.MaxLength = 32767;
            this.mTxtAlamatSup.Name = "mTxtAlamatSup";
            this.mTxtAlamatSup.PasswordChar = '\0';
            this.mTxtAlamatSup.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtAlamatSup.SelectedText = "";
            this.mTxtAlamatSup.SelectionLength = 0;
            this.mTxtAlamatSup.SelectionStart = 0;
            this.mTxtAlamatSup.ShortcutsEnabled = true;
            this.mTxtAlamatSup.Size = new System.Drawing.Size(166, 23);
            this.mTxtAlamatSup.TabIndex = 4;
            this.mTxtAlamatSup.UseSelectable = true;
            this.mTxtAlamatSup.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtAlamatSup.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(72, 89);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(48, 19);
            this.metroLabel8.TabIndex = 2;
            this.metroLabel8.Text = "No HP";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(73, 48);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(51, 19);
            this.metroLabel7.TabIndex = 1;
            this.metroLabel7.Text = "Alamat";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(75, 10);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(45, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Nama";
            // 
            // txtNamaSupplier
            // 
            // 
            // 
            // 
            this.txtNamaSupplier.CustomButton.Image = null;
            this.txtNamaSupplier.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.txtNamaSupplier.CustomButton.Name = "";
            this.txtNamaSupplier.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNamaSupplier.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNamaSupplier.CustomButton.TabIndex = 1;
            this.txtNamaSupplier.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNamaSupplier.CustomButton.UseSelectable = true;
            this.txtNamaSupplier.CustomButton.Visible = false;
            this.txtNamaSupplier.Lines = new string[0];
            this.txtNamaSupplier.Location = new System.Drawing.Point(230, 11);
            this.txtNamaSupplier.MaxLength = 32767;
            this.txtNamaSupplier.Name = "txtNamaSupplier";
            this.txtNamaSupplier.PasswordChar = '\0';
            this.txtNamaSupplier.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNamaSupplier.SelectedText = "";
            this.txtNamaSupplier.SelectionLength = 0;
            this.txtNamaSupplier.SelectionStart = 0;
            this.txtNamaSupplier.ShortcutsEnabled = true;
            this.txtNamaSupplier.Size = new System.Drawing.Size(141, 23);
            this.txtNamaSupplier.TabIndex = 10;
            this.txtNamaSupplier.UseSelectable = true;
            this.txtNamaSupplier.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNamaSupplier.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // browseSupplier
            // 
            this.browseSupplier.BackColor = System.Drawing.Color.LightGray;
            this.browseSupplier.Location = new System.Drawing.Point(370, 10);
            this.browseSupplier.Name = "browseSupplier";
            this.browseSupplier.Size = new System.Drawing.Size(30, 25);
            this.browseSupplier.TabIndex = 11;
            this.browseSupplier.UseSelectable = true;
            this.browseSupplier.Click += new System.EventHandler(this.browseSupplier_Click);
            // 
            // browseCust
            // 
            this.browseCust.BackColor = System.Drawing.Color.LightGray;
            this.browseCust.Location = new System.Drawing.Point(349, 8);
            this.browseCust.Name = "browseCust";
            this.browseCust.Size = new System.Drawing.Size(30, 25);
            this.browseCust.TabIndex = 10;
            this.browseCust.UseSelectable = true;
            this.browseCust.Click += new System.EventHandler(this.browseCust_Click);
            // 
            // txtNamaCust
            // 
            // 
            // 
            // 
            this.txtNamaCust.CustomButton.Image = null;
            this.txtNamaCust.CustomButton.Location = new System.Drawing.Point(89, 1);
            this.txtNamaCust.CustomButton.Name = "";
            this.txtNamaCust.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNamaCust.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNamaCust.CustomButton.TabIndex = 1;
            this.txtNamaCust.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNamaCust.CustomButton.UseSelectable = true;
            this.txtNamaCust.CustomButton.Visible = false;
            this.txtNamaCust.Lines = new string[0];
            this.txtNamaCust.Location = new System.Drawing.Point(240, 9);
            this.txtNamaCust.MaxLength = 32767;
            this.txtNamaCust.Name = "txtNamaCust";
            this.txtNamaCust.PasswordChar = '\0';
            this.txtNamaCust.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNamaCust.SelectedText = "";
            this.txtNamaCust.SelectionLength = 0;
            this.txtNamaCust.SelectionStart = 0;
            this.txtNamaCust.ShortcutsEnabled = true;
            this.txtNamaCust.Size = new System.Drawing.Size(111, 23);
            this.txtNamaCust.TabIndex = 11;
            this.txtNamaCust.UseSelectable = true;
            this.txtNamaCust.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNamaCust.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 377);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "frmUpdate";
            this.Text = "frmUpdate";
            this.mtpCust.ResumeLayout(false);
            this.mtpCust.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.mtpBarang.ResumeLayout(false);
            this.mtpBarang.PerformLayout();
            this.mtpSupplier.ResumeLayout(false);
            this.mtpSupplier.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnUpdateCust;
        private MetroFramework.Controls.MetroRadioButton rboWanitaCust;
        private MetroFramework.Controls.MetroRadioButton rboPriaCust;
        private MetroFramework.Controls.MetroTextBox txtNoHpCust;
        private MetroFramework.Controls.MetroTextBox txtAlamatCust;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.TabPage mtpCust;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroRadioButton rboWanitaSup;
        private MetroFramework.Controls.MetroRadioButton rboPriaSup;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroButton btnUpdateSup;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage mtpBarang;
        private MetroFramework.Controls.MetroButton btnUpdateItem;
        private MetroFramework.Controls.MetroTextBox txtHargaJual;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtHpp;
        private MetroFramework.Controls.MetroTextBox txtJumlah;
        private MetroFramework.Controls.MetroTextBox txtNama;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TabPage mtpSupplier;
        private MetroFramework.Controls.MetroTextBox mTxtNoHpSup;
        private MetroFramework.Controls.MetroTextBox mTxtAlamatSup;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private Lib.User_Control.CustomBrowseButton btnBrowse;
        private MetroFramework.Controls.MetroTextBox txtKodeBarang;
        private MetroFramework.Controls.MetroTextBox txtNamaCust;
        private Lib.User_Control.CustomBrowseButton browseCust;
        private Lib.User_Control.CustomBrowseButton browseSupplier;
        private MetroFramework.Controls.MetroTextBox txtNamaSupplier;
    }
}
namespace Latihan_POS.FormList
{
    partial class frmHapus
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
            this.btnHapusSupplier = new MetroFramework.Controls.MetroButton();
            this.mtpCust = new System.Windows.Forms.TabPage();
            this.btnHapusCust = new MetroFramework.Controls.MetroButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.mtpBarang = new System.Windows.Forms.TabPage();
            this.btnHapusBarang = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtpSupplier = new System.Windows.Forms.TabPage();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.browseItemUserControl1 = new Latihan_POS.Lib.User_Control.BrowseItemUserControl();
            this.browseSupplierUserControl1 = new Latihan_POS.Lib.User_Control.BrowseSupplierUserControl();
            this.browseCustomerUserControl1 = new Latihan_POS.Lib.User_Control.BrowseCustomerUserControl();
            this.mtpCust.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.mtpBarang.SuspendLayout();
            this.mtpSupplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHapusSupplier
            // 
            this.btnHapusSupplier.Location = new System.Drawing.Point(220, 80);
            this.btnHapusSupplier.Name = "btnHapusSupplier";
            this.btnHapusSupplier.Size = new System.Drawing.Size(134, 23);
            this.btnHapusSupplier.TabIndex = 6;
            this.btnHapusSupplier.Text = "Hapus Sup";
            this.btnHapusSupplier.UseSelectable = true;
            this.btnHapusSupplier.Click += new System.EventHandler(this.btnHapusSupplier_Click);
            // 
            // mtpCust
            // 
            this.mtpCust.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mtpCust.Controls.Add(this.browseCustomerUserControl1);
            this.mtpCust.Controls.Add(this.btnHapusCust);
            this.mtpCust.Controls.Add(this.metroLabel9);
            this.mtpCust.Location = new System.Drawing.Point(4, 38);
            this.mtpCust.Name = "mtpCust";
            this.mtpCust.Size = new System.Drawing.Size(474, 255);
            this.mtpCust.TabIndex = 2;
            this.mtpCust.Text = "Customer";
            // 
            // btnHapusCust
            // 
            this.btnHapusCust.Location = new System.Drawing.Point(220, 80);
            this.btnHapusCust.Name = "btnHapusCust";
            this.btnHapusCust.Size = new System.Drawing.Size(133, 23);
            this.btnHapusCust.TabIndex = 9;
            this.btnHapusCust.Text = "Hapus Cust";
            this.btnHapusCust.UseSelectable = true;
            this.btnHapusCust.Click += new System.EventHandler(this.btnHapusCust_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(75, 41);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(45, 19);
            this.metroLabel9.TabIndex = 0;
            this.metroLabel9.Text = "Nama";
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
            this.mtpBarang.Controls.Add(this.browseItemUserControl1);
            this.mtpBarang.Controls.Add(this.btnHapusBarang);
            this.mtpBarang.Controls.Add(this.metroLabel3);
            this.mtpBarang.Location = new System.Drawing.Point(4, 38);
            this.mtpBarang.Name = "mtpBarang";
            this.mtpBarang.Size = new System.Drawing.Size(474, 255);
            this.mtpBarang.TabIndex = 0;
            this.mtpBarang.Text = "Barang";
            // 
            // btnHapusBarang
            // 
            this.btnHapusBarang.Location = new System.Drawing.Point(215, 80);
            this.btnHapusBarang.Name = "btnHapusBarang";
            this.btnHapusBarang.Size = new System.Drawing.Size(140, 23);
            this.btnHapusBarang.TabIndex = 6;
            this.btnHapusBarang.Text = "Hapus";
            this.btnHapusBarang.UseSelectable = true;
            this.btnHapusBarang.Click += new System.EventHandler(this.btnHapusBarang_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(75, 41);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Barang";
            // 
            // mtpSupplier
            // 
            this.mtpSupplier.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mtpSupplier.Controls.Add(this.browseSupplierUserControl1);
            this.mtpSupplier.Controls.Add(this.btnHapusSupplier);
            this.mtpSupplier.Controls.Add(this.metroLabel6);
            this.mtpSupplier.Location = new System.Drawing.Point(4, 38);
            this.mtpSupplier.Name = "mtpSupplier";
            this.mtpSupplier.Size = new System.Drawing.Size(474, 255);
            this.mtpSupplier.TabIndex = 1;
            this.mtpSupplier.Text = "Supplier";
            this.mtpSupplier.Click += new System.EventHandler(this.mtpSupplier_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(75, 41);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(45, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Nama";
            // 
            // browseItemUserControl1
            // 
            this.browseItemUserControl1.Location = new System.Drawing.Point(150, 41);
            this.browseItemUserControl1.Name = "browseItemUserControl1";
            this.browseItemUserControl1.Size = new System.Drawing.Size(273, 24);
            this.browseItemUserControl1.TabIndex = 7;
            // 
            // browseSupplierUserControl1
            // 
            this.browseSupplierUserControl1.Location = new System.Drawing.Point(150, 41);
            this.browseSupplierUserControl1.Name = "browseSupplierUserControl1";
            this.browseSupplierUserControl1.Size = new System.Drawing.Size(273, 24);
            this.browseSupplierUserControl1.TabIndex = 7;
            // 
            // browseCustomerUserControl1
            // 
            this.browseCustomerUserControl1.Location = new System.Drawing.Point(150, 41);
            this.browseCustomerUserControl1.Name = "browseCustomerUserControl1";
            this.browseCustomerUserControl1.Size = new System.Drawing.Size(273, 24);
            this.browseCustomerUserControl1.TabIndex = 10;
            // 
            // frmHapus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 377);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "frmHapus";
            this.Text = "frmHapus";
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

        private MetroFramework.Controls.MetroButton btnHapusSupplier;
        private System.Windows.Forms.TabPage mtpCust;
        private MetroFramework.Controls.MetroButton btnHapusCust;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage mtpBarang;
        private System.Windows.Forms.TabPage mtpSupplier;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton btnHapusBarang;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private Lib.User_Control.BrowseCustomerUserControl browseCustomerUserControl1;
        private Lib.User_Control.BrowseSupplierUserControl browseSupplierUserControl1;
        private Lib.User_Control.BrowseItemUserControl browseItemUserControl1;
    }
}
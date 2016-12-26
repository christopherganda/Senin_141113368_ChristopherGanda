namespace Latihan_POS
{
    partial class MainForm
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnTampil = new MetroFramework.Controls.MetroButton();
            this.btnHapus = new MetroFramework.Controls.MetroButton();
            this.tileClose = new MetroFramework.Controls.MetroTile();
            this.btnRegister = new MetroFramework.Controls.MetroButton();
            this.btnTampilTransaksi = new MetroFramework.Controls.MetroButton();
            this.btnTransaksi = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(20, 60);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer.Panel1.Controls.Add(this.btnTransaksi);
            this.splitContainer.Panel1.Controls.Add(this.btnTampilTransaksi);
            this.splitContainer.Panel1.Controls.Add(this.btnUpdate);
            this.splitContainer.Panel1.Controls.Add(this.btnTampil);
            this.splitContainer.Panel1.Controls.Add(this.btnHapus);
            this.splitContainer.Panel1.Controls.Add(this.tileClose);
            this.splitContainer.Panel1.Controls.Add(this.btnRegister);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.Aqua;
            this.splitContainer.Size = new System.Drawing.Size(1304, 642);
            this.splitContainer.SplitterDistance = 434;
            this.splitContainer.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(17, 87);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 50);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnTampil
            // 
            this.btnTampil.Location = new System.Drawing.Point(249, 15);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(87, 50);
            this.btnTampil.TabIndex = 3;
            this.btnTampil.Text = "Tampil";
            this.btnTampil.UseSelectable = true;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(135, 15);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(87, 50);
            this.btnHapus.TabIndex = 2;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseSelectable = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // tileClose
            // 
            this.tileClose.ActiveControl = null;
            this.tileClose.Location = new System.Drawing.Point(17, 568);
            this.tileClose.Name = "tileClose";
            this.tileClose.Size = new System.Drawing.Size(75, 60);
            this.tileClose.TabIndex = 1;
            this.tileClose.Text = "Close";
            this.tileClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileClose.UseSelectable = true;
            this.tileClose.Click += new System.EventHandler(this.tileClose_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(17, 15);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(92, 50);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseSelectable = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnTampilTransaksi
            // 
            this.btnTampilTransaksi.Location = new System.Drawing.Point(135, 87);
            this.btnTampilTransaksi.Name = "btnTampilTransaksi";
            this.btnTampilTransaksi.Size = new System.Drawing.Size(87, 50);
            this.btnTampilTransaksi.TabIndex = 5;
            this.btnTampilTransaksi.Text = "Tampil Transaksi";
            this.btnTampilTransaksi.UseSelectable = true;
            this.btnTampilTransaksi.Click += new System.EventHandler(this.btnTampilTransaksi_Click);
            // 
            // btnTransaksi
            // 
            this.btnTransaksi.Location = new System.Drawing.Point(249, 87);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Size = new System.Drawing.Size(87, 50);
            this.btnTransaksi.TabIndex = 6;
            this.btnTransaksi.Text = "Transaksi";
            this.btnTransaksi.UseSelectable = true;
            this.btnTransaksi.Click += new System.EventHandler(this.btnTransaksi_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 722);
            this.Controls.Add(this.splitContainer);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Main";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private MetroFramework.Controls.MetroButton btnRegister;
        private MetroFramework.Controls.MetroTile tileClose;
        private MetroFramework.Controls.MetroButton btnHapus;
        private MetroFramework.Controls.MetroButton btnTampil;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnTampilTransaksi;
        private MetroFramework.Controls.MetroButton btnTransaksi;
    }
}
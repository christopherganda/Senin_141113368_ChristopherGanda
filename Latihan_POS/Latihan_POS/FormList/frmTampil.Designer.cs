namespace Latihan_POS.FormList
{
    partial class frmTampil
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbBoxTabel = new MetroFramework.Controls.MetroComboBox();
            this.btnTampil = new MetroFramework.Controls.MetroButton();
            this.dgvTampil = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTampil)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(55, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Tabel";
            // 
            // cmbBoxTabel
            // 
            this.cmbBoxTabel.FormattingEnabled = true;
            this.cmbBoxTabel.ItemHeight = 23;
            this.cmbBoxTabel.Items.AddRange(new object[] {
            "customer",
            "item",
            "supplier"});
            this.cmbBoxTabel.Location = new System.Drawing.Point(127, 72);
            this.cmbBoxTabel.Name = "cmbBoxTabel";
            this.cmbBoxTabel.Size = new System.Drawing.Size(121, 29);
            this.cmbBoxTabel.TabIndex = 1;
            this.cmbBoxTabel.UseSelectable = true;
            // 
            // btnTampil
            // 
            this.btnTampil.Location = new System.Drawing.Point(307, 72);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(105, 29);
            this.btnTampil.TabIndex = 2;
            this.btnTampil.Text = "Tampil";
            this.btnTampil.UseSelectable = true;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // dgvTampil
            // 
            this.dgvTampil.AllowUserToAddRows = false;
            this.dgvTampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTampil.Location = new System.Drawing.Point(23, 130);
            this.dgvTampil.Name = "dgvTampil";
            this.dgvTampil.ReadOnly = true;
            this.dgvTampil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTampil.Size = new System.Drawing.Size(476, 224);
            this.dgvTampil.TabIndex = 3;
            // 
            // frmTampil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 377);
            this.Controls.Add(this.dgvTampil);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.cmbBoxTabel);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmTampil";
            this.Text = "frmTampil";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTampil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbBoxTabel;
        private MetroFramework.Controls.MetroButton btnTampil;
        private System.Windows.Forms.DataGridView dgvTampil;
    }
}
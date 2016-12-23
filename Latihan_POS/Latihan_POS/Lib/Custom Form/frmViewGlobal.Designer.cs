namespace Latihan_POS.Lib.Custom_Form
{
    partial class frmViewGlobal
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
            this.dgvBrowse = new System.Windows.Forms.DataGridView();
            this.btnTampil = new MetroFramework.Controls.MetroButton();
            this.cmbBoxTabel = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtFilter = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrowse)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBrowse
            // 
            this.dgvBrowse.AllowUserToAddRows = false;
            this.dgvBrowse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBrowse.Location = new System.Drawing.Point(23, 126);
            this.dgvBrowse.Name = "dgvBrowse";
            this.dgvBrowse.ReadOnly = true;
            this.dgvBrowse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBrowse.Size = new System.Drawing.Size(476, 248);
            this.dgvBrowse.TabIndex = 7;
            // 
            // btnTampil
            // 
            this.btnTampil.Location = new System.Drawing.Point(307, 59);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(105, 29);
            this.btnTampil.TabIndex = 6;
            this.btnTampil.Text = "Tampil";
            this.btnTampil.UseSelectable = true;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // cmbBoxTabel
            // 
            this.cmbBoxTabel.FormattingEnabled = true;
            this.cmbBoxTabel.ItemHeight = 23;
            this.cmbBoxTabel.Location = new System.Drawing.Point(127, 59);
            this.cmbBoxTabel.Name = "cmbBoxTabel";
            this.cmbBoxTabel.Size = new System.Drawing.Size(121, 29);
            this.cmbBoxTabel.TabIndex = 5;
            this.cmbBoxTabel.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(55, 59);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Tabel";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(19, 100);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Filter";
            // 
            // txtFilter
            // 
            // 
            // 
            // 
            this.txtFilter.CustomButton.Image = null;
            this.txtFilter.CustomButton.Location = new System.Drawing.Point(400, 1);
            this.txtFilter.CustomButton.Name = "";
            this.txtFilter.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFilter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFilter.CustomButton.TabIndex = 1;
            this.txtFilter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFilter.CustomButton.UseSelectable = true;
            this.txtFilter.CustomButton.Visible = false;
            this.txtFilter.Lines = new string[0];
            this.txtFilter.Location = new System.Drawing.Point(77, 98);
            this.txtFilter.MaxLength = 32767;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PasswordChar = '\0';
            this.txtFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilter.SelectedText = "";
            this.txtFilter.SelectionLength = 0;
            this.txtFilter.SelectionStart = 0;
            this.txtFilter.ShortcutsEnabled = true;
            this.txtFilter.Size = new System.Drawing.Size(422, 23);
            this.txtFilter.TabIndex = 9;
            this.txtFilter.UseSelectable = true;
            this.txtFilter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFilter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // frmViewGlobal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 401);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.dgvBrowse);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.cmbBoxTabel);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmViewGlobal";
            this.Text = "frmViewGlobal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrowse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBrowse;
        private MetroFramework.Controls.MetroButton btnTampil;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtFilter;
        protected MetroFramework.Controls.MetroComboBox cmbBoxTabel;

    }
}
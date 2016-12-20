namespace Latihan_POS.Lib.User_Control
{
    partial class ItemUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtItem = new MetroFramework.Controls.MetroTextBox();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.txtNamaBarang = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // txtItem
            // 
            // 
            // 
            // 
            this.txtItem.CustomButton.Image = null;
            this.txtItem.CustomButton.Location = new System.Drawing.Point(60, 1);
            this.txtItem.CustomButton.Name = "";
            this.txtItem.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtItem.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItem.CustomButton.TabIndex = 1;
            this.txtItem.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItem.CustomButton.UseSelectable = true;
            this.txtItem.CustomButton.Visible = false;
            this.txtItem.Enabled = false;
            this.txtItem.Lines = new string[0];
            this.txtItem.Location = new System.Drawing.Point(0, 0);
            this.txtItem.MaxLength = 32767;
            this.txtItem.Name = "txtItem";
            this.txtItem.PasswordChar = '\0';
            this.txtItem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItem.SelectedText = "";
            this.txtItem.SelectionLength = 0;
            this.txtItem.SelectionStart = 0;
            this.txtItem.ShortcutsEnabled = true;
            this.txtItem.Size = new System.Drawing.Size(82, 23);
            this.txtItem.TabIndex = 0;
            this.txtItem.UseSelectable = true;
            this.txtItem.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItem.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(81, 0);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(32, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtNamaBarang
            // 
            // 
            // 
            // 
            this.txtNamaBarang.CustomButton.Image = null;
            this.txtNamaBarang.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.txtNamaBarang.CustomButton.Name = "";
            this.txtNamaBarang.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNamaBarang.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNamaBarang.CustomButton.TabIndex = 1;
            this.txtNamaBarang.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNamaBarang.CustomButton.UseSelectable = true;
            this.txtNamaBarang.CustomButton.Visible = false;
            this.txtNamaBarang.Enabled = false;
            this.txtNamaBarang.Lines = new string[0];
            this.txtNamaBarang.Location = new System.Drawing.Point(113, 0);
            this.txtNamaBarang.MaxLength = 32767;
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.PasswordChar = '\0';
            this.txtNamaBarang.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNamaBarang.SelectedText = "";
            this.txtNamaBarang.SelectionLength = 0;
            this.txtNamaBarang.SelectionStart = 0;
            this.txtNamaBarang.ShortcutsEnabled = true;
            this.txtNamaBarang.Size = new System.Drawing.Size(212, 23);
            this.txtNamaBarang.TabIndex = 2;
            this.txtNamaBarang.UseSelectable = true;
            this.txtNamaBarang.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNamaBarang.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ItemUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtNamaBarang);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtItem);
            this.Name = "ItemUserControl";
            this.Size = new System.Drawing.Size(325, 24);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtItem;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private MetroFramework.Controls.MetroTextBox txtNamaBarang;
    }
}

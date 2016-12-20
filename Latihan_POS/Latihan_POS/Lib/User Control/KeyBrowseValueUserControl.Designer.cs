namespace Latihan_POS.Lib.User_Control
{
    partial class KeyBrowseValueUserControl
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
            this.btnBrowse = new Latihan_POS.Lib.User_Control.CustomBrowseButton();
            this.txtKey = new MetroFramework.Controls.MetroTextBox();
            this.txtValue = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.LightGray;
            this.btnBrowse.Location = new System.Drawing.Point(91, -1);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(30, 25);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtKey
            // 
            // 
            // 
            // 
            this.txtKey.CustomButton.Image = null;
            this.txtKey.CustomButton.Location = new System.Drawing.Point(71, 2);
            this.txtKey.CustomButton.Name = "";
            this.txtKey.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtKey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKey.CustomButton.TabIndex = 1;
            this.txtKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKey.CustomButton.UseSelectable = true;
            this.txtKey.CustomButton.Visible = false;
            this.txtKey.Lines = new string[0];
            this.txtKey.Location = new System.Drawing.Point(0, 0);
            this.txtKey.MaxLength = 32767;
            this.txtKey.Name = "txtKey";
            this.txtKey.PasswordChar = '\0';
            this.txtKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKey.SelectedText = "";
            this.txtKey.SelectionLength = 0;
            this.txtKey.SelectionStart = 0;
            this.txtKey.ShortcutsEnabled = true;
            this.txtKey.Size = new System.Drawing.Size(93, 24);
            this.txtKey.TabIndex = 1;
            this.txtKey.UseSelectable = true;
            this.txtKey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // txtValue
            // 
            // 
            // 
            // 
            this.txtValue.CustomButton.Image = null;
            this.txtValue.CustomButton.Location = new System.Drawing.Point(131, 2);
            this.txtValue.CustomButton.Name = "";
            this.txtValue.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValue.CustomButton.TabIndex = 1;
            this.txtValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValue.CustomButton.UseSelectable = true;
            this.txtValue.CustomButton.Visible = false;
            this.txtValue.Lines = new string[0];
            this.txtValue.Location = new System.Drawing.Point(121, 0);
            this.txtValue.MaxLength = 32767;
            this.txtValue.Name = "txtValue";
            this.txtValue.PasswordChar = '\0';
            this.txtValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValue.SelectedText = "";
            this.txtValue.SelectionLength = 0;
            this.txtValue.SelectionStart = 0;
            this.txtValue.ShortcutsEnabled = true;
            this.txtValue.Size = new System.Drawing.Size(153, 24);
            this.txtValue.TabIndex = 2;
            this.txtValue.UseSelectable = true;
            this.txtValue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // KeyBrowseValueUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnBrowse);
            this.Name = "KeyBrowseValueUserControl";
            this.Size = new System.Drawing.Size(273, 24);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.KeyBrowseValueUserControl_Validating);
            this.Validated += new System.EventHandler(this.KeyBrowseValueUserControl_Validated);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomBrowseButton btnBrowse;
        private MetroFramework.Controls.MetroTextBox txtKey;
        private MetroFramework.Controls.MetroTextBox txtValue;

    }
}

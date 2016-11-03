namespace Latihan_5_1
{
    partial class frmSetting
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
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Background Color");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Theme", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            this.pnlBgColor = new System.Windows.Forms.Panel();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.cboBackgroundColor = new System.Windows.Forms.ComboBox();
            this.lblBgColor = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pnlBgColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBgColor
            // 
            this.pnlBgColor.BackColor = System.Drawing.SystemColors.Window;
            this.pnlBgColor.Controls.Add(this.btnApply);
            this.pnlBgColor.Controls.Add(this.btnCancel);
            this.pnlBgColor.Controls.Add(this.btnOk);
            this.pnlBgColor.Controls.Add(this.cboBackgroundColor);
            this.pnlBgColor.Controls.Add(this.lblBgColor);
            this.pnlBgColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBgColor.Location = new System.Drawing.Point(140, 0);
            this.pnlBgColor.Name = "pnlBgColor";
            this.pnlBgColor.Size = new System.Drawing.Size(445, 383);
            this.pnlBgColor.TabIndex = 3;
            this.pnlBgColor.Visible = false;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(200, 341);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(362, 341);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(281, 341);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cboBackgroundColor
            // 
            this.cboBackgroundColor.FormattingEnabled = true;
            this.cboBackgroundColor.Location = new System.Drawing.Point(196, 27);
            this.cboBackgroundColor.Name = "cboBackgroundColor";
            this.cboBackgroundColor.Size = new System.Drawing.Size(121, 21);
            this.cboBackgroundColor.TabIndex = 1;
            this.cboBackgroundColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboBackgroundColor_DrawItem);
            // 
            // lblBgColor
            // 
            this.lblBgColor.AutoSize = true;
            this.lblBgColor.Location = new System.Drawing.Point(86, 30);
            this.lblBgColor.Name = "lblBgColor";
            this.lblBgColor.Size = new System.Drawing.Size(92, 13);
            this.lblBgColor.TabIndex = 0;
            this.lblBgColor.Text = "Background Color";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode11.Name = "bgColor";
            treeNode11.Text = "Background Color";
            treeNode12.Name = "theme";
            treeNode12.Text = "Theme";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(140, 383);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 383);
            this.Controls.Add(this.pnlBgColor);
            this.Controls.Add(this.treeView1);
            this.Name = "frmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSetting";
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.pnlBgColor.ResumeLayout(false);
            this.pnlBgColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBgColor;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cboBackgroundColor;
        private System.Windows.Forms.Label lblBgColor;
        private System.Windows.Forms.TreeView treeView1;
    }
}
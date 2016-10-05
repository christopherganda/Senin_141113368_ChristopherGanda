namespace Latihan_2_1
{
    partial class Form1
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.nudBulan = new System.Windows.Forms.NumericUpDown();
            this.nudTanggal = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudBulan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTanggal)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.monthCalendar1.Location = new System.Drawing.Point(57, 94);
            this.monthCalendar1.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.monthCalendar1.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ScrollChange = 4;
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tanggal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bulan";
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(239, 65);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 7;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(94, 65);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 6;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // nudBulan
            // 
            this.nudBulan.Location = new System.Drawing.Point(194, 42);
            this.nudBulan.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudBulan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBulan.Name = "nudBulan";
            this.nudBulan.Size = new System.Drawing.Size(120, 20);
            this.nudBulan.TabIndex = 5;
            this.nudBulan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBulan.ValueChanged += new System.EventHandler(this.nudBulan_ValueChanged);
            // 
            // nudTanggal
            // 
            this.nudTanggal.Location = new System.Drawing.Point(194, 20);
            this.nudTanggal.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudTanggal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTanggal.Name = "nudTanggal";
            this.nudTanggal.Size = new System.Drawing.Size(51, 20);
            this.nudTanggal.TabIndex = 4;
            this.nudTanggal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTanggal.ValueChanged += new System.EventHandler(this.nudTanggal_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 423);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.nudBulan);
            this.Controls.Add(this.nudTanggal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBulan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTanggal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.NumericUpDown nudBulan;
        private System.Windows.Forms.NumericUpDown nudTanggal;
    }
}


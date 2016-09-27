using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static DateTime now = DateTime.Now;
        private void vsbMin_Scroll(object sender, ScrollEventArgs e)
        {
            lblMin.Text = (vsbMin.Maximum-vsbMin.Value).ToString();
            if (vsbMax.Value > vsbMin.Value)
            {
                vsbMax.Value = vsbMin.Value-1;
                lblMax.Text = (vsbMax.Maximum - vsbMax.Value).ToString();
            }
            dtpTanggal.MaxDate = now.AddYears(vsbMin.Value - vsbMin.Maximum);
            dtpTanggal.MinDate = now.AddYears(vsbMax.Value - vsbMax.Maximum);
        }

        private void vsbMax_Scroll(object sender, ScrollEventArgs e)
        {
            lblMax.Text = (vsbMax.Maximum - vsbMax.Value).ToString();
            //lblMax.Text = vsbMax.Value.ToString();
            if (vsbMax.Value > vsbMin.Value)
            {
                vsbMin.Value = vsbMax.Value;
                lblMin.Text = (vsbMin.Maximum - vsbMin.Value).ToString();
            }
            dtpTanggal.MaxDate = now.AddYears(vsbMin.Value - vsbMin.Maximum);
            dtpTanggal.MinDate = now.AddYears(vsbMax.Value - vsbMax.Maximum);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpTanggal.MaxDate = now.AddYears(vsbMin.Value - vsbMin.Maximum);
            dtpTanggal.MinDate = now.AddYears(vsbMax.Value - vsbMax.Maximum);
        }
    }
}

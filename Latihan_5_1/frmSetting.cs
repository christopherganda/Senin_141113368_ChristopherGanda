using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_5_1
{
    public partial class frmSetting : Form
    {
        
        public frmSetting()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text == "Background Color")pnlBgColor.Show();          
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Form1 form = (Form1)MdiParent;
            form.setBackgroundColor(cboBackgroundColor.Text);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Form1 form = (Form1)MdiParent;
            form.setBackgroundColor(cboBackgroundColor.Text);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboBackgroundColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            // a dropdownlist may initially have no item selected, so skip the highlighting:
            if (e.Index >= 0)
            {
                Graphics g = e.Graphics;
                Brush brush = new SolidBrush(e.BackColor);
                Brush tBrush = new SolidBrush(e.ForeColor);

                g.FillRectangle(brush, e.Bounds);
                string s = (string)this.cboBackgroundColor.Items[e.Index].ToString();
                SolidBrush b = new SolidBrush(Color.FromName(s));
                // Draw a rectangle and fill it with the current color
                // and add the name to the right of the color
                e.Graphics.DrawRectangle(Pens.Black, 2, e.Bounds.Top + 1, 20, 11);
                e.Graphics.FillRectangle(b, 3, e.Bounds.Top + 2, 19, 10);
                e.Graphics.DrawString(s, this.Font, Brushes.Black, 25, e.Bounds.Top);
                brush.Dispose();
                tBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            Form1 form = (Form1)MdiParent;
            form.getFontColor(cboBackgroundColor);
            cboBackgroundColor.Text = form.getBackgroundColor();
        }

    }
}

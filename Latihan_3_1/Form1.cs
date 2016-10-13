using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Reflection;
namespace Latihan_3_1
{
    public partial class Form1 : Form
    {
        private void tscbFontColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            // a dropdownlist may initially have no item selected, so skip the highlighting:
            if (e.Index >= 0)
            {
                Graphics g = e.Graphics;
                Brush brush = new SolidBrush(e.BackColor);
                Brush tBrush = new SolidBrush(e.ForeColor);

                g.FillRectangle(brush, e.Bounds);
                string s = (string)this.tscbFontColor.Items[e.Index].ToString();
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
        public Form1()
        {
            InitializeComponent();

            for (int i = 8; i <= 72; i++) tscbFontSize.Items.Add(i);
            InstalledFontCollection fontsCollection = new InstalledFontCollection();
            FontFamily[] fontFamilies = fontsCollection.Families;
            foreach (FontFamily font in fontFamilies)
            {
                tscbFontFamily.Items.Add(font.Name);
            }
            this.tscbFontColor.ComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            this.tscbFontColor.ComboBox.DrawItem += new DrawItemEventHandler(tscbFontColor_DrawItem);
            Color clr = new Color();
            PropertyInfo[] colors = clr.GetType().GetProperties();
            foreach (PropertyInfo c in colors)
            {
                this.tscbFontColor.Items.Add(c.Name);
            }
            tscbFontColor.SelectedIndex = 10;
            tscbFontColor.Text = "Black";
            tscbFontFamily.SelectedItem = "Calibri";
            tscbFontSize.SelectedItem = 8;
            ubahFont();

        }
        private void tscbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox tscb = (ToolStripComboBox)sender;
            if (!tscb.Focused)
            {
                return;
            }
            ubahFont();
        }
        private void tscbFontColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox tscb = (ToolStripComboBox)sender;
            if (!tscb.Focused)
            {
                return;
            }
            ubahFont();
        }
        private void tscbFontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox tscb = (ToolStripComboBox)sender;
            if (!tscb.Focused)
            {
                return;
            }
            ubahFont();
        }
        private void ubahFont()
        {
            System.Drawing.FontStyle style = (tsbBold.Checked) ? FontStyle.Bold : FontStyle.Regular;
            style |= (tsbItalic.Checked) ? FontStyle.Italic : FontStyle.Regular;
            style |= (tsbUnderline.Checked) ? FontStyle.Underline : FontStyle.Regular;
            rtbText.SelectionFont = new Font(tscbFontFamily.Text,
                                             tscbFontSize.Text==""? 11:Convert.ToSingle(tscbFontSize.Text) ,
                                             style);
            rtbText.SelectionColor = Color.FromName(tscbFontColor.Text);
            rtbText.Focus();
            rtbText.Select(rtbText.SelectionStart,rtbText.SelectionLength );
        }

        private void tsbBold_Click(object sender, EventArgs e)
        {
            tsbBold.Checked ^= true;
            ubahFont();
        }

        private void tsbItalic_Click(object sender, EventArgs e)
        {
            tsbItalic.Checked ^= true;
            ubahFont();
        }

        private void tsbUnderline_Click(object sender, EventArgs e)
        {
            tsbUnderline.Checked ^= true;
            ubahFont();
        }
        private void tscbFontSize_LostFocus(object sender, EventArgs e)
        {
            ubahFont();
        }
        private void tscbFontColor_LostFocus(object sender, EventArgs e)
        {
            ubahFont();
        }
        private void tscbFontFamily_LostFocus(object sender, EventArgs e)
        {
            ubahFont();
        }

        private void rtbText_SelectionChanged(object sender, EventArgs e)
        {
            tsbBold.Checked = false;
            tsbItalic.Checked = false;
            tsbUnderline.Checked = false;
            if (rtbText.SelectionFont != null)
            {
                tscbFontFamily.Text = rtbText.SelectionFont.FontFamily.Name;
                tscbFontSize.Text = rtbText.SelectionFont.Size.ToString();
                if (rtbText.SelectionFont.Style.ToString().IndexOf("Bold") >= 0)
                {
                    tsbBold.Checked = true;
                }
                if (rtbText.SelectionFont.Style.ToString().IndexOf("Italic") >= 0)
                {
                    tsbItalic.Checked = true;
                }
                if (rtbText.SelectionFont.Style.ToString().IndexOf("Underline") >= 0)
                {
                    tsbUnderline.Checked = true;
                }
            }
            else
            {
                tscbFontFamily.Text = "";
                tscbFontSize.Text = "";
            }

            if (rtbText.SelectionColor.Name == "0")
            {
                tscbFontColor.Text = "Black";
            }
            else
            {
                tscbFontColor.Text = rtbText.SelectionColor.Name;
            }
        }


        
    }
}

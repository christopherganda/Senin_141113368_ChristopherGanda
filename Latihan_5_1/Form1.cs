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
using System.IO;

namespace Latihan_5_1
{
    public partial class Form1 : Form
    {
        bool isBold = false, isItalic = false, isUnderline = false, cekKosong = false, cekClose = false;
        System.Drawing.FontStyle fontStyle;
        public Form1()
        {
            InitializeComponent();
        }
        private void tsmiNew_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
        public void save()
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "*.txt(textfile)|*.txt";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                rtbText.SaveFile(savefile.FileName, RichTextBoxStreamType.PlainText);
                cekKosong = false;
            }
        }
        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            Stream myStream;
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    string filename = openFileDialog1.FileName;
                    string readfiletext = File.ReadAllText(filename);
                    rtbText.Text = readfiletext;
                }
            }
        }

        public void getFontSize()
        {
            for (int i = 8; i <= 72; i++) tscbFontSize.Items.Add(i);
        }
        public void getFontFamily()
        {
            InstalledFontCollection fontsCollection = new InstalledFontCollection();
            FontFamily[] fontFamilies = fontsCollection.Families;
            foreach (FontFamily font in fontFamilies)
            {
                tscbFontFamily.Items.Add(font.Name);
            }
        }
        public void getFontColor()
        {
            this.tscbFontColor.ComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            this.tscbFontColor.ComboBox.DrawItem += new DrawItemEventHandler(tscbFontColor_DrawItem);
            Color clr = new Color();
            PropertyInfo[] colors = clr.GetType().GetProperties();
            foreach (PropertyInfo c in colors)
            {
                this.tscbFontColor.Items.Add(c.Name);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            getFontColor();
            getFontFamily();
            getFontSize();
            tscbFontColor.SelectedIndex = 10;
            tscbFontColor.Text = "Black";
            tscbFontFamily.SelectedItem = "Calibri";
            tscbFontSize.SelectedItem = 12;
            ubahFont();
        }

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

        private void rtbText_SelectionChanged(object sender, EventArgs e)
        {
            tsbBold.Checked = tsbItalic.Checked = tsbUnderline.Checked = false;

            if (rtbText.SelectionFont == null)
            {
                tscbFontSize.Text = "";
                tscbFontFamily.Text = "";
            }
            else
            {
                tscbFontFamily.Text = rtbText.SelectionFont.Name;
                tscbFontSize.Text = rtbText.SelectionFont.Size.ToString();
                if (rtbText.SelectionFont.Bold)
                {
                    tsbBold.Checked = true;
                }
                if (rtbText.SelectionFont.Italic)
                {
                    tsbItalic.Checked = true;
                }
                if (rtbText.SelectionFont.Underline)
                {
                    tsbUnderline.Checked = true;
                }
            }

            if (rtbText.SelectionColor.Name == "0")
            {
                tscbFontColor.Text = "";
            }
            else
            {
                tscbFontColor.Text = rtbText.SelectionColor.Name;
            }

        }
        private void tscbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox tscb = (ToolStripComboBox)sender;
            if (!tscb.Focused)
            {
                return;
            }
            ubahFont("font");
        }
        private void tscbFontColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox tscb = (ToolStripComboBox)sender;
            if (!tscb.Focused)
            {
                return;
            }
            rtbText.SelectionColor = Color.FromName(tscbFontColor.Text);
            rtbText.Focus();
        }
        private void tscbFontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox tscb = (ToolStripComboBox)sender;
            if (!tscb.Focused)
            {
                return;
            }
            ubahFont("font");
        }
        private void tscbFontSize_LostFocus(object sender, EventArgs e)
        {
            ubahFont("font");
        }
        private void tscbFontColor_LostFocus(object sender, EventArgs e)
        {
            rtbText.SelectionColor = Color.FromName(tscbFontColor.Text);
            rtbText.Focus();
        }
        private void tscbFontFamily_LostFocus(object sender, EventArgs e)
        {
            ubahFont("font");
        }
        private void tsbBold_Click(object sender, EventArgs e)
        {
            tsbBold.Checked ^= true;
            ubahFont("bold");
        }
        private void tsbItalic_Click(object sender, EventArgs e)
        {
            tsbItalic.Checked ^= true;
            ubahFont("italic");
        }
        private void tsbUnderline_Click(object sender, EventArgs e)
        {

        }
        private void ubahStyle()
        {
            if (isBold)
                fontStyle = FontStyle.Bold;
            else
                fontStyle = FontStyle.Regular;
            if (isItalic)
                fontStyle |= FontStyle.Italic;
            else
                fontStyle |= FontStyle.Regular;
            if (isUnderline)
                fontStyle |= FontStyle.Underline;
            else
                fontStyle |= FontStyle.Regular;
        }
        private void checkStyle(string style)
        {
            if (style != null && style == "bold")
            {
                isBold = tsbBold.Checked;
            }
            else if (style != null && style == "italic")
            {
                isItalic = tsbItalic.Checked;
            }
            else if (style != null && style == "underline")
            {
                isUnderline = tsbUnderline.Checked;
            }

        }
        private void ubahFont(string style = null)
        {

            int start = rtbText.SelectionStart;
            int length = rtbText.SelectionLength;
            float fontSize;
            string fontFamily;
            this.rtbText.SelectionChanged -= new System.EventHandler(this.rtbText_SelectionChanged);
            if (length == 0)
            {
                if (tscbFontFamily.Text == "")
                    fontFamily = rtbText.SelectionFont.FontFamily.Name;
                else
                    fontFamily = tscbFontFamily.Text;
                if (tscbFontSize.Text == "")
                    fontSize = rtbText.SelectionFont.Size;
                else
                    fontSize = Convert.ToSingle(tscbFontSize.Text);
                isBold = rtbText.SelectionFont.Bold;
                isItalic = rtbText.SelectionFont.Italic;
                isUnderline = rtbText.SelectionFont.Underline;
                checkStyle(style);
                ubahStyle();
                rtbText.SelectionFont = new Font(fontFamily, fontSize, fontStyle);
            }
            for (int i = start; i < start + length; i++)
            {
                rtbText.SelectionChanged -= new System.EventHandler(this.rtbText_SelectionChanged);
                rtbText.Select(i, 1);
                if (tscbFontFamily.Text == "")
                    fontFamily = rtbText.SelectionFont.FontFamily.Name;
                else
                    fontFamily = tscbFontFamily.Text;
                if (tscbFontSize.Text == "")
                    fontSize = rtbText.SelectionFont.Size;
                else
                    fontSize = Convert.ToSingle(tscbFontSize.Text);
                isBold = rtbText.SelectionFont.Bold;
                isItalic = rtbText.SelectionFont.Italic;
                isUnderline = rtbText.SelectionFont.Underline;
                checkStyle(style);
                ubahStyle();
                rtbText.SelectionFont = new Font(fontFamily, fontSize, fontStyle);
            }
            rtbText.Focus();
            rtbText.Select(start, length);
            this.rtbText.SelectionChanged += new System.EventHandler(this.rtbText_SelectionChanged);
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            save();
        }
        private void exit(FormClosingEventArgs e = null)
        {
            if (cekKosong)
            {
                DialogResult dialogResult = MessageBox.Show("Apakah anda mau menyimpan?", "Pesan", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Yes)
                {
                    save();
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    cekClose = true;
                    Application.Exit();
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    cekClose = false;
                    if (e != null)
                        e.Cancel = true;
                }
            }
        }
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void rtbText_TextChanged(object sender, EventArgs e)
        {
            cekKosong = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cekClose)
                exit(e);
        }

        private void tsmiSetting_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length < 1)
            {
                frmSetting showForm = new frmSetting();
                showForm.MdiParent = this;
                rtbText.SendToBack();
                showForm.Show();
            }

        }
    }
}

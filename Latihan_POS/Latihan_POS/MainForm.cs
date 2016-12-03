using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Latihan_POS
{
    public partial class MainForm : MetroFramework.Forms.MetroForm  
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None ;
            this.WindowState = FormWindowState.Maximized;
            splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            //splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            //splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            
            splitContainer.Location = new System.Drawing.Point(0, 0);
            splitContainer.Orientation = System.Windows.Forms.Orientation.Vertical ;
            //splitContainer.Size = new System.Drawing.Size(207, 273);
            //splitContainer.SplitterDistance = 125;
            //splitContainer.SplitterWidth = 6;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Form showForm = new FormList.frmRegisterBarang();
            //showForm.TopLevel = false;
            //splitContainer.Panel2.Controls.Add(showForm);
            //showForm.Show();
            //showForm.Location = new Point((splitContainer.Panel2.Width - showForm.Width) / 2, (splitContainer.Panel2.Height - showForm.Height) / 2);
            if (splitContainer.Panel2.Controls.Count < 1)
            {
                MetroFramework.Forms.MetroForm showForm = new FormList.frmRegisterBarang();
                showForm.TopLevel = false;
                showForm.MdiParent = this;
                splitContainer.Panel2.Controls.Add(showForm);
                showForm.Location = new Point((splitContainer.Panel2.Width - showForm.Width) / 2, (splitContainer.Panel2.Height - showForm.Height) / 2);
                //showForm.WindowState = FormWindowState.Maximized;
                showForm.Show();
                showForm.Location = new Point((splitContainer.Panel2.Width - showForm.Width) / 2, (splitContainer.Panel2.Height - showForm.Height) / 2);
                //Size maxWindowTrackSize = splitContainer.Panel2.ClientSize;
                //showForm.Size = maxWindowTrackSize;
                
             
            }
            //if (splitContainer.Panel2.Controls.Count < 1)
            //{
            //    FormList.frmRegisterBarang show = new FormList.frmRegisterBarang();
            //    show.TopLevel = false;
            //    show.MdiParent = this;
            //    MainForm main = new MainForm();
            //    //show.Parent = main;
            //    splitContainer.Panel2.Controls.Add(show);
            //    show.Show();
            //}
        }

        private void tileClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Dispose();
        }
    }
}

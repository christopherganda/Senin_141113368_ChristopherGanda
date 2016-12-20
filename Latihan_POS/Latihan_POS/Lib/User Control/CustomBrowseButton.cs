using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Latihan_POS.Lib.User_Control
{
    public partial class CustomBrowseButton : MetroFramework.Controls.MetroButton 
    {
        
        public CustomBrowseButton()
        {
            InitializeComponent();
            this.BackColor = Color.LightGray;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            this.MinimumSize= new Size(30,25);
            this.Size = new Size(30, 25);
            this.Text = "...";
        }
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public FlatButtonAppearance FlatAppearance
        {
            get
            {
                return base.FlatAppearance;
            }
        }
        
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Size MinimumSize
        {
            get
            {
                return base.MinimumSize ;
            }
            set
            {
                base.MinimumSize = value; 
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
            }
        }
    }
}

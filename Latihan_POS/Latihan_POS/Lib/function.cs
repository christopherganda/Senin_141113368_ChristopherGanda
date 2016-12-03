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
     class function
    {
        public static void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is MetroFramework.Controls.MetroTextBox )
                    ((MetroFramework.Controls.MetroTextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }
    }
}

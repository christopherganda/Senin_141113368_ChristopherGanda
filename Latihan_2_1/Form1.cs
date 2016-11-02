using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class Form1 : Form
    {
        private DateTime d;
        public Form1()
        {
            InitializeComponent();
        }

        private void nudBulan_ValueChanged(object sender, EventArgs e)
        {
            d = monthCalendar1.SelectionRange.Start;
            nudTanggal.Maximum = DateTime.DaysInMonth(d.Year, (int)nudBulan.Value);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            d = monthCalendar1.SelectionRange.Start;
            nudTanggal.Maximum = DateTime.DaysInMonth(d.Year, (int)nudBulan.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            d = monthCalendar1.SelectionRange.Start;
            DateTime awal = monthCalendar1.MinDate;
            for (DateTime i = awal; i <= monthCalendar1.MaxDate; i = i.AddDays(1))
            {
                if (i.DayOfWeek.ToString() == "Sunday" || (i.Day == 18 && i.Month == 3))
                {
                    monthCalendar1.AddBoldedDate(i);
                }
            }
            monthCalendar1.Refresh();
        }

        private void nudTanggal_ValueChanged(object sender, EventArgs e)
        {
            d = monthCalendar1.SelectionRange.Start;
            nudTanggal.Maximum = DateTime.DaysInMonth(d.Year, (int)nudBulan.Value);
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            DateTime pilih = new DateTime(d.Year, (int)nudBulan.Value, (int)nudTanggal.Value);
            monthCalendar1.AddAnnuallyBoldedDate(pilih);
            monthCalendar1.Refresh();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DateTime awal = new DateTime(monthCalendar1.MinDate.Year, (int)nudBulan.Value, (int)nudTanggal.Value);
            for (DateTime i = awal; i <= monthCalendar1.MaxDate; i = i.AddYears(1))
            {
                if (i.DayOfWeek.ToString() != "Sunday" || (i.Day != 18 && i.Month != 3))
                {
                    monthCalendar1.RemoveAnnuallyBoldedDate(i);
                }
            }
            monthCalendar1.Refresh();
        }
    }
}

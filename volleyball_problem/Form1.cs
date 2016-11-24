using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volleyball_problem
{
    public partial class Form1 : Form
    {
        long mod = 1000000007;
        public Form1()
        {
            InitializeComponent();
        }
        private long gcd(long a, long b)
        {
            if (b == 0) return a;
            return gcd(b, a % b);
        }
        private long modularInverse(long value)
        {
            long tmp, x, y, times, modulus;
            x = 0;
            y = 1;
            modulus = mod;
            if (mod <= 1 || gcd(value, mod) != 1) return -1;
            while (value > 1)
            {
                times = value / mod;
                tmp = mod;
                mod = value % mod;
                value = tmp;
                tmp = x;
                x = y - times * x;
                y = tmp;
            }
            mod = modulus;
            return (modulus + y) % modulus;
        }
        private void swap(ref long a, ref long b)
        {
            if (a > b)
            {
                long temp = a;
                a = b;
                b = temp;
            }
        }
        private long faktorial(long a)
        {
            long hasil = 1;
            for (int i = 1; i <= a; i++)
            {
                hasil *= i;
                hasil %= mod;
            }
            return hasil;
        }
        private long nCk(long a, long b)
        {
            long hasil = 1;
            //MessageBox.Show(a.ToString() + " " + b.ToString());
            hasil *= faktorial(a);
            hasil %= mod;
            hasil *= modularInverse(faktorial(a - b));
            //MessageBox.Show(mod.ToString());
            hasil %= mod;
            hasil *= modularInverse(faktorial(b));
            hasil %= mod;
            return hasil;
        }
        private long pangkat( long a)
        {
            long hasil = 1;
            for(long i = 1;i<=a;i++){
                hasil*=2;
                hasil %= mod;
            }
            return hasil;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            long a = Convert.ToInt64(txtA.Text);
            long b = Convert.ToInt64(txtB.Text);
            swap(ref a,ref  b);
            //MessageBox.Show(a.ToString() + " " + b.ToString());
            if (b < 25 || b - a < 2 || (b > 25 && b - a != 2))
            {
                txtHasil.Text  = "0";
            }
            else
            {
                long hasil = nCk(Math.Min(a + b - 1, 47), Math.Min(b - 1, 24));
                //MessageBox.Show(hasil.ToString());
                //MessageBox.Show(Math.Min(a + b - 1, 47).ToString() + " " + Math.Min(b - 1, 24).ToString());
                //MessageBox.Show(Math.Min(b - 1, 24).ToString());
                hasil *= pangkat(b - 25);
                //MessageBox.Show(pangkat(b-25,2).ToString());
                hasil %= mod;
                txtHasil.Text = hasil.ToString();
               
            }
        }
    }
}

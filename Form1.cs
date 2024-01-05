using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatorizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txt.Text != "")
            {
                string s = "";
                if (txt.Text.Length > 16)
                {
                    MessageBox.Show("Number is so large ! Literally unable to factorize", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt.Focus();
                    txt.SelectAll();
                }
                else
                {
                    long a = long.Parse(txt.Text);
                    long i = 2;
                    long[] ans = new long[10000];
                    long c = 0;
                    double t = (double)(a);
                    long m = (long)(Math.Sqrt(t));
                    while (i <= m)
                    {
                        while (a % i == 0)
                        {
                            a /= i;
                            c++;
                            if (c == 1) s += i.ToString();
                            else s += '*' + i.ToString();

                        }
                        i++;
                    }
                    if (a > 1)
                    {
                        c++;
                        if (c == 1) s += a.ToString();
                        else s += '*' + a.ToString();

                    }

                    rtxt.Text = s;
                }
            }
            else rtxt.Text = "";


        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b') e.Handled = false;
            else if (txt.Text == "" && e.KeyChar == '0') e.Handled = true;
            else if (e.KeyChar > '9' || e.KeyChar < '0') e.Handled = true;
            else e.Handled = false;
        }

        private void del_Click(object sender, EventArgs e)
        {
            txt.Text = "";
            txt.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string b = textBox1.Text;
            StringBuilder a = new StringBuilder(b);
            string ch = textBox3.Text;
            if (ch == "" || ch == " ") MessageBox.Show("Вы не ввели символ");
            else
            {

                string[] c = b.Split(' ', ',', '?', ';', '.', '!');


                foreach (string item in c)
                {
                    int vv = item.IndexOf(ch.ToUpper());
                    int xx = item.IndexOf(ch.ToLower());
                    if (item.IndexOf(ch.ToUpper()) != -1 || item.IndexOf(ch.ToLower()) != -1)
                    {
                        int fl = b.IndexOf(item);
                        a.Remove(fl, item.Length);
                        b = a.ToString();

                    }
                }
                b = b.Trim();

                textBox2.Text = b;
            }
        }
    }
}
          
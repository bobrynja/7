using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            int flag = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] == a[i - 1])
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 1) textBox2.Text = ("В строке имеются два соседствующих одинаковых символа");
            else textBox2.Text = ("В строке не имеется два соседствующих одинаковых символа");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void sss(int i)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            switch(i)
            {
                case 1:
                    label1.Text = (x + y).ToString();
                    break;
                case 2:
                    label1.Text = (x - y).ToString();
                    break;
                case 3:
                    label1.Text = (x * y).ToString();
                    break;
                case 4:
                    label1.Text = (x / y).ToString();
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sss(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sss(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sss(3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sss(4);
        }
    }
}

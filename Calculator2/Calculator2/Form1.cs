using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double first_num = Convert.ToInt32(textBox1.Text);
            double second_num = Convert.ToInt32(textBox2.Text);
            string sign = textBox3.Text;

            switch (sign)
            {
                case "+":
                    textBox4.Text = Convert.ToString(first_num + second_num);
                    break;
                case "-":
                    textBox4.Text = Convert.ToString(first_num - second_num);
                    break;
                case "*":
                    textBox4.Text = Convert.ToString(first_num * second_num);
                    break;
                case "/":
                    textBox4.Text = Convert.ToString(first_num / second_num);
                    break;
                case "%":
                    textBox4.Text = Convert.ToString(first_num % second_num);
                    break;
            }
        }
    }
}

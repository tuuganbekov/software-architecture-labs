using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_work_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 1; i < 10; i++)
            {
                listBox1.Items.Add("Record " + i.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] sArrayItems = { "Excellent", "Good", "Satisfactory", "Unsatisfactory" };
            listBox1.Items.Clear();
            for(int i = 0; i < sArrayItems.GetLength(0); i++)
            {
                listBox1.Items.Add(sArrayItems[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(4, "Added line 2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(new object[] { "Excellent", "Good", "Satisfactory", "Unsatisfactory" });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for(int i = 1; i < 21; i++)
            {
                listBox1.Items.Add("Straw " + i.ToString());
                listBox1.SelectionMode = SelectionMode.MultiSimple;
                listBox1.SetSelected(0, true);
                //listBox1.SetSelected(1, true);
                //listBox1.SetSelected(2, true);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
            listBox1.Items.Clear();
            for(int i = 1; i < 21; i++)
            {
                listBox1.Items.Add("Straw " + i.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.UseTabStops = true;
            for (int i = 1; i < 21; i++)
            {
                listBox1.Items.Add("Option \t" + i.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                MessageBox.Show(listBox1.SelectedItem.ToString(), "Geting the string value");
                //MessageBox.Show(listBox1.Text, "");
                if(listBox1.SelectedIndex != -1)
                {
                    MessageBox.Show(listBox1.SelectedIndex.ToString(), "Getting the string index");
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                MessageBox.Show(listBox1.Items[i].ToString() + "");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(0);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedItem.ToString(), "Getting string value");
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We clicked on the component with the mouse");
        }
    }
}

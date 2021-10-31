﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_work_5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.SelectionBullet = true;
            richTextBox1.BulletIndent = 50;
            richTextBox1.SelectionFont = new Font("Arial", 16);
            richTextBox1.SelectedText = "Below is a list \n";
            richTextBox1.SelectionFont = new Font("Arial", 12);
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.SelectedText = "Apple" + "\n";
            richTextBox1.SelectionFont = new Font("Arial", 12);
            richTextBox1.SelectionColor = Color.Orange;
            richTextBox1.SelectedText = "Orange" + "\n";
            richTextBox1.SelectionFont = new Font("Arial", 12);
            richTextBox1.SelectionColor = Color.Purple;
            richTextBox1.SelectedText = "Grapes" + "\n";
            richTextBox1.SelectionBullet = false;
            richTextBox1.SelectionFont = new Font("Verdana", 10);
            richTextBox1.SelectedText = "The list is over \n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // first way
            int viNom = 0;
            richTextBox1.Text += "Text" + (Convert.ToInt32(viNom)).ToString();
            viNom++;
            richTextBox1.Text += "String" + (Convert.ToInt32(viNom)).ToString() + "\r\n";
            viNom++;
            richTextBox1.Text += "String" + (Convert.ToInt32(viNom)).ToString() + "\r\n";
            // second way
            richTextBox1.AppendText("String" + Convert.ToString(viNom) + "\r\n");
            viNom++;
            richTextBox1.AppendText("String" + Convert.ToString(viNom) + "\r\n");
            //// third way 
            //richTextBox1.Lines = new string [] {"Line 1", "Line 2"};

        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "My site https://www.w3schools.com/cs/index.php";
        }

        private void richTextBox2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Clicked on links");
            //System.Diagnostics.Process.Start(e.LinkText);
        } 
    }
}

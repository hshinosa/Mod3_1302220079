﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOD3
{
    public partial class Form1 : Form
    {
        int hasil = 0;
        int nilai1 = 0;
        int nilai2 = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            nilai1 = int.Parse(label1.Text);
            label1.Text = label1.Text + label1.Text;
            label1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text += button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hasil = nilai1 + int.Parse(label1.Text);
            label1.Text = hasil.ToString();
        }
    }
}

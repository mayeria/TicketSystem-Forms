using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bilety
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (Form1.film1 != null)
                richTextBox1.Text += Form1.film1 + "\n";
            if (Form1.film2 != null)
                richTextBox1.Text += Form1.film2 + "\n";
            if (Form1.film3 != null)
                richTextBox1.Text += Form1.film3 + "\n";
            if (Form1.film4 != null)
                richTextBox1.Text += Form1.film4 + "\n";
            if (Form1.film5 != null)
                richTextBox1.Text += Form1.film5 + "\n";
            if (Form1.film6 != null)
                richTextBox1.Text += Form1.film6 + "\n";
            if (Form1.film7 != null)
                richTextBox1.Text += Form1.film7 + "\n";
            if (Form1.film8 != null)
                richTextBox1.Text += Form1.film8 + "\n";
            if (Form1.film9 != null)
                richTextBox1.Text += Form1.film9 + "\n";
            if (Form1.film10 != null)
                richTextBox1.Text += Form1.film10 + "\n";
            if (Form1.film11 != null)
                richTextBox1.Text += Form1.film11 + "\n";
            if (Form1.film12 != null)
                richTextBox1.Text += Form1.film12 + "\n";
            if (Form1.film13 != null)
                richTextBox1.Text += Form1.film13 + "\n";
            if (Form1.film14 != null)
                richTextBox1.Text += Form1.film14 + "\n";

            label4.Text = Form1.suma.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
            richTextBox1.Text = null;
            Form1.suma = 0;
            this.Close();
        }
    }
}

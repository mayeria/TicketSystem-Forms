using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bilety
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(Form1.film1 != null)
                listBox2.Items.Add(Form1.film1);
            if (Form1.film2 != null)
                listBox2.Items.Add(Form1.film2);
            if (Form1.film3 != null)
                listBox2.Items.Add(Form1.film3);
            if (Form1.film4 != null)
                listBox2.Items.Add(Form1.film4);
            if (Form1.film5 != null)
                listBox2.Items.Add(Form1.film5);
            if (Form1.film6 != null)
                listBox2.Items.Add(Form1.film6);
            if (Form1.film7 != null)
                listBox2.Items.Add(Form1.film7);
            if (Form1.film8 != null)
                listBox2.Items.Add(Form1.film8);
            if (Form1.film9 != null)
                listBox2.Items.Add(Form1.film9);
            if (Form1.film10 != null)
                listBox2.Items.Add(Form1.film10);
            if (Form1.film11 != null)
                listBox2.Items.Add(Form1.film11);
            if (Form1.film12 != null)
                listBox2.Items.Add(Form1.film12);
            if (Form1.film13 != null)
                listBox2.Items.Add(Form1.film13);
            if (Form1.film14 != null)
                listBox2.Items.Add(Form1.film14);
            label3.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            listBox2.Items.Clear();
            label3.Visible = true;
            Form1.film1 = null;
            Form1.film2 = null;
            Form1.film3 = null;
            Form1.film4 = null;
            Form1.film5 = null;
            Form1.film6 = null;
            Form1.film7 = null;
            Form1.film8 = null;
            Form1.film9 = null;
            Form1.film10 = null;
            Form1.film11 = null;
            Form1.film12 = null;
            Form1.film13 = null;
            Form1.film14 = null;
        }
    }
}

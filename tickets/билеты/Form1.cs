using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace билеты
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.KeyPress += (sender, e) => e.Handled = true;
            comboBox2.KeyPress += (sender, e) => e.Handled = true;
            comboBox4.KeyPress += (sender, e) => e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Enabled = false;
            comboBox4.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Enabled = true;
                comboBox2.Show();
                comboBox4.Hide();
               
            }
            if (comboBox1.SelectedIndex == 1)
            {
                comboBox4.Enabled = true;
                comboBox4.Show();
                comboBox2.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0)
            {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            }
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1)
            {
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 2)
            {
                Form4 f4 = new Form4();
                f4.ShowDialog();
            }
            if (comboBox1.SelectedIndex == 1 && comboBox4.SelectedIndex == 0)
            {
                Form5 f5 = new Form5();
                f5.ShowDialog();
            }
            if (comboBox1.SelectedIndex == 1 &&comboBox4.SelectedIndex == 1)
            {
                Form6 f6 = new Form6();
                f6.ShowDialog();
            }
            if (comboBox1.SelectedIndex == 1 && comboBox4.SelectedIndex == 2)
            {
                Form7 f7 = new Form7();
                f7.ShowDialog();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedIndex == 0 || comboBox2.SelectedIndex != 0)
            {
                button1.Enabled = true;
            }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex != 0 || comboBox4.SelectedIndex == 0)
            {
                button1.Enabled = true;
            }
        }
    }
}

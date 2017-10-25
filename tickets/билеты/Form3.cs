using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace билеты
{

    public partial class Form3 : Form
    {
        string login = "1";
        string password = "1";
        string l, p;
        int price = 50000;
        int buyin = 15000;
        public Form3()
        {
            InitializeComponent();
            panel2.Hide();
            panel3.Hide();
            panel5.Hide();
            panel4.Hide();
            textBox2.Hide();
            textBox2.Enabled = false;
            textBox3.Text = button1.Text;
            textBox12.Text = button9.Text;
            textBox1.Text = Convert.ToString(buyin);
            textBox4.Text = "Беларусь";
            textBox4.KeyPress += (sender, e) => e.Handled = true;
            textBox2.KeyPress += (sender, e) => e.Handled = true;
            textBox14.KeyPress += (sender, e) => e.Handled = true;
            textBox5.KeyPress += (sender, e) => e.Handled = true;
            textBox6.KeyPress += (sender, e) => e.Handled = true;
            textBox9.KeyPress += (sender, e) => e.Handled = true;
            textBox10.KeyPress += (sender, e) => e.Handled = true;
            textBox11.KeyPress += (sender, e) => e.Handled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
        }
        private void администрированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel5.Show();
        }
        private void button133_Click(object sender, EventArgs e)
        {
            button1.Text = textBox3.Text;
        }

        

        private void button8_Click(object sender, EventArgs e)
        {
            login = textBox8.Text;
        }

        private void button137_Click(object sender, EventArgs e)
        {
            panel2.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (button5.BackColor == Color.FromArgb(100, 149, 237))
            {
                MessageBox.Show("Билет забронирован");
               DialogResult q1 = MessageBox.Show("Выкупить?", "Выкуп", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (q1 == DialogResult.Yes)
                {
                    panel3.Show();
                    textBox2.Enabled = true;
                    textBox2.Show();
                    textBox2.Text = Convert.ToString(price+buyin);
                    button4.Hide();
                }
                if (q1 == DialogResult.No)
                {
                    return;
                }
            }
            if (button5.BackColor == Color.FromArgb(255, 0, 0))
            {
                button5.Enabled = false;
            }
            else
            {
                textBox5.Text = Convert.ToString(dateTimePicker1.Value.Date.Day) + "." + Convert.ToString(dateTimePicker1.Value.Date.Month) + "." + Convert.ToString(dateTimePicker1.Value.Date.Year);
                panel3.Show();
                textBox6.Text = button1.Text;
                textBox9.Text = button9.Text;
                textBox10.Text = "1";
                textBox11.Text = button5.Text;
                textBox14.Text = textBox13.Text;
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            textBox8.Text = login;
            textBox7.Text = password;
            textBox13.Text = Convert.ToString(price);
            textBox1.Text = Convert.ToString(buyin);
        }

        private void button141_Click(object sender, EventArgs e)
        {
            button9.Text = textBox12.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox10.Text == "1" && textBox11.Text == "1")
            {
                button5.BackColor = Color.FromArgb(100 , 149, 237);
                panel3.Hide();
                MessageBox.Show("Билет успешно забронирован!\n Код брони:1+1");
                textBox10.Text = " ";
                textBox11.Text = " ";
            }
            if (textBox10.Text == "1" && textBox11.Text == "2")
            {
                button6.BackColor = Color.FromArgb(100, 149, 237);
                panel3.Hide();
                MessageBox.Show("Билет успешно забронирован!\n Код брони:1+2");
                textBox10.Text = " ";
                textBox11.Text = " ";
            }
            if (textBox10.Text == "1" && textBox11.Text == "3")
            {
                button14.BackColor = Color.FromArgb(100, 149, 237);
                panel3.Hide();
                MessageBox.Show("Билет успешно забронирован!\n Код брони:1+3");
                textBox10.Text = " ";
                textBox11.Text = " ";
            }
            if (textBox10.Text == "1" && textBox11.Text == "4")
            {
                button13.BackColor = Color.FromArgb(100, 149, 237);
                panel3.Hide();
                MessageBox.Show("Билет успешно забронирован!\n Код брони:1+4");
                textBox10.Text = " ";
                textBox11.Text = " ";
            }
            if (textBox10.Text == "2" && textBox11.Text == "1")
            {
                button40.BackColor = Color.FromArgb(100, 149, 237);
                panel3.Hide();
                MessageBox.Show("Билет успешно забронирован!\n Код брони:2+1");
                textBox10.Text = " ";
                textBox11.Text = " ";
            }
            if (textBox10.Text == "2" && textBox11.Text == "2")
            {
                button39.BackColor = Color.FromArgb(100, 149, 237);
                panel3.Hide();
                MessageBox.Show("Билет успешно забронирован!\n Код брони:2+2");
                textBox10.Text = " ";
                textBox11.Text = " ";
            }
            if (textBox10.Text == "2" && textBox11.Text == "3")
            {
                button38.BackColor = Color.FromArgb(100, 149, 237);
                panel3.Hide();
                MessageBox.Show("Билет успешно забронирован!\n Код брони:2+3");
                textBox10.Text = " ";
                textBox11.Text = " ";
            }
            if (textBox10.Text == "2" && textBox11.Text == "4")
            {
                button37.BackColor = Color.FromArgb(100, 149, 237);
                panel3.Hide();
                MessageBox.Show("Билет успешно забронирован!\n Код брони:2+4");
                textBox10.Text = " ";
                textBox11.Text = " ";
            }
            if (textBox10.Text == "3" && textBox11.Text == "1")
            {
                button19.BackColor = Color.FromArgb(100, 149, 237);
                panel3.Hide();
                MessageBox.Show("Билет успешно забронирован!\n Код брони:3+1");
                textBox10.Text = " ";
                textBox11.Text = " ";
            }
            if (textBox10.Text == "3" && textBox11.Text == "2")
            {
                button18.BackColor = Color.FromArgb(100, 149, 237);
                panel3.Hide();
                MessageBox.Show("Билет успешно забронирован!\n Код брони:3+2");
                textBox10.Text = " ";
                textBox11.Text = " ";
            }
            if (textBox10.Text == "3" && textBox11.Text == "3")
            {
                button17.BackColor = Color.FromArgb(100, 149, 237);
                panel3.Hide();
                MessageBox.Show("Билет успешно забронирован!\n Код брони:3+3");
                textBox10.Text = " ";
                textBox11.Text = " ";
            }
            if (textBox10.Text == "3" && textBox11.Text == "4")
            {
                button16.BackColor = Color.FromArgb(100, 149, 237);
                panel3.Hide();
                MessageBox.Show("Билет успешно забронирован!\n Код брони:3+4");
                textBox10.Text = " ";
                textBox11.Text = " ";
            }
            if (textBox10.Text == "4" && textBox11.Text == "1")
            {
                button15.BackColor = Color.FromArgb(100, 149, 237);
                panel3.Hide();
                MessageBox.Show("Билет успешно забронирован!\n Код брони:4+1");
                textBox10.Text = " ";
                textBox11.Text = " ";
            }
            if (textBox10.Text == "4" && textBox11.Text == "2")
            {
                button12.BackColor = Color.FromArgb(100, 149, 237);
                panel3.Hide();
                MessageBox.Show("Билет успешно забронирован!\n Код брони:4+2");
                textBox10.Text = " ";
                textBox11.Text = " ";
            }
            if (textBox10.Text == "4" && textBox11.Text == "3")
            {
                button11.BackColor = Color.FromArgb(100, 149, 237);
                panel3.Hide();
                MessageBox.Show("Билет успешно забронирован!\n Код брони:4+3");
                textBox10.Text = " ";
                textBox11.Text = " ";
            }
            if (textBox10.Text == "4" && textBox11.Text == "4")
            {
                button10.BackColor = Color.FromArgb(100, 149, 237);
                panel3.Hide();
                MessageBox.Show("Билет успешно забронирован!\n Код брони:4+4");
                textBox10.Text = " ";
                textBox11.Text = " ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Date < DateTime.Now)
            {
                DateTime f12;
                f12 = DateTime.Now;
                dateTimePicker1.Value = f12;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            l = textBox16.Text;
            p = textBox15.Text;
            if (l == login && p == password)
            {
                panel5.Hide();
                panel2.Show();
                textBox16.Clear();
                textBox15.Clear();
            }
            else
            {
                MessageBox.Show("Не верный логин или пароль");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            panel5.Hide();
            textBox16.Clear();
            textBox15.Clear();
        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Hide();
            button4.Show();
            if (button6.BackColor == Color.FromArgb(100, 149, 237))
            {
                MessageBox.Show("Билет забронирован");
                DialogResult q1 = MessageBox.Show("Выкупить?", "Выкуп", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (q1 == DialogResult.Yes)
                {
                    panel3.Show();
                    textBox2.Enabled = true;
                    textBox2.Show();
                    textBox2.Text = Convert.ToString(price + buyin);
                    button4.Hide();
                }
                if (q1 == DialogResult.No)
                {
                    return;
                }
            }
            if (button6.BackColor == Color.FromArgb(255, 0, 0))
            {
                button6.Enabled = false;
            }
            else
            {
                textBox5.Text = Convert.ToString(dateTimePicker1.Value.Date.Day) + "." + Convert.ToString(dateTimePicker1.Value.Date.Month) + "." + Convert.ToString(dateTimePicker1.Value.Date.Year);
                panel3.Show();
                textBox6.Text = button1.Text;
                textBox9.Text = button9.Text;
                textBox10.Text = "1";
                textBox11.Text = button6.Text;
                textBox14.Text = textBox13.Text;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button4.Show();
            textBox2.Hide();
            if (button14.BackColor == Color.FromArgb(100, 149, 237))
            {
                MessageBox.Show("Билет забронирован");
                DialogResult q1 = MessageBox.Show("Выкупить?", "Выкуп", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (q1 == DialogResult.Yes)
                {
                    panel3.Show();
                    textBox2.Enabled = true;
                    textBox2.Show();
                    textBox2.Text = Convert.ToString(price + buyin);
                    button4.Hide();
                }
                if (q1 == DialogResult.No)
                {
                    return;
                }
            }
            if (button14.BackColor == Color.FromArgb(255, 0, 0))
            {
                button14.Enabled = false;
            }
            else
            {
                textBox5.Text = Convert.ToString(dateTimePicker1.Value.Date.Day) + "." + Convert.ToString(dateTimePicker1.Value.Date.Month) + "." + Convert.ToString(dateTimePicker1.Value.Date.Year);
                panel3.Show();
                textBox6.Text = button1.Text;
                textBox9.Text = button9.Text;
                textBox10.Text = "1";
                textBox11.Text = button14.Text;
                textBox14.Text = textBox13.Text;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button4.Show();
            textBox2.Hide();
            if (button13.BackColor == Color.FromArgb(100, 149, 237))
            {
                MessageBox.Show("Билет забронирован");
                DialogResult q1 = MessageBox.Show("Выкупить?", "Выкуп", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (q1 == DialogResult.Yes)
                {
                    panel3.Show();
                    textBox2.Enabled = true;
                    textBox2.Show();
                    textBox2.Text = Convert.ToString(price + buyin);
                    button4.Hide();
                }
                if (q1 == DialogResult.No)
                {
                    return;
                }
            }
            if (button13.BackColor == Color.FromArgb(255, 0, 0))
            {
                button13.Enabled = false;
            }
            else
            {
                textBox5.Text = Convert.ToString(dateTimePicker1.Value.Date.Day) + "." + Convert.ToString(dateTimePicker1.Value.Date.Month) + "." + Convert.ToString(dateTimePicker1.Value.Date.Year);
                panel3.Show();
                textBox6.Text = button1.Text;
                textBox9.Text = button9.Text;
                textBox10.Text = "1";
                textBox11.Text = button13.Text;
                textBox14.Text = textBox13.Text;
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            button4.Show();
            textBox2.Hide();
            if (button40.BackColor == Color.FromArgb(100, 149, 237))
            {
                MessageBox.Show("Билет забронирован");
                DialogResult q1 = MessageBox.Show("Выкупить?", "Выкуп", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (q1 == DialogResult.Yes)
                {
                    panel3.Show();
                    textBox2.Enabled = true;
                    textBox2.Show();
                    textBox2.Text = Convert.ToString(price + buyin);
                    button4.Hide();
                }
                if (q1 == DialogResult.No)
                {
                    return;
                }
            }
            if (button40.BackColor == Color.FromArgb(255, 0, 0))
            {
                button40.Enabled = false;
            }
            else
            {
                textBox5.Text = Convert.ToString(dateTimePicker1.Value.Date.Day) + "." + Convert.ToString(dateTimePicker1.Value.Date.Month) + "." + Convert.ToString(dateTimePicker1.Value.Date.Year);
                panel3.Show();
                textBox6.Text = button1.Text;
                textBox9.Text = button9.Text;
                textBox10.Text = "2";
                textBox11.Text = button40.Text;
                textBox14.Text = textBox13.Text;
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            button4.Show();
            textBox2.Hide();
            if (button39.BackColor == Color.FromArgb(100, 149, 237))
            {
                MessageBox.Show("Билет забронирован");
                DialogResult q1 = MessageBox.Show("Выкупить?", "Выкуп", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (q1 == DialogResult.Yes)
                {
                    panel3.Show();
                    textBox2.Enabled = true;
                    textBox2.Show();
                    textBox2.Text = Convert.ToString(price + buyin);
                    button4.Hide();
                }
                if (q1 == DialogResult.No)
                {
                    return;
                }
            }
            if (button39.BackColor == Color.FromArgb(255, 0, 0))
            {
                button39.Enabled = false;
            }
            else
            {
                textBox5.Text = Convert.ToString(dateTimePicker1.Value.Date.Day) + "." + Convert.ToString(dateTimePicker1.Value.Date.Month) + "." + Convert.ToString(dateTimePicker1.Value.Date.Year);
                panel3.Show();
                textBox6.Text = button1.Text;
                textBox9.Text = button9.Text;
                textBox10.Text = "2";
                textBox11.Text = button39.Text;
                textBox14.Text = textBox13.Text;
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            button4.Show();
            textBox2.Hide();
            if (button38.BackColor == Color.FromArgb(100, 149, 237))
            {
                MessageBox.Show("Билет забронирован");
                DialogResult q1 = MessageBox.Show("Выкупить?", "Выкуп", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (q1 == DialogResult.Yes)
                {
                    panel3.Show();
                    textBox2.Enabled = true;
                    textBox2.Show();
                    textBox2.Text = Convert.ToString(price + buyin);
                    button4.Hide();
                }
                if (q1 == DialogResult.No)
                {
                    return;
                }
            }
            if (button38.BackColor == Color.FromArgb(255, 0, 0))
            {
                button38.Enabled = false;
            }
            else
            {
                textBox5.Text = Convert.ToString(dateTimePicker1.Value.Date.Day) + "." + Convert.ToString(dateTimePicker1.Value.Date.Month) + "." + Convert.ToString(dateTimePicker1.Value.Date.Year);
                panel3.Show();
                textBox6.Text = button1.Text;
                textBox9.Text = button9.Text;
                textBox10.Text = "2";
                textBox11.Text = button38.Text;
                textBox14.Text = textBox13.Text;
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            button4.Show();
            textBox2.Hide();
            if (button37.BackColor == Color.FromArgb(100, 149, 237))
            {
                MessageBox.Show("Билет забронирован");
                DialogResult q1 = MessageBox.Show("Выкупить?", "Выкуп", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (q1 == DialogResult.Yes)
                {
                    panel3.Show();
                    textBox2.Enabled = true;
                    textBox2.Show();
                    textBox2.Text = Convert.ToString(price + buyin);
                    button4.Hide();
                }
                if (q1 == DialogResult.No)
                {
                    return;
                }
            }
            if (button37.BackColor == Color.FromArgb(255, 0, 0))
            {
                button37.Enabled = false;
            }
            else
            {
                textBox5.Text = Convert.ToString(dateTimePicker1.Value.Date.Day) + "." + Convert.ToString(dateTimePicker1.Value.Date.Month) + "." + Convert.ToString(dateTimePicker1.Value.Date.Year);
                panel3.Show();
                textBox6.Text = button1.Text;
                textBox9.Text = button9.Text;
                textBox10.Text = "2";
                textBox11.Text = button37.Text;
                textBox14.Text = textBox13.Text;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button4.Show();
            textBox2.Hide();
            if (button19.BackColor == Color.FromArgb(100, 149, 237))
            {
                MessageBox.Show("Билет забронирован");
                DialogResult q1 = MessageBox.Show("Выкупить?", "Выкуп", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (q1 == DialogResult.Yes)
                {
                    panel3.Show();
                    textBox2.Enabled = true;
                    textBox2.Show();
                    textBox2.Text = Convert.ToString(price + buyin);
                    button4.Hide();
                }
                if (q1 == DialogResult.No)
                {
                    return;
                }
            }
            if (button19.BackColor == Color.FromArgb(255, 0, 0))
            {
                button19.Enabled = false;
            }
            else
            {
                textBox5.Text = Convert.ToString(dateTimePicker1.Value.Date.Day) + "." + Convert.ToString(dateTimePicker1.Value.Date.Month) + "." + Convert.ToString(dateTimePicker1.Value.Date.Year);
                panel3.Show();
                textBox6.Text = button1.Text;
                textBox9.Text = button9.Text;
                textBox10.Text = "3";
                textBox11.Text = button19.Text;
                textBox14.Text = textBox13.Text;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button4.Show();
            textBox2.Hide();
            if (button18.BackColor == Color.FromArgb(100, 149, 237))
            {
                MessageBox.Show("Билет забронирован");
                DialogResult q1 = MessageBox.Show("Выкупить?", "Выкуп", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (q1 == DialogResult.Yes)
                {
                    panel3.Show();
                    textBox2.Enabled = true;
                    textBox2.Show();
                    textBox2.Text = Convert.ToString(price + buyin);
                    button4.Hide();
                }
                if (q1 == DialogResult.No)
                {
                    return;
                }
            }
            if (button18.BackColor == Color.FromArgb(255, 0, 0))
            {
                button18.Enabled = false;
            }
            else
            {
                textBox5.Text = Convert.ToString(dateTimePicker1.Value.Date.Day) + "." + Convert.ToString(dateTimePicker1.Value.Date.Month) + "." + Convert.ToString(dateTimePicker1.Value.Date.Year);
                panel3.Show();
                textBox6.Text = button1.Text;
                textBox9.Text = button9.Text;
                textBox10.Text = "3";
                textBox11.Text = button18.Text;
                textBox14.Text = textBox13.Text;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button4.Show();
            textBox2.Hide();
            if (button17.BackColor == Color.FromArgb(100, 149, 237))
            {
                MessageBox.Show("Билет забронирован");
                DialogResult q1 = MessageBox.Show("Выкупить?", "Выкуп", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (q1 == DialogResult.Yes)
                {
                    panel3.Show();
                    textBox2.Enabled = true;
                    textBox2.Show();
                    textBox2.Text = Convert.ToString(price + buyin);
                    button4.Hide();
                }
                if (q1 == DialogResult.No)
                {
                    return;
                }
            }
            if (button17.BackColor == Color.FromArgb(255, 0, 0))
            {
                button17.Enabled = false;
            }
            else
            {
                textBox5.Text = Convert.ToString(dateTimePicker1.Value.Date.Day) + "." + Convert.ToString(dateTimePicker1.Value.Date.Month) + "." + Convert.ToString(dateTimePicker1.Value.Date.Year);
                panel3.Show();
                textBox6.Text = button1.Text;
                textBox9.Text = button9.Text;
                textBox10.Text = "3";
                textBox11.Text = button17.Text;
                textBox14.Text = textBox13.Text;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button4.Show();
            textBox2.Hide();
            if (button16.BackColor == Color.FromArgb(100, 149, 237))
            {
                MessageBox.Show("Билет забронирован");
                DialogResult q1 = MessageBox.Show("Выкупить?", "Выкуп", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (q1 == DialogResult.Yes)
                {
                    panel3.Show();
                    textBox2.Enabled = true;
                    textBox2.Show();
                    textBox2.Text = Convert.ToString(price + buyin);
                    button4.Hide();
                }
                if (q1 == DialogResult.No)
                {
                    return;
                }
            }
            if (button16.BackColor == Color.FromArgb(255, 0, 0))
            {
                button16.Enabled = false;
            }
            else
            {
                textBox5.Text = Convert.ToString(dateTimePicker1.Value.Date.Day) + "." + Convert.ToString(dateTimePicker1.Value.Date.Month) + "." + Convert.ToString(dateTimePicker1.Value.Date.Year);
                panel3.Show();
                textBox6.Text = button1.Text;
                textBox9.Text = button9.Text;
                textBox10.Text = "3";
                textBox11.Text = button16.Text;
                textBox14.Text = textBox13.Text;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button4.Show();
            textBox2.Hide();
            if (button15.BackColor == Color.FromArgb(100, 149, 237))
            {
                MessageBox.Show("Билет забронирован");
                DialogResult q1 = MessageBox.Show("Выкупить?", "Выкуп", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (q1 == DialogResult.Yes)
                {
                    panel3.Show();
                    textBox2.Enabled = true;
                    textBox2.Show();
                    textBox2.Text = Convert.ToString(price + buyin);
                    button4.Hide();
                }
                if (q1 == DialogResult.No)
                {
                    return;
                }
            }
            if (button15.BackColor == Color.FromArgb(255, 0, 0))
            {
                button15.Enabled = false;
            }
            else
            {
                textBox5.Text = Convert.ToString(dateTimePicker1.Value.Date.Day) + "." + Convert.ToString(dateTimePicker1.Value.Date.Month) + "." + Convert.ToString(dateTimePicker1.Value.Date.Year);
                panel3.Show();
                textBox6.Text = button1.Text;
                textBox9.Text = button9.Text;
                textBox10.Text = "4";
                textBox11.Text = button15.Text;
                textBox14.Text = textBox13.Text;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button4.Show();
            textBox2.Hide();
            if (button12.BackColor == Color.FromArgb(100, 149, 237))
            {
                MessageBox.Show("Билет забронирован");
                DialogResult q1 = MessageBox.Show("Выкупить?", "Выкуп", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (q1 == DialogResult.Yes)
                {
                    panel3.Show();
                    textBox2.Enabled = true;
                    textBox2.Show();
                    textBox2.Text = Convert.ToString(price + buyin);
                    button4.Hide();
                }
                if (q1 == DialogResult.No)
                {
                    return;
                }
            }
            if (button12.BackColor == Color.FromArgb(255, 0, 0))
            {
                button12.Enabled = false;
            }
            else
            {
                textBox5.Text = Convert.ToString(dateTimePicker1.Value.Date.Day) + "." + Convert.ToString(dateTimePicker1.Value.Date.Month) + "." + Convert.ToString(dateTimePicker1.Value.Date.Year);
                panel3.Show();
                textBox6.Text = button1.Text;
                textBox9.Text = button9.Text;
                textBox10.Text = "4";
                textBox11.Text = button12.Text;
                textBox14.Text = textBox13.Text;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button4.Show();
            textBox2.Hide();
            if (button11.BackColor == Color.FromArgb(100, 149, 237))
            {
                MessageBox.Show("Билет забронирован");
                DialogResult q1 = MessageBox.Show("Выкупить?", "Выкуп", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (q1 == DialogResult.Yes)
                {
                    panel3.Show();
                    textBox2.Enabled = true;
                    textBox2.Show();
                    textBox2.Text = Convert.ToString(price + buyin);
                    button4.Hide();
                }
                if (q1 == DialogResult.No)
                {
                    return;
                }
            }
            if (button11.BackColor == Color.FromArgb(255, 0, 0))
            {
                button11.Enabled = false;
            }
            else
            {
                textBox5.Text = Convert.ToString(dateTimePicker1.Value.Date.Day) + "." + Convert.ToString(dateTimePicker1.Value.Date.Month) + "." + Convert.ToString(dateTimePicker1.Value.Date.Year);
                panel3.Show();
                textBox6.Text = button1.Text;
                textBox9.Text = button9.Text;
                textBox10.Text = "4";
                textBox11.Text = button11.Text;
                textBox14.Text = textBox13.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button4.Show();
            textBox2.Hide();
            if (button10.BackColor == Color.FromArgb(100, 149, 237))
            {
                MessageBox.Show("Билет забронирован");
                DialogResult q1 = MessageBox.Show("Выкупить?", "Выкуп", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (q1 == DialogResult.Yes)
                {
                    panel3.Show();
                    textBox2.Enabled = true;
                    textBox2.Show();
                    textBox2.Text = Convert.ToString(price + buyin);
                    button4.Hide();
                }
                if (q1 == DialogResult.No)
                {
                    return;
                }
            }
            if (button10.BackColor == Color.FromArgb(255, 0, 0))
            {
                button10.Enabled = false;
            }
            else
            {
                textBox5.Text = Convert.ToString(dateTimePicker1.Value.Date.Day) + "." + Convert.ToString(dateTimePicker1.Value.Date.Month) + "." + Convert.ToString(dateTimePicker1.Value.Date.Year);
                panel3.Show();
                textBox6.Text = button1.Text;
                textBox9.Text = button9.Text;
                textBox10.Text = "4";
                textBox11.Text = button10.Text;
                textBox14.Text = textBox13.Text;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            buyin = Convert.ToInt32(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            button1.Text = textBox3.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            password = textBox7.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox17.Clear();
            panel3.Show();
            panel4.Hide();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (textBox17.Text == "")
            {
                MessageBox.Show("Поле пустое!");
            }
            else
            {
                if (textBox10.Text == "1" && textBox11.Text == "1")
                {
                    MessageBox.Show("Билет оплачен!");
                    panel4.Hide();
                    panel3.Hide();
                    textBox17.Clear();
                    button5.BackColor = Color.FromArgb(255, 0, 0);
                    button5.Enabled = false;
                    SaveFileDialog saveFile1 = new SaveFileDialog();
                    saveFile1.DefaultExt = "*.txt";
                    saveFile1.Filter = "Билет|*.txt";
                    if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                        saveFile1.FileName.Length > 0)
                    {
                        using (StreamWriter sw = new StreamWriter(saveFile1.FileName, true))
                        {
                            if (textBox2.Enabled == true)
                            {
                                sw.WriteLine(label4.Text + textBox4.Text);
                                sw.WriteLine(label5.Text + textBox5.Text);
                                sw.WriteLine(label6.Text + textBox6.Text);
                                sw.WriteLine(label9.Text + textBox9.Text);
                                sw.WriteLine(label10.Text + textBox10.Text);
                                sw.WriteLine(label11.Text + textBox11.Text);
                                sw.WriteLine(label14.Text + textBox2.Text);
                                sw.Close();
                            }
                            else
                            {
                                sw.WriteLine(label4.Text + textBox4.Text);
                                sw.WriteLine(label5.Text + textBox5.Text);
                                sw.WriteLine(label6.Text + textBox6.Text);
                                sw.WriteLine(label9.Text + textBox9.Text);
                                sw.WriteLine(label10.Text + textBox10.Text);
                                sw.WriteLine(label11.Text + textBox11.Text);
                                sw.WriteLine(label14.Text + textBox14.Text);
                                sw.Close();
                            }
                        }
                    }
                }
                if (textBox10.Text == "1" && textBox11.Text == "2")
                {
                    MessageBox.Show("Билет оплачен!");
                    panel4.Hide();
                    panel3.Hide();
                    textBox17.Clear();
                    button6.BackColor = Color.FromArgb(255, 0, 0);
                    button6.Enabled = false;
                    SaveFileDialog saveFile1 = new SaveFileDialog();
                    saveFile1.DefaultExt = "*.txt";
                    saveFile1.Filter = "Билет|*.txt";
                    if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                        saveFile1.FileName.Length > 0)
                    {
                        using (StreamWriter sw = new StreamWriter(saveFile1.FileName, true))
                        {
                            if (textBox2.Enabled == true)
                            {
                                sw.WriteLine(label4.Text + textBox4.Text);
                                sw.WriteLine(label5.Text + textBox5.Text);
                                sw.WriteLine(label6.Text + textBox6.Text);
                                sw.WriteLine(label9.Text + textBox9.Text);
                                sw.WriteLine(label10.Text + textBox10.Text);
                                sw.WriteLine(label11.Text + textBox11.Text);
                                sw.WriteLine(label14.Text + textBox2.Text);
                                sw.Close();
                            }
                            else
                            {
                                sw.WriteLine(label4.Text + textBox4.Text);
                                sw.WriteLine(label5.Text + textBox5.Text);
                                sw.WriteLine(label6.Text + textBox6.Text);
                                sw.WriteLine(label9.Text + textBox9.Text);
                                sw.WriteLine(label10.Text + textBox10.Text);
                                sw.WriteLine(label11.Text + textBox11.Text);
                                sw.WriteLine(label14.Text + textBox14.Text);
                                sw.Close();
                            }
                        }
                    }
                }
                if (textBox10.Text == "1" && textBox11.Text == "3")
                {
                    MessageBox.Show("Билет оплачен!");
                    panel4.Hide();
                    panel3.Hide();
                    textBox17.Clear();
                    button14.BackColor = Color.FromArgb(255, 0, 0);
                    button14.Enabled = false;
                    SaveFileDialog saveFile1 = new SaveFileDialog();
                    saveFile1.DefaultExt = "*.txt";
                    saveFile1.Filter = "Билет|*.txt";
                    if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                        saveFile1.FileName.Length > 0)
                    {
                        using (StreamWriter sw = new StreamWriter(saveFile1.FileName, true))
                        {
                            if (textBox2.Enabled == true)
                            {
                                sw.WriteLine(label4.Text + textBox4.Text);
                                sw.WriteLine(label5.Text + textBox5.Text);
                                sw.WriteLine(label6.Text + textBox6.Text);
                                sw.WriteLine(label9.Text + textBox9.Text);
                                sw.WriteLine(label10.Text + textBox10.Text);
                                sw.WriteLine(label11.Text + textBox11.Text);
                                sw.WriteLine(label14.Text + textBox2.Text);
                                sw.Close();
                            }
                            else
                            {
                                sw.WriteLine(label4.Text + textBox4.Text);
                                sw.WriteLine(label5.Text + textBox5.Text);
                                sw.WriteLine(label6.Text + textBox6.Text);
                                sw.WriteLine(label9.Text + textBox9.Text);
                                sw.WriteLine(label10.Text + textBox10.Text);
                                sw.WriteLine(label11.Text + textBox11.Text);
                                sw.WriteLine(label14.Text + textBox14.Text);
                                sw.Close();
                            }
                        }
                    }
                }
                if (textBox10.Text == "1" && textBox11.Text == "4")
                {
                    MessageBox.Show("Билет оплачен!");
                    panel4.Hide();
                    panel3.Hide();
                    textBox17.Clear();
                    button13.BackColor = Color.FromArgb(255, 0, 0);
                    button13.Enabled = false;
                    SaveFileDialog saveFile1 = new SaveFileDialog();
                    saveFile1.DefaultExt = "*.txt";
                    saveFile1.Filter = "Билет|*.txt";
                    if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                        saveFile1.FileName.Length > 0)
                    {
                        using (StreamWriter sw = new StreamWriter(saveFile1.FileName, true))
                        {
                            if (textBox2.Enabled == true)
                            {
                                sw.WriteLine(label4.Text + textBox4.Text);
                                sw.WriteLine(label5.Text + textBox5.Text);
                                sw.WriteLine(label6.Text + textBox6.Text);
                                sw.WriteLine(label9.Text + textBox9.Text);
                                sw.WriteLine(label10.Text + textBox10.Text);
                                sw.WriteLine(label11.Text + textBox11.Text);
                                sw.WriteLine(label14.Text + textBox2.Text);
                                sw.Close();
                            }
                            else
                            {
                                sw.WriteLine(label4.Text + textBox4.Text);
                                sw.WriteLine(label5.Text + textBox5.Text);
                                sw.WriteLine(label6.Text + textBox6.Text);
                                sw.WriteLine(label9.Text + textBox9.Text);
                                sw.WriteLine(label10.Text + textBox10.Text);
                                sw.WriteLine(label11.Text + textBox11.Text);
                                sw.WriteLine(label14.Text + textBox14.Text);
                                sw.Close();
                            }
                        }
                    }
                }
                if (textBox10.Text == "2" && textBox11.Text == "1")
                {
                    MessageBox.Show("Билет оплачен!");
                    panel4.Hide();
                    panel3.Hide();
                    textBox17.Clear();
                    button40.BackColor = Color.FromArgb(255, 0, 0);
                    button40.Enabled = false;
                    SaveFileDialog saveFile1 = new SaveFileDialog();
                    saveFile1.DefaultExt = "*.txt";
                    saveFile1.Filter = "Билет|*.txt";
                    if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                        saveFile1.FileName.Length > 0)
                    {
                        using (StreamWriter sw = new StreamWriter(saveFile1.FileName, true))
                        {
                            if (textBox2.Enabled == true)
                            {
                                sw.WriteLine(label4.Text + textBox4.Text);
                                sw.WriteLine(label5.Text + textBox5.Text);
                                sw.WriteLine(label6.Text + textBox6.Text);
                                sw.WriteLine(label9.Text + textBox9.Text);
                                sw.WriteLine(label10.Text + textBox10.Text);
                                sw.WriteLine(label11.Text + textBox11.Text);
                                sw.WriteLine(label14.Text + textBox2.Text);
                                sw.Close();
                            }
                            else
                            {
                                sw.WriteLine(label4.Text + textBox4.Text);
                                sw.WriteLine(label5.Text + textBox5.Text);
                                sw.WriteLine(label6.Text + textBox6.Text);
                                sw.WriteLine(label9.Text + textBox9.Text);
                                sw.WriteLine(label10.Text + textBox10.Text);
                                sw.WriteLine(label11.Text + textBox11.Text);
                                sw.WriteLine(label14.Text + textBox14.Text);
                                sw.Close();
                            }
                        }
                    }
                }
                if (textBox10.Text == "2" && textBox11.Text == "2")
                {
                    MessageBox.Show("Билет оплачен!");
                    panel4.Hide();
                    panel3.Hide();
                    textBox17.Clear();
                    button39.BackColor = Color.FromArgb(255, 0, 0);
                    button39.Enabled = false;
                    SaveFileDialog saveFile1 = new SaveFileDialog();
                    saveFile1.DefaultExt = "*.txt";
                    saveFile1.Filter = "Билет|*.txt";
                    if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                        saveFile1.FileName.Length > 0)
                    {
                        using (StreamWriter sw = new StreamWriter(saveFile1.FileName, true))
                        {
                            if (textBox2.Enabled == true)
                            {
                                sw.WriteLine(label4.Text + textBox4.Text);
                                sw.WriteLine(label5.Text + textBox5.Text);
                                sw.WriteLine(label6.Text + textBox6.Text);
                                sw.WriteLine(label9.Text + textBox9.Text);
                                sw.WriteLine(label10.Text + textBox10.Text);
                                sw.WriteLine(label11.Text + textBox11.Text);
                                sw.WriteLine(label14.Text + textBox2.Text);
                                sw.Close();
                            }
                            else
                            {
                                sw.WriteLine(label4.Text + textBox4.Text);
                                sw.WriteLine(label5.Text + textBox5.Text);
                                sw.WriteLine(label6.Text + textBox6.Text);
                                sw.WriteLine(label9.Text + textBox9.Text);
                                sw.WriteLine(label10.Text + textBox10.Text);
                                sw.WriteLine(label11.Text + textBox11.Text);
                                sw.WriteLine(label14.Text + textBox14.Text);
                                sw.Close();
                            }
                        }
                    }
                }
                if (textBox10.Text == "2" && textBox11.Text == "3")
                {
                    MessageBox.Show("Билет оплачен!");
                    panel4.Hide();
                    panel3.Hide();
                    textBox17.Clear();
                    button38.BackColor = Color.FromArgb(255, 0, 0);
                    button38.Enabled = false;
                    SaveFileDialog saveFile1 = new SaveFileDialog();
                    saveFile1.DefaultExt = "*.txt";
                    saveFile1.Filter = "Билет|*.txt";
                    if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                        saveFile1.FileName.Length > 0)
                    {
                        using (StreamWriter sw = new StreamWriter(saveFile1.FileName, true))
                        {
                            if (textBox2.Enabled == true)
                            {
                                sw.WriteLine(label4.Text + textBox4.Text);
                                sw.WriteLine(label5.Text + textBox5.Text);
                                sw.WriteLine(label6.Text + textBox6.Text);
                                sw.WriteLine(label9.Text + textBox9.Text);
                                sw.WriteLine(label10.Text + textBox10.Text);
                                sw.WriteLine(label11.Text + textBox11.Text);
                                sw.WriteLine(label14.Text + textBox2.Text);
                                sw.Close();
                            }
                            else
                            {
                                sw.WriteLine(label4.Text + textBox4.Text);
                                sw.WriteLine(label5.Text + textBox5.Text);
                                sw.WriteLine(label6.Text + textBox6.Text);
                                sw.WriteLine(label9.Text + textBox9.Text);
                                sw.WriteLine(label10.Text + textBox10.Text);
                                sw.WriteLine(label11.Text + textBox11.Text);
                                sw.WriteLine(label14.Text + textBox14.Text);
                                sw.Close();
                            }
                        }
                    }
                }
                if (textBox10.Text == "2" && textBox11.Text == "4")
                {
                    MessageBox.Show("Билет оплачен!");
                    panel4.Hide();
                    panel3.Hide();
                    textBox17.Clear();
                    button37.BackColor = Color.FromArgb(255, 0, 0);
                    button37.Enabled = false;
                    SaveFileDialog saveFile1 = new SaveFileDialog();
                    saveFile1.DefaultExt = "*.txt";
                    saveFile1.Filter = "Билет|*.txt";
                    if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                        saveFile1.FileName.Length > 0)
                    {
                        using (StreamWriter sw = new StreamWriter(saveFile1.FileName, true))
                        {
                            if (textBox2.Enabled == true)
                            {
                                sw.WriteLine(label4.Text + textBox4.Text);
                                sw.WriteLine(label5.Text + textBox5.Text);
                                sw.WriteLine(label6.Text + textBox6.Text);
                                sw.WriteLine(label9.Text + textBox9.Text);
                                sw.WriteLine(label10.Text + textBox10.Text);
                                sw.WriteLine(label11.Text + textBox11.Text);
                                sw.WriteLine(label14.Text + textBox2.Text);
                                sw.Close();
                            }
                            else
                            {
                                sw.WriteLine(label4.Text + textBox4.Text);
                                sw.WriteLine(label5.Text + textBox5.Text);
                                sw.WriteLine(label6.Text + textBox6.Text);
                                sw.WriteLine(label9.Text + textBox9.Text);
                                sw.WriteLine(label10.Text + textBox10.Text);
                                sw.WriteLine(label11.Text + textBox11.Text);
                                sw.WriteLine(label14.Text + textBox14.Text);
                                sw.Close();
                            }
                        }
                    }
                }
                if (textBox10.Text == "3" && textBox11.Text == "1")
                {
                    MessageBox.Show("Билет оплачен!");
                    panel4.Hide();
                    panel3.Hide();
                    textBox17.Clear();
                    button19.BackColor = Color.FromArgb(255, 0, 0);
                    button19.Enabled = false;
                    SaveFileDialog saveFile1 = new SaveFileDialog();
                    saveFile1.DefaultExt = "*.txt";
                    saveFile1.Filter = "Билет|*.txt";
                    if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                        saveFile1.FileName.Length > 0)
                    {
                        using (StreamWriter sw = new StreamWriter(saveFile1.FileName, true))
                        {
                            if (textBox2.Enabled == true)
                            {
                                sw.WriteLine(label4.Text + textBox4.Text);
                                sw.WriteLine(label5.Text + textBox5.Text);
                                sw.WriteLine(label6.Text + textBox6.Text);
                                sw.WriteLine(label9.Text + textBox9.Text);
                                sw.WriteLine(label10.Text + textBox10.Text);
                                sw.WriteLine(label11.Text + textBox11.Text);
                                sw.WriteLine(label14.Text + textBox2.Text);
                                sw.Close();
                            }
                            else
                            {
                                sw.WriteLine(label4.Text + textBox4.Text);
                                sw.WriteLine(label5.Text + textBox5.Text);
                                sw.WriteLine(label6.Text + textBox6.Text);
                                sw.WriteLine(label9.Text + textBox9.Text);
                                sw.WriteLine(label10.Text + textBox10.Text);
                                sw.WriteLine(label11.Text + textBox11.Text);
                                sw.WriteLine(label14.Text + textBox14.Text);
                                sw.Close();
                            }
                        }
                    }
                }
                if (textBox10.Text == "3" && textBox11.Text == "2")
                {
                    MessageBox.Show("Билет оплачен!");
                    panel4.Hide();
                    panel3.Hide();
                    textBox17.Clear();
                    button18.BackColor = Color.FromArgb(255, 0, 0);
                    button18.Enabled = false;
                    SaveFileDialog saveFile1 = new SaveFileDialog();
                    saveFile1.DefaultExt = "*.txt";
                    saveFile1.Filter = "Билет|*.txt";
                    if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                        saveFile1.FileName.Length > 0)
                    {
                        using (StreamWriter sw = new StreamWriter(saveFile1.FileName, true))
                        {
                            if (textBox2.Enabled == true)
                            {
                                sw.WriteLine(label4.Text + textBox4.Text);
                                sw.WriteLine(label5.Text + textBox5.Text);
                                sw.WriteLine(label6.Text + textBox6.Text);
                                sw.WriteLine(label9.Text + textBox9.Text);
                                sw.WriteLine(label10.Text + textBox10.Text);
                                sw.WriteLine(label11.Text + textBox11.Text);
                                sw.WriteLine(label14.Text + textBox2.Text);
                                sw.Close();
                            }
                            else
                            {
                                sw.WriteLine(label4.Text + textBox4.Text);
                                sw.WriteLine(label5.Text + textBox5.Text);
                                sw.WriteLine(label6.Text + textBox6.Text);
                                sw.WriteLine(label9.Text + textBox9.Text);
                                sw.WriteLine(label10.Text + textBox10.Text);
                                sw.WriteLine(label11.Text + textBox11.Text);
                                sw.WriteLine(label14.Text + textBox14.Text);
                                sw.Close();
                            }
                        }
                    }
                }
                if (textBox10.Text == "3" && textBox11.Text == "3")
                {
                    MessageBox.Show("Билет оплачен!");
                    panel4.Hide();
                    panel3.Hide();
                    textBox17.Clear();
                    button17.BackColor = Color.FromArgb(255, 0, 0);
                    button17.Enabled = false;
                    SaveFileDialog saveFile1 = new SaveFileDialog();
                    saveFile1.DefaultExt = "*.txt";
                    saveFile1.Filter = "Билет|*.txt";
                    if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                        saveFile1.FileName.Length > 0)
                    {
                        using (StreamWriter sw = new StreamWriter(saveFile1.FileName, true))
                        {
                            if (textBox2.Enabled == true)
                            {
                                sw.WriteLine(label4.Text + textBox4.Text);
                                sw.WriteLine(label5.Text + textBox5.Text);
                                sw.WriteLine(label6.Text + textBox6.Text);
                                sw.WriteLine(label9.Text + textBox9.Text);
                                sw.WriteLine(label10.Text + textBox10.Text);
                                sw.WriteLine(label11.Text + textBox11.Text);
                                sw.WriteLine(label14.Text + textBox2.Text);
                                sw.Close();
                            }
                            else
                            {
                                sw.WriteLine(label4.Text + textBox4.Text);
                                sw.WriteLine(label5.Text + textBox5.Text);
                                sw.WriteLine(label6.Text + textBox6.Text);
                                sw.WriteLine(label9.Text + textBox9.Text);
                                sw.WriteLine(label10.Text + textBox10.Text);
                                sw.WriteLine(label11.Text + textBox11.Text);
                                sw.WriteLine(label14.Text + textBox14.Text);
                                sw.Close();
                            }
                        }
                    }
                }
                if (textBox10.Text == "3" && textBox11.Text == "4")
                {
                    MessageBox.Show("Билет оплачен!");
                    panel4.Hide();
                    panel3.Hide();
                    textBox17.Clear();
                    button16.BackColor = Color.FromArgb(255, 0, 0);
                    button16.Enabled = false;
                    SaveFileDialog saveFile1 = new SaveFileDialog();
                    saveFile1.DefaultExt = "*.txt";
                    saveFile1.Filter = "Билет|*.txt";
                    if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                        saveFile1.FileName.Length > 0)
                    {
                        using (StreamWriter sw = new StreamWriter(saveFile1.FileName, true))
                        {
                            if (textBox2.Enabled == true)
                            {
                                sw.WriteLine(label4.Text + textBox4.Text);
                                sw.WriteLine(label5.Text + textBox5.Text);
                                sw.WriteLine(label6.Text + textBox6.Text);
                                sw.WriteLine(label9.Text + textBox9.Text);
                                sw.WriteLine(label10.Text + textBox10.Text);
                                sw.WriteLine(label11.Text + textBox11.Text);
                                sw.WriteLine(label14.Text + textBox2.Text);
                                sw.Close();
                            }
                            else
                            {
                                sw.WriteLine(label4.Text + textBox4.Text);
                                sw.WriteLine(label5.Text + textBox5.Text);
                                sw.WriteLine(label6.Text + textBox6.Text);
                                sw.WriteLine(label9.Text + textBox9.Text);
                                sw.WriteLine(label10.Text + textBox10.Text);
                                sw.WriteLine(label11.Text + textBox11.Text);
                                sw.WriteLine(label14.Text + textBox14.Text);
                                sw.Close();
                            }
                        }
                    }
                }
                if (textBox10.Text == "4" && textBox11.Text == "1")
                {
                    MessageBox.Show("Билет оплачен!");
                    panel4.Hide();
                    panel3.Hide();
                    textBox17.Clear();
                    button15.BackColor = Color.FromArgb(255, 0, 0);
                    button15.Enabled = false;
                    SaveFileDialog saveFile1 = new SaveFileDialog();
                    saveFile1.DefaultExt = "*.txt";
                    saveFile1.Filter = "Билет|*.txt";
                    if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                        saveFile1.FileName.Length > 0)
                    {
                        using (StreamWriter sw = new StreamWriter(saveFile1.FileName, true))
                        {
                            if (textBox2.Enabled == true)
                            {
                                sw.WriteLine(label4.Text + textBox4.Text);
                                sw.WriteLine(label5.Text + textBox5.Text);
                                sw.WriteLine(label6.Text + textBox6.Text);
                                sw.WriteLine(label9.Text + textBox9.Text);
                                sw.WriteLine(label10.Text + textBox10.Text);
                                sw.WriteLine(label11.Text + textBox11.Text);
                                sw.WriteLine(label14.Text + textBox2.Text);
                                sw.Close();
                            }
                            else
                            {
                                sw.WriteLine(label4.Text + textBox4.Text);
                                sw.WriteLine(label5.Text + textBox5.Text);
                                sw.WriteLine(label6.Text + textBox6.Text);
                                sw.WriteLine(label9.Text + textBox9.Text);
                                sw.WriteLine(label10.Text + textBox10.Text);
                                sw.WriteLine(label11.Text + textBox11.Text);
                                sw.WriteLine(label14.Text + textBox14.Text);
                                sw.Close();
                            }
                        }
                    }
                }
                if (textBox10.Text == "4" && textBox11.Text == "2")
                {
                    MessageBox.Show("Билет оплачен!");
                    panel4.Hide();
                    panel3.Hide();
                    textBox17.Clear();
                    button12.BackColor = Color.FromArgb(255, 0, 0);
                    button12.Enabled = false;
                    SaveFileDialog saveFile1 = new SaveFileDialog();
                    saveFile1.DefaultExt = "*.txt";
                    saveFile1.Filter = "Билет|*.txt";
                    if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                        saveFile1.FileName.Length > 0)
                    {
                        using (StreamWriter sw = new StreamWriter(saveFile1.FileName, true))
                        {
                            if (textBox2.Enabled == true)
                            {
                                sw.WriteLine(label4.Text + textBox4.Text);
                                sw.WriteLine(label5.Text + textBox5.Text);
                                sw.WriteLine(label6.Text + textBox6.Text);
                                sw.WriteLine(label9.Text + textBox9.Text);
                                sw.WriteLine(label10.Text + textBox10.Text);
                                sw.WriteLine(label11.Text + textBox11.Text);
                                sw.WriteLine(label14.Text + textBox2.Text);
                                sw.Close();
                            }
                            else
                            {
                                sw.WriteLine(label4.Text + textBox4.Text);
                                sw.WriteLine(label5.Text + textBox5.Text);
                                sw.WriteLine(label6.Text + textBox6.Text);
                                sw.WriteLine(label9.Text + textBox9.Text);
                                sw.WriteLine(label10.Text + textBox10.Text);
                                sw.WriteLine(label11.Text + textBox11.Text);
                                sw.WriteLine(label14.Text + textBox14.Text);
                                sw.Close();
                            }
                        }
                    }
                }
                if (textBox10.Text == "4" && textBox11.Text == "3")
                {
                    MessageBox.Show("Билет оплачен!");
                    panel4.Hide();
                    panel3.Hide();
                    textBox17.Clear();
                    button11.BackColor = Color.FromArgb(255, 0, 0);
                    button11.Enabled = false;
                    SaveFileDialog saveFile1 = new SaveFileDialog();
                    saveFile1.DefaultExt = "*.txt";
                    saveFile1.Filter = "Билет|*.txt";
                    if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                        saveFile1.FileName.Length > 0)
                    {
                        using (StreamWriter sw = new StreamWriter(saveFile1.FileName, true))
                        {
                            if (textBox2.Enabled == true)
                            {
                                sw.WriteLine(label4.Text + textBox4.Text);
                                sw.WriteLine(label5.Text + textBox5.Text);
                                sw.WriteLine(label6.Text + textBox6.Text);
                                sw.WriteLine(label9.Text + textBox9.Text);
                                sw.WriteLine(label10.Text + textBox10.Text);
                                sw.WriteLine(label11.Text + textBox11.Text);
                                sw.WriteLine(label14.Text + textBox2.Text);
                                sw.Close();
                            }
                            else
                            {
                                sw.WriteLine(label4.Text + textBox4.Text);
                                sw.WriteLine(label5.Text + textBox5.Text);
                                sw.WriteLine(label6.Text + textBox6.Text);
                                sw.WriteLine(label9.Text + textBox9.Text);
                                sw.WriteLine(label10.Text + textBox10.Text);
                                sw.WriteLine(label11.Text + textBox11.Text);
                                sw.WriteLine(label14.Text + textBox14.Text);
                                sw.Close();
                            }
                        }
                    }
                }
                if (textBox10.Text == "4" && textBox11.Text == "4")
                {
                    MessageBox.Show("Билет оплачен!");
                    panel4.Hide();
                    panel3.Hide();
                    textBox17.Clear();
                    button10.BackColor = Color.FromArgb(255, 0, 0);
                    button10.Enabled = false;
                    SaveFileDialog saveFile1 = new SaveFileDialog();
                    saveFile1.DefaultExt = "*.txt";
                    saveFile1.Filter = "Билет|*.txt";
                    if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                        saveFile1.FileName.Length > 0)
                    {
                        using (StreamWriter sw = new StreamWriter(saveFile1.FileName, true))
                        {
                            if (textBox2.Enabled == true)
                            {
                                sw.WriteLine(label4.Text + textBox4.Text);
                                sw.WriteLine(label5.Text + textBox5.Text);
                                sw.WriteLine(label6.Text + textBox6.Text);
                                sw.WriteLine(label9.Text + textBox9.Text);
                                sw.WriteLine(label10.Text + textBox10.Text);
                                sw.WriteLine(label11.Text + textBox11.Text);
                                sw.WriteLine(label14.Text + textBox2.Text);
                                sw.Close();
                            }
                            else
                            {
                                sw.WriteLine(label4.Text + textBox4.Text);
                                sw.WriteLine(label5.Text + textBox5.Text);
                                sw.WriteLine(label6.Text + textBox6.Text);
                                sw.WriteLine(label9.Text + textBox9.Text);
                                sw.WriteLine(label10.Text + textBox10.Text);
                                sw.WriteLine(label11.Text + textBox11.Text);
                                sw.WriteLine(label14.Text + textBox14.Text);
                                sw.Close();
                            }
                        }
                    }
                }
            }
        }

        private void button142_Click(object sender, EventArgs e)
        {
            textBox13.Text = textBox13.Text;
        }
    }
}

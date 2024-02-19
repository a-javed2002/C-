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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello Bro");
            MessageBox.Show("Hello " + textBox1.Text);

            label3.Text = "Hello " + textBox1.Text;
            label3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "")
            {
                double n1 = double.Parse(textBox2.Text);
                double n2 = double.Parse(textBox3.Text);

                label6.Text = $"ADDITION IS: {n1 + n2}";
                label6.Visible = true;
            }
            else
            {
                MessageBox.Show($"Fill Both Fields\n{label4.Text}\n{label5.Text}");
                label6.Text = $"";
                label6.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "")
            {
                double n1 = double.Parse(textBox2.Text);
                double n2 = double.Parse(textBox3.Text);

                label6.Text = $"SUBTRACTION IS: {n1 - n2}";
                label6.Visible = true;
            }
            else
            {
                MessageBox.Show($"Fill Both Fields\n{label4.Text}\n{label5.Text}");
                label6.Text = $"";
                label6.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "")
            {
                double n1 = double.Parse(textBox2.Text);
                double n2 = double.Parse(textBox3.Text);

                label6.Text = $"MULTIPLICATION IS: {n1 * n2}";
                label6.Visible = true;
            }
            else
            {
                MessageBox.Show($"Fill Both Fields\n{label4.Text}\n{label5.Text}");
                label6.Text = $"";
                label6.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "")
            {
                double n1 = double.Parse(textBox2.Text);
                double n2 = double.Parse(textBox3.Text);

                label6.Text = $"DIVISION IS: {n1 / n2}";
                label6.Visible = true;
            }
            else
            {
                MessageBox.Show($"Fill Both Fields\n{label4.Text}\n{label5.Text}");
                label6.Text = $"";
                label6.Visible = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox4.Text!="")
            {
                FRUITS_LIST.Items.Add(textBox4.Text);
                textBox4.Clear();
                textBox4.Focus();

                label9.Text = "Total Fruits: "+FRUITS_LIST.Items.Count.ToString();
                FRUITS_LIST.Sorted = true;
            }
            else
            {
                MessageBox.Show("Enter Something");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //FRUITS_LIST.Items.Remove(FRUITS_LIST.SelectedItem);
            FRUITS_LIST.Items.RemoveAt(FRUITS_LIST.SelectedIndex);
            //FRUITS_LIST.Items.Clear();//removes all
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox5.Text);
            textBox5.Clear();
            textBox5.Focus();
        }
    }
}

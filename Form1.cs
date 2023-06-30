using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEA_SHOP
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Welcome To CAFE COFFEE DAY");
            int total = 0;
            if (comboBox1.Text == "TEA")
            {
                int tea = 12;
                int temp = (int)numericUpDown1.Value * tea;
                listBox1.Items.Add("The Bill For Tea : " + temp);

                total = +temp;
            }
            else if (comboBox1.Text == "MILK")
            {
                int milk = 10;
                int temp = (int)numericUpDown1.Value * milk;
                listBox1.Items.Add("The Bill For MILK : " + temp);

                total += temp;
            }
            else if (comboBox1.Text == "COFFEE")
            {
                int coffee = 15;
                int temp = (int)numericUpDown1.Value * coffee;
                listBox1.Items.Add("The Bill For COFFEE : " + temp);

                total += temp;
            }
            else if (comboBox1.Text == "LEMON TEA")
            {
                int lemon_tea = 20;
                int temp = (int)numericUpDown1.Value * lemon_tea;
                listBox1.Items.Add("The Bill For LEMON TEA : " + temp);

                total += temp;
            }
            else if (comboBox1.Text == "GINGER TEA")
            {
                int ginger_tea = 15;
                int temp = (int)numericUpDown1.Value * ginger_tea;
                listBox1.Items.Add("The Bill For GINGER TEA : " + temp);

                total += temp;
            }
            if (comboBox2.Text == "COKE")
            {
                int coke = 60;
                int temp = (int)numericUpDown1.Value * coke;
                listBox1.Items.Add("The Bill For COKE : " + temp);

                total += temp;
            }
            else if (comboBox2.Text == "SPRITE")
            {
                int sprite = 50;
                int temp = (int)numericUpDown1.Value * sprite;
                listBox1.Items.Add("The Bill For SPRITE : " + temp);

                total += temp;
            }
            else if (comboBox2.Text == "7UP")
            {
                int s_up = 40;
                int temp = (int)numericUpDown1.Value * s_up;
                listBox1.Items.Add("The Bill For 7UP : " + temp);

                total += temp;
            }
            else if (comboBox2.Text == "MIRANDA")
            {
                int miranda = 50;
                int temp = (int)numericUpDown1.Value * miranda;
                listBox1.Items.Add("The Bill For MIRANDA : " + temp);

                total += temp;
            }
            if (comboBox3.Text == "VADA")
            {
                int vada = 6;
                int temp = (int)numericUpDown1.Value * vada;
                listBox1.Items.Add("The Bill For VADA : " + temp);

                total += temp;
            }
            else if (comboBox3.Text == "SAMOSA")
            {
                int samosa = 6;
                int temp = (int)numericUpDown1.Value * samosa;
                listBox1.Items.Add("The Bill For SAMSA : " + temp);

                total += temp;
            }
            else if (comboBox3.Text == "BAJJI")
            {
                int bajji = 6;
                int temp = (int)numericUpDown1.Value * bajji;
                listBox1.Items.Add("The Bill For BAJJI : " +  temp);

                total += temp;
            }
            else if (comboBox3.Text == "BONDA")
            {
                int bonda = 10;
                int temp = (int)numericUpDown1.Value * bonda;
                listBox1.Items.Add("The Bill For BONDA : " + temp);
                total += temp;
            }
            listBox1.Items.Add("Your Total Bill Amount is " + total);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            numericUpDown3.Enabled = false;
            listBox1.Items.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                numericUpDown1.Enabled = true;
            }
            else
            {
                numericUpDown1.Enabled = false;
                comboBox1.SelectedIndex = -1;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex > -1)
            {
                numericUpDown2.Enabled = true;
            }
            else
            {
                numericUpDown2.Enabled = false;
                comboBox2.SelectedIndex = -1;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex > -1)
            {
                numericUpDown3.Enabled = true;
            }
            else
            {
                numericUpDown3.Enabled = true;
                comboBox3.SelectedIndex = -1;
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
          
        }
        
    }
}






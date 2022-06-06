//Form1.cs:

//Code of Form1
//comboBox1 is your BirthYear
//comboBox2 is your BirthMonth
//comboBox3 is your BirthDay
//comboBox4 is your Favorite Color
//Button1 is to get Lucky Number

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity15B
{
    public partial class Form1 : Form
    {
        int maxDay;
        static int luckyNumber;
        public Form1()
        {
            InitializeComponent();
        }
        public int getLuckyNumber()
        {
            return luckyNumber;
        }
        public void birthDay()
        {
            maxDay = 0;
            if (comboBox2.SelectedIndex == 0 || comboBox2.SelectedIndex == 2 || comboBox2.SelectedIndex == 4 || comboBox2.SelectedIndex == 6 || comboBox2.SelectedIndex == 7 || comboBox2.SelectedIndex == 9 || comboBox2.SelectedIndex == 11)
            {
                maxDay = 31;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                int year = Int32.Parse(comboBox1.Text);
                // If a year is multiple of 400,  
                // then it is a leap year 
                if (year % 400 == 0)
                    maxDay = 29;
                // Else If a year is muliplt of 100, 
                // then it is not a leap year 
                if (year % 100 == 0)
                    maxDay = 28;
                // Else If a year is muliplt of 4, 
                // then it is a leap year 
                if (year % 4 == 0)
                    maxDay = 29;
                else
                    maxDay = 28;
            }
            else
                maxDay = 30;

            if (comboBox2.SelectedIndex != -1)
            {
                comboBox3.Items.Clear();
                for (int i = 0; i < maxDay; i++)
                {
                    comboBox3.Items.Add(i + 1);
                }
                comboBox3.Text = maxDay.ToString();
            }


        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            birthDay();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "2004";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            birthDay();

        }

        void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1 && comboBox3.SelectedIndex != -1 && comboBox4.SelectedIndex != -1)
            {
                //calculation lucky number
                luckyNumber = (comboBox1.SelectedIndex + comboBox2.SelectedIndex + comboBox3.SelectedIndex + comboBox4.SelectedIndex);
                Form2 frm2 = new Form2(luckyNumber);
                frm2.Show();
            }
            else
            {
                MessageBox.Show("Please Fill The Above Form");
            }
        }

    }
}

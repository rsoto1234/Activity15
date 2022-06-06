//Label 2 is to show the LuckyNumber

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
    public partial class Form2 : Form
    {
        int lk_num;  // to hold lucky number sent from Form1
        public Form2(int n)
        {
            lk_num = n;  // assign Form1 created lucky number to lk_num
            InitializeComponent();
        }

       
        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            label3.Text = frm.getLuckyNumber().ToString(); //display lucky number
        }
    }
}
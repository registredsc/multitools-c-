using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Registre_Tools
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                PassGen(8);
            }
            else if (radioButton2.Checked)
            {
                PassGen(15);
            }
            else if (radioButton3.Checked)
            {
                PassGen(20);
            }
            else if (radioButton4.Checked)
            {
                PassGen(35);
            }
            else if (radioButton5.Checked)
            {
                PassGen(50);
            }
            else if (radioButton6.Checked)
            {
                PassGen(60);
            }
            else if (radioButton7.Checked)
            {
                PassGen(70);
            }
            else if (radioButton8.Checked)
            {
                PassGen(80);
            }
            else if (radioButton9.Checked)
            {
                PassGen(90);
            }
            else if (radioButton10.Checked)
            {
                PassGen(100);
            }

        }

        public void PassGen(int len)
        {
            const string Char = "abcdefghijklnmopqrstuvxyzABCDEFGHIJKLNMOPQRSTUVXYZ0123456789!*$";
            StringBuilder result = new StringBuilder();
            Random rand = new Random();
            while (0 < len--)
            {
                result.Append(Char[rand.Next(Char.Length)]);
            }
            textBox1.Text = result.ToString();
        }


    }
}

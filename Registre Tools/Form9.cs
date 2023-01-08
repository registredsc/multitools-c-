using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Registre_Tools
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string shop = "https://discord.gg/dTrD6WKDS2";
            MessageBox.Show(shop);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string spring = "https://discord.gg/URxcamJ9pM";
            MessageBox.Show(spring);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = "Registre";
            MessageBox.Show(username);
        }
    }
}

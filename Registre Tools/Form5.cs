using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Registre_Tools
{
    public partial class Form5 : Form
    {

        private WebClient wp;
        public Form5()
        {
            wp = new WebClient();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient wp = new WebClient();
            string ping = wp.DownloadString("https://webresolver.nl/api.php?key=1NXME-6CX9D-IKZ8U-10VLX&action=ping&string=" + textBox1.Text);
            richTextBox1.Text = ping;
        }
    }
}

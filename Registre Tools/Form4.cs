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
    public partial class Form4 : Form

    {

        private WebClient wc;
        public Form4()
        {
            wc = new WebClient();
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            string geoip = wc.DownloadString("https://webresolver.nl/api.php?key=1NXME-6CX9D-IKZ8U-10VLX&action=geoip&string=" + textBox1.Text);
            MessageBox.Show(geoip);

        }
    }
}

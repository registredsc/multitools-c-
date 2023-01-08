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
    public partial class Form3 : Form
    {
        private WebClient wb;
        public Form3()
        {
            wb = new WebClient();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = wb.DownloadString(string.Format("http://ipv4bot.whatismyipaddress.com/"));
        }

    }
}

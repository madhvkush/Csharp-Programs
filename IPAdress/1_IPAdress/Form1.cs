using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace _1_IPAdress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIP_Click(object sender, EventArgs e)
        {
            try
            {
                IPHostEntry hostname = Dns.GetHostByName(txtHotsName.Text);
                IPAddress[] ip = hostname.AddressList;
                lblIPAddress.Text = ip[0].ToString();
                txtIPAdress.Text = ip[0].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

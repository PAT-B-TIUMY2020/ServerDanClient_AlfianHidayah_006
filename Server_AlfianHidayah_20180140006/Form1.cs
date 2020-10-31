using ServiceMtk_P1_006;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_AlfianHidayah_20180140006
{
    public partial class Form1 : Form
    {
        ServiceHost hostObj = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnON_Click(object sender, EventArgs e)
        {
            hostObj = new ServiceHost(typeof(Matematika));
            hostObj.Open();
        }

        private void BtnOFF_Click(object sender, EventArgs e)
        {
            hostObj = new ServiceHost(typeof(Matematika));
            hostObj.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Paul_Killian_Assignment_1
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Virus Successfully Installed");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
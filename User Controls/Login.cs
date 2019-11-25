using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twitter.User_Controls
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();

        }

        private void RegisterNow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register1.Show();
        }
    }
}

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
    public partial class Home : UserControl
    {
        

        public Home()
        {
            InitializeComponent();
            
            Login.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Login.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Login2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Login2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Register.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Register.FlatAppearance.MouseOverBackColor = Color.Transparent;

        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void Login2_Click(object sender, EventArgs e)
        {
            
        }

        private void Login_Click(object sender, EventArgs e)
        {
            
        }

        private void Register_Click(object sender, EventArgs e)
        {
            register1.Show();
        }
    }
}

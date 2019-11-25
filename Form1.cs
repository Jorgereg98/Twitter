using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twitter
{
    public partial class TwitterForm : Form
    {
        public TwitterForm()
        {
            InitializeComponent();
        }

        private void TwitterForm_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void home1_Load(object sender, EventArgs e)
        {

        }
    }
}

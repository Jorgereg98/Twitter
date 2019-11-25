using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twitter.Models;
using Twitter.Builder;

namespace Twitter.User_Controls
{
    public partial class Register : UserControl
    {
        Password password = new Password();

        public Register()
        {
            InitializeComponent();
            Next.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Next.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") label5.Visible = true;
            else label5.Visible = false;
            if (textBox2.Text == "") label6.Visible = true;
            else label6.Visible = false;
            if (textBox3.Text == "") label7.Visible = true;
            else label7.Visible = false;
            if (textBox4.Text == "") label8.Visible = true;
            else label8.Visible = false;


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            label8.Visible = true;
            if (textBox4.Text.Any(char.IsDigit) && textBox4.Text.Any(char.IsLower) && textBox4.Text.Any(char.IsUpper) && textBox4.Text.Length >= 12)
            {
                password = PasswordFluentBuilder.Create(DifficultyEnum.Very_Strong)
                   .Finish();
                label8.ForeColor = Color.ForestGreen;
                label8.Text = password.ToString();
            }
            else if (textBox4.Text.Any(char.IsDigit) && textBox4.Text.Any(char.IsLower) && textBox4.Text.Any(char.IsUpper) && textBox4.Text.Length < 12 && textBox4.Text.Length >= 7)
            {
                password = PasswordFluentBuilder.Create(DifficultyEnum.Strong)
                   .Finish();
                label8.ForeColor = Color.YellowGreen;
                label8.Text = password.ToString();
            }
            else if (textBox4.Text.Any(char.IsDigit) && textBox4.Text.Any(char.IsLower) && textBox4.Text.Any(char.IsUpper) && textBox4.Text.Length < 7)
            {
                password = PasswordFluentBuilder.Create(DifficultyEnum.Regular)
                   .Finish();
                label8.ForeColor = Color.Gold;
                label8.Text = password.ToString();
            }
            else
            {
                password = PasswordFluentBuilder.Create(DifficultyEnum.Weak)
                   .Finish();
                label8.ForeColor = Color.Crimson;
                label8.Text = password.ToString();
            }

        }
    }
}

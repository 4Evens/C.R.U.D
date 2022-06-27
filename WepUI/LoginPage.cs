using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstrack;
using Business.Concrete;
using Business.DependencyResolvers.Ninject;

namespace WepUI
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        IUserService _userService = InstanceFactory.GetInstance<IUserService>();
        UserManager _userManager = InstanceFactory.GetInstance<UserManager>();
        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                jtxPassword.IsPassword = true;
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                jtxPassword.IsPassword = false;
            }
        }

        private void jfbLoginButton_Click(object sender, EventArgs e)
        {
            //if (jtxLogin.Text == string.Empty)
            //{
            //    MessageBox.Show("Enter valid user name please", "Error");
            //    return;
            //}
            //else if (jtxPassword.Text == string.Empty)
            //{
            //    MessageBox.Show("Enter valid password please", "Error");
            //    return;
            //}

            if (_userService.IsUser(jtxLogin.Text, jtxPassword.Text))
            {
                Form1 form = new Form1();
                form.ShowDialog();
                this.Hide();
            }
            //else if (expr)
            //{

            //}
            else
            {
                MessageBox.Show("Tekrar deneyiniz..");
            }


        }
    }
}

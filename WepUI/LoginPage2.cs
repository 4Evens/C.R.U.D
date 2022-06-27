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
    public partial class LoginPage2 : Form
    {
        public LoginPage2()
        {
            InitializeComponent();
        }
        IUserService _userService = InstanceFactory.GetInstance<IUserService>();
        UserManager _userManager = InstanceFactory.GetInstance<UserManager>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Enes" && txtpassword.Text == "12345")
            {
                new Form1().Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("The User name or password you entered is incorrect, try again");
                txtUserName.Clear();
                txtpassword.Clear();
                txtUserName.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtpassword.Clear();
            txtUserName.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

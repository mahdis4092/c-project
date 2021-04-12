using Hospital_management_system.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_management_system.Ui_Layer
{
    public partial class Login : Form
    {
        //Home home;
        public Login( )
        {
           // this.home = home;
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""||textBox2.Text=="")
            {
                MessageBox.Show("Username or password can not be empty");
            }
            else
            {
                UserService userService = new UserService();
                bool result = userService.LoginValidation(textBox1.Text,textBox2.Text);
                if(result)
                {
                  Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(" Invalid Username or password ");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User us = new User();
            us.Show();
            this.Hide();
        }
    }
}

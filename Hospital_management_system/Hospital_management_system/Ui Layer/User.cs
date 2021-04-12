using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_management_system.Ui_Layer
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void User_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["FA"].ConnectionString);
            connection.Open();
            string sql = "INSERT INTO Usersd(Name,Username,Password,Email,UserType) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            connection.Close();
            if (textBox1.Text == " " || textBox2.Text == " " || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Element can not be empty");
            }
            else
            {

                if (result > 0)
                {
                    MessageBox.Show("User added successfully.");
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = string.Empty;
                    Login ls = new Login();
                    ls.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error in user adding.");
                }
            }
        }
    }
}

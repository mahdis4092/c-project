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
    public partial class Bill : Form
    {
       // int id = 0;
        Home home;
        public Bill(Home home)
        {
            this.home = home;
            InitializeComponent();
            button1.Click += this.RefreshGridview;
            button1.Click += this.ClearField;
            button4.Click += this.RefreshGridview;
            button4.Click += this.ClearField;
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            ReceptionistService receptionistService = new ReceptionistService();
            loaddataGridView1.DataSource = receptionistService.GetReceptionistList();
        }
        void RefreshGridview(object sender, EventArgs e)
        {
            ReceptionistService receptionistService = new ReceptionistService();
            loaddataGridView1.DataSource = receptionistService.GetReceptionistList();
        }
        void ClearField(object sender, EventArgs e)
        {
            retextBox1.Text = retextBox2.Text = retextBox3.Text = retextBox4.Text = textBox1.Text = string.Empty;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ReceptionistService receptionistService = new ReceptionistService();
            int result = receptionistService.AddNewReceptionist(retextBox1.Text, retextBox2.Text, retextBox3.Text, retextBox4.Text);
            if (retextBox1.Text == "" || retextBox2.Text == "" || retextBox3.Text == "" || retextBox4.Text == "")
            {
                MessageBox.Show("ELEMENT CAN NOT BE EMPTY");
            }
            else
            {
                if (result > 0)
                {
                    MessageBox.Show("Bill added successfully");
                }
                else
                {
                    MessageBox.Show("Error in adding");
                }
            }
        }

        private void Bill_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Hide();
        }

        private void loaddataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (loaddataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)

             loaddataGridView1.CurrentRow.Selected = true;
           // id =(int) loaddataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            retextBox1.Text = loaddataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            retextBox2.Text = loaddataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            retextBox3.Text = loaddataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            retextBox4.Text = loaddataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReceptionistService receptionistService = new ReceptionistService();
            int result = receptionistService.UpdateReceptionist(retextBox1.Text, retextBox2.Text, retextBox3.Text, retextBox4.Text);
            if (result > 0)
            {
                MessageBox.Show("Bill added successfully");
            }
            else
            {
                MessageBox.Show("Error in adding");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReceptionistService receptionistService = new ReceptionistService();
            int result = receptionistService.DeleteReceptionist(textBox1.Text);
            if (result > 0)
            {
                MessageBox.Show("Bill Deleted successfully");
            }
            else
            {
                MessageBox.Show("Error in Deleting");
            }

        }
    }
}

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
    public partial class PatientsEm : Form
    {
        Home home;
        public PatientsEm(Home home)
        {
            this.home = home;
            InitializeComponent();
            button1.Click += this.RefreshGridview;
            button1.Click += this.ClearFields;
            button3.Click += this.RefreshGridview;
            button3.Click += this.ClearFields;
        }

        private void PatientsEm_Load(object sender, EventArgs e)
        {
            PatientEmservice patientEmservice = new PatientEmservice();
            dataGridView1.DataSource = patientEmservice.GetListOfPatients();
            patientEmservice = new PatientEmservice();
            comboBox1.DataSource = patientEmservice.GetDoctorNameList();
        }

        private void PatientsEm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
       void RefreshGridview(object sender, EventArgs e)
        {
            PatientEmservice patientEmservice = new PatientEmservice();
            dataGridView1.DataSource = patientEmservice.GetListOfPatients();
            patientEmservice = new PatientEmservice();
            comboBox1.DataSource = patientEmservice.GetDoctorNameList();
        }
        void ClearFields(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            //dateTimePicker1 = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox9.Text = string.Empty;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PatientEmservice patientEmservice = new PatientEmservice();
            int result = patientEmservice.AddNewPatient(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,dateTimePicker1.Text,textBox5.Text,textBox6.Text,textBox7.Text);
            if (textBox1.Text ==" " || textBox2.Text ==" " || textBox3.Text == " " || textBox4.Text == " " || dateTimePicker1.Text == " " || textBox5.Text == " " || textBox6.Text == " " || textBox7.Text == " ")
            {
                MessageBox.Show("Element can not be empty");
            }
            else
            {

                if (result > 0)
                {
                    MessageBox.Show("Patient added successfully");
                }
                else
                {
                    MessageBox.Show("Error in adding");
                }
            }
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            
                dataGridView1.CurrentRow.Selected = true;
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                //textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            }

        private void button3_Click(object sender, EventArgs e)
        {
            PatientEmservice patientEmservice = new PatientEmservice();
            int result = patientEmservice.DeletePatient(textBox9.Text);
                if (result>0)
            {
                MessageBox.Show("Deleted successfully");
            }
                else
            {
                MessageBox.Show("Error in delete");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PatientEmservice patientEmservice = new PatientEmservice();
            dataGridView2.DataSource=patientEmservice.GetPatientListBySearch(comboBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Hide();

        }
    }
    
}

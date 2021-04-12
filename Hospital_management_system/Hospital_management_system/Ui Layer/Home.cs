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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientsEm patientsEm = new PatientsEm(this);
            patientsEm.Show();
            this.Hide();
        }

        private void receptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill(this);
            bill.Show();
            this.Hide();
        }
    }
}

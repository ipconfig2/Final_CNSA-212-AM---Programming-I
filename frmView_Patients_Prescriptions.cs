using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_1
{
    public partial class frmView_Patients_Prescriptions : Form
    {


        public frmView_Patients_Prescriptions()
        {
            InitializeComponent();
            Class dataService = new Class();
            DataSet patientData = dataService.SearchPatient(txtPatientSearch.Text);
        }

        private void View_Patients_Prescriptions_Load(object sender, EventArgs e)
        {
            cmuDelete.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string patientID = txtPatientSearch.Text.Trim();
            if (string.IsNullOrEmpty(patientID))
            {
                MessageBox.Show("Please enter a Patient ID.");
                return;
            }
            else
            {
                cmuDelete.Enabled = true;
            }
            Class loader = new Class();

            loader.LoadPatientInfo(patientID, dataGridViewPrescriptions, lblPatientName, lblDOB, lblAddress, lblPhone);

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void cmuSearch_Click(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens the add patient form
            frmAdd_Prescription aform = new frmAdd_Prescription();
            aform.ShowDialog();
        }

        private void cmuDelete_Click(object sender, EventArgs e)
        {

        }

        private void cmuDelete_Click_1(object sender, EventArgs e)
        {
            string PrescID = "";
            Class DeleteP = new Class();

            if (dataGridViewPrescriptions.SelectedRows.Count > 0)
            {
                try
                {
                    //selects the patient id from the selected row
                    PrescID = dataGridViewPrescriptions.SelectedRows[0].Cells[0].Value.ToString();
                    var confirmResult = MessageBox.Show("Are you sure you want to remove this Prescription?", "Confirm Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        // delete patient
                        DeleteP.DeletePresc(PrescID);
                        MessageBox.Show("Prescription Deleted Susscessfully!");

                        btnSearch_Click(sender, e);

                    }
                    else
                    {
                        // do nothing
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}

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
    public partial class frmUpdate_Patient_Info : Form
    {

        public frmUpdate_Patient_Info()
        {
            InitializeComponent();
        }

        private void Update_Patient_Info_Load(object sender, EventArgs e)
        {
            DisableFormFields();
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.MouseOverBackColor = Color.PaleVioletRed;

            //turn button green on hover
            btnUpdatePatient.FlatStyle = FlatStyle.Flat;
            btnUpdatePatient.FlatAppearance.MouseOverBackColor = Color.LightGreen;

            btnUpdatePatient.Enabled = false;
        }

        private void DisableFormFields()
        {
            txtFName.Enabled = false;
            txtLName.Enabled = false;
            txtMI.Enabled = false;
            txtGender.Enabled = false;
            txtPhone.Enabled = false;
            txtStreet.Enabled = false;
            txtCity.Enabled = false;
            txtState.Enabled = false;
            txtZip.Enabled = false;
            txtCountry.Enabled = false;
            txtInsurance.Enabled = false;
            txtDOB.Enabled = false;
            btnUpdatePatient.Enabled = false;
        }

        private void EnableFormFields()
        {
            txtFName.Enabled = true;
            txtLName.Enabled = true;
            txtMI.Enabled = true;
            txtGender.Enabled = true;
            txtPhone.Enabled = true;
            txtStreet.Enabled = true;
            txtCity.Enabled = true;
            txtState.Enabled = true;
            txtZip.Enabled = true;
            txtCountry.Enabled = true;
            txtInsurance.Enabled = true;
            txtDOB.Enabled = true;
            btnUpdatePatient.Enabled = true;
        }


        private void txtPatientID_TextChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPatientID.Text))
            {
                EnableFormFields();
            }
            else
            {
                DisableFormFields();
                btnUpdatePatient.Enabled = false; 
            }
        }

        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPhone.Text) && (txtPhone.Text.Length != 10 || !txtPhone.Text.All(char.IsDigit)))
            {
                MessageBox.Show("Phone number must be exactly 10 digits, with no spaces or special characters.");
                return;
            }

            string patientId = txtPatientID.Text;


            if (string.IsNullOrEmpty(txtPatientID.Text))
            {
                MessageBox.Show("Patient ID is required.");
                return;
            }

                try
                {

                    string Fname = txtFName.Text.Trim();
                    string M_I = txtMI.Text.Trim();
                    string LName = txtLName.Text.Trim();
                    string DOB = txtDOB.Text.Trim();
                    string Gender = txtGender.Text.Trim();
                    string Phone = txtPhone.Text.ToString();
                    string state = txtState.Text.ToString();
                    string STREET = txtStreet.Text.Trim();
                    string CITY = txtCity.Text.Trim();
                    string ZIP = txtZip.Text.ToString();
                    string COUNTRY = txtCountry.Text.ToString();
                    string Insurance = txtInsurance.Text.ToString();
                    var updatePatientInstance = new Class();
                    updatePatientInstance.UpdatePatient(patientId, Fname, M_I, LName, DOB, Gender, Phone, STREET, CITY, state, ZIP, COUNTRY, Insurance);
                    MessageBox.Show("Updated Patient");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
           }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}


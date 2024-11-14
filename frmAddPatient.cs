using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

namespace Final_1
{
    public partial class frmAdd_Patient : Form
    {
        public frmAdd_Patient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void Add_Patient_Load(object sender, EventArgs e)
        {
            //turns close button red on hover
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.MouseOverBackColor = Color.PaleVioletRed;
            //turn button green on hover
            btnAddPatient.FlatStyle = FlatStyle.Flat;
            btnAddPatient.FlatAppearance.MouseOverBackColor = Color.LightGreen;

            //disable buttons
            btnAddPatient.Enabled = false;
            
        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPhone.Text) && (txtPhone.Text.Length != 10 || !txtPhone.Text.All(char.IsDigit)))
            {
                MessageBox.Show("Phone number must be exactly 10 digits, with no spaces or special characters.");
                return;
            }
            if (!string.IsNullOrEmpty(txtZip.Text) && (txtZip.Text.Length != 5 || !txtZip.Text.All(char.IsDigit)))
            {
                MessageBox.Show("Zip Code must be exactly 5 digits, with no spaces or special characters.");
                return;
            }
            if (txtFName.Text.Trim().Length <= 0 || txtLName.Text.Trim().Length <= 0 || txtGender.Text.Trim().Length <= 0 || txtInsurance.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Enter a first name, last name, Gender, and Insurance", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                var AddP = new Class();
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
                    AddP.AddPatient(Fname, M_I, LName, DOB, Gender, Phone, STREET, CITY, state, ZIP, COUNTRY, Insurance);
                    MessageBox.Show("Successfuly added patient");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {
            if((txtFName.Text.Length > 0 && txtLName.Text.Length > 0 && txtGender.Text.Length > 0 && txtGender.Text.Length > 0 && txtInsurance.Text.Length > 0))
            {
                btnAddPatient.Enabled = true;
            }
            else
            {
                btnAddPatient.Enabled = false;
            }
        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {
            if ((txtFName.Text.Length > 0 && txtLName.Text.Length > 0 && txtGender.Text.Length > 0 && txtGender.Text.Length > 0 && txtInsurance.Text.Length > 0))
            {
                btnAddPatient.Enabled = true;
            }
            else
            {
                btnAddPatient.Enabled = false;
            }
        }

        private void txtGender_TextChanged(object sender, EventArgs e)
        {
            if ((txtFName.Text.Length > 0 && txtLName.Text.Length > 0 && txtGender.Text.Length > 0 && txtGender.Text.Length > 0 && txtInsurance.Text.Length > 0))
            {
                btnAddPatient.Enabled = true;
            }
            else
            {
                btnAddPatient.Enabled = false;
            }
        }

        private void txtDOB_TextChanged(object sender, EventArgs e)
        {
            if ((txtFName.Text.Length > 0 && txtLName.Text.Length > 0 && txtGender.Text.Length > 0 && txtGender.Text.Length > 0 && txtInsurance.Text.Length > 0))
            {
                btnAddPatient.Enabled = true;
            }
            else
            {
                btnAddPatient.Enabled = false;
            }
        }

        private void txtInsurance_TextChanged(object sender, EventArgs e)
        {
            if ((txtFName.Text.Length > 0 && txtLName.Text.Length > 0 && txtGender.Text.Length > 0 && txtGender.Text.Length > 0 && txtInsurance.Text.Length > 0))
            {
                btnAddPatient.Enabled = true;
            }
            else
            {
                btnAddPatient.Enabled = false;
            }
        }
    }
      }
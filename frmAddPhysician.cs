using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Final_1
{
    public partial class frmAdd_Physician : Form
    {
        public frmAdd_Physician()
        {
            InitializeComponent();
        }

        private void Add_Physician_Load(object sender, EventArgs e)
        {
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.MouseOverBackColor = Color.PaleVioletRed;

            //turn button green on hover
            btnAddPhysician.FlatStyle = FlatStyle.Flat;
            btnAddPhysician.FlatAppearance.MouseOverBackColor = Color.LightGreen;

            btnAddPhysician.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
            if (!string.IsNullOrEmpty(txtPhoneNumber.Text) && (txtPhoneNumber.Text.Length != 10 || !txtPhoneNumber.Text.All(char.IsDigit)))
            {
                MessageBox.Show("Phone number must be exactly 10 digits, with no spaces or special characters.");
                return;
            }
            if (txtFName.Text.Trim().Length <= 0 || txtLName.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Enter a first name and last name.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    Class AddPhy = new Class();

                    string Fname = txtFName.Text.Trim();
                    string LName = txtLName.Text.Trim();
                    string Email = txtEmail.Text.Trim();
                    string Phone = txtPhoneNumber.Text.Trim();


                    AddPhy.AddPhysician(Fname, LName, Email, Phone);
                    MessageBox.Show("Successfuly added Physician");
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
            if ((txtFName.Text.Length > 0 && txtLName.Text.Length > 0))
            {
                btnAddPhysician.Enabled = true;
            }
            else
            {
                btnAddPhysician.Enabled = false;
            }
        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {
            if ((txtFName.Text.Length > 0 && txtLName.Text.Length > 0))
            {
                btnAddPhysician.Enabled = true;
            }
            else
            {
                btnAddPhysician.Enabled = false;
            }
        }
    }
}

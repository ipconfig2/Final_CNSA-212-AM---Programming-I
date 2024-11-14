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

namespace FinalPhysicianApp
{
    public partial class frmModPatient : Form
    {
        public frmModPatient()
        {
            InitializeComponent();

            // Attach KeyPress events for validation
            txtPatFName.KeyPress += OnlyAllowLetters;  
            txtLName.KeyPress += OnlyAllowLetters;
            txtMidInt.KeyPress += OnlyAllowLetters;  
            txtGender.KeyPress += OnlyAllowLetters;
            txtPhone.KeyPress += OnlyAllowNumbers;      //i did this because its cooler

        }


        private void OnlyAllowLetters(object sender, KeyPressEventArgs e)
        {
            // Allow only letters, backspace, and space
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Prevent the character from being entered
            }
        }
        private void OnlyAllowNumbers(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers and backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Prevent the character from being entered
            }
        }

        private bool ValidateFields()
        {
            // Clear any existing errors
            errorProvider1.Clear();
            bool isValid = true;

            // Check if "Add" checkbox is checked
            if (rdbtnAdd.Checked)
            {

                if (string.IsNullOrWhiteSpace(txtPatFName.Text))
                {
                    errorProvider1.SetError(txtPatFName, "First Name is required.");
                    isValid = false;
                }
                if (string.IsNullOrWhiteSpace(txtLName.Text))
                {
                    errorProvider1.SetError(txtLName, "Last Name is required.");
                    isValid = false;
                }
                if (string.IsNullOrWhiteSpace(txtMidInt.Text))
                {
                    errorProvider1.SetError(txtMidInt, "Middle Initial is required ( only one value).");
                    isValid = false;
                }
                if (string.IsNullOrWhiteSpace(txtGender.Text))
                {
                    errorProvider1.SetError(txtGender, "Only Enter M or F");
                    isValid = false;
                }


            }
            // Check if "Update" checkbox is checked
            else if (rdbtnUpdate.Checked)
            {
                // Either PhysicianID or both First and Last Name must be filled for updating
                if (string.IsNullOrWhiteSpace(txtPatID.Text) &&
                    (string.IsNullOrWhiteSpace(txtPatFName.Text) || string.IsNullOrWhiteSpace(txtLName.Text)))
                {
                    errorProvider1.SetError(txtPatID, "Physician ID or both First and Last Name are required for updating.");
                    isValid = false;
                }
            }
            // Check if "Delete" checkbox is checked
            else if (rdbtnDelete.Checked)
            {
                // Either PhysicianID or both First and Last Name must be filled for deleting
                if (string.IsNullOrWhiteSpace(txtPatID.Text) &&
                    (string.IsNullOrWhiteSpace(txtPatFName.Text) || string.IsNullOrWhiteSpace(txtLName.Text)))
                {
                    errorProvider1.SetError(txtPatID, "Physician ID or both First and Last Name are required for deleting.");
                    isValid = false;
                }
            }

            return isValid;
        }

        private string GetSelectedAction()
        {
            if (rdbtnAdd.Checked)
                return "Insert";
            else if (rdbtnUpdate.Checked)
                return "Update";
            else if (rdbtnDelete.Checked)
                return "Delete";
            else
                throw new InvalidOperationException("Please Choose a Modification Action (Add, Update, or Delete).");
        }
        private void ManagePatient()
        {
            // Perform validation and return if any errors
            if (!ValidateFields())
            {
                MessageBox.Show("Please correct or enter in the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))

                {
                    SqlCommand command = new SqlCommand("ManagePatient", connection); // Database procedure connection
                    command.CommandType = CommandType.StoredProcedure;

                    string action = GetSelectedAction(); // Get the action based on selected checkbox (Add, Update, or Delete)
                    command.Parameters.AddWithValue("@Action", action);

                    // Add parameters for Insert or Update
                    if (action == "Insert" || action == "Update")
                    {
                        command.Parameters.AddWithValue("@FirstName", string.IsNullOrWhiteSpace(txtPatFName.Text) ? (object)DBNull.Value : txtPatFName.Text);
                        command.Parameters.AddWithValue("@MIDINT", string.IsNullOrWhiteSpace(txtMidInt.Text) ? (object)DBNull.Value : txtMidInt.Text);
                        command.Parameters.AddWithValue("@LastName", string.IsNullOrWhiteSpace(txtLName.Text) ? (object)DBNull.Value : txtLName.Text);
                        command.Parameters.AddWithValue("@Gender", string.IsNullOrWhiteSpace(txtGender.Text) ? (object)DBNull.Value : txtGender.Text);
                        command.Parameters.AddWithValue("@PhoneNumber", string.IsNullOrWhiteSpace(txtPhone.Text) ? (object)DBNull.Value : txtPhone.Text);
                        command.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(txtEmail.Text) ? (object)DBNull.Value : txtEmail.Text);
                        command.Parameters.AddWithValue("@Address", string.IsNullOrWhiteSpace(txtAddress.Text) ? (object)DBNull.Value : txtAddress.Text);
                        command.Parameters.AddWithValue("@City", string.IsNullOrWhiteSpace(txtCity.Text) ? (object)DBNull.Value : txtCity.Text);
                        command.Parameters.AddWithValue("@State", string.IsNullOrWhiteSpace(txtState.Text) ? (object)DBNull.Value : txtState.Text);
                        command.Parameters.AddWithValue("@Zip", string.IsNullOrWhiteSpace(txtZip.Text) ? (object)DBNull.Value : txtZip.Text);
                        command.Parameters.AddWithValue("@DOB", string.IsNullOrWhiteSpace(txtDOB.Text) ? (object)DBNull.Value :txtDOB.Text);
                    }

                    // Add PhysicianID for Update or Delete only
                    if (action == "Update" || action == "Delete")
                    {
                        command.Parameters.AddWithValue("@PatientID", txtPatID.Text);
                    }

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show($"Patient {action.ToLower()} operation completed successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void AddTextFields()
        {
            txtPatID.Enabled = false;
            txtPatFName.Enabled = true;
            txtMidInt.Enabled = true;
            txtLName.Enabled = true;
            txtPhone.Enabled = true;
            txtEmail.Enabled = true;
            txtGender.Enabled = true;
            txtDOB.Enabled = true;
            txtAddress.Enabled = true;
            txtCity.Enabled = true;
            txtState.Enabled = true;
            txtZip.Enabled = true;
        }
        private void DeleteTextFields()
        {
            txtPatID.Enabled = true;
            txtPatFName.Enabled = false;
            txtMidInt.Enabled = false;
            txtLName.Enabled = false;
            txtPhone.Enabled = false;
            txtEmail.Enabled = false;
            txtGender.Enabled = false;
            txtDOB.Enabled = false;
            txtAddress.Enabled = false;
            txtCity.Enabled = false;
            txtState.Enabled = false;
            txtZip.Enabled = false;
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void frmModPatient_Load(object sender, EventArgs e)
        {
            txtPatID.Enabled = false;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            ManagePatient();
        }
 

        private void rdbtnAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnAdd.Checked)
            {
                AddTextFields();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGender_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbtnUpdate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbtnDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnDelete.Checked)
            {
                DeleteTextFields();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPatID.Text = String.Empty;
            txtPatFName.Text = String.Empty;
            txtMidInt.Text = String.Empty;
            txtLName.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtGender.Text = String.Empty;
            txtDOB.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtCity.Text = String.Empty;
            txtState.Text = String.Empty;
            txtZip.Text = String.Empty;
        }

        private void txtPatID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

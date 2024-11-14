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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalPhysicianApp
{
    public partial class frmPrescription : Form
    {
                private frmHome frmHomePhysician;




        public frmPrescription()
        {
            InitializeComponent();

            // Attach KeyPress events for validation
            txtRefills.KeyPress += OnlyAllowNumbers;
            txtIntake.KeyPress += OnlyAllowLetters;
            txtMedID.KeyPress += OnlyAllowLetters;
            txtMedID.KeyPress += OnlyAllowNumbers;      //i did this because its cooler

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

        private void frmPrescription_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
            txtMedID.Text = string.Empty;
            cbMed.Text = string.Empty;
        }

        private void AddPrescription()
        {
            // Clear previous error messages
            errorProvider1.Clear();

            // Validate and parse IDs
            if (string.IsNullOrWhiteSpace(txtPhyID.Text))
            {
                errorProvider1.SetError(txtPhyID, "Please enter a valid Doctor ID.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPatID.Text))
            {
                errorProvider1.SetError(txtPatID, "Please enter a valid Patient ID.");
                return;
            }

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("AddPrescription", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Pass parameters to the stored procedure by using the Text property
                    command.Parameters.AddWithValue("@DoctorID", txtPhyID.Text); // Use .Text to get the string value
                    command.Parameters.AddWithValue("@PatientID", txtPatID.Text);
                    command.Parameters.AddWithValue("@Med_NO", txtMedID.Text);
                    command.Parameters.AddWithValue("@MedName", cbMed.Text);
                    command.Parameters.AddWithValue("@Dosage", txtDosage.Text);
                    command.Parameters.AddWithValue("@IntMethod", txtIntake.Text);
                    command.Parameters.AddWithValue("@RefillsLeft", txtRefills.Text);


                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Prescription added successfully.");
                }
            }
            catch (SqlException ex)
            {
                // Display specific error messages based on the error from SQL Server
                if (ex.Message.Contains("Doctor ID does not exist"))
                {
                    errorProvider1.SetError(txtPhyID, "Doctor ID does not exist.");
                    MessageBox.Show("Doctor ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Contains("Patient ID does not exist"))
                {
                    errorProvider1.SetError(txtPatID, "Patient ID does not exist.");
                    MessageBox.Show("Patient ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Contains("Medication ID does not exist"))
                {
                    errorProvider1.SetError(txtMedID, "Medication ID does not exist.");
                    MessageBox.Show("Medication ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // General error message for other issues
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        private void DeletePrescription()
        {
            string prescriptionID = txtPrescID.Text;

            if (string.IsNullOrWhiteSpace(prescriptionID))
            {
                MessageBox.Show("Please enter a valid Prescription ID to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Show a confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to delete this prescription?",
                                                  "Delete Confirmation",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

            // If user clicks OK, proceed with deletion
            if (result == DialogResult.OK)
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

                    using (SqlConnection connection = new SqlConnection(connectionString))

                    {
                        SqlCommand command = new SqlCommand("DeletePrescription", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        // Pass the PrescriptionID to the stored procedure
                        command.Parameters.AddWithValue("@PrescriptionID", prescriptionID);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Prescription deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Prescription ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // If user clicks Cancel, stop the action
            else
            {
                MessageBox.Show("Deletion cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            DeletePrescription();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            AddPrescription();
        }
        // Dictionary to store medication names and corresponding IDs
        private Dictionary<string, string> medicationsDict = new Dictionary<string, string>();

        private void LoadComboBoxData()
        {


            string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString)) ;
            string query = "SELECT Med_NO, Med_Name FROM Medication";


            // Clear the ComboBox before loading new data
            cbMed.Items.Clear();
            medicationsDict.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Get the medication name and ID from the database
                        string medicationID = reader["Med_NO"].ToString();
                        string medicationName = reader["Med_Name"].ToString();

                        // Add medication name to ComboBox and store name-ID pair in the dictionary
                        cbMed.Items.Add(medicationName);
                        medicationsDict[medicationName] = medicationID;
                    }

                    // Optional: Set the ComboBox to show the first item by default
                    if (cbMed.Items.Count > 0)
                    {
                        cbMed.SelectedIndex = 0;
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading ComboBox data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbMed_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                // Get the selected medication name
                string selectedMedicationName = cbMed.SelectedItem.ToString();

                // Look up the medication ID in the dictionary and display it in the TextBox
                if (medicationsDict.TryGetValue(selectedMedicationName, out string medicationID))
                {
                    txtMedID.Text = medicationID;
                }
            }
        }

        private void txtMedID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void lblPhysicianForm_Click(object sender, EventArgs e)
        {

        }
    }
}

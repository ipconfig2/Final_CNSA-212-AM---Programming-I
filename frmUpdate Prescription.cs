using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Final_1
{
    public partial class frmUpdate_Prescription : Form
    {


        public frmUpdate_Prescription()
        {
            InitializeComponent();
        }

        private void Update_Prescription_Load(object sender, EventArgs e)
        {
            DisableFormFields();
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.MouseOverBackColor = Color.PaleVioletRed;

            //turn button green on hover
            btnUpdatePrescription.FlatStyle = FlatStyle.Flat;
            btnUpdatePrescription.FlatAppearance.MouseOverBackColor = Color.LightGreen;

            btnUpdatePrescription.Enabled = false;
        }

        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrescriptionID.Text))
            {
                MessageBox.Show("Prescription ID is required.");
                return;
            }

            try
            {

                string PrescriptionId = txtPrescriptionID.Text.Trim();
                string PatientID = txtPatientID.Text.Trim();
                string PhysicianID = txtPhysicianID.Text.Trim();
                string MedName = txtMedicationName.Text.Trim();
                string Dosage = txtDosage.Text.Trim();
                string IntMethod = txtIntakeMethod.Text.ToString();
                int refillsLeft = -1;
                if (!string.IsNullOrEmpty(txtRefills.Text))
                {
                    refillsLeft = int.Parse(txtRefills.Text);
                }
                var updatePrescriptionInstance = new Class();
                updatePrescriptionInstance.UpdatePrescription(PrescriptionId, PatientID, PhysicianID, MedName, Dosage, IntMethod, refillsLeft);
                MessageBox.Show("Updated Prescription");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void txtPrescriptionID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPrescriptionID.Text))
            {
                EnableFormFields();
            }
            else
            {
                DisableFormFields();
                btnUpdatePrescription.Enabled = true;
            }

        }

        private void DisableFormFields()
        {
            txtPatientID.Enabled = false;
            txtPhysicianID.Enabled = false;
            txtMedicationName.Enabled = false;
            txtIntakeMethod.Enabled = false;
            txtRefills.Enabled = false;
            txtDosage.Enabled = false;
            btnUpdatePrescription.Enabled = false;
        }

        private void EnableFormFields()
        {
            txtPatientID.Enabled = true;
            txtPhysicianID.Enabled = true;
            txtMedicationName.Enabled = true;
            txtIntakeMethod.Enabled = true;
            txtRefills.Enabled = true;
            txtDosage.Enabled = true;
            btnUpdatePrescription.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

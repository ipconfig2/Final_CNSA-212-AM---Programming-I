using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Final_1
{
    public partial class frmAdd_Prescription : Form
    {
        public frmAdd_Prescription()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Prescription_Load(object sender, EventArgs e)
        {
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.MouseOverBackColor = Color.PaleVioletRed;

            //turn button green on hover
            btnAddPrescription.FlatStyle = FlatStyle.Flat;
            btnAddPrescription.FlatAppearance.MouseOverBackColor = Color.LightGreen;

            btnAddPrescription.Enabled = false;
        }

        private void btnAddPrescription_Click(object sender, EventArgs e)
        {
            try
            {
                string patientID = txtPatientID.Text;
                string physicianID = txtPhysicianID.Text;
                string medName = txtMedicationName.Text;
                string dosage = txtDosage.Text;
                string intMethod = txtIntakeMethod.Text;
                int refillsLeft = int.Parse(txtRefillsLeft.Text);

                var AddPre = new Class();
                AddPre.AddPrescription(patientID, physicianID, medName, dosage, intMethod, refillsLeft);
                MessageBox.Show("Successfuly added prescription");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPatientID_TextChanged(object sender, EventArgs e)
        {
            if ((txtPatientID.Text.Length > 0 && txtPhysicianID.Text.Length > 0 && txtDosage.Text.Length > 0 && txtIntakeMethod.Text.Length > 0 && txtMedicationName.Text.Length > 0 && txtRefillsLeft.Text.Length > 0))
            {
                btnAddPrescription.Enabled = true;
            }
            else
            {
                btnAddPrescription.Enabled = false;
            }
        }

        private void txtPhysicianID_TextChanged(object sender, EventArgs e)
        {
            if ((txtPatientID.Text.Length > 0 && txtPhysicianID.Text.Length > 0 && txtDosage.Text.Length > 0 && txtIntakeMethod.Text.Length > 0 && txtMedicationName.Text.Length > 0 && txtRefillsLeft.Text.Length > 0))
            {
                btnAddPrescription.Enabled = true;
            }
            else
            {
                btnAddPrescription.Enabled = false;
            }
        }

        private void txtMedicationName_TextChanged(object sender, EventArgs e)
        {
            if ((txtPatientID.Text.Length > 0 && txtPhysicianID.Text.Length > 0 && txtDosage.Text.Length > 0 && txtIntakeMethod.Text.Length > 0 && txtMedicationName.Text.Length > 0 && txtRefillsLeft.Text.Length > 0))
            {
                btnAddPrescription.Enabled = true;
            }
            else
            {
                btnAddPrescription.Enabled = false;
            }
        }

        private void txtIntakeMethod_TextChanged(object sender, EventArgs e)
        {
            if ((txtPatientID.Text.Length > 0 && txtPhysicianID.Text.Length > 0 && txtDosage.Text.Length > 0 && txtIntakeMethod.Text.Length > 0 && txtMedicationName.Text.Length > 0 && txtRefillsLeft.Text.Length > 0))
            {
                btnAddPrescription.Enabled = true;
            }
            else
            {
                btnAddPrescription.Enabled = false;
            }
        }

        private void txtRefillsLeft_TextChanged(object sender, EventArgs e)
        {
            if ((txtPatientID.Text.Length > 0 && txtPhysicianID.Text.Length > 0 && txtDosage.Text.Length > 0 && txtIntakeMethod.Text.Length > 0 && txtMedicationName.Text.Length > 0 && txtRefillsLeft.Text.Length > 0))
            {
                btnAddPrescription.Enabled = true;
            }
            else
            {
                btnAddPrescription.Enabled = false;
            }
        }

        private void txtDosage_TextChanged(object sender, EventArgs e)
        {
            if ((txtPatientID.Text.Length > 0 && txtPhysicianID.Text.Length > 0 && txtDosage.Text.Length > 0 && txtIntakeMethod.Text.Length > 0 && txtMedicationName.Text.Length > 0 && txtRefillsLeft.Text.Length > 0))
            {
                btnAddPrescription.Enabled = true;
            }
            else
            {
                btnAddPrescription.Enabled = false;
            }
        }
    }
}
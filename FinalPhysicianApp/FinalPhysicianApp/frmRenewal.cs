using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Data.SqlClient;

namespace FinalPhysicianApp
{
    public partial class frmRenewal : Form
    {
        public frmRenewal()
        {
            InitializeComponent();
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void dgrStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string searchText = txtPrescID.Text.Trim();

            int? prescid = null;
            string patientID = null;

            // Check if the input is a valid integer for PrescriptionID
            if (int.TryParse(searchText, out int parsedPrescID))
            {
                prescid = parsedPrescID;
            }
            else
            {
                // Assume it is a PatientID if not an integer
                patientID = searchText;
            }
            try
                {
                    DataSet ds = new DataSet();
                    prescDataTier prescDT = new prescDataTier();

                // Pass the integer version of prescid to GetPrescription
                ds = prescDT.GetPrescription(prescid, patientID);

                if (ds.Tables[0].Rows.Count > 0)
                    {
                        dgrPrescription.Visible = true;

                        dgrPrescription.DataSource = ds.Tables[0];
                        dgrPrescription.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;

                        dgrPrescription.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dgrPrescription.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;

                    }
                else
                {
                    MessageBox.Show("No records found for the given prescription ID.");
                }

            }
                catch (Exception ex)
                {
                MessageBox.Show(ex.Message + ex.Source, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void frmRenewal_Load(object sender, EventArgs e)
        {

        }

        private void txtPrescID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPhysicianForm_Click(object sender, EventArgs e)
        {

        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (dgrPrescription.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a prescription to renew.");
                return;
            }

            try
            {
                // Attempt to retrieve the selected PrescriptionID
                var selectedRow = dgrPrescription.SelectedRows[0];
                if (selectedRow.Cells["PrescriptionID"].Value == null)
                {
                    MessageBox.Show("The selected prescription does not have a valid ID.");
                    return;
                }

                int prescID;
                if (int.TryParse(selectedRow.Cells["PrescriptionID"].Value.ToString(), out prescID))
                {
                    prescDataTier2 prescDT = new prescDataTier2();

                    // Attempt to renew the prescription
                    bool success = prescDT.RenewPrescription(prescID);
                    if (success)
                    {
                        MessageBox.Show("Prescription renewed successfully.");

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error renewing prescription: " + ex.Message);
            }

        }

        private void btnClearTB_Click(object sender, EventArgs e)
        {

            if (dgrPrescription.Rows.Count > 0)
            {
                // Clear the data grid if it has data
                DataTable dt = (DataTable)dgrPrescription.DataSource;
                dt.Clear();
                txtPrescID.Text = String.Empty;
            }
            else
            {
                // Show an error message if the data grid is already empty
                MessageBox.Show("There is no data to clear.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}

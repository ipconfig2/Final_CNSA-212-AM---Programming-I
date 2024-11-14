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

namespace Final_1
{
    public partial class frmViewRefill : Form
    {
        public frmViewRefill()
        {
            InitializeComponent();
        }

        private void ViewRefill_Load(object sender, EventArgs e)
        {
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.MouseOverBackColor = Color.PaleVioletRed;

            //turn button green on hover
            btnGetRefill.FlatStyle = FlatStyle.Flat;
            btnGetRefill.FlatAppearance.MouseOverBackColor = Color.LightGreen;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string prescriptionId = txtViewRefill.Text.Trim();

            // Check if the Prescription ID is not empty
            if (!string.IsNullOrEmpty(prescriptionId))
            {
                Class refillsload = new Class();
                DataSet result = refillsload.LoadRefills(prescriptionId);

                if (result != null)
                {
                    // Process the result, such as binding it to a DataGridView
                    RefillsDataGridView.DataSource = result.Tables[0];
                }
                else
                {
                    MessageBox.Show("No data found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a Prescription ID.");
            }

        }

       

        private void btnGetRefill_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtViewRefill.Text.Trim(), out int prescriptionId))
                {
                    string status = "COMPLETED";

                    // Create an instance of PatientService
                    Class refilltrigger = new Class();
                    refilltrigger.TriggerRefillProcedure(prescriptionId, status);

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
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
           
        }

        private void cmuDelete_Click(object sender, EventArgs e)
        {

        }
    }
}

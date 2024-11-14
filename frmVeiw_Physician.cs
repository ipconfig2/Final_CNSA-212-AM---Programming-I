using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace Final_1
{
    public partial class frmVeiw_Physician : Form
    {
        public frmVeiw_Physician()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Veiw_Physician_Load(object sender, EventArgs e)
        {
            dgvPhysiciandata.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);

            cmuDelete.Enabled = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class dataService = new Class();
            DataSet physicianData = dataService.SearchPhysician(txtSearch.Text.Trim());

            // Assuming dgvPhysiciandata is your DataGridView
            dgvPhysiciandata.DataSource = physicianData.Tables[0];

            if (physicianData.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No records found.");
            }
            else
            {
                cmuDelete.Enabled = true;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void cmuSearch_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens the add patient form
            frmAdd_Physician aform = new frmAdd_Physician();
            aform.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cmuDelete_Click(object sender, EventArgs e)
        {
            string DoctorID = "";
            Class DeleteD = new Class();

            if (dgvPhysiciandata.SelectedRows.Count > 0)
            {
                try
                {
                    //selects the patient id from the selected row
                    DoctorID = dgvPhysiciandata.SelectedRows[0].Cells[0].Value.ToString();
                    var confirmResult = MessageBox.Show("Are you sure you want to remove this Physician?", "Confirm Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        // delete patient
                        DeleteD.DeleteDoctor(DoctorID);
                        MessageBox.Show("Physician Deleted Susscessfully!");

                        button1_Click(sender, e);

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

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
    public partial class frmViewpatient : Form
    {
        public frmViewpatient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Veiw_Patient_Load(object sender, EventArgs e)
        {
            //expands the datagrid with the app window
            dgvPatientdata.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);

            updateToolStripMenuItem.Enabled = false;
            deleteToolStripMenuItem.Enabled = false;
            copyIDToolStripMenuItem.Enabled = false;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class dataService = new Class();
            DataSet patientData = dataService.SearchPatient(txtPatientSearch.Text);

            // Assuming dgvPatientdata is your DataGridView
            dgvPatientdata.DataSource = patientData.Tables[0];

            if (patientData.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No records found.");
            }
            else
            {
                
                updateToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
                copyIDToolStripMenuItem.Enabled = true;
            
            }

        }


        private void dgvPatientdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtPatientSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens the update patient form
            frmUpdate_Patient_Info aform = new frmUpdate_Patient_Info();
            aform.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens the add patient form
            frmAdd_Patient aform = new frmAdd_Patient();
            aform.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string PATIENTID = "";
            Class DeleteP = new Class();

            if (dgvPatientdata.SelectedRows.Count > 0)
            {
                try
                {
                    //selects the patient id from the selected row
                    PATIENTID = dgvPatientdata.SelectedRows[0].Cells[0].Value.ToString();
                    var confirmResult = MessageBox.Show("Are you sure you want to remove this patient?", "Confirm Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        // delete patient
                        DeleteP.DeletePatient(PATIENTID);
                        MessageBox.Show("Patient Deleted Susscessfully!");

                        button1_Click(sender, e);
                        dgvPatientdata.Update();
                        dgvPatientdata.Refresh();


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

        private void copyIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
           var cop = dgvPatientdata.SelectedRows[0].Cells[0].Value.ToString();
            if ( cop != null)
            {
                Clipboard.SetText( cop.ToString());
            }
        }
    }
}

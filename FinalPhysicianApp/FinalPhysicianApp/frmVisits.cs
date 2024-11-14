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
using System.Xml.Linq;

namespace FinalPhysicianApp
{
    public partial class frmVisits : Form
    {
        public frmVisits()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                if (txtPatient.Text.Trim().Length > 0)
                {

                    {
                        DataSet ds = new DataSet();
                        prescDataTier Patinetid = new prescDataTier();

                        string patid = txtPatient.Text.Trim();
                        string docid = txtDoctor.Text.Trim();
                        string reason = txtReason.Text.Trim();
                        string diag1 = txtDiagnosis.Text.Trim();
                        string diag2 = txtDiagnosis2.Text.Trim();
                        string diag3 = txtDiagnosis3.Text.Trim();
                        string med1 = txtMedication.Text.Trim();
                        string dos1 = txtDosage.Text.Trim();
                        string int1 = txtIntake.Text.Trim();
                        string ref1 = txtRefills.Text.Trim();
                        string med2 = txtMedication2.Text.Trim();
                        string dos2 = txtDosage2.Text.Trim();
                        string int2 = txtIntake2.Text.Trim();
                        string ref2 = txtRefills2.Text.Trim();
                        string med3 = txtMedication3.Text.Trim();
                        string dos3 = txtDosage3.Text.Trim();
                        string int3 = txtIntake3.Text.Trim();
                        string ref3 = txtRefills3.Text.Trim();
                        decimal amt = 0;
                        if (txtAmount.Text != string.Empty)
                        {
                        amt = decimal.Parse(txtAmount.Text);
                        }
                        else
                        {
                       
                        }
                        Patinetid.PatVists(patid, reason, diag1, diag2, diag3, med1, dos1, int1, ref1, med2, dos2, int2, ref2, med3, dos3,  int3,  ref3, docid, amt);
                        MessageBox.Show("Record added susscessfully", "Confirmation!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
        }

        private void frmVisits_Load(object sender, EventArgs e)
        {
            txtDoctor.Enabled = false;
            txtReason.Enabled = false;
            txtDiagnosis.Enabled = false;
            txtDiagnosis2.Enabled = false;
            txtDiagnosis3.Enabled = false;
            txtMedication.Enabled = false; 
            txtDosage.Enabled = false;  
            txtIntake.Enabled = false;  
            txtRefills.Enabled = false;
            txtMedication2.Enabled = false;
            txtDosage2.Enabled = false;
            txtIntake2.Enabled = false;
            txtRefills2.Enabled = false;
            txtMedication3.Enabled = false;
            txtDosage3.Enabled = false;
            txtIntake3.Enabled = false;
            txtRefills3.Enabled = false;
            txtAmount.Enabled = false; 
            btnSave.Enabled = false;    
        }

        private void txtPatient_TextChanged(object sender, EventArgs e)
        {
            if(txtPatient.Text.Length > 0)
            {
                txtDoctor.Enabled = true;
                txtReason.Enabled = true;
                txtDiagnosis.Enabled = true;
                txtMedication.Enabled = true;
                txtDosage.Enabled = true;
                txtIntake.Enabled = true;
                txtRefills.Enabled = true;
                txtAmount.Enabled = true;
                btnSave.Enabled = true; 
            }
            
        }

        private void txtDiagnosis_TextChanged(object sender, EventArgs e)
        {
            if(txtDiagnosis.Text.Length > 0)
            {
                txtDiagnosis2.Enabled = true;
            }
            else
            {
                txtDiagnosis2.Enabled = false;
            }
        }

        private void txtDiagnosis3_TextChanged(object sender, EventArgs e)
        {
            if (txtDiagnosis3.Text.Length > 0)
            {
                txtMedication3.Enabled = true;
                txtDosage3.Enabled = true;
                txtIntake3.Enabled = true;
                txtRefills3.Enabled = true;
            }
            else
            {
                txtDiagnosis3.Enabled = false;
            }
        }

        private void txtDiagnosis2_TextChanged(object sender, EventArgs e)
        {
            if (txtDiagnosis2.Text.Length > 0)
            {
                txtDiagnosis3.Enabled = true;
                txtMedication2.Enabled = true;
                txtDosage2.Enabled = true;
                txtIntake2.Enabled = true;
                txtRefills2.Enabled = true;  
            }
            else
            {
                txtDiagnosis3.Enabled = false;
            }
        }
    }
}

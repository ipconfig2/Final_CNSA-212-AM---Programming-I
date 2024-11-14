using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPhysicianApp
{
    public partial class frmHome : Form
    {
        public frmModPhysician frmModPhysician;
        public frmPrescription frmPrescription;
        public frmModPatient frmModPatient;
        public frmRenewal frmRenewal;
        private frmLookUp frmLookUp;

        public string SelectedForm { get; private set; }  // Store the user's choice
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            btnModFrm.Enabled = false;
        }

        private void ckPhy_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (ckPhy.Checked)
                {
                    ckPat.Enabled = false;
                    btnModFrm.Enabled = true;
                }
                if (!ckPhy.Checked)
                {
                    ckPat.Enabled = true;
                    btnModFrm.Enabled = false;
                }

            }
        }

        private void ckPat_CheckedChanged(object sender, EventArgs e)
        {
            if (ckPat.Checked)
            {
                ckPhy.Enabled = false;
                btnModFrm.Enabled = true;
            }
            if (!ckPat.Checked)
            {
                ckPhy.Enabled = true;
                btnModFrm.Enabled = false;
            }
        }

        private void btnModFrm_Click(object sender, EventArgs e)
        {
            {
                if (ckPhy.Checked)
                {
                    frmModPhysician = new frmModPhysician();
                    frmModPhysician.MdiParent = this.MdiParent;
                    frmModPhysician.Show();
                }
                if (ckPat.Checked)
                {
                    frmModPatient = new frmModPatient();
                    frmModPatient.MdiParent = this.MdiParent;
                    frmModPatient.Show();
                }

            }
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            frmLookUp = new frmLookUp();
            frmLookUp.MdiParent = this.MdiParent;
            frmLookUp.Show();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            frmRenewal = new frmRenewal();
            frmRenewal.MdiParent = this.MdiParent;
            frmRenewal.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmPrescription = new frmPrescription();
            frmPrescription.MdiParent = this.MdiParent;
            frmPrescription.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnVisit_Click(object sender, EventArgs e)
        {
            var frmVisits = new frmVisits();
            frmVisits.MdiParent = this.MdiParent;
            frmVisits.Show();
        }


        private int buttonPressCount = 0;
        private void btnJoke_Click(object sender, EventArgs e)
        {
            buttonPressCount++;
            if (buttonPressCount <= 3)
            {
                MessageBox.Show("Task Failed Successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            else
            {
                MessageBox.Show("You have pressed the button more than 3 times, How many times are you going to do this????", "Observation Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}

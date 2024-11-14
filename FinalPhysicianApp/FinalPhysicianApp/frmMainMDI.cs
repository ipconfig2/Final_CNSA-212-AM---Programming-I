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
    public partial class frmMainMDI : Form
    {
        private frmHome frmHome;

        public frmMainMDI()
        {

            InitializeComponent();
            this.IsMdiContainer = true;
        }
        private void homePhysicianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //// Open frmHomePhysician as an MDI child
            frmHome homePhysicianForm = new frmHome();
            homePhysicianForm.MdiParent = this;
            homePhysicianForm.Show();
        }

        private void modPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open frmModPatient as an MDI child
            frmModPatient modPatientForm = new frmModPatient();
            modPatientForm.MdiParent = this;
            modPatientForm.Show();
        }

        private void modPhysicianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open frmModPhysician as an MDI child
            frmModPhysician modPhysicianForm = new frmModPhysician();
            modPhysicianForm.MdiParent = this;
            modPhysicianForm.Show();
        }

        private void prescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open frmPrescription as an MDI child
            frmPrescription prescriptionForm = new frmPrescription();
            prescriptionForm.MdiParent = this;
            prescriptionForm.Show();
        }

        private void renewalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open frmRenewal as an MDI child
            frmRenewal renewalForm = new frmRenewal();
            renewalForm.MdiParent = this;
            renewalForm.Show();
        }

    public void frmMainMDI_Load(object sender, EventArgs e)
        {
            // Open frmHomePhysician as an MDI child at startup
            frmHome homePhysicianForm = new frmHome();
            homePhysicianForm.MdiParent = this;
            homePhysicianForm.Show();
            homePhysicianForm.Focus();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Arrange_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void summaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void virticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Temporarily store the current size of each child form
            var childForms = this.MdiChildren;
            var formSizes = childForms.ToDictionary(form => form, form => form.Size);

            this.LayoutMdi(MdiLayout.TileVertical);

            // Restore each form's original size
            foreach (var form in childForms)
            {
                form.Size = formSizes[form];
            }
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childform in this.MdiChildren)
            {
                childform.Close();
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHome homePhysicianForm = new frmHome();
            homePhysicianForm.MdiParent = this;
            homePhysicianForm.Show();
            homePhysicianForm.Focus();
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Temporarily store the current size of each child form
            var childForms = this.MdiChildren;
            var formSizes = childForms.ToDictionary(form => form, form => form.Size);

            this.LayoutMdi(MdiLayout.TileHorizontal);

            // Restore each form's original size
            foreach (var form in childForms)
            {
                form.Size = formSizes[form];
            }
        }

        private void showStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

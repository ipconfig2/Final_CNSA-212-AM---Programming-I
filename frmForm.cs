using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Final_1
{
    public partial class frmForm : Form
    {
        public frmForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;  // Set the main form as MDI container.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //startup sound
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\coding\Documents\Startup.wav");
            player.Play();
            
            //background
            BackgroundImageLayout = ImageLayout.Stretch;
            Image myimage = new Bitmap(@"C:\Users\coding\Documents\LP2.jpg");
            this.BackgroundImage = myimage;
            
            //screen size on load
            this.Size = new Size(1250, 900);

        }



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addNewPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmAdd_Patient AddPatientForm = new frmAdd_Patient();

            AddPatientForm.MdiParent = this;
            AddPatientForm.StartPosition = FormStartPosition.CenterScreen;
            AddPatientForm.Show();
            AddPatientForm.Focus();
            AddPatientForm.Activate();
            AddPatientForm.BringToFront();

        }

        private void viewPatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewpatient viewPatientForm = new frmViewpatient();

            viewPatientForm.MdiParent = this;
            viewPatientForm.StartPosition = FormStartPosition.CenterScreen;
            viewPatientForm.Show();
            viewPatientForm.Focus();
            viewPatientForm.Activate();
            viewPatientForm.BringToFront();
        }

        private void viewPhysicianToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            frmVeiw_Physician viewPhysicianForm = new frmVeiw_Physician();

            viewPhysicianForm.MdiParent = this;
            viewPhysicianForm.StartPosition = FormStartPosition.CenterScreen;
            viewPhysicianForm.Show();
            viewPhysicianForm.Focus();
            viewPhysicianForm.Activate();
            viewPhysicianForm.BringToFront();

        }

        private void addPhysicianToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmAdd_Physician AddPhysicianForm = new frmAdd_Physician();

            AddPhysicianForm.MdiParent = this;
            AddPhysicianForm.StartPosition = FormStartPosition.CenterScreen;
            AddPhysicianForm.Show();
            AddPhysicianForm.Focus();
            AddPhysicianForm.Activate();
            AddPhysicianForm.BringToFront();
        }

        private void updatePatientInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmUpdate_Patient_Info Update_Patient_InfoForm = new frmUpdate_Patient_Info();

            Update_Patient_InfoForm.MdiParent = this;
            Update_Patient_InfoForm.StartPosition = FormStartPosition.CenterScreen;
            Update_Patient_InfoForm.Show();
            Update_Patient_InfoForm.Focus();
            Update_Patient_InfoForm.Activate();
            Update_Patient_InfoForm.BringToFront();

        }

        private void addPrescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmAdd_Prescription AddPrescriptionForm = new frmAdd_Prescription();

            AddPrescriptionForm.MdiParent = this;
            AddPrescriptionForm.StartPosition = FormStartPosition.CenterScreen;
            AddPrescriptionForm.Show();
            AddPrescriptionForm.Focus();
            AddPrescriptionForm.Activate();
            AddPrescriptionForm.BringToFront();
        }

        private void updatePrescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmUpdate_Prescription UpdatePrescriptionForm = new frmUpdate_Prescription();

            UpdatePrescriptionForm.MdiParent = this;
            UpdatePrescriptionForm.StartPosition = FormStartPosition.CenterScreen;
            UpdatePrescriptionForm.Show();
            UpdatePrescriptionForm.Focus();
            UpdatePrescriptionForm.Activate();
            UpdatePrescriptionForm.BringToFront();
            
        }

        private void viewPatientsPrescriptionsToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            frmView_Patients_Prescriptions ViewPrescriptionRecordsForm = new frmView_Patients_Prescriptions();

            ViewPrescriptionRecordsForm.MdiParent = this;
            ViewPrescriptionRecordsForm.StartPosition = FormStartPosition.CenterScreen;
            ViewPrescriptionRecordsForm.Show();
            ViewPrescriptionRecordsForm.Focus();
            ViewPrescriptionRecordsForm.Activate();
            ViewPrescriptionRecordsForm.BringToFront();
        }

        private void viewRefillsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmViewRefill ViewRefillForm = new frmViewRefill();

            ViewRefillForm.MdiParent = this;
            ViewRefillForm.StartPosition = FormStartPosition.CenterScreen;
            ViewRefillForm.Show();
            ViewRefillForm.Focus();
            ViewRefillForm.Activate();
            ViewRefillForm.BringToFront();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childform in this.MdiChildren)
            {
                childform.Close();
            }
        }
    }
}

namespace Final_1
{
    partial class frmForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePatientInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.physicianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPhysicianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPrescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePrescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPatientsPrescriptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPhysicianToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRefillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientToolStripMenuItem,
            this.physicianToolStripMenuItem,
            this.prescriptionToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPatientToolStripMenuItem,
            this.updatePatientInfoToolStripMenuItem});
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.patientToolStripMenuItem.Text = "&Patient";
            // 
            // addNewPatientToolStripMenuItem
            // 
            this.addNewPatientToolStripMenuItem.Name = "addNewPatientToolStripMenuItem";
            this.addNewPatientToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.addNewPatientToolStripMenuItem.Text = "&Add New Patient";
            this.addNewPatientToolStripMenuItem.Click += new System.EventHandler(this.addNewPatientToolStripMenuItem_Click);
            // 
            // updatePatientInfoToolStripMenuItem
            // 
            this.updatePatientInfoToolStripMenuItem.Name = "updatePatientInfoToolStripMenuItem";
            this.updatePatientInfoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.updatePatientInfoToolStripMenuItem.Text = "&Update Patient Info";
            this.updatePatientInfoToolStripMenuItem.Click += new System.EventHandler(this.updatePatientInfoToolStripMenuItem_Click);
            // 
            // physicianToolStripMenuItem
            // 
            this.physicianToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPhysicianToolStripMenuItem});
            this.physicianToolStripMenuItem.Name = "physicianToolStripMenuItem";
            this.physicianToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.physicianToolStripMenuItem.Text = "Ph&ysician";
            // 
            // addPhysicianToolStripMenuItem
            // 
            this.addPhysicianToolStripMenuItem.Name = "addPhysicianToolStripMenuItem";
            this.addPhysicianToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.addPhysicianToolStripMenuItem.Text = "Add Physi&cian";
            this.addPhysicianToolStripMenuItem.Click += new System.EventHandler(this.addPhysicianToolStripMenuItem_Click);
            // 
            // prescriptionToolStripMenuItem
            // 
            this.prescriptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPrescriptionToolStripMenuItem,
            this.updatePrescriptionToolStripMenuItem});
            this.prescriptionToolStripMenuItem.Name = "prescriptionToolStripMenuItem";
            this.prescriptionToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.prescriptionToolStripMenuItem.Text = "P&rescription";
            // 
            // addPrescriptionToolStripMenuItem
            // 
            this.addPrescriptionToolStripMenuItem.Name = "addPrescriptionToolStripMenuItem";
            this.addPrescriptionToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.addPrescriptionToolStripMenuItem.Text = "Add Pr&escription";
            this.addPrescriptionToolStripMenuItem.Click += new System.EventHandler(this.addPrescriptionToolStripMenuItem_Click);
            // 
            // updatePrescriptionToolStripMenuItem
            // 
            this.updatePrescriptionToolStripMenuItem.Name = "updatePrescriptionToolStripMenuItem";
            this.updatePrescriptionToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.updatePrescriptionToolStripMenuItem.Text = "Up&date Prescription";
            this.updatePrescriptionToolStripMenuItem.Click += new System.EventHandler(this.updatePrescriptionToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPatientsPrescriptionsToolStripMenuItem,
            this.viewPatientsToolStripMenuItem,
            this.viewPhysicianToolStripMenuItem1,
            this.viewRefillsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // viewPatientsPrescriptionsToolStripMenuItem
            // 
            this.viewPatientsPrescriptionsToolStripMenuItem.Name = "viewPatientsPrescriptionsToolStripMenuItem";
            this.viewPatientsPrescriptionsToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.viewPatientsPrescriptionsToolStripMenuItem.Text = "View Pa&tient’s Prescriptions";
            this.viewPatientsPrescriptionsToolStripMenuItem.Click += new System.EventHandler(this.viewPatientsPrescriptionsToolStripMenuItem_Click);
            // 
            // viewPatientsToolStripMenuItem
            // 
            this.viewPatientsToolStripMenuItem.Name = "viewPatientsToolStripMenuItem";
            this.viewPatientsToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.viewPatientsToolStripMenuItem.Text = "View Patie&nts";
            this.viewPatientsToolStripMenuItem.Click += new System.EventHandler(this.viewPatientsToolStripMenuItem_Click);
            // 
            // viewPhysicianToolStripMenuItem1
            // 
            this.viewPhysicianToolStripMenuItem1.Name = "viewPhysicianToolStripMenuItem1";
            this.viewPhysicianToolStripMenuItem1.Size = new System.Drawing.Size(218, 22);
            this.viewPhysicianToolStripMenuItem1.Text = "View P&hysician";
            this.viewPhysicianToolStripMenuItem1.Click += new System.EventHandler(this.viewPhysicianToolStripMenuItem1_Click);
            // 
            // viewRefillsToolStripMenuItem
            // 
            this.viewRefillsToolStripMenuItem.Name = "viewRefillsToolStripMenuItem";
            this.viewRefillsToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.viewRefillsToolStripMenuItem.Text = "Refill&s";
            this.viewRefillsToolStripMenuItem.ToolTipText = "Click to view refill logs or log a refill pickup";
            this.viewRefillsToolStripMenuItem.Click += new System.EventHandler(this.viewRefillsToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem,
            this.closeAllToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "&Window";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.cascadeToolStripMenuItem.Text = "&Cascade";
            this.cascadeToolStripMenuItem.ToolTipText = "Click to  make windows Cascading to eachother";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.horizontalToolStripMenuItem.Text = "&Horizontal";
            this.horizontalToolStripMenuItem.ToolTipText = "Click to  make windows Horizontal to eachother";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.verticalToolStripMenuItem.Text = "&Vertical";
            this.verticalToolStripMenuItem.ToolTipText = "Click to  make windows vertical to eachother";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.closeAllToolStripMenuItem.Text = "Close &All";
            this.closeAllToolStripMenuItem.ToolTipText = "Click to close all windows";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.closeAllToolStripMenuItem_Click);
            // 
            // frmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Louis Pharmacy App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePatientInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem physicianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPhysicianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPrescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePrescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPatientsPrescriptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPatientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPhysicianToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewRefillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


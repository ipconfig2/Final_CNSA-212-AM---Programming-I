namespace FinalPhysicianApp
{
    partial class frmRenewal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRenewal));
            this.btnRenew = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgrPrescription = new System.Windows.Forms.DataGridView();
            this.PrescriptionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHYSICIANID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatePrescribed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefillsLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPrescID = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblPhysicianForm = new System.Windows.Forms.Label();
            this.btnClearTB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrPrescription)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRenew
            // 
            this.btnRenew.Location = new System.Drawing.Point(609, 79);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(159, 23);
            this.btnRenew.TabIndex = 12;
            this.btnRenew.Text = "Renewal Prescription";
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Location = new System.Drawing.Point(59, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Enter ID:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(774, 79);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 23);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgrPrescription
            // 
            this.dgrPrescription.AllowUserToAddRows = false;
            this.dgrPrescription.AllowUserToDeleteRows = false;
            this.dgrPrescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrPrescription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrescriptionID,
            this.PatientID,
            this.PHYSICIANID,
            this.MedName,
            this.Dosage,
            this.intMethod,
            this.DatePrescribed,
            this.RefillsLeft});
            this.dgrPrescription.Location = new System.Drawing.Point(12, 108);
            this.dgrPrescription.Name = "dgrPrescription";
            this.dgrPrescription.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrPrescription.Size = new System.Drawing.Size(844, 219);
            this.dgrPrescription.TabIndex = 23;
            this.dgrPrescription.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrStudents_CellContentClick);
            // 
            // PrescriptionID
            // 
            this.PrescriptionID.DataPropertyName = "PrescriptionID";
            this.PrescriptionID.HeaderText = "Prescriptions ID";
            this.PrescriptionID.Name = "PrescriptionID";
            // 
            // PatientID
            // 
            this.PatientID.DataPropertyName = "PatientID";
            this.PatientID.HeaderText = "Patient ID";
            this.PatientID.Name = "PatientID";
            // 
            // PHYSICIANID
            // 
            this.PHYSICIANID.DataPropertyName = "PHYSICIANID";
            this.PHYSICIANID.HeaderText = "Physician ID";
            this.PHYSICIANID.Name = "PHYSICIANID";
            // 
            // MedName
            // 
            this.MedName.DataPropertyName = "MedName";
            this.MedName.HeaderText = "Medication";
            this.MedName.Name = "MedName";
            // 
            // Dosage
            // 
            this.Dosage.DataPropertyName = "Dosage";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Dosage.DefaultCellStyle = dataGridViewCellStyle1;
            this.Dosage.HeaderText = "Dosage";
            this.Dosage.Name = "Dosage";
            // 
            // intMethod
            // 
            this.intMethod.DataPropertyName = "IntMethod";
            this.intMethod.HeaderText = "Intake";
            this.intMethod.Name = "intMethod";
            // 
            // DatePrescribed
            // 
            this.DatePrescribed.DataPropertyName = "DatePrescribed";
            dataGridViewCellStyle2.Format = "g";
            dataGridViewCellStyle2.NullValue = null;
            this.DatePrescribed.DefaultCellStyle = dataGridViewCellStyle2;
            this.DatePrescribed.HeaderText = "Date Prescribed";
            this.DatePrescribed.Name = "DatePrescribed";
            // 
            // RefillsLeft
            // 
            this.RefillsLeft.DataPropertyName = "RefillsLeft";
            this.RefillsLeft.HeaderText = "Refills";
            this.RefillsLeft.Name = "RefillsLeft";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(235, 79);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPrescID
            // 
            this.txtPrescID.Location = new System.Drawing.Point(12, 79);
            this.txtPrescID.Name = "txtPrescID";
            this.txtPrescID.Size = new System.Drawing.Size(206, 20);
            this.txtPrescID.TabIndex = 21;
            this.toolTip1.SetToolTip(this.txtPrescID, "Enter Prescription or Patient ID");
            this.txtPrescID.TextChanged += new System.EventHandler(this.txtPrescID_TextChanged);
            // 
            // lblPhysicianForm
            // 
            this.lblPhysicianForm.AutoSize = true;
            this.lblPhysicianForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhysicianForm.Location = new System.Drawing.Point(185, 9);
            this.lblPhysicianForm.Name = "lblPhysicianForm";
            this.lblPhysicianForm.Size = new System.Drawing.Size(489, 31);
            this.lblPhysicianForm.TabIndex = 25;
            this.lblPhysicianForm.Text = "Prescription Renewal and Lookup Form";
            this.lblPhysicianForm.Click += new System.EventHandler(this.lblPhysicianForm_Click);
            // 
            // btnClearTB
            // 
            this.btnClearTB.Location = new System.Drawing.Point(335, 79);
            this.btnClearTB.Name = "btnClearTB";
            this.btnClearTB.Size = new System.Drawing.Size(75, 23);
            this.btnClearTB.TabIndex = 26;
            this.btnClearTB.Text = "Clear Table";
            this.btnClearTB.UseVisualStyleBackColor = true;
            this.btnClearTB.Click += new System.EventHandler(this.btnClearTB_Click);
            // 
            // frmRenewal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 342);
            this.Controls.Add(this.btnClearTB);
            this.Controls.Add(this.lblPhysicianForm);
            this.Controls.Add(this.dgrPrescription);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtPrescID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRenew);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRenewal";
            this.Text = "frmRenewal";
            this.Load += new System.EventHandler(this.frmRenewal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrPrescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgrPrescription;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPrescID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrescriptionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHYSICIANID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosage;
        private System.Windows.Forms.DataGridViewTextBoxColumn intMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatePrescribed;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefillsLeft;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblPhysicianForm;
        private System.Windows.Forms.Button btnClearTB;
    }
}
namespace Final_1
{
    partial class frmUpdate_Prescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdate_Prescription));
            this.txtRefills = new System.Windows.Forms.TextBox();
            this.txtIntakeMethod = new System.Windows.Forms.TextBox();
            this.txtDosage = new System.Windows.Forms.TextBox();
            this.txtMedicationName = new System.Windows.Forms.TextBox();
            this.txtPhysicianID = new System.Windows.Forms.TextBox();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdatePrescription = new System.Windows.Forms.Button();
            this.txtPrescriptionID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRefills
            // 
            this.txtRefills.Location = new System.Drawing.Point(509, 169);
            this.txtRefills.Name = "txtRefills";
            this.txtRefills.Size = new System.Drawing.Size(246, 20);
            this.txtRefills.TabIndex = 6;
            // 
            // txtIntakeMethod
            // 
            this.txtIntakeMethod.Location = new System.Drawing.Point(509, 142);
            this.txtIntakeMethod.Name = "txtIntakeMethod";
            this.txtIntakeMethod.Size = new System.Drawing.Size(246, 20);
            this.txtIntakeMethod.TabIndex = 5;
            // 
            // txtDosage
            // 
            this.txtDosage.Location = new System.Drawing.Point(509, 195);
            this.txtDosage.Name = "txtDosage";
            this.txtDosage.Size = new System.Drawing.Size(246, 20);
            this.txtDosage.TabIndex = 7;
            // 
            // txtMedicationName
            // 
            this.txtMedicationName.Location = new System.Drawing.Point(144, 194);
            this.txtMedicationName.Name = "txtMedicationName";
            this.txtMedicationName.Size = new System.Drawing.Size(246, 20);
            this.txtMedicationName.TabIndex = 4;
            // 
            // txtPhysicianID
            // 
            this.txtPhysicianID.Location = new System.Drawing.Point(144, 168);
            this.txtPhysicianID.Name = "txtPhysicianID";
            this.txtPhysicianID.Size = new System.Drawing.Size(246, 20);
            this.txtPhysicianID.TabIndex = 3;
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(144, 141);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(246, 20);
            this.txtPatientID.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Gainsboro;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(464, 172);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 14);
            this.label15.TabIndex = 96;
            this.label15.Text = "Refills:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Gainsboro;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(424, 145);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 14);
            this.label18.TabIndex = 94;
            this.label18.Text = "Intake Method:";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(460, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 14);
            this.label5.TabIndex = 93;
            this.label5.Text = "Dosage:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 14);
            this.label6.TabIndex = 92;
            this.label6.Text = "Medication Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 14);
            this.label4.TabIndex = 91;
            this.label4.Text = "Physician ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 14);
            this.label3.TabIndex = 90;
            this.label3.Text = "Patient ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 23);
            this.label1.TabIndex = 89;
            this.label1.Text = "Update Prescription";
            // 
            // btnUpdatePrescription
            // 
            this.btnUpdatePrescription.Location = new System.Drawing.Point(248, 283);
            this.btnUpdatePrescription.Name = "btnUpdatePrescription";
            this.btnUpdatePrescription.Size = new System.Drawing.Size(142, 49);
            this.btnUpdatePrescription.TabIndex = 8;
            this.btnUpdatePrescription.Text = "Update Prescription";
            this.toolTip1.SetToolTip(this.btnUpdatePrescription, "Press to update Prescription ");
            this.btnUpdatePrescription.UseVisualStyleBackColor = true;
            this.btnUpdatePrescription.Click += new System.EventHandler(this.btnUpdatePatient_Click);
            // 
            // txtPrescriptionID
            // 
            this.txtPrescriptionID.Location = new System.Drawing.Point(348, 81);
            this.txtPrescriptionID.Name = "txtPrescriptionID";
            this.txtPrescriptionID.Size = new System.Drawing.Size(246, 20);
            this.txtPrescriptionID.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtPrescriptionID, "Input Prescription ID for the Prescription that you want to updated");
            this.txtPrescriptionID.TextChanged += new System.EventHandler(this.txtPrescriptionID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 14);
            this.label2.TabIndex = 110;
            this.label2.Text = "Prescription ID:";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(452, 283);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 49);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Cancel";
            this.toolTip1.SetToolTip(this.btnClose, "Close form");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(330, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 114;
            this.label7.Text = "*";
            this.toolTip1.SetToolTip(this.label7, "Required Field");
            // 
            // frmUpdate_Prescription
            // 
            this.AcceptButton = this.btnUpdatePrescription;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(823, 451);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtPrescriptionID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpdatePrescription);
            this.Controls.Add(this.txtRefills);
            this.Controls.Add(this.txtIntakeMethod);
            this.Controls.Add(this.txtDosage);
            this.Controls.Add(this.txtMedicationName);
            this.Controls.Add(this.txtPhysicianID);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdate_Prescription";
            this.Text = "Update_Prescription";
            this.Load += new System.EventHandler(this.Update_Prescription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRefills;
        private System.Windows.Forms.TextBox txtIntakeMethod;
        private System.Windows.Forms.TextBox txtDosage;
        private System.Windows.Forms.TextBox txtMedicationName;
        private System.Windows.Forms.TextBox txtPhysicianID;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdatePrescription;
        private System.Windows.Forms.TextBox txtPrescriptionID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label7;
    }
}
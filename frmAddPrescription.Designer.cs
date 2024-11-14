namespace Final_1
{
    partial class frmAdd_Prescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdd_Prescription));
            this.txtRefillsLeft = new System.Windows.Forms.TextBox();
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
            this.btnAddPrescription = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRefillsLeft
            // 
            this.txtRefillsLeft.Location = new System.Drawing.Point(498, 128);
            this.txtRefillsLeft.Name = "txtRefillsLeft";
            this.txtRefillsLeft.Size = new System.Drawing.Size(246, 20);
            this.txtRefillsLeft.TabIndex = 85;
            this.txtRefillsLeft.TextChanged += new System.EventHandler(this.txtRefillsLeft_TextChanged);
            // 
            // txtIntakeMethod
            // 
            this.txtIntakeMethod.Location = new System.Drawing.Point(498, 100);
            this.txtIntakeMethod.Name = "txtIntakeMethod";
            this.txtIntakeMethod.Size = new System.Drawing.Size(246, 20);
            this.txtIntakeMethod.TabIndex = 84;
            this.txtIntakeMethod.TextChanged += new System.EventHandler(this.txtIntakeMethod_TextChanged);
            // 
            // txtDosage
            // 
            this.txtDosage.Location = new System.Drawing.Point(498, 156);
            this.txtDosage.Name = "txtDosage";
            this.txtDosage.Size = new System.Drawing.Size(246, 20);
            this.txtDosage.TabIndex = 86;
            this.txtDosage.TextChanged += new System.EventHandler(this.txtDosage_TextChanged);
            // 
            // txtMedicationName
            // 
            this.txtMedicationName.Location = new System.Drawing.Point(122, 153);
            this.txtMedicationName.Name = "txtMedicationName";
            this.txtMedicationName.Size = new System.Drawing.Size(246, 20);
            this.txtMedicationName.TabIndex = 83;
            this.txtMedicationName.TextChanged += new System.EventHandler(this.txtMedicationName_TextChanged);
            // 
            // txtPhysicianID
            // 
            this.txtPhysicianID.Location = new System.Drawing.Point(122, 127);
            this.txtPhysicianID.Name = "txtPhysicianID";
            this.txtPhysicianID.Size = new System.Drawing.Size(246, 20);
            this.txtPhysicianID.TabIndex = 82;
            this.txtPhysicianID.TextChanged += new System.EventHandler(this.txtPhysicianID_TextChanged);
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(122, 100);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(246, 20);
            this.txtPatientID.TabIndex = 81;
            this.txtPatientID.TextChanged += new System.EventHandler(this.txtPatientID_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Gainsboro;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(442, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 14);
            this.label15.TabIndex = 80;
            this.label15.Text = "Refills:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Gainsboro;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(402, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 14);
            this.label18.TabIndex = 77;
            this.label18.Text = "Intake Method:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(438, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 14);
            this.label5.TabIndex = 76;
            this.label5.Text = "Dosage:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 14);
            this.label6.TabIndex = 75;
            this.label6.Text = "Medication Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 14);
            this.label4.TabIndex = 74;
            this.label4.Text = "Physician ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 14);
            this.label3.TabIndex = 73;
            this.label3.Text = "Patient ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 23);
            this.label1.TabIndex = 72;
            this.label1.Text = "Add Prescription";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAddPrescription
            // 
            this.btnAddPrescription.Location = new System.Drawing.Point(329, 296);
            this.btnAddPrescription.Name = "btnAddPrescription";
            this.btnAddPrescription.Size = new System.Drawing.Size(142, 49);
            this.btnAddPrescription.TabIndex = 87;
            this.btnAddPrescription.Text = "Add Prescription";
            this.toolTip1.SetToolTip(this.btnAddPrescription, "Click to Add Prescription");
            this.btnAddPrescription.UseVisualStyleBackColor = true;
            this.btnAddPrescription.Click += new System.EventHandler(this.btnAddPrescription_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(329, 362);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 49);
            this.btnClose.TabIndex = 88;
            this.btnClose.Text = "Cancel";
            this.toolTip1.SetToolTip(this.btnClose, "Close form");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(101, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 114;
            this.label2.Text = "*";
            this.toolTip1.SetToolTip(this.label2, "Required Field");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(101, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 115;
            this.label7.Text = "*";
            this.toolTip1.SetToolTip(this.label7, "Required Field");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(101, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 116;
            this.label8.Text = "*";
            this.toolTip1.SetToolTip(this.label8, "Required Field");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(477, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 20);
            this.label9.TabIndex = 117;
            this.label9.Text = "*";
            this.toolTip1.SetToolTip(this.label9, "Required Field");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(477, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 20);
            this.label10.TabIndex = 118;
            this.label10.Text = "*";
            this.toolTip1.SetToolTip(this.label10, "Required Field");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(477, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 20);
            this.label11.TabIndex = 119;
            this.label11.Text = "*";
            this.toolTip1.SetToolTip(this.label11, "Required Field");
            // 
            // frmAdd_Prescription
            // 
            this.AcceptButton = this.btnAddPrescription;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddPrescription);
            this.Controls.Add(this.txtRefillsLeft);
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
            this.Name = "frmAdd_Prescription";
            this.Text = "Add_Prescription";
            this.Load += new System.EventHandler(this.Add_Prescription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRefillsLeft;
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
        private System.Windows.Forms.Button btnAddPrescription;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}
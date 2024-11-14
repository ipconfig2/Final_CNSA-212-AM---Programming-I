namespace FinalPhysicianApp
{
    partial class frmVisits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisits));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtDoctor = new System.Windows.Forms.TextBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.txtPatient = new System.Windows.Forms.TextBox();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIntake3 = new System.Windows.Forms.TextBox();
            this.lblMedication3 = new System.Windows.Forms.Label();
            this.lblRefills3 = new System.Windows.Forms.Label();
            this.lblDosage3 = new System.Windows.Forms.Label();
            this.txtRefills3 = new System.Windows.Forms.TextBox();
            this.txtDosage3 = new System.Windows.Forms.TextBox();
            this.lblIntake3 = new System.Windows.Forms.Label();
            this.txtMedication3 = new System.Windows.Forms.TextBox();
            this.txtIntake2 = new System.Windows.Forms.TextBox();
            this.lblMedication2 = new System.Windows.Forms.Label();
            this.lblRefills2 = new System.Windows.Forms.Label();
            this.lblDosage2 = new System.Windows.Forms.Label();
            this.txtRefills2 = new System.Windows.Forms.TextBox();
            this.txtDosage2 = new System.Windows.Forms.TextBox();
            this.lblIntake2 = new System.Windows.Forms.Label();
            this.txtMedication2 = new System.Windows.Forms.TextBox();
            this.txtIntake = new System.Windows.Forms.TextBox();
            this.lblMedication = new System.Windows.Forms.Label();
            this.lblRefills = new System.Windows.Forms.Label();
            this.lblDosage = new System.Windows.Forms.Label();
            this.txtRefills = new System.Windows.Forms.TextBox();
            this.txtDosage = new System.Windows.Forms.TextBox();
            this.lblIntake = new System.Windows.Forms.Label();
            this.txtMedication = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDiagnosis3 = new System.Windows.Forms.Label();
            this.txtDiagnosis3 = new System.Windows.Forms.TextBox();
            this.lblDiagnosis2 = new System.Windows.Forms.Label();
            this.txtDiagnosis2 = new System.Windows.Forms.TextBox();
            this.lblDiagnosis = new System.Windows.Forms.Label();
            this.txtDiagnosis = new System.Windows.Forms.TextBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblPatient = new System.Windows.Forms.Label();
            this.lblVisists = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(400, 485);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 50);
            this.btnClose.TabIndex = 48;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(251, 485);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 50);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(447, 183);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 46;
            // 
            // txtDoctor
            // 
            this.txtDoctor.Location = new System.Drawing.Point(420, 116);
            this.txtDoctor.Name = "txtDoctor";
            this.txtDoctor.Size = new System.Drawing.Size(100, 20);
            this.txtDoctor.TabIndex = 45;
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(143, 185);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(100, 20);
            this.txtReason.TabIndex = 44;
            // 
            // txtPatient
            // 
            this.txtPatient.Location = new System.Drawing.Point(119, 118);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.Size = new System.Drawing.Size(100, 20);
            this.txtPatient.TabIndex = 43;
            this.txtPatient.TextChanged += new System.EventHandler(this.txtPatient_TextChanged);
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.BackColor = System.Drawing.Color.Gainsboro;
            this.lblDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctor.Location = new System.Drawing.Point(330, 116);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(82, 20);
            this.lblDoctor.TabIndex = 42;
            this.lblDoctor.Text = "Doctor ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIntake3);
            this.groupBox1.Controls.Add(this.lblMedication3);
            this.groupBox1.Controls.Add(this.lblRefills3);
            this.groupBox1.Controls.Add(this.lblDosage3);
            this.groupBox1.Controls.Add(this.txtRefills3);
            this.groupBox1.Controls.Add(this.txtDosage3);
            this.groupBox1.Controls.Add(this.lblIntake3);
            this.groupBox1.Controls.Add(this.txtMedication3);
            this.groupBox1.Controls.Add(this.txtIntake2);
            this.groupBox1.Controls.Add(this.lblMedication2);
            this.groupBox1.Controls.Add(this.lblRefills2);
            this.groupBox1.Controls.Add(this.lblDosage2);
            this.groupBox1.Controls.Add(this.txtRefills2);
            this.groupBox1.Controls.Add(this.txtDosage2);
            this.groupBox1.Controls.Add(this.lblIntake2);
            this.groupBox1.Controls.Add(this.txtMedication2);
            this.groupBox1.Controls.Add(this.txtIntake);
            this.groupBox1.Controls.Add(this.lblMedication);
            this.groupBox1.Controls.Add(this.lblRefills);
            this.groupBox1.Controls.Add(this.lblDosage);
            this.groupBox1.Controls.Add(this.txtRefills);
            this.groupBox1.Controls.Add(this.txtDosage);
            this.groupBox1.Controls.Add(this.lblIntake);
            this.groupBox1.Controls.Add(this.txtMedication);
            this.groupBox1.Location = new System.Drawing.Point(334, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 225);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prescription Desc";
            // 
            // txtIntake3
            // 
            this.txtIntake3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtIntake3.ForeColor = System.Drawing.Color.Black;
            this.txtIntake3.Location = new System.Drawing.Point(142, 183);
            this.txtIntake3.Name = "txtIntake3";
            this.txtIntake3.Size = new System.Drawing.Size(60, 20);
            this.txtIntake3.TabIndex = 42;
            // 
            // lblMedication3
            // 
            this.lblMedication3.BackColor = System.Drawing.Color.Gainsboro;
            this.lblMedication3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMedication3.Location = new System.Drawing.Point(6, 147);
            this.lblMedication3.Name = "lblMedication3";
            this.lblMedication3.Size = new System.Drawing.Size(108, 25);
            this.lblMedication3.TabIndex = 41;
            this.lblMedication3.Text = "Other Medication:";
            this.lblMedication3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRefills3
            // 
            this.lblRefills3.BackColor = System.Drawing.Color.Gainsboro;
            this.lblRefills3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRefills3.Location = new System.Drawing.Point(339, 147);
            this.lblRefills3.Name = "lblRefills3";
            this.lblRefills3.Size = new System.Drawing.Size(57, 25);
            this.lblRefills3.TabIndex = 40;
            this.lblRefills3.Text = "Refills:";
            this.lblRefills3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDosage3
            // 
            this.lblDosage3.BackColor = System.Drawing.Color.Gainsboro;
            this.lblDosage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDosage3.Location = new System.Drawing.Point(233, 147);
            this.lblDosage3.Name = "lblDosage3";
            this.lblDosage3.Size = new System.Drawing.Size(69, 25);
            this.lblDosage3.TabIndex = 39;
            this.lblDosage3.Text = "Dosage:";
            this.lblDosage3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRefills3
            // 
            this.txtRefills3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRefills3.ForeColor = System.Drawing.Color.Black;
            this.txtRefills3.Location = new System.Drawing.Point(339, 183);
            this.txtRefills3.Name = "txtRefills3";
            this.txtRefills3.Size = new System.Drawing.Size(57, 20);
            this.txtRefills3.TabIndex = 37;
            // 
            // txtDosage3
            // 
            this.txtDosage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDosage3.ForeColor = System.Drawing.Color.Black;
            this.txtDosage3.Location = new System.Drawing.Point(233, 183);
            this.txtDosage3.Name = "txtDosage3";
            this.txtDosage3.Size = new System.Drawing.Size(69, 20);
            this.txtDosage3.TabIndex = 36;
            // 
            // lblIntake3
            // 
            this.lblIntake3.BackColor = System.Drawing.Color.Gainsboro;
            this.lblIntake3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIntake3.Location = new System.Drawing.Point(142, 147);
            this.lblIntake3.Name = "lblIntake3";
            this.lblIntake3.Size = new System.Drawing.Size(60, 25);
            this.lblIntake3.TabIndex = 38;
            this.lblIntake3.Text = "Intake:";
            this.lblIntake3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMedication3
            // 
            this.txtMedication3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMedication3.ForeColor = System.Drawing.Color.Black;
            this.txtMedication3.Location = new System.Drawing.Point(6, 183);
            this.txtMedication3.Name = "txtMedication3";
            this.txtMedication3.Size = new System.Drawing.Size(108, 20);
            this.txtMedication3.TabIndex = 35;
            // 
            // txtIntake2
            // 
            this.txtIntake2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtIntake2.ForeColor = System.Drawing.Color.Black;
            this.txtIntake2.Location = new System.Drawing.Point(142, 124);
            this.txtIntake2.Name = "txtIntake2";
            this.txtIntake2.Size = new System.Drawing.Size(60, 20);
            this.txtIntake2.TabIndex = 34;
            // 
            // lblMedication2
            // 
            this.lblMedication2.BackColor = System.Drawing.Color.Gainsboro;
            this.lblMedication2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMedication2.Location = new System.Drawing.Point(6, 88);
            this.lblMedication2.Name = "lblMedication2";
            this.lblMedication2.Size = new System.Drawing.Size(108, 25);
            this.lblMedication2.TabIndex = 33;
            this.lblMedication2.Text = "Medication Name:";
            this.lblMedication2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRefills2
            // 
            this.lblRefills2.BackColor = System.Drawing.Color.Gainsboro;
            this.lblRefills2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRefills2.Location = new System.Drawing.Point(339, 88);
            this.lblRefills2.Name = "lblRefills2";
            this.lblRefills2.Size = new System.Drawing.Size(57, 25);
            this.lblRefills2.TabIndex = 32;
            this.lblRefills2.Text = "Refills:";
            this.lblRefills2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDosage2
            // 
            this.lblDosage2.BackColor = System.Drawing.Color.Gainsboro;
            this.lblDosage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDosage2.Location = new System.Drawing.Point(233, 88);
            this.lblDosage2.Name = "lblDosage2";
            this.lblDosage2.Size = new System.Drawing.Size(69, 25);
            this.lblDosage2.TabIndex = 31;
            this.lblDosage2.Text = "Dosage:";
            this.lblDosage2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRefills2
            // 
            this.txtRefills2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRefills2.ForeColor = System.Drawing.Color.Black;
            this.txtRefills2.Location = new System.Drawing.Point(339, 124);
            this.txtRefills2.Name = "txtRefills2";
            this.txtRefills2.Size = new System.Drawing.Size(57, 20);
            this.txtRefills2.TabIndex = 29;
            // 
            // txtDosage2
            // 
            this.txtDosage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDosage2.ForeColor = System.Drawing.Color.Black;
            this.txtDosage2.Location = new System.Drawing.Point(233, 124);
            this.txtDosage2.Name = "txtDosage2";
            this.txtDosage2.Size = new System.Drawing.Size(69, 20);
            this.txtDosage2.TabIndex = 28;
            // 
            // lblIntake2
            // 
            this.lblIntake2.BackColor = System.Drawing.Color.Gainsboro;
            this.lblIntake2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIntake2.Location = new System.Drawing.Point(142, 88);
            this.lblIntake2.Name = "lblIntake2";
            this.lblIntake2.Size = new System.Drawing.Size(60, 25);
            this.lblIntake2.TabIndex = 30;
            this.lblIntake2.Text = "Intake:";
            this.lblIntake2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMedication2
            // 
            this.txtMedication2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMedication2.ForeColor = System.Drawing.Color.Black;
            this.txtMedication2.Location = new System.Drawing.Point(6, 124);
            this.txtMedication2.Name = "txtMedication2";
            this.txtMedication2.Size = new System.Drawing.Size(108, 20);
            this.txtMedication2.TabIndex = 27;
            // 
            // txtIntake
            // 
            this.txtIntake.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtIntake.ForeColor = System.Drawing.Color.Black;
            this.txtIntake.Location = new System.Drawing.Point(142, 65);
            this.txtIntake.Name = "txtIntake";
            this.txtIntake.Size = new System.Drawing.Size(60, 20);
            this.txtIntake.TabIndex = 26;
            // 
            // lblMedication
            // 
            this.lblMedication.BackColor = System.Drawing.Color.Gainsboro;
            this.lblMedication.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMedication.Location = new System.Drawing.Point(6, 29);
            this.lblMedication.Name = "lblMedication";
            this.lblMedication.Size = new System.Drawing.Size(108, 25);
            this.lblMedication.TabIndex = 25;
            this.lblMedication.Text = "Medication Name:";
            this.lblMedication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRefills
            // 
            this.lblRefills.BackColor = System.Drawing.Color.Gainsboro;
            this.lblRefills.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRefills.Location = new System.Drawing.Point(339, 29);
            this.lblRefills.Name = "lblRefills";
            this.lblRefills.Size = new System.Drawing.Size(57, 25);
            this.lblRefills.TabIndex = 24;
            this.lblRefills.Text = "Refills";
            this.lblRefills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDosage
            // 
            this.lblDosage.BackColor = System.Drawing.Color.Gainsboro;
            this.lblDosage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDosage.Location = new System.Drawing.Point(233, 29);
            this.lblDosage.Name = "lblDosage";
            this.lblDosage.Size = new System.Drawing.Size(69, 25);
            this.lblDosage.TabIndex = 23;
            this.lblDosage.Text = "Dosage:";
            this.lblDosage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRefills
            // 
            this.txtRefills.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRefills.ForeColor = System.Drawing.Color.Black;
            this.txtRefills.Location = new System.Drawing.Point(339, 65);
            this.txtRefills.Name = "txtRefills";
            this.txtRefills.Size = new System.Drawing.Size(57, 20);
            this.txtRefills.TabIndex = 7;
            // 
            // txtDosage
            // 
            this.txtDosage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDosage.ForeColor = System.Drawing.Color.Black;
            this.txtDosage.Location = new System.Drawing.Point(233, 65);
            this.txtDosage.Name = "txtDosage";
            this.txtDosage.Size = new System.Drawing.Size(69, 20);
            this.txtDosage.TabIndex = 6;
            // 
            // lblIntake
            // 
            this.lblIntake.BackColor = System.Drawing.Color.Gainsboro;
            this.lblIntake.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIntake.Location = new System.Drawing.Point(142, 29);
            this.lblIntake.Name = "lblIntake";
            this.lblIntake.Size = new System.Drawing.Size(60, 25);
            this.lblIntake.TabIndex = 17;
            this.lblIntake.Text = "Intake:";
            this.lblIntake.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMedication
            // 
            this.txtMedication.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMedication.ForeColor = System.Drawing.Color.Black;
            this.txtMedication.Location = new System.Drawing.Point(6, 65);
            this.txtMedication.Name = "txtMedication";
            this.txtMedication.Size = new System.Drawing.Size(108, 20);
            this.txtMedication.TabIndex = 5;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Gainsboro;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(331, 186);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(110, 16);
            this.lblAmount.TabIndex = 40;
            this.lblAmount.Text = "Amount Charged:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDiagnosis3);
            this.groupBox2.Controls.Add(this.txtDiagnosis3);
            this.groupBox2.Controls.Add(this.lblDiagnosis2);
            this.groupBox2.Controls.Add(this.txtDiagnosis2);
            this.groupBox2.Controls.Add(this.lblDiagnosis);
            this.groupBox2.Controls.Add(this.txtDiagnosis);
            this.groupBox2.Location = new System.Drawing.Point(33, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 225);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diagnosis";
            // 
            // lblDiagnosis3
            // 
            this.lblDiagnosis3.BackColor = System.Drawing.Color.Gainsboro;
            this.lblDiagnosis3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDiagnosis3.Location = new System.Drawing.Point(28, 147);
            this.lblDiagnosis3.Name = "lblDiagnosis3";
            this.lblDiagnosis3.Size = new System.Drawing.Size(108, 25);
            this.lblDiagnosis3.TabIndex = 65;
            this.lblDiagnosis3.Text = "Other Diagnosis:";
            this.lblDiagnosis3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDiagnosis3
            // 
            this.txtDiagnosis3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDiagnosis3.ForeColor = System.Drawing.Color.Black;
            this.txtDiagnosis3.Location = new System.Drawing.Point(142, 152);
            this.txtDiagnosis3.Name = "txtDiagnosis3";
            this.txtDiagnosis3.Size = new System.Drawing.Size(108, 20);
            this.txtDiagnosis3.TabIndex = 59;
            this.txtDiagnosis3.TextChanged += new System.EventHandler(this.txtDiagnosis3_TextChanged);
            // 
            // lblDiagnosis2
            // 
            this.lblDiagnosis2.BackColor = System.Drawing.Color.Gainsboro;
            this.lblDiagnosis2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDiagnosis2.Location = new System.Drawing.Point(28, 88);
            this.lblDiagnosis2.Name = "lblDiagnosis2";
            this.lblDiagnosis2.Size = new System.Drawing.Size(108, 25);
            this.lblDiagnosis2.TabIndex = 57;
            this.lblDiagnosis2.Text = "Diagnosis:";
            this.lblDiagnosis2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDiagnosis2
            // 
            this.txtDiagnosis2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDiagnosis2.ForeColor = System.Drawing.Color.Black;
            this.txtDiagnosis2.Location = new System.Drawing.Point(142, 88);
            this.txtDiagnosis2.Name = "txtDiagnosis2";
            this.txtDiagnosis2.Size = new System.Drawing.Size(108, 20);
            this.txtDiagnosis2.TabIndex = 51;
            this.txtDiagnosis2.TextChanged += new System.EventHandler(this.txtDiagnosis2_TextChanged);
            // 
            // lblDiagnosis
            // 
            this.lblDiagnosis.BackColor = System.Drawing.Color.Gainsboro;
            this.lblDiagnosis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDiagnosis.Location = new System.Drawing.Point(28, 29);
            this.lblDiagnosis.Name = "lblDiagnosis";
            this.lblDiagnosis.Size = new System.Drawing.Size(108, 25);
            this.lblDiagnosis.TabIndex = 49;
            this.lblDiagnosis.Text = "Diagnosis:";
            this.lblDiagnosis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDiagnosis.ForeColor = System.Drawing.Color.Black;
            this.txtDiagnosis.Location = new System.Drawing.Point(142, 29);
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.Size = new System.Drawing.Size(108, 20);
            this.txtDiagnosis.TabIndex = 43;
            this.txtDiagnosis.TextChanged += new System.EventHandler(this.txtDiagnosis_TextChanged);
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.BackColor = System.Drawing.Color.Gainsboro;
            this.lblReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReason.Location = new System.Drawing.Point(30, 186);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(107, 16);
            this.lblReason.TabIndex = 38;
            this.lblReason.Text = "Reason of Visist:";
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.BackColor = System.Drawing.Color.Gainsboro;
            this.lblPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatient.Location = new System.Drawing.Point(29, 116);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(84, 20);
            this.lblPatient.TabIndex = 37;
            this.lblPatient.Text = "Patient ID:";
            // 
            // lblVisists
            // 
            this.lblVisists.AutoSize = true;
            this.lblVisists.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisists.Location = new System.Drawing.Point(287, 17);
            this.lblVisists.Name = "lblVisists";
            this.lblVisists.Size = new System.Drawing.Size(233, 42);
            this.lblVisists.TabIndex = 36;
            this.lblVisists.Text = "Patient Visits";
            // 
            // frmVisits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 569);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtDoctor);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.txtPatient);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.lblVisists);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVisits";
            this.Text = "frmVisits";
            this.Load += new System.EventHandler(this.frmVisits_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtDoctor;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.TextBox txtPatient;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIntake3;
        private System.Windows.Forms.Label lblMedication3;
        private System.Windows.Forms.Label lblRefills3;
        private System.Windows.Forms.Label lblDosage3;
        private System.Windows.Forms.TextBox txtRefills3;
        private System.Windows.Forms.TextBox txtDosage3;
        private System.Windows.Forms.Label lblIntake3;
        private System.Windows.Forms.TextBox txtMedication3;
        private System.Windows.Forms.TextBox txtIntake2;
        private System.Windows.Forms.Label lblMedication2;
        private System.Windows.Forms.Label lblRefills2;
        private System.Windows.Forms.Label lblDosage2;
        private System.Windows.Forms.TextBox txtRefills2;
        private System.Windows.Forms.TextBox txtDosage2;
        private System.Windows.Forms.Label lblIntake2;
        private System.Windows.Forms.TextBox txtMedication2;
        private System.Windows.Forms.TextBox txtIntake;
        private System.Windows.Forms.Label lblMedication;
        private System.Windows.Forms.Label lblRefills;
        private System.Windows.Forms.Label lblDosage;
        private System.Windows.Forms.TextBox txtRefills;
        private System.Windows.Forms.TextBox txtDosage;
        private System.Windows.Forms.Label lblIntake;
        private System.Windows.Forms.TextBox txtMedication;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDiagnosis3;
        private System.Windows.Forms.TextBox txtDiagnosis3;
        private System.Windows.Forms.Label lblDiagnosis2;
        private System.Windows.Forms.TextBox txtDiagnosis2;
        private System.Windows.Forms.Label lblDiagnosis;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Label lblVisists;
    }
}
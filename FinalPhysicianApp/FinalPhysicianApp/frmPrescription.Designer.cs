namespace FinalPhysicianApp
{
    partial class frmPrescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrescription));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbMed = new System.Windows.Forms.ComboBox();
            this.txtMedID = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPhyID = new System.Windows.Forms.TextBox();
            this.txtPatID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblPhysicianForm = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrescID = new System.Windows.Forms.TextBox();
            this.btnClearPresc = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRefills = new System.Windows.Forms.TextBox();
            this.txtDosage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIntake = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Location = new System.Drawing.Point(10, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Medication Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Location = new System.Drawing.Point(10, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Medication ID:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbMed);
            this.groupBox2.Controls.Add(this.txtMedID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(261, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 94);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prescription Order";
            // 
            // cbMed
            // 
            this.cbMed.FormattingEnabled = true;
            this.cbMed.Location = new System.Drawing.Point(117, 59);
            this.cbMed.Name = "cbMed";
            this.cbMed.Size = new System.Drawing.Size(121, 21);
            this.cbMed.TabIndex = 4;
            this.cbMed.SelectedIndexChanged += new System.EventHandler(this.cbMed_SelectedIndexChanged);
            // 
            // txtMedID
            // 
            this.txtMedID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMedID.ForeColor = System.Drawing.Color.Black;
            this.txtMedID.Location = new System.Drawing.Point(116, 19);
            this.txtMedID.Name = "txtMedID";
            this.txtMedID.Size = new System.Drawing.Size(125, 20);
            this.txtMedID.TabIndex = 3;
            this.txtMedID.TextChanged += new System.EventHandler(this.txtMedID_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPhyID);
            this.groupBox3.Controls.Add(this.txtPatID);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(25, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 114);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Presciption Information";
            // 
            // txtPhyID
            // 
            this.txtPhyID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPhyID.ForeColor = System.Drawing.Color.Black;
            this.txtPhyID.Location = new System.Drawing.Point(112, 42);
            this.txtPhyID.Name = "txtPhyID";
            this.txtPhyID.Size = new System.Drawing.Size(96, 20);
            this.txtPhyID.TabIndex = 1;
            // 
            // txtPatID
            // 
            this.txtPatID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPatID.ForeColor = System.Drawing.Color.Black;
            this.txtPatID.Location = new System.Drawing.Point(112, 78);
            this.txtPatID.Name = "txtPatID";
            this.txtPatID.Size = new System.Drawing.Size(96, 20);
            this.txtPatID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(6, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Patient ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Doctor ID";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(158, 241);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(226, 31);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(25, 286);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 9;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblPhysicianForm
            // 
            this.lblPhysicianForm.AutoSize = true;
            this.lblPhysicianForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhysicianForm.Location = new System.Drawing.Point(131, 41);
            this.lblPhysicianForm.Name = "lblPhysicianForm";
            this.lblPhysicianForm.Size = new System.Drawing.Size(321, 31);
            this.lblPhysicianForm.TabIndex = 22;
            this.lblPhysicianForm.Text = "Prescription Fill Out Form";
            this.lblPhysicianForm.Click += new System.EventHandler(this.lblPhysicianForm_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtPrescID);
            this.groupBox4.Controls.Add(this.btnDel);
            this.groupBox4.Location = new System.Drawing.Point(128, 346);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(324, 62);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Prescription Delete:";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Gainsboro;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Presc ID";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrescID
            // 
            this.txtPrescID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrescID.ForeColor = System.Drawing.Color.Black;
            this.txtPrescID.Location = new System.Drawing.Point(69, 32);
            this.txtPrescID.Name = "txtPrescID";
            this.txtPrescID.Size = new System.Drawing.Size(140, 20);
            this.txtPrescID.TabIndex = 11;
            // 
            // btnClearPresc
            // 
            this.btnClearPresc.Location = new System.Drawing.Point(25, 241);
            this.btnClearPresc.Name = "btnClearPresc";
            this.btnClearPresc.Size = new System.Drawing.Size(75, 23);
            this.btnClearPresc.TabIndex = 8;
            this.btnClearPresc.Text = "Clear Presc.";
            this.btnClearPresc.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtRefills);
            this.groupBox1.Controls.Add(this.txtDosage);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtIntake);
            this.groupBox1.Location = new System.Drawing.Point(261, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 99);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prescription Desc";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Gainsboro;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(221, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Refills";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(134, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Dose";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRefills
            // 
            this.txtRefills.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRefills.ForeColor = System.Drawing.Color.Black;
            this.txtRefills.Location = new System.Drawing.Point(221, 65);
            this.txtRefills.Name = "txtRefills";
            this.txtRefills.Size = new System.Drawing.Size(41, 20);
            this.txtRefills.TabIndex = 7;
            // 
            // txtDosage
            // 
            this.txtDosage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDosage.ForeColor = System.Drawing.Color.Black;
            this.txtDosage.Location = new System.Drawing.Point(134, 65);
            this.txtDosage.Name = "txtDosage";
            this.txtDosage.Size = new System.Drawing.Size(41, 20);
            this.txtDosage.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(39, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Intake";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // txtIntake
            // 
            this.txtIntake.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtIntake.ForeColor = System.Drawing.Color.Black;
            this.txtIntake.Location = new System.Drawing.Point(39, 65);
            this.txtIntake.Name = "txtIntake";
            this.txtIntake.Size = new System.Drawing.Size(41, 20);
            this.txtIntake.TabIndex = 5;
            // 
            // frmPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 442);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClearPresc);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblPhysicianForm);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrescription";
            this.Text = "frmPrescription";
            this.Load += new System.EventHandler(this.frmPrescription_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMedID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblPhysicianForm;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrescID;
        private System.Windows.Forms.Button btnClearPresc;
        private System.Windows.Forms.TextBox txtPhyID;
        private System.Windows.Forms.TextBox txtPatID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbMed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRefills;
        private System.Windows.Forms.TextBox txtDosage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIntake;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}
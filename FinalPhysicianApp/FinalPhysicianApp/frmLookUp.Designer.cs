namespace FinalPhysicianApp
{
    partial class frmLookUp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgrPatient = new System.Windows.Forms.DataGridView();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrPhy = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClearTB = new System.Windows.Forms.Button();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPatID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPhyLname = new System.Windows.Forms.TextBox();
            this.txtPhyFname = new System.Windows.Forms.TextBox();
            this.btnPhySearch = new System.Windows.Forms.Button();
            this.txtPhyID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPatVID = new System.Windows.Forms.TextBox();
            this.btnVisitSearch = new System.Windows.Forms.Button();
            this.txtVID = new System.Windows.Forms.TextBox();
            this.dgrVisits = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnJoke = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrPhy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrVisits)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrPatient
            // 
            this.dgrPatient.AllowUserToAddRows = false;
            this.dgrPatient.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.IndianRed;
            this.dgrPatient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgrPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientID,
            this.LNAME,
            this.FNAME,
            this.Gender,
            this.DOB});
            this.dgrPatient.Location = new System.Drawing.Point(12, 153);
            this.dgrPatient.Name = "dgrPatient";
            this.dgrPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrPatient.Size = new System.Drawing.Size(541, 162);
            this.dgrPatient.TabIndex = 3;
            this.dgrPatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrPatient_CellContentClick);
            // 
            // PatientID
            // 
            this.PatientID.DataPropertyName = "Patient_ID";
            this.PatientID.HeaderText = "Patient ID";
            this.PatientID.Name = "PatientID";
            // 
            // LNAME
            // 
            this.LNAME.DataPropertyName = "LNAME";
            this.LNAME.HeaderText = "Last Name";
            this.LNAME.Name = "LNAME";
            // 
            // FNAME
            // 
            this.FNAME.DataPropertyName = "FNAME";
            this.FNAME.HeaderText = "First Name";
            this.FNAME.Name = "FNAME";
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            dataGridViewCellStyle12.Format = "C2";
            dataGridViewCellStyle12.NullValue = null;
            this.Gender.DefaultCellStyle = dataGridViewCellStyle12;
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            // 
            // DOB
            // 
            this.DOB.DataPropertyName = "DOB";
            dataGridViewCellStyle13.Format = "d";
            dataGridViewCellStyle13.NullValue = null;
            this.DOB.DefaultCellStyle = dataGridViewCellStyle13;
            this.DOB.HeaderText = "Date of Birth";
            this.DOB.Name = "DOB";
            // 
            // dgrPhy
            // 
            this.dgrPhy.AllowUserToAddRows = false;
            this.dgrPhy.AllowUserToDeleteRows = false;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.IndianRed;
            this.dgrPhy.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgrPhy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrPhy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgrPhy.Location = new System.Drawing.Point(621, 153);
            this.dgrPhy.Name = "dgrPhy";
            this.dgrPhy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrPhy.Size = new System.Drawing.Size(541, 162);
            this.dgrPhy.TabIndex = 4;
            this.dgrPhy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrPhy_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Doctor_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Physician ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LNAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FNAME";
            this.dataGridViewTextBoxColumn3.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Pri_Field";
            dataGridViewCellStyle15.Format = "C2";
            dataGridViewCellStyle15.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn4.HeaderText = "Field";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CELL_PHONE";
            dataGridViewCellStyle16.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTextBoxColumn5.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // btnClearTB
            // 
            this.btnClearTB.Location = new System.Drawing.Point(371, 97);
            this.btnClearTB.Name = "btnClearTB";
            this.btnClearTB.Size = new System.Drawing.Size(75, 23);
            this.btnClearTB.TabIndex = 6;
            this.btnClearTB.Text = "Clear Table";
            this.btnClearTB.UseVisualStyleBackColor = true;
            this.btnClearTB.Click += new System.EventHandler(this.btnClearTB_Click);
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(102, 127);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(154, 20);
            this.txtLname.TabIndex = 3;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(102, 101);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(154, 20);
            this.txtFname.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(290, 97);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPatID
            // 
            this.txtPatID.Location = new System.Drawing.Point(102, 75);
            this.txtPatID.Name = "txtPatID";
            this.txtPatID.Size = new System.Drawing.Size(154, 20);
            this.txtPatID.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(980, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Clear Table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPhyLname
            // 
            this.txtPhyLname.Location = new System.Drawing.Point(711, 127);
            this.txtPhyLname.Name = "txtPhyLname";
            this.txtPhyLname.Size = new System.Drawing.Size(154, 20);
            this.txtPhyLname.TabIndex = 9;
            // 
            // txtPhyFname
            // 
            this.txtPhyFname.Location = new System.Drawing.Point(711, 101);
            this.txtPhyFname.Name = "txtPhyFname";
            this.txtPhyFname.Size = new System.Drawing.Size(154, 20);
            this.txtPhyFname.TabIndex = 8;
            // 
            // btnPhySearch
            // 
            this.btnPhySearch.Location = new System.Drawing.Point(899, 98);
            this.btnPhySearch.Name = "btnPhySearch";
            this.btnPhySearch.Size = new System.Drawing.Size(75, 23);
            this.btnPhySearch.TabIndex = 10;
            this.btnPhySearch.Text = "Search";
            this.btnPhySearch.UseVisualStyleBackColor = true;
            this.btnPhySearch.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtPhyID
            // 
            this.txtPhyID.Location = new System.Drawing.Point(711, 75);
            this.txtPhyID.Name = "txtPhyID";
            this.txtPhyID.Size = new System.Drawing.Size(154, 20);
            this.txtPhyID.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Last Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Last Digit of ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "First Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(56, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Patient Look up Table";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(665, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(309, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Physician Look up Table";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(621, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "First Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Gainsboro;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(621, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Last Digit of ID";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Gainsboro;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(621, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "Last Name";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Gainsboro;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(324, 436);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 58;
            this.label9.Text = "Patient ID";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Gainsboro;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(324, 410);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 57;
            this.label10.Text = "Visit ID";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Gainsboro;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(368, 375);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(309, 20);
            this.label12.TabIndex = 55;
            this.label12.Text = "Patient Visits Look up Table";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(683, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 54;
            this.button2.Text = "Clear Table";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPatVID
            // 
            this.txtPatVID.Location = new System.Drawing.Point(414, 436);
            this.txtPatVID.Name = "txtPatVID";
            this.txtPatVID.Size = new System.Drawing.Size(154, 20);
            this.txtPatVID.TabIndex = 51;
            // 
            // btnVisitSearch
            // 
            this.btnVisitSearch.Location = new System.Drawing.Point(602, 433);
            this.btnVisitSearch.Name = "btnVisitSearch";
            this.btnVisitSearch.Size = new System.Drawing.Size(75, 23);
            this.btnVisitSearch.TabIndex = 53;
            this.btnVisitSearch.Text = "Search";
            this.btnVisitSearch.UseVisualStyleBackColor = true;
            this.btnVisitSearch.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // txtVID
            // 
            this.txtVID.Location = new System.Drawing.Point(414, 410);
            this.txtVID.Name = "txtVID";
            this.txtVID.Size = new System.Drawing.Size(154, 20);
            this.txtVID.TabIndex = 50;
            // 
            // dgrVisits
            // 
            this.dgrVisits.AllowUserToAddRows = false;
            this.dgrVisits.AllowUserToDeleteRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.IndianRed;
            this.dgrVisits.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgrVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrVisits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dgrVisits.Location = new System.Drawing.Point(324, 488);
            this.dgrVisits.Name = "dgrVisits";
            this.dgrVisits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrVisits.Size = new System.Drawing.Size(541, 162);
            this.dgrVisits.TabIndex = 49;
            this.dgrVisits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrVisits_CellContentClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "VISIT_ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "Visit ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PATIENT_ID";
            this.dataGridViewTextBoxColumn7.HeaderText = "Patient ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "VISITDT";
            dataGridViewCellStyle18.Format = "f";
            dataGridViewCellStyle18.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewTextBoxColumn8.HeaderText = "Visit date";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "VISIT_NOTE";
            dataGridViewCellStyle19.Format = "C2";
            dataGridViewCellStyle19.NullValue = null;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewTextBoxColumn9.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "AMT_CHARGED";
            dataGridViewCellStyle20.Format = "N2";
            dataGridViewCellStyle20.NullValue = null;
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewTextBoxColumn10.HeaderText = "Charged";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // btnJoke
            // 
            this.btnJoke.Location = new System.Drawing.Point(12, 636);
            this.btnJoke.Name = "btnJoke";
            this.btnJoke.Size = new System.Drawing.Size(97, 24);
            this.btnJoke.TabIndex = 59;
            this.btnJoke.Text = "Guide";
            this.btnJoke.UseVisualStyleBackColor = true;
            this.btnJoke.Click += new System.EventHandler(this.btnJoke_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(159, 636);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 24);
            this.button3.TabIndex = 60;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // frmLookUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 672);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnJoke);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtPatVID);
            this.Controls.Add(this.btnVisitSearch);
            this.Controls.Add(this.txtVID);
            this.Controls.Add(this.dgrVisits);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPhyLname);
            this.Controls.Add(this.txtPhyFname);
            this.Controls.Add(this.btnPhySearch);
            this.Controls.Add(this.txtPhyID);
            this.Controls.Add(this.btnClearTB);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtPatID);
            this.Controls.Add(this.dgrPhy);
            this.Controls.Add(this.dgrPatient);
            this.Name = "frmLookUp";
            this.Text = "frmLookUp";
            this.Load += new System.EventHandler(this.frmLookUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrPhy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrVisits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrPatient;
        private System.Windows.Forms.DataGridView dgrPhy;
        private System.Windows.Forms.Button btnClearTB;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPatID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPhyLname;
        private System.Windows.Forms.TextBox txtPhyFname;
        private System.Windows.Forms.Button btnPhySearch;
        private System.Windows.Forms.TextBox txtPhyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn FNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPatVID;
        private System.Windows.Forms.Button btnVisitSearch;
        private System.Windows.Forms.TextBox txtVID;
        private System.Windows.Forms.DataGridView dgrVisits;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button btnJoke;
        private System.Windows.Forms.Button button3;
    }
}
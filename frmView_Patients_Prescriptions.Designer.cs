namespace Final_1
{
    partial class frmView_Patients_Prescriptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmView_Patients_Prescriptions));
            this.dataGridViewPrescriptions = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblViewpatient = new System.Windows.Forms.Label();
            this.txtPatientSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrescriptions)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPrescriptions
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.IndianRed;
            this.dataGridViewPrescriptions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrescriptions.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewPrescriptions.Location = new System.Drawing.Point(12, 163);
            this.dataGridViewPrescriptions.Name = "dataGridViewPrescriptions";
            this.dataGridViewPrescriptions.Size = new System.Drawing.Size(776, 200);
            this.dataGridViewPrescriptions.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmuSearch,
            this.newToolStripMenuItem,
            this.cmuDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 70);
            // 
            // cmuSearch
            // 
            this.cmuSearch.Name = "cmuSearch";
            this.cmuSearch.Size = new System.Drawing.Size(109, 22);
            this.cmuSearch.Text = "Search";
            this.cmuSearch.Click += new System.EventHandler(this.cmuSearch_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // cmuDelete
            // 
            this.cmuDelete.Name = "cmuDelete";
            this.cmuDelete.Size = new System.Drawing.Size(109, 22);
            this.cmuDelete.Text = "Delete";
            this.cmuDelete.Click += new System.EventHandler(this.cmuDelete_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(531, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblViewpatient
            // 
            this.lblViewpatient.AutoSize = true;
            this.lblViewpatient.BackColor = System.Drawing.SystemColors.Control;
            this.lblViewpatient.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewpatient.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblViewpatient.Location = new System.Drawing.Point(297, 25);
            this.lblViewpatient.Name = "lblViewpatient";
            this.lblViewpatient.Size = new System.Drawing.Size(195, 21);
            this.lblViewpatient.TabIndex = 9;
            this.lblViewpatient.Text = "View Patients Perscriptions";
            // 
            // txtPatientSearch
            // 
            this.txtPatientSearch.Location = new System.Drawing.Point(198, 60);
            this.txtPatientSearch.Name = "txtPatientSearch";
            this.txtPatientSearch.Size = new System.Drawing.Size(327, 20);
            this.txtPatientSearch.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtPatientSearch, "Insert patient ID");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(156, 117);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(68, 13);
            this.lblPatientName.TabIndex = 12;
            this.lblPatientName.Text = "PatientName";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(309, 117);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(30, 13);
            this.lblDOB.TabIndex = 13;
            this.lblDOB.Text = "DOB";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(463, 117);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Address";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(702, 117);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 15;
            this.lblPhone.Text = "Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Patient Info:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(341, 390);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 49);
            this.btnClose.TabIndex = 112;
            this.btnClose.Text = "Cancel";
            this.toolTip1.SetToolTip(this.btnClose, "Close form");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmView_Patients_Prescriptions
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(989, 558);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.dataGridViewPrescriptions);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblViewpatient);
            this.Controls.Add(this.txtPatientSearch);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmView_Patients_Prescriptions";
            this.Text = "View_Patients_Prescriptions";
            this.Load += new System.EventHandler(this.View_Patients_Prescriptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrescriptions)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPrescriptions;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblViewpatient;
        private System.Windows.Forms.TextBox txtPatientSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmuSearch;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmuDelete;
    }
}
namespace Final_1
{
    partial class frmViewpatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewpatient));
            this.label3 = new System.Windows.Forms.Label();
            this.txtPatientSearch = new System.Windows.Forms.TextBox();
            this.lblViewpatient = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvPatientdata = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientdata)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPatientSearch
            // 
            this.txtPatientSearch.Location = new System.Drawing.Point(274, 67);
            this.txtPatientSearch.Name = "txtPatientSearch";
            this.txtPatientSearch.Size = new System.Drawing.Size(327, 20);
            this.txtPatientSearch.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtPatientSearch, "Insert Patient Name");
            this.txtPatientSearch.TextChanged += new System.EventHandler(this.txtPatientSearch_TextChanged);
            // 
            // lblViewpatient
            // 
            this.lblViewpatient.AutoSize = true;
            this.lblViewpatient.BackColor = System.Drawing.SystemColors.Control;
            this.lblViewpatient.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewpatient.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblViewpatient.Location = new System.Drawing.Point(404, 28);
            this.lblViewpatient.Name = "lblViewpatient";
            this.lblViewpatient.Size = new System.Drawing.Size(96, 21);
            this.lblViewpatient.TabIndex = 4;
            this.lblViewpatient.Text = "View Patient";
            this.lblViewpatient.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(607, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvPatientdata
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.IndianRed;
            this.dgvPatientdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPatientdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientdata.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPatientdata.Location = new System.Drawing.Point(63, 114);
            this.dgvPatientdata.Name = "dgvPatientdata";
            this.dgvPatientdata.Size = new System.Drawing.Size(776, 206);
            this.dgvPatientdata.TabIndex = 6;
            this.dgvPatientdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatientdata_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.newToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.copyIDToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 114);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // copyIDToolStripMenuItem
            // 
            this.copyIDToolStripMenuItem.Name = "copyIDToolStripMenuItem";
            this.copyIDToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.copyIDToolStripMenuItem.Text = "Copy ID";
            this.copyIDToolStripMenuItem.Click += new System.EventHandler(this.copyIDToolStripMenuItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(388, 393);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 49);
            this.btnClose.TabIndex = 112;
            this.btnClose.Text = "Cancel";
            this.toolTip1.SetToolTip(this.btnClose, "Close form");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmViewpatient
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(989, 558);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvPatientdata);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblViewpatient);
            this.Controls.Add(this.txtPatientSearch);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewpatient";
            this.Text = "View_Patient";
            this.Load += new System.EventHandler(this.Veiw_Patient_Load);
            this.ContextMenuStripChanged += new System.EventHandler(this.searchToolStripMenuItem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientdata)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPatientSearch;
        private System.Windows.Forms.Label lblViewpatient;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvPatientdata;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyIDToolStripMenuItem;
    }
}
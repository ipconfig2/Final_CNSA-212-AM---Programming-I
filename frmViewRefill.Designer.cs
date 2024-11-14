namespace Final_1
{
    partial class frmViewRefill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewRefill));
            this.RefillsDataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblViewpatient = new System.Windows.Forms.Label();
            this.txtViewRefill = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetRefill = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RefillsDataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RefillsDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.IndianRed;
            this.RefillsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.RefillsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RefillsDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.RefillsDataGridView.Location = new System.Drawing.Point(12, 98);
            this.RefillsDataGridView.Name = "RefillsDataGridView";
            this.RefillsDataGridView.Size = new System.Drawing.Size(776, 271);
            this.RefillsDataGridView.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmuSearch});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // cmuSearch
            // 
            this.cmuSearch.Name = "cmuSearch";
            this.cmuSearch.Size = new System.Drawing.Size(180, 22);
            this.cmuSearch.Text = "Search";
            this.cmuSearch.Click += new System.EventHandler(this.cmuSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(531, 57);
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
            this.lblViewpatient.Location = new System.Drawing.Point(354, 20);
            this.lblViewpatient.Name = "lblViewpatient";
            this.lblViewpatient.Size = new System.Drawing.Size(52, 21);
            this.lblViewpatient.TabIndex = 9;
            this.lblViewpatient.Text = "Refills";
            // 
            // txtViewRefill
            // 
            this.txtViewRefill.Location = new System.Drawing.Point(198, 60);
            this.txtViewRefill.Name = "txtViewRefill";
            this.txtViewRefill.Size = new System.Drawing.Size(327, 20);
            this.txtViewRefill.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtViewRefill, "Insert Prescription ID");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // btnGetRefill
            // 
            this.btnGetRefill.Location = new System.Drawing.Point(243, 389);
            this.btnGetRefill.Name = "btnGetRefill";
            this.btnGetRefill.Size = new System.Drawing.Size(163, 53);
            this.btnGetRefill.TabIndex = 12;
            this.btnGetRefill.Text = "Pickup Refill";
            this.toolTip1.SetToolTip(this.btnGetRefill, "Click to log refill pickup");
            this.btnGetRefill.UseVisualStyleBackColor = true;
            this.btnGetRefill.Click += new System.EventHandler(this.btnGetRefill_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(434, 389);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 53);
            this.btnClose.TabIndex = 112;
            this.btnClose.Text = "Cancel";
            this.toolTip1.SetToolTip(this.btnClose, "Close form");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmViewRefill
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(852, 488);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGetRefill);
            this.Controls.Add(this.RefillsDataGridView);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblViewpatient);
            this.Controls.Add(this.txtViewRefill);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewRefill";
            this.Text = "ViewRefill";
            this.Load += new System.EventHandler(this.ViewRefill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RefillsDataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RefillsDataGridView;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblViewpatient;
        private System.Windows.Forms.TextBox txtViewRefill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGetRefill;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmuSearch;
    }
}
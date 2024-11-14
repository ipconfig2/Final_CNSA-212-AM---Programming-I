using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPhysicianApp
{
    public partial class frmLookUp : Form
    {
        public frmLookUp()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string patientid = txtPatID.Text.Trim();
            string fname = txtFname.Text.Trim();
            string lname = txtLname.Text.Trim();

            if (txtPatID.Text.ToString().Trim().Length > 0 || txtLname.Text.ToString().Trim().Length > 0 || txtFname.Text.ToString().Trim().Length > 0)
                try
                {
                    DataSet ds = new DataSet();
                    prescDataTier patDT = new prescDataTier();

                    patientid = txtPatID.Text.Trim();
                    fname = txtFname.Text.Trim();
                    lname = txtLname.Text.Trim();


                    //making sure one field is entered
                    if (patientid == "" && lname == "" && fname == "")
                    {
                        MessageBox.Show("Cannot Leave All Fields Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    ds = patDT.GetPatient(patientid, lname, fname);



                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        dgrPatient.Visible = true;

                        dgrPatient.DataSource = ds.Tables[0];

                        dgrPatient.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
                        dgrPatient.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dgrPatient.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;


                    }
                    else
                    {
                        dgrPatient.Visible = false;
                        MessageBox.Show("No matching patient found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.Source, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void frmLookUp_Load(object sender, EventArgs e)
        {

        }

        private void btnClearTB_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgrPatient.DataSource;
            dt.Clear();
        }

        private void dgrPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string physicianid = txtPhyID.Text.Trim();
            string fname = txtPhyFname.Text.Trim();
            string lname = txtPhyLname.Text.Trim();

            if (txtPhyID.Text.ToString().Trim().Length > 0 || txtPhyLname.Text.ToString().Trim().Length > 0 || txtPhyFname.Text.ToString().Trim().Length > 0)

                    try
                    {
                    DataSet ds = new DataSet();
                    prescDataTier phyDT = new prescDataTier();

                    //making sure one field is entered
                    if (physicianid == "" && lname == "" && fname == "")
                    {
                        MessageBox.Show("Cannot Leave All Fields Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    ds = phyDT.GetPhysician(physicianid, lname, fname);


                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        dgrPhy.Visible = true;

                        dgrPhy.DataSource = ds.Tables[0];

                        dgrPhy.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
                        dgrPhy.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dgrPhy.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;


                    }
                    else
                    {
                        dgrPhy.Visible = false;
                        MessageBox.Show("No matching patient found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.Source, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgrPhy.Rows.Count > 0)
            {
                // Clear the data grid if it has data
                DataTable dt = (DataTable)dgrPhy.DataSource;
                dt.Clear();
                txtPhyID.Text = String.Empty;
            }
            else
            {
                // Show an error message if the data grid is already empty
                MessageBox.Show("There is no data to clear.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgrPhy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }





        private void button3_Click_1(object sender, EventArgs e)
        {
                string Visitid = txtVID.Text.Trim();
                string patvid = txtPatVID.Text.Trim();


                if (txtVID.Text.ToString().Trim().Length > 0 || txtPatID.Text.ToString().Trim().Length > 0 )

                    try
                    {
                        DataSet ds = new DataSet();
                        prescDataTier VDT = new prescDataTier();

                        //making sure one field is entered
                        if (Visitid == "" && patvid == "" )
                        {
                            MessageBox.Show("Cannot Leave All Fields Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }


                        ds = VDT.GetVisits(Visitid, patvid);


                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            dgrVisits.Visible = true;

                        dgrVisits.DataSource = ds.Tables[0];

                        dgrVisits.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
                        dgrVisits.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dgrVisits.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;


                        }
                        else
                        {
                        dgrVisits.Visible = false;
                            MessageBox.Show("No matching patient found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.Source, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            
        }

        private void dgrVisits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgrVisits.Rows.Count > 0)
            {
                // Clear the data grid if it has data
                DataTable dt = (DataTable)dgrVisits.DataSource;
                dt.Clear();
                txtVID.Text = String.Empty;
            }
            else
            {
                // Show an error message if the data grid is already empty
                MessageBox.Show("There is no data to clear.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnJoke_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Enter in P or 1 to search for all data, Enter in exact patient id for specific search, Enter 2 to search for any Patient ID that has a 2 digit in there ID, Change number if needed for search.", "Guide", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

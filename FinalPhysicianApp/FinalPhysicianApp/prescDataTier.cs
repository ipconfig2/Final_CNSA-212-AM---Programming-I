using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using Microsoft.VisualBasic;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Data.SqlClient;
using System.IO;

namespace FinalPhysicianApp
{


    public class prescDataTier2
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        public bool RenewPrescription(int prescID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    //Retrieve prescription details
                    SqlCommand getCommand = new SqlCommand("SELECT * FROM prescriptions WHERE PrescriptionID = @PrescriptionID", connection, transaction);
                    getCommand.Parameters.AddWithValue("@PrescriptionID", prescID);

                    DataTable prescData = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(getCommand))
                    {
                        adapter.Fill(prescData);
                    }

                    if (prescData.Rows.Count == 0)
                        throw new Exception("Prescription not found.");

                    DataRow row = prescData.Rows[0];

                    //new prescription same details (different PrescriptionID)
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO prescriptions (PatientID, PHYSICIANID, MedName, Dosage, IntMethod, DatePrescribed, RefillsLeft) " +
                        "VALUES (@PatientID, @PHYSICIANID, @MedName, @Dosage, @Intake, @DatePrescribed, @Refills);", connection, transaction);

                    insertCommand.Parameters.AddWithValue("@PatientID", row["PatientID"]);
                    insertCommand.Parameters.AddWithValue("@PHYSICIANID", row["PHYSICIANID"]);
                    insertCommand.Parameters.AddWithValue("@MedName", row["MedName"]);
                    insertCommand.Parameters.AddWithValue("@Dosage", row["Dosage"]);
                    insertCommand.Parameters.AddWithValue("@Intake", row["IntMethod"]);
                    insertCommand.Parameters.AddWithValue("@DatePrescribed", row["DatePrescribed"]);
                    insertCommand.Parameters.AddWithValue("@Refills", row["RefillsLeft"]);

                    insertCommand.ExecuteNonQuery();

                    //Delete old prescription
                    SqlCommand deleteCommand = new SqlCommand("DELETE FROM prescriptions WHERE PrescriptionID = @PrescriptionID", connection, transaction);
                    deleteCommand.Parameters.AddWithValue("@PrescriptionID", prescID);

                    deleteCommand.ExecuteNonQuery();

                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }

    public class prescDataTier
    {
        static String connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        static SqlConnection myConn = new SqlConnection(connString);
        static System.Data.SqlClient.SqlCommand cmdString = new System.Data.SqlClient.SqlCommand();
        public DataSet GetPrescription(int? prescid = null, string patientID = null)
        {
            try
            {
                // open connection
                myConn.Open();
                //clear any parameters
                cmdString.Parameters.Clear();
                // command
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;//This is telling us we are calling a stored procedure
                cmdString.CommandTimeout = 1500;


                // Determine the appropriate stored procedure based on parameters
                if (prescid.HasValue)
                {
                    cmdString.CommandText = "GetPrescByID";
                    cmdString.Parameters.Add("@PrescriptionID", SqlDbType.Int).Value = prescid.Value;
                }
                else if (!string.IsNullOrEmpty(patientID))
                {
                    cmdString.CommandText = "GetPrescByPatientID";
                    cmdString.Parameters.Add("@PatientID", SqlDbType.NVarChar).Value = patientID;
                }
                else
                {
                    throw new ArgumentException("Either PrescriptionID or PatientID must be provided.");
                }

                SqlDataAdapter aAdapter = new SqlDataAdapter();

                aAdapter.SelectCommand = cmdString;
                DataSet aDataSet = new DataSet();

                // fill adapater
                aAdapter.Fill(aDataSet);

                //        return dataSet
                return aDataSet;
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }
            finally
            {
                myConn.Close();
            }
        }

        public DataSet GetPatient(string patid, string lname, string fname)
        {


            try
            {
                //open connection
                myConn.Open();

                //clear any parameters
                cmdString.Parameters.Clear();

                cmdString.Connection = myConn; //make the connection
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "GetPatientByID"; //query
                cmdString.Parameters.Add("@patientid", SqlDbType.VarChar, 6).Value = patid;
                cmdString.Parameters.Add("@fname", SqlDbType.VarChar, 6).Value = fname;
                cmdString.Parameters.Add("@lname", SqlDbType.VarChar, 6).Value = lname;


                //cmdString.Parameters.Add("@patientid", SqlDbType.VarChar, 6).Value = string.IsNullOrEmpty(patid) ? (object)DBNull.Value : patid;
                //cmdString.Parameters.Add("@fname", SqlDbType.VarChar, 50).Value = string.IsNullOrEmpty(fname) ? (object)DBNull.Value : fname;
                //cmdString.Parameters.Add("@lname", SqlDbType.VarChar, 50).Value = string.IsNullOrEmpty(lname) ? (object)DBNull.Value : lname;



                SqlDataAdapter pAdapter = new SqlDataAdapter();
                pAdapter.SelectCommand = cmdString;

                DataSet pDataSet = new DataSet();
                // fill adapter
                pAdapter.Fill(pDataSet);
                myConn.Close();
                return pDataSet;

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);

            }
            finally
            {
                myConn.Close();
            }
        }


        public DataSet GetPhysician(string phyid, string lname, string fname)
        {


            try
            {
                //open connection
                myConn.Open();

                //clear any parameters
                cmdString.Parameters.Clear();

                cmdString.Connection = myConn; //make the connection
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "GetPhyByID"; //query
                cmdString.Parameters.Add("@physicianid", SqlDbType.VarChar, 6).Value = phyid;
                cmdString.Parameters.Add("@Phyfname", SqlDbType.VarChar, 6).Value = fname;
                cmdString.Parameters.Add("@Phylname", SqlDbType.VarChar, 6).Value = lname;

                SqlDataAdapter dAdapter = new SqlDataAdapter();
                dAdapter.SelectCommand = cmdString;

                DataSet dDataSet = new DataSet();
                // fill adapter
                dAdapter.Fill(dDataSet);
                myConn.Close();
                return dDataSet;

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);

            }
            finally
            {
                myConn.Close();
            }
        }



        public DataSet GetVisits(string Visitid, string patvid)
        {


            try
            {
                //open connection
                myConn.Open();

                //clear any parameters
                cmdString.Parameters.Clear();

                cmdString.Connection = myConn; //make the connection
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "GetVisitsByID"; //query
                cmdString.Parameters.Add("@vid", SqlDbType.Int).Value = string.IsNullOrEmpty(Visitid) ? (object)DBNull.Value : int.Parse(Visitid);
                cmdString.Parameters.Add("@patvid", SqlDbType.VarChar, 6).Value = string.IsNullOrEmpty(patvid) ? (object)DBNull.Value : patvid;


                SqlDataAdapter vAdapter = new SqlDataAdapter();
                vAdapter.SelectCommand = cmdString;

                DataSet vDataSet = new DataSet();
                // fill adapter
                vAdapter.Fill(vDataSet);
                myConn.Close();
                return vDataSet;

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);

            }
            finally
            {
                myConn.Close();
            }
        }

        public void PatVists(string patid, string reason, string diag1, string diag2, string diag3, 
            string med1, string dos1, string int1, string ref1, string med2, string dos2, string int2, string ref2,
            string med3, string dos3,  string int3,  string ref3,  string docid, Decimal amt)
        {
            try
            {
                // Open connection
                myConn.Open();

                // Clear any existing parameters
                cmdString.Parameters.Clear();

                // Set up command and parameters for the stored procedure
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "PAT_VISIT";

                // Define input parameters
                cmdString.Parameters.Add("@PATIENT_ID", SqlDbType.VarChar, 9).Value = patid;
                cmdString.Parameters.Add("@DOCTOR_ID", SqlDbType.VarChar, 7).Value = docid;
                cmdString.Parameters.Add("@REASON_OF_VISIT", SqlDbType.VarChar, 99).Value = reason;
                cmdString.Parameters.Add("@DIAGNOSIS1", SqlDbType.VarChar, 50).Value = diag1;
                cmdString.Parameters.Add("@DIAGNOSIS2", SqlDbType.VarChar, 50).Value = diag2;
                cmdString.Parameters.Add("@DIAGNOSIS3", SqlDbType.VarChar, 50).Value = diag3;
                cmdString.Parameters.Add("@MedName1", SqlDbType.VarChar, 30).Value = med1;
                cmdString.Parameters.Add("@DOSAGE1", SqlDbType.VarChar, 50).Value = dos1;
                cmdString.Parameters.Add("@IntMethod1", SqlDbType.VarChar, 20).Value = int1;
                cmdString.Parameters.Add("@REFILL1", SqlDbType.VarChar, 30).Value = ref1;
                cmdString.Parameters.Add("@MedName2", SqlDbType.VarChar, 30).Value = med2;
                cmdString.Parameters.Add("@DOSAGE2", SqlDbType.VarChar, 50).Value = dos2;
                cmdString.Parameters.Add("@IntMethod2", SqlDbType.VarChar, 20).Value = int2;
                cmdString.Parameters.Add("@REFILL2", SqlDbType.VarChar, 30).Value = ref2;
                cmdString.Parameters.Add("@MedName3", SqlDbType.VarChar, 30).Value = med3;
                cmdString.Parameters.Add("@DOSAGE3", SqlDbType.VarChar, 50).Value = dos3;
                cmdString.Parameters.Add("@IntMethod3", SqlDbType.VarChar, 20).Value = int3;
                cmdString.Parameters.Add("@REFILL3", SqlDbType.VarChar, 30).Value = ref3;
                cmdString.Parameters.Add("@AMT_CHARGED", SqlDbType.Decimal, 8).Value = amt;

                // Execute the command
                cmdString.ExecuteNonQuery();
                Console.WriteLine("Patient visit record successfully added.");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("A database error occurred: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid input format: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
            finally
            {
                // Ensure connection is closed
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }

    }
}

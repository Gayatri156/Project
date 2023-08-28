using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTSIMSLibrary.Trainer
{
    public class ClsBatchManagement
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-AP5681V\\SQLEXPRESS;Initial Catalog=IMS-PROJECT;Integrated Security=True");

        public string BatchName { get; set; }
        public int CourseId { get; set; }
        public string StaffCode { get; set; }
        public string StudCode { get; set; }
        public int TotalStudent { get; set; }
        public string BatchSTime { get; set; }

        public string BatchEndTime { get; set; }

        public int LabId { get; set; }

        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int  StatusId { get; set; }
        public int BatchId { get; set; }

        public ClsBatchManagement()
        {
            
        }
        public ClsBatchManagement(int SelectedId)
        {
            BatchId=SelectedId;
        }
        public ClsBatchManagement(string BName,int CourseId, string StaffCode, string StudCode, int TotalStudent, string BatchSTime,
                                  string BatchEndTime, int LabId, string StartDate, string EndDate, int statusId)
        {
            this.BatchName = BName;
            this.CourseId = CourseId;
            this.StaffCode = StaffCode;
            this.StudCode = StudCode;
            this.TotalStudent = TotalStudent;
            this.BatchSTime = BatchSTime;
            this.BatchEndTime = BatchEndTime;
            this.LabId = LabId;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.StatusId = statusId;

        }
          
        public void CreateBatch()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("BatchManagementProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "CreateBatch");
            cmd.Parameters.AddWithValue("@BatchName", BatchName);
            cmd.Parameters.AddWithValue("@CourseId", CourseId);
            cmd.Parameters.AddWithValue("@StaffCode", StaffCode);
            cmd.Parameters.AddWithValue("@StudCode", StudCode);
            cmd.Parameters.AddWithValue("@TotalStudent", TotalStudent);
            cmd.Parameters.AddWithValue("@BatchSTime", BatchSTime);
            cmd.Parameters.AddWithValue("@BatchEndTime", BatchEndTime);
            cmd.Parameters.AddWithValue("@LabId", LabId);
            cmd.Parameters.AddWithValue("@StartDate", StartDate);
            cmd.Parameters.AddWithValue("@EndDate", EndDate);
            cmd.Parameters.AddWithValue("@StatusId", StatusId);

            cmd.ExecuteNonQuery();
                
            con.Close();

        }



        public DataTable GetLab()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("BatchManagementProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetLab");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }

        public DataTable GetCourse()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("BatchManagementProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Get_Course");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }

        public DataTable GetBatchStatus()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("BatchManagementProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "BatchStatus");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }

        public DataTable GetStaff()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("BatchManagementProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetStaff");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }

        public DataTable StudentList()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("BatchManagementProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetStudentList");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }

        public DataTable GetAllBatchDetails()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("BatchManagementProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetAllBatchDetails");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }

        public SqlDataReader GetBatchDetailsByID()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("BatchManagementProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetBatchDetailsById");
            cmd.Parameters.AddWithValue("@BatchId", BatchId);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;


        }


    }
}

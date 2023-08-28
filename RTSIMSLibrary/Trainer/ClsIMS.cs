using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RTSIMSLibrary.Trainer
{
    public class ClsIMS
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-AP5681V\\SQLEXPRESS;Initial Catalog=IMS-PROJECT;Integrated Security=True");

        public string Test_Name { get; set; }
        public int CourseId { get; set; }
        public int TopicId { get; set; }
        public int SelectedTestId { get; set; }
        public DateTime TestCreationDate { get; set; }
        public int TotalMarks { get; set; }
        public string Duration { get; set; }
        public byte[] SelectFile { get; set; }

        public int selectedCourseId { get; set; }


        public string AssignTestDate { get; set; }
        public int SelectedBatchId { get; set; }
        public int SelectedLabId { get; set; }
        public int SelectedStatusId { get; set; }
        public string SelectedMonitoringStaffCode { get; set; }


        public ClsIMS(int SelectedTestId, string AssignTestDate, int SelectedBatchId, int SelectedLabId, int SelectedStatusId, string SelectedMonitoringStaffCode)
        {
            this.SelectedTestId = SelectedTestId;
            this.AssignTestDate = AssignTestDate;
            this.SelectedBatchId = SelectedBatchId;
            this.SelectedLabId = SelectedLabId;
            this.SelectedStatusId = SelectedStatusId;
            this.SelectedMonitoringStaffCode = SelectedMonitoringStaffCode;
        }
        public ClsIMS()
        {
            
        }

        public ClsIMS(int selectedId)
        {
            this.selectedCourseId= selectedId;
            SelectedTestId = selectedId;
            SelectedBatchId= selectedId;
            SelectedTestId= selectedId;
            SelectedLabId= selectedId;
        }
        public ClsIMS(string Test_Name, int CourseId, int TopicId, DateTime TestCreationDate, int TotalMarks, string Duration)
        {
            this.Test_Name = Test_Name;
            this.CourseId = CourseId;
            this.TopicId = TopicId;
            this.TestCreationDate = TestCreationDate;
            this.TotalMarks = TotalMarks;
            this.Duration = Duration;
           // this.SelectFile = SelectFile;

        }

      




        public void Create_Test()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Test_Management_Procedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Create_Test");
            cmd.Parameters.AddWithValue("@Test_Name", Test_Name);
            cmd.Parameters.AddWithValue("@CourseId", CourseId);
            cmd.Parameters.AddWithValue("@TopicId", TopicId);
            cmd.Parameters.AddWithValue("@TestCreationDate", TestCreationDate);
            cmd.Parameters.AddWithValue("@TotalMarks", TotalMarks);
            cmd.Parameters.AddWithValue("@Duration", Duration);

            cmd.ExecuteNonQuery();

            con.Close();

        }
       


       
        public void Assign_Test()
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("Test_Management_Procedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Assign_Test");
            cmd.Parameters.AddWithValue("@SelectedTestId", SelectedTestId);
            cmd.Parameters.AddWithValue("@AssignTestDate", AssignTestDate);
            cmd.Parameters.AddWithValue("@SelectedBatchId", SelectedBatchId);
            cmd.Parameters.AddWithValue("@SelectedLabId", SelectedLabId);
            cmd.Parameters.AddWithValue("@SelectedStatusId", SelectedStatusId);
            cmd.Parameters.AddWithValue("@SelectedMonitoringStaffCode", SelectedMonitoringStaffCode);

            cmd.ExecuteNonQuery();

            con.Close();

        }

        public DataTable GetCourse()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Test_Management_Procedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Get_Course");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable GetTopic()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Test_Management_Procedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Get_Topic");
            cmd.Parameters.AddWithValue("@SelectedCourseId", selectedCourseId);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }


        public DataTable GetBatch()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Test_Management_Procedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetBatch");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }

        public DataTable GetTestName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Test_Management_Procedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetTestName");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }

        public DataTable GetLab()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Test_Management_Procedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetLab");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }

        public DataTable GetMonitoringStaff()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Test_Management_Procedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetMonitoringStaff");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }

        public DataTable GetTestStatus()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Test_Management_Procedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "TestStatus");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }


        public DataTable GetDataToDashboard()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Test_Management_Procedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetDataToDatagrid");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable GetDataToDashboardByCourseName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Test_Management_Procedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag","GetDataToDatagridByCourseName");
            cmd.Parameters.AddWithValue("@SelectedCourseId", selectedCourseId);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable GetDataToDashboardByBatchName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Test_Management_Procedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetDataToDatagridByBatchName");
            cmd.Parameters.AddWithValue("@SelectedBatchId", SelectedBatchId);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable GetDataToDashboardByTestName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Test_Management_Procedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetDataToDatagridByTestName");
            cmd.Parameters.AddWithValue("@SelectedTestId", SelectedTestId);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable GetDataToDashboardByLabName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Test_Management_Procedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetDataToDatagridByLabName");
            cmd.Parameters.AddWithValue("@SelectedLabId", SelectedLabId);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public SqlDataReader TestDetails()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Test_Management_Procedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "TestDetails");
            cmd.Parameters.AddWithValue("@SelectedTestId", SelectedTestId);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;


        }



    }
}

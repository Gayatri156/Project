using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RTSIMSLibrary.Trainer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IMS
{
    public partial class FrmAssignTest : Form
    {
        public FrmAssignTest()
        {
            InitializeComponent();
        }

        private void FrmAssignTest_Load(object sender, EventArgs e)
        {
            ClsIMS clsIMS = new ClsIMS();
            DataTable dt = clsIMS.GetBatch();
            cmbbxBatchName.ValueMember = "BatchId";
            cmbbxBatchName.DisplayMember = "BatchName";
            cmbbxBatchName.DataSource= dt;

            DataTable dt1 = clsIMS.GetLab();
            cmbbxLab.ValueMember = "LabId";
            cmbbxLab.DisplayMember = "LabName";
            cmbbxLab.DataSource = dt1;

            DataTable dt2 = clsIMS.GetMonitoringStaff();
            cmbbxMonitoringStaff.ValueMember = "StaffCode";
            cmbbxMonitoringStaff.DisplayMember = "StaffName";
            cmbbxMonitoringStaff.DataSource = dt2;

            DataTable dt3 = clsIMS.GetTestStatus();
            cmbbxStatus.ValueMember = "StatusID";
            cmbbxStatus.DisplayMember = "StatusName";
            cmbbxStatus.DataSource = dt3;
        }

        private void cmbbxBatchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsIMS clsIMS = new ClsIMS();
            DataTable dt1 = clsIMS.GetTestName();
            cmbbxTestName.ValueMember = "TestId";
            cmbbxTestName.DisplayMember = "TestName";
            cmbbxTestName.DataSource = dt1;
        }

        private void cmbbxTestName_SelectedIndexChanged(object sender, EventArgs e)
        {

            ClsIMS clsIMS = new ClsIMS(int.Parse(cmbbxTestName.SelectedValue.ToString()));
            SqlDataReader reader = clsIMS.TestDetails();
            while (reader.Read())
            {
                lblDurationIP.Text = reader["Duration"].ToString();
                lblTopicNameIP.Text = reader["TopicName"].ToString();
                lblTotalMarksIP.Text = reader["TotalMarks"].ToString();
               
            }

        }

        private void btnCreateTest_Click(object sender, EventArgs e)
        {
            int testNameId = int.Parse(cmbbxTestName.SelectedValue.ToString());
            string AssignTestDate = dtpickerAssignTest.Text.ToString();
            int BatchNameId = int.Parse(cmbbxBatchName.SelectedValue.ToString());
            int LabId = int.Parse(cmbbxLab.SelectedValue.ToString());
            int statusId = int.Parse(cmbbxStatus.SelectedValue.ToString());
            string StaffCode = cmbbxMonitoringStaff.SelectedValue.ToString();

            ClsIMS clsIMS = new ClsIMS(testNameId, AssignTestDate, BatchNameId,LabId, statusId, StaffCode);
            clsIMS.Assign_Test();
            MessageBox.Show("Test Assigned SuccessFully");
        }
    }
}

using RTSIMSLibrary.Trainer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class FrmEditBatch : Form
    {
        public int BatchId { get; set; }
        public FrmEditBatch(int BatchId)
        {
            InitializeComponent();
            this.BatchId = BatchId;
        }

        private void FrmEditBatch_Load(object sender, EventArgs e)
        {
            ClsBatchManagement clsBatchManagement1 = new ClsBatchManagement();

            DataTable dtLab = clsBatchManagement1.GetLab();
            cmbbxLabName.ValueMember = "LabId";
            cmbbxLabName.DisplayMember = "LabName";
            cmbbxLabName.DataSource = dtLab;

            DataTable dtStatus = clsBatchManagement1.GetBatchStatus();
            cmbbxBatchStatus.ValueMember = "StatusID";
            cmbbxBatchStatus.DisplayMember = "StatusName";
            cmbbxBatchStatus.DataSource = dtStatus;

            DataTable dtCourse = clsBatchManagement1.GetCourse();
            cmbbxCourse.ValueMember = "CourseId";
            cmbbxCourse.DisplayMember = "CourseTypeName";
            cmbbxCourse.DataSource = dtCourse;

            DataTable dtstaff = clsBatchManagement1.GetStaff();
            cmbbxStaff.ValueMember = "StaffCode";
            cmbbxStaff.DisplayMember = "StaffName";
            cmbbxStaff.DataSource = dtstaff;

            DataTable dtStudentList = clsBatchManagement1.StudentList();
            ((ListBox)checkedListBoxStudent).DataSource = dtStudentList;
            ((ListBox)checkedListBoxStudent).DisplayMember = "StudFullName";
            ((ListBox)checkedListBoxStudent).ValueMember = "StudCode";


            ClsBatchManagement clsBatchManagement = new ClsBatchManagement(BatchId);
            SqlDataReader reader = clsBatchManagement.GetBatchDetailsByID();
            while (reader.Read())
            {
                txtbxBatchName.Text = reader["BatchName"].ToString();

               // string s= reader["CourseTypeName"].ToString();
                //cmbbxCourse.Text=   (reader["CourseTypeName"].ToString());
                //cmbbxLabName.SelectedValue = reader["LabId"].ToString();
                //cmbbxStaff.SelectedValue = reader["StaffCode"].ToString();
                //cmbbxBatchStatus.SelectedValue= reader["StatusId"].ToString();

                dateTimePickerStartDate.Text= reader["StartDate"].ToString();
                dateTimePickerEndDate.Text= reader["EndDate"].ToString();


                txtbxStartTime.Text = reader["BatchSTime"].ToString();
                txtbxBatchEndTime.Text = reader["BatchEndTime"].ToString();
               
                lblNumberofStudents.Text= reader["TotalStudent"].ToString();



                //string bname = txtbxBatchName.Text.ToString();
                //int CID = int.Parse(cmbbxCourse.SelectedValue.ToString());
                //string StaffCode = cmbbxStaff.SelectedValue.ToString();
                //string Stime = txtbxStartTime.Text.ToString();
                //string Etime = txtbxBatchEndTime.Text.ToString();
                //int labId = int.Parse(cmbbxLabName.SelectedValue.ToString());
                //string Sdate = dateTimePickerStartDate.Text.ToString();
                //string Edate = dateTimePickerEndDate.Text.ToString();
                //int StatusId = int.Parse(cmbbxBatchStatus.SelectedValue.ToString());


            }

        }

        private void btnCreateBatch_Click(object sender, EventArgs e)
        {

        }

        private void btnShowStudentList_Click(object sender, EventArgs e)
        {
            checkedListBoxStudent.Visible = true;
        }
        StringBuilder sb=new StringBuilder();
        private void buttonDemo_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBoxStudent.CheckedItems)
            {
                var row = (item as DataRowView).Row;

                sb.Append(row["StudCode"].ToString());
                sb.Append(",");



            }
            sb.Remove(sb.Length - 1, 1);
            string jn = sb.ToString();

            lblNumberofStudents.Text = checkedListBoxStudent.CheckedItems.Count.ToString();


            string al = checkedListBoxStudent.SelectedItems.ToString();
            // lstbxstudentAddedToBatch.Items.Add();
            lstbxstudentAddedToBatch.Items.Clear();
            foreach (var item in checkedListBoxStudent.CheckedItems)
            {
                var row = (item as DataRowView).Row;

                lstbxstudentAddedToBatch.Items.Add(row["StudFullName"]);

            }
        }
    }
}

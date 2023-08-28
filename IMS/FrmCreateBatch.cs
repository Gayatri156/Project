using RTSIMSLibrary.Trainer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class FrmCreateBatch : Form
    {
        public FrmCreateBatch()
        {
            InitializeComponent();
        }

        private void FrmCreateBatch_Load(object sender, EventArgs e)
        {
            ClsBatchManagement clsBatchManagement = new ClsBatchManagement();
           
            DataTable dtLab = clsBatchManagement.GetLab();
            cmbbxLabName.ValueMember = "LabId";
            cmbbxLabName.DisplayMember = "LabName";
            cmbbxLabName.DataSource = dtLab;

            DataTable dtStatus = clsBatchManagement.GetBatchStatus();
            cmbbxBatchStatus.ValueMember = "StatusID";
            cmbbxBatchStatus.DisplayMember = "StatusName";
            cmbbxBatchStatus.DataSource = dtStatus;

            DataTable dtCourse = clsBatchManagement.GetCourse();
            cmbbxCourse.ValueMember = "CourseId";
            cmbbxCourse.DisplayMember = "CourseTypeName";
            cmbbxCourse.DataSource = dtCourse;

            DataTable dtstaff = clsBatchManagement.GetStaff();
            cmbbxStaff.ValueMember = "StaffCode";
            cmbbxStaff.DisplayMember = "StaffName";
            cmbbxStaff.DataSource = dtstaff;

            DataTable dtStudentList = clsBatchManagement.StudentList();
            ((ListBox)checkedListBoxStudent).DataSource = dtStudentList;
            ((ListBox)checkedListBoxStudent).DisplayMember = "StudFullName";
            ((ListBox)checkedListBoxStudent).ValueMember = "StudCode";

            //DataColumn dataColumn = new DataColumn("StudCode",typeof(string));
            //dtStudentList.Columns.Add(dataColumn);

            //DataRow dataRow= dtStudentList.NewRow();
            //dtStudentList.Rows.Add(dataRow);


            // checkedListBoxStudent



            //for (int i = 0; i < dtStudentList.Rows.Count; i++)
            //{
            //  //  checkedListBoxStudent.Items.Add(dtStudentList.Rows[i]["StudCode"].ToString());
            //    checkedListBoxStudent.Items.Add(dtStudentList.Rows[i]["StudFullName"].ToString());

            //}

           
            
        }

        private void btnShowStudentList_Click(object sender, EventArgs e)
        {
            checkedListBoxStudent.Visible= true;
        }
        
        private void checkedListBoxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
          
        
        }

        private void btnCreateBatch_Click(object sender, EventArgs e)
        {

                      string bname = txtbxBatchName.Text.ToString();
                      int CID = int.Parse(cmbbxCourse.SelectedValue.ToString());
                      string StaffCode = cmbbxStaff.SelectedValue.ToString();
                      string Stime = txtbxStartTime.Text.ToString();
                      string Etime = txtbxBatchEndTime.Text.ToString();
                      int labId = int.Parse(cmbbxLabName.SelectedValue.ToString());
                      string Sdate= dateTimePickerStartDate.Text.ToString();
                      string Edate= dateTimePickerEndDate.Text.ToString();
                      int StatusId= int.Parse(cmbbxBatchStatus.SelectedValue.ToString());

            ClsBatchManagement clsBatchManagement = new ClsBatchManagement(bname, CID, StaffCode,sb.ToString(), int.Parse(checkedListBoxStudent.CheckedItems.Count.ToString()), Stime, Etime, labId,Sdate, Edate, StatusId);
            clsBatchManagement.CreateBatch();
            MessageBox.Show("Batch Created Successfully");
        }
        StringBuilder sb = new StringBuilder();
       ArrayList al= new ArrayList();
        private void SelectedVAlueChanged(object sender, EventArgs e)
        {
           
            
           
            //foreach (var item in checkedListBoxStudent.CheckedItems)
            //{
            //    var row = (item as DataRowView).Row;
               
            //    sb.Append(row["StudCode"].ToString());
            //    sb.Append(",");
               
            //}
            //string jn = sb.ToString();

            //lblNumberofStudents.Text = checkedListBoxStudent.CheckedItems.Count.ToString();

        }

       // StringBuilder sdc = new StringBuilder();
        private void buttonDemo_Click(object sender, EventArgs e)
        {

            foreach (var item in checkedListBoxStudent.CheckedItems)
            {
                var row = (item as DataRowView).Row;

                sb.Append(row["StudCode"].ToString());
                sb.Append(",");

                

            }
            sb.Remove(sb.Length-1,1);
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

        private void cmbbxStaff_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cmbbxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void lstbxstudentAddedToBatch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lblNumberofStudents_Click(object sender, EventArgs e)
        {

        }

        private void cmbbxBatchStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerEndDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerStartDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtbxStartTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxBatchEndTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxBatchName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblBatchStartTime_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbbxLabName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
                                                       

}

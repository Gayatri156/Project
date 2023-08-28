using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RTSIMSLibrary.Trainer;

namespace IMS
{
    public partial class FrmTestManagement : Form
    {
        public FrmTestManagement()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void FrmTestManagement_Load(object sender, EventArgs e)
        {
            ClsIMS clsIMS = new ClsIMS();
            DataTable dt = clsIMS.GetDataToDashboard();
            datagridOnDashBoard.DataSource = dt;

          

        }

        private void btnNewTest_Click(object sender, EventArgs e)
        {
            FrmCreateTest frmCreateTest = new FrmCreateTest();
            frmCreateTest.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmCreateTest frmCreateTest = new FrmCreateTest();
            frmCreateTest.Show();
        }

        private void btnAssignTest_Click(object sender, EventArgs e)
        {
            FrmAssignTest frmAssignTest = new FrmAssignTest();
            frmAssignTest.Show();
        }

        private void cmbbxCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsIMS clsIMS = new ClsIMS(int.Parse(cmbbxCourseName.SelectedValue.ToString()));
            DataTable dtbl = clsIMS.GetDataToDashboardByCourseName();
            datagridOnDashBoard.DataSource = dtbl;
        }

        private void cmbbxBatchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsIMS clsIMS = new ClsIMS(int.Parse(cmbbxBatchName.SelectedValue.ToString()));
            DataTable dtbl = clsIMS.GetDataToDashboardByBatchName();
            datagridOnDashBoard.DataSource = dtbl;

        }

        private void cmbbxTestName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsIMS clsIMS = new ClsIMS(int.Parse(cmbbxTestName.SelectedValue.ToString()));
            DataTable dtbl = clsIMS.GetDataToDashboardByTestName();
            datagridOnDashBoard.DataSource = dtbl;
        }

        private void datagridOnDashBoard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //FrmEditTest frmEditTest= new FrmEditTest();
            //frmEditTest.Show();

            //if (e.ColumnIndex == 1)
            //{
            //    string CourseName = datagridOnDashBoard.CurrentRow.Cells[2].Value.ToString();
            //    string TestName = int.Parse(dataGridViewOrdered.CurrentRow.Cells[1].Value.ToString());
            //    int OId = int.Parse(dataGridViewOrdered.CurrentRow.Cells[9].Value.ToString());
            //    OfferForm offerForm = new OfferForm(PName, Pprice, OId);
            //    offerForm.Show();

            //}
        }

        private void cmbbxLab_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsIMS clsIMS = new ClsIMS(int.Parse(cmbbxLab.SelectedValue.ToString()));
            DataTable dtbl = clsIMS.GetDataToDashboardByLabName();
            datagridOnDashBoard.DataSource = dtbl;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ClsIMS clsIMS = new ClsIMS();

            panelFilter.Visible = true;


            DataTable dt1 = clsIMS.GetBatch();
            cmbbxBatchName.ValueMember = "BatchId";
            cmbbxBatchName.DisplayMember = "BatchName";
            cmbbxBatchName.DataSource = dt1;

            DataTable dt2 = clsIMS.GetLab();
            cmbbxLab.ValueMember = "LabId";
            cmbbxLab.DisplayMember = "LabName";
            cmbbxLab.DataSource = dt2;


            DataTable dt3 = clsIMS.GetCourse();
            cmbbxCourseName.ValueMember = "CourseId";
            cmbbxCourseName.DisplayMember = "CourseTypeName";
            cmbbxCourseName.DataSource = dt3;


            DataTable dt4 = clsIMS.GetTestName();
            cmbbxTestName.ValueMember = "TestId";
            cmbbxTestName.DisplayMember = "TestName";
            cmbbxTestName.DataSource = dt4;
        }

        private void courseSelecetdChange(object sender, EventArgs e)
        {
          
        }

        private void SelectedValueLab(object sender, EventArgs e)
        {
           

        }

        private void BatchSelectedValue(object sender, EventArgs e)
        {
           
        }

        private void SelectedTestName(object sender, EventArgs e)
        {
           
        }
    }
}

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
    public partial class FrmCreateTest : Form
    {
        public FrmCreateTest()
        {
            InitializeComponent();
        }

        private void FrmCreateTest_Load(object sender, EventArgs e)
        {
            ClsIMS clsIMS = new ClsIMS();
            DataTable dt = clsIMS.GetCourse();
            cmbbxCourseName.ValueMember = "CourseId";
            cmbbxCourseName.DisplayMember = "CourseTypeName";
            cmbbxCourseName.DataSource = dt;

        }

        private void cmbbxCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            ClsIMS clsIMS = new ClsIMS(int.Parse(cmbbxCourseName.SelectedValue.ToString()));
            DataTable dtbl = clsIMS.GetTopic();
            cmbbxTopicName.ValueMember = "TopicId";
            cmbbxTopicName.DisplayMember = "TopicName";
            cmbbxTopicName.DataSource = dtbl;
        }

        private void cmbbxTopicName_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnCreateTest_Click(object sender, EventArgs e)
        {
            DateTime dtime = DateTime.Now;
            string tname = txtbxTestName.Text.ToString();
            int cid = int.Parse(cmbbxCourseName.SelectedValue.ToString());
            int tid = int.Parse(cmbbxTopicName.SelectedValue.ToString());
            int marks = int.Parse(txtbxTotalMarks.Text.ToString());
            string Duration= txtbxDuration.Text.ToString();
            ClsIMS clsIMS = new ClsIMS(tname, cid, tid, dtime, marks, Duration);
            clsIMS.Create_Test();
            MessageBox.Show("Test Created SuccessFully");
                
        }
    }
}   

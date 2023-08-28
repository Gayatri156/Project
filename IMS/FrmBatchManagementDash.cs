using RTSIMSLibrary.Trainer;
using System;
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
    public partial class FrmBatchManagementDash : Form
    {
        public FrmBatchManagementDash()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCreateBatch frm = new FrmCreateBatch();
            frm.Show();
        }

        private void FrmBatchManagementDash_Load(object sender, EventArgs e)
        {
            ClsBatchManagement clsBatchManagement = new ClsBatchManagement();
            DataTable dt = clsBatchManagement.GetAllBatchDetails();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //string PName = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                //int Pprice = int.Parse(dataGridViewOrdered.CurrentRow.Cells[7].Value.ToString());
                //int OId = int.Parse(dataGridViewOrdered.CurrentRow.Cells[9].Value.ToString());
                //OfferForm offerForm = new OfferForm(PName, Pprice, OId);
                //offerForm.Show();
                int BatchId = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                FrmEditBatch frm = new FrmEditBatch(BatchId);
                frm.Show();

            }
        }
    }
}

namespace IMS
{
    partial class FrmTestManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbxSearch = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnNewTest = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picbxFilter = new System.Windows.Forms.PictureBox();
            this.btnAssignTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbbxCourseName = new System.Windows.Forms.ComboBox();
            this.cmbbxBatchName = new System.Windows.Forms.ComboBox();
            this.cmbbxLab = new System.Windows.Forms.ComboBox();
            this.cmbbxTestName = new System.Windows.Forms.ComboBox();
            this.datagridOnDashBoard = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.panelFilter = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridOnDashBoard)).BeginInit();
            this.panelFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IMS.Properties.Resources.download__1_;
            this.pictureBox1.Location = new System.Drawing.Point(455, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtbxSearch
            // 
            this.txtbxSearch.Location = new System.Drawing.Point(505, 61);
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.Size = new System.Drawing.Size(216, 26);
            this.txtbxSearch.TabIndex = 1;
            this.txtbxSearch.Text = "Search";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::IMS.Properties.Resources.download_;
            this.pictureBox2.Location = new System.Drawing.Point(808, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnNewTest
            // 
            this.btnNewTest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNewTest.Location = new System.Drawing.Point(843, 61);
            this.btnNewTest.Name = "btnNewTest";
            this.btnNewTest.Size = new System.Drawing.Size(128, 45);
            this.btnNewTest.TabIndex = 3;
            this.btnNewTest.Text = "New Test";
            this.btnNewTest.UseVisualStyleBackColor = false;
            this.btnNewTest.Click += new System.EventHandler(this.btnNewTest_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::IMS.Properties.Resources.Delete;
            this.pictureBox3.Location = new System.Drawing.Point(1004, 61);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // picbxFilter
            // 
            this.picbxFilter.Image = global::IMS.Properties.Resources.F;
            this.picbxFilter.Location = new System.Drawing.Point(1086, 61);
            this.picbxFilter.Name = "picbxFilter";
            this.picbxFilter.Size = new System.Drawing.Size(56, 45);
            this.picbxFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbxFilter.TabIndex = 5;
            this.picbxFilter.TabStop = false;
            this.picbxFilter.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // btnAssignTest
            // 
            this.btnAssignTest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAssignTest.Location = new System.Drawing.Point(1176, 61);
            this.btnAssignTest.Name = "btnAssignTest";
            this.btnAssignTest.Size = new System.Drawing.Size(111, 45);
            this.btnAssignTest.TabIndex = 6;
            this.btnAssignTest.Text = "Assign Test";
            this.btnAssignTest.UseVisualStyleBackColor = false;
            this.btnAssignTest.Click += new System.EventHandler(this.btnAssignTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Course Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(587, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Test Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(587, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lab";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Batch Name";
            // 
            // cmbbxCourseName
            // 
            this.cmbbxCourseName.Font = new System.Drawing.Font("Century", 10F);
            this.cmbbxCourseName.FormattingEnabled = true;
            this.cmbbxCourseName.Location = new System.Drawing.Point(249, 14);
            this.cmbbxCourseName.Name = "cmbbxCourseName";
            this.cmbbxCourseName.Size = new System.Drawing.Size(217, 31);
            this.cmbbxCourseName.TabIndex = 11;
            this.cmbbxCourseName.Text = "-- Select --";
            this.cmbbxCourseName.SelectedIndexChanged += new System.EventHandler(this.cmbbxCourseName_SelectedIndexChanged);
            this.cmbbxCourseName.SelectedValueChanged += new System.EventHandler(this.courseSelecetdChange);
            // 
            // cmbbxBatchName
            // 
            this.cmbbxBatchName.Font = new System.Drawing.Font("Century", 10F);
            this.cmbbxBatchName.FormattingEnabled = true;
            this.cmbbxBatchName.Location = new System.Drawing.Point(249, 79);
            this.cmbbxBatchName.Name = "cmbbxBatchName";
            this.cmbbxBatchName.Size = new System.Drawing.Size(217, 31);
            this.cmbbxBatchName.TabIndex = 12;
            this.cmbbxBatchName.Text = "-- Select --";
            this.cmbbxBatchName.SelectedIndexChanged += new System.EventHandler(this.cmbbxBatchName_SelectedIndexChanged);
            this.cmbbxBatchName.SelectedValueChanged += new System.EventHandler(this.BatchSelectedValue);
            // 
            // cmbbxLab
            // 
            this.cmbbxLab.Font = new System.Drawing.Font("Century", 10F);
            this.cmbbxLab.FormattingEnabled = true;
            this.cmbbxLab.Location = new System.Drawing.Point(771, 10);
            this.cmbbxLab.Name = "cmbbxLab";
            this.cmbbxLab.Size = new System.Drawing.Size(217, 31);
            this.cmbbxLab.TabIndex = 13;
            this.cmbbxLab.Text = "-- Select --";
            this.cmbbxLab.SelectedIndexChanged += new System.EventHandler(this.cmbbxLab_SelectedIndexChanged);
            this.cmbbxLab.SelectedValueChanged += new System.EventHandler(this.SelectedValueLab);
            // 
            // cmbbxTestName
            // 
            this.cmbbxTestName.Font = new System.Drawing.Font("Century", 10F);
            this.cmbbxTestName.FormattingEnabled = true;
            this.cmbbxTestName.Location = new System.Drawing.Point(771, 83);
            this.cmbbxTestName.Name = "cmbbxTestName";
            this.cmbbxTestName.Size = new System.Drawing.Size(217, 31);
            this.cmbbxTestName.TabIndex = 14;
            this.cmbbxTestName.Text = "-- Select --";
            this.cmbbxTestName.SelectedIndexChanged += new System.EventHandler(this.cmbbxTestName_SelectedIndexChanged);
            this.cmbbxTestName.SelectedValueChanged += new System.EventHandler(this.SelectedTestName);
            // 
            // datagridOnDashBoard
            // 
            this.datagridOnDashBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridOnDashBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.Edit,
            this.Delete});
            this.datagridOnDashBoard.Location = new System.Drawing.Point(418, 274);
            this.datagridOnDashBoard.Name = "datagridOnDashBoard";
            this.datagridOnDashBoard.RowHeadersWidth = 62;
            this.datagridOnDashBoard.RowTemplate.Height = 28;
            this.datagridOnDashBoard.Size = new System.Drawing.Size(1282, 739);
            this.datagridOnDashBoard.TabIndex = 15;
            this.datagridOnDashBoard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridOnDashBoard_CellContentClick);
            // 
            // Select
            // 
            this.Select.HeaderText = "               Select";
            this.Select.MinimumWidth = 8;
            this.Select.Name = "Select";
            this.Select.Width = 150;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "         Edit";
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            this.Edit.Text = " Edit";
            this.Edit.ToolTipText = " Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 79;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "               Delete";
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.Text = " Delete";
            this.Delete.ToolTipText = " Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 16F);
            this.label5.Location = new System.Drawing.Point(561, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 38);
            this.label5.TabIndex = 16;
            this.label5.Text = "Test Management";
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.label1);
            this.panelFilter.Controls.Add(this.cmbbxLab);
            this.panelFilter.Controls.Add(this.label3);
            this.panelFilter.Controls.Add(this.cmbbxTestName);
            this.panelFilter.Controls.Add(this.cmbbxCourseName);
            this.panelFilter.Controls.Add(this.label2);
            this.panelFilter.Controls.Add(this.label4);
            this.panelFilter.Controls.Add(this.cmbbxBatchName);
            this.panelFilter.Location = new System.Drawing.Point(505, 131);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(1056, 137);
            this.panelFilter.TabIndex = 17;
            this.panelFilter.Visible = false;
            // 
            // FrmTestManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1722, 1044);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datagridOnDashBoard);
            this.Controls.Add(this.btnAssignTest);
            this.Controls.Add(this.picbxFilter);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnNewTest);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtbxSearch);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmTestManagement";
            this.Text = "FrmTestManagement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTestManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridOnDashBoard)).EndInit();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtbxSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnNewTest;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox picbxFilter;
        private System.Windows.Forms.Button btnAssignTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbbxCourseName;
        private System.Windows.Forms.ComboBox cmbbxBatchName;
        private System.Windows.Forms.ComboBox cmbbxLab;
        private System.Windows.Forms.ComboBox cmbbxTestName;
        private System.Windows.Forms.DataGridView datagridOnDashBoard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Panel panelFilter;
    }
}
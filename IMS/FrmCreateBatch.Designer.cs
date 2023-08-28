namespace IMS
{
    partial class FrmCreateBatch
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbbxLabName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBatchStartTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbxBatchName = new System.Windows.Forms.TextBox();
            this.txtbxBatchEndTime = new System.Windows.Forms.TextBox();
            this.txtbxStartTime = new System.Windows.Forms.TextBox();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.cmbbxBatchStatus = new System.Windows.Forms.ComboBox();
            this.lblNumberofStudents = new System.Windows.Forms.Label();
            this.checkedListBoxStudent = new System.Windows.Forms.CheckedListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnShowStudentList = new System.Windows.Forms.Button();
            this.btnCreateBatch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbbxCourse = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbbxStaff = new System.Windows.Forms.ComboBox();
            this.buttonDemo = new System.Windows.Forms.Button();
            this.lstbxstudentAddedToBatch = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Batch Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbbxLabName
            // 
            this.cmbbxLabName.Font = new System.Drawing.Font("Century", 10F);
            this.cmbbxLabName.FormattingEnabled = true;
            this.cmbbxLabName.Location = new System.Drawing.Point(715, 225);
            this.cmbbxLabName.Name = "cmbbxLabName";
            this.cmbbxLabName.Size = new System.Drawing.Size(217, 31);
            this.cmbbxLabName.TabIndex = 14;
            this.cmbbxLabName.Text = "-- Select --";
            this.cmbbxLabName.SelectedIndexChanged += new System.EventHandler(this.cmbbxLabName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(998, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tentitive End Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(417, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "Batch Status";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(417, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "Start Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(417, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 28);
            this.label5.TabIndex = 18;
            this.label5.Text = "Lab Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(998, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "Batch End Time";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblBatchStartTime
            // 
            this.lblBatchStartTime.AutoSize = true;
            this.lblBatchStartTime.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatchStartTime.Location = new System.Drawing.Point(408, 151);
            this.lblBatchStartTime.Name = "lblBatchStartTime";
            this.lblBatchStartTime.Size = new System.Drawing.Size(205, 28);
            this.lblBatchStartTime.TabIndex = 20;
            this.lblBatchStartTime.Text = "Batch Start Time";
            this.lblBatchStartTime.Click += new System.EventHandler(this.lblBatchStartTime_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1018, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 28);
            this.label8.TabIndex = 21;
            this.label8.Text = "Student Name";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(417, 469);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(292, 28);
            this.label9.TabIndex = 22;
            this.label9.Text = "Total Number of Student";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtbxBatchName
            // 
            this.txtbxBatchName.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxBatchName.Location = new System.Drawing.Point(715, 65);
            this.txtbxBatchName.Name = "txtbxBatchName";
            this.txtbxBatchName.Size = new System.Drawing.Size(217, 32);
            this.txtbxBatchName.TabIndex = 23;
            this.txtbxBatchName.TextChanged += new System.EventHandler(this.txtbxBatchName_TextChanged);
            // 
            // txtbxBatchEndTime
            // 
            this.txtbxBatchEndTime.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxBatchEndTime.Location = new System.Drawing.Point(1242, 147);
            this.txtbxBatchEndTime.Name = "txtbxBatchEndTime";
            this.txtbxBatchEndTime.Size = new System.Drawing.Size(217, 32);
            this.txtbxBatchEndTime.TabIndex = 24;
            this.txtbxBatchEndTime.TextChanged += new System.EventHandler(this.txtbxBatchEndTime_TextChanged);
            // 
            // txtbxStartTime
            // 
            this.txtbxStartTime.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxStartTime.Location = new System.Drawing.Point(715, 147);
            this.txtbxStartTime.Name = "txtbxStartTime";
            this.txtbxStartTime.Size = new System.Drawing.Size(217, 32);
            this.txtbxStartTime.TabIndex = 25;
            this.txtbxStartTime.TextChanged += new System.EventHandler(this.txtbxStartTime_TextChanged);
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(715, 303);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerStartDate.TabIndex = 27;
            this.dateTimePickerStartDate.ValueChanged += new System.EventHandler(this.dateTimePickerStartDate_ValueChanged);
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(1242, 303);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerEndDate.TabIndex = 28;
            this.dateTimePickerEndDate.ValueChanged += new System.EventHandler(this.dateTimePickerEndDate_ValueChanged);
            // 
            // cmbbxBatchStatus
            // 
            this.cmbbxBatchStatus.Font = new System.Drawing.Font("Century", 10F);
            this.cmbbxBatchStatus.FormattingEnabled = true;
            this.cmbbxBatchStatus.Location = new System.Drawing.Point(715, 388);
            this.cmbbxBatchStatus.Name = "cmbbxBatchStatus";
            this.cmbbxBatchStatus.Size = new System.Drawing.Size(217, 31);
            this.cmbbxBatchStatus.TabIndex = 29;
            this.cmbbxBatchStatus.Text = "-- Select --";
            this.cmbbxBatchStatus.SelectedIndexChanged += new System.EventHandler(this.cmbbxBatchStatus_SelectedIndexChanged);
            // 
            // lblNumberofStudents
            // 
            this.lblNumberofStudents.AutoSize = true;
            this.lblNumberofStudents.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberofStudents.Location = new System.Drawing.Point(755, 469);
            this.lblNumberofStudents.Name = "lblNumberofStudents";
            this.lblNumberofStudents.Size = new System.Drawing.Size(25, 28);
            this.lblNumberofStudents.TabIndex = 30;
            this.lblNumberofStudents.Text = "0";
            this.lblNumberofStudents.Click += new System.EventHandler(this.lblNumberofStudents_Click);
            // 
            // checkedListBoxStudent
            // 
            this.checkedListBoxStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.checkedListBoxStudent.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxStudent.FormattingEnabled = true;
            this.checkedListBoxStudent.Location = new System.Drawing.Point(1242, 456);
            this.checkedListBoxStudent.Name = "checkedListBoxStudent";
            this.checkedListBoxStudent.Size = new System.Drawing.Size(305, 294);
            this.checkedListBoxStudent.TabIndex = 31;
            this.checkedListBoxStudent.Visible = false;
            this.checkedListBoxStudent.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxStudent_SelectedIndexChanged);
            this.checkedListBoxStudent.SelectedValueChanged += new System.EventHandler(this.SelectedVAlueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(417, 537);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(286, 28);
            this.label11.TabIndex = 33;
            this.label11.Text = "Students added to Batch";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btnShowStudentList
            // 
            this.btnShowStudentList.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowStudentList.Location = new System.Drawing.Point(1242, 388);
            this.btnShowStudentList.Name = "btnShowStudentList";
            this.btnShowStudentList.Size = new System.Drawing.Size(274, 38);
            this.btnShowStudentList.TabIndex = 34;
            this.btnShowStudentList.Text = "Show student List";
            this.btnShowStudentList.UseVisualStyleBackColor = true;
            this.btnShowStudentList.Click += new System.EventHandler(this.btnShowStudentList_Click);
            // 
            // btnCreateBatch
            // 
            this.btnCreateBatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCreateBatch.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBatch.Location = new System.Drawing.Point(493, 598);
            this.btnCreateBatch.Name = "btnCreateBatch";
            this.btnCreateBatch.Size = new System.Drawing.Size(141, 51);
            this.btnCreateBatch.TabIndex = 35;
            this.btnCreateBatch.Text = "Create Batch";
            this.btnCreateBatch.UseVisualStyleBackColor = false;
            this.btnCreateBatch.Click += new System.EventHandler(this.btnCreateBatch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancel.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(493, 685);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(141, 51);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(998, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 28);
            this.label7.TabIndex = 37;
            this.label7.Text = "Course";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cmbbxCourse
            // 
            this.cmbbxCourse.Font = new System.Drawing.Font("Century", 10F);
            this.cmbbxCourse.FormattingEnabled = true;
            this.cmbbxCourse.Location = new System.Drawing.Point(1242, 70);
            this.cmbbxCourse.Name = "cmbbxCourse";
            this.cmbbxCourse.Size = new System.Drawing.Size(217, 31);
            this.cmbbxCourse.TabIndex = 38;
            this.cmbbxCourse.Text = "-- Select --";
            this.cmbbxCourse.SelectedIndexChanged += new System.EventHandler(this.cmbbxCourse_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(998, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 28);
            this.label10.TabIndex = 39;
            this.label10.Text = "Staff Name";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // cmbbxStaff
            // 
            this.cmbbxStaff.Font = new System.Drawing.Font("Century", 10F);
            this.cmbbxStaff.FormattingEnabled = true;
            this.cmbbxStaff.Location = new System.Drawing.Point(1242, 229);
            this.cmbbxStaff.Name = "cmbbxStaff";
            this.cmbbxStaff.Size = new System.Drawing.Size(217, 31);
            this.cmbbxStaff.TabIndex = 40;
            this.cmbbxStaff.Text = "-- Select --";
            this.cmbbxStaff.SelectedIndexChanged += new System.EventHandler(this.cmbbxStaff_SelectedIndexChanged);
            // 
            // buttonDemo
            // 
            this.buttonDemo.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDemo.Location = new System.Drawing.Point(937, 456);
            this.buttonDemo.Name = "buttonDemo";
            this.buttonDemo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonDemo.Size = new System.Drawing.Size(274, 38);
            this.buttonDemo.TabIndex = 41;
            this.buttonDemo.Text = "Show Selected Student  ";
            this.buttonDemo.UseVisualStyleBackColor = true;
            this.buttonDemo.Click += new System.EventHandler(this.buttonDemo_Click);
            // 
            // lstbxstudentAddedToBatch
            // 
            this.lstbxstudentAddedToBatch.FormattingEnabled = true;
            this.lstbxstudentAddedToBatch.ItemHeight = 20;
            this.lstbxstudentAddedToBatch.Location = new System.Drawing.Point(805, 598);
            this.lstbxstudentAddedToBatch.Name = "lstbxstudentAddedToBatch";
            this.lstbxstudentAddedToBatch.Size = new System.Drawing.Size(331, 184);
            this.lstbxstudentAddedToBatch.TabIndex = 42;
            this.lstbxstudentAddedToBatch.SelectedIndexChanged += new System.EventHandler(this.lstbxstudentAddedToBatch_SelectedIndexChanged);
            // 
            // FrmCreateBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1743, 774);
            this.Controls.Add(this.lstbxstudentAddedToBatch);
            this.Controls.Add(this.buttonDemo);
            this.Controls.Add(this.cmbbxStaff);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbbxCourse);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateBatch);
            this.Controls.Add(this.btnShowStudentList);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.checkedListBoxStudent);
            this.Controls.Add(this.lblNumberofStudents);
            this.Controls.Add(this.cmbbxBatchStatus);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.txtbxStartTime);
            this.Controls.Add(this.txtbxBatchEndTime);
            this.Controls.Add(this.txtbxBatchName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblBatchStartTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbbxLabName);
            this.Controls.Add(this.label2);
            this.Name = "FrmCreateBatch";
            this.Text = "FrmCreateBatch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCreateBatch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbbxLabName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBatchStartTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbxBatchName;
        private System.Windows.Forms.TextBox txtbxBatchEndTime;
        private System.Windows.Forms.TextBox txtbxStartTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.ComboBox cmbbxBatchStatus;
        private System.Windows.Forms.Label lblNumberofStudents;
        private System.Windows.Forms.CheckedListBox checkedListBoxStudent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnShowStudentList;
        private System.Windows.Forms.Button btnCreateBatch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbbxCourse;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbbxStaff;
        private System.Windows.Forms.Button buttonDemo;
        private System.Windows.Forms.ListBox lstbxstudentAddedToBatch;
    }
}
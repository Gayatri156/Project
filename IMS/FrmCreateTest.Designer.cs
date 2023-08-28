namespace IMS
{
    partial class FrmCreateTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbbxCourseName = new System.Windows.Forms.ComboBox();
            this.cmbbxTopicName = new System.Windows.Forms.ComboBox();
            this.txtbxTestName = new System.Windows.Forms.TextBox();
            this.txtbxDuration = new System.Windows.Forms.TextBox();
            this.txtbxTotalMarks = new System.Windows.Forms.TextBox();
            this.btnCreateTest = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(681, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Test";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(471, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(471, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(471, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select Question File";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(471, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Marks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(471, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Topic Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(471, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Test Name";
            // 
            // cmbbxCourseName
            // 
            this.cmbbxCourseName.Font = new System.Drawing.Font("Century", 10F);
            this.cmbbxCourseName.FormattingEnabled = true;
            this.cmbbxCourseName.Location = new System.Drawing.Point(768, 83);
            this.cmbbxCourseName.Name = "cmbbxCourseName";
            this.cmbbxCourseName.Size = new System.Drawing.Size(217, 31);
            this.cmbbxCourseName.TabIndex = 13;
            this.cmbbxCourseName.Text = "-- Select --";
            this.cmbbxCourseName.SelectedIndexChanged += new System.EventHandler(this.cmbbxCourseName_SelectedIndexChanged);
            // 
            // cmbbxTopicName
            // 
            this.cmbbxTopicName.Font = new System.Drawing.Font("Century", 10F);
            this.cmbbxTopicName.FormattingEnabled = true;
            this.cmbbxTopicName.Location = new System.Drawing.Point(768, 244);
            this.cmbbxTopicName.Name = "cmbbxTopicName";
            this.cmbbxTopicName.Size = new System.Drawing.Size(217, 31);
            this.cmbbxTopicName.TabIndex = 14;
            this.cmbbxTopicName.Text = "-- Select --";
            this.cmbbxTopicName.SelectedIndexChanged += new System.EventHandler(this.cmbbxTopicName_SelectedIndexChanged);
            // 
            // txtbxTestName
            // 
            this.txtbxTestName.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxTestName.Location = new System.Drawing.Point(768, 168);
            this.txtbxTestName.Name = "txtbxTestName";
            this.txtbxTestName.Size = new System.Drawing.Size(217, 32);
            this.txtbxTestName.TabIndex = 15;
            // 
            // txtbxDuration
            // 
            this.txtbxDuration.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxDuration.Location = new System.Drawing.Point(768, 322);
            this.txtbxDuration.Name = "txtbxDuration";
            this.txtbxDuration.Size = new System.Drawing.Size(217, 32);
            this.txtbxDuration.TabIndex = 16;
            // 
            // txtbxTotalMarks
            // 
            this.txtbxTotalMarks.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxTotalMarks.Location = new System.Drawing.Point(768, 402);
            this.txtbxTotalMarks.Name = "txtbxTotalMarks";
            this.txtbxTotalMarks.Size = new System.Drawing.Size(217, 32);
            this.txtbxTotalMarks.TabIndex = 17;
            // 
            // btnCreateTest
            // 
            this.btnCreateTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCreateTest.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTest.Location = new System.Drawing.Point(476, 573);
            this.btnCreateTest.Name = "btnCreateTest";
            this.btnCreateTest.Size = new System.Drawing.Size(141, 51);
            this.btnCreateTest.TabIndex = 18;
            this.btnCreateTest.Text = "Create Test";
            this.btnCreateTest.UseVisualStyleBackColor = false;
            this.btnCreateTest.Click += new System.EventHandler(this.btnCreateTest_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancel.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(675, 573);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(141, 51);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // FrmCreateTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1726, 712);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateTest);
            this.Controls.Add(this.txtbxTotalMarks);
            this.Controls.Add(this.txtbxDuration);
            this.Controls.Add(this.txtbxTestName);
            this.Controls.Add(this.cmbbxTopicName);
            this.Controls.Add(this.cmbbxCourseName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCreateTest";
            this.Text = "FrmCreateTest";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCreateTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbbxCourseName;
        private System.Windows.Forms.ComboBox cmbbxTopicName;
        private System.Windows.Forms.TextBox txtbxTestName;
        private System.Windows.Forms.TextBox txtbxDuration;
        private System.Windows.Forms.TextBox txtbxTotalMarks;
        private System.Windows.Forms.Button btnCreateTest;
        private System.Windows.Forms.Button btnCancel;
    }
}
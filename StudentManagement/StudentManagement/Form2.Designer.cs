namespace StudentManagement {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnClassDetail = new System.Windows.Forms.Button();
            this.btnStudentList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClassId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClassYear = new System.Windows.Forms.TextBox();
            this.lsStudent = new System.Windows.Forms.ListView();
            this.stdId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stdName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.classId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Class ID:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(124, 37);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(130, 20);
            this.txtId.TabIndex = 1;
            // 
            // btnClassDetail
            // 
            this.btnClassDetail.Location = new System.Drawing.Point(44, 76);
            this.btnClassDetail.Name = "btnClassDetail";
            this.btnClassDetail.Size = new System.Drawing.Size(210, 23);
            this.btnClassDetail.TabIndex = 2;
            this.btnClassDetail.Text = "Detail information of class";
            this.btnClassDetail.UseVisualStyleBackColor = true;
            this.btnClassDetail.Click += new System.EventHandler(this.btnClassDetail_Click);
            // 
            // btnStudentList
            // 
            this.btnStudentList.Location = new System.Drawing.Point(283, 76);
            this.btnStudentList.Name = "btnStudentList";
            this.btnStudentList.Size = new System.Drawing.Size(242, 23);
            this.btnStudentList.TabIndex = 2;
            this.btnStudentList.Text = "Student List of Class";
            this.btnStudentList.UseVisualStyleBackColor = true;
            this.btnStudentList.Click += new System.EventHandler(this.btnStudentList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Class ID:";
            // 
            // txtClassId
            // 
            this.txtClassId.Location = new System.Drawing.Point(113, 124);
            this.txtClassId.Name = "txtClassId";
            this.txtClassId.ReadOnly = true;
            this.txtClassId.Size = new System.Drawing.Size(141, 20);
            this.txtClassId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Class Name:";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(113, 160);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.ReadOnly = true;
            this.txtClassName.Size = new System.Drawing.Size(141, 20);
            this.txtClassName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Year:";
            // 
            // txtClassYear
            // 
            this.txtClassYear.Location = new System.Drawing.Point(113, 197);
            this.txtClassYear.Name = "txtClassYear";
            this.txtClassYear.ReadOnly = true;
            this.txtClassYear.Size = new System.Drawing.Size(141, 20);
            this.txtClassYear.TabIndex = 1;
            // 
            // lsStudent
            // 
            this.lsStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stdId,
            this.stdName,
            this.classId});
            this.lsStudent.FullRowSelect = true;
            this.lsStudent.GridLines = true;
            this.lsStudent.HideSelection = false;
            this.lsStudent.Location = new System.Drawing.Point(283, 124);
            this.lsStudent.MultiSelect = false;
            this.lsStudent.Name = "lsStudent";
            this.lsStudent.Size = new System.Drawing.Size(313, 211);
            this.lsStudent.TabIndex = 3;
            this.lsStudent.UseCompatibleStateImageBehavior = false;
            this.lsStudent.View = System.Windows.Forms.View.Details;
            // 
            // stdId
            // 
            this.stdId.Text = "Student ID";
            this.stdId.Width = 80;
            // 
            // stdName
            // 
            this.stdName.Text = "Student Name";
            this.stdName.Width = 172;
            // 
            // classId
            // 
            this.classId.Text = "Class ID";
            this.classId.Width = 149;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 354);
            this.Controls.Add(this.lsStudent);
            this.Controls.Add(this.btnStudentList);
            this.Controls.Add(this.btnClassDetail);
            this.Controls.Add(this.txtClassYear);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClassId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnClassDetail;
        private System.Windows.Forms.Button btnStudentList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClassId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClassYear;
        private System.Windows.Forms.ListView lsStudent;
        private System.Windows.Forms.ColumnHeader stdId;
        private System.Windows.Forms.ColumnHeader stdName;
        private System.Windows.Forms.ColumnHeader classId;
    }
}
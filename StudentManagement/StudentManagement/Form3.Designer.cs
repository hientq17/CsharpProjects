namespace StudentManagement {
    partial class Form3 {
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
            this.lsBoxClasses = new System.Windows.Forms.ListBox();
            this.lsViewStudents = new System.Windows.Forms.ListView();
            this.stdId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stdName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.classId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsBoxClasses
            // 
            this.lsBoxClasses.FormattingEnabled = true;
            this.lsBoxClasses.Location = new System.Drawing.Point(25, 70);
            this.lsBoxClasses.Name = "lsBoxClasses";
            this.lsBoxClasses.Size = new System.Drawing.Size(120, 160);
            this.lsBoxClasses.TabIndex = 0;
            this.lsBoxClasses.SelectedIndexChanged += new System.EventHandler(this.lsBoxClass_SelectedIndexChanged);
            // 
            // lsViewStudents
            // 
            this.lsViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stdId,
            this.stdName,
            this.classId});
            this.lsViewStudents.FullRowSelect = true;
            this.lsViewStudents.GridLines = true;
            this.lsViewStudents.HideSelection = false;
            this.lsViewStudents.Location = new System.Drawing.Point(166, 70);
            this.lsViewStudents.MultiSelect = false;
            this.lsViewStudents.Name = "lsViewStudents";
            this.lsViewStudents.Size = new System.Drawing.Size(313, 163);
            this.lsViewStudents.TabIndex = 4;
            this.lsViewStudents.UseCompatibleStateImageBehavior = false;
            this.lsViewStudents.View = System.Windows.Forms.View.Details;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "List Classes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "List Students";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 272);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsViewStudents);
            this.Controls.Add(this.lsBoxClasses);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsBoxClasses;
        private System.Windows.Forms.ListView lsViewStudents;
        private System.Windows.Forms.ColumnHeader stdId;
        private System.Windows.Forms.ColumnHeader stdName;
        private System.Windows.Forms.ColumnHeader classId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
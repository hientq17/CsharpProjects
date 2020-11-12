namespace Lab04 {
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lsStudent = new System.Windows.Forms.ListView();
            this.supId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contactName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter company name:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(118, 15);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(180, 20);
            this.txtCompanyName.TabIndex = 1;
            // 
            // lsStudent
            // 
            this.lsStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.supId,
            this.comName,
            this.contactName,
            this.address,
            this.phone});
            this.lsStudent.FullRowSelect = true;
            this.lsStudent.GridLines = true;
            this.lsStudent.HideSelection = false;
            this.lsStudent.Location = new System.Drawing.Point(12, 63);
            this.lsStudent.MultiSelect = false;
            this.lsStudent.Name = "lsStudent";
            this.lsStudent.Size = new System.Drawing.Size(585, 279);
            this.lsStudent.TabIndex = 3;
            this.lsStudent.UseCompatibleStateImageBehavior = false;
            this.lsStudent.View = System.Windows.Forms.View.Details;
            // 
            // supId
            // 
            this.supId.Text = "Supplier ID";
            this.supId.Width = 80;
            // 
            // comName
            // 
            this.comName.Text = "Company Name";
            this.comName.Width = 172;
            // 
            // contactName
            // 
            this.contactName.Text = "Contact Name";
            this.contactName.Width = 149;
            // 
            // address
            // 
            this.address.Text = "Address";
            // 
            // phone
            // 
            this.phone.Text = "Phone";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(304, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.Location = new System.Drawing.Point(395, 15);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayAll.TabIndex = 4;
            this.btnDisplayAll.Text = "Display All";
            this.btnDisplayAll.UseVisualStyleBackColor = true;
            this.btnDisplayAll.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(487, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 354);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDisplayAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lsStudent);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.ListView lsStudent;
        private System.Windows.Forms.ColumnHeader supId;
        private System.Windows.Forms.ColumnHeader comName;
        private System.Windows.Forms.ColumnHeader contactName;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader phone;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.Button btnClose;
    }
}
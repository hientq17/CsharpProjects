namespace Lab04 {
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
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lsStudent = new System.Windows.Forms.ListView();
            this.productId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.supplierId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityPerUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitsInStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.disContinued = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter product name:";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(118, 15);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(180, 20);
            this.txtProductName.TabIndex = 1;
            // 
            // lsStudent
            // 
            this.lsStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productId,
            this.productName,
            this.supplierId,
            this.categoryId,
            this.quantityPerUnit,
            this.unitPrice,
            this.unitsInStock,
            this.disContinued});
            this.lsStudent.FullRowSelect = true;
            this.lsStudent.GridLines = true;
            this.lsStudent.HideSelection = false;
            this.lsStudent.Location = new System.Drawing.Point(12, 63);
            this.lsStudent.MultiSelect = false;
            this.lsStudent.Name = "lsStudent";
            this.lsStudent.Size = new System.Drawing.Size(724, 279);
            this.lsStudent.TabIndex = 3;
            this.lsStudent.UseCompatibleStateImageBehavior = false;
            this.lsStudent.View = System.Windows.Forms.View.Details;
            // 
            // productId
            // 
            this.productId.Text = "Product ID";
            this.productId.Width = 65;
            // 
            // productName
            // 
            this.productName.Text = "Product Name";
            this.productName.Width = 103;
            // 
            // supplierId
            // 
            this.supplierId.Text = "Supplier ID";
            this.supplierId.Width = 76;
            // 
            // categoryId
            // 
            this.categoryId.Text = "Category ID";
            this.categoryId.Width = 75;
            // 
            // quantityPerUnit
            // 
            this.quantityPerUnit.Text = "Quantity Per Unit";
            this.quantityPerUnit.Width = 125;
            // 
            // unitPrice
            // 
            this.unitPrice.Text = "Unit Price";
            this.unitPrice.Width = 71;
            // 
            // unitsInStock
            // 
            this.unitsInStock.Text = "Units In Stock";
            this.unitsInStock.Width = 119;
            // 
            // disContinued
            // 
            this.disContinued.Text = "Discontinued";
            this.disContinued.Width = 113;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 354);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDisplayAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lsStudent);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.ListView lsStudent;
        private System.Windows.Forms.ColumnHeader productId;
        private System.Windows.Forms.ColumnHeader productName;
        private System.Windows.Forms.ColumnHeader supplierId;
        private System.Windows.Forms.ColumnHeader categoryId;
        private System.Windows.Forms.ColumnHeader quantityPerUnit;
        private System.Windows.Forms.ColumnHeader unitPrice;
        private System.Windows.Forms.ColumnHeader unitsInStock;
        private System.Windows.Forms.ColumnHeader disContinued;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.Button btnClose;
    }
}
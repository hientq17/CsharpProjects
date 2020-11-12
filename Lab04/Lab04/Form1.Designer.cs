namespace Lab04 {
    partial class Form1 {
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnListProducts = new System.Windows.Forms.Button();
            this.btnListSuppliers = new System.Windows.Forms.Button();
            this.btnListCategories = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(58, 35);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(129, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open connection";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Enabled = false;
            this.btnClose.Location = new System.Drawing.Point(58, 194);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close connection";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnListProducts
            // 
            this.btnListProducts.Enabled = false;
            this.btnListProducts.Location = new System.Drawing.Point(58, 74);
            this.btnListProducts.Name = "btnListProducts";
            this.btnListProducts.Size = new System.Drawing.Size(129, 23);
            this.btnListProducts.TabIndex = 0;
            this.btnListProducts.Text = "List all Products";
            this.btnListProducts.UseVisualStyleBackColor = true;
            this.btnListProducts.Click += new System.EventHandler(this.btnListProducts_Click);
            // 
            // btnListSuppliers
            // 
            this.btnListSuppliers.Enabled = false;
            this.btnListSuppliers.Location = new System.Drawing.Point(58, 114);
            this.btnListSuppliers.Name = "btnListSuppliers";
            this.btnListSuppliers.Size = new System.Drawing.Size(129, 23);
            this.btnListSuppliers.TabIndex = 0;
            this.btnListSuppliers.Text = "List all Suppliers";
            this.btnListSuppliers.UseVisualStyleBackColor = true;
            this.btnListSuppliers.Click += new System.EventHandler(this.btnListSuppliers_Click);
            // 
            // btnListCategories
            // 
            this.btnListCategories.Enabled = false;
            this.btnListCategories.Location = new System.Drawing.Point(58, 153);
            this.btnListCategories.Name = "btnListCategories";
            this.btnListCategories.Size = new System.Drawing.Size(129, 23);
            this.btnListCategories.TabIndex = 0;
            this.btnListCategories.Text = "List all Categories";
            this.btnListCategories.UseVisualStyleBackColor = true;
            this.btnListCategories.Click += new System.EventHandler(this.btnListCategories_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 255);
            this.Controls.Add(this.btnListCategories);
            this.Controls.Add(this.btnListSuppliers);
            this.Controls.Add(this.btnListProducts);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnListProducts;
        private System.Windows.Forms.Button btnListSuppliers;
        private System.Windows.Forms.Button btnListCategories;
    }
}


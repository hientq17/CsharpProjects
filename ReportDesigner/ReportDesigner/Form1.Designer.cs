namespace ReportDesigner {
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mrendzpc_CoffeeManagementDataSet = new ReportDesigner.mrendzpc_CoffeeManagementDataSet();
            this.InvoiceDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReportTableAdapter = new ReportDesigner.mrendzpc_CoffeeManagementDataSetTableAdapters.ReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mrendzpc_CoffeeManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportBindingSource
            // 
            this.ReportBindingSource.DataMember = "Report";
            this.ReportBindingSource.DataSource = this.mrendzpc_CoffeeManagementDataSet;
            // 
            // mrendzpc_CoffeeManagementDataSet
            // 
            this.mrendzpc_CoffeeManagementDataSet.DataSetName = "mrendzpc_CoffeeManagementDataSet";
            this.mrendzpc_CoffeeManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // InvoiceDetailBindingSource
            // 
            this.InvoiceDetailBindingSource.DataMember = "InvoiceDetail";
            // 
            // reportViewer
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReportBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.InvoiceDetailBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "ReportDesigner.Report1.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(1, 7);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(456, 593);
            this.reportViewer.TabIndex = 0;
            // 
            // ReportTableAdapter
            // 
            this.ReportTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 595);
            this.Controls.Add(this.reportViewer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mrendzpc_CoffeeManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource ReportBindingSource;
        private mrendzpc_CoffeeManagementDataSet mrendzpc_CoffeeManagementDataSet;
        private System.Windows.Forms.BindingSource InvoiceDetailBindingSource;
        private mrendzpc_CoffeeManagementDataSetTableAdapters.ReportTableAdapter ReportTableAdapter;
      
    }
}


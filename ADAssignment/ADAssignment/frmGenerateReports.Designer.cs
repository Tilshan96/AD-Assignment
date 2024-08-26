namespace ADAssignment
{
    partial class frmGenerateReports
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ApplicationDevelopmentDataSet = new ADAssignment.ApplicationDevelopmentDataSet();
            this.tblManageCustomerOrderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblManageCustomerOrderDetailsTableAdapter = new ADAssignment.ApplicationDevelopmentDataSetTableAdapters.tblManageCustomerOrderDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationDevelopmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblManageCustomerOrderDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblManageCustomerOrderDetailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ADAssignment.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(480, 392);
            this.reportViewer1.TabIndex = 0;
            // 
            // ApplicationDevelopmentDataSet
            // 
            this.ApplicationDevelopmentDataSet.DataSetName = "ApplicationDevelopmentDataSet";
            this.ApplicationDevelopmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblManageCustomerOrderDetailsBindingSource
            // 
            this.tblManageCustomerOrderDetailsBindingSource.DataMember = "tblManageCustomerOrderDetails";
            this.tblManageCustomerOrderDetailsBindingSource.DataSource = this.ApplicationDevelopmentDataSet;
            // 
            // tblManageCustomerOrderDetailsTableAdapter
            // 
            this.tblManageCustomerOrderDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frmGenerateReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(480, 392);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmGenerateReports";
            this.Text = "Generate Reports";
            this.Load += new System.EventHandler(this.frmGenerateReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationDevelopmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblManageCustomerOrderDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblManageCustomerOrderDetailsBindingSource;
        private ApplicationDevelopmentDataSet ApplicationDevelopmentDataSet;
        private ApplicationDevelopmentDataSetTableAdapters.tblManageCustomerOrderDetailsTableAdapter tblManageCustomerOrderDetailsTableAdapter;
    }
}
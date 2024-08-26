namespace ADAssignment
{
    partial class frmAdmin
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
            this.btnGenerateReports = new System.Windows.Forms.Button();
            this.btnManageCustomerOrderDetails = new System.Windows.Forms.Button();
            this.btnManageCustomerDetails = new System.Windows.Forms.Button();
            this.btnManageCarPartsDetails = new System.Windows.Forms.Button();
            this.btnManageCarDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerateReports
            // 
            this.btnGenerateReports.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGenerateReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReports.Location = new System.Drawing.Point(27, 445);
            this.btnGenerateReports.Name = "btnGenerateReports";
            this.btnGenerateReports.Size = new System.Drawing.Size(468, 49);
            this.btnGenerateReports.TabIndex = 1;
            this.btnGenerateReports.Text = "Generate Reports";
            this.btnGenerateReports.UseVisualStyleBackColor = false;
            this.btnGenerateReports.Click += new System.EventHandler(this.btnGenerateReports_Click);
            // 
            // btnManageCustomerOrderDetails
            // 
            this.btnManageCustomerOrderDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnManageCustomerOrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCustomerOrderDetails.Location = new System.Drawing.Point(27, 354);
            this.btnManageCustomerOrderDetails.Name = "btnManageCustomerOrderDetails";
            this.btnManageCustomerOrderDetails.Size = new System.Drawing.Size(468, 49);
            this.btnManageCustomerOrderDetails.TabIndex = 2;
            this.btnManageCustomerOrderDetails.Text = "Manage Customer Order Details";
            this.btnManageCustomerOrderDetails.UseVisualStyleBackColor = false;
            this.btnManageCustomerOrderDetails.Click += new System.EventHandler(this.btnManageCustomerOrderDetails_Click);
            // 
            // btnManageCustomerDetails
            // 
            this.btnManageCustomerDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnManageCustomerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCustomerDetails.Location = new System.Drawing.Point(27, 255);
            this.btnManageCustomerDetails.Name = "btnManageCustomerDetails";
            this.btnManageCustomerDetails.Size = new System.Drawing.Size(468, 49);
            this.btnManageCustomerDetails.TabIndex = 3;
            this.btnManageCustomerDetails.Text = "Manage Customer Details";
            this.btnManageCustomerDetails.UseVisualStyleBackColor = false;
            this.btnManageCustomerDetails.Click += new System.EventHandler(this.btnManageCustomerDetails_Click);
            // 
            // btnManageCarPartsDetails
            // 
            this.btnManageCarPartsDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnManageCarPartsDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCarPartsDetails.Location = new System.Drawing.Point(27, 152);
            this.btnManageCarPartsDetails.Name = "btnManageCarPartsDetails";
            this.btnManageCarPartsDetails.Size = new System.Drawing.Size(468, 58);
            this.btnManageCarPartsDetails.TabIndex = 4;
            this.btnManageCarPartsDetails.Text = "Manage Car Parts Details";
            this.btnManageCarPartsDetails.UseVisualStyleBackColor = false;
            this.btnManageCarPartsDetails.Click += new System.EventHandler(this.btnManageCarPartsDetails_Click);
            // 
            // btnManageCarDetails
            // 
            this.btnManageCarDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnManageCarDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCarDetails.Location = new System.Drawing.Point(27, 59);
            this.btnManageCarDetails.Name = "btnManageCarDetails";
            this.btnManageCarDetails.Size = new System.Drawing.Size(468, 49);
            this.btnManageCarDetails.TabIndex = 5;
            this.btnManageCarDetails.Text = "Manage Car Details";
            this.btnManageCarDetails.UseVisualStyleBackColor = false;
            this.btnManageCarDetails.Click += new System.EventHandler(this.btnManageCarDetails_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(522, 573);
            this.Controls.Add(this.btnGenerateReports);
            this.Controls.Add(this.btnManageCustomerOrderDetails);
            this.Controls.Add(this.btnManageCustomerDetails);
            this.Controls.Add(this.btnManageCarPartsDetails);
            this.Controls.Add(this.btnManageCarDetails);
            this.Name = "frmAdmin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateReports;
        private System.Windows.Forms.Button btnManageCustomerOrderDetails;
        private System.Windows.Forms.Button btnManageCustomerDetails;
        private System.Windows.Forms.Button btnManageCarPartsDetails;
        private System.Windows.Forms.Button btnManageCarDetails;
    }
}
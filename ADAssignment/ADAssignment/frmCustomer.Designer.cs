namespace ADAssignment
{
    partial class frmCustomer
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
            this.btnViewOrderStatus = new System.Windows.Forms.Button();
            this.btnOrderCarorCarParts = new System.Windows.Forms.Button();
            this.btnSearchCarPartsDetails = new System.Windows.Forms.Button();
            this.btnSearchCarDetails = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewOrderStatus
            // 
            this.btnViewOrderStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViewOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrderStatus.Location = new System.Drawing.Point(27, 444);
            this.btnViewOrderStatus.Name = "btnViewOrderStatus";
            this.btnViewOrderStatus.Size = new System.Drawing.Size(468, 49);
            this.btnViewOrderStatus.TabIndex = 6;
            this.btnViewOrderStatus.Text = "View Order Status";
            this.btnViewOrderStatus.UseVisualStyleBackColor = false;
            this.btnViewOrderStatus.Click += new System.EventHandler(this.btnViewOrderStatus_Click);
            // 
            // btnOrderCarorCarParts
            // 
            this.btnOrderCarorCarParts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOrderCarorCarParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderCarorCarParts.Location = new System.Drawing.Point(27, 353);
            this.btnOrderCarorCarParts.Name = "btnOrderCarorCarParts";
            this.btnOrderCarorCarParts.Size = new System.Drawing.Size(468, 49);
            this.btnOrderCarorCarParts.TabIndex = 7;
            this.btnOrderCarorCarParts.Text = "Order Car/Car Parts";
            this.btnOrderCarorCarParts.UseVisualStyleBackColor = false;
            this.btnOrderCarorCarParts.Click += new System.EventHandler(this.btnOrderCarorCarParts_Click);
            // 
            // btnSearchCarPartsDetails
            // 
            this.btnSearchCarPartsDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchCarPartsDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCarPartsDetails.Location = new System.Drawing.Point(27, 254);
            this.btnSearchCarPartsDetails.Name = "btnSearchCarPartsDetails";
            this.btnSearchCarPartsDetails.Size = new System.Drawing.Size(468, 49);
            this.btnSearchCarPartsDetails.TabIndex = 8;
            this.btnSearchCarPartsDetails.Text = "Search Car Parts Details";
            this.btnSearchCarPartsDetails.UseVisualStyleBackColor = false;
            this.btnSearchCarPartsDetails.Click += new System.EventHandler(this.btnSearchCarPartsDetails_Click);
            // 
            // btnSearchCarDetails
            // 
            this.btnSearchCarDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchCarDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCarDetails.Location = new System.Drawing.Point(27, 151);
            this.btnSearchCarDetails.Name = "btnSearchCarDetails";
            this.btnSearchCarDetails.Size = new System.Drawing.Size(468, 58);
            this.btnSearchCarDetails.TabIndex = 9;
            this.btnSearchCarDetails.Text = "Search Car Details";
            this.btnSearchCarDetails.UseVisualStyleBackColor = false;
            this.btnSearchCarDetails.Click += new System.EventHandler(this.btnSearchCarDetails_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(27, 58);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(468, 49);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(531, 584);
            this.Controls.Add(this.btnViewOrderStatus);
            this.Controls.Add(this.btnOrderCarorCarParts);
            this.Controls.Add(this.btnSearchCarPartsDetails);
            this.Controls.Add(this.btnSearchCarDetails);
            this.Controls.Add(this.btnRegister);
            this.Name = "frmCustomer";
            this.Text = "Customer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewOrderStatus;
        private System.Windows.Forms.Button btnOrderCarorCarParts;
        private System.Windows.Forms.Button btnSearchCarPartsDetails;
        private System.Windows.Forms.Button btnSearchCarDetails;
        private System.Windows.Forms.Button btnRegister;
    }
}
namespace MarketMasterplace
{
    partial class frmVendViewDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendViewDetail));
            this.dgvDisplayVendors = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVendorDisplay = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayVendors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisplayVendors
            // 
            this.dgvDisplayVendors.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvDisplayVendors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayVendors.GridColor = System.Drawing.Color.PaleGoldenrod;
            this.dgvDisplayVendors.Location = new System.Drawing.Point(12, 168);
            this.dgvDisplayVendors.Name = "dgvDisplayVendors";
            this.dgvDisplayVendors.Size = new System.Drawing.Size(888, 474);
            this.dgvDisplayVendors.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DimGray;
            this.btnBack.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(704, 108);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 54);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "<<Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 129);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // lblVendorDisplay
            // 
            this.lblVendorDisplay.AutoSize = true;
            this.lblVendorDisplay.BackColor = System.Drawing.Color.DimGray;
            this.lblVendorDisplay.Font = new System.Drawing.Font("Maiandra GD", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendorDisplay.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lblVendorDisplay.Location = new System.Drawing.Point(123, 36);
            this.lblVendorDisplay.Name = "lblVendorDisplay";
            this.lblVendorDisplay.Size = new System.Drawing.Size(474, 57);
            this.lblVendorDisplay.TabIndex = 40;
            this.lblVendorDisplay.Text = "Vendor Display Form";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DimGray;
            this.btnAdd.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(805, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 54);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "&Add New";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmVendViewDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(912, 654);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblVendorDisplay);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvDisplayVendors);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVendViewDetail";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayVendors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisplayVendors;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVendorDisplay;
        private System.Windows.Forms.Button btnAdd;
    }
}
partial class frmMain
{
    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnVendor = new System.Windows.Forms.Button();
            this.btnEntertainer = new System.Windows.Forms.Button();
            this.btnVolunteer = new System.Windows.Forms.Button();
            this.btnVisitor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DimGray;
            this.btnExit.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.btnExit.Location = new System.Drawing.Point(155, 329);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 57);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "E&XIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnVendor
            // 
            this.btnVendor.BackColor = System.Drawing.Color.DimGray;
            this.btnVendor.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendor.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.btnVendor.Location = new System.Drawing.Point(31, 158);
            this.btnVendor.Name = "btnVendor";
            this.btnVendor.Size = new System.Drawing.Size(140, 57);
            this.btnVendor.TabIndex = 3;
            this.btnVendor.Text = "Vendor";
            this.btnVendor.UseVisualStyleBackColor = false;
            this.btnVendor.Click += new System.EventHandler(this.btnVendor_Click);
            // 
            // btnEntertainer
            // 
            this.btnEntertainer.BackColor = System.Drawing.Color.DimGray;
            this.btnEntertainer.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntertainer.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.btnEntertainer.Location = new System.Drawing.Point(252, 244);
            this.btnEntertainer.Name = "btnEntertainer";
            this.btnEntertainer.Size = new System.Drawing.Size(145, 57);
            this.btnEntertainer.TabIndex = 4;
            this.btnEntertainer.Text = "Entertainer";
            this.btnEntertainer.UseVisualStyleBackColor = false;
            this.btnEntertainer.Click += new System.EventHandler(this.btnEntertainer_Click);
            // 
            // btnVolunteer
            // 
            this.btnVolunteer.BackColor = System.Drawing.Color.DimGray;
            this.btnVolunteer.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolunteer.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.btnVolunteer.Location = new System.Drawing.Point(252, 158);
            this.btnVolunteer.Name = "btnVolunteer";
            this.btnVolunteer.Size = new System.Drawing.Size(145, 57);
            this.btnVolunteer.TabIndex = 5;
            this.btnVolunteer.Text = "Volunteer";
            this.btnVolunteer.UseVisualStyleBackColor = false;
            this.btnVolunteer.Click += new System.EventHandler(this.btnVolunteer_Click);
            // 
            // btnVisitor
            // 
            this.btnVisitor.BackColor = System.Drawing.Color.DimGray;
            this.btnVisitor.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitor.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.btnVisitor.Location = new System.Drawing.Point(31, 244);
            this.btnVisitor.Name = "btnVisitor";
            this.btnVisitor.Size = new System.Drawing.Size(140, 57);
            this.btnVisitor.TabIndex = 6;
            this.btnVisitor.Text = "Visitor";
            this.btnVisitor.UseVisualStyleBackColor = false;
            this.btnVisitor.Click += new System.EventHandler(this.btnVisitor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 144);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(424, 398);
            this.Controls.Add(this.btnVisitor);
            this.Controls.Add(this.btnVolunteer);
            this.Controls.Add(this.btnEntertainer);
            this.Controls.Add(this.btnVendor);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Button btnVendor;
    private System.Windows.Forms.Button btnEntertainer;
    private System.Windows.Forms.Button btnVolunteer;
    private System.Windows.Forms.Button btnVisitor;
    private System.Windows.Forms.PictureBox pictureBox1;
}
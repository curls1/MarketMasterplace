namespace MarketMasterplace
{
    partial class frmVisitorApp
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
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.lblvfName = new System.Windows.Forms.Label();
            this.lblvlName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.chkBag = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtaVisitor = new System.Windows.Forms.DataGridView();
            this.lblVisitorName = new System.Windows.Forms.Label();
            this.lblBag = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaVisitor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(12, 50);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(124, 20);
            this.txtFirst.TabIndex = 0;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(12, 95);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(124, 20);
            this.txtLast.TabIndex = 1;
            // 
            // lblvfName
            // 
            this.lblvfName.AutoSize = true;
            this.lblvfName.BackColor = System.Drawing.Color.DimGray;
            this.lblvfName.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvfName.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lblvfName.Location = new System.Drawing.Point(12, 30);
            this.lblvfName.Name = "lblvfName";
            this.lblvfName.Size = new System.Drawing.Size(85, 19);
            this.lblvfName.TabIndex = 4;
            this.lblvfName.Text = "First Name";
            // 
            // lblvlName
            // 
            this.lblvlName.AutoSize = true;
            this.lblvlName.BackColor = System.Drawing.Color.DimGray;
            this.lblvlName.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvlName.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lblvlName.Location = new System.Drawing.Point(12, 73);
            this.lblvlName.Name = "lblvlName";
            this.lblvlName.Size = new System.Drawing.Size(82, 19);
            this.lblvlName.TabIndex = 5;
            this.lblvlName.Text = "Last Name";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DimGray;
            this.btnBack.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.btnBack.Location = new System.Drawing.Point(12, 233);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(56, 31);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DimGray;
            this.btnAdd.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.btnAdd.Location = new System.Drawing.Point(12, 196);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 31);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.DimGray;
            this.lblEmail.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lblEmail.Location = new System.Drawing.Point(12, 118);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(105, 19);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email Address";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 141);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(124, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // chkBag
            // 
            this.chkBag.AutoSize = true;
            this.chkBag.BackColor = System.Drawing.Color.DimGray;
            this.chkBag.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBag.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.chkBag.Location = new System.Drawing.Point(12, 167);
            this.chkBag.Name = "chkBag";
            this.chkBag.Size = new System.Drawing.Size(100, 23);
            this.chkBag.TabIndex = 19;
            this.chkBag.Text = "Bag Given";
            this.chkBag.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Green;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(569, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // dtaVisitor
            // 
            this.dtaVisitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaVisitor.Location = new System.Drawing.Point(183, 73);
            this.dtaVisitor.Name = "dtaVisitor";
            this.dtaVisitor.Size = new System.Drawing.Size(374, 186);
            this.dtaVisitor.TabIndex = 21;
            // 
            // lblVisitorName
            // 
            this.lblVisitorName.AutoSize = true;
            this.lblVisitorName.BackColor = System.Drawing.Color.DimGray;
            this.lblVisitorName.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitorName.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lblVisitorName.Location = new System.Drawing.Point(193, 54);
            this.lblVisitorName.Name = "lblVisitorName";
            this.lblVisitorName.Size = new System.Drawing.Size(102, 19);
            this.lblVisitorName.TabIndex = 22;
            this.lblVisitorName.Text = "Visitor Name";
            // 
            // lblBag
            // 
            this.lblBag.AutoSize = true;
            this.lblBag.BackColor = System.Drawing.Color.DimGray;
            this.lblBag.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBag.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lblBag.Location = new System.Drawing.Point(450, 54);
            this.lblBag.Name = "lblBag";
            this.lblBag.Size = new System.Drawing.Size(87, 19);
            this.lblBag.TabIndex = 23;
            this.lblBag.Text = "Bag Given?";
            // 
            // frmVisitorApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(569, 271);
            this.Controls.Add(this.lblBag);
            this.Controls.Add(this.lblVisitorName);
            this.Controls.Add(this.dtaVisitor);
            this.Controls.Add(this.chkBag);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblvlName);
            this.Controls.Add(this.lblvfName);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmVisitorApp";
            this.Text = "VisitorApp";
            this.Load += new System.EventHandler(this.frmVolunteerApp_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaVisitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label lblvfName;
        private System.Windows.Forms.Label lblvlName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.CheckBox chkBag;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtaVisitor;
        private System.Windows.Forms.Label lblVisitorName;
        private System.Windows.Forms.Label lblBag;
    }
}


partial class frmband
{
    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmband));
            this.btnExit = new System.Windows.Forms.Button();
            this.mnuFile = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBandName = new System.Windows.Forms.Label();
            this.lblBandContactName = new System.Windows.Forms.Label();
            this.lblContactEmail = new System.Windows.Forms.Label();
            this.lblContactPhone = new System.Windows.Forms.Label();
            this.lblperformancedate = new System.Windows.Forms.Label();
            this.lstBands = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearchPD = new System.Windows.Forms.Button();
            this.btnSortDate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblWestLafayetteFarmersMarket = new System.Windows.Forms.Label();
            this.lblBPN = new System.Windows.Forms.Label();
            this.txtBandName = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtContactEmail = new System.Windows.Forms.TextBox();
            this.txtContactPhone = new System.Windows.Forms.TextBox();
            this.txtPerformanceDate = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.mnuFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DimGray;
            this.btnExit.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.btnExit.Location = new System.Drawing.Point(676, 52);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "E&XIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mnuFile
            // 
            this.mnuFile.BackColor = System.Drawing.Color.ForestGreen;
            this.mnuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuFile.Location = new System.Drawing.Point(0, 0);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(795, 24);
            this.mnuFile.TabIndex = 2;
            this.mnuFile.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // lblBandName
            // 
            this.lblBandName.AutoSize = true;
            this.lblBandName.BackColor = System.Drawing.Color.DimGray;
            this.lblBandName.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lblBandName.Location = new System.Drawing.Point(12, 141);
            this.lblBandName.Name = "lblBandName";
            this.lblBandName.Size = new System.Drawing.Size(97, 19);
            this.lblBandName.TabIndex = 3;
            this.lblBandName.Text = "Band Name:";
            // 
            // lblBandContactName
            // 
            this.lblBandContactName.AutoSize = true;
            this.lblBandContactName.BackColor = System.Drawing.Color.DimGray;
            this.lblBandContactName.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lblBandContactName.Location = new System.Drawing.Point(12, 195);
            this.lblBandContactName.Name = "lblBandContactName";
            this.lblBandContactName.Size = new System.Drawing.Size(157, 19);
            this.lblBandContactName.TabIndex = 4;
            this.lblBandContactName.Text = "Band Contact Name:";
            // 
            // lblContactEmail
            // 
            this.lblContactEmail.AutoSize = true;
            this.lblContactEmail.BackColor = System.Drawing.Color.DimGray;
            this.lblContactEmail.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lblContactEmail.Location = new System.Drawing.Point(12, 261);
            this.lblContactEmail.Name = "lblContactEmail";
            this.lblContactEmail.Size = new System.Drawing.Size(112, 19);
            this.lblContactEmail.TabIndex = 5;
            this.lblContactEmail.Text = "Contact Email:";
            // 
            // lblContactPhone
            // 
            this.lblContactPhone.AutoSize = true;
            this.lblContactPhone.BackColor = System.Drawing.Color.DimGray;
            this.lblContactPhone.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lblContactPhone.Location = new System.Drawing.Point(12, 315);
            this.lblContactPhone.Name = "lblContactPhone";
            this.lblContactPhone.Size = new System.Drawing.Size(119, 19);
            this.lblContactPhone.TabIndex = 6;
            this.lblContactPhone.Text = "Contact Phone:";
            // 
            // lblperformancedate
            // 
            this.lblperformancedate.AutoSize = true;
            this.lblperformancedate.BackColor = System.Drawing.Color.DimGray;
            this.lblperformancedate.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lblperformancedate.Location = new System.Drawing.Point(12, 366);
            this.lblperformancedate.Name = "lblperformancedate";
            this.lblperformancedate.Size = new System.Drawing.Size(142, 19);
            this.lblperformancedate.TabIndex = 7;
            this.lblperformancedate.Text = "Performance Date:";
            // 
            // lstBands
            // 
            this.lstBands.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstBands.FormattingEnabled = true;
            this.lstBands.ItemHeight = 19;
            this.lstBands.Location = new System.Drawing.Point(305, 117);
            this.lstBands.Name = "lstBands";
            this.lstBands.Size = new System.Drawing.Size(478, 403);
            this.lstBands.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.button1.Location = new System.Drawing.Point(305, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Search &Band Name";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnSearchPD
            // 
            this.btnSearchPD.BackColor = System.Drawing.Color.DimGray;
            this.btnSearchPD.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.btnSearchPD.Location = new System.Drawing.Point(305, 66);
            this.btnSearchPD.Name = "btnSearchPD";
            this.btnSearchPD.Size = new System.Drawing.Size(138, 23);
            this.btnSearchPD.TabIndex = 10;
            this.btnSearchPD.Text = "Search &Performance Date";
            this.btnSearchPD.UseVisualStyleBackColor = false;
            // 
            // btnSortDate
            // 
            this.btnSortDate.BackColor = System.Drawing.Color.DimGray;
            this.btnSortDate.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.btnSortDate.Location = new System.Drawing.Point(449, 36);
            this.btnSortDate.Name = "btnSortDate";
            this.btnSortDate.Size = new System.Drawing.Size(75, 23);
            this.btnSortDate.TabIndex = 11;
            this.btnSortDate.Text = "Sort &Date";
            this.btnSortDate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DimGray;
            this.btnAdd.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.btnAdd.Location = new System.Drawing.Point(449, 64);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DimGray;
            this.btnUpdate.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.btnUpdate.Location = new System.Drawing.Point(553, 36);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DimGray;
            this.btnDelete.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.btnDelete.Location = new System.Drawing.Point(554, 64);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // lblWestLafayetteFarmersMarket
            // 
            this.lblWestLafayetteFarmersMarket.AutoSize = true;
            this.lblWestLafayetteFarmersMarket.BackColor = System.Drawing.Color.DimGray;
            this.lblWestLafayetteFarmersMarket.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWestLafayetteFarmersMarket.Location = new System.Drawing.Point(27, 36);
            this.lblWestLafayetteFarmersMarket.Name = "lblWestLafayetteFarmersMarket";
            this.lblWestLafayetteFarmersMarket.Size = new System.Drawing.Size(228, 19);
            this.lblWestLafayetteFarmersMarket.TabIndex = 15;
            this.lblWestLafayetteFarmersMarket.Text = "West Lafayette Farmer\'s Market";
            // 
            // lblBPN
            // 
            this.lblBPN.AutoSize = true;
            this.lblBPN.BackColor = System.Drawing.Color.DimGray;
            this.lblBPN.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lblBPN.Location = new System.Drawing.Point(12, 430);
            this.lblBPN.Name = "lblBPN";
            this.lblBPN.Size = new System.Drawing.Size(190, 19);
            this.lblBPN.TabIndex = 16;
            this.lblBPN.Text = "Band Performance Notes:";
            // 
            // txtBandName
            // 
            this.txtBandName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBandName.Location = new System.Drawing.Point(129, 138);
            this.txtBandName.Name = "txtBandName";
            this.txtBandName.Size = new System.Drawing.Size(143, 27);
            this.txtBandName.TabIndex = 17;
            // 
            // txtContactName
            // 
            this.txtContactName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtContactName.Location = new System.Drawing.Point(129, 188);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(143, 27);
            this.txtContactName.TabIndex = 18;
            // 
            // txtContactEmail
            // 
            this.txtContactEmail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtContactEmail.Location = new System.Drawing.Point(129, 254);
            this.txtContactEmail.Name = "txtContactEmail";
            this.txtContactEmail.Size = new System.Drawing.Size(143, 27);
            this.txtContactEmail.TabIndex = 19;
            // 
            // txtContactPhone
            // 
            this.txtContactPhone.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtContactPhone.Location = new System.Drawing.Point(129, 308);
            this.txtContactPhone.Name = "txtContactPhone";
            this.txtContactPhone.Size = new System.Drawing.Size(143, 27);
            this.txtContactPhone.TabIndex = 20;
            // 
            // txtPerformanceDate
            // 
            this.txtPerformanceDate.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPerformanceDate.Location = new System.Drawing.Point(129, 359);
            this.txtPerformanceDate.Name = "txtPerformanceDate";
            this.txtPerformanceDate.Size = new System.Drawing.Size(143, 27);
            this.txtPerformanceDate.TabIndex = 21;
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNotes.Location = new System.Drawing.Point(15, 453);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(261, 27);
            this.txtNotes.TabIndex = 22;
            // 
            // frmband
            // 
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(795, 535);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtPerformanceDate);
            this.Controls.Add(this.txtContactPhone);
            this.Controls.Add(this.txtContactEmail);
            this.Controls.Add(this.txtContactName);
            this.Controls.Add(this.txtBandName);
            this.Controls.Add(this.lblBPN);
            this.Controls.Add(this.lblWestLafayetteFarmersMarket);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSortDate);
            this.Controls.Add(this.btnSearchPD);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstBands);
            this.Controls.Add(this.lblperformancedate);
            this.Controls.Add(this.lblContactPhone);
            this.Controls.Add(this.lblContactEmail);
            this.Controls.Add(this.lblBandContactName);
            this.Controls.Add(this.lblBandName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.mnuFile);
            this.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuFile;
            this.Name = "frmband";
            this.Text = "Master Marketplace";
            this.mnuFile.ResumeLayout(false);
            this.mnuFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.MenuStrip mnuFile;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    private System.Windows.Forms.Label lblBandName;
    private System.Windows.Forms.Label lblBandContactName;
    private System.Windows.Forms.Label lblContactEmail;
    private System.Windows.Forms.Label lblContactPhone;
    private System.Windows.Forms.Label lblperformancedate;
    private System.Windows.Forms.ListBox lstBands;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button btnSearchPD;
    private System.Windows.Forms.Button btnSortDate;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Label lblWestLafayetteFarmersMarket;
    private System.Windows.Forms.Label lblBPN;
    private System.Windows.Forms.TextBox txtBandName;
    private System.Windows.Forms.TextBox txtContactName;
    private System.Windows.Forms.TextBox txtContactEmail;
    private System.Windows.Forms.TextBox txtContactPhone;
    private System.Windows.Forms.TextBox txtPerformanceDate;
    private System.Windows.Forms.TextBox txtNotes;
}
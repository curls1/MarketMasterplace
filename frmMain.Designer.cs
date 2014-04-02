partial class frmMain
{
    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.btnOK = new System.Windows.Forms.Button();
        this.btnExit = new System.Windows.Forms.Button();
        this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
        this.menuStrip1.SuspendLayout();
        this.SuspendLayout();
        // 
        // btnOK
        // 
        this.btnOK.Location = new System.Drawing.Point(168, 217);
        this.btnOK.Name = "btnOK";
        this.btnOK.Size = new System.Drawing.Size(75, 23);
        this.btnOK.TabIndex = 0;
        this.btnOK.Text = "&OK";
        this.btnOK.UseVisualStyleBackColor = true;
        this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
        // 
        // btnExit
        // 
        this.btnExit.Location = new System.Drawing.Point(264, 217);
        this.btnExit.Name = "btnExit";
        this.btnExit.Size = new System.Drawing.Size(75, 23);
        this.btnExit.TabIndex = 1;
        this.btnExit.Text = "E&XIT";
        this.btnExit.UseVisualStyleBackColor = true;
        this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
        // 
        // menuStrip1
        // 
        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Size = new System.Drawing.Size(351, 24);
        this.menuStrip1.TabIndex = 2;
        this.menuStrip1.Text = "menuStrip1";
        // 
        // mnuFile
        // 
        this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpen,
            this.mnuFileExit});
        this.mnuFile.Name = "mnuFile";
        this.mnuFile.Size = new System.Drawing.Size(37, 20);
        this.mnuFile.Text = "&File";
        // 
        // mnuFileOpen
        // 
        this.mnuFileOpen.Name = "mnuFileOpen";
        this.mnuFileOpen.Size = new System.Drawing.Size(152, 22);
        this.mnuFileOpen.Text = "&Open";
        this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
        // 
        // mnuFileExit
        // 
        this.mnuFileExit.Name = "mnuFileExit";
        this.mnuFileExit.Size = new System.Drawing.Size(152, 22);
        this.mnuFileExit.Text = "E&xit";
        this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
        // 
        // frmMain
        // 
        this.ClientSize = new System.Drawing.Size(351, 262);
        this.Controls.Add(this.btnExit);
        this.Controls.Add(this.btnOK);
        this.Controls.Add(this.menuStrip1);
        this.MainMenuStrip = this.menuStrip1;
        this.Name = "frmMain";
        this.Text = "My First C# Application by Alka Harriger";
        this.menuStrip1.ResumeLayout(false);
        this.menuStrip1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem mnuFile;
    private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
    private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
}
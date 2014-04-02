//THIS IS AN EDIT FROM JIM

using System;
using System.Windows.Forms;               // For UI controls.
using System.Threading;                   // When using menus and needing to control threading.
using System.Data.OleDb;                  // For OLE DB objects (also added reference to System.Data).
using System.Collections;                 // For using ArrayLists.
using System.IO;                          // For some file methods, when using file menus.
using System.Configuration;               // To access the app.config data (also add reference to System.Configuration).

using MarketMasterplace.lib;              // local lib 

// Name:   frmMain.cs has the C# code for XXXX
// Author: Alka Harriger
// Date:   4/1/13
//
// This application gets XXX and then produces XXXX.

public partial class frmMain : Form
{
    [STAThread]

    public static void Main()
    {
        NLUtility.log("frmMain.Main()");

        frmMain main = new frmMain();
        Application.Run(main);
    }

    public frmMain()
    {
        NLUtility.log("frmMain constructor");

        InitializeComponent();
    }
    
    private void frmMain_Load(object sender, EventArgs e)
    {
        NLUtility.log("frmMain.frmMain_Load()");
    }
    
    // When File-Exit is clicked, the program terminates.
    private void mnuFileExit_Click(object sender, EventArgs e)
    {
        NLUtility.log("frmMain.mnuFileExit_Click()");

        Close();
    }

    // The btnExit_Click method terminates the program when the EXIT button is clicked.
    private void btnExit_Click(object sender, EventArgs e)
    {
        NLUtility.log("frmMain.btnExit_Click()");

        Close();
    }

    // When File-Open is clicked, the program gets the filename that the user wishes to use for the 
    // application & stores the name in the class-scope variable that other methods will use.
    private void mnuFileOpen_Click(object sender, EventArgs e)
    {
        NLUtility.log("frmMain.mnuFileOpen_Click()");

        OpenFileDialog ofd;
        try
        {
            ofd = new OpenFileDialog();
            ofd.Title = "Select the database file to open";
            ofd.Filter = "Database files (*.accdb)|*.accdb|All files (*.*)|*.*";
            ofd.InitialDirectory = Path.Combine(Application.StartupPath, @"\Databases");
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //mUserFile = ofd.FileName;
                MMPDB.mUserFile = ofd.FileName;
            }
        }
        catch (Exception ex)
        {
            NLUtility.ShowMessage("There was an unexpected problem using the open file dialogue:" + ex.Message);
        }

        // Add code here to actually load the data and display where appropriate.

    }



}
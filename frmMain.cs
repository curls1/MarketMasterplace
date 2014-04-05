using System;
using System.Windows.Forms;               // For UI controls.
using System.Threading;                   // When using menus and needing to control threading.
using System.Data.OleDb;                  // For OLE DB objects (also added reference to System.Data).
using System.Collections;                 // For using ArrayLists.
using System.IO;                          // For some file methods, when using file menus.
using System.Configuration;               // To access the app.config data (also add reference to System.Configuration).
using MarketMasterplace; 

// Name:   MarketMasterplace (frmMain)
// Author: Nicole Hands, Alex Hirsch, Zach Escallier, David McNutt
// Date:   4/1/14
//
// Description: This program will allow the Market Masters of the West Lafayette Farmer's Market to manage 

public partial class frmMain : Form
{
    [STAThread]

    public static void Main()
    {
        frmMain main = new frmMain();
        Application.Run(main);
    }

    // Class scope variables and objects.
    private string mUserFile;
    private OleDbConnection mDB;
    frmband band;
    frmVendDataEntry vendDisplay;
    frmVendViewDetail vendView;
    frmVisitorApp visitor;
    frmMain main; 
    
    public frmMain()
    {
        InitializeComponent();
        visitor = new frmVisitorApp();
        vendView = new frmVendViewDetail();
        band = new frmband();
        vendDisplay = new frmVendDataEntry();
    }

    // When File-Exit is clicked, the program terminates.
    private void mnuFileExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    // The btnExit_Click method terminates the program when the EXIT button is clicked.
    private void btnExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    // When File-Open is clicked, the program gets the filename that the user wishes to use for the 
    // application & stores the name in the class-scope variable that other methods will use.
    private void mnuFileOpen_Click(object sender, EventArgs e)
    {
        OpenFileDialog ofd;
        try
        {
            ofd = new OpenFileDialog();
            ofd.Title = "Select the database file to open";
            ofd.Filter = "Database files (*.accdb)|*.accdb|All files (*.*)|*.*";
            ofd.InitialDirectory = Path.Combine(Application.StartupPath, @"\Databases");
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                mUserFile = ofd.FileName;
            }
        }
        catch (Exception ex)
        {
            MarketMasterplace.lib.NLUtility.ShowMessage("There was an unexpected problem opening the file: " + ex.Message);
        }

        // Add code here to actually load the data and display where appropriate.

    }

    private void btnVendor_Click(object sender, EventArgs e)
    {
        vendView = new frmVendViewDetail(); //new instance of form
        vendView.FormClosed += new FormClosedEventHandler(vendDisplay_FormClosed); //catch when child form is closed
        vendView.Show(); //show child form
        this.Hide(); //hide parent form
    }

    //event handler for child form
    private void vendDisplay_FormClosed(object sender, FormClosedEventArgs e)
    {
        this.Show(); //when the sub-form is closed, form main reappears
    }

    private void btnVolunteer_Click(object sender, EventArgs e)
    {
        //volunteer = new frmVolunteer(); //new instance of form
        //volunteer.FormClosed += new FormClosedEventHandler(vendDisplay_FormClosed); //catch when child form is closed
        //volunteer.Show(); //show child form
        this.Hide(); //hide parent form
    }

    //event handler for child form
    private void volunteer_FormClosed(object sender, FormClosedEventArgs e)
    {
        this.Show(); //when the sub-form is closed, form main reappears
    }

    private void btnVisitor_Click(object sender, EventArgs e)
    {
        visitor = new frmVisitorApp(); //new instance of form
        visitor.FormClosed += new FormClosedEventHandler(vendDisplay_FormClosed); //catch when child form is closed
        visitor.Show(); //show child form
        this.Hide(); //hide parent form
    }

    //event handler for child form
    private void visitor_FormClosed(object sender, FormClosedEventArgs e)
    {
        this.Show(); //when the sub-form is closed, form main reappears
    }

    private void btnEntertainer_Click(object sender, EventArgs e)
    {
        band = new frmband(); //new instance of form
        band.FormClosed += new FormClosedEventHandler(vendDisplay_FormClosed); //catch when child form is closed
        band.Show(); //show child form
        this.Hide(); //hide parent form
    }

    //event handler for child form
    private void band_FormClosed(object sender, FormClosedEventArgs e)
    {
        this.Show(); //when the sub-form is closed, form main reappears
    }
    
    
    
    
    
    
    
    //// The overloaded validateInput helper methods handle the existence check, type check, and range check for a given 
    //// input form object and assigns the equivalent value to its corresponding variable. (This one handles int data.)
    //private bool validateInput(TextBox txtInput, int min, int max, out int userInput)
    //{
    //    string fieldName;
    //    fieldName = txtInput.Name.Substring(3);
    //    userInput = 0;
    //    if (txtInput.Text == "")
    //    {
    //        ShowMessage("Please enter a value for " + fieldName);
    //        txtInput.Focus();
    //        return false;
    //    }
    //    if (int.TryParse(txtInput.Text, out userInput) == false)
    //    {
    //        ShowMessage("Only numbers are allowed for " + fieldName + ". Please re-enter:");
    //        txtInput.Focus();
    //        return false;
    //    }
    //    if (userInput < min || userInput > max)
    //    {
    //        ShowMessage(fieldName + " must be between " + min.ToString() + " and " + max.ToString());
    //        txtInput.Focus();
    //        return false;
    //    }
    //    return true;
    //}

    //// The overloaded validateInput helper methods handle the existence check, type check, and range check for a given 
    //// input form object and assigns the equivalent value to its corresponding variable. (This one handles double data.)
    //private bool validateInput(TextBox txtInput, double min, double max, out double userInput)
    //{
    //    string fieldName;
    //    fieldName = txtInput.Name.Substring(3);
    //    userInput = 0D;
    //    if (txtInput.Text == "")
    //    {
    //        ShowMessage("Please enter a value for " + fieldName);
    //        txtInput.Focus();
    //        return false;
    //    }
    //    if (double.TryParse(txtInput.Text, out userInput) == false)
    //    {
    //        ShowMessage("Only numbers are allowed for " + fieldName + ". Please re-enter:");
    //        txtInput.Focus();
    //        return false;
    //    }
    //    if (userInput < min || userInput > max)
    //    {
    //        ShowMessage(fieldName + " must be between " + min.ToString() + " and " + max.ToString());
    //        txtInput.Focus();
    //        return false;
    //    }
    //    return true;
    //}

    //// The overloaded validateInput helper methods handle the existence check, type check, and range check for a given 
    //// input form object and assigns the equivalent value to its corresponding variable. (This one handles decimal data.)
    //private bool validateInput(TextBox txtInput, decimal min, decimal max, out decimal userInput)
    //{
    //    string fieldName;
    //    fieldName = txtInput.Name.Substring(3);
    //    userInput = 0M;
    //    if (txtInput.Text == "")
    //    {
    //        ShowMessage("Please enter a value for " + fieldName);
    //        txtInput.Focus();
    //        return false;
    //    }
    //    if (decimal.TryParse(txtInput.Text, out userInput) == false)
    //    {
    //        ShowMessage("Only numbers are allowed for " + fieldName + ". Please re-enter:");
    //        txtInput.Focus();
    //        return false;
    //    }
    //    if (userInput < min || userInput > max)
    //    {
    //        ShowMessage(fieldName + " must be between " + min.ToString() + " and " + max.ToString());
    //        txtInput.Focus();
    //        return false;
    //    }
    //    return true;
    //}

    //// The overloaded validateInput helper methods handle the existence check, type check, and range check for a given 
    //// input form object and assigns the equivalent value to its corresponding variable. (This one handles DateTime data.)
    //private bool validateInput(TextBox txtInput, DateTime min, DateTime max, out DateTime userInput)
    //{
    //    string fieldName;
    //    fieldName = txtInput.Name.Substring(3);
    //    userInput = DateTime.Parse("01/01/1900");
    //    if (txtInput.Text == "")
    //    {
    //        ShowMessage("Please enter a date in the format mm/dd/yyyy for " + fieldName);
    //        txtInput.Focus();
    //        return false;
    //    }
    //    if (DateTime.TryParse(txtInput.Text, out userInput) == false)
    //    {
    //        ShowMessage("Only dates are allowed for " + fieldName + ". Please re-enter:");
    //        txtInput.Focus();
    //        return false;
    //    }
    //    if (userInput < min || userInput > max)
    //    {
    //        ShowMessage(fieldName + " must be between " + min.ToShortDateString() + " and " + max.ToShortDateString());
    //        txtInput.Focus();
    //        return false;
    //    }
    //    return true;
    //}

    //// The overloaded validateInput helper methods handle the existence check for a given Boolean input form object 
    //// and assigns the equivalent value to its corresponding variable. 
    //private bool validateInput(TextBox txtInput, out bool userInput)
    //{
    //    string fieldName;
    //    fieldName = txtInput.Name.Substring(3);
    //    userInput = false;
    //    if (txtInput.Text == "")
    //    {
    //        ShowMessage("Please enter a value for " + fieldName);
    //        txtInput.Focus();
    //        return false;
    //    }
    //    userInput = bool.Parse(txtInput.Text);
    //    return true;
    //}

    //// The overloaded validateInput helper method handles the existence check for a given string input form object 
    //// and assigns the equivalent value to its corresponding variable. 
    //private bool validateInput(TextBox txtInput, out string userInput)
    //{
    //    string fieldName;
    //    fieldName = txtInput.Name.Substring(3);
    //    userInput = "";
    //    if (txtInput.Text == "")
    //    {
    //        ShowMessage("Please enter a value for " + fieldName);
    //        txtInput.Focus();
    //        return false;
    //    }
    //    userInput = txtInput.Text;
    //    return true;
    //}

    //// The ShowMessage helper method displays an error message with a standard title and an OK button.
    //private void ShowMessage(string msg)
    //{
    //    MessageBox.Show(msg, "Message from Application", MessageBoxButtons.OK);
    //}

    //// This helper method is used to open a connection to the database.
    //private void openDatabaseConnection()
    //{
    //    string connectionString = ConfigurationManager.AppSettings["DBConnectionString"] + mUserFile;
    //    mDB = new OleDbConnection(connectionString);
    //}

    //// This helper method releases the DB connection.
    //private void closeDatabaseConnection()
    //{
    //    if (mDB != null)
    //    {
    //        mDB.Close();
    //    }
    //}

}
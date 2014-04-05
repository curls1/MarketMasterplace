using System;
using System.Windows.Forms;
using System.IO;                          // For some file methods, when using file menus.
using System.Configuration;               // To access the app.config data (also add reference to System.Configuration).
using MarketMasterplace;


namespace MarketMasterplace
{
    public partial class frmVisitorApp : Form
    {
        public static void Visitor()
        {
            frmVisitorApp visitor = new frmVisitorApp();
            Application.Run(visitor);
        }
        
        public frmVisitorApp()
        {
            InitializeComponent();
        }

        private void frmVolunteerApp_Load(object sender, EventArgs e)
        {
            //MarketMasterplace.lib.NLUtility.validateInput(
        }
    }
}

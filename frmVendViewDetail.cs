using System;
using System.Windows.Forms;               // For UI controls.
using System.Threading;                   // When using menus and needing to control threading.
using System.Data.OleDb;                  // For OLE DB objects (also added reference to System.Data).
using System.Collections;                 // For using ArrayLists.
using System.IO;                          // For some file methods, when using file menus.
using System.Configuration;               // To access the app.config data (also add reference to System.Configuration).
using MarketMasterplace; 


namespace MarketMasterplace
{
    public partial class frmVendViewDetail : Form
    {
        public static void VendorViewDetail()
        {
            frmVendViewDetail vendorEntry = new frmVendViewDetail();
            Application.Run(vendorEntry);
        }

        public frmVendViewDetail()
        {
            InitializeComponent();
        }

        frmVendDataEntry vendorDataEntry;

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            vendorDataEntry = new frmVendDataEntry();
            vendorDataEntry.FormClosed += new FormClosedEventHandler(vendorEntry_FormClosed);
            vendorDataEntry.Show();
            this.Hide();
        }

        private void vendorEntry_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
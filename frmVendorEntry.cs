using System;
using System.Windows.Forms;
using System.IO;                          // For some file methods, when using file menus.
using System.Configuration;               // To access the app.config data (also add reference to System.Configuration).


namespace MarketMasterplace
{
    public partial class frmVendorEntry : Form
    {
        public static void VendorEntry()
        {
            frmVendorEntry vendorEntry = new frmVendorEntry();
            Application.Run(vendorEntry);
        }

        public frmVendorEntry()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

}
    //public partial class frmband : Form
    //{
    //    public static void Band()
    //    {
    //        frmband band = new frmband();
    //        Application.Run(band);
    //    }

    //    public frmband()
    //    {
    //        InitializeComponent();
    //    }

    //    private void btnExit_Click(object sender, EventArgs e)
    //    {
    //        Close();
    //    }


    //}


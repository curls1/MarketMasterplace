using System;
using System.Windows.Forms;
using System.IO;                          // For some file methods, when using file menus.
using System.Configuration;               // To access the app.config data (also add reference to System.Configuration).
using MarketMasterplace; 



namespace MarketMasterplace
{
    public partial class frmVendDataEntry : Form
    {
        public static void VendorDisplay()
        {
            frmVendDataEntry vendorDisplay = new frmVendDataEntry();
            Application.Run(vendorDisplay);
        }


        public frmVendDataEntry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
       
    }

}
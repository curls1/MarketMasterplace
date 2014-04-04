﻿using System;
using System.Windows.Forms;
using System.IO;                          // For some file methods, when using file menus.
using System.Configuration;               // To access the app.config data (also add reference to System.Configuration).



namespace MarketMasterplace
{
    public partial class frmVendorDisplay : Form
    {
        public static void VendorDisplay()
        {
            frmVendorDisplay vendorDisplay = new frmVendorDisplay();
            Application.Run(vendorDisplay);
        }


        public frmVendorDisplay()
        {
            InitializeComponent();
        }

    }

}
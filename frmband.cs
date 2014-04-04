using System;
using System.Windows.Forms;
using System.IO;                          // For some file methods, when using file menus.
using System.Configuration;               // To access the app.config data (also add reference to System.Configuration).



    public partial class frmband : Form
    {
        public static void Band()
        {
            frmband band = new frmband();
            Application.Run(band);
        }

        public frmband()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }


    }

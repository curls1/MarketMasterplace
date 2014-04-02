using System;
using System.Windows.Forms;               // For UI controls.
using System.Threading;                   // When using menus and needing to control threading.
using System.Data.OleDb;                  // For OLE DB objects (also added reference to System.Data).
using System.Collections;                 // For using ArrayLists.
using System.IO;                          // For some file methods, when using file menus.
using System.Configuration;               // To access the app.config data (also add reference to System.Configuration).
using System.Drawing;                     // color, interface

using MarketMasterplace.lib;

namespace MarketMasterplace.lib

{
    public class NLDataGridView : System.Windows.Forms.DataGridView
    {

        public void configureDefault()
        {

            this.AutoGenerateColumns = false;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToOrderColumns = false;
            this.AllowUserToResizeColumns = true;
            this.AllowUserToResizeRows = true;
            this.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.MultiSelect = false;
            this.RowHeadersVisible = false;

            this.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

        }

        public void configAutoSort()
        {
            foreach (DataGridViewColumn c in this.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.Automatic;
            }

        }

    }

}

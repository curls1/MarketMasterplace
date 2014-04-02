using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace MarketMasterplace.lib

{
    class NLDataGridView : System.Windows.Forms.DataGridView
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

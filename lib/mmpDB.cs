using System;
using System.Data.OleDb;    // For OLE DB objects (also added reference to System.Data).
using System.Collections;   // For using ArrayLists.
using System.IO;            // For some file methods, when using file menus.
using System.Configuration; // To access the app.config data (also add reference to System.Configuration).
using System.Data;          // for the love of data

namespace MarketMasterplace.lib
{
    public static class MMPDB
    {

        // Class scope variables and objects.
        public static string mUserFile;
        public static OleDbConnection mConn;

        // This helper method is used to open a connection to the database.
        public static void openDatabaseConnection()
        {
            string connectionString = ConfigurationManager.AppSettings["DBConnectionString"] + mUserFile;
            mConn = new OleDbConnection(connectionString);
        }

        // This helper method releases the DB connection.
        public static void closeDatabaseConnection()
        {
            if (mConn != null)
            {
                mConn.Close();
            }
        }

        public static DataSet execQuery(string sql)
        {
            mConn.Open();

            OleDbCommand cmd = new OleDbCommand(sql, mConn);
            IDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            mConn.Close();

            return ds;
        }

        public static void execNonQuery(string sql)
        {
            mConn.Open();

            OleDbCommand cmd = new OleDbCommand(sql, mConn);
            cmd.ExecuteNonQuery();

            mConn.Close();
        }

    }
}



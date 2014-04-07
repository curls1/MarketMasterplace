using System;
using System.Data.OleDb;
using MarketMasterplace;

    class clsMarketAttend
    {
        private DateTime mMarketDate;

        public clsMarketAttend()
        {
            mMarketDate = DateTime.Today;
        }

        public clsMarketAttend(DateTime marketDate)
        {
            mMarketDate = marketDate;
        }

        public DateTime MarketDate
        {
            get
            {
                return mMarketDate;
            }
            set
            {
                mMarketDate = value;
            }
        }

    }

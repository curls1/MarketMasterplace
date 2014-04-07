using System;
using MarketMasterplace;

    class clsVisit
    {
        private string mEmailAddr;
        private DateTime mVisitDate;

        public clsVisit()
        {
            mVisitDate = DateTime.Today;
        }

        public clsVisit(DateTime marketDate)
        {
            mVisitDate = marketDate;
        }

        public DateTime MarketDate
        {
            get
            {
                return mVisitDate;
            }
            set
            {
                mVisitDate = value;
            }
        }
    }

    class clsVisitor
    {
        private string mVisitorFName;
        private string mVisitorLName;
    }

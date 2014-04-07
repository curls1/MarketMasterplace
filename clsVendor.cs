using System;
using System.Data.OleDb;
using MarketMasterplace;

    public class clsVendor
    {
        //define class data members
        private string mVendorFirstName;
        private string mVendorLastName;
        private string mVendorBusinessName;
        private string mVendorStreetAddress;
        private string mVendorCity;
        private string mVendorState;
        private string mVendorZip;
        private string mVendorStatus;
        private string mVendorLoadGroup;
        private int mVendorPointValue;
        private string mVendorEmail;
        private string mVendorProductionAddress;
        private bool mCSAAvailability;


        //define class constructors
        public clsVendor()
        {
            mVendorFirstName = "";
            mVendorLastName = "";
            mVendorBusinessName = "";
            mVendorStreetAddress = "";
            mVendorCity = "";
            mVendorState = "";
            mVendorZip = "";
            mVendorStatus = "";
            mVendorPointValue = 0;
            mVendorEmail = "";
            mVendorProductionAddress = ""; 
            mCSAAvailability = false;
        }

        public clsVendor(string fName, string lName, string BusinName, string street, string city, 
            string state, string zip, string status, int points, string email, string prodAddr, bool csa)
        {
            mVendorFirstName = fName;
            mVendorLastName = lName;
            mVendorBusinessName = BusinName;
            mVendorStreetAddress = street;
            mVendorCity = city;
            mVendorState = state;
            mVendorZip = zip;
            mVendorStatus = status;
            mVendorPointValue = points;
            mVendorEmail = email;
            mVendorProductionAddress = prodAddr;
            mCSAAvailability = csa;
        }

        //accessor methods for class

        public string FirstName
        {
            get
            {
                return mVendorFirstName;
            }

            set
            {
                mVendorFirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return mVendorLastName;
            }

            set
            {
                mVendorLastName = value;
            }
        }

        public string BusinessName
        {
            get
            {
                return mVendorBusinessName;
            }
            set
            {
                mVendorBusinessName = value; 
            }
        }
        public string MailingAddress
        {
            get
            {
                return mVendorStreetAddress;
            }
            set
            {
                mVendorStreetAddress = value;
            }
        }

        public string City
        {
            get
            {
                return mVendorCity;
            }
            set
            {
                mVendorCity = value;
            }
        }

        public string State
        {
            get
            {
                return mVendorState;
            }
            set
            {
                mVendorState = value;
            }
        }

        public string Zip
        {
            get
            {
                return mVendorZip;
            }
            set
            {
                mVendorZip = value;
            }
        }

        public string Status
        {
            get
            {
                return mVendorStatus;
            }
            set
            {
                mVendorStatus = value;
            }
        }

        public string LoadGroup
        {
            get
            {
                return mVendorLoadGroup;
            }
            set
            {
                mVendorLoadGroup = value;
            }
        }

        public int PointValue
        {
            get
            {
                return mVendorPointValue;
            }
            set
            {
                mVendorPointValue = value;
            }
        }

        public string Email
        {
            get
            {
                return mVendorEmail;
            }
            set
            {
                mVendorEmail = value;
            }
        }

        public string ProductionAddress
        {
            get
            {
                return mVendorProductionAddress;
            }
            set
            {
                mVendorProductionAddress = value;
            }
        }

        public bool CSAAvailable
        {
            get
            {
                return mCSAAvailability;
            }
            set
            {
                mCSAAvailability = value;
            }
        }
    }

    public class clsVendorBooth
    { 
        
            private int mBoothID;
            private string mBoothDescription;

            public clsVendorBooth()
            {
                mBoothID = 0;
                mBoothDescription = "";
            }
            public clsVendorBooth(int ID, string description)
            {
                mBoothID = ID;
                mBoothDescription = description;
            }

            public int BoothID
            {
                get 
                {
                    return mBoothID; 
                }
                set
                {
                    mBoothID = value; 
                }

            }
            public string BoothDescript
            {
                get 
                {
                    return mBoothDescription;
                }
                set 
                {
                    mBoothDescription = value; 
                }
            }
    }

    public class clsVendorContract
    {
        private int mContractID;
        private DateTime mContractEffectiveDate;
        private bool mFeePaid;
        private string mContractType;

        public clsVendorContract()
        {
            mContractID = 0;
            mContractEffectiveDate = DateTime.Today;
            mFeePaid = false;
            mContractType = "";
        }

        public clsVendorContract(int ID, DateTime effectiveDate, bool FeePaid, string type)
        {
            mContractID = ID;
            mContractEffectiveDate = effectiveDate;
            mFeePaid = FeePaid;
            mContractType = type;
        }
        
        public int ContractID
        {
            get
            {
                return mContractID;
            }
            set
            {
                mContractID = value; 
            }
        }
        
        public DateTime EffectiveDate
        {
            get 
            {
                return mContractEffectiveDate; 
            }
            set
            {
                mContractEffectiveDate = value;
            }
        }

        public bool FeePaid
        {
            get
            {
                return mFeePaid; 
            }
            set
            {
                mFeePaid = value; 
            }
        }

        public string ContractType
        {
            get
            {
                return mContractType;
            }
            set
            {
                mContractType = value; 
            }
        }
    }
    
    public class clsVendorEquipment
    {
        private int mEquipmentCode;
        private string mEquipmentDescription;
    
        public clsVendorEquipment()
        {
            mEquipmentCode = 0; 
            mEquipmentDescription = "";
        }

        public clsVendorEquipment(int code, string description)
        {
            mEquipmentCode = code;
            mEquipmentDescription = description;
        }

        public int Code
        {
            get 
            {
                return mEquipmentCode;
            }
            set
            {
                mEquipmentCode = value; 
            }
        
        }

        public string Description
        {
            get
            {
                return mEquipmentDescription; 
            }
            set
            {
                mEquipmentDescription = value;
            }
        }
    
    }

    public class clsVendorCategory
    {
        private int mCategoryID;
        private string mCategoryName;
        private string mCategoryRequirements;
            
        public clsVendorCategory()
        {
            mCategoryID = 0; 
            mCategoryName = "";
            mCategoryRequirements = "";
        }
        
        public clsVendorCategory(int ID, string Name, string Requirements)
        {
            mCategoryID = ID;
            mCategoryName = Name; 
            mCategoryRequirements = Requirements;
        }

        public int ID
        {
            get
            {
                return mCategoryID;
            }
            set
            {
                mCategoryID = value;
            }
        }

        public string CategoryName
        {
            get
            {
                return mCategoryName;
            }
            set
            {
                mCategoryName = value; 
            }
        }

        public string CategoryRequirements
        {
            get
            {
                return mCategoryRequirements;
            }
            set
            {
                mCategoryRequirements = value; 
            }
        }
}





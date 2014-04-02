using System;

public class clsFileHandler
{
    // List of the class data members.

    private string mName;
    private DateTime mDate;
    private int mNumber;
    private float mValue;

    // ----------- Class constructors ----------------

    public clsFileHandler()
    {
        mName = "";
        mDate = DateTime.Now;
        mNumber = 0;
        mValue = 0F;
    }

    public clsFileHandler(string myName, DateTime myDate, int myNumber, float myValue)
    {
        mName = myName;
        mDate = myDate;
        mNumber = myNumber;
        mValue = myValue;
    }

    // ----------- Accessor methods for data members ----------------

    // Purpose: Reads or writes the mName data member.
    public string MyName
    {
        get
        {
            return mName;
        }

        set
        {
            mName = value;
        }
    }

    public DateTime MyDate
    {
        get
        {
            return mDate;
        }

        set
        {
            mDate = value;
        }
    }

    public int MyNumber
    {
        get
        {
            return mNumber;
        }

        set
        {
            mNumber = value;
        }
    }

    public float MyValue
    {
        get
        {
            return mValue;
        }

        set
        {
            mValue = value;
        }
    }

    // ----------- End Accessor methods for data members ------------

    // Purpose:  Returns a string containing the object's state.
    public string Serialize()
    {
        return mName + "\t"
            + mDate.ToString() + "\t"
            + mNumber.ToString() + "\t"
            + mValue.ToString();
    }

    // Purpose: Populates the object's state from a serialized string.
    public void Deserialize(string serializedRecord)
    {
        string[] values = serializedRecord.Split('\t');

        mName = values[0];
        mDate = DateTime.Parse(values[1]);
        mNumber = int.Parse(values[2]);
        mValue = float.Parse(values[3]);
    }

}
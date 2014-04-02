using System;

public class clsSQL
{
    public static string ToSql(bool boolValue)
    {
        return boolValue.ToString();
    }

    public static string ToSql(DateTime dateTimeValue)
    {
        return "'" + dateTimeValue.ToShortDateString() + "'";
    }

    public static string ToSql(decimal decimalValue)
    {
        return decimalValue.ToString();
    }

    public static string ToSql(int intValue)
    {
        return intValue.ToString();
    }

    public static string ToSql(double doubleValue)
    {
        return doubleValue.ToString();
    }

    public static string ToSql(string stringValue)
    {
        return "'" + stringValue.Replace("'", "''") + "'";
    }
}

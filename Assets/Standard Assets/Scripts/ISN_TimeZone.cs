using UnityEngine;
public class ISN_TimeZone
{
    // Fields
    private long _SecondsFromGMT;
    private string _Name;
    private static ISN_TimeZone _LocalTimeZone;
    
    // Properties
    public string Name { get; }
    public long SecondsFromGMT { get; }
    public static ISN_TimeZone LocalTimeZone { get; }
    
    // Methods
    public ISN_TimeZone()
    {
        this._SecondsFromGMT = 7200;
        this._Name = "Europe/Kiev";
    }
    public ISN_TimeZone(string data)
    {
        this._SecondsFromGMT = 7200;
        this._Name = "Europe/Kiev";
        typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
        System.String[] val_1 = data.Split(separator:  null);
        this._Name = val_1[0];
        string val_4 = val_1[1];
        this._SecondsFromGMT = System.Convert.ToInt64(value:  0);
    }
    public string get_Name()
    {
        return (string)this._Name;
    }
    public long get_SecondsFromGMT()
    {
        return (long)this._SecondsFromGMT;
    }
    public static ISN_TimeZone get_LocalTimeZone()
    {
        ISN_TimeZone val_2;
        ISN_TimeZone val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(ISN_TimeZone._LocalTimeZone == null)
        {
                val_2 = val_3;
            val_3 = new ISN_TimeZone();
            val_4 = null;
            val_4 = null;
            ISN_TimeZone._LocalTimeZone = val_2;
            val_3 = null;
        }
        
        val_3 = null;
        return (ISN_TimeZone)ISN_TimeZone._LocalTimeZone;
    }
    private static ISN_TimeZone()
    {
    
    }

}

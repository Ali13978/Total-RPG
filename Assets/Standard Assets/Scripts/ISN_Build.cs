using UnityEngine;
public class ISN_Build
{
    // Fields
    private string _Version;
    private int _Number;
    private static ISN_Build _Current;
    
    // Properties
    public string Version { get; }
    public int Number { get; }
    public static ISN_Build Current { get; }
    
    // Methods
    public ISN_Build()
    {
        this._Number = 1;
        this._Version = "1.0";
    }
    public ISN_Build(string data)
    {
        string val_6;
        this._Version = "1.0";
        this._Number = 1;
        typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
        System.String[] val_1 = data.Split(separator:  null);
        this._Version = val_1[0];
        string val_2 = val_1[1].Trim();
        if((System.String.IsNullOrEmpty(value:  0)) != false)
        {
                val_6 = 1;
        }
        else
        {
                val_6 = 0;
        }
        
        this._Number = System.Convert.ToInt32(value:  val_6);
    }
    public string get_Version()
    {
        return (string)this._Version;
    }
    public int get_Number()
    {
        return (int)this._Number;
    }
    public static ISN_Build get_Current()
    {
        ISN_Build val_2;
        ISN_Build val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(ISN_Build._Current == null)
        {
                val_2 = val_3;
            val_3 = new ISN_Build();
            val_4 = null;
            val_4 = null;
            ISN_Build._Current = val_2;
            val_3 = null;
        }
        
        val_3 = null;
        return (ISN_Build)ISN_Build._Current;
    }
    private static ISN_Build()
    {
    
    }

}

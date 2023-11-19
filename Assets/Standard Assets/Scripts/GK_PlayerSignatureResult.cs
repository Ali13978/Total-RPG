using UnityEngine;
public class GK_PlayerSignatureResult : Result
{
    // Fields
    public string _PublicKeyUrl;
    public byte[] _Signature;
    public byte[] _Salt;
    public long _Timestamp;
    
    // Properties
    public string PublicKeyUrl { get; }
    public byte[] Signature { get; }
    public byte[] Salt { get; }
    public long Timestamp { get; }
    
    // Methods
    public GK_PlayerSignatureResult(string publicKeyUrl, string signature, string salt, string timestamp)
    {
        var val_10;
        var val_11;
        this._PublicKeyUrl = publicKeyUrl;
        typeof(System.Char[]).__il2cppRuntimeField_20 = 44;
        System.String[] val_1 = signature.Split(separator:  null);
        System.Collections.Generic.List<System.Byte> val_2 = new System.Collections.Generic.List<System.Byte>();
        val_10 = 0;
        goto label_4;
        label_11:
        Add(item:  W24);
        val_10 = 1;
        label_4:
        if(val_10 >= val_1.Length)
        {
            goto label_6;
        }
        
        string val_10 = val_1[1];
        byte val_3 = System.Convert.ToByte(value:  0);
        if(null != 0)
        {
            goto label_11;
        }
        
        goto label_11;
        label_6:
        this._Signature = ToArray();
        typeof(System.Char[]).__il2cppRuntimeField_20 = 44;
        System.Collections.Generic.List<System.Byte> val_6 = new System.Collections.Generic.List<System.Byte>();
        val_11 = 0;
        goto label_16;
        label_23:
        Add(item:  val_1);
        val_11 = 1;
        label_16:
        if(val_11 >= val_5.Length)
        {
            goto label_18;
        }
        
        string val_11 = salt.Split(separator:  null)[1];
        byte val_7 = System.Convert.ToByte(value:  0);
        if(null != 0)
        {
            goto label_23;
        }
        
        goto label_23;
        label_18:
        this._Salt = ToArray();
        this._Timestamp = System.Convert.ToInt64(value:  0);
    }
    public GK_PlayerSignatureResult(SA.Common.Models.Error errro)
    {
    
    }
    public string get_PublicKeyUrl()
    {
        return (string)this._PublicKeyUrl;
    }
    public byte[] get_Signature()
    {
        return (System.Byte[])this._Signature;
    }
    public byte[] get_Salt()
    {
        return (System.Byte[])this._Salt;
    }
    public long get_Timestamp()
    {
        return (long)this._Timestamp;
    }

}

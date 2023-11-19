using UnityEngine;
public class ISN_DeviceGUID
{
    // Fields
    private byte[] _Bytes;
    private string _Base64;
    
    // Properties
    public string Base64String { get; }
    public byte[] Bytes { get; }
    
    // Methods
    public ISN_DeviceGUID(string data)
    {
        this._Base64 = data;
        this._Bytes = System.Convert.FromBase64String(s:  0);
    }
    public string get_Base64String()
    {
        return (string)this._Base64;
    }
    public byte[] get_Bytes()
    {
        return (System.Byte[])this._Bytes;
    }

}

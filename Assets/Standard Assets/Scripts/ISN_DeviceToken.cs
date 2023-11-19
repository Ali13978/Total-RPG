using UnityEngine;
public class ISN_DeviceToken
{
    // Fields
    private string _tokenString;
    private byte[] _tokenBytes;
    
    // Properties
    public string DeviceId { get; }
    public byte[] Bytes { get; }
    public string TokenString { get; }
    
    // Methods
    public ISN_DeviceToken(string base64String, string token)
    {
        val_1 = new System.Object();
        this._tokenString = val_1;
        this._tokenBytes = System.Convert.FromBase64String(s:  0);
    }
    public string get_DeviceId()
    {
        return (string)this._tokenString;
    }
    public byte[] get_Bytes()
    {
        return (System.Byte[])this._tokenBytes;
    }
    public string get_TokenString()
    {
        return (string)this._tokenString;
    }

}

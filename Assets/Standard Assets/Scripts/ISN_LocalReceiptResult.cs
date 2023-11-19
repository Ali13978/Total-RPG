using UnityEngine;
public class ISN_LocalReceiptResult
{
    // Fields
    private byte[] _Receipt;
    private string _ReceiptString;
    
    // Properties
    public byte[] Receipt { get; }
    public string ReceiptString { get; }
    
    // Methods
    public ISN_LocalReceiptResult(string data)
    {
        null = null;
        this._ReceiptString = System.String.Empty;
        if(data.Length < 1)
        {
                return;
        }
        
        this._Receipt = System.Convert.FromBase64String(s:  0);
        this._ReceiptString = data;
    }
    public byte[] get_Receipt()
    {
        return (System.Byte[])this._Receipt;
    }
    public string get_ReceiptString()
    {
        return (string)this._ReceiptString;
    }

}

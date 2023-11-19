using UnityEngine;
public class SK_RequestStorefrontIdentifierResult : Result
{
    // Fields
    private string _StorefrontIdentifier;
    
    // Properties
    public string StorefrontIdentifier { get; set; }
    
    // Methods
    public SK_RequestStorefrontIdentifierResult()
    {
        null = null;
        this._StorefrontIdentifier = System.String.Empty;
        this = new System.Object();
    }
    public SK_RequestStorefrontIdentifierResult(string errorData)
    {
        null = null;
        this._StorefrontIdentifier = System.String.Empty;
        this = new System.Object();
        mem[1152921510331009520] = new SA.Common.Models.Error(errorData:  errorData);
    }
    public string get_StorefrontIdentifier()
    {
        return (string)this._StorefrontIdentifier;
    }
    public void set_StorefrontIdentifier(string value)
    {
        this._StorefrontIdentifier = value;
    }

}

using UnityEngine;
public class ISN_RemoteNotification
{
    // Fields
    private string _Body;
    
    // Properties
    public string Body { get; }
    
    // Methods
    public ISN_RemoteNotification(string body)
    {
        this._Body = "{}";
        this._Body = body;
    }
    public string get_Body()
    {
        return (string)this._Body;
    }

}

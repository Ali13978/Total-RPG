using UnityEngine;
public class ISN_RemoteNotificationsRegistrationResult : Result
{
    // Fields
    private ISN_DeviceToken _Token;
    
    // Properties
    public ISN_DeviceToken Token { get; }
    
    // Methods
    public ISN_RemoteNotificationsRegistrationResult(ISN_DeviceToken token)
    {
        this._Token = token;
    }
    public ISN_RemoteNotificationsRegistrationResult(SA.Common.Models.Error error)
    {
    
    }
    public ISN_DeviceToken get_Token()
    {
        return (ISN_DeviceToken)this._Token;
    }

}

using UnityEngine;

namespace GooglePlayGames.BasicApi
{
    public enum ResponseStatus
    {
        // Fields
        Success = 1
        ,SuccessWithStale = 2
        ,LicenseCheckFailed = -1
        ,InternalError = -2
        ,NotAuthorized = -3
        ,VersionUpdateRequired = -4
        ,Timeout = -5
        
    
    }

}

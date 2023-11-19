using UnityEngine;
public class SK_AuthorizationResult : Result
{
    // Fields
    private SK_CloudServiceAuthorizationStatus _AuthorizationStatus;
    
    // Properties
    public SK_CloudServiceAuthorizationStatus AuthorizationStatus { get; }
    
    // Methods
    public SK_AuthorizationResult(SK_CloudServiceAuthorizationStatus status)
    {
        val_1 = new System.Object();
        this._AuthorizationStatus = status;
    }
    public SK_CloudServiceAuthorizationStatus get_AuthorizationStatus()
    {
        return (SK_CloudServiceAuthorizationStatus)this._AuthorizationStatus;
    }

}

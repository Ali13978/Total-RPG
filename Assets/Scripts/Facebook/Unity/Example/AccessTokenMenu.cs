using UnityEngine;

namespace Facebook.Unity.Example
{
    internal class AccessTokenMenu : MenuBase
    {
        // Methods
        public AccessTokenMenu()
        {
        
        }
        protected override void GetGui()
        {
            if((this.Button(label:  "Refresh Access Token")) == false)
            {
                    return;
            }
            
            Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> val_2 = new Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result));
            FB.Mobile.RefreshCurrentAccessToken(callback:  0);
        }
    
    }

}

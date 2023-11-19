using UnityEngine;

namespace Facebook.Unity.Example
{
    internal class AppLinks : MenuBase
    {
        // Methods
        public AppLinks()
        {
        
        }
        protected override void GetGui()
        {
            if((this.Button(label:  "Get App Link")) != false)
            {
                    Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> val_2 = new Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result));
                Facebook.Unity.FB.GetAppLink(callback:  0);
            }
            
            if(Facebook.Unity.Constants.IsMobile == false)
            {
                    return;
            }
            
            if((this.Button(label:  "Fetch Deferred App Link")) == false)
            {
                    return;
            }
            
            Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> val_5 = new Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result));
            FB.Mobile.FetchDeferredAppLinkData(callback:  0);
        }
    
    }

}

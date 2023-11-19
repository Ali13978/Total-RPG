using UnityEngine;

namespace Facebook.Unity.Example
{
    internal class AppInvites : MenuBase
    {
        // Methods
        public AppInvites()
        {
        
        }
        protected override void GetGui()
        {
            IntPtr val_15;
            if((this.Button(label:  "Android Invite")) != false)
            {
                    mem[1152921511839689576] = "Logged FB.AppEvent";
                val_15 = System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result);
                Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppInviteResult> val_3 = new Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppInviteResult>(object:  this, method:  val_15);
                FB.Mobile.AppInvite(appLinkUrl:  0, previewImageUrl:  new System.Uri(uriString:  "https://fb.me/892708710750483"), callback:  0);
            }
            
            if((this.Button(label:  "Android Invite With Custom Image")) != false)
            {
                    mem[1152921511839689576] = "Logged FB.AppEvent";
                System.Uri val_6 = null;
                val_15 = val_6;
                val_6 = new System.Uri(uriString:  "http://i.imgur.com/zkYlB.jpg");
                Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppInviteResult> val_7 = new Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppInviteResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result));
                FB.Mobile.AppInvite(appLinkUrl:  0, previewImageUrl:  new System.Uri(uriString:  "https://fb.me/892708710750483"), callback:  val_15);
            }
            
            if((this.Button(label:  "iOS Invite")) != false)
            {
                    mem[1152921511839689576] = "Logged FB.AppEvent";
                val_15 = System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result);
                Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppInviteResult> val_10 = new Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppInviteResult>(object:  this, method:  val_15);
                FB.Mobile.AppInvite(appLinkUrl:  0, previewImageUrl:  new System.Uri(uriString:  "https://fb.me/810530068992919"), callback:  0);
            }
            
            if((this.Button(label:  "iOS Invite With Custom Image")) == false)
            {
                    return;
            }
            
            mem[1152921511839689576] = "Logged FB.AppEvent";
            Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppInviteResult> val_14 = new Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppInviteResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result));
            FB.Mobile.AppInvite(appLinkUrl:  0, previewImageUrl:  new System.Uri(uriString:  "https://fb.me/810530068992919"), callback:  new System.Uri(uriString:  "http://i.imgur.com/zkYlB.jpg"));
        }
    
    }

}

using UnityEngine;

namespace TzarGames.Endless
{
    public class FacebookLoginRewardHandler : OpenUrlRewardHandler
    {
        // Fields
        public bool IgnoreLogin;
        
        // Methods
        public FacebookLoginRewardHandler()
        {
        
        }
        public override void Open()
        {
            if(this.IgnoreLogin != true)
            {
                    if(TzarGames.Endless.FacebookPlatform.IsLoggedIn == false)
            {
                goto label_4;
            }
            
            }
            
            this.Open();
            return;
            label_4:
            System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  this, method:  System.Void TzarGames.Endless.FacebookLoginRewardHandler::<Open>m__0(bool success));
            TzarGames.Endless.FacebookPlatform.Login(callback:  null);
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private void <Open>__BaseCallProxy0()
        {
            this.Open();
        }
        private void <Open>m__0(bool success)
        {
            if(success == false)
            {
                    return;
            }
            
            this.Open();
        }
    
    }

}

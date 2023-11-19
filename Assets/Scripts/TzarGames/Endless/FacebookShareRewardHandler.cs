using UnityEngine;

namespace TzarGames.Endless
{
    public class FacebookShareRewardHandler : RewardHandler
    {
        // Fields
        [UnityEngine.SerializeField]
        private string iosLink;
        [UnityEngine.SerializeField]
        private string androidLink;
        
        // Methods
        public FacebookShareRewardHandler()
        {
        
        }
        public override void Open()
        {
            System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  this, method:  System.Void TzarGames.Endless.FacebookShareRewardHandler::<Open>m__0(bool success));
            TzarGames.Endless.FacebookPlatform.FeedShare(link:  null, shareResult:  new System.Uri(uriString:  this.androidLink));
        }
        private void <Open>m__0(bool success)
        {
            if(success == false)
            {
                    return;
            }
            
            this.giveReward();
        }
    
    }

}

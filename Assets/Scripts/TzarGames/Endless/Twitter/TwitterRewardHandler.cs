using UnityEngine;

namespace TzarGames.Endless.Twitter
{
    public class TwitterRewardHandler : RewardHandler
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Texture2D texture;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset text;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset languageCode;
        private const string TWITTER_ADDRESS = "http://twitter.com/intent/tweet";
        
        // Methods
        public TwitterRewardHandler()
        {
        
        }
        public override void Open()
        {
            this.OnPostTweetMessage();
        }
        public void OnPostTweetMessage()
        {
            string val_1 = TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
            string val_3 = TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
            string val_4 = UnityEngine.WWW.EscapeURL(s:  0);
            string val_5 = 0 + "http://twitter.com/intent/tweet?text="("http://twitter.com/intent/tweet?text=") + UnityEngine.WWW.EscapeURL(s:  0)(UnityEngine.WWW.EscapeURL(s:  0)) + "&amp;lang="("&amp;lang=");
            UnityEngine.Application.OpenURL(url:  0);
            this.giveReward();
        }
    
    }

}

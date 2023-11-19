using UnityEngine;

namespace TzarGames.Endless
{
    public class OpenUrlRewardHandler : RewardHandler
    {
        // Fields
        [UnityEngine.SerializeField]
        private string url;
        
        // Properties
        public string Url { get; }
        
        // Methods
        public OpenUrlRewardHandler()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        public string get_Url()
        {
            return (string)this.url;
        }
        public override void Open()
        {
            UnityEngine.Application.OpenURL(url:  0);
            this.giveReward();
        }
    
    }

}

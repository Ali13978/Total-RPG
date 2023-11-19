using UnityEngine;

namespace TzarGames.Common.Ads
{
    public class GoogleAdsService : AdService
    {
        // Fields
        [UnityEngine.SerializeField]
        private string androidAppId;
        [UnityEngine.SerializeField]
        private string iosAppId;
        [UnityEngine.SerializeField]
        private string androidAdUnitId;
        [UnityEngine.SerializeField]
        private string iosAdUnitId;
        [UnityEngine.SerializeField]
        private bool debug;
        private bool isShowing;
        private System.Action<TzarGames.Common.ShowResult> lastCallback;
        private bool canReward;
        
        // Methods
        public GoogleAdsService()
        {
        
        }
        public override bool IsReady(TzarGames.Common.Ad ad)
        {
            return false;
        }
        public override void Show(TzarGames.Common.Ad ad, System.Action<TzarGames.Common.ShowResult> callback)
        {
            if(this.isShowing == false)
            {
                    return;
            }
            
            callback.Invoke(obj:  0);
        }
        public override void Initialize()
        {
            if(this.debug != false)
            {
                    UnityEngine.Debug.Log(message:  0);
            }
            
            this.requestAd();
        }
        public override void RequestAd(TzarGames.Common.Ad ad)
        {
            this.requestAd();
        }
        private void requestAd()
        {
            if(this.debug != false)
            {
                    UnityEngine.Debug.Log(message:  0);
            }
            
            this.canReward = false;
        }
        private void HandleRewardBasedVideoOpened(object sender, System.EventArgs e)
        {
            if(this.debug == false)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  0);
        }
        private void HandleRewardBasedVideoLeftApplication(object sender, System.EventArgs e)
        {
            if(this.debug == false)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  0);
        }
        private void HandleRewardBasedVideoClosed(object sender, System.EventArgs e)
        {
            TzarGames.Common.ShowResult val_1;
            var val_2;
            if(this.debug != false)
            {
                    UnityEngine.Debug.Log(message:  0);
            }
            
            if(this.canReward != false)
            {
                    val_1 = 2;
                val_2 = 1;
                this.canReward = false;
            }
            else
            {
                    val_1 = 1;
                val_2 = 1;
            }
            
            this.finish(result:  val_1, requestAgain:  true);
        }
        private void HandleRewardBasedVideoStarted(object sender, System.EventArgs e)
        {
            if(this.debug == false)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  0);
        }
        private void HandleRewardBasedVideoLoaded(object sender, System.EventArgs e)
        {
            if(this.debug == false)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  0);
        }
        private void finish(TzarGames.Common.ShowResult result, bool requestAgain)
        {
            this.isShowing = false;
            this.NotifyAdSkippedOrFinished();
            if(requestAgain != false)
            {
                    this.requestAd();
            }
            
            if(this.lastCallback == null)
            {
                    return;
            }
            
            this.lastCallback = 0;
            this.lastCallback.Invoke(obj:  result);
        }
    
    }

}

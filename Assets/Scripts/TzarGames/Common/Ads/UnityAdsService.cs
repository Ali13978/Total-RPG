using UnityEngine;

namespace TzarGames.Common.Ads
{
    public class UnityAdsService : AdService
    {
        // Methods
        public UnityAdsService()
        {
        
        }
        public override bool IsReady(TzarGames.Common.Ad ad)
        {
            string val_1 = ad.AdId;
            return UnityEngine.Advertisements.Advertisement.IsReady(placementId:  0);
        }
        public override void Show(TzarGames.Common.Ad id, System.Action<TzarGames.Common.ShowResult> callback)
        {
            if(null != 0)
            {
                    typeof(UnityAdsService.<Show>c__AnonStorey0).__il2cppRuntimeField_10 = callback;
            }
            else
            {
                    mem[16] = callback;
            }
            
            typeof(UnityAdsService.<Show>c__AnonStorey0).__il2cppRuntimeField_18 = this;
            UnityEngine.Advertisements.ShowOptions val_2 = new UnityEngine.Advertisements.ShowOptions();
            resultCallback = new System.Action<UnityEngine.Advertisements.ShowResult>(object:  new System.Object(), method:  System.Void UnityAdsService.<Show>c__AnonStorey0::<>m__0(UnityEngine.Advertisements.ShowResult result));
            this.NotifyAdStarted();
            UnityEngine.Advertisements.Advertisement.Show(placementId:  0, showOptions:  id.AdId);
        }
        public override void Initialize()
        {
        
        }
        public override void RequestAd(TzarGames.Common.Ad ad)
        {
        
        }
    
    }

}

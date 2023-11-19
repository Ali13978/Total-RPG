using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class BuyGameUI : GameUIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase waitingWindow;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase mainWindow;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase noAdsWindow;
        [UnityEngine.SerializeField]
        private TzarGames.Common.ShowAds ads;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action OnContinueAllowed;
        
        // Methods
        public BuyGameUI()
        {
        
        }
        public void add_OnContinueAllowed(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnContinueAllowed);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921510881798664 != this.OnContinueAllowed);
        
        }
        public void remove_OnContinueAllowed(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnContinueAllowed);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921510881935240 != this.OnContinueAllowed);
        
        }
        private void Start()
        {
            this.ads.OnAdFinished.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void TzarGames.Endless.UI.BuyGameUI::adsFinished()));
            this.ads.OnAdSkipped.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void TzarGames.Endless.UI.BuyGameUI::OnAddCancelled()));
        }
        private void OnAddCancelled()
        {
            if(this.mainWindow == null)
            {
                
            }
        
        }
        public override void NotifyShown()
        {
            this.NotifyShown();
            if(this.ads.IsReady() != false)
            {
                    return;
            }
            
            this.ads.RequestAd();
        }
        public void OnBackFromNoAdsWindowPressed()
        {
            if(this.noAdsWindow == null)
            {
                
            }
        
        }
        private void adsFinished()
        {
            TzarGames.Endless.EndlessGameState.Instance.NotifyGameAdsWatched();
            this.continueGame();
        }
        private void continueGame()
        {
            TzarGames.Endless.EndlessGameState.Instance.TryContinueGame();
            if(TzarGames.Endless.EndlessGameState.Instance.IsInGameState() != false)
            {
                    if(this.noAdsWindow != null)
            {
                goto label_6;
            }
            
            }
            
            label_6:
            if(this.OnContinueAllowed == null)
            {
                    return;
            }
            
            this.OnContinueAllowed.Invoke();
        }
        public void CancelBuy()
        {
            TzarGames.Endless.EndlessGameState.Instance.CancelGameContinue();
        }
        public void OnWatchAdsPressed()
        {
            if(this.ads.IsReady() != false)
            {
                    this.ads.ShowAd();
                return;
            }
            
            if(this.noAdsWindow == null)
            {
                
            }
        
        }
        public void OnBuyGamePressed()
        {
            if(TzarGames.Endless.EndlessInAppManager.IsInitialized == false)
            {
                    return;
            }
            
            System.Action<TzarGames.Common.IPurchaseResult> val_2 = new System.Action<TzarGames.Common.IPurchaseResult>(object:  this, method:  System.Void TzarGames.Endless.UI.BuyGameUI::<OnBuyGamePressed>m__0(TzarGames.Common.IPurchaseResult x));
            TzarGames.Endless.EndlessInAppManager.BuyFullGame(resultCallback:  0);
        }
        private void Update()
        {
            if(this.noAdsWindow.IsVisible == false)
            {
                    return;
            }
            
            if(this.ads.IsReady() == false)
            {
                    return;
            }
            
            this.ads.ShowAd();
        }
        private void <OnBuyGamePressed>m__0(TzarGames.Common.IPurchaseResult x)
        {
            var val_2;
            if(x == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = x;
            if((x & 1) == 0)
            {
                    return;
            }
            
            this.continueGame();
        }
    
    }

}

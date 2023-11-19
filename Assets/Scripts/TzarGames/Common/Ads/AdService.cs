using UnityEngine;

namespace TzarGames.Common.Ads
{
    public abstract class AdService : CommonAsset, IAdsService
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.Common.IAdsService> OnAdStarted;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.Common.IAdsService> OnAdSkippedOrFinished;
        
        // Methods
        protected AdService()
        {
        
        }
        public void add_OnAdStarted(System.Action<TzarGames.Common.IAdsService> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnAdStarted);
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
            while(1152921511048450984 != this.OnAdStarted);
        
        }
        public void remove_OnAdStarted(System.Action<TzarGames.Common.IAdsService> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnAdStarted);
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
            while(1152921511048587560 != this.OnAdStarted);
        
        }
        public void add_OnAdSkippedOrFinished(System.Action<TzarGames.Common.IAdsService> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnAdSkippedOrFinished);
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
            while(1152921511048724144 != this.OnAdSkippedOrFinished);
        
        }
        public void remove_OnAdSkippedOrFinished(System.Action<TzarGames.Common.IAdsService> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnAdSkippedOrFinished);
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
            while(1152921511048860720 != this.OnAdSkippedOrFinished);
        
        }
        public abstract bool IsReady(TzarGames.Common.Ad ad); // 0
        public abstract void Show(TzarGames.Common.Ad ad, System.Action<TzarGames.Common.ShowResult> callback); // 0
        public abstract void Initialize(); // 0
        public abstract void RequestAd(TzarGames.Common.Ad ad); // 0
        protected void NotifyAdStarted()
        {
            if(this.OnAdStarted == null)
            {
                    return;
            }
            
            this.OnAdStarted.Invoke(obj:  this);
        }
        protected void NotifyAdSkippedOrFinished()
        {
            if(this.OnAdSkippedOrFinished == null)
            {
                    return;
            }
            
            this.OnAdSkippedOrFinished.Invoke(obj:  this);
        }
    
    }

}

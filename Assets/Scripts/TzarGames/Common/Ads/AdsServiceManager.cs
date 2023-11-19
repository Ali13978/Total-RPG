using UnityEngine;

namespace TzarGames.Common.Ads
{
    public class AdsServiceManager : MonoBehaviour
    {
        // Fields
        [UnityEngine.HeaderAttribute]
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private System.Collections.Generic.List<TzarGames.Common.Ads.AdService> _services;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static TzarGames.Common.Ads.AdsServiceManager <Instance>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.Common.IAdsService> OnAdStarted;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.Common.IAdsService> OnAdSkippedOrFinished;
        
        // Properties
        public static TzarGames.Common.Ads.AdsServiceManager Instance { get; set; }
        
        // Methods
        public AdsServiceManager()
        {
        
        }
        public static TzarGames.Common.Ads.AdsServiceManager get_Instance()
        {
            return (TzarGames.Common.Ads.AdsServiceManager)TzarGames.Common.Ads.AdsServiceManager.<Instance>k__BackingField;
        }
        private static void set_Instance(TzarGames.Common.Ads.AdsServiceManager value)
        {
            TzarGames.Common.Ads.AdsServiceManager.<Instance>k__BackingField = X1;
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
            while(1152921511049582880 != this.OnAdStarted);
        
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
            while(1152921511049719456 != this.OnAdStarted);
        
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
            while(1152921511049856040 != this.OnAdSkippedOrFinished);
        
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
            while(1152921511049992616 != this.OnAdSkippedOrFinished);
        
        }
        public static TzarGames.Common.IAdsService GetReadyServiceForAd(TzarGames.Common.Ad ad)
        {
            var val_6 = 0;
            if(0 == (TzarGames.Common.Ads.AdsServiceManager.<Instance>k__BackingField))
            {
                    return (TzarGames.Common.IAdsService)val_6;
            }
            
            var val_6 = 0;
            label_13:
            if(val_6 >= Count)
            {
                goto label_8;
            }
            
            val_6 = Item[0];
            val_6 = val_6 + 1;
            if(((val_6 & 1) & 1) == 0)
            {
                goto label_13;
            }
            
            return (TzarGames.Common.IAdsService)val_6;
            label_8:
            val_6 = 0;
            return (TzarGames.Common.IAdsService)val_6;
        }
        public static void RequestAdServicesForAd(TzarGames.Common.Ad ad)
        {
            var val_6;
            if(0 == (TzarGames.Common.Ads.AdsServiceManager.<Instance>k__BackingField))
            {
                    return;
            }
            
            val_6 = 0;
            goto label_5;
            label_14:
            val_6 = 1;
            label_5:
            if(val_6 >= Count)
            {
                    return;
            }
            
            if(((Item[1] & 1) & 1) == 0)
            {
                goto label_14;
            }
        
        }
        protected virtual void Start()
        {
            var val_7;
            System.Action<TzarGames.Common.IAdsService> val_8;
            var val_9;
            if(0 != (TzarGames.Common.Ads.AdsServiceManager.<Instance>k__BackingField))
            {
                    UnityEngine.GameObject val_2 = this.gameObject;
                UnityEngine.Object.Destroy(obj:  0);
                return;
            }
            
            val_7 = 0;
            TzarGames.Common.Ads.AdsServiceManager.<Instance>k__BackingField = this;
            goto label_8;
            label_20:
            val_7 = 1;
            label_8:
            int val_3 = this._services.Count;
            if(val_7 >= val_3)
            {
                    return;
            }
            
            TzarGames.Common.Ads.AdService val_4 = this._services.Item[1];
            val_4.add_OnAdStarted(value:  new System.Action<TzarGames.Common.IAdsService>(object:  this, method:  System.Void TzarGames.Common.Ads.AdsServiceManager::ServiceOnOnAdStarted(TzarGames.Common.IAdsService adsService)));
            System.Action<TzarGames.Common.IAdsService> val_6 = new System.Action<TzarGames.Common.IAdsService>(object:  this, method:  System.Void TzarGames.Common.Ads.AdsServiceManager::ServiceOnOnAdSkippedOrFinished(TzarGames.Common.IAdsService adsService));
            if(val_4 == null)
            {
                goto label_13;
            }
            
            val_8 = val_6;
            val_4.add_OnAdSkippedOrFinished(value:  val_8);
            goto label_20;
            label_13:
            val_8 = val_6;
            val_4.add_OnAdSkippedOrFinished(value:  val_8);
            goto label_20;
            label_21:
            val_9 = val_3;
            mem[8] = ???;
            goto label_21;
        }
        protected virtual void OnDestroy()
        {
            object val_6;
            var val_7;
            val_6 = this;
            if(0 != (TzarGames.Common.Ads.AdsServiceManager.<Instance>k__BackingField))
            {
                    return;
            }
            
            val_7 = 0;
            goto label_5;
            label_11:
            X21.remove_OnAdSkippedOrFinished(value:  X22);
            val_7 = 1;
            label_5:
            if(val_7 >= this._services.Count)
            {
                goto label_7;
            }
            
            TzarGames.Common.Ads.AdService val_3 = this._services.Item[1];
            val_3.remove_OnAdStarted(value:  new System.Action<TzarGames.Common.IAdsService>(object:  this, method:  System.Void TzarGames.Common.Ads.AdsServiceManager::ServiceOnOnAdStarted(TzarGames.Common.IAdsService adsService)));
            System.Action<TzarGames.Common.IAdsService> val_5 = new System.Action<TzarGames.Common.IAdsService>(object:  this, method:  System.Void TzarGames.Common.Ads.AdsServiceManager::ServiceOnOnAdSkippedOrFinished(TzarGames.Common.IAdsService adsService));
            if(val_3 != null)
            {
                goto label_11;
            }
            
            goto label_11;
            label_7:
            TzarGames.Common.Ads.AdsServiceManager.<Instance>k__BackingField = 0;
        }
        public void AddService(TzarGames.Common.Ads.AdService service)
        {
            if((this._services.Contains(item:  service)) != false)
            {
                    return;
            }
            
            service.add_OnAdStarted(value:  new System.Action<TzarGames.Common.IAdsService>(object:  this, method:  System.Void TzarGames.Common.Ads.AdsServiceManager::ServiceOnOnAdStarted(TzarGames.Common.IAdsService adsService)));
            service.add_OnAdSkippedOrFinished(value:  new System.Action<TzarGames.Common.IAdsService>(object:  this, method:  System.Void TzarGames.Common.Ads.AdsServiceManager::ServiceOnOnAdSkippedOrFinished(TzarGames.Common.IAdsService adsService)));
            this._services.Add(item:  service);
        }
        public void RemoveService(TzarGames.Common.Ads.AdService service)
        {
            if((this._services.Contains(item:  service)) == false)
            {
                    return;
            }
            
            bool val_2 = this._services.Remove(item:  service);
            service.remove_OnAdStarted(value:  new System.Action<TzarGames.Common.IAdsService>(object:  this, method:  System.Void TzarGames.Common.Ads.AdsServiceManager::ServiceOnOnAdStarted(TzarGames.Common.IAdsService adsService)));
            service.remove_OnAdSkippedOrFinished(value:  new System.Action<TzarGames.Common.IAdsService>(object:  this, method:  System.Void TzarGames.Common.Ads.AdsServiceManager::ServiceOnOnAdSkippedOrFinished(TzarGames.Common.IAdsService adsService)));
        }
        private void ServiceOnOnAdSkippedOrFinished(TzarGames.Common.IAdsService adsService)
        {
            if(this.OnAdSkippedOrFinished == null)
            {
                    return;
            }
            
            this.OnAdSkippedOrFinished.Invoke(obj:  adsService);
        }
        private void ServiceOnOnAdStarted(TzarGames.Common.IAdsService adsService)
        {
            if(this.OnAdStarted == null)
            {
                    return;
            }
            
            this.OnAdStarted.Invoke(obj:  adsService);
        }
    
    }

}

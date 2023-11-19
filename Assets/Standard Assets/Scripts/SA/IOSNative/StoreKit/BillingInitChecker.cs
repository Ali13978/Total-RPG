using UnityEngine;

namespace SA.IOSNative.StoreKit
{
    public class BillingInitChecker
    {
        // Fields
        private SA.IOSNative.StoreKit.BillingInitChecker.BillingInitListener _listener;
        
        // Methods
        public BillingInitChecker(SA.IOSNative.StoreKit.BillingInitChecker.BillingInitListener listener)
        {
            this._listener = listener;
            SA_EditorAd val_1 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
            if(val_1._IsInterstitialLoading != false)
            {
                    this._listener.Invoke();
                return;
            }
            
            System.Action<SA.Common.Models.Result> val_2 = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void SA.IOSNative.StoreKit.BillingInitChecker::HandleOnStoreKitInitComplete(SA.Common.Models.Result obj));
            SA.IOSNative.StoreKit.PaymentManager.add_OnStoreKitInitComplete(value:  null);
            SA_EditorAd val_3 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
            if(val_3._IsVideoLoading != false)
            {
                    return;
            }
            
            SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.LoadStore(forceLoad:  false);
        }
        private void HandleOnStoreKitInitComplete(SA.Common.Models.Result obj)
        {
            System.Action<SA.Common.Models.Result> val_1 = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void SA.IOSNative.StoreKit.BillingInitChecker::HandleOnStoreKitInitComplete(SA.Common.Models.Result obj));
            SA.IOSNative.StoreKit.PaymentManager.remove_OnStoreKitInitComplete(value:  null);
            this._listener.Invoke();
        }
    
    }

}

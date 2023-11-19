using UnityEngine;

namespace UnityEngine.Purchasing
{
    [UnityEngine.AddComponentMenu]
    [UnityEngine.HelpURLAttribute]
    public class IAPListener : MonoBehaviour
    {
        // Fields
        [UnityEngine.TooltipAttribute]
        public bool consumePurchase;
        [UnityEngine.TooltipAttribute]
        public bool dontDestroyOnLoad;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.Purchasing.IAPListener.OnPurchaseCompletedEvent onPurchaseComplete;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.Purchasing.IAPListener.OnPurchaseFailedEvent onPurchaseFailed;
        
        // Methods
        public IAPListener()
        {
            this.consumePurchase = true;
            this.dontDestroyOnLoad = true;
        }
        private void OnEnable()
        {
            if(this.dontDestroyOnLoad != false)
            {
                    UnityEngine.GameObject val_1 = this.gameObject;
                UnityEngine.Object.DontDestroyOnLoad(target:  0);
            }
            
            UnityEngine.Purchasing.CodelessIAPStoreListener.Instance.AddListener(listener:  this);
        }
        private void OnDisable()
        {
            UnityEngine.Purchasing.CodelessIAPStoreListener.Instance.RemoveListener(listener:  this);
        }
        public UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e)
        {
            string val_3 = e.purchasedProduct.definition.id;
            string val_4 = System.String.Format(format:  0, arg0:  "IAPListener.ProcessPurchase(PurchaseEventArgs {0} - {1})", arg1:  e);
            UnityEngine.Debug.Log(message:  0);
            this.onPurchaseComplete.Invoke(arg0:  e.purchasedProduct);
            bool val_7 = this.consumePurchase;
            val_7 = val_7 ^ 1;
            return (UnityEngine.Purchasing.PurchaseProcessingResult)val_7 & 255;
        }
        public void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason reason)
        {
            string val_1 = System.String.Format(format:  0, arg0:  "IAPListener.OnPurchaseFailed(Product {0}, PurchaseFailureReason {1})", arg1:  product);
            UnityEngine.Debug.Log(message:  0);
            this.onPurchaseFailed.Invoke(arg0:  product, arg1:  reason);
        }
    
    }

}

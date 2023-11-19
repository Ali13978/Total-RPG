using UnityEngine;

namespace UnityEngine.Purchasing
{
    [UnityEngine.RequireComponent]
    [UnityEngine.AddComponentMenu]
    [UnityEngine.HelpURLAttribute]
    public class IAPButton : MonoBehaviour
    {
        // Fields
        [UnityEngine.HideInInspector]
        public string productId;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.Purchasing.IAPButton.ButtonType buttonType;
        [UnityEngine.TooltipAttribute]
        public bool consumePurchase;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.Purchasing.IAPButton.OnPurchaseCompletedEvent onPurchaseComplete;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.Purchasing.IAPButton.OnPurchaseFailedEvent onPurchaseFailed;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.UI.Text titleText;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.UI.Text descriptionText;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.UI.Text priceText;
        
        // Methods
        public IAPButton()
        {
            this.consumePurchase = true;
        }
        private void Start()
        {
            UnityEngine.UI.Button val_1 = this.GetComponent<UnityEngine.UI.Button>();
            if(this.buttonType != 1)
            {
                    if(this.buttonType != 0)
            {
                    return;
            }
            
                if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    val_1.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UnityEngine.Purchasing.IAPButton::PurchaseProduct()));
            }
            
                if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    UnityEngine.Debug.LogError(message:  0);
            }
            
                if((UnityEngine.Purchasing.CodelessIAPStoreListener.Instance.HasProductInCatalog(productID:  this.productId)) == true)
            {
                    return;
            }
            
                string val_9 = 0 + "The product catalog has no product with the ID \"" + this.productId;
                UnityEngine.Debug.LogWarning(message:  0);
                return;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            val_1.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UnityEngine.Purchasing.IAPButton::Restore()));
        }
        private void OnEnable()
        {
            if(this.buttonType != 0)
            {
                    return;
            }
            
            UnityEngine.Purchasing.CodelessIAPStoreListener.Instance.AddButton(button:  this);
            if(UnityEngine.Purchasing.CodelessIAPStoreListener.initializationComplete == false)
            {
                    return;
            }
            
            this.UpdateText();
        }
        private void OnDisable()
        {
            if(this.buttonType != 0)
            {
                    return;
            }
            
            UnityEngine.Purchasing.CodelessIAPStoreListener.Instance.RemoveButton(button:  this);
        }
        private void PurchaseProduct()
        {
            if(this.buttonType != 0)
            {
                    return;
            }
            
            string val_1 = 0 + "IAPButton.PurchaseProduct() with product ID: "("IAPButton.PurchaseProduct() with product ID: ");
            UnityEngine.Debug.Log(message:  0);
            UnityEngine.Purchasing.CodelessIAPStoreListener.Instance.InitiatePurchase(productID:  this.productId);
        }
        private void Restore()
        {
            object val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            val_30 = this;
            if(this.buttonType != 1)
            {
                    return;
            }
            
            if(UnityEngine.Application.platform != 18)
            {
                    if(UnityEngine.Application.platform != 19)
            {
                    if(UnityEngine.Application.platform != 20)
            {
                goto label_4;
            }
            
            }
            
            }
            
            UnityEngine.Purchasing.CodelessIAPStoreListener val_4 = UnityEngine.Purchasing.CodelessIAPStoreListener.Instance;
            var val_30 = 0;
            val_30 = val_30 + 1;
            val_31 = val_4.extensions;
            val_30 = val_4.extensions;
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_32 = val_30;
            return;
            label_4:
            if(UnityEngine.Application.platform != 8)
            {
                    if(UnityEngine.Application.platform != 1)
            {
                    if(UnityEngine.Application.platform != 31)
            {
                goto label_18;
            }
            
            }
            
            }
            
            UnityEngine.Purchasing.CodelessIAPStoreListener val_10 = UnityEngine.Purchasing.CodelessIAPStoreListener.Instance;
            var val_32 = 0;
            val_32 = val_32 + 1;
            val_33 = val_10.extensions;
            val_34 = val_10.extensions;
            System.Action<System.Boolean> val_12 = null;
            val_35 = val_12;
            val_12 = new System.Action<System.Boolean>(object:  this, method:  System.Void UnityEngine.Purchasing.IAPButton::OnTransactionsRestored(bool success));
            var val_33 = 0;
            val_37 = 1152921504775999496;
            val_33 = val_33 + 1;
            label_68:
            val_38 = val_34;
            return;
            label_18:
            if((UnityEngine.Application.platform != 11) || (UnityEngine.Purchasing.StandardPurchasingModule.Instance().appStore != 4))
            {
                goto label_34;
            }
            
            UnityEngine.Purchasing.CodelessIAPStoreListener val_16 = UnityEngine.Purchasing.CodelessIAPStoreListener.Instance;
            var val_34 = 0;
            val_34 = val_34 + 1;
            val_39 = val_16.extensions;
            goto label_40;
            label_34:
            if((UnityEngine.Application.platform != 11) || (UnityEngine.Purchasing.StandardPurchasingModule.Instance().appStore != 3))
            {
                goto label_45;
            }
            
            UnityEngine.Purchasing.CodelessIAPStoreListener val_20 = UnityEngine.Purchasing.CodelessIAPStoreListener.Instance;
            var val_35 = 0;
            val_35 = val_35 + 1;
            val_40 = val_20.extensions;
            goto label_51;
            label_45:
            UnityEngine.Vector2 val_23 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            string val_24 = 0 + UnityEngine.Application.platform.ToString();
            UnityEngine.Debug.LogWarning(message:  0);
            return;
            label_40:
            val_34 = val_16.extensions;
            System.Action<System.Boolean> val_26 = null;
            val_35 = val_26;
            val_26 = new System.Action<System.Boolean>(object:  this, method:  System.Void UnityEngine.Purchasing.IAPButton::OnTransactionsRestored(bool success));
            var val_36 = 0;
            val_37 = 1152921504775999496;
            val_36 = val_36 + 1;
            goto label_68;
            label_51:
            val_34 = val_20.extensions;
            System.Action<UnityEngine.Purchasing.RestoreTransactionIDState> val_28 = null;
            val_35 = val_28;
            val_28 = new System.Action<UnityEngine.Purchasing.RestoreTransactionIDState>(object:  this, method:  System.Void UnityEngine.Purchasing.IAPButton::<Restore>m__0(UnityEngine.Purchasing.RestoreTransactionIDState restoreTransactionIDState));
            var val_37 = 0;
            val_37 = 1152921504775999496;
            val_37 = val_37 + 1;
            goto label_68;
        }
        private void OnTransactionsRestored(bool success)
        {
            bool val_1 = success;
            string val_2 = 0 + "Transactions restored: "("Transactions restored: ");
            UnityEngine.Debug.Log(message:  0);
        }
        public UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e)
        {
            string val_3 = e.purchasedProduct.definition.id;
            string val_4 = System.String.Format(format:  0, arg0:  "IAPButton.ProcessPurchase(PurchaseEventArgs {0} - {1})", arg1:  e);
            UnityEngine.Debug.Log(message:  0);
            this.onPurchaseComplete.Invoke(arg0:  e.purchasedProduct);
            bool val_7 = this.consumePurchase;
            val_7 = val_7 ^ 1;
            return (UnityEngine.Purchasing.PurchaseProcessingResult)val_7 & 255;
        }
        public void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason reason)
        {
            string val_1 = System.String.Format(format:  0, arg0:  "IAPButton.OnPurchaseFailed(Product {0}, PurchaseFailureReason {1})", arg1:  product);
            UnityEngine.Debug.Log(message:  0);
            this.onPurchaseFailed.Invoke(arg0:  product, arg1:  reason);
        }
        internal void UpdateText()
        {
            var val_20;
            UnityEngine.UI.Text val_21;
            var val_22;
            val_20 = this;
            val_21 = UnityEngine.Purchasing.CodelessIAPStoreListener.Instance;
            UnityEngine.Purchasing.Product val_2 = val_21.GetProduct(productID:  this.productId);
            if(val_2 == null)
            {
                    return;
            }
            
            val_22 = 1152921504721543168;
            if(0 != this.titleText)
            {
                    string val_5 = val_2.metadata.localizedTitle;
            }
            
            if(0 != this.descriptionText)
            {
                    string val_8 = val_2.metadata.localizedDescription;
            }
            
            val_21 = this.priceText;
            if(0 == val_21)
            {
                    return;
            }
            
            string val_11 = val_2.metadata.localizedPriceString;
            val_20 = ???;
            val_21 = ???;
            val_22 = ???;
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5A0;
        }
        private void <Restore>m__0(UnityEngine.Purchasing.RestoreTransactionIDState restoreTransactionIDState)
        {
            this.OnTransactionsRestored(success:  ((restoreTransactionIDState & 4294967294) != 2) ? 1 : 0);
        }
    
    }

}

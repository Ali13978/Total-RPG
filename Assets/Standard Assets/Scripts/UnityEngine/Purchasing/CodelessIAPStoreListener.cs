using UnityEngine;

namespace UnityEngine.Purchasing
{
    public class CodelessIAPStoreListener : IStoreListener
    {
        // Fields
        private static UnityEngine.Purchasing.CodelessIAPStoreListener instance;
        private System.Collections.Generic.List<UnityEngine.Purchasing.IAPButton> activeButtons;
        private System.Collections.Generic.List<UnityEngine.Purchasing.IAPListener> activeListeners;
        private static bool unityPurchasingInitialized;
        protected UnityEngine.Purchasing.IStoreController controller;
        protected UnityEngine.Purchasing.IExtensionProvider extensions;
        protected UnityEngine.Purchasing.ProductCatalog catalog;
        public static bool initializationComplete;
        
        // Properties
        public static UnityEngine.Purchasing.CodelessIAPStoreListener Instance { get; }
        public UnityEngine.Purchasing.IStoreController StoreController { get; }
        public UnityEngine.Purchasing.IExtensionProvider ExtensionProvider { get; }
        
        // Methods
        private CodelessIAPStoreListener()
        {
            this.activeButtons = new System.Collections.Generic.List<UnityEngine.Purchasing.IAPButton>();
            this.activeListeners = new System.Collections.Generic.List<UnityEngine.Purchasing.IAPListener>();
            this.catalog = UnityEngine.Purchasing.ProductCatalog.LoadDefaultCatalog();
        }
        [UnityEngine.RuntimeInitializeOnLoadMethodAttribute]
        private static void InitializeCodelessPurchasingOnLoad()
        {
            if(val_1.enableCodelessAutoInitialization == false)
            {
                    return;
            }
            
            if(UnityEngine.Purchasing.ProductCatalog.LoadDefaultCatalog().IsEmpty() == true)
            {
                    return;
            }
            
            if(UnityEngine.Purchasing.CodelessIAPStoreListener.instance != null)
            {
                    return;
            }
            
            UnityEngine.Purchasing.CodelessIAPStoreListener.CreateCodelessIAPStoreListenerInstance();
        }
        private static void InitializePurchasing()
        {
            UnityEngine.Purchasing.StandardPurchasingModule val_1 = UnityEngine.Purchasing.StandardPurchasingModule.Instance();
            val_1.useFakeStoreUIMode = 1;
            UnityEngine.Purchasing.ConfigurationBuilder val_2 = UnityEngine.Purchasing.ConfigurationBuilder.Instance(first:  0, rest:  val_1);
            UnityEngine.Purchasing.IAPConfigurationHelper.PopulateConfigurationBuilder(builder: ref  val_2, catalog:  val_2);
            UnityEngine.Purchasing.UnityPurchasing.Initialize(listener:  0, builder:  UnityEngine.Purchasing.CodelessIAPStoreListener.instance);
            UnityEngine.Purchasing.CodelessIAPStoreListener.unityPurchasingInitialized = true;
        }
        public static UnityEngine.Purchasing.CodelessIAPStoreListener get_Instance()
        {
            UnityEngine.Purchasing.CodelessIAPStoreListener val_1 = UnityEngine.Purchasing.CodelessIAPStoreListener.instance;
            if(val_1 != null)
            {
                    return val_1;
            }
            
            UnityEngine.Purchasing.CodelessIAPStoreListener.CreateCodelessIAPStoreListenerInstance();
            val_1 = UnityEngine.Purchasing.CodelessIAPStoreListener.instance;
            return val_1;
        }
        private static void CreateCodelessIAPStoreListenerInstance()
        {
            UnityEngine.Purchasing.CodelessIAPStoreListener.instance = new UnityEngine.Purchasing.CodelessIAPStoreListener();
            if(UnityEngine.Purchasing.CodelessIAPStoreListener.unityPurchasingInitialized != false)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  0);
            UnityEngine.Purchasing.CodelessIAPStoreListener.InitializePurchasing();
        }
        public UnityEngine.Purchasing.IStoreController get_StoreController()
        {
            return (UnityEngine.Purchasing.IStoreController)this.controller;
        }
        public UnityEngine.Purchasing.IExtensionProvider get_ExtensionProvider()
        {
            return (UnityEngine.Purchasing.IExtensionProvider)this.extensions;
        }
        public bool HasProductInCatalog(string productID)
        {
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            System.Collections.Generic.ICollection<UnityEngine.Purchasing.ProductCatalogItem> val_1 = this.catalog.allProducts;
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_9 = val_1;
            do
            {
                var val_10 = 0;
                val_10 = val_10 + 1;
                val_10 = val_1;
                if(((val_1 & 1) & 1) == 0)
            {
                goto label_31;
            }
            
                var val_11 = 0;
                val_11 = val_11 + 1;
                val_11 = val_1;
            }
            while((System.String.op_Equality(a:  0, b:  val_1)) == false);
            
            val_12 = 0;
            val_13 = 1;
            val_14 = 84;
            label_31:
            if(val_1 != null)
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                val_15 = val_1;
            }
            
            if( != 82)
            {
                    if( == 84)
            {
                    return (bool)val_13;
            }
            
            }
            
            val_13 = 0;
            return (bool)val_13;
        }
        public UnityEngine.Purchasing.Product GetProduct(string productID)
        {
            var val_6;
            var val_7;
            if(this.controller != null)
            {
                    var val_6 = 0;
                val_6 = val_6 + 1;
                val_6 = this.controller;
                if(this.controller != null)
            {
                    if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                goto label_9;
            }
            
            }
            
            }
            
            string val_4 = 0 + "CodelessIAPStoreListener attempted to get unknown product ";
            UnityEngine.Debug.LogError(message:  0);
            return 0;
            label_9:
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_7 = this.controller;
            if(this.controller != null)
            {
                    return this.controller.WithID(id:  productID);
            }
            
            return this.controller.WithID(id:  productID);
        }
        public void AddButton(UnityEngine.Purchasing.IAPButton button)
        {
            this.activeButtons.Add(item:  button);
        }
        public void RemoveButton(UnityEngine.Purchasing.IAPButton button)
        {
            bool val_1 = this.activeButtons.Remove(item:  button);
        }
        public void AddListener(UnityEngine.Purchasing.IAPListener listener)
        {
            this.activeListeners.Add(item:  listener);
        }
        public void RemoveListener(UnityEngine.Purchasing.IAPListener listener)
        {
            bool val_1 = this.activeListeners.Remove(item:  listener);
        }
        public void InitiatePurchase(string productID)
        {
            var val_5;
            var val_6;
            var val_7;
            val_5 = productID;
            if(this.controller != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                val_6 = this.controller;
                return;
            }
            
            UnityEngine.Debug.LogError(message:  0);
            List.Enumerator<T> val_1 = this.activeButtons.GetEnumerator();
            label_15:
            if((0 & 1) == 0)
            {
                goto label_9;
            }
            
            if((System.String.op_Equality(a:  0, b:  this)) == false)
            {
                goto label_15;
            }
            
            0.InitializationCallback.OnPurchaseFailed(product:  0, reason:  0);
            goto label_15;
            label_9:
            val_5 = 0;
            val_7 = 1;
            0.Dispose();
            if((val_7 & 1) != 0)
            {
                    return;
            }
            
            if(val_5 == 0)
            {
                    return;
            }
        
        }
        public void OnInitialized(UnityEngine.Purchasing.IStoreController controller, UnityEngine.Purchasing.IExtensionProvider extensions)
        {
            var val_3;
            var val_4;
            UnityEngine.Purchasing.CodelessIAPStoreListener.initializationComplete = true;
            this.controller = controller;
            this.extensions = extensions;
            List.Enumerator<T> val_1 = this.activeButtons.GetEnumerator();
            label_4:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            0.InitializationCallback.UpdateText();
            goto label_4;
            label_2:
            val_3 = 0;
            val_4 = 1;
            0.Dispose();
            if((val_4 & 1) != 0)
            {
                    return;
            }
            
            if(val_3 == 0)
            {
                    return;
            }
        
        }
        public void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error)
        {
            string val_1 = error.ToString();
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            string val_3 = System.String.Format(format:  0, arg0:  "Purchasing failed to initialize. Reason: {0}");
            UnityEngine.Debug.LogError(message:  0);
        }
        public UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e)
        {
            var val_3;
            UnityEngine.Purchasing.PurchaseEventArgs val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            val_20 = e;
            List.Enumerator<T> val_1 = this.activeButtons.GetEnumerator();
            val_21 = 0;
            val_22 = 0;
            goto label_3;
            label_14:
            val_22 = val_22 | ((val_1.current == 0) ? 1 : 0);
            val_21 = 1;
            goto label_3;
            label_11:
            string val_8 = val_20.purchasedProduct.definition.id;
            if((System.String.op_Equality(a:  0, b:  X22)) == true)
            {
                goto label_10;
            }
            
            label_3:
            if((0 & 1) != 0)
            {
                goto label_11;
            }
            
            goto label_12;
            label_10:
            UnityEngine.Purchasing.PurchaseProcessingResult val_10 = val_3.InitializationCallback.ProcessPurchase(e:  val_20);
            goto label_14;
            label_12:
            val_3.Dispose();
            List.Enumerator<T> val_11 = this.activeListeners.GetEnumerator();
            goto label_19;
            label_22:
            val_22 = val_22 | ((val_11.current == 0) ? 1 : 0);
            val_21 = 1;
            label_19:
            if((0 & 1) == 0)
            {
                goto label_20;
            }
            
            UnityEngine.Purchasing.PurchaseProcessingResult val_14 = 0.InitializationCallback.ProcessPurchase(e:  val_20);
            goto label_22;
            label_20:
            val_23 = 0;
            val_24 = 1;
            0.Dispose();
            if(((val_21 & 1) & 1) != 0)
            {
                    return (UnityEngine.Purchasing.PurchaseProcessingResult)(~val_22) & 1;
            }
            
            val_20 = 0 + "Purchase not correctly processed for product \"" + val_20.purchasedProduct.definition.id;
            UnityEngine.Debug.LogError(message:  0);
            return (UnityEngine.Purchasing.PurchaseProcessingResult)(~val_22) & 1;
        }
        public void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason reason)
        {
            var val_3;
            UnityEngine.Purchasing.Product val_13;
            var val_14;
            var val_15;
            val_13 = product;
            List.Enumerator<T> val_1 = this.activeButtons.GetEnumerator();
            label_10:
            label_8:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            string val_6 = val_13.definition.id;
            if((System.String.op_Equality(a:  0, b:  0)) == false)
            {
                goto label_8;
            }
            
            val_3.InitializationCallback.OnPurchaseFailed(product:  val_13, reason:  reason);
            goto label_10;
            label_2:
            val_3.Dispose();
            List.Enumerator<T> val_8 = this.activeListeners.GetEnumerator();
            label_17:
            if((0 & 1) == 0)
            {
                goto label_15;
            }
            
            0.InitializationCallback.OnPurchaseFailed(product:  val_13, reason:  reason);
            goto label_17;
            label_15:
            val_14 = 0;
            val_15 = 1;
            0.Dispose();
            if(((0 & 1) & 1) != 0)
            {
                    return;
            }
            
            val_13 = 0 + "Failed purchase not correctly handled for product \"" + val_13.definition.id;
            UnityEngine.Debug.LogError(message:  0);
        }
    
    }

}

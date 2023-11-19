using UnityEngine;

namespace TzarGames.Common
{
    public class UnityInAppManager : MonoBehaviour, IInAppPurchaseManager, IStoreListener
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.UnityProductInfo[] products;
        private UnityEngine.Purchasing.IStoreController controller;
        private UnityEngine.Purchasing.IExtensionProvider extensions;
        private static TzarGames.Common.UnityInAppManager instance;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static System.Action<UnityEngine.Purchasing.PurchaseEventArgs> OnProcessPurchase;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <IsInitialized>k__BackingField;
        private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Action<TzarGames.Common.IPurchaseResult>>> pendingPurchaseCallbacks;
        private static System.Action<bool> <>f__am$cache0;
        
        // Properties
        public static TzarGames.Common.UnityInAppManager Instance { get; }
        public bool IsInitialized { get; set; }
        public static bool SupportsRestoringPurchases { get; }
        
        // Methods
        public UnityInAppManager()
        {
            this.pendingPurchaseCallbacks = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.Action<TzarGames.Common.IPurchaseResult>>>();
        }
        public static TzarGames.Common.UnityInAppManager get_Instance()
        {
            null = null;
            return (TzarGames.Common.UnityInAppManager)TzarGames.Common.UnityInAppManager.instance;
        }
        public static void add_OnProcessPurchase(System.Action<UnityEngine.Purchasing.PurchaseEventArgs> value)
        {
            var val_3;
            System.Action<UnityEngine.Purchasing.PurchaseEventArgs> val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = TzarGames.Common.UnityInAppManager.OnProcessPurchase;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = TzarGames.Common.UnityInAppManager.__il2cppRuntimeField_static_fields;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  val_4);
            val_5 = 0;
            if(val_1 != null)
            {
                    val_5 = val_1;
                if(null != null)
            {
                    val_5 = 0;
            }
            
            }
            
            if(1152921504902696968 != val_4)
            {
                goto label_8;
            }
        
        }
        public static void remove_OnProcessPurchase(System.Action<UnityEngine.Purchasing.PurchaseEventArgs> value)
        {
            var val_3;
            System.Action<UnityEngine.Purchasing.PurchaseEventArgs> val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = TzarGames.Common.UnityInAppManager.OnProcessPurchase;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = TzarGames.Common.UnityInAppManager.__il2cppRuntimeField_static_fields;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  val_4);
            val_5 = 0;
            if(val_1 != null)
            {
                    val_5 = val_1;
                if(null != null)
            {
                    val_5 = 0;
            }
            
            }
            
            if(1152921504902696968 != val_4)
            {
                goto label_8;
            }
        
        }
        public bool get_IsInitialized()
        {
            return (bool)this.<IsInitialized>k__BackingField;
        }
        private void set_IsInitialized(bool value)
        {
            this.<IsInitialized>k__BackingField = value;
        }
        private void Awake()
        {
            var val_8;
            UnityEngine.Purchasing.IDs val_9;
            var val_10;
            var val_11;
            val_8 = null;
            val_8 = null;
            TzarGames.Common.UnityInAppManager.instance = this;
            UnityEngine.Purchasing.ConfigurationBuilder val_2 = UnityEngine.Purchasing.ConfigurationBuilder.Instance(first:  0, rest:  UnityEngine.Purchasing.StandardPurchasingModule.Instance());
            val_9 = mem[1152921511232810056];
            val_10 = 0;
            goto label_5;
            label_27:
            UnityEngine.Purchasing.ConfigurationBuilder val_3 = val_2.AddProduct(id:  X22, type:  W23, storeIDs:  val_9);
            val_9 = val_9;
            val_10 = 1;
            label_5:
            if(val_10 >= (mem[1152921511232810056] + 24))
            {
                goto label_7;
            }
            
            var val_4 = val_9 + 8;
            UnityEngine.Purchasing.IDs val_5 = new UnityEngine.Purchasing.IDs();
            val_11 = 0;
            goto label_10;
            label_23:
            Add(id:  X22, stores:  X23);
            val_11 = 1;
            label_10:
            if(val_11 >= ((mem[1152921511232810056] + 8) + 32 + 32 + 24))
            {
                goto label_12;
            }
            
            var val_6 = ((mem[1152921511232810056] + 8) + 32 + 32) + 8;
            typeof(System.String[]).__il2cppRuntimeField_20 = TzarGames.Common.UnityInAppManager.getStringFromStoreName(storeName:  null);
            if(null != 0)
            {
                goto label_23;
            }
            
            goto label_23;
            label_12:
            if(((mem[1152921511232810056] + 8) + 32) != 0)
            {
                
            }
            
            if(val_2 != 0)
            {
                goto label_27;
            }
            
            goto label_27;
            label_7:
            UnityEngine.Purchasing.UnityPurchasing.Initialize(listener:  0, builder:  this);
        }
        private void OnDestroy()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if(0 != TzarGames.Common.UnityInAppManager.instance)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            TzarGames.Common.UnityInAppManager.instance = 0;
        }
        private static string getStringFromStoreName(TzarGames.Common.UnityInAppStoreNames storeName)
        {
            var val_4;
            var val_2 = (W1 < 3) ? (W1 + 3) : 0;
            if(val_2 == 3)
            {
                goto label_1;
            }
            
            if(val_2 == 5)
            {
                goto label_2;
            }
            
            if(val_2 != 4)
            {
                goto label_3;
            }
            
            val_4 = "GooglePlay";
            return (string)val_4;
            label_1:
            val_4 = "MacAppStore";
            return (string)val_4;
            label_2:
            val_4 = "AppleAppStore";
            return (string)val_4;
            label_3:
            System.ArgumentOutOfRangeException val_3 = new System.ArgumentOutOfRangeException(paramName:  "storeName", actualValue:  W1, message:  0);
        }
        public void OnInitialized(UnityEngine.Purchasing.IStoreController controller, UnityEngine.Purchasing.IExtensionProvider extensions)
        {
            this.controller = controller;
            this.extensions = extensions;
            this.<IsInitialized>k__BackingField = true;
        }
        public void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error)
        {
            this.<IsInitialized>k__BackingField = false;
        }
        public UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e)
        {
            var val_26;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.Action<TzarGames.Common.IPurchaseResult>>> val_41;
            var val_42;
            var val_43;
            System.Action<UnityEngine.Purchasing.PurchaseEventArgs> val_44;
            var val_45;
            var val_46;
            var val_47;
            System.Action<UnityEngine.Purchasing.PurchaseEventArgs> val_48;
            var val_49;
            string val_3 = e.purchasedProduct.definition.id;
            string val_4 = 0 + "Process Purchase ";
            UnityEngine.Debug.Log(message:  0);
            UnityEngine.Purchasing.Security.CrossPlatformValidator val_8 = new UnityEngine.Purchasing.Security.CrossPlatformValidator(googlePublicKey:  UnityEngine.Purchasing.Security.GooglePlayTangle.Data(), appleRootCert:  UnityEngine.Purchasing.Security.AppleTangle.Data(), appBundleId:  UnityEngine.Application.identifier);
            UnityEngine.Debug.Log(message:  0);
            val_36 = 0;
            goto label_17;
            label_38:
            val_36 = 1;
            label_17:
            if(val_36 >= val_11.Length)
            {
                goto label_19;
            }
            
            UnityEngine.Purchasing.Security.IPurchaseReceipt val_38 = Validate(unityIAPReceipt:  e.purchasedProduct.receipt)[1];
            var val_39 = 0;
            val_39 = val_39 + 1;
            val_37 = val_38;
            UnityEngine.Debug.Log(message:  0);
            var val_40 = 0;
            val_40 = val_40 + 1;
            val_38 = val_38;
            UnityEngine.Debug.Log(message:  0);
            var val_41 = 0;
            val_41 = val_41 + 1;
            val_39 = val_38;
            UnityEngine.Debug.Log(message:  0);
            goto label_38;
            label_61:
            if((0 & 1) == 0)
            {
                goto label_59;
            }
            
            val_26.InitializationCallback.Invoke(obj:  new TzarGames.Common.PurchaseResult());
            goto label_61;
            label_59:
            val_41 = 0;
            val_42 = 1;
            val_26.Dispose();
            Clear();
            if(((0 & 1) & 1) != 0)
            {
                    return 0;
            }
            
            val_43 = null;
            val_43 = null;
            val_44 = TzarGames.Common.UnityInAppManager.OnProcessPurchase;
            if(val_44 == null)
            {
                    return 0;
            }
            
            val_44 = TzarGames.Common.UnityInAppManager.OnProcessPurchase;
            if(val_44 == null)
            {
                    val_44 = 0;
            }
            
            val_44.Invoke(obj:  e);
            return 0;
            label_19:
            string val_31 = e.purchasedProduct.definition.id;
            if((this.pendingPurchaseCallbacks.ContainsKey(key:  val_31)) == false)
            {
                goto label_78;
            }
            
            if(null != 0)
            {
                    ProductID = val_31;
            }
            else
            {
                    ProductID = val_31;
            }
            
            Success = true;
            System.Collections.Generic.List<System.Action<TzarGames.Common.IPurchaseResult>> val_34 = this.pendingPurchaseCallbacks.Item[val_31];
            List.Enumerator<T> val_35 = val_34.GetEnumerator();
            label_85:
            if((0 & 1) == 0)
            {
                goto label_83;
            }
            
            val_26.InitializationCallback.Invoke(obj:  new TzarGames.Common.PurchaseResult());
            goto label_85;
            label_83:
            val_45 = 0;
            val_46 = 1;
            val_26.Dispose();
            val_34.Clear();
            if(((0 & 1) & 1) != 0)
            {
                    return 0;
            }
            
            label_78:
            val_47 = null;
            val_47 = null;
            val_48 = TzarGames.Common.UnityInAppManager.OnProcessPurchase;
            if(val_48 == null)
            {
                    return 0;
            }
            
            val_48 = TzarGames.Common.UnityInAppManager.OnProcessPurchase;
            if(val_48 == null)
            {
                    val_48 = 0;
            }
            
            val_48.Invoke(obj:  e);
            return 0;
            label_109:
            val_40 = ;
            do
            {
            
            }
            while( != val_38);
            
            val_49 = ;
            if((null & 1) != 0)
            {
                    UnityEngine.Debug.LogException(exception:  0);
                return 0;
            }
            
            mem[8] = ;
            goto label_109;
        }
        public void OnPurchaseFailed(UnityEngine.Purchasing.Product i, UnityEngine.Purchasing.PurchaseFailureReason p)
        {
            string val_14;
            var val_15;
            string val_16;
            var val_18;
            val_14 = i;
            val_15 = this;
            typeof(System.Object[]).__il2cppRuntimeField_20 = val_14.definition.id;
            typeof(System.Object[]).__il2cppRuntimeField_28 = p;
            UnityEngine.Debug.LogFormat(format:  0, args:  "Purchase failed: {0}, reason: {1}");
            val_16 = val_14.definition.id;
            if((this.pendingPurchaseCallbacks.ContainsKey(key:  val_16)) == false)
            {
                    return;
            }
            
            val_14 = val_14.definition.id;
            if(null != 0)
            {
                    ProductID = val_14;
            }
            else
            {
                    ProductID = val_14;
            }
            
            Success = false;
            if(((p < 8) ? (p + 6) : 0) > 13)
            {
                    return;
            }
            
            var val_14 = 25486696 + (p < 0x8 ? (p + 6) : 0) << 2;
            val_14 = val_14 + 25486696;
            goto (25486696 + (p < 0x8 ? (p + 6) : 0) << 2 + 25486696);
            label_32:
            if((0 & 1) == 0)
            {
                goto label_30;
            }
            
            0.InitializationCallback.Invoke(obj:  new TzarGames.Common.PurchaseResult());
            goto label_32;
            label_30:
            val_18 = 0;
            val_14 = 1;
            0.Dispose();
            Clear();
        }
        private TzarGames.Common.UnityProductInfo getProduct(string productId)
        {
            string val_3;
            var val_4;
            TzarGames.Common.UnityProductInfo val_5;
            val_4 = 0;
            label_7:
            if(val_4 >= this.products.Length)
            {
                goto label_2;
            }
            
            val_5 = this.products[0];
            val_3 = this.products[0x0][0].ProductId;
            val_4 = val_4 + 1;
            if((System.String.op_Equality(a:  0, b:  val_3)) == false)
            {
                goto label_7;
            }
            
            return (TzarGames.Common.UnityProductInfo)val_5;
            label_2:
            val_5 = 0;
            return (TzarGames.Common.UnityProductInfo)val_5;
        }
        private void callFailureCallback(string productId, System.Action<TzarGames.Common.IPurchaseResult> callback)
        {
            if(callback == null)
            {
                    return;
            }
            
            if(null != 0)
            {
                    ProductID = productId;
                Success = false;
            }
            else
            {
                    ProductID = productId;
                Success = false;
            }
            
            FailureReason = 7;
            callback.Invoke(obj:  new TzarGames.Common.PurchaseResult());
        }
        public static bool get_SupportsRestoringPurchases()
        {
            var val_4;
            if(UnityEngine.Application.platform != 8)
            {
                    return (bool)(UnityEngine.Application.platform == 1) ? 1 : 0;
            }
            
            val_4 = 1;
            return (bool)(UnityEngine.Application.platform == 1) ? 1 : 0;
        }
        public void RestorePurchases()
        {
            IntPtr val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            if((this.<IsInitialized>k__BackingField) == false)
            {
                goto label_1;
            }
            
            if(TzarGames.Common.UnityInAppManager.SupportsRestoringPurchases == false)
            {
                goto label_4;
            }
            
            UnityEngine.Debug.Log(message:  0);
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_8 = this.extensions;
            goto label_11;
            label_1:
            UnityEngine.Debug.Log(message:  0);
            return;
            label_4:
            UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
            string val_3 = 0 + "RestorePurchases FAIL. Not supported on this platform. Current = "("RestorePurchases FAIL. Not supported on this platform. Current = ");
            UnityEngine.Debug.Log(message:  0);
            return;
            label_11:
            val_9 = null;
            val_9 = null;
            if((TzarGames.Common.UnityInAppManager.<>f__am$cache0) == null)
            {
                    System.Action<System.Boolean> val_5 = null;
                val_7 = static System.Void TzarGames.Common.UnityInAppManager::<RestorePurchases>m__0(bool result);
                val_5 = new System.Action<System.Boolean>(object:  0, method:  val_7);
                val_10 = null;
                val_10 = null;
                TzarGames.Common.UnityInAppManager.<>f__am$cache0 = val_5;
                val_9 = null;
            }
            
            val_9 = null;
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_7 = 0;
            val_11 = this.extensions;
            goto x3;
        }
        public string GetLocalizedPriceForProduct(string productId)
        {
            var val_4;
            if((this.controller != null) && ((this.<IsInitialized>k__BackingField) != false))
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
                val_4 = this.controller;
            }
            else
            {
                    typeof(System.Object[]).__il2cppRuntimeField_20 = productId;
                typeof(System.Object[]).__il2cppRuntimeField_28 = this.controller;
                typeof(System.Object[]).__il2cppRuntimeField_30 = this.<IsInitialized>k__BackingField;
                typeof(System.Object[]).__il2cppRuntimeField_31 = 25890803;
                UnityEngine.Debug.LogErrorFormat(format:  0, args:  "InApps not initialized (GetLocalizedPriceForProduct), productId: {0}, controller: {1}, IsInitialized: {2}");
                return 0;
            }
            
            UnityEngine.Purchasing.ProductMetadata val_3 = this.controller.WithID(id:  productId).metadata;
            if(val_3 != null)
            {
                    return val_3.localizedPriceString;
            }
            
            return val_3.localizedPriceString;
        }
        public void InitiatePurchase(string productId, System.Action<TzarGames.Common.IPurchaseResult> resultCallback)
        {
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.Action<TzarGames.Common.IPurchaseResult>>> val_8;
            System.Collections.Generic.List<System.Action<TzarGames.Common.IPurchaseResult>> val_9;
            var val_10;
            var val_11;
            val_8 = 1152921504608284672;
            string val_1 = 0 + "Initiate purchase: "("Initiate purchase: ");
            UnityEngine.Debug.Log(message:  0);
            if((this.controller == null) || ((this.<IsInitialized>k__BackingField) == false))
            {
                goto label_6;
            }
            
            if((this.getProduct(productId:  productId)) == null)
            {
                goto label_7;
            }
            
            if((this.pendingPurchaseCallbacks.ContainsKey(key:  productId)) == false)
            {
                goto label_9;
            }
            
            val_9 = this.pendingPurchaseCallbacks.Item[productId];
            if(val_9 != null)
            {
                goto label_30;
            }
            
            goto label_12;
            label_6:
            typeof(System.Object[]).__il2cppRuntimeField_20 = productId;
            typeof(System.Object[]).__il2cppRuntimeField_28 = this.controller;
            typeof(System.Object[]).__il2cppRuntimeField_30 = this.<IsInitialized>k__BackingField;
            typeof(System.Object[]).__il2cppRuntimeField_31 = 25891654;
            UnityEngine.Debug.LogErrorFormat(format:  0, args:  "InApps not initialized (InitiatePurchase), productId: {0}, controller: {1}, IsInitialized: {2}");
            this.callFailureCallback(productId:  productId, callback:  resultCallback);
            return;
            label_7:
            string val_5 = 0 + "No product found with id ";
            UnityEngine.Debug.LogError(message:  0);
            this.callFailureCallback(productId:  productId, callback:  resultCallback);
            return;
            label_9:
            System.Collections.Generic.List<System.Action<TzarGames.Common.IPurchaseResult>> val_6 = null;
            val_9 = val_6;
            val_6 = new System.Collections.Generic.List<System.Action<TzarGames.Common.IPurchaseResult>>();
            val_8 = this.pendingPurchaseCallbacks;
            val_8.Add(key:  productId, value:  val_9);
            if(null != 0)
            {
                goto label_30;
            }
            
            label_12:
            label_30:
            val_10 = public System.Void System.Collections.Generic.List<System.Action<TzarGames.Common.IPurchaseResult>>::Add(System.Action<TzarGames.Common.IPurchaseResult> item);
            Add(item:  resultCallback);
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_10 = 2;
            val_11 = this.controller;
            goto x3;
        }
        public bool IsProductPurchased(string productId)
        {
            var val_7;
            var val_8;
            if(this.controller == null)
            {
                    return false;
            }
            
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_7 = this.controller;
            if(this.controller == null)
            {
                    return false;
            }
            
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_8 = this.controller;
            var val_10 = 0;
            do
            {
                if(val_10 >= val_3.Length)
            {
                    return false;
            }
            
                UnityEngine.Purchasing.Product val_9 = this.controller.all[0];
                val_10 = val_10 + 1;
            }
            while((System.String.op_Equality(a:  0, b:  val_9.definition.id)) == false);
            
            if(val_9 != null)
            {
                    return val_9.hasReceipt;
            }
            
            return val_9.hasReceipt;
        }
        private static UnityInAppManager()
        {
        
        }
        private static void <RestorePurchases>m__0(bool result)
        {
            string val_2 = 0 + "RestorePurchases continuing: "("RestorePurchases continuing: ") + W1 & 1(W1 & 1);
            UnityEngine.Debug.Log(message:  0);
        }
    
    }

}

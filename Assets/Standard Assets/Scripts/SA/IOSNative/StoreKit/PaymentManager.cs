using UnityEngine;

namespace SA.IOSNative.StoreKit
{
    public class PaymentManager : Singleton<SA.IOSNative.StoreKit.PaymentManager>
    {
        // Fields
        public const string APPLE_VERIFICATION_SERVER = "https://buy.itunes.apple.com/verifyReceipt";
        public const string SANDBOX_VERIFICATION_SERVER = "https://sandbox.itunes.apple.com/verifyReceipt";
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static System.Action<SA.Common.Models.Result> OnStoreKitInitComplete;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static System.Action OnRestoreStarted;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static System.Action<SA.IOSNative.StoreKit.RestoreResult> OnRestoreComplete;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static System.Action<string> OnTransactionStarted;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static System.Action<SA.IOSNative.StoreKit.PurchaseResult> OnTransactionComplete;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static System.Action<string> OnProductPurchasedExternally;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static System.Action<SA.IOSNative.StoreKit.VerificationResponse> OnVerificationComplete;
        private bool _IsStoreLoaded;
        private bool _IsWaitingLoadResult;
        private static int _nextId;
        private System.Collections.Generic.Dictionary<int, SA.IOSNative.StoreKit.StoreProductView> _productsView;
        private static string lastPurchasedProduct;
        
        // Properties
        public System.Collections.Generic.List<SA.IOSNative.StoreKit.Product> Products { get; }
        public bool IsStoreLoaded { get; }
        public bool IsInAppPurchasesEnabled { get; }
        public bool IsWaitingLoadResult { get; }
        private static int NextId { get; }
        
        // Methods
        public PaymentManager()
        {
            this._productsView = new System.Collections.Generic.Dictionary<System.Int32, SA.IOSNative.StoreKit.StoreProductView>();
        }
        public static void add_OnStoreKitInitComplete(System.Action<SA.Common.Models.Result> value)
        {
            var val_3;
            System.Action<SA.Common.Models.Result> val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.StoreKit.PaymentManager.OnStoreKitInitComplete;
            System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  null);
            val_5 = 0;
            if(val_1 == null)
            {
                    return;
            }
            
            val_5 = val_1;
            if(null == null)
            {
                    return;
            }
            
            val_5 = 0;
        }
        public static void remove_OnStoreKitInitComplete(System.Action<SA.Common.Models.Result> value)
        {
            var val_3;
            System.Action<SA.Common.Models.Result> val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.StoreKit.PaymentManager.OnStoreKitInitComplete;
            System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  null);
            val_5 = 0;
            if(val_1 == null)
            {
                    return;
            }
            
            val_5 = val_1;
            if(null == null)
            {
                    return;
            }
            
            val_5 = 0;
        }
        public static void add_OnRestoreStarted(System.Action value)
        {
            var val_3;
            System.Action val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.StoreKit.PaymentManager.OnRestoreStarted;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = SA.IOSNative.StoreKit.PaymentManager.__il2cppRuntimeField_static_fields;
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
            
            if(1152921504846733320 != val_4)
            {
                goto label_8;
            }
        
        }
        public static void remove_OnRestoreStarted(System.Action value)
        {
            var val_3;
            System.Action val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.StoreKit.PaymentManager.OnRestoreStarted;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = SA.IOSNative.StoreKit.PaymentManager.__il2cppRuntimeField_static_fields;
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
            
            if(1152921504846733320 != val_4)
            {
                goto label_8;
            }
        
        }
        public static void add_OnRestoreComplete(System.Action<SA.IOSNative.StoreKit.RestoreResult> value)
        {
            var val_3;
            System.Action<SA.IOSNative.StoreKit.RestoreResult> val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.StoreKit.PaymentManager.OnRestoreComplete;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = SA.IOSNative.StoreKit.PaymentManager.__il2cppRuntimeField_static_fields;
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
            
            if(1152921504846733328 != val_4)
            {
                goto label_8;
            }
        
        }
        public static void remove_OnRestoreComplete(System.Action<SA.IOSNative.StoreKit.RestoreResult> value)
        {
            var val_3;
            System.Action<SA.IOSNative.StoreKit.RestoreResult> val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.StoreKit.PaymentManager.OnRestoreComplete;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = SA.IOSNative.StoreKit.PaymentManager.__il2cppRuntimeField_static_fields;
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
            
            if(1152921504846733328 != val_4)
            {
                goto label_8;
            }
        
        }
        public static void add_OnTransactionStarted(System.Action<string> value)
        {
            var val_3;
            System.Action<System.String> val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.StoreKit.PaymentManager.OnTransactionStarted;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = SA.IOSNative.StoreKit.PaymentManager.__il2cppRuntimeField_static_fields;
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
            
            if(1152921504846733336 != val_4)
            {
                goto label_8;
            }
        
        }
        public static void remove_OnTransactionStarted(System.Action<string> value)
        {
            var val_3;
            System.Action<System.String> val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.StoreKit.PaymentManager.OnTransactionStarted;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = SA.IOSNative.StoreKit.PaymentManager.__il2cppRuntimeField_static_fields;
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
            
            if(1152921504846733336 != val_4)
            {
                goto label_8;
            }
        
        }
        public static void add_OnTransactionComplete(System.Action<SA.IOSNative.StoreKit.PurchaseResult> value)
        {
            var val_3;
            System.Action<SA.IOSNative.StoreKit.PurchaseResult> val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.StoreKit.PaymentManager.OnTransactionComplete;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = SA.IOSNative.StoreKit.PaymentManager.__il2cppRuntimeField_static_fields;
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
            
            if(1152921504846733344 != val_4)
            {
                goto label_8;
            }
        
        }
        public static void remove_OnTransactionComplete(System.Action<SA.IOSNative.StoreKit.PurchaseResult> value)
        {
            var val_3;
            System.Action<SA.IOSNative.StoreKit.PurchaseResult> val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.StoreKit.PaymentManager.OnTransactionComplete;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = SA.IOSNative.StoreKit.PaymentManager.__il2cppRuntimeField_static_fields;
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
            
            if(1152921504846733344 != val_4)
            {
                goto label_8;
            }
        
        }
        public static void add_OnProductPurchasedExternally(System.Action<string> value)
        {
            var val_3;
            System.Action<System.String> val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.StoreKit.PaymentManager.OnProductPurchasedExternally;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = SA.IOSNative.StoreKit.PaymentManager.__il2cppRuntimeField_static_fields;
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
            
            if(1152921504846733352 != val_4)
            {
                goto label_8;
            }
        
        }
        public static void remove_OnProductPurchasedExternally(System.Action<string> value)
        {
            var val_3;
            System.Action<System.String> val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.StoreKit.PaymentManager.OnProductPurchasedExternally;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = SA.IOSNative.StoreKit.PaymentManager.__il2cppRuntimeField_static_fields;
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
            
            if(1152921504846733352 != val_4)
            {
                goto label_8;
            }
        
        }
        public static void add_OnVerificationComplete(System.Action<SA.IOSNative.StoreKit.VerificationResponse> value)
        {
            var val_3;
            System.Action<SA.IOSNative.StoreKit.VerificationResponse> val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.StoreKit.PaymentManager.OnVerificationComplete;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = SA.IOSNative.StoreKit.PaymentManager.__il2cppRuntimeField_static_fields;
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
            
            if(1152921504846733360 != val_4)
            {
                goto label_8;
            }
        
        }
        public static void remove_OnVerificationComplete(System.Action<SA.IOSNative.StoreKit.VerificationResponse> value)
        {
            var val_3;
            System.Action<SA.IOSNative.StoreKit.VerificationResponse> val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.StoreKit.PaymentManager.OnVerificationComplete;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = SA.IOSNative.StoreKit.PaymentManager.__il2cppRuntimeField_static_fields;
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
            
            if(1152921504846733360 != val_4)
            {
                goto label_8;
            }
        
        }
        private void Awake()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  0);
        }
        public void LoadStore(bool forceLoad = False)
        {
            var val_16;
            var val_17;
            string val_18;
            if(((this._IsStoreLoaded & 255) == false) || (forceLoad == true))
            {
                goto label_2;
            }
            
            label_23:
            this.Invoke(methodName:  "FireSuccessInitEvent", time:  1f);
            return;
            label_2:
            if(this._IsStoreLoaded > true)
            {
                    return;
            }
            
            this._IsWaitingLoadResult = true;
            val_17 = null;
            val_17 = null;
            val_18 = System.String.Empty;
            val_16 = Products.Count;
            if(val_16 >= 1)
            {
                    var val_16 = 0;
                do
            {
                if(val_16 != 0)
            {
                    string val_5 = 0 + val_18;
                val_18 = val_5;
            }
            
                SA.IOSNative.StoreKit.Product val_7 = val_5.Products.Item[0];
                string val_8 = 0 + val_18;
                val_16 = val_16 + 1;
            }
            while(val_16 != val_16);
            
            }
            
            ISN_SoomlaGrow.Init();
            if(UnityEngine.Application.isEditor == false)
            {
                goto label_18;
            }
            
            IOSNativeSettings val_13 = IOSNativeSettings.Instance;
            if(val_13.InAppsEditorTesting == false)
            {
                    return;
            }
            
            goto label_23;
            label_18:
            IOSNativeSettings val_14 = IOSNativeSettings.Instance;
            if(IOSNativeSettings.Instance != null)
            {
                    return;
            }
        
        }
        public void BuyProduct(string productId)
        {
            System.Action<System.String> val_5;
            var val_6;
            var val_7;
            if(UnityEngine.Application.isEditor != false)
            {
                    IOSNativeSettings val_3 = IOSNativeSettings.Instance;
                if(val_3.InAppsEditorTesting == false)
            {
                    return;
            }
            
                val_6 = null;
                val_6 = null;
                FireProductBoughtEvent(productIdentifier:  productId, applicationUsername:  System.String.Empty, receipt:  System.String.Empty, transactionIdentifier:  System.String.Empty, IsRestored:  false);
                return;
            }
            
            val_7 = null;
            val_7 = null;
            val_5 = SA.IOSNative.StoreKit.PaymentManager.OnTransactionStarted;
            val_5.Invoke(obj:  productId);
            if(this._IsStoreLoaded != false)
            {
                    return;
            }
            
            ISN_Logger.Log(message:  0, logType:  "buyProduct shouldn\'t be called before StoreKit is initialized");
            SA.Common.Models.Error val_4 = new SA.Common.Models.Error(code:  4, message:  "StoreKit not yet initialized");
            val_4.SendTransactionFailEvent(productIdentifier:  productId, error:  val_4);
        }
        public void FinishTransaction(string productId)
        {
        
        }
        public void AddProductId(string productId)
        {
            SA.IOSNative.StoreKit.Product val_1 = new SA.IOSNative.StoreKit.Product();
            typeof(SA.IOSNative.StoreKit.Product).__il2cppRuntimeField_18 = productId;
            val_1.AddProduct(product:  val_1);
        }
        public void AddProduct(SA.IOSNative.StoreKit.Product product)
        {
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            List.Enumerator<T> val_2 = this.Products.GetEnumerator();
            label_6:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            bool val_4 = X21.Equals(value:  product._Id);
            if(val_4 == false)
            {
                goto label_6;
            }
            
            val_9 = val_4.Products.IndexOf(item:  0.InitializationCallback);
            val_10 = 0;
            val_11 = 1;
            val_12 = 1;
            goto label_9;
            label_2:
            val_10 = 0;
            val_9 = 0;
            val_12 = 0;
            val_11 = 1;
            label_9:
            0.Dispose();
            System.Collections.Generic.List<SA.IOSNative.StoreKit.Product> val_8 = this.Products;
            if(val_12 != 0)
            {
                    val_8.set_Item(index:  0, value:  product);
                return;
            }
            
            val_8.Add(item:  product);
        }
        public SA.IOSNative.StoreKit.Product GetProductById(string prodcutId)
        {
            string val_7;
            SA.IOSNative.StoreKit.Product val_8;
            val_7 = prodcutId;
            List.Enumerator<T> val_2 = this.Products.GetEnumerator();
            label_5:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            val_8 = 0.InitializationCallback;
            if((X21.Equals(value:  val_7)) == false)
            {
                goto label_5;
            }
            
            0.Dispose();
            return val_8;
            label_2:
            0.Dispose();
            SA.IOSNative.StoreKit.Product val_5 = null;
            val_8 = val_5;
            val_5 = new SA.IOSNative.StoreKit.Product();
            typeof(SA.IOSNative.StoreKit.Product).__il2cppRuntimeField_18 = val_7;
            val_7 = val_5.Products;
            val_7.Add(item:  val_8);
            return val_8;
        }
        public void RestorePurchases()
        {
            var val_9;
            System.Action val_10;
            var val_11;
            var val_12;
            if(this._IsStoreLoaded == false)
            {
                goto label_1;
            }
            
            val_9 = null;
            val_9 = null;
            val_10 = SA.IOSNative.StoreKit.PaymentManager.OnRestoreStarted;
            val_10.Invoke();
            if(UnityEngine.Application.isEditor == false)
            {
                    return;
            }
            
            IOSNativeSettings val_2 = IOSNativeSettings.Instance;
            val_10 = val_2;
            if(val_2.InAppsEditorTesting == false)
            {
                    return;
            }
            
            List.Enumerator<T> val_4 = val_2.Products.GetEnumerator();
            label_17:
            if((0 & 1) == 0)
            {
                goto label_11;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_5 = 0.InitializationCallback;
            if(0 != 1)
            {
                goto label_17;
            }
            
            string val_6 = 0 + "Restored: "("Restored: ");
            ISN_Logger.Log(message:  0, logType:  val_6);
            this.FireProductBoughtEvent(productIdentifier:  val_6, applicationUsername:  System.String.Empty, receipt:  System.String.Empty, transactionIdentifier:  System.String.Empty, IsRestored:  true);
            goto label_17;
            label_1:
            object val_8 = null;
            val_10 = val_8;
            val_8 = new System.Object();
            typeof(SA.IOSNative.StoreKit.RestoreResult).__il2cppRuntimeField_10 = new SA.Common.Models.Error(code:  7, message:  "Store Kit Initilizations required");
            val_12 = null;
            val_12 = null;
            SA.IOSNative.StoreKit.PaymentManager.OnRestoreComplete.Invoke(obj:  val_10);
            return;
            label_11:
            val_10 = 0;
            val_11 = 1;
            0.Dispose();
            this.FireRestoreCompleteEvent();
        }
        public void VerifyLastPurchase(string url)
        {
        
        }
        public void RegisterProductView(SA.IOSNative.StoreKit.StoreProductView view)
        {
            int val_2;
            System.Collections.Generic.Dictionary<System.Int32, SA.IOSNative.StoreKit.StoreProductView> val_3;
            val_2 = SA.IOSNative.StoreKit.PaymentManager.NextId;
            if(view != null)
            {
                    view._id = val_2;
                val_3 = this._productsView;
            }
            else
            {
                    mem[48] = val_2;
                val_3 = this._productsView;
                val_2 = mem[48];
            }
            
            val_3.Add(key:  val_2, value:  view);
        }
        public System.Collections.Generic.List<SA.IOSNative.StoreKit.Product> get_Products()
        {
            if(IOSNativeSettings.Instance != null)
            {
                    return (System.Collections.Generic.List<SA.IOSNative.StoreKit.Product>)val_1.InAppProducts;
            }
            
            return (System.Collections.Generic.List<SA.IOSNative.StoreKit.Product>)val_1.InAppProducts;
        }
        public bool get_IsStoreLoaded()
        {
            return (bool)this._IsStoreLoaded;
        }
        public bool get_IsInAppPurchasesEnabled()
        {
            return false;
        }
        public bool get_IsWaitingLoadResult()
        {
            return (bool)this._IsWaitingLoadResult;
        }
        private static int get_NextId()
        {
            null = null;
            int val_1 = SA.IOSNative.StoreKit.PaymentManager._nextId;
            val_1 = val_1 + 1;
            SA.IOSNative.StoreKit.PaymentManager._nextId = val_1;
            return (int)SA.IOSNative.StoreKit.PaymentManager._nextId;
        }
        private void OnStoreKitInitFailed(string data)
        {
            var val_5;
            this._IsStoreLoaded = false;
            this._IsWaitingLoadResult = false;
            typeof(SA.Common.Models.Result).__il2cppRuntimeField_10 = new SA.Common.Models.Error(errorData:  data);
            val_5 = null;
            val_5 = null;
            SA.IOSNative.StoreKit.PaymentManager.OnStoreKitInitComplete.Invoke(obj:  new System.Object());
            IOSNativeSettings val_3 = IOSNativeSettings.Instance;
            if(val_3.DisablePluginLogs != false)
            {
                    return;
            }
            
            ISN_Logger.Log(message:  0, logType:  0 + "STORE_KIT_INIT_FAILED Error: "("STORE_KIT_INIT_FAILED Error: "));
        }
        private void onStoreDataReceived(string data)
        {
            SA.Common.Models.Result val_22;
            var val_23;
            string val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            val_22 = this;
            val_23 = null;
            val_23 = null;
            val_24 = System.String.Empty;
            if((data.Equals(value:  val_24)) != false)
            {
                    ISN_Logger.Log(message:  0, logType:  "InAppPurchaseManager, no products avaiable");
                object val_2 = null;
                val_22 = val_2;
                val_2 = new System.Object();
                val_25 = null;
                val_25 = null;
                SA.IOSNative.StoreKit.PaymentManager.OnStoreKitInitComplete.Invoke(obj:  val_22);
                return;
            }
            
            typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
            System.String[] val_3 = data.Split(separator:  null);
            val_26 = 0;
            goto label_12;
            label_28:
            val_26 = W22 + 1;
            typeof(System.Char[]).__il2cppRuntimeField_11 = 1;
            typeof(System.Char[]).__il2cppRuntimeField_40 = val_3[val_26];
            label_12:
            if(val_26 >= val_3.Length)
            {
                goto label_14;
            }
            
            SA.IOSNative.StoreKit.Product val_4 = val_3.GetProductById(prodcutId:  val_3[(long)val_26]);
            var val_24 = (long)val_26 + 1;
            val_4._DisplayName = val_3[val_24];
            val_24 = val_24 + 1;
            val_24 = val_24 + 1;
            val_4._Description = val_3[(long)val_26 + 2];
            val_4._LocalizedPrice = val_3[(long)val_26 + 3];
            string val_27 = val_3[(long)val_26 + 4];
            val_4._Price = System.Convert.ToSingle(value:  0);
            var val_12 = (val_24 + 1) + 1;
            val_4._CurrencyCode = val_3[(long)val_26 + 5];
            var val_13 = val_26 + 6;
            val_12 = val_12 + 1;
            if(val_12 < val_3.Length)
            {
                goto label_28;
            }
            
            goto label_28;
            label_14:
            int val_15 = val_3.Products.Count;
            ISN_Logger.Log(message:  0, logType:  0 + "InAppPurchaseManager, total products in settings: "("InAppPurchaseManager, total products in settings: "));
            List.Enumerator<T> val_18 = this.Products.GetEnumerator();
            val_24 = 0;
            goto label_33;
            label_36:
            label_33:
            if((0 & 1) == 0)
            {
                goto label_34;
            }
            
            if(0.InitializationCallback != null)
            {
                goto label_36;
            }
            
            goto label_36;
            label_34:
            val_27 = 0;
            val_28 = 1;
            0.Dispose();
            ISN_Logger.Log(message:  0, logType:  0 + "InAppPurchaseManager, total avaliable products");
            this.FireSuccessInitEvent();
        }
        private void onProductBought(string array)
        {
            var val_5;
            int val_6;
            val_5 = "|";
            if(("|") == null)
            {
                    val_5 = "|";
            }
            
            typeof(System.Char[]).__il2cppRuntimeField_20 = Chars[0];
            System.String[] val_2 = array.Split(separator:  null);
            bool val_3 = val_2[1].Equals(value:  "0");
            val_6 = val_2.Length;
            if(val_6 == 0)
            {
                    val_6 = val_2.Length;
            }
            
            if(val_6 <= 2)
            {
                    val_6 = val_2.Length;
            }
            
            if(val_6 <= 3)
            {
                    val_6 = val_2.Length;
            }
            
            val_3.FireProductBoughtEvent(productIdentifier:  val_2[0], applicationUsername:  val_2[2], receipt:  val_2[3], transactionIdentifier:  val_2[4], IsRestored:  val_3);
        }
        private void onProductPurchasedExternally(string productIdentifier)
        {
            null = null;
            SA.IOSNative.StoreKit.PaymentManager.OnProductPurchasedExternally.Invoke(obj:  productIdentifier);
        }
        private void onProductStateDeferred(string productIdentifier)
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            val_3 = null;
            val_3 = null;
            SA.IOSNative.StoreKit.PaymentManager.OnTransactionComplete.Invoke(obj:  new SA.IOSNative.StoreKit.PurchaseResult(productIdentifier:  productIdentifier, state:  2, applicationUsername:  System.String.Empty, receipt:  System.String.Empty, transactionIdentifier:  System.String.Empty));
        }
        private void onTransactionFailed(string data)
        {
            var val_3;
            int val_4;
            val_3 = "|%|";
            if(("|%|") == null)
            {
                    val_3 = "|%|";
            }
            
            typeof(System.String[]).__il2cppRuntimeField_20 = val_3;
            System.String[] val_1 = data.Split(separator:  null, options:  0);
            val_4 = val_1.Length;
            if(val_4 == 0)
            {
                    val_4 = val_1.Length;
            }
            
            SA.Common.Models.Error val_2 = new SA.Common.Models.Error(errorData:  val_1[1]);
            val_2.SendTransactionFailEvent(productIdentifier:  val_1[0], error:  val_2);
        }
        private void onVerificationResult(string data)
        {
            null = null;
            SA.IOSNative.StoreKit.PaymentManager.OnVerificationComplete.Invoke(obj:  new SA.IOSNative.StoreKit.VerificationResponse(productIdentifier:  SA.IOSNative.StoreKit.PaymentManager.lastPurchasedProduct, dataArray:  data));
        }
        public void onRestoreTransactionFailed(string array)
        {
            var val_3;
            typeof(SA.IOSNative.StoreKit.RestoreResult).__il2cppRuntimeField_10 = new SA.Common.Models.Error(errorData:  array);
            val_3 = null;
            val_3 = null;
            SA.IOSNative.StoreKit.PaymentManager.OnRestoreComplete.Invoke(obj:  new System.Object());
        }
        public void onRestoreTransactionComplete(string array)
        {
            this.FireRestoreCompleteEvent();
        }
        private void OnProductViewLoaded(string viewId)
        {
            int val_1 = System.Convert.ToInt32(value:  0);
            if((this._productsView.ContainsKey(key:  val_1)) == false)
            {
                    return;
            }
            
            SA.IOSNative.StoreKit.StoreProductView val_3 = this._productsView.Item[val_1];
            val_3.Loaded.Invoke();
        }
        private void OnProductViewLoadedFailed(string viewId)
        {
            int val_1 = System.Convert.ToInt32(value:  0);
            if((this._productsView.ContainsKey(key:  val_1)) == false)
            {
                    return;
            }
            
            SA.IOSNative.StoreKit.StoreProductView val_3 = this._productsView.Item[val_1];
            val_3.LoadFailed.Invoke();
        }
        private void OnProductViewDismissed(string viewId)
        {
            int val_1 = System.Convert.ToInt32(value:  0);
            if((this._productsView.ContainsKey(key:  val_1)) == false)
            {
                    return;
            }
            
            SA.IOSNative.StoreKit.StoreProductView val_3 = this._productsView.Item[val_1];
            val_3.Dismissed.Invoke();
        }
        private void FireSuccessInitEvent()
        {
            var val_2;
            this._IsStoreLoaded = true;
            this._IsWaitingLoadResult = false;
            val_2 = null;
            val_2 = null;
            SA.IOSNative.StoreKit.PaymentManager.OnStoreKitInitComplete.Invoke(obj:  new System.Object());
        }
        private void FireRestoreCompleteEvent()
        {
            var val_2 = null;
            SA.IOSNative.StoreKit.PaymentManager.OnRestoreComplete.Invoke(obj:  new System.Object());
        }
        private void FireProductBoughtEvent(string productIdentifier, string applicationUsername, string receipt, string transactionIdentifier, bool IsRestored)
        {
            var val_3 = null;
            SA.IOSNative.StoreKit.PaymentManager.lastPurchasedProduct = SA.IOSNative.StoreKit.PurchaseResult.__il2cppRuntimeField_namespaze;
            SA.IOSNative.StoreKit.PaymentManager.OnTransactionComplete.Invoke(obj:  new SA.IOSNative.StoreKit.PurchaseResult(productIdentifier:  productIdentifier, state:  (IsRestored != true) ? 3 : 0, applicationUsername:  applicationUsername, receipt:  receipt, transactionIdentifier:  transactionIdentifier));
        }
        private void SendTransactionFailEvent(string productIdentifier, SA.Common.Models.Error error)
        {
            var val_2 = null;
            SA.IOSNative.StoreKit.PaymentManager.OnTransactionComplete.Invoke(obj:  new SA.IOSNative.StoreKit.PurchaseResult(productIdentifier:  productIdentifier, e:  error));
        }
        private void EditorFakeInitEvent()
        {
            this.FireSuccessInitEvent();
        }
        private static PaymentManager()
        {
            SA.IOSNative.StoreKit.PaymentManager.OnStoreKitInitComplete = new System.Action<SA.Common.Models.Result>(object:  0, method:  static System.Void SA.IOSNative.StoreKit.PaymentManager::<OnStoreKitInitComplete>m__0(SA.Common.Models.Result ));
            SA.IOSNative.StoreKit.PaymentManager.OnRestoreStarted = new System.Action(object:  0, method:  static System.Void SA.IOSNative.StoreKit.PaymentManager::<OnRestoreStarted>m__1());
            SA.IOSNative.StoreKit.PaymentManager.OnRestoreComplete = new System.Action<SA.IOSNative.StoreKit.RestoreResult>(object:  0, method:  static System.Void SA.IOSNative.StoreKit.PaymentManager::<OnRestoreComplete>m__2(SA.IOSNative.StoreKit.RestoreResult ));
            SA.IOSNative.StoreKit.PaymentManager.OnTransactionStarted = new System.Action<System.String>(object:  0, method:  static System.Void SA.IOSNative.StoreKit.PaymentManager::<OnTransactionStarted>m__3(string ));
            SA.IOSNative.StoreKit.PaymentManager.OnTransactionComplete = new System.Action<SA.IOSNative.StoreKit.PurchaseResult>(object:  0, method:  static System.Void SA.IOSNative.StoreKit.PaymentManager::<OnTransactionComplete>m__4(SA.IOSNative.StoreKit.PurchaseResult ));
            SA.IOSNative.StoreKit.PaymentManager.OnProductPurchasedExternally = new System.Action<System.String>(object:  0, method:  static System.Void SA.IOSNative.StoreKit.PaymentManager::<OnProductPurchasedExternally>m__5(string ));
            SA.IOSNative.StoreKit.PaymentManager.OnVerificationComplete = new System.Action<SA.IOSNative.StoreKit.VerificationResponse>(object:  0, method:  static System.Void SA.IOSNative.StoreKit.PaymentManager::<OnVerificationComplete>m__6(SA.IOSNative.StoreKit.VerificationResponse ));
            SA.IOSNative.StoreKit.PaymentManager._nextId = 1;
        }
        private static void <OnStoreKitInitComplete>m__0(SA.Common.Models.Result )
        {
        
        }
        private static void <OnRestoreStarted>m__1()
        {
        
        }
        private static void <OnRestoreComplete>m__2(SA.IOSNative.StoreKit.RestoreResult )
        {
        
        }
        private static void <OnTransactionStarted>m__3(string )
        {
        
        }
        private static void <OnTransactionComplete>m__4(SA.IOSNative.StoreKit.PurchaseResult )
        {
        
        }
        private static void <OnProductPurchasedExternally>m__5(string )
        {
        
        }
        private static void <OnVerificationComplete>m__6(SA.IOSNative.StoreKit.VerificationResponse )
        {
        
        }
    
    }

}

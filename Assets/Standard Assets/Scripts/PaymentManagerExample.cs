using UnityEngine;
public class PaymentManagerExample
{
    // Fields
    public const string SMALL_PACK = "your.product.id1.here";
    public const string NC_PACK = "your.product.id2.here";
    public string lastTransactionProdudctId;
    private static bool IsInitialized;
    private static System.Action<SA.IOSNative.StoreKit.VerificationResponse> <>f__mg$cache0;
    private static System.Action<SA.Common.Models.Result> <>f__mg$cache1;
    private static System.Action<SA.IOSNative.StoreKit.PurchaseResult> <>f__mg$cache2;
    private static System.Action<SA.IOSNative.StoreKit.RestoreResult> <>f__mg$cache3;
    
    // Methods
    public PaymentManagerExample()
    {
        null = null;
        this.lastTransactionProdudctId = System.String.Empty;
    }
    public static void init()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        val_8 = null;
        val_8 = null;
        if(PaymentManagerExample.IsInitialized != false)
        {
                return;
        }
        
        SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.AddProductId(productId:  "your.product.id1.here");
        SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.AddProductId(productId:  "your.product.id2.here");
        val_9 = null;
        val_9 = null;
        if((PaymentManagerExample.<>f__mg$cache0) == null)
        {
                val_10 = null;
            val_10 = null;
            PaymentManagerExample.<>f__mg$cache0 = new System.Action<SA.IOSNative.StoreKit.VerificationResponse>(object:  0, method:  static System.Void PaymentManagerExample::HandleOnVerificationComplete(SA.IOSNative.StoreKit.VerificationResponse response));
            val_9 = null;
        }
        
        val_9 = null;
        SA.IOSNative.StoreKit.PaymentManager.add_OnVerificationComplete(value:  0);
        val_11 = null;
        if((PaymentManagerExample.<>f__mg$cache1) == null)
        {
                val_12 = null;
            val_12 = null;
            PaymentManagerExample.<>f__mg$cache1 = new System.Action<SA.Common.Models.Result>(object:  0, method:  static System.Void PaymentManagerExample::OnStoreKitInitComplete(SA.Common.Models.Result result));
            val_11 = null;
        }
        
        val_11 = null;
        SA.IOSNative.StoreKit.PaymentManager.add_OnStoreKitInitComplete(value:  0);
        val_13 = null;
        if((PaymentManagerExample.<>f__mg$cache2) == null)
        {
                val_14 = null;
            val_14 = null;
            PaymentManagerExample.<>f__mg$cache2 = new System.Action<SA.IOSNative.StoreKit.PurchaseResult>(object:  0, method:  static System.Void PaymentManagerExample::OnTransactionComplete(SA.IOSNative.StoreKit.PurchaseResult result));
            val_13 = null;
        }
        
        val_13 = null;
        SA.IOSNative.StoreKit.PaymentManager.add_OnTransactionComplete(value:  0);
        val_15 = null;
        if((PaymentManagerExample.<>f__mg$cache3) == null)
        {
                val_16 = null;
            val_16 = null;
            PaymentManagerExample.<>f__mg$cache3 = new System.Action<SA.IOSNative.StoreKit.RestoreResult>(object:  0, method:  static System.Void PaymentManagerExample::OnRestoreComplete(SA.IOSNative.StoreKit.RestoreResult res));
            val_15 = null;
        }
        
        val_15 = null;
        SA.IOSNative.StoreKit.PaymentManager.add_OnRestoreComplete(value:  0);
        PaymentManagerExample.IsInitialized = true;
        SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.LoadStore(forceLoad:  false);
    }
    public static void buyItem(string productId)
    {
        SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.BuyProduct(productId:  X1);
    }
    private static void UnlockProducts(string productIdentifier)
    {
        if(X1 != 0)
        {
                if((System.String.op_Equality(a:  0, b:  X1)) != true)
        {
                bool val_3 = System.String.op_Equality(a:  0, b:  X1);
        }
        
        }
        
        SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.FinishTransaction(productId:  X1);
    }
    private static void OnTransactionComplete(SA.IOSNative.StoreKit.PurchaseResult result)
    {
        var val_25;
        var val_26;
        string val_28;
        val_25 = X1;
        string val_1 = val_25.ProductIdentifier;
        string val_2 = 0 + "OnTransactionComplete: "("OnTransactionComplete: ");
        ISN_Logger.Log(message:  val_2, logType:  val_2);
        SA.IOSNative.StoreKit.PurchaseState val_3 = val_25.State;
        val_26 = 1152921504846888960;
        string val_4 = 0 + "OnTransactionComplete: state: "("OnTransactionComplete: state: ");
        ISN_Logger.Log(message:  val_4, logType:  val_4);
        if(val_25.State < 4)
        {
                if((25816116 + (val_5) << 2) > 7)
        {
                return;
        }
        
            var val_25 = 25815884 + (25816116 + (val_5) << 2) << 2;
            val_25 = val_25 + 25815884;
        }
        else
        {
                if(val_25.State == 1)
        {
                typeof(System.Object[]).__il2cppRuntimeField_20 = "Error code: ";
            typeof(System.Object[]).__il2cppRuntimeField_28 = val_25.Error.Code;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            val_26 = "\nError description:";
            typeof(System.Object[]).__il2cppRuntimeField_30 = val_26;
            typeof(System.Object[]).__il2cppRuntimeField_38 = val_25.Error.Message;
            string val_18 = +0;
            return;
        }
        
            if(val_25 != 0)
        {
                val_28 = val_25.ProductIdentifier;
        }
        else
        {
                val_28 = 0.ProductIdentifier;
        }
        
            SA.IOSNative.StoreKit.PurchaseState val_21 = val_25.State;
            val_26 = val_21;
            string val_22 = val_21.ToString();
            UnityEngine.Vector2 val_23 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            string val_24 = 0 + "product " + val_28 + " state: "(" state: ");
        }
    
    }
    private static void OnRestoreComplete(SA.IOSNative.StoreKit.RestoreResult res)
    {
        if(X1.IsSucceeded == true)
        {
                return;
        }
        
        int val_3 = X1.Error.Code;
        string val_4 = 0 + "Error: "("Error: ");
        string val_6 = X1.Error.Message;
    }
    private static void HandleOnVerificationComplete(SA.IOSNative.StoreKit.VerificationResponse response)
    {
        int val_1 = X1.Status;
        string val_2 = 0 + "Transaction verification status: "("Transaction verification status: ");
        string val_3 = X1.OriginalJSON;
        string val_4 = 0 + "ORIGINAL JSON: "("ORIGINAL JSON: ");
        ISN_Logger.Log(message:  val_4, logType:  val_4);
    }
    private static void OnStoreKitInitComplete(SA.Common.Models.Result result)
    {
        T val_15;
        var val_16;
        var val_17;
        var val_18;
        if(X1.IsSucceeded == false)
        {
            goto label_2;
        }
        
        List.Enumerator<T> val_4 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.Products.GetEnumerator();
        val_15 = 0;
        goto label_7;
        label_10:
        val_15 = (val_4.current & 1) + val_15;
        label_7:
        if((0 & 1) == 0)
        {
            goto label_8;
        }
        
        bool val_7 = 0.InitializationCallback.IsAvailable;
        goto label_10;
        label_2:
        typeof(System.Object[]).__il2cppRuntimeField_20 = "Error code: ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = X1.Error.Code;
        typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
        val_18 = "\nError description:";
        typeof(System.Object[]).__il2cppRuntimeField_30 = val_18;
        typeof(System.Object[]).__il2cppRuntimeField_38 = X1.Error.Message;
        string val_12 = +0;
        return;
        label_8:
        val_16 = 0;
        val_17 = 1;
        0.Dispose();
        val_18 = 1152921504607113216;
        string val_13 = 0 + "Available products count: "("Available products count: ");
        string val_14 = 0 + "StoreKit Init Succeeded Available products count: "("StoreKit Init Succeeded Available products count: ");
        ISN_Logger.Log(message:  val_14, logType:  val_14);
    }
    private static PaymentManagerExample()
    {
    
    }

}

using UnityEngine;
public class ISN_SoomlaGrow : Singleton<ISN_SoomlaGrow>
{
    // Fields
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action ActionInitialized;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action ActionConnected;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action ActionDisconnected;
    private static bool _IsInitialized;
    
    // Properties
    public static bool IsInitialized { get; }
    
    // Methods
    public ISN_SoomlaGrow()
    {
    
    }
    public static void add_ActionInitialized(System.Action value)
    {
        var val_3;
        System.Action val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_SoomlaGrow.ActionInitialized;
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
    public static void remove_ActionInitialized(System.Action value)
    {
        var val_3;
        System.Action val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_SoomlaGrow.ActionInitialized;
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
    public static void add_ActionConnected(System.Action value)
    {
        var val_3;
        System.Action val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_SoomlaGrow.ActionConnected;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = ISN_SoomlaGrow.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504840609800 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionConnected(System.Action value)
    {
        var val_3;
        System.Action val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_SoomlaGrow.ActionConnected;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = ISN_SoomlaGrow.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504840609800 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_ActionDisconnected(System.Action value)
    {
        var val_3;
        System.Action val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_SoomlaGrow.ActionDisconnected;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = ISN_SoomlaGrow.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504840609808 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionDisconnected(System.Action value)
    {
        var val_3;
        System.Action val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_SoomlaGrow.ActionDisconnected;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = ISN_SoomlaGrow.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504840609808 != val_4)
        {
            goto label_8;
        }
    
    }
    public void CreateObject()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  0);
    }
    public static void Init()
    {
    
    }
    private static void HandleOnVerificationComplete(SA.IOSNative.StoreKit.VerificationResponse res)
    {
        if(X1.Status == 0)
        {
                return;
        }
    
    }
    private static void HandleOnRestoreComplete(SA.IOSNative.StoreKit.RestoreResult res)
    {
        bool val_1 = X1.IsSucceeded;
    }
    private static void HandleOnRestoreStarted()
    {
    
    }
    private static void HandleOnTransactionStarted(string prodcutId)
    {
    
    }
    private static void HandleOnTransactionComplete(SA.IOSNative.StoreKit.PurchaseResult res)
    {
        var val_11 = X1;
        SA.IOSNative.StoreKit.PurchaseState val_1 = val_11.State;
        if(val_1 != 1)
        {
                if(val_1 != 0)
        {
                return;
        }
        
            val_11 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.GetProductById(prodcutId:  val_11.ProductIdentifier);
            if(val_11 == null)
        {
                return;
        }
        
            string val_5 = val_11.Id;
            long val_6 = val_11.PriceInMicros;
            string val_7 = val_11.CurrencyCode;
            return;
        }
        
        if(val_11.Error.Code != 2)
        {
                return;
        }
        
        string val_10 = val_11.ProductIdentifier;
    }
    public static void SocialAction(ISN_SoomlaEvent soomlaEvent, ISN_SoomlaAction action, ISN_SoomlaProvider provider)
    {
    
    }
    private static void PurchaseStarted(string prodcutId)
    {
    
    }
    private static void PurchaseFinished(string prodcutId, string priceInMicros, string currency)
    {
    
    }
    private static void PurchaseCanceled(string prodcutId)
    {
    
    }
    public static void SetPurchasesSupportedState(bool isSupported)
    {
    
    }
    private static void PurchaseError()
    {
    
    }
    private static void VerificationFailed()
    {
    
    }
    private static void RestoreStarted()
    {
    
    }
    private static void RestoreFinished(bool state)
    {
    
    }
    public static bool get_IsInitialized()
    {
        null = null;
        return (bool)ISN_SoomlaGrow._IsInitialized;
    }
    private void OnHighWayInitialized()
    {
        null = null;
        ISN_SoomlaGrow.ActionInitialized.Invoke();
    }
    private void OnHihgWayConnected()
    {
        null = null;
        ISN_SoomlaGrow.ActionConnected.Invoke();
    }
    private void OnHihgWayDisconnected()
    {
        null = null;
        ISN_SoomlaGrow.ActionDisconnected.Invoke();
    }
    private static void HandleOnInstagramPostResult(SA.Common.Models.Result res)
    {
        if(X1.IsSucceeded == false)
        {
                return;
        }
    
    }
    private static void HandleOnTwitterPostResult(SA.Common.Models.Result res)
    {
        if(X1.IsSucceeded == false)
        {
                return;
        }
    
    }
    private static void HandleOnInstagramPostStart()
    {
    
    }
    private static void HandleOnTwitterPostStart()
    {
    
    }
    private static void HandleOnFacebookPostStart()
    {
    
    }
    private static void HandleOnFacebookPostResult(SA.Common.Models.Result res)
    {
        if(X1.IsSucceeded == false)
        {
                return;
        }
    
    }
    private static ISN_SoomlaGrow()
    {
        ISN_SoomlaGrow.ActionInitialized = new System.Action(object:  0, method:  static System.Void ISN_SoomlaGrow::<ActionInitialized>m__0());
        ISN_SoomlaGrow.ActionConnected = new System.Action(object:  0, method:  static System.Void ISN_SoomlaGrow::<ActionConnected>m__1());
        ISN_SoomlaGrow.ActionDisconnected = new System.Action(object:  0, method:  static System.Void ISN_SoomlaGrow::<ActionDisconnected>m__2());
        ISN_SoomlaGrow._IsInitialized = false;
    }
    private static void <ActionInitialized>m__0()
    {
    
    }
    private static void <ActionConnected>m__1()
    {
    
    }
    private static void <ActionDisconnected>m__2()
    {
    
    }

}

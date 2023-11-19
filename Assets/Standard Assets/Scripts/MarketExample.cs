using UnityEngine;
public class MarketExample : BaseIOSFeaturePreview
{
    // Fields
    private byte[] ReceiptData;
    
    // Methods
    public MarketExample()
    {
    
    }
    private void Awake()
    {
    
    }
    private void OnGUI()
    {
        var val_25;
        IntPtr val_26;
        this.UpdateToStartPos();
        int val_1 = UnityEngine.Screen.width;
        float val_25 = 0f;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_25, m_Width = 0f, m_Height = 0f}, text:  0, style:  "In-App Purchases");
        val_25 = val_25 + 0f;
        mem[1152921510361556632] = val_25;
        float val_26 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_26, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                PaymentManagerExample.init();
        }
        
        if((SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.IsStoreLoaded) != false)
        {
                val_25 = 0;
        }
        else
        {
                val_25 = 0;
        }
        
        UnityEngine.GUI.enabled = false;
        val_26 = 0f + val_26;
        mem[1152921510361556636] = null;
        mem[1152921510361556632] = val_26;
        float val_27 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_27, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                PaymentManagerExample.buyItem(productId:  null);
        }
        
        val_27 = 0f + val_27;
        mem[1152921510361556636] = val_27;
        float val_28 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_28, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                PaymentManagerExample.buyItem(productId:  null);
        }
        
        val_28 = 0f + val_28;
        mem[1152921510361556636] = val_28;
        float val_29 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_29, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.RestorePurchases();
        }
        
        val_29 = 0f + val_29;
        mem[1152921510361556636] = SA.Common.Pattern.Singleton<T>.__il2cppRuntimeField_cctor_finished;
        mem[1152921510361556632] = val_29;
        float val_30 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_30, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.VerifyLastPurchase(url:  "https://sandbox.itunes.apple.com/verifyReceipt");
        }
        
        val_30 = 0f + val_30;
        mem[1152921510361556636] = val_30;
        float val_31 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_31, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                typeof(System.String[]).__il2cppRuntimeField_20 = "333700869";
            SA.IOSNative.StoreKit.StoreProductView val_14 = null;
            val_26 = val_14;
            val_14 = new SA.IOSNative.StoreKit.StoreProductView(ids:  null);
            System.Action val_15 = new System.Action(object:  this, method:  System.Void MarketExample::StoreProductViewDisnissed());
            if(null != 0)
        {
                add_Dismissed(value:  val_15);
        }
        else
        {
                add_Dismissed(value:  val_15);
        }
        
            Load();
        }
        
        val_31 = 0f + val_31;
        mem[1152921510361556636] = val_31;
        float val_32 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_32, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                bool val_19 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.IsInAppPurchasesEnabled;
            string val_20 = 0 + "Is Payments Enabled: "("Is Payments Enabled: ");
        }
        
        mem[1152921510361556636] = true;
        val_32 = val_32 + 0f;
        val_32 = val_32 + 0f;
        mem[1152921510361556632] = val_32;
        UnityEngine.GUI.enabled = false;
        int val_21 = UnityEngine.Screen.width;
        float val_33 = 0f;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_33, m_Width = 0f, m_Height = 0f}, text:  0, style:  "Local Receipt Validation");
        val_33 = 0f + val_33;
        mem[1152921510361556632] = val_33;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) == false)
        {
                return;
        }
        
        val_26 = System.Void MarketExample::OnReceiptLoaded(ISN_LocalReceiptResult result);
        System.Action<ISN_LocalReceiptResult> val_23 = new System.Action<ISN_LocalReceiptResult>(object:  this, method:  val_26);
        ISN_Security.add_OnReceiptLoaded(value:  null);
        if((SA.Common.Pattern.Singleton<SA_EditorAd>.Instance) != null)
        {
                return;
        }
    
    }
    private void StoreProductViewDisnissed()
    {
        ISN_Logger.Log(message:  15876, logType:  "Store Product View was dismissed");
    }
    private void OnReceiptLoaded(ISN_LocalReceiptResult result)
    {
        ISN_Logger.Log(message:  15873, logType:  "OnReceiptLoaded");
        System.Action<ISN_LocalReceiptResult> val_1 = new System.Action<ISN_LocalReceiptResult>(object:  this, method:  System.Void MarketExample::OnReceiptLoaded(ISN_LocalReceiptResult result));
        ISN_Security.remove_OnReceiptLoaded(value:  null);
        if(result._Receipt != null)
        {
                this.ReceiptData = result._Receipt;
            IOSDialog.Create(title:  0 + "Receipt loaded, byte array length: "("Receipt loaded, byte array length: ") + result._Receipt.Length, message:  "Success").add_OnComplete(value:  new System.Action<IOSDialogResult>(object:  this, method:  System.Void MarketExample::OnVerifayComplete(IOSDialogResult res)));
            return;
        }
        
        IOSDialog.Create(title:  null, message:  "Failed").add_OnComplete(value:  new System.Action<IOSDialogResult>(object:  this, method:  System.Void MarketExample::OnComplete(IOSDialogResult res)));
    }
    private void OnVerifayComplete(IOSDialogResult res)
    {
        if(res != 0)
        {
                return;
        }
        
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.SendRequest());
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private System.Collections.IEnumerator SendRequest()
    {
        typeof(MarketExample.<SendRequest>c__Iterator0).__il2cppRuntimeField_38 = this;
        return (System.Collections.IEnumerator)new System.Object();
    }
    private void OnComplete(IOSDialogResult res)
    {
        IntPtr val_3;
        if(res != 0)
        {
                return;
        }
        
        val_3 = System.Void MarketExample::OnReceiptRefreshComplete(SA.Common.Models.Result res);
        System.Action<SA.Common.Models.Result> val_1 = new System.Action<SA.Common.Models.Result>(object:  this, method:  val_3);
        ISN_Security.add_OnReceiptRefreshComplete(value:  null);
        if((SA.Common.Pattern.Singleton<SA_EditorAd>.Instance) != null)
        {
                return;
        }
    
    }
    private void OnReceiptRefreshComplete(SA.Common.Models.Result res)
    {
        bool val_1 = res.IsSucceeded;
        if(val_1 == false)
        {
                return;
        }
        
        IOSDialog.Create(title:  val_1, message:  "Success").add_OnComplete(value:  new System.Action<IOSDialogResult>(object:  this, method:  System.Void MarketExample::Dialog_RetrieveLocalReceipt(IOSDialogResult res)));
    }
    private void Dialog_RetrieveLocalReceipt(IOSDialogResult res)
    {
        IntPtr val_3;
        if(res != 0)
        {
                return;
        }
        
        val_3 = System.Void MarketExample::OnReceiptLoaded(ISN_LocalReceiptResult result);
        System.Action<ISN_LocalReceiptResult> val_1 = new System.Action<ISN_LocalReceiptResult>(object:  this, method:  val_3);
        ISN_Security.add_OnReceiptLoaded(value:  null);
        if((SA.Common.Pattern.Singleton<SA_EditorAd>.Instance) != null)
        {
                return;
        }
    
    }

}

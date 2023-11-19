using UnityEngine;
[UnityEngine.AddComponentMenu]
public class IAPDemo : MonoBehaviour, IStoreListener
{
    // Fields
    private UnityEngine.Purchasing.IStoreController m_Controller;
    private UnityEngine.Purchasing.IAppleExtensions m_AppleExtensions;
    private UnityEngine.Purchasing.IMoolahExtension m_MoolahExtensions;
    private UnityEngine.Purchasing.ISamsungAppsExtensions m_SamsungExtensions;
    private UnityEngine.Purchasing.IMicrosoftExtensions m_MicrosoftExtensions;
    private UnityEngine.Purchasing.ITransactionHistoryExtensions m_TransactionHistoryExtensions;
    private UnityEngine.Purchasing.IGooglePlayStoreExtensions m_GooglePlayStoreExtensions;
    private bool m_IsGooglePlayStoreSelected;
    private bool m_IsSamsungAppsStoreSelected;
    private bool m_IsCloudMoolahStoreSelected;
    private bool m_PurchaseInProgress;
    private System.Collections.Generic.Dictionary<string, IAPDemoProductUI> m_ProductUIs;
    public UnityEngine.GameObject productUITemplate;
    public UnityEngine.RectTransform contentRect;
    public UnityEngine.UI.Button restoreButton;
    public UnityEngine.UI.Text versionText;
    
    // Methods
    public IAPDemo()
    {
        this.m_ProductUIs = new System.Collections.Generic.Dictionary<System.String, IAPDemoProductUI>();
    }
    public void OnInitialized(UnityEngine.Purchasing.IStoreController controller, UnityEngine.Purchasing.IExtensionProvider extensions)
    {
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        IntPtr val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        this.m_Controller = controller;
        var val_29 = 0;
        val_29 = val_29 + 1;
        val_29 = extensions;
        this.m_AppleExtensions = extensions;
        var val_30 = 0;
        val_30 = val_30 + 1;
        val_30 = extensions;
        this.m_SamsungExtensions = extensions;
        var val_31 = 0;
        val_31 = val_31 + 1;
        val_31 = extensions;
        this.m_MoolahExtensions = extensions;
        var val_32 = 0;
        val_32 = val_32 + 1;
        val_32 = extensions;
        this.m_MicrosoftExtensions = extensions;
        var val_33 = 0;
        val_33 = val_33 + 1;
        val_33 = extensions;
        this.m_TransactionHistoryExtensions = extensions;
        var val_34 = 0;
        val_34 = val_34 + 1;
        val_34 = extensions;
        this.m_GooglePlayStoreExtensions = extensions;
        var val_35 = 0;
        val_35 = val_35 + 1;
        val_35 = controller;
        UnityEngine.Purchasing.Product[] val_8 = controller.all;
        this.InitUI(items:  0);
        val_36 = System.Void IAPDemo::OnDeferred(UnityEngine.Purchasing.Product item);
        null = new System.Action<UnityEngine.Purchasing.Product>(object:  this, method:  val_36);
        var val_36 = 0;
        val_36 = val_36 + 1;
        val_36 = 1;
        val_37 = this.m_AppleExtensions;
        UnityEngine.Debug.Log(message:  0);
        var val_37 = 0;
        val_37 = val_37 + 1;
        val_38 = controller;
        val_39 = 0;
        goto label_50;
        label_98:
        val_39 = 1;
        label_50:
        if(val_39 >= val_12.Length)
        {
            goto label_52;
        }
        
        UnityEngine.Purchasing.Product val_38 = controller.all[1];
        if(val_38.availableToPurchase == false)
        {
            goto label_98;
        }
        
        typeof(System.String[]).__il2cppRuntimeField_20 = val_38.metadata.localizedTitle;
        typeof(System.String[]).__il2cppRuntimeField_28 = val_38.metadata.localizedDescription;
        typeof(System.String[]).__il2cppRuntimeField_30 = val_38.metadata.isoCurrencyCode;
        decimal val_21 = val_38.metadata.localizedPrice;
        typeof(System.String[]).__il2cppRuntimeField_38 = ;
        typeof(System.String[]).__il2cppRuntimeField_40 = val_38.metadata.localizedPriceString;
        typeof(System.String[]).__il2cppRuntimeField_48 = val_38.transactionID;
        typeof(System.String[]).__il2cppRuntimeField_50 = val_38.receipt;
        string val_26 = System.String.Join(separator:  0, value:  " - ");
        UnityEngine.Debug.Log(message:  0);
        goto label_98;
        label_52:
        var val_39 = 0;
        val_39 = val_39 + 1;
        val_40 = this.m_Controller;
        this.AddProductUIs(products:  this.m_Controller.all);
        this.LogProductDefinitions();
    }
    public UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e)
    {
        string val_3 = e.purchasedProduct.definition.id;
        string val_4 = 0 + "Purchase OK: "("Purchase OK: ");
        UnityEngine.Debug.Log(message:  0);
        string val_6 = e.purchasedProduct.receipt;
        string val_7 = 0 + "Receipt: "("Receipt: ");
        UnityEngine.Debug.Log(message:  0);
        this.m_PurchaseInProgress = false;
        this.UpdateProductUI(p:  e.purchasedProduct);
        return 0;
    }
    public void OnPurchaseFailed(UnityEngine.Purchasing.Product item, UnityEngine.Purchasing.PurchaseFailureReason r)
    {
        var val_10;
        var val_11;
        var val_12;
        string val_2 = item.definition.id;
        string val_3 = 0 + "Purchase failed: "("Purchase failed: ");
        UnityEngine.Debug.Log(message:  0);
        UnityEngine.Debug.Log(message:  0);
        var val_10 = 0;
        val_10 = val_10 + 1;
        val_10 = this.m_TransactionHistoryExtensions;
        string val_5 = 0 + "Store specific error code: "("Store specific error code: ");
        UnityEngine.Debug.Log(message:  0);
        var val_11 = 0;
        val_11 = val_11 + 1;
        val_11 = this.m_TransactionHistoryExtensions;
        if(this.m_TransactionHistoryExtensions != null)
        {
                var val_12 = 0;
            val_12 = val_12 + 1;
            val_12 = this.m_TransactionHistoryExtensions;
            string val_8 = this.m_TransactionHistoryExtensions.message;
            string val_9 = 0 + "Purchase failure description message: "("Purchase failure description message: ");
            UnityEngine.Debug.Log(message:  0);
        }
        
        this.m_PurchaseInProgress = false;
    }
    public void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error)
    {
        var val_1;
        object val_2;
        UnityEngine.Debug.Log(message:  0);
        if(error == 0)
        {
            goto label_3;
        }
        
        if(error == 1)
        {
            goto label_4;
        }
        
        if(error != 2)
        {
                return;
        }
        
        UnityEngine.Debug.LogError(message:  0);
        return;
        label_3:
        val_1 = "Billing disabled!";
        val_2 = 0;
        goto label_10;
        label_4:
        val_1 = "No products available for purchase!";
        val_2 = 0;
        label_10:
        UnityEngine.Debug.Log(message:  val_2);
    }
    public void Awake()
    {
        var val_20;
        UnityEngine.Purchasing.IDs val_21;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        var val_62;
        var val_63;
        bool val_64;
        var val_65;
        UnityEngine.Purchasing.IDs val_66;
        string val_67;
        var val_68;
        string val_69;
        var val_70;
        var val_71;
        var val_72;
        string val_73;
        var val_74;
        var val_75;
        var val_76;
        var val_77;
        UnityEngine.Purchasing.ProductType val_78;
        var val_79;
        var val_80;
        var val_81;
        var val_82;
        UnityEngine.Purchasing.StandardPurchasingModule val_1 = UnityEngine.Purchasing.StandardPurchasingModule.Instance();
        val_1.useFakeStoreUIMode = 1;
        val_55 = null;
        UnityEngine.Purchasing.ConfigurationBuilder val_2 = UnityEngine.Purchasing.ConfigurationBuilder.Instance(first:  0, rest:  val_1);
        var val_54 = 0;
        val_54 = val_54 + 1;
        val_55 = 0;
        val_56 = val_2.Configure<UnityEngine.Purchasing.IMicrosoftConfiguration>();
        val_58 = 0;
        this.m_IsGooglePlayStoreSelected = (val_1.appStore == 1) ? 1 : 0;
        var val_55 = 0;
        val_55 = val_55 + 1;
        val_57 = 0;
        val_59 = val_2.Configure<UnityEngine.Purchasing.IMoolahConfiguration>();
        var val_56 = 0;
        val_56 = val_56 + 1;
        val_60 = 1;
        val_61 = val_2.Configure<UnityEngine.Purchasing.IMoolahConfiguration>();
        var val_57 = 0;
        val_57 = val_57 + 1;
        val_62 = 2;
        val_63 = val_2.Configure<UnityEngine.Purchasing.IMoolahConfiguration>();
        if(UnityEngine.Application.platform == 11)
        {
                var val_16 = (val_1.appStore == 3) ? 1 : 0;
        }
        else
        {
                val_64 = false;
        }
        
        this.m_IsCloudMoolahStoreSelected = val_64;
        System.Collections.Generic.ICollection<UnityEngine.Purchasing.ProductCatalogItem> val_18 = UnityEngine.Purchasing.ProductCatalog.LoadDefaultCatalog().allValidProducts;
        var val_58 = 0;
        val_58 = val_58 + 1;
        val_65 = val_18;
        val_66 = 1152921504775856128;
        val_67 = 0;
        goto label_54;
        label_55:
        if(X26 == 0)
        {
            goto label_42;
        }
        
        var val_61 = X26;
        if((X26 + 258) == 0)
        {
            goto label_43;
        }
        
        var val_59 = X26 + 152;
        var val_60 = 0;
        val_59 = val_59 + 8;
        label_45:
        if(((X26 + 152 + 8) + -8) == null)
        {
            goto label_44;
        }
        
        val_60 = val_60 + 1;
        val_59 = val_59 + 16;
        if(val_60 < (X26 + 258))
        {
            goto label_45;
        }
        
        label_43:
        val_68 = X26;
        goto label_46;
        label_44:
        val_61 = val_61 + (((X26 + 152 + 8)) << 4);
        val_68 = val_61 + 272;
        label_46:
        label_42:
        if( == 287)
        {
                val_67 = 0;
        }
        else
        {
                if(null != 0)
        {
            
        }
        
        }
        
        if((public UnityEngine.Purchasing.IMoolahConfiguration UnityEngine.Purchasing.ConfigurationBuilder::Configure<UnityEngine.Purchasing.IMoolahConfiguration>()) != 0)
        {
                val_69 = public UnityEngine.Purchasing.ITizenStoreConfiguration UnityEngine.Purchasing.ConfigurationBuilder::Configure<UnityEngine.Purchasing.ITizenStoreConfiguration>();
        }
        else
        {
                val_69 = 11993091;
        }
        
        UnityEngine.Purchasing.ConfigurationBuilder val_22 = val_2.AddProduct(id:  val_69, type:  public System.Void IAPDemo::RestoreButtonClick(), storeIDs:  val_21);
        label_54:
        label_77:
        var val_62 = 0;
        val_62 = val_62 + 1;
        val_70 = val_18;
        if(((val_18 & 1) & 1) == 0)
        {
            goto label_177;
        }
        
        var val_63 = 0;
        val_63 = val_63 + 1;
        val_71 = val_18;
        System.Collections.Generic.ICollection<UnityEngine.Purchasing.StoreID> val_26 = val_18.allStoreIDs;
        var val_64 = 0;
        val_64 = val_64 + 1;
        val_72 = val_26;
        if(val_26 >= 1)
        {
            goto label_73;
        }
        
        if(val_18 != null)
        {
            
        }
        else
        {
                val_73 = 11993091;
        }
        
        UnityEngine.Purchasing.ConfigurationBuilder val_28 = val_2.AddProduct(id:  val_73, type:  val_18);
        goto label_77;
        label_73:
        val_21 = val_66;
        val_21 = new UnityEngine.Purchasing.IDs();
        System.Collections.Generic.ICollection<UnityEngine.Purchasing.StoreID> val_30 = val_18.allStoreIDs;
        var val_65 = 0;
        val_65 = val_65 + 1;
        val_74 = val_30;
        val_20 = val_67;
        label_101:
        var val_66 = 0;
        val_66 = val_66 + 1;
        val_75 = val_30;
        if(((val_30 & 1) & 1) == 0)
        {
            goto label_55;
        }
        
        var val_67 = 0;
        val_67 = val_67 + 1;
        val_76 = val_30;
        typeof(System.String[]).__il2cppRuntimeField_20 = val_30;
        Add(id:  val_67, stores:  null);
        goto label_101;
        label_177:
        if(val_18 != null)
        {
                var val_68 = 0;
            val_68 = val_68 + 1;
            val_77 = val_18;
        }
        
        typeof(System.String[]).__il2cppRuntimeField_20 = "MacAppStore";
        Add(id:  "com.unity3d.unityiap.unityiapdemo.100goldcoins.7", stores:  null);
        typeof(System.String[]).__il2cppRuntimeField_20 = "TizenStore";
        Add(id:  "000000596586", stores:  null);
        typeof(System.String[]).__il2cppRuntimeField_20 = "MoolahAppStore";
        Add(id:  "com.ff", stores:  null);
        typeof(System.String[]).__il2cppRuntimeField_20 = "AmazonApps";
        Add(id:  "100.gold.coins", stores:  null);
        typeof(System.String[]).__il2cppRuntimeField_20 = "AppleAppStore";
        Add(id:  "100.gold.coins", stores:  null);
        UnityEngine.Purchasing.ConfigurationBuilder val_37 = val_2.AddProduct(id:  "100.gold.coins", type:  0, storeIDs:  new UnityEngine.Purchasing.IDs());
        typeof(System.String[]).__il2cppRuntimeField_20 = "MacAppStore";
        Add(id:  "com.unity3d.unityiap.unityiapdemo.500goldcoins.7", stores:  null);
        typeof(System.String[]).__il2cppRuntimeField_20 = "TizenStore";
        Add(id:  "000000596581", stores:  null);
        typeof(System.String[]).__il2cppRuntimeField_20 = "MoolahAppStore";
        Add(id:  "com.ee", stores:  null);
        typeof(System.String[]).__il2cppRuntimeField_20 = "AmazonApps";
        Add(id:  "500.gold.coins", stores:  null);
        UnityEngine.Purchasing.ConfigurationBuilder val_39 = val_2.AddProduct(id:  "500.gold.coins", type:  0, storeIDs:  new UnityEngine.Purchasing.IDs());
        UnityEngine.Purchasing.ConfigurationBuilder val_41 = val_2.AddProduct(id:  "300.gold.coins", type:  0, storeIDs:  new UnityEngine.Purchasing.IDs());
        UnityEngine.Purchasing.ConfigurationBuilder val_43 = val_2.AddProduct(id:  "sub1", type:  2, storeIDs:  new UnityEngine.Purchasing.IDs());
        UnityEngine.Purchasing.IDs val_44 = new UnityEngine.Purchasing.IDs();
        if(val_2 != null)
        {
                val_78 = 2;
            UnityEngine.Purchasing.ConfigurationBuilder val_45 = val_2.AddProduct(id:  "sub2", type:  val_78, storeIDs:  val_44);
        }
        else
        {
                val_78 = 2;
            UnityEngine.Purchasing.ConfigurationBuilder val_46 = 0.AddProduct(id:  "sub2", type:  val_78, storeIDs:  val_44);
        }
        
        var val_69 = 0;
        val_69 = val_69 + 1;
        val_78 = 0;
        val_79 = val_2.Configure<UnityEngine.Purchasing.ISamsungAppsConfiguration>();
        if(UnityEngine.Application.platform == 11)
        {
                var val_51 = (val_1.appStore == 4) ? 1 : 0;
        }
        else
        {
                val_81 = 0;
        }
        
        mem[1152921510524256241] = val_81;
        var val_70 = 0;
        val_70 = val_70 + 1;
        val_80 = 0;
        val_82 = val_2.Configure<UnityEngine.Purchasing.ITizenStoreConfiguration>();
        UnityEngine.Purchasing.UnityPurchasing.Initialize(listener:  0, builder:  this);
    }
    private void OnTransactionsRestored(bool success)
    {
        bool val_1 = success;
        string val_2 = 0 + "Transactions restored.";
        UnityEngine.Debug.Log(message:  0);
    }
    private void OnDeferred(UnityEngine.Purchasing.Product item)
    {
        string val_2 = item.definition.id;
        string val_3 = 0 + "Purchase deferred: "("Purchase deferred: ");
        UnityEngine.Debug.Log(message:  0);
    }
    private void InitUI(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Product> items)
    {
        this.restoreButton.gameObject.SetActive(value:  true);
        this.ClearProductUIs();
        this.restoreButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void IAPDemo::RestoreButtonClick()));
        string val_5 = 0 + "Unity version: "("Unity version: ") + UnityEngine.Application.unityVersion;
        if(this.versionText == null)
        {
            
        }
    
    }
    public void PurchaseButtonClick(string productID)
    {
        string val_7;
        var val_8;
        object val_9;
        var val_10;
        var val_11;
        val_7 = productID;
        if(this.m_PurchaseInProgress != false)
        {
                UnityEngine.Debug.Log(message:  0);
            return;
        }
        
        if(this.m_Controller == null)
        {
            goto label_4;
        }
        
        var val_7 = 0;
        val_7 = val_7 + 1;
        val_8 = this.m_Controller;
        goto label_8;
        label_4:
        val_9 = 0;
        goto label_11;
        label_8:
        if((this.m_Controller.WithID(id:  val_7)) == null)
        {
            goto label_13;
        }
        
        this.m_PurchaseInProgress = true;
        var val_8 = 0;
        val_8 = val_8 + 1;
        val_10 = this.m_Controller;
        goto label_18;
        label_13:
        val_7 = 0 + "No product has id ";
        val_9 = 0;
        label_11:
        UnityEngine.Debug.LogError(message:  val_9);
        return;
        label_18:
        UnityEngine.Purchasing.Product val_5 = this.m_Controller.WithID(id:  val_7);
        var val_9 = 0;
        val_9 = val_9 + 1;
        val_11 = this.m_Controller;
    }
    public void RestoreButtonClick()
    {
        object val_10;
        UnityEngine.Purchasing.IMoolahExtension val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        val_10 = this;
        if(this.m_IsCloudMoolahStoreSelected == false)
        {
            goto label_1;
        }
        
        val_11 = this.m_MoolahExtensions;
        System.Action<UnityEngine.Purchasing.RestoreTransactionIDState> val_1 = null;
        val_12 = val_1;
        val_1 = new System.Action<UnityEngine.Purchasing.RestoreTransactionIDState>(object:  this, method:  System.Void IAPDemo::<RestoreButtonClick>m__0(UnityEngine.Purchasing.RestoreTransactionIDState restoreTransactionIDState));
        var val_10 = 0;
        val_14 = 1152921504792932360;
        val_10 = val_10 + 1;
        goto label_31;
        label_1:
        if(this.m_IsSamsungAppsStoreSelected == false)
        {
            goto label_7;
        }
        
        val_11 = this.m_SamsungExtensions;
        System.Action<System.Boolean> val_2 = null;
        val_12 = val_2;
        val_2 = new System.Action<System.Boolean>(object:  this, method:  System.Void IAPDemo::OnTransactionsRestored(bool success));
        var val_11 = 0;
        val_14 = 1152921504793944072;
        val_11 = val_11 + 1;
        label_31:
        val_15 = val_11;
        goto mem[.ctor(object:  this, method:  System.Void IAPDemo::<RestoreButtonClick>m__0(UnityEngine.Purchasing.RestoreTransactionIDState restoreTransactionIDState))];
        label_7:
        if(UnityEngine.Application.platform != 18)
        {
                if(UnityEngine.Application.platform != 19)
        {
                if(UnityEngine.Application.platform != 20)
        {
            goto label_15;
        }
        
        }
        
        }
        
        var val_12 = 0;
        val_12 = val_12 + 1;
        val_16 = this.m_MicrosoftExtensions;
        val_10 = ???;
        label_15:
        if((val_10 + 80) == 0)
        {
            goto label_21;
        }
        
        val_11 = mem[val_10 + 72];
        val_11 = val_10 + 72;
        System.Action<System.Boolean> val_7 = null;
        val_12 = val_7;
        val_7 = new System.Action<System.Boolean>(object:  val_10, method:  System.Void IAPDemo::OnTransactionsRestored(bool success));
        val_13 = mem[val_10 + 72];
        val_13 = val_11;
        if((val_10 + 72 + 258) == 0)
        {
            goto label_31;
        }
        
        var val_13 = 0;
        val_14 = (val_10 + 72 + 152) + 8;
        label_25:
        if(((val_10 + 72 + 152 + 8) + -8) == null)
        {
            goto mem[.ctor(object:  this, method:  System.Void IAPDemo::<RestoreButtonClick>m__0(UnityEngine.Purchasing.RestoreTransactionIDState restoreTransactionIDState))];
        }
        
        val_13 = val_13 + 1;
        val_14 = val_14 + 16;
        if(val_13 < (val_10 + 72 + 258))
        {
            goto label_25;
        }
        
        goto label_31;
        label_21:
        val_11 = mem[val_10 + 32];
        val_11 = val_10 + 32;
        System.Action<System.Boolean> val_8 = null;
        val_12 = val_8;
        val_8 = new System.Action<System.Boolean>(object:  val_10, method:  System.Void IAPDemo::OnTransactionsRestored(bool success));
        val_13 = mem[val_10 + 32];
        val_13 = val_11;
        if((val_10 + 32 + 258) == 0)
        {
            goto label_31;
        }
        
        var val_14 = 0;
        val_14 = (val_10 + 32 + 152) + 8;
        label_30:
        if(((val_10 + 32 + 152 + 8) + -8) == null)
        {
            goto mem[.ctor(object:  this, method:  System.Void IAPDemo::<RestoreButtonClick>m__0(UnityEngine.Purchasing.RestoreTransactionIDState restoreTransactionIDState))];
        }
        
        val_14 = val_14 + 1;
        val_14 = val_14 + 16;
        if(val_14 < (val_10 + 32 + 258))
        {
            goto label_30;
        }
        
        goto label_31;
    }
    private void ClearProductUIs()
    {
        var val_4;
        var val_5;
        Dictionary.Enumerator<TKey, TValue> val_1 = this.m_ProductUIs.GetEnumerator();
        label_6:
        if((0 & 1) == 0)
        {
            goto label_2;
        }
        
        UnityEngine.Playables.PlayableHandle val_2 = 0.GetHandle();
        UnityEngine.GameObject val_3 = val_2.m_Handle.gameObject;
        UnityEngine.Object.Destroy(obj:  0);
        goto label_6;
        label_2:
        val_4 = 0;
        val_5 = 1;
        0.Dispose();
        this.m_ProductUIs.Clear();
    }
    private void AddProductUIs(UnityEngine.Purchasing.Product[] products)
    {
        var val_17;
        this.ClearProductUIs();
        UnityEngine.RectTransform val_1 = this.productUITemplate.GetComponent<UnityEngine.RectTransform>();
        UnityEngine.Rect val_2 = val_1.rect;
        UnityEngine.Vector3 val_3 = val_1.localPosition;
        float val_17 = (float)products.Length;
        val_17 = val_2.m_XMin * val_17;
        this.contentRect.SetSizeWithCurrentAnchors(axis:  1, size:  val_17);
        val_17 = 0;
        goto label_6;
        label_27:
        X23.set_Item(key:  this.contentRect, value:  X22);
        val_17 = 1;
        label_6:
        if(val_17 >= products.Length)
        {
                return;
        }
        
        UnityEngine.Purchasing.Product val_18 = products[1];
        UnityEngine.GameObject val_4 = this.productUITemplate.gameObject;
        Unitycoding.UIWidgets.RadialMenuItem val_5 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0);
        val_5.transform.SetParent(parent:  this.productUITemplate.transform.parent, worldPositionStays:  false);
        val_5.GetComponent<UnityEngine.RectTransform>().localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  val_2.m_XMin);
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        if(val_5 != null)
        {
                val_5.SetActive(value:  true);
        }
        else
        {
                val_5.SetActive(value:  true);
        }
        
        val_5.GetComponent<IAPDemoProductUI>().SetProduct(p:  val_18, purchaseCallback:  new System.Action<System.String>(object:  this, method:  public System.Void IAPDemo::PurchaseButtonClick(string productID)));
        string val_16 = val_18.definition.id;
        if(this.m_ProductUIs != null)
        {
            goto label_27;
        }
        
        goto label_27;
    }
    private void UpdateProductUI(UnityEngine.Purchasing.Product p)
    {
        if((this.m_ProductUIs.ContainsKey(key:  p.definition.id)) == false)
        {
                return;
        }
        
        this.m_ProductUIs.Item[p.definition.id].SetProduct(p:  p, purchaseCallback:  new System.Action<System.String>(object:  this, method:  public System.Void IAPDemo::PurchaseButtonClick(string productID)));
    }
    private void UpdateProductPendingUI(UnityEngine.Purchasing.Product p, int secondsRemaining)
    {
        if((this.m_ProductUIs.ContainsKey(key:  p.definition.id)) == false)
        {
                return;
        }
        
        this.m_ProductUIs.Item[p.definition.id].SetPendingTime(secondsRemaining:  secondsRemaining);
    }
    private bool NeedRestoreButton()
    {
        if(UnityEngine.Application.platform == 8)
        {
                return true;
        }
        
        if(UnityEngine.Application.platform == 1)
        {
                return true;
        }
        
        if(UnityEngine.Application.platform == 31)
        {
                return true;
        }
        
        if(UnityEngine.Application.platform == 18)
        {
                return true;
        }
        
        if(UnityEngine.Application.platform == 19)
        {
                return true;
        }
        
        if(UnityEngine.Application.platform == 20)
        {
                return true;
        }
        
        if(this.m_IsSamsungAppsStoreSelected != false)
        {
                return true;
        }
        
        var val_7 = (this.m_IsCloudMoolahStoreSelected == true) ? 1 : 0;
        return true;
    }
    private void LogProductDefinitions()
    {
        var val_15;
        var val_16;
        var val_15 = 0;
        val_15 = val_15 + 1;
        val_15 = this.m_Controller;
        val_16 = 0;
        goto label_7;
        label_41:
        UnityEngine.Debug.Log(message:  0);
        val_16 = 1;
        label_7:
        if(val_16 >= val_2.Length)
        {
                return;
        }
        
        UnityEngine.Purchasing.Product val_16 = this.m_Controller.all[1];
        typeof(System.Object[]).__il2cppRuntimeField_20 = val_16.definition.id;
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_16.definition.storeSpecificId;
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        typeof(System.Object[]).__il2cppRuntimeField_30 = val_16.definition.type.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_38 = (val_16.definition.enabled != true) ? "enabled" : "disabled";
        string val_14 = System.String.Format(format:  0, args:  "id: {0}\nstore-specific id: {1}\ntype: {2}\nenabled: {3}\n");
        goto label_41;
    }
    private void <RestoreButtonClick>m__0(UnityEngine.Purchasing.RestoreTransactionIDState restoreTransactionIDState)
    {
        string val_1 = restoreTransactionIDState.ToString();
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        string val_3 = 0 + "restoreTransactionIDState = "("restoreTransactionIDState = ");
        UnityEngine.Debug.Log(message:  0);
        this.OnTransactionsRestored(success:  (185942016 != 2) ? 1 : 0);
    }

}

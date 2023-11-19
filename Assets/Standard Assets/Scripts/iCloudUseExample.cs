using UnityEngine;
public class iCloudUseExample : BaseIOSFeaturePreview
{
    // Fields
    private float v;
    private static System.Action<iCloudData> <>f__am$cache0;
    
    // Methods
    public iCloudUseExample()
    {
        this.v = 1.1f;
    }
    private void Awake()
    {
        System.Action<SA.Common.Models.Result> val_1 = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void iCloudUseExample::OnCloundInitAction(SA.Common.Models.Result result));
        iCloudManager.add_OnCloudInitAction(value:  null);
        iCloudManager.add_OnCloudDataReceivedAction(value:  new System.Action<iCloudData>(object:  this, method:  System.Void iCloudUseExample::OnCloudDataReceivedAction(iCloudData data)) = new System.Action<iCloudData>(object:  this, method:  System.Void iCloudUseExample::OnCloudDataReceivedAction(iCloudData data)));
        iCloudManager.add_OnStoreDidChangeExternally(value:  new System.Action<System.Collections.Generic.List<iCloudData>>(object:  this, method:  System.Void iCloudUseExample::HandleOnStoreDidChangeExternally(System.Collections.Generic.List<iCloudData> changedData)) = new System.Action<System.Collections.Generic.List<iCloudData>>(object:  this, method:  System.Void iCloudUseExample::HandleOnStoreDidChangeExternally(System.Collections.Generic.List<iCloudData> changedData)));
    }
    private void HandleOnStoreDidChangeExternally(System.Collections.Generic.List<iCloudData> changedData)
    {
        var val_4;
        var val_5;
        List.Enumerator<T> val_1 = changedData.GetEnumerator();
        label_6:
        if((0 & 1) == 0)
        {
            goto label_2;
        }
        
        ISN_Logger.Log(message:  0, logType:  0 + "Cloud data with key:  "("Cloud data with key:  ") + 0.InitializationCallback);
        goto label_6;
        label_2:
        val_4 = 0;
        val_5 = 1;
        0.Dispose();
        if((val_5 & 1) != 0)
        {
                return;
        }
        
        if(val_4 == 0)
        {
                return;
        }
    
    }
    private void OnGUI()
    {
        var val_17;
        System.Action<iCloudData> val_18;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                SA_EditorAd val_2 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
        }
        
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                SA_EditorAd val_4 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
        }
        
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                float val_17 = this.v;
            val_17 = val_17 + 1.1f;
            this.v = val_17;
            SA_EditorAd val_6 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
        }
        
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                val_17 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
            val_18 = iCloudUseExample.<>f__am$cache0;
            if(val_18 == null)
        {
                iCloudUseExample.<>f__am$cache0 = new System.Action<iCloudData>(object:  0, method:  static System.Void iCloudUseExample::<OnGUI>m__0(iCloudData obj));
            val_18 = iCloudUseExample.<>f__am$cache0;
        }
        
            val_17.RequestDataForKey(key:  "TestFloatKey", callback:  val_18);
        }
        
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                System.Text.UTF8Encoding val_11 = null;
            val_17 = val_11;
            val_11 = new System.Text.UTF8Encoding();
            System.Byte[] val_12 = GetBytes(s:  "hello world");
            SA_EditorAd val_13 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
        }
        
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                SA_EditorAd val_15 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
        }
        
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) == false)
        {
                return;
        }
        
        this.LoadLevel(levelName:  "Peer-To-PeerGameExample");
    }
    private void OnCloundInitAction(SA.Common.Models.Result result)
    {
        var val_2;
        string val_3;
        if(result.IsSucceeded != false)
        {
                val_2 = "Initialization Success!";
            val_3 = 0;
        }
        else
        {
                val_2 = "Initialization Failed!";
            val_3 = 0;
        }
        
        IOSNativePopUpManager.showMessage(title:  val_3, message:  "iCloud");
    }
    private void OnCloudDataReceivedAction(iCloudData data)
    {
        string val_1;
        string val_2;
        if(data == null)
        {
            goto label_1;
        }
        
        val_1 = data.m_key;
        if(data.m_IsEmpty == true)
        {
            goto label_2;
        }
        
        goto label_6;
        label_1:
        val_1 = 11993091;
        if(64 == 0)
        {
            goto label_4;
        }
        
        label_2:
        val_2 = 0;
        goto label_5;
        label_4:
        if(64 == 0)
        {
            goto label_6;
        }
        
        goto label_7;
        label_6:
        label_7:
        val_2 = 0;
        label_5:
        IOSNativePopUpManager.showMessage(title:  val_2, message:  val_1);
    }
    private void OnDestroy()
    {
        System.Action<SA.Common.Models.Result> val_1 = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void iCloudUseExample::OnCloundInitAction(SA.Common.Models.Result result));
        iCloudManager.remove_OnCloudInitAction(value:  null);
        iCloudManager.remove_OnCloudDataReceivedAction(value:  new System.Action<iCloudData>(object:  this, method:  System.Void iCloudUseExample::OnCloudDataReceivedAction(iCloudData data)) = new System.Action<iCloudData>(object:  this, method:  System.Void iCloudUseExample::OnCloudDataReceivedAction(iCloudData data)));
    }
    private static void <OnGUI>m__0(iCloudData obj)
    {
        float val_1 = X1.FloatValue;
        UnityEngine.Debug.Log(message:  0);
    }

}

using UnityEngine;
public class TvOsCloudExample : MonoBehaviour
{
    // Fields
    private static System.Action<iCloudData> <>f__am$cache0;
    
    // Methods
    public TvOsCloudExample()
    {
    
    }
    private void Start()
    {
        System.Action<iCloudData> val_5;
        UnityEngine.Debug.Log(message:  0);
        System.Action<iCloudData> val_1 = new System.Action<iCloudData>(object:  this, method:  System.Void TvOsCloudExample::OnCloudDataReceivedAction(iCloudData data));
        iCloudManager.add_OnCloudDataReceivedAction(value:  0);
        SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.SetString(key:  "Test", val:  "test");
        val_5 = TvOsCloudExample.<>f__am$cache0;
        if(val_5 == null)
        {
                TvOsCloudExample.<>f__am$cache0 = new System.Action<iCloudData>(object:  0, method:  static System.Void TvOsCloudExample::<Start>m__0(iCloudData data));
            val_5 = TvOsCloudExample.<>f__am$cache0;
        }
        
        SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.RequestDataForKey(key:  "Test", callback:  val_5);
    }
    private void OnCloudDataReceivedAction(iCloudData data)
    {
        var val_9;
        string val_10;
        UnityEngine.Debug.Log(message:  0);
        if(data == null)
        {
            goto label_3;
        }
        
        val_9 = data.IsEmpty;
        val_10 = data.Key;
        if(val_9 == true)
        {
            goto label_4;
        }
        
        goto label_5;
        label_3:
        val_9 = 0.IsEmpty;
        val_10 = 0.Key;
        if(val_9 == false)
        {
            goto label_6;
        }
        
        label_4:
        string val_5 = 0 + val_10;
        goto label_9;
        label_6:
        label_5:
        string val_6 = data.StringValue;
        string val_7 = 0 + val_10 + " / "(" / ");
        label_9:
        UnityEngine.Debug.Log(message:  0);
    }
    private static void <Start>m__0(iCloudData data)
    {
        var val_9;
        string val_10;
        UnityEngine.Debug.Log(message:  0);
        if(X1 == 0)
        {
            goto label_3;
        }
        
        val_9 = X1.IsEmpty;
        val_10 = X1.Key;
        if(val_9 == true)
        {
            goto label_4;
        }
        
        goto label_5;
        label_3:
        val_9 = 0.IsEmpty;
        val_10 = 0.Key;
        if(val_9 == false)
        {
            goto label_6;
        }
        
        label_4:
        string val_5 = 0 + val_10;
        goto label_9;
        label_6:
        label_5:
        string val_6 = X1.StringValue;
        string val_7 = 0 + val_10 + " / "(" / ");
        label_9:
        UnityEngine.Debug.Log(message:  0);
    }

}

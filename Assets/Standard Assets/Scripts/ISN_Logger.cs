using UnityEngine;
public class ISN_Logger : Singleton<ISN_Logger>
{
    // Methods
    public ISN_Logger()
    {
    
    }
    private void Awake()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  0);
    }
    public void Create()
    {
    
    }
    public static void Log(object message, UnityEngine.LogType logType = 3)
    {
        var val_4;
        SA_EditorAd val_1 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
        if(logType == 0)
        {
                return;
        }
        
        val_4 = IOSNativeSettings.Instance;
        if(val_2.DisablePluginLogs == true)
        {
                return;
        }
        
        bool val_3 = UnityEngine.Application.isEditor;
        if(val_3 == false)
        {
                return;
        }
        
        ISN_Logger.ISNEditorLog(logType:  val_3, message:  W2);
    }
    private static void ISNEditorLog(UnityEngine.LogType logType, object message)
    {
        if(message > 4)
        {
            goto label_1;
        }
        
        if((25816096 + (message) << 2) == 6)
        {
            goto label_2;
        }
        
        if((25816096 + (message) << 2) == 5)
        {
            goto label_3;
        }
        
        if((25816096 + (message) << 2) == 3)
        {
            goto label_4;
        }
        
        label_1:
        UnityEngine.Debug.Log(message:  0);
        return;
        label_2:
        X2 = 0;
        UnityEngine.Debug.LogException(exception:  0);
        return;
        label_3:
        UnityEngine.Debug.LogWarning(message:  0);
        return;
        label_4:
        UnityEngine.Debug.LogError(message:  0);
    }

}

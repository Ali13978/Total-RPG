using UnityEngine;
public class GooglePlayObbDownloadManager
{
    // Fields
    private static UnityEngine.AndroidJavaClass m_AndroidOSBuildClass;
    private static IGooglePlayObbDownloader m_Instance;
    
    // Methods
    public GooglePlayObbDownloadManager()
    {
    
    }
    public static IGooglePlayObbDownloader GetGooglePlayObbDownloader()
    {
        IGooglePlayObbDownloader val_6;
        var val_7;
        IGooglePlayObbDownloader val_9;
        var val_10;
        val_7 = null;
        val_7 = null;
        val_9 = GooglePlayObbDownloadManager.m_Instance;
        if(val_9 == null)
        {
            goto label_3;
        }
        
        goto label_6;
        label_3:
        if(GooglePlayObbDownloadManager.IsDownloaderAvailable() == false)
        {
            goto label_9;
        }
        
        object val_5 = null;
        val_6 = val_5;
        val_5 = new System.Object();
        val_10 = null;
        val_10 = null;
        GooglePlayObbDownloadManager.m_Instance = val_6;
        label_6:
        val_9 = GooglePlayObbDownloadManager.m_Instance;
        return (IGooglePlayObbDownloader)val_9;
        label_9:
        val_9 = 0;
        return (IGooglePlayObbDownloader)val_9;
    }
    public static bool IsDownloaderAvailable()
    {
        null = null;
        return System.IntPtr.op_Inequality(value1:  0, value2:  GooglePlayObbDownloadManager.m_AndroidOSBuildClass.GetRawClass());
    }
    private static GooglePlayObbDownloadManager()
    {
        GooglePlayObbDownloadManager.m_AndroidOSBuildClass = new UnityEngine.AndroidJavaClass(className:  "android.os.Build");
    }

}

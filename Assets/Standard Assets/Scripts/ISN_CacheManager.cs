using UnityEngine;
public class ISN_CacheManager : MonoBehaviour
{
    // Fields
    private const string DATA_SPLITTER = "|";
    private const string ACHIEVEMENT_SPLITTER = "&";
    private const string GA_DATA_CACHE_KEY = "ISN_Cache";
    
    // Properties
    public static string SavedData { get; set; }
    
    // Methods
    public ISN_CacheManager()
    {
    
    }
    public static void SaveAchievementRequest(string achievementId, float percent)
    {
        string val_6;
        string val_7;
        val_6 = X1;
        IOSNativeSettings val_1 = IOSNativeSettings.Instance;
        if(val_1.UseGCRequestCaching == false)
        {
                return;
        }
        
        string val_2 = ISN_CacheManager.SavedData;
        val_6 = 0 + val_6 + "&"("&");
        val_7 = 0;
        if((System.String.op_Inequality(a:  val_7, b:  val_2)) != false)
        {
                string val_5 = 0 + val_2 + "|"("|");
            val_6 = val_5;
        }
        
        ISN_CacheManager.SavedData = val_5;
    }
    public static void SendAchievementCachedRequest()
    {
        string val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        val_8 = ISN_CacheManager.SavedData;
        val_9 = null;
        val_9 = null;
        if((System.String.op_Inequality(a:  0, b:  val_8)) == false)
        {
            goto label_10;
        }
        
        val_10 = "|";
        if(("|") == null)
        {
                val_10 = "|";
        }
        
        typeof(System.Char[]).__il2cppRuntimeField_20 = Chars[0];
        val_8 = val_8.Split(separator:  null);
        val_11 = 0;
        goto label_8;
        label_23:
        GameCenterManager.SubmitAchievementNoCache(percent:  V8.16B, achievementId:  0);
        val_11 = 1;
        label_8:
        if(val_11 >= val_4.Length)
        {
            goto label_10;
        }
        
        val_12 = "&";
        if(("&") == null)
        {
                val_12 = "&";
        }
        
        typeof(System.Char[]).__il2cppRuntimeField_20 = Chars[0];
        System.String[] val_6 = val_8[1].Split(separator:  null);
        string val_9 = val_6[1];
        float val_7 = System.Convert.ToSingle(value:  0);
        string val_10 = val_6[0];
        goto label_23;
        label_10:
        ISN_CacheManager.Clear();
    }
    public static void Clear()
    {
        UnityEngine.PlayerPrefs.DeleteKey(key:  0);
    }
    public static string get_SavedData()
    {
        var val_2;
        if((UnityEngine.PlayerPrefs.HasKey(key:  0)) != false)
        {
                return UnityEngine.PlayerPrefs.GetString(key:  0);
        }
        
        val_2 = null;
        val_2 = null;
        return (string)System.String.Empty;
    }
    public static void set_SavedData(string value)
    {
        UnityEngine.PlayerPrefs.SetString(key:  0, value:  "ISN_Cache");
    }

}

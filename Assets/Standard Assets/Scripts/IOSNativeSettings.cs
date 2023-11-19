using UnityEngine;
public class IOSNativeSettings : ScriptableObject
{
    // Fields
    public const string VERSION_NUMBER = "9.11/24";
    public bool EnableGameCenterAPI;
    public bool EnableInAppsAPI;
    public bool EnableCameraAPI;
    public bool EnableSocialSharingAPI;
    public bool EnablePickerAPI;
    public bool EnableMediaPlayerAPI;
    public bool EnableReplayKit;
    public bool EnableCloudKit;
    public bool EnableSoomla;
    public bool EnableGestureAPI;
    public bool EnableForceTouchAPI;
    public bool EnablePushNotificationsAPI;
    public bool EnableContactsAPI;
    public bool EnableAppEventsAPI;
    public bool EnableUserNotificationsAPI;
    public bool EnablePermissionAPI;
    public string AppleId;
    public int ToolbarIndex;
    public bool ExpandMoreActionsMenu;
    public bool ExpandModulesSettings;
    public bool InAppsEditorTesting;
    public bool CheckInternetBeforeLoadRequest;
    public bool PromotedPurchaseSupport;
    public SA.IOSNative.StoreKit.TransactionsHandlingMode TransactionsHandlingMode;
    public System.Collections.Generic.List<string> DefaultStoreProductsView;
    public System.Collections.Generic.List<SA.IOSNative.StoreKit.Product> InAppProducts;
    public bool ShowStoreKitProducts;
    public System.Collections.Generic.List<GK_Leaderboard> Leaderboards;
    public System.Collections.Generic.List<GK_AchievementTemplate> Achievements;
    public bool UseGCRequestCaching;
    public bool UsePPForAchievements;
    public bool AutoLoadUsersSmallImages;
    public bool AutoLoadUsersBigImages;
    public bool ShowLeaderboards;
    public bool ShowAchievementsParams;
    public bool AdEditorTesting;
    public int EditorFillRateIndex;
    public int EditorFillRate;
    public int MaxImageLoadSize;
    public float JPegCompressionRate;
    public IOSGalleryLoadImageFormat GalleryImageFormat;
    public int RPK_iPadViewType;
    public string CameraUsageDescription;
    public string PhotoLibraryUsageDescription;
    public string AppleMusicUsageDescription;
    public string ContactsUsageDescription;
    public System.Collections.Generic.List<SA.IOSNative.Models.UrlType> UrlTypes;
    public System.Collections.Generic.List<SA.IOSNative.Models.UrlType> ApplicationQueriesSchemes;
    public System.Collections.Generic.List<SA.IOSNative.Gestures.ForceTouchMenuItem> ForceTouchMenu;
    public bool DisablePluginLogs;
    public string SoomlaDownloadLink;
    public string SoomlaDocsLink;
    public string SoomlaGameKey;
    public string SoomlaEnvKey;
    public bool OneSignalEnabled;
    public string OneSignalDocsLink;
    private const string ISNSettingsAssetName = "IOSNativeSettings";
    private const string ISNSettingsAssetExtension = ".asset";
    private static IOSNativeSettings instance;
    
    // Properties
    public static IOSNativeSettings Instance { get; }
    
    // Methods
    public IOSNativeSettings()
    {
        var val_8;
        this.EnableGameCenterAPI = true;
        this.EnableInAppsAPI = true;
        this.EnableCameraAPI = true;
        this.EnableSocialSharingAPI = true;
        this.ExpandMoreActionsMenu = true;
        this.ExpandModulesSettings = true;
        this.AppleId = "XXXXXXXXX";
        this.InAppsEditorTesting = true;
        this.PromotedPurchaseSupport = true;
        this.DefaultStoreProductsView = new System.Collections.Generic.List<System.String>();
        this.ShowStoreKitProducts = true;
        this.InAppProducts = new System.Collections.Generic.List<SA.IOSNative.StoreKit.Product>();
        this.Leaderboards = new System.Collections.Generic.List<GK_Leaderboard>();
        this.EditorFillRateIndex = 4;
        this.EditorFillRate = 100;
        this.Achievements = new System.Collections.Generic.List<GK_AchievementTemplate>();
        this.GalleryImageFormat = true;
        this.AutoLoadUsersSmallImages = true;
        this.ShowLeaderboards = true;
        this.ShowAchievementsParams = true;
        this.AdEditorTesting = true;
        this.MaxImageLoadSize = 512;
        this.JPegCompressionRate = 7.346868E-41f;
        this.CameraUsageDescription = "for making pictures";
        this.PhotoLibraryUsageDescription = "for taking pictures";
        this.AppleMusicUsageDescription = "for playing music";
        this.ContactsUsageDescription = "for contacts reading";
        this.UrlTypes = new System.Collections.Generic.List<SA.IOSNative.Models.UrlType>();
        this.ApplicationQueriesSchemes = new System.Collections.Generic.List<SA.IOSNative.Models.UrlType>();
        this.ForceTouchMenu = new System.Collections.Generic.List<SA.IOSNative.Gestures.ForceTouchMenuItem>();
        this.SoomlaDownloadLink = "http://goo.gl/7LYwuj";
        this.SoomlaDocsLink = "https://goo.gl/JFkpNa";
        val_8 = null;
        val_8 = null;
        this.SoomlaGameKey = System.String.Empty;
        this.SoomlaEnvKey = System.String.Empty;
        this.OneSignalDocsLink = "https://goo.gl/Royty6";
    }
    public static IOSNativeSettings get_Instance()
    {
        var val_6;
        IOSNativeSettings val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        val_6 = null;
        val_6 = null;
        val_7 = IOSNativeSettings.instance;
        if(0 == val_7)
        {
                UnityEngine.Object val_2 = UnityEngine.Resources.Load(path:  0);
            val_8 = null;
            val_8 = null;
            val_9 = 0;
            IOSNativeSettings.instance = ;
            if(0 == IOSNativeSettings.instance)
        {
                val_10 = null;
            val_7 = UnityEngine.ScriptableObject.CreateInstance<LlockhamIndustries.Decals.DynamicDecalSettings>();
            val_10 = null;
            IOSNativeSettings.instance = val_7;
        }
        
        }
        
        val_11 = null;
        val_11 = null;
        return (IOSNativeSettings)IOSNativeSettings.instance;
    }
    private static IOSNativeSettings()
    {
    
    }

}

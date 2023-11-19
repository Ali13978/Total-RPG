using UnityEngine;
public class IOSNativeFeaturesPreview : BaseIOSFeaturePreview
{
    // Fields
    public float x;
    public static IOSNativePreviewBackButton back;
    
    // Methods
    public IOSNativeFeaturesPreview()
    {
    
    }
    private void Awake()
    {
        var val_3;
        IOSNativePreviewBackButton val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = IOSNativeFeaturesPreview.back;
        if(0 != val_4)
        {
                return;
        }
        
        val_5 = null;
        val_4 = IOSNativePreviewBackButton.Create();
        val_5 = null;
        IOSNativeFeaturesPreview.back = val_4;
    }
    private void OnGUI()
    {
        this.UpdateToStartPos();
        int val_1 = UnityEngine.Screen.width;
        float val_24 = 0f;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_24, m_Width = 0f, m_Height = 0f}, text:  0, style:  "Game Center Examples");
        val_24 = val_24 + 0f;
        mem[1152921510401106936] = val_24;
        float val_25 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_25, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                this.LoadLevel(levelName:  "GameCenterGeneral");
        }
        
        val_25 = 0f + val_25;
        mem[1152921510401106940] = val_25;
        float val_26 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_26, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                this.LoadLevel(levelName:  "FriendsLoadExample");
        }
        
        val_26 = 0f + val_26;
        mem[1152921510401106940] = val_26;
        float val_27 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_27, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                this.LoadLevel(levelName:  "CustomLeaderboardGUIExample");
        }
        
        val_27 = val_27 + 0f;
        mem[1152921510401106940] = "CustomLeaderboardGUIExample";
        mem[1152921510401106936] = 0f + val_27;
        int val_6 = UnityEngine.Screen.width;
        float val_28 = 0f;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_28, m_Width = 0f, m_Height = 0f}, text:  0, style:  "Main Features");
        val_28 = 0f + val_28;
        mem[1152921510401106940] = "Main Features";
        mem[1152921510401106936] = val_28;
        float val_29 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_29, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                this.LoadLevel(levelName:  "BillingExample");
        }
        
        val_29 = 0f + val_29;
        mem[1152921510401106940] = "BillingExample";
        mem[1152921510401106936] = val_29;
        float val_30 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_30, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                this.LoadLevel(levelName:  "iCloudExampleScene");
        }
        
        val_30 = 0f + val_30;
        mem[1152921510401106940] = val_30;
        float val_31 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_31, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                this.LoadLevel(levelName:  "SocialPostingExample");
        }
        
        val_31 = 0f + val_31;
        mem[1152921510401106940] = val_31;
        float val_32 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_32, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                this.LoadLevel(levelName:  "NotificationExample");
        }
        
        val_32 = 0f + val_32;
        mem[1152921510401106940] = "NotificationExample";
        mem[1152921510401106936] = val_32;
        float val_33 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_33, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                this.LoadLevel(levelName:  "ReplayKitExampleScene");
        }
        
        val_33 = 0f + val_33;
        mem[1152921510401106940] = val_33;
        float val_34 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_34, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                this.LoadLevel(levelName:  "CloudKitExampleScene");
        }
        
        val_34 = 0f + val_34;
        mem[1152921510401106940] = val_34;
        float val_35 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_35, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                this.LoadLevel(levelName:  "GameSavesExample");
        }
        
        val_35 = val_35 + 0f;
        mem[1152921510401106940] = "GameSavesExample";
        mem[1152921510401106936] = 0f + val_35;
        int val_15 = UnityEngine.Screen.width;
        float val_36 = 0f;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_36, m_Width = 0f, m_Height = 0f}, text:  0, style:  "Networking");
        val_36 = 0f + val_36;
        mem[1152921510401106940] = "Networking";
        mem[1152921510401106936] = val_36;
        float val_37 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_37, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                this.LoadLevel(levelName:  "TMB_Multiplayer_Example");
        }
        
        val_37 = 0f + val_37;
        mem[1152921510401106940] = val_37;
        float val_38 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_38, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                this.LoadLevel(levelName:  "RTM_Multiplayer_Example");
        }
        
        val_38 = 0f + val_38;
        mem[1152921510401106940] = val_38;
        float val_39 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_39, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                this.LoadLevel(levelName:  "Peer-To-PeerGameExample");
        }
        
        val_39 = val_39 + 0f;
        mem[1152921510401106940] = "Peer-To-PeerGameExample";
        mem[1152921510401106936] = 0f + val_39;
        int val_20 = UnityEngine.Screen.width;
        float val_40 = 0f;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_40, m_Width = 0f, m_Height = 0f}, text:  0, style:  "Additional Features Features");
        val_40 = 0f + val_40;
        mem[1152921510401106940] = "Additional Features Features";
        mem[1152921510401106936] = val_40;
        float val_41 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_41, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                this.LoadLevel(levelName:  "PopUpsAndAppEventsHandler");
        }
        
        val_41 = 0f + val_41;
        mem[1152921510401106940] = val_41;
        float val_42 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_42, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                this.LoadLevel(levelName:  "MediaExample");
        }
        
        val_42 = 0f + val_42;
        mem[1152921510401106940] = val_42;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) == false)
        {
                return;
        }
        
        this.LoadLevel(levelName:  "NativeIOSActionsExample");
    }
    private static IOSNativeFeaturesPreview()
    {
    
    }

}

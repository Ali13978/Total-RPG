using UnityEngine;
public class IOSSocialUseExample : MonoBehaviour
{
    // Fields
    private UnityEngine.GUIStyle style;
    private UnityEngine.GUIStyle style2;
    public UnityEngine.Texture2D drawTexture;
    public UnityEngine.Texture2D textureForPost;
    private static System.Action<TextMessageComposeResult> <>f__am$cache0;
    
    // Methods
    public IOSSocialUseExample()
    {
    
    }
    private void Awake()
    {
        System.Action<SA.Common.Models.Result> val_1 = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void IOSSocialUseExample::HandleOnFacebookPostResult(SA.Common.Models.Result res));
        IOSSocialManager.add_OnFacebookPostResult(value:  null);
        IOSSocialManager.add_OnTwitterPostResult(value:  new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void IOSSocialUseExample::HandleOnTwitterPostResult(SA.Common.Models.Result res)) = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void IOSSocialUseExample::HandleOnTwitterPostResult(SA.Common.Models.Result res)));
        IOSSocialManager.add_OnInstagramPostResult(value:  new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void IOSSocialUseExample::HandleOnInstagramPostResult(SA.Common.Models.Result res)) = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void IOSSocialUseExample::HandleOnInstagramPostResult(SA.Common.Models.Result res)));
        IOSSocialManager.add_OnMailResult(value:  new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void IOSSocialUseExample::OnMailResult(SA.Common.Models.Result result)) = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void IOSSocialUseExample::OnMailResult(SA.Common.Models.Result result)));
        this.InitStyles();
    }
    private void InitStyles()
    {
        this.style = new UnityEngine.GUIStyle();
        UnityEngine.Color val_3 = UnityEngine.Color.white;
        normal.textColor = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
        this.style.fontSize = 16;
        this.style.fontStyle = 3;
        this.style.alignment = 0;
        this.style.wordWrap = true;
        this.style2 = new UnityEngine.GUIStyle();
        UnityEngine.Color val_6 = UnityEngine.Color.white;
        normal.textColor = new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a};
        this.style2.fontSize = 12;
        this.style2.fontStyle = 2;
        this.style2.alignment = 0;
        this.style2.wordWrap = true;
    }
    private void OnGUI()
    {
        string val_38;
        System.Action<TextMessageComposeResult> val_39;
        int val_1 = UnityEngine.Screen.width;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0, style:  "Twitter");
        val_38 = "Post";
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.TwitterPost(text:  public static IOSSocialManager SA.Common.Pattern.Singleton<IOSSocialManager>::get_Instance(), url:  0, texture:  0);
        }
        
        bool val_4 = UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0);
        if(val_4 != false)
        {
                UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  val_4.PostTwitterScreenshot());
        }
        
        int val_7 = UnityEngine.Screen.width;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0, style:  "Facebook");
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.FacebookPost(text:  public static IOSSocialManager SA.Common.Pattern.Singleton<IOSSocialManager>::get_Instance(), url:  0, texture:  0);
        }
        
        bool val_10 = UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0);
        if(val_10 != false)
        {
                UnityEngine.Coroutine val_12 = this.StartCoroutine(routine:  val_10.PostFBScreenshot());
        }
        
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.FacebookPost(text:  public static IOSSocialManager SA.Common.Pattern.Singleton<IOSSocialManager>::get_Instance(), url:  0, texture:  0);
        }
        
        int val_15 = UnityEngine.Screen.width;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0, style:  "Native Sharing");
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                SA_EditorAd val_17 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
        }
        
        bool val_18 = UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0);
        if(val_18 != false)
        {
                UnityEngine.Coroutine val_20 = this.StartCoroutine(routine:  val_18.PostScreenshot());
        }
        
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.SendMail(subject:  public static IOSSocialManager SA.Common.Pattern.Singleton<IOSSocialManager>::get_Instance(), body:  0, recipients:  0, texture:  this.textureForPost);
        }
        
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                val_39 = IOSSocialUseExample.<>f__am$cache0;
            val_38 = "Hello Google";
            if(val_39 == null)
        {
                IOSSocialUseExample.<>f__am$cache0 = new System.Action<TextMessageComposeResult>(object:  0, method:  static System.Void IOSSocialUseExample::<OnGUI>m__0(TextMessageComposeResult result));
            val_39 = IOSSocialUseExample.<>f__am$cache0;
        }
        
            SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.SendTextMessage(body:  val_38, recepient:  "+18773555787", callback:  val_39);
        }
        
        int val_26 = UnityEngine.Screen.width;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0, style:  "Instagram");
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                val_38 = System.Void IOSSocialUseExample::OnPostImageInstagram(IOSImagePickResult result);
            System.Action<IOSImagePickResult> val_28 = new System.Action<IOSImagePickResult>(object:  this, method:  val_38);
            IOSCamera.add_OnImagePicked(value:  0);
            SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.PickImage(source:  2);
        }
        
        bool val_30 = UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0);
        if(val_30 != false)
        {
                UnityEngine.Coroutine val_32 = this.StartCoroutine(routine:  val_30.PostScreenshotInstagram());
        }
        
        int val_33 = UnityEngine.Screen.width;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0, style:  "WhatsApp");
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                SA_EditorAd val_35 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
        }
        
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) == false)
        {
                return;
        }
        
        if((SA.Common.Pattern.Singleton<SA_EditorAd>.Instance) != null)
        {
                return;
        }
    
    }
    private void OnPostImageInstagram(IOSImagePickResult result)
    {
        string val_5;
        bool val_1 = result.IsSucceeded;
        if(val_1 != false)
        {
                val_5 = 0;
            UnityEngine.Object.Destroy(obj:  0);
            this.drawTexture = result._image;
        }
        else
        {
                val_5 = "Image Load Failed";
            IOSMessage val_2 = IOSMessage.Create(title:  val_1, message:  "ERROR");
        }
        
        SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.InstagramPost(texture:  public static IOSSocialManager SA.Common.Pattern.Singleton<IOSSocialManager>::get_Instance(), message:  val_5);
        System.Action<IOSImagePickResult> val_4 = new System.Action<IOSImagePickResult>(object:  this, method:  System.Void IOSSocialUseExample::OnPostImageInstagram(IOSImagePickResult result));
        IOSCamera.remove_OnImagePicked(value:  0);
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private System.Collections.IEnumerator PostScreenshotInstagram()
    {
        return (System.Collections.IEnumerator)new System.Object();
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private System.Collections.IEnumerator PostScreenshot()
    {
        return (System.Collections.IEnumerator)new System.Object();
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private System.Collections.IEnumerator PostTwitterScreenshot()
    {
        return (System.Collections.IEnumerator)new System.Object();
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private System.Collections.IEnumerator PostFBScreenshot()
    {
        return (System.Collections.IEnumerator)new System.Object();
    }
    private void HandleOnInstagramPostResult(SA.Common.Models.Result res)
    {
        bool val_1 = res.IsSucceeded;
    }
    private void HandleOnTwitterPostResult(SA.Common.Models.Result res)
    {
        bool val_1 = res.IsSucceeded;
    }
    private void HandleOnFacebookPostResult(SA.Common.Models.Result res)
    {
        bool val_1 = res.IsSucceeded;
    }
    private void OnMailResult(SA.Common.Models.Result result)
    {
        bool val_1 = result.IsSucceeded;
    }
    private static void <OnGUI>m__0(TextMessageComposeResult result)
    {
        string val_1 = 0 + "Message send result: "("Message send result: ");
        UnityEngine.Debug.Log(message:  0);
    }

}

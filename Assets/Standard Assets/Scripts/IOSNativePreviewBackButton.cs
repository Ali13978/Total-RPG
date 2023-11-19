using UnityEngine;
public class IOSNativePreviewBackButton : BaseIOSFeaturePreview
{
    // Fields
    private string initialSceneName;
    
    // Properties
    public string loadedLevelName { get; }
    
    // Methods
    public IOSNativePreviewBackButton()
    {
        this.initialSceneName = "scene";
    }
    public static IOSNativePreviewBackButton Create()
    {
        UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  "BackButton");
        if(null != 0)
        {
                return AddComponent<IOSNativePreviewBackButton>();
        }
        
        return AddComponent<IOSNativePreviewBackButton>();
    }
    private void Awake()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  0);
        UnityEngine.SceneManagement.Scene val_2 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        this.initialSceneName = val_2.m_Handle.name;
    }
    private void OnGUI()
    {
        string val_10;
        UnityEngine.SceneManagement.Scene val_2 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        val_10 = this.initialSceneName;
        if((val_2.m_Handle.name.Equals(value:  val_10)) == true)
        {
                return;
        }
        
        val_10 = 1152921504742842368;
        float val_6 = (float)UnityEngine.Screen.width + (-144f);
        UnityEngine.Color val_7 = UnityEngine.GUI.color;
        UnityEngine.Color val_8 = UnityEngine.Color.green;
        UnityEngine.GUI.color = new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.a};
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                this.LoadLevel(levelName:  this.initialSceneName);
        }
        
        UnityEngine.GUI.color = new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a};
    }
    public string get_loadedLevelName()
    {
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        return (string)val_1.m_Handle.name;
    }

}

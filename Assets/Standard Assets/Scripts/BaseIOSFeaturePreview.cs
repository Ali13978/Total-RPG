using UnityEngine;
public class BaseIOSFeaturePreview : MonoBehaviour
{
    // Fields
    protected UnityEngine.GUIStyle style;
    protected int buttonWidth;
    protected int buttonHeight;
    protected float StartY;
    protected float StartX;
    protected float XStartPos;
    protected float YStartPos;
    protected float XButtonStep;
    protected float YButtonStep;
    protected float YLableStep;
    
    // Methods
    public BaseIOSFeaturePreview()
    {
        this.buttonWidth = 200;
        this.buttonHeight = 75;
        this.XButtonStep = 220f;
        this.YButtonStep = 90f;
        this.StartY = ;
        this.StartX = ;
        this.XStartPos = 10f;
        this.YStartPos = 10f;
        this.YLableStep = 50f;
    }
    protected virtual void InitStyles()
    {
        this.style = new UnityEngine.GUIStyle();
        UnityEngine.Color val_3 = UnityEngine.Color.white;
        normal.textColor = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
        this.style.fontSize = 16;
        this.style.fontStyle = 3;
        this.style.alignment = 0;
        this.style.wordWrap = true;
    }
    public virtual void Start()
    {
        goto typeof(BaseIOSFeaturePreview).__il2cppRuntimeField_150;
    }
    public void UpdateToStartPos()
    {
        this.StartY = this.YStartPos;
        this.StartX = this.XStartPos;
    }
    public void LoadLevel(string levelName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  0);
    }

}

using UnityEngine;
public class ConnectionButton : MonoBehaviour
{
    // Fields
    private float w;
    private float h;
    private UnityEngine.Rect r;
    
    // Methods
    public ConnectionButton()
    {
        this.r = 0;
        mem[1152921510372031032] = 0;
    }
    private void Start()
    {
        float val_5 = 0.2f;
        val_5 = (float)UnityEngine.Screen.width * val_5;
        this.w = val_5;
        float val_6 = 0.1f;
        val_6 = (float)UnityEngine.Screen.height * val_6;
        this.h = val_6;
        float val_7 = this.w;
        val_7 = (float)UnityEngine.Screen.width - val_7;
        val_7 = val_7 * 0.5f;
        this.r.startFloat = val_7;
        float val_8 = this.h;
        val_8 = (float)UnityEngine.Screen.height - val_8;
        val_8 = val_8 * 0.5f;
    }
    private void OnGUI()
    {
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = this.r, m_YMin = V10.16B, m_Width = V9.16B, m_Height = V8.16B}, text:  0)) == false)
        {
                return;
        }
        
        this = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
        if(this != null)
        {
                return;
        }
    
    }

}

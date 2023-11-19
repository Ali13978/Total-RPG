using UnityEngine;
public class DisconnectButton : MonoBehaviour
{
    // Fields
    private float w;
    private float h;
    private UnityEngine.Rect r;
    
    // Methods
    public DisconnectButton()
    {
        this.r = 0;
        mem[1152921510372375320] = 0;
    }
    private void Start()
    {
        float val_4 = 0.2f;
        val_4 = (float)UnityEngine.Screen.width * val_4;
        this.w = val_4;
        float val_5 = (float)UnityEngine.Screen.height;
        val_5 = val_5 * 0.1f;
        this.h = val_5;
        this.r.startFloat = this.w * 0.1f;
        float val_6 = this.h;
        val_6 = val_6 * 0.1f;
    }
    private void OnGUI()
    {
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = this.r, m_YMin = V10.16B, m_Width = V9.16B, m_Height = V8.16B}, text:  0)) == false)
        {
                return;
        }
        
        this = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
        val_2._IsInterstitialLoading = false;
        val_2._IsVideoLoading = false;
        val_2._IsInterstitialReady = false;
        val_2._IsVideoReady = false;
        val_2._FillRate = 0;
    }

}

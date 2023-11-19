using UnityEngine;
public class ShowStatusWhenConnecting : MonoBehaviour
{
    // Fields
    public UnityEngine.GUISkin Skin;
    
    // Methods
    public ShowStatusWhenConnecting()
    {
    
    }
    private void OnGUI()
    {
        if(0 != this.Skin)
        {
                UnityEngine.GUI.skin = 0;
        }
        
        float val_14 = (float)UnityEngine.Screen.width;
        val_14 = val_14 + (-400f);
        float val_4 = (float)UnityEngine.Screen.height + (-100f);
        val_14 = val_14 * 0.5f;
        val_4 = val_4 * 0.5f;
        UnityEngine.GUIStyle val_6 = UnityEngine.GUI.skin.box;
        UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, style:  0);
        string val_7 = this.GetConnectingDots();
        UnityEngine.GUILayout.Label(text:  0, style:  0 + "Connecting", options:  UnityEngine.GUI.skin.customStyles[0]);
        ClientState val_11 = PhotonNetwork.connectionStateDetailed;
        UnityEngine.GUILayout.Label(text:  0, options:  0 + "Status: "("Status: "));
        UnityEngine.GUILayout.EndArea();
        if(PhotonNetwork.inRoom == false)
        {
                return;
        }
        
        this.enabled = false;
    }
    private string GetConnectingDots()
    {
        var val_4;
        string val_5;
        val_4 = null;
        val_4 = null;
        val_5 = System.String.Empty;
        float val_4 = 3f;
        val_4 = UnityEngine.Time.timeSinceLevelLoad * val_4;
        int val_5 = UnityEngine.Mathf.FloorToInt(f:  val_4);
        if(val_5 < 1)
        {
                return (string)val_5;
        }
        
        do
        {
            val_5 = 0 + val_5;
            val_5 = val_5 - 1;
        }
        while(val_5 != 0);
        
        return (string)val_5;
    }

}

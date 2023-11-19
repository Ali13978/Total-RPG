using UnityEngine;
[Serializable]
public class JSCall : MonoBehaviour
{
    // Methods
    public JSCall()
    {
    
    }
    public override void Start()
    {
        this.SendMessage(methodName:  "InitGameCenter");
    }
    public override void OnGUI()
    {
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                this.SendMessage(methodName:  "SubmitScore", value:  100);
        }
        
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) == false)
        {
                return;
        }
        
        UnityScript.Lang.Array val_3 = new UnityScript.Lang.Array();
        if(null != 0)
        {
                int val_4 = push(value:  "20.2");
            int val_5 = push(value:  "your.achievement.id1.here");
        }
        else
        {
                int val_6 = push(value:  "20.2");
            int val_7 = push(value:  "your.achievement.id1.here");
        }
        
        this.SendMessage(methodName:  "SubmitAchievement", value:  join(seperator:  "|"));
    }
    public override void Main()
    {
    
    }

}

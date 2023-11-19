using UnityEngine;
[UnityEngine.RequireComponent]
public class PointedAtGameObjectInfo : MonoBehaviour
{
    // Methods
    public PointedAtGameObjectInfo()
    {
    
    }
    private void OnGUI()
    {
        UnityEngine.Object val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        object val_31;
        object val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        val_26 = InputToEvent.goPointedAt;
        if(0 == val_26)
        {
                return;
        }
        
        UnityEngine.GameObject val_3 = InputToEvent.goPointedAt;
        val_26 = Extensions.GetPhotonView(go:  0);
        if(0 == val_26)
        {
                return;
        }
        
        UnityEngine.Vector3 val_6 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_8 = UnityEngine.Input.mousePosition;
        val_8.y = (float)UnityEngine.Screen.height - val_8.y;
        val_8.y = val_8.y + (-15f);
        float val_26 = 5f;
        val_26 = val_6.x + val_26;
        int val_9 = val_26.CreatorActorNr;
        var val_10 = (val_9 == 0) ? 0f : 0f;
        var val_11 = (val_9 == 0) ? 0f : 0f;
        var val_12 = (val_9 == 0) ? 0f : 0f;
        var val_13 = (val_9 == 0) ? 0f : 0f;
        var val_14 = (val_9 == 0) ? 0 : "ViewID {0} {1}{2}";
        var val_15 = (val_9 == 0) ? 0 : val_4.viewIdField;
        if(val_9 != 0)
        {
                val_33 = null;
            val_33 = null;
        }
        else
        {
                val_34 = "scene ";
            val_27 = 0f;
            val_28 = 0f;
            val_29 = 0f;
            val_30 = 0f;
            val_31 = "ViewID {0} {1}{2}";
            val_32 = val_4.viewIdField;
        }
        
        bool val_16 = val_26.isMine;
        if(val_16 != false)
        {
                val_39 = val_34;
            val_38 = val_30;
            val_37 = val_29;
            val_40 = "mine";
            val_36 = val_28;
            val_35 = val_27;
        }
        else
        {
                val_40 = 0 + "owner: "("owner: ");
            val_32 = (val_16 != true) ? 0 : (val_32);
            val_31 = (val_16 != true) ? 0 : (val_31);
        }
        
        val_26 = System.String.Format(format:  0, arg0:  val_31, arg1:  val_32, arg2:  (val_16 != true) ? 0 : (val_34));
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = (val_16 != true) ? 0f : (val_27), m_YMin = (val_16 != true) ? 0f : (val_28), m_Width = (val_16 != true) ? 0f : (val_29), m_Height = (val_16 != true) ? 0f : (val_30)}, text:  0);
    }

}

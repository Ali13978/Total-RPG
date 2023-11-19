using UnityEngine;
public class FloatingLabel : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform Target;
    public UnityEngine.Camera TargetCamera;
    public UnityEngine.Vector3 offset;
    private UnityEngine.GUIText myGuiText;
    
    // Methods
    public FloatingLabel()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.offset = val_1;
        mem[1152921511109403244] = val_1.y;
        mem[1152921511109403248] = val_1.z;
    }
    private void Awake()
    {
        this.myGuiText = this.GetComponent<UnityEngine.GUIText>();
    }
    public void SetText(string text)
    {
        this.myGuiText.text = text;
    }
    private void LateUpdate()
    {
        var val_13;
        var val_14;
        UnityEngine.Camera val_15;
        val_13 = this;
        val_14 = 1152921504721543168;
        if(0 == UnityEngine.Camera.main)
        {
                return;
        }
        
        if(0 == this.Target)
        {
                return;
        }
        
        if(0 == this.TargetCamera)
        {
                val_15 = UnityEngine.Camera.main;
        }
        else
        {
                val_15 = this.TargetCamera;
        }
        
        val_14 = this.Target.transform;
        UnityEngine.Vector3 val_7 = val_14.position;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = this.offset, y = V11.16B, z = V10.16B});
        UnityEngine.Vector3 val_9 = val_15.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        float val_13 = val_9.x;
        float val_14 = val_9.y;
        val_13 = val_13 / (float)UnityEngine.Screen.width;
        val_14 = val_14 / (float)UnityEngine.Screen.height;
        val_13 = this.myGuiText.transform;
        val_13.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }

}

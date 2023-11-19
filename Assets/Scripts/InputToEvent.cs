using UnityEngine;
public class InputToEvent : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject lastGo;
    public static UnityEngine.Vector3 inputHitPos;
    public bool DetectPointedAtGameObject;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static UnityEngine.GameObject <goPointedAt>k__BackingField;
    private UnityEngine.Vector2 pressedPosition;
    private UnityEngine.Vector2 currentPos;
    public bool Dragging;
    private UnityEngine.Camera m_Camera;
    
    // Properties
    public static UnityEngine.GameObject goPointedAt { get; set; }
    public UnityEngine.Vector2 DragVector { get; }
    
    // Methods
    public InputToEvent()
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.pressedPosition = val_1;
        mem[1152921512467534296] = val_1.y;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
        this.currentPos = val_2;
        mem[1152921512467534304] = val_2.y;
    }
    public static UnityEngine.GameObject get_goPointedAt()
    {
        return (UnityEngine.GameObject)InputToEvent.<goPointedAt>k__BackingField;
    }
    private static void set_goPointedAt(UnityEngine.GameObject value)
    {
        InputToEvent.<goPointedAt>k__BackingField = X1;
    }
    public UnityEngine.Vector2 get_DragVector()
    {
        if(this.Dragging == false)
        {
                return UnityEngine.Vector2.zero;
        }
        
        return UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = this.currentPos, y = V10.16B}, b:  new UnityEngine.Vector2() {x = this.pressedPosition, y = V8.16B});
    }
    private void Start()
    {
        this.m_Camera = this.GetComponent<UnityEngine.Camera>();
    }
    private void Update()
    {
        UnityEngine.GameObject val_22;
        float val_23;
        float val_24;
        var val_25;
        float val_26;
        float val_27;
        float val_28;
        val_22 = this;
        if(this.DetectPointedAtGameObject != false)
        {
                UnityEngine.Vector3 val_1 = UnityEngine.Input.mousePosition;
            val_23 = val_1.x;
            val_24 = val_1.z;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_23, y = val_1.y, z = val_24});
            InputToEvent.<goPointedAt>k__BackingField = this.RaycastObject(screenPos:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
        }
        
        if(UnityEngine.Input.touchCount < 1)
        {
            goto label_9;
        }
        
        UnityEngine.Touch val_7 = UnityEngine.Input.GetTouch(index:  0);
        this.currentPos = val_2;
        mem[1152921512468135408] = val_2.y;
        if(==0)
        {
            goto label_12;
        }
        
        if((-728658360) != 3)
        {
                return;
        }
        
        this.Release(screenPos:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
        return;
        label_9:
        UnityEngine.Vector3 val_9 = UnityEngine.Input.mousePosition;
        val_25 = 1152921504730062848;
        val_23 = val_9.x;
        val_24 = val_9.z;
        val_26 = val_23;
        val_27 = val_9.y;
        val_28 = val_24;
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_26, y = val_27, z = val_28});
        this.currentPos = val_10;
        mem[1152921512468135408] = val_10.y;
        if((UnityEngine.Input.GetMouseButtonDown(button:  0)) != false)
        {
                UnityEngine.Vector3 val_12 = UnityEngine.Input.mousePosition;
            val_23 = val_12.x;
            val_24 = val_12.z;
            val_26 = val_23;
            val_27 = val_12.y;
            val_28 = val_24;
            UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_26, y = val_27, z = val_28});
            this.Press(screenPos:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
        }
        
        if((UnityEngine.Input.GetMouseButtonUp(button:  0)) != false)
        {
                UnityEngine.Vector3 val_15 = UnityEngine.Input.mousePosition;
            val_23 = val_15.x;
            val_24 = val_15.z;
            val_26 = val_23;
            val_27 = val_15.y;
            val_28 = val_24;
            UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_26, y = val_27, z = val_28});
            this.Release(screenPos:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y});
        }
        
        if((UnityEngine.Input.GetMouseButtonDown(button:  0)) == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_18 = UnityEngine.Input.mousePosition;
        val_23 = val_18.x;
        val_24 = val_18.z;
        UnityEngine.Vector2 val_19 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_23, y = val_18.y, z = val_24});
        this.pressedPosition = val_19;
        mem[1152921512468135400] = val_19.y;
        UnityEngine.GameObject val_20 = this.RaycastObject(screenPos:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y});
        this.lastGo = val_20;
        if(0 == val_20)
        {
                return;
        }
        
        val_22 = this.lastGo;
        val_22.SendMessage(methodName:  "OnPressRight", options:  1);
        return;
        label_12:
        this.Press(screenPos:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
    }
    private void Press(UnityEngine.Vector2 screenPos)
    {
        this.pressedPosition = screenPos;
        mem[1152921512468280312] = screenPos.y;
        this.Dragging = true;
        UnityEngine.GameObject val_1 = this.RaycastObject(screenPos:  new UnityEngine.Vector2() {x = screenPos.x, y = screenPos.y});
        this.lastGo = val_1;
        if(0 == val_1)
        {
                return;
        }
        
        this.lastGo.SendMessage(methodName:  "OnPress", options:  1);
    }
    private void Release(UnityEngine.Vector2 screenPos)
    {
        if(0 != this.lastGo)
        {
                1152921504721543168 = this.RaycastObject(screenPos:  new UnityEngine.Vector2() {x = screenPos.x, y = screenPos.y});
            if(0 == 1152921504721543168)
        {
                this.lastGo.SendMessage(methodName:  "OnClick", options:  1);
        }
        
            this.lastGo.SendMessage(methodName:  "OnRelease", options:  1);
            this.lastGo = 0;
        }
        
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
        this.pressedPosition = val_4;
        mem[1152921512468421176] = val_4.y;
        this.Dragging = false;
    }
    private UnityEngine.GameObject RaycastObject(UnityEngine.Vector2 screenPos)
    {
        float val_3;
        float val_4;
        UnityEngine.Camera val_8;
        var val_9;
        val_8 = this.m_Camera;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = screenPos.x, y = screenPos.y});
        UnityEngine.Ray val_2 = val_8.ScreenPointToRay(position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        val_9 = 0;
        if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3(), m_Direction = new UnityEngine.Vector3()}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, m_Normal = new UnityEngine.Vector3() {x = val_4, y = val_3, z = val_3}, m_UV = new UnityEngine.Vector2()}, maxDistance:  200f)) == false)
        {
                return (UnityEngine.GameObject)val_8.gameObject;
        }
        
        InputToEvent.inputHitPos = 200f;
        InputToEvent.inputHitPos.__il2cppRuntimeField_4 = val_1.y;
        InputToEvent.inputHitPos.__il2cppRuntimeField_8 = val_1.z;
        val_8 = 0.Payload;
        return (UnityEngine.GameObject)val_8.gameObject;
    }

}

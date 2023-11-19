using UnityEngine;
public class Spectator : MonoBehaviour
{
    // Fields
    public float MovementSpeed;
    public float MouseHorizontalSpeed;
    public float MouseVerticalSpeed;
    public float MinimumVertical;
    public float MaximumVertical;
    public bool LookOnRightMouseDown;
    private bool bCanLook;
    private float rotX;
    private float rotY;
    private UnityEngine.Vector3 translateVector;
    
    // Methods
    public Spectator()
    {
        this.MovementSpeed = ;
        this.MouseHorizontalSpeed = ;
        this.MouseVerticalSpeed = 5f;
        this.MinimumVertical = -60f;
        this.MaximumVertical = 60f;
        this.LookOnRightMouseDown = true;
        this.bCanLook = true;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.translateVector = val_1;
        mem[1152921511208640908] = val_1.y;
        mem[1152921511208640912] = val_1.z;
    }
    private void Start()
    {
        if(this.LookOnRightMouseDown == false)
        {
                return;
        }
        
        this.bCanLook = false;
    }
    private void Update()
    {
        bool val_5;
        if((this.LookOnRightMouseDown & 255) == false)
        {
            goto label_1;
        }
        
        if((UnityEngine.Input.GetMouseButtonDown(button:  0)) != false)
        {
                this.bCanLook = true;
        }
        
        if((UnityEngine.Input.GetMouseButtonUp(button:  0)) == false)
        {
            goto label_7;
        }
        
        this.bCanLook = false;
        goto label_10;
        label_1:
        val_5 = this.LookOnRightMouseDown >> 8;
        goto label_9;
        label_7:
        val_5 = this.bCanLook;
        label_9:
        if(val_5 != false)
        {
                this.handleMouseInput();
        }
        
        label_10:
        this.handleKeyboardInput();
    }
    private void handleMouseInput()
    {
        UnityEngine.Vector3 val_3 = this.transform.localEulerAngles;
        float val_4 = (UnityEngine.Input.GetAxis(axisName:  0)) * this.MouseHorizontalSpeed;
        val_4 = val_4 + val_3.y;
        this.rotX = val_4;
        float val_8 = this.rotY;
        float val_5 = UnityEngine.Input.GetAxis(axisName:  0);
        val_5 = val_5 * this.MouseVerticalSpeed;
        val_8 = val_8 + val_5;
        this.rotY = val_8;
        this.rotY = UnityEngine.Mathf.Clamp(value:  val_8, min:  this.MinimumVertical, max:  this.MaximumVertical);
        this.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private void handleKeyboardInput()
    {
        this.translateVector = UnityEngine.Input.GetAxis(axisName:  0);
        mem[1152921511209109584] = UnityEngine.Input.GetAxis(axisName:  0);
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.translateVector, y = V9.16B, z = V10.16B}, d:  UnityEngine.Time.deltaTime);
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  this.MovementSpeed);
        this.transform.Translate(translation:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
    }

}

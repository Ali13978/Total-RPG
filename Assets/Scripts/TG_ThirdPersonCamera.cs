using UnityEngine;
public class TG_ThirdPersonCamera : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform Target;
    public float CamPitch;
    public float CamYaw;
    public float CamOffset;
    private UnityEngine.Vector3 isoRotEulerAngles;
    private UnityEngine.Vector3 vOffset;
    protected UnityEngine.Vector3 TargetOffset;
    private UnityEngine.Transform cachedTransform;
    
    // Methods
    public TG_ThirdPersonCamera()
    {
        this.CamPitch = 60f;
        this.CamOffset = 5f;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.isoRotEulerAngles = val_1;
        mem[1152921511457768496] = val_1.y;
        mem[1152921511457768500] = val_1.z;
        this.vOffset = 0;
        mem[1152921511457768508] = 0;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.TargetOffset = val_2;
        mem[1152921511457768520] = val_2.y;
        mem[1152921511457768524] = val_2.z;
    }
    private void Awake()
    {
        this.cachedTransform = this.transform;
    }
    public void Unparent()
    {
        this.cachedTransform.SetParent(parent:  0);
    }
    private void LateUpdate()
    {
        goto typeof(TG_ThirdPersonCamera).__il2cppRuntimeField_150;
    }
    public virtual void UpdateCamera()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.vOffset = val_1;
        mem[1152921511458249276] = val_1.y;
        mem[1152921511458249280] = this.CamOffset;
        this.isoRotEulerAngles = this.CamPitch;
        mem[1152921511458249264] = this.CamYaw;
        this.cachedTransform.eulerAngles = new UnityEngine.Vector3() {x = this.CamPitch, y = this.CamYaw, z = V8.16B};
        UnityEngine.Quaternion val_2 = this.cachedTransform.rotation;
        UnityEngine.Vector3 val_3 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w}, point:  new UnityEngine.Vector3() {x = this.vOffset, y = V12.16B, z = V11.16B});
        this.vOffset = val_3;
        mem[1152921511458249276] = val_3.y;
        mem[1152921511458249280] = val_3.z;
        UnityEngine.Vector3 val_4 = this.Target.position;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = this.TargetOffset, y = this.vOffset, z = V12.16B});
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = this.vOffset, y = this.vOffset, z = V12.16B});
        this.cachedTransform.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
    }

}

using UnityEngine;
public class FollowGameObject : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform objectToFollow;
    public UnityEngine.Vector3 displacement;
    public bool applyYaw;
    private UnityEngine.Transform cachedTransform;
    
    // Methods
    public FollowGameObject()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.displacement = val_1;
        mem[1152921511109950564] = val_1.y;
        mem[1152921511109950568] = val_1.z;
    }
    private void Start()
    {
        this.cachedTransform = this.transform;
    }
    private void Update()
    {
        UnityEngine.Vector3 val_8;
        float val_9;
        float val_10;
        if(0 == this.objectToFollow)
        {
                return;
        }
        
        val_8 = this.displacement;
        if(this.applyYaw != false)
        {
                UnityEngine.Vector3 val_3 = this.objectToFollow.forward;
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_3.x, y = 0f, z = val_3.z});
            UnityEngine.Vector3 val_5 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, point:  new UnityEngine.Vector3() {x = val_8, y = V9.16B, z = V10.16B});
            val_8 = val_5.x;
            val_9 = val_5.y;
            val_10 = val_5.z;
            this.cachedTransform.rotation = new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w};
        }
        
        UnityEngine.Vector3 val_6 = this.objectToFollow.position;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_10});
        this.cachedTransform.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
    }
    public void Unparent()
    {
        this.cachedTransform.SetParent(parent:  0);
    }

}

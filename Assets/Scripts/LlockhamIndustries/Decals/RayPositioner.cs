using UnityEngine;

namespace LlockhamIndustries.Decals
{
    public class RayPositioner : Positioner
    {
        // Fields
        public UnityEngine.Transform rayTransform;
        public UnityEngine.Vector3 positionOffset;
        public UnityEngine.Vector3 rotationOffset;
        public float castLength;
        
        // Methods
        public RayPositioner()
        {
            this.castLength = 100f;
            UnityEngine.LayerMask val_1 = UnityEngine.LayerMask.op_Implicit(intVal:  0);
            mem[1152921511819020288] = val_1.m_Mask;
            this = new UnityEngine.MonoBehaviour();
        }
        private void LateUpdate()
        {
            UnityEngine.Transform val_13;
            if(0 != this.rayTransform)
            {
                    val_13 = this.rayTransform;
            }
            else
            {
                    val_13 = this.transform;
            }
            
            UnityEngine.Quaternion val_3 = val_13.rotation;
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.rotationOffset, y = V13.16B, z = V12.16B});
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}, rhs:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w});
            UnityEngine.Vector3 val_6 = val_13.position;
            UnityEngine.Vector3 val_7 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w}, point:  new UnityEngine.Vector3() {x = this.positionOffset, y = val_4.y, z = val_4.z});
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_10 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w}, point:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_12 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w}, point:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            this.Reproject(Ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, CastLength:  this.castLength, ReferenceUp:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        }
        private void OnDrawGizmosSelected()
        {
            UnityEngine.Transform val_17;
            if(0 != this.rayTransform)
            {
                    val_17 = this.rayTransform;
            }
            else
            {
                    val_17 = this.transform;
            }
            
            UnityEngine.Quaternion val_3 = val_17.rotation;
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.rotationOffset, y = V13.16B, z = V12.16B});
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}, rhs:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w});
            UnityEngine.Vector3 val_6 = val_17.position;
            UnityEngine.Vector3 val_7 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w}, point:  new UnityEngine.Vector3() {x = this.positionOffset, y = val_4.y, z = val_4.z});
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            UnityEngine.Color val_9 = UnityEngine.Color.black;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_9.r, g = val_9.g, b = val_9.b, a = val_9.a};
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_11 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w}, point:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  0.4f);
            UnityEngine.Gizmos.DrawRay(from:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, direction:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            UnityEngine.Color val_13 = UnityEngine.Color.white;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_13.r, g = val_13.g, b = val_13.b, a = val_13.a};
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_15 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w}, point:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, d:  this.castLength);
            UnityEngine.Gizmos.DrawRay(from:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, direction:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
        }
    
    }

}

using UnityEngine;

namespace Cinemachine.Utility
{
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static class UnityQuaternionExtensions
    {
        // Methods
        public static UnityEngine.Quaternion SlerpWithReferenceUp(UnityEngine.Quaternion qA, UnityEngine.Quaternion qB, float t, UnityEngine.Vector3 up)
        {
            float val_1;
            float val_19;
            float val_20;
            float val_21;
            float val_22;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_3 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = qA.x, y = qA.y, z = qA.z, w = qA.w}, point:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Vector3 val_4 = Cinemachine.Utility.UnityVectorExtensions.ProjectOntoPlane(vector:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, planeNormal:  new UnityEngine.Vector3() {x = up.x, y = val_1, z = up.y});
            val_19 = val_4.z;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_6 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = qB.x, y = qB.y, z = qB.z, w = qB.w}, point:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            val_20 = val_4.x;
            UnityEngine.Vector3 val_7 = Cinemachine.Utility.UnityVectorExtensions.ProjectOntoPlane(vector:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, planeNormal:  new UnityEngine.Vector3() {x = up.x, y = val_1, z = up.y});
            val_21 = val_7.y;
            val_22 = val_7.z;
            if(val_7.x >= 0)
            {
                    if(val_7.x >= 0)
            {
                goto label_6;
            }
            
            }
            
            UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.Slerp(a:  new UnityEngine.Quaternion() {x = qA.x, y = qA.y, z = qA.z, w = qA.w}, b:  new UnityEngine.Quaternion() {x = qB.x, y = qB.y, z = qB.z, w = qB.w}, t:  t);
            return new UnityEngine.Quaternion() {x = val_18.x, y = val_18.y, z = val_18.z, w = val_18.w};
            label_6:
            UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_20, y = val_4.y, z = val_19}, upwards:  new UnityEngine.Vector3() {x = up.x, y = val_1, z = up.y});
            val_20 = val_9.z;
            UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w});
            UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w}, rhs:  new UnityEngine.Quaternion() {x = qA.x, y = qA.y, z = qA.z, w = qA.w});
            UnityEngine.Quaternion val_12 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_20, w = val_9.w});
            UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w}, rhs:  new UnityEngine.Quaternion() {x = qB.x, y = qB.y, z = qB.z, w = qB.w});
            val_19 = val_13.z;
            val_22 = UnityEngine.Mathf.LerpAngle(a:  val_13.x, b:  val_13.x, t:  t);
            val_21 = UnityEngine.Mathf.LerpAngle(a:  val_13.y, b:  val_13.y, t:  t);
            UnityEngine.Quaternion val_17 = UnityEngine.Quaternion.Euler(x:  val_22, y:  val_21, z:  UnityEngine.Mathf.LerpAngle(a:  val_13.z, b:  val_19, t:  t));
            UnityEngine.Quaternion val_18 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_20, w = val_9.w}, rhs:  new UnityEngine.Quaternion() {x = val_17.x, y = val_17.y, z = val_17.z, w = val_17.w});
            return new UnityEngine.Quaternion() {x = val_18.x, y = val_18.y, z = val_18.z, w = val_18.w};
        }
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static UnityEngine.Quaternion Normalized(UnityEngine.Quaternion q)
        {
            return new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f};
        }
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static UnityEngine.Vector2 GetCameraRotationToTarget(UnityEngine.Quaternion orient, UnityEngine.Vector3 lookAtDir, UnityEngine.Vector3 worldUp)
        {
            float val_2;
            var val_23;
            float val_24;
            float val_25;
            float val_26;
            float val_27;
            float val_33;
            float val_35;
            float val_36;
            float val_37;
            val_24 = lookAtDir.z;
            val_25 = lookAtDir.x;
            val_26 = orient.z;
            val_27 = orient.x;
            if(orient.x < 0)
            {
                    UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
                return new UnityEngine.Vector2() {x = val_22.m_Height, y = val_22.m_Radius};
            }
            
            val_23 = 1152921504719839232;
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = val_27, y = orient.y, z = val_26, w = orient.w});
            UnityEngine.Vector3 val_4 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}, point:  new UnityEngine.Vector3() {x = worldUp.x, y = val_2, z = worldUp.y});
            UnityEngine.Vector3 val_5 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}, point:  new UnityEngine.Vector3() {x = val_25, y = lookAtDir.y, z = val_24});
            UnityEngine.Vector3 val_6 = Cinemachine.Utility.UnityVectorExtensions.ProjectOntoPlane(vector:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, planeNormal:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            if(val_6.x >= 0)
            {
                goto label_7;
            }
            
            val_33 = val_4.x;
            val_24 = 0f;
            goto label_8;
            label_7:
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_8 = Cinemachine.Utility.UnityVectorExtensions.ProjectOntoPlane(vector:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, planeNormal:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            val_35 = val_8.x;
            val_36 = val_8.y;
            val_37 = val_8.z;
            if(val_8.x >= 0)
            {
                goto label_11;
            }
            
            if((UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_35, y = val_36, z = val_37}, rhs:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z})) <= 0f)
            {
                goto label_14;
            }
            
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.down;
            goto label_17;
            label_11:
            val_33 = val_4.x;
            goto label_18;
            label_14:
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.up;
            label_17:
            val_33 = val_4.x;
            UnityEngine.Vector3 val_14 = Cinemachine.Utility.UnityVectorExtensions.ProjectOntoPlane(vector:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, planeNormal:  new UnityEngine.Vector3() {x = val_33, y = val_4.y, z = val_4.z});
            val_35 = val_14.x;
            val_36 = val_14.y;
            val_37 = val_14.z;
            label_18:
            val_24 = Cinemachine.Utility.UnityVectorExtensions.SignedAngle(from:  new UnityEngine.Vector3() {x = val_35, y = val_36, z = val_37}, to:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, refNormal:  new UnityEngine.Vector3() {x = val_33, y = val_4.z, z = val_6.x});
            label_8:
            UnityEngine.Quaternion val_16 = UnityEngine.Quaternion.AngleAxis(angle:  val_24, axis:  new UnityEngine.Vector3() {x = val_33, y = val_4.y, z = val_4.z});
            val_25 = val_16.y;
            val_26 = val_16.z;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_18 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_16.x, y = val_25, z = val_26, w = val_16.w}, point:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            val_27 = val_18.y;
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_20 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_16.x, y = val_25, z = val_26, w = val_16.w}, point:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
            CinemachineFreeLook.Orbit val_22 = new CinemachineFreeLook.Orbit(h:  Cinemachine.Utility.UnityVectorExtensions.SignedAngle(from:  new UnityEngine.Vector3() {x = val_18.x, y = val_27, z = val_18.z}, to:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, refNormal:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.z, z = val_6.x}), r:  val_24);
            return new UnityEngine.Vector2() {x = val_22.m_Height, y = val_22.m_Radius};
        }
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static UnityEngine.Quaternion ApplyCameraRotation(UnityEngine.Quaternion orient, UnityEngine.Vector2 rot, UnityEngine.Vector3 worldUp)
        {
            float val_1;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.right;
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.AngleAxis(angle:  rot.x, axis:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.AngleAxis(angle:  rot.y, axis:  new UnityEngine.Vector3() {x = worldUp.x, y = val_1, z = worldUp.y});
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, rhs:  new UnityEngine.Quaternion() {x = orient.x, y = orient.y, z = orient.z, w = orient.w});
            return UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w}, rhs:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
        }
    
    }

}

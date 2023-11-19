using UnityEngine;

namespace Cinemachine.Utility
{
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static class UnityVectorExtensions
    {
        // Fields
        public const float Epsilon = 0.0001;
        
        // Methods
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static float ClosestPointOnSegment(UnityEngine.Vector3 p, UnityEngine.Vector3 s0, UnityEngine.Vector3 s1)
        {
            float val_1;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = s1.x, y = val_1, z = s1.y}, b:  new UnityEngine.Vector3() {x = s0.x, y = s0.y, z = s0.z});
            float val_3 = UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            if(val_3 < 0)
            {
                    return 0f;
            }
            
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = p.x, y = p.y, z = p.z}, b:  new UnityEngine.Vector3() {x = s0.x, y = s0.y, z = s0.z});
            float val_5 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, rhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            val_5 = val_5 / val_3;
            return UnityEngine.Mathf.Clamp01(value:  val_5);
        }
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static float ClosestPointOnSegment(UnityEngine.Vector2 p, UnityEngine.Vector2 s0, UnityEngine.Vector2 s1)
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = s1.x, y = s1.y}, b:  new UnityEngine.Vector2() {x = s0.x, y = s0.y});
            float val_2 = UnityEngine.Vector2.SqrMagnitude(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            if(val_2 < 0)
            {
                    return 0f;
            }
            
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = p.x, y = p.y}, b:  new UnityEngine.Vector2() {x = s0.x, y = s0.y});
            float val_4 = UnityEngine.Vector2.Dot(lhs:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, rhs:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            val_4 = val_4 / val_2;
            return UnityEngine.Mathf.Clamp01(value:  val_4);
        }
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static UnityEngine.Vector3 ProjectOntoPlane(UnityEngine.Vector3 vector, UnityEngine.Vector3 planeNormal)
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(d:  UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = vector.x, y = vector.y, z = vector.z}, rhs:  new UnityEngine.Vector3() {x = planeNormal.x, y = planeNormal.y, z = planeNormal.z}), a:  new UnityEngine.Vector3() {x = planeNormal.x, y = planeNormal.y, z = planeNormal.z});
            return UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = vector.x, y = vector.y, z = vector.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static bool AlmostZero(UnityEngine.Vector3 v)
        {
            return (bool)(v.x < 0) ? 1 : 0;
        }
        public static float SignedAngle(UnityEngine.Vector3 from, UnityEngine.Vector3 to, UnityEngine.Vector3 refNormal)
        {
            float val_1;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = from.x, y = from.y, z = from.z}, rhs:  new UnityEngine.Vector3() {x = to.x, y = to.y, z = to.z});
            float val_3 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = refNormal.x, y = val_1, z = refNormal.y});
            if(System.Math.Abs(val_3) < 0)
            {
                    var val_7 = ((UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = from.x, y = from.y, z = from.z}, rhs:  new UnityEngine.Vector3() {x = to.x, y = to.y, z = to.z})) >= 0) ? 0f : 180f;
                return (float)val_8;
            }
            
            float val_8 = UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = from.x, y = from.y, z = from.z}, to:  new UnityEngine.Vector3() {x = to.x, y = to.y, z = to.z});
            val_8 = (val_3 < 0) ? (-val_8) : (val_8);
            return (float)val_8;
        }
        public static UnityEngine.Vector3 SlerpWithReferenceUp(UnityEngine.Vector3 vA, UnityEngine.Vector3 vB, float t, UnityEngine.Vector3 up)
        {
            float val_1;
            float val_12;
            float val_13;
            float val_14;
            float val_15;
            val_12 = t;
            val_13 = vA.y;
            val_14 = vA.z;
            if((vA.x >= 0) && (vA.x >= 0))
            {
                    UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = vA.x, y = val_13, z = val_14}, d:  vA.x);
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = vB.x, y = vB.y, z = vB.z}, d:  vA.x);
                UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, upwards:  new UnityEngine.Vector3() {x = up.x, y = val_1, z = up.y});
                val_13 = val_4.y;
                UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, upwards:  new UnityEngine.Vector3() {x = up.x, y = val_1, z = up.y});
                val_12 = val_12;
                UnityEngine.Quaternion val_6 = Cinemachine.Utility.UnityQuaternionExtensions.SlerpWithReferenceUp(qA:  new UnityEngine.Quaternion() {x = val_4.x, y = val_13, z = val_4.z, w = val_4.w}, qB:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w}, t:  val_12, up:  new UnityEngine.Vector3() {x = up.x, y = up.y});
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.forward;
                UnityEngine.Vector3 val_8 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w}, point:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
                val_14 = val_8.x;
                val_15 = val_8.z;
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14, y = val_8.y, z = val_15}, d:  UnityEngine.Mathf.Lerp(a:  vA.x, b:  vA.x, t:  val_12));
                return new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            }
            
            val_15 = vB.y;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = vA.x, y = val_13, z = val_14}, b:  new UnityEngine.Vector3() {x = vB.x, y = val_15, z = vB.z}, t:  val_12);
            return new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        }
    
    }

}

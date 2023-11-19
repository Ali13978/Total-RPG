using UnityEngine;

namespace TzarGames.Common
{
    public class Math3D
    {
        // Fields
        private static UnityEngine.Transform tempChild;
        private static UnityEngine.Transform tempParent;
        private static UnityEngine.Vector3[] positionRegister;
        private static float[] posTimeRegister;
        private static int positionSamplesTaken;
        private static UnityEngine.Quaternion[] rotationRegister;
        private static float[] rotTimeRegister;
        private static int rotationSamplesTaken;
        
        // Methods
        public Math3D()
        {
        
        }
        public static void Init()
        {
            var val_9;
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  "Math3d_TempChild");
            val_9 = null;
            val_9 = null;
            TzarGames.Common.Math3D.tempChild = transform;
            UnityEngine.GameObject val_3 = new UnityEngine.GameObject(name:  "Math3d_TempParent");
            TzarGames.Common.Math3D.tempParent = transform;
            TzarGames.Common.Math3D.tempChild.gameObject.hideFlags = 61;
            UnityEngine.GameObject val_6 = TzarGames.Common.Math3D.tempChild.gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  0);
            TzarGames.Common.Math3D.tempParent.gameObject.hideFlags = 61;
            UnityEngine.GameObject val_8 = TzarGames.Common.Math3D.tempParent.gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  0);
            TzarGames.Common.Math3D.tempChild.parent = TzarGames.Common.Math3D.tempParent;
        }
        public static UnityEngine.Vector3 AddVectorLength(UnityEngine.Vector3 vector, float size)
        {
            float val_2 = vector.y;
            float val_1 = UnityEngine.Vector3.Magnitude(vector:  new UnityEngine.Vector3() {x = vector.x, y = val_2, z = vector.z});
            val_2 = val_1 + size;
            size = val_2 / val_1;
            return UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = vector.x, y = vector.y, z = vector.z}, d:  size);
        }
        public static UnityEngine.Vector3 SetVectorLength(UnityEngine.Vector3 vector, float size)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.Normalize(value:  new UnityEngine.Vector3() {x = vector.x, y = vector.y, z = vector.z});
            return UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  size);
        }
        public static UnityEngine.Quaternion SubtractRotation(UnityEngine.Quaternion B, UnityEngine.Quaternion A)
        {
            UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = A.x, y = A.y, z = A.z, w = A.w});
            return UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w}, rhs:  new UnityEngine.Quaternion() {x = B.x, y = B.y, z = B.z, w = B.w});
        }
        public static UnityEngine.Quaternion AddRotation(UnityEngine.Quaternion A, UnityEngine.Quaternion B)
        {
            return UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = A.x, y = A.y, z = A.z, w = A.w}, rhs:  new UnityEngine.Quaternion() {x = B.x, y = B.y, z = B.z, w = B.w});
        }
        public static UnityEngine.Vector3 TransformDirectionMath(UnityEngine.Quaternion rotation, UnityEngine.Vector3 vector)
        {
            return UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w}, point:  new UnityEngine.Vector3() {x = vector.x, y = vector.y, z = vector.z});
        }
        public static UnityEngine.Vector3 InverseTransformDirectionMath(UnityEngine.Quaternion rotation, UnityEngine.Vector3 vector)
        {
            UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w});
            return UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w}, point:  new UnityEngine.Vector3() {x = vector.x, y = vector.y, z = vector.z});
        }
        public static UnityEngine.Vector3 RotateVectorFromTo(UnityEngine.Quaternion from, UnityEngine.Quaternion to, UnityEngine.Vector3 vector)
        {
            float val_1;
            UnityEngine.Quaternion val_2 = TzarGames.Common.Math3D.SubtractRotation(B:  new UnityEngine.Quaternion() {x = to.x, y = to.y, z = to.z, w = to.w}, A:  new UnityEngine.Quaternion() {x = from.x, y = from.y, z = from.z, w = from.w});
            UnityEngine.Vector3 val_3 = TzarGames.Common.Math3D.InverseTransformDirectionMath(rotation:  new UnityEngine.Quaternion() {x = from.x, y = from.y, z = from.z, w = from.w}, vector:  new UnityEngine.Vector3() {x = vector.x, y = val_1, z = vector.y});
            UnityEngine.Vector3 val_4 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w}, point:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            return TzarGames.Common.Math3D.TransformDirectionMath(rotation:  new UnityEngine.Quaternion() {x = from.x, y = from.y, z = from.z, w = from.w}, vector:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        }
        public static bool PlanePlaneIntersection(out UnityEngine.Vector3 linePoint, out UnityEngine.Vector3 lineVec, UnityEngine.Vector3 plane1Normal, UnityEngine.Vector3 plane1Position, UnityEngine.Vector3 plane2Normal, UnityEngine.Vector3 plane2Position)
        {
            float val_1;
            float val_7;
            float val_12;
            var val_13;
            val_12 = plane1Normal.z;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            lineVec.x = val_2.x;
            lineVec.y = val_2.y;
            lineVec.z = val_2.z;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            mem2[0] = val_3.x;
            mem2[0] = val_3.y;
            mem2[0] = val_3.z;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = plane1Normal.x, y = plane1Normal.y, z = val_12}, rhs:  new UnityEngine.Vector3() {x = plane2Normal.x, y = val_1, z = plane2Normal.y});
            mem2[0] = val_4.x;
            mem2[0] = val_4.y;
            mem2[0] = val_4.z;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = plane2Normal.x, y = val_1, z = plane2Normal.y}, rhs:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            float val_6 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = plane1Normal.x, y = plane1Normal.y, z = val_12}, rhs:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            if(System.Math.Abs(val_6) > 0.006f)
            {
                    val_12 = plane2Position.x;
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = plane1Position.x, y = plane1Position.y, z = plane1Position.z}, b:  new UnityEngine.Vector3() {x = plane2Normal.z, y = val_7, z = val_12});
                float val_9 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = plane1Normal.x, y = plane1Normal.y, z = val_12}, rhs:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
                val_9 = val_9 / val_6;
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(d:  val_9, a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = plane2Normal.z, y = val_7, z = val_12}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
                val_13 = 1;
                lineVec.x = val_11.x;
                lineVec.y = val_11.y;
                lineVec.z = val_11.z;
                return (bool)val_13;
            }
            
            val_13 = 0;
            return (bool)val_13;
        }
        public static bool LinePlaneIntersection(out UnityEngine.Vector3 intersection, UnityEngine.Vector3 linePoint, UnityEngine.Vector3 lineVec, UnityEngine.Vector3 planeNormal, UnityEngine.Vector3 planePoint)
        {
            float val_1;
            float val_2;
            float val_9;
            float val_10;
            var val_11;
            val_9 = planeNormal.x;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            mem2[0] = val_3.x;
            mem2[0] = val_3.y;
            mem2[0] = val_3.z;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = planeNormal.z, y = val_1, z = planePoint.x}, b:  new UnityEngine.Vector3() {x = linePoint.x, y = linePoint.y, z = linePoint.z});
            val_10 = lineVec.z;
            float val_6 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = lineVec.x, y = lineVec.y, z = val_10}, rhs:  new UnityEngine.Vector3() {x = val_9, y = val_2, z = planeNormal.y});
            if(val_6 != 0f)
            {
                    val_9 = (UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, rhs:  new UnityEngine.Vector3() {x = val_9, y = val_2, z = planeNormal.y})) / val_6;
                UnityEngine.Vector3 val_7 = TzarGames.Common.Math3D.SetVectorLength(vector:  new UnityEngine.Vector3() {x = lineVec.x, y = lineVec.y, z = val_10}, size:  val_9);
                val_9 = val_7.x;
                val_10 = val_7.z;
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = linePoint.x, y = linePoint.y, z = linePoint.z}, b:  new UnityEngine.Vector3() {x = val_9, y = val_7.y, z = val_10});
                val_11 = 1;
                mem2[0] = val_8.x;
                mem2[0] = val_8.y;
                mem2[0] = val_8.z;
                return (bool)val_11;
            }
            
            val_11 = 0;
            return (bool)val_11;
        }
        public static bool LineLineIntersection(out UnityEngine.Vector3 intersection, UnityEngine.Vector3 linePoint1, UnityEngine.Vector3 lineVec1, UnityEngine.Vector3 linePoint2, UnityEngine.Vector3 lineVec2)
        {
            float val_1;
            float val_2;
            float val_11;
            float val_12;
            var val_13;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = linePoint2.x, y = val_2, z = linePoint2.y}, b:  new UnityEngine.Vector3() {x = linePoint1.x, y = linePoint1.y, z = linePoint1.z});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = lineVec1.x, y = lineVec1.y, z = lineVec1.z}, rhs:  new UnityEngine.Vector3() {x = linePoint2.z, y = val_1, z = lineVec2.x});
            val_11 = val_3.z;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_11}, rhs:  new UnityEngine.Vector3() {x = linePoint2.z, y = val_1, z = lineVec2.x});
            val_12 = 0.0001f;
            float val_11 = System.Math.Abs(UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_11}, rhs:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}));
            if((val_11 < 0) && (val_11 > val_12))
            {
                    val_11 = val_4.y;
                float val_12 = val_4.x;
                float val_7 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, rhs:  new UnityEngine.Vector3() {x = val_12, y = val_11, z = val_4.z});
                val_12 = val_7;
                val_12 = val_12 / val_7;
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = lineVec1.x, y = lineVec1.y, z = lineVec1.z}, d:  val_12);
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = linePoint1.x, y = linePoint1.y, z = linePoint1.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
                mem2[0] = val_9.x;
                mem2[0] = val_9.y;
                mem2[0] = val_9.z;
                val_13 = 1;
                return (bool)val_13;
            }
            
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            val_13 = 0;
            mem2[0] = val_10.x;
            mem2[0] = val_10.y;
            mem2[0] = val_10.z;
            return (bool)val_13;
        }
        public static bool ClosestPointsOnTwoLines(out UnityEngine.Vector3 closestPointLine1, out UnityEngine.Vector3 closestPointLine2, UnityEngine.Vector3 linePoint1, UnityEngine.Vector3 lineVec1, UnityEngine.Vector3 linePoint2, UnityEngine.Vector3 lineVec2)
        {
            float val_1;
            float val_8;
            float val_18;
            float val_19;
            float val_20;
            float val_21;
            float val_22;
            var val_23;
            val_18 = lineVec1.z;
            val_19 = linePoint1.z;
            float val_19 = val_1;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            closestPointLine2.x = val_2.x;
            closestPointLine2.y = val_2.y;
            closestPointLine2.z = val_2.z;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            mem2[0] = val_3.x;
            mem2[0] = val_3.y;
            mem2[0] = val_3.z;
            val_20 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = lineVec1.x, y = lineVec1.y, z = val_18}, rhs:  new UnityEngine.Vector3() {x = lineVec1.x, y = lineVec1.y, z = val_18});
            float val_22 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = lineVec1.x, y = lineVec1.y, z = val_18}, rhs:  new UnityEngine.Vector3() {x = linePoint2.z, y = val_19, z = lineVec2.x});
            float val_18 = lineVec2.x;
            float val_6 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = linePoint2.z, y = val_19, z = val_18}, rhs:  new UnityEngine.Vector3() {x = linePoint2.z, y = val_19, z = lineVec2.x});
            val_18 = val_20 * val_6;
            val_19 = val_18 - (val_22 * val_22);
            if(val_19 != 0f)
            {
                    val_21 = val_8;
                val_22 = linePoint2.x;
                val_21 = val_21;
                val_22 = val_22;
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = linePoint1.x, y = linePoint1.y, z = val_19}, b:  new UnityEngine.Vector3() {x = val_22, y = val_21, z = linePoint2.y});
                val_19 = val_9.x;
                val_20 = val_9.y;
                val_18 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = lineVec1.x, y = lineVec1.y, z = val_18}, rhs:  new UnityEngine.Vector3() {x = val_19, y = val_20, z = val_9.z});
                float val_20 = val_19;
                float val_11 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = linePoint2.z, y = val_20, z = lineVec2.x}, rhs:  new UnityEngine.Vector3() {x = val_19, y = val_20, z = val_9.z});
                float val_21 = val_6;
                val_20 = val_22 * val_11;
                val_21 = val_21 * val_18;
                val_20 = val_20 - val_21;
                val_11 = val_20 * val_11;
                val_11 = val_11 - (val_22 * val_18);
                val_22 = val_11 / val_19;
                UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = lineVec1.x, y = lineVec1.y, z = val_18}, d:  val_20 / val_19);
                UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = linePoint1.x, y = linePoint1.y, z = val_19}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
                closestPointLine2.x = val_15.x;
                closestPointLine2.y = val_15.y;
                closestPointLine2.z = val_15.z;
                UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = linePoint2.z, y = val_19, z = lineVec2.x}, d:  val_22);
                UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_22, y = val_21, z = linePoint2.y}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
                val_23 = 1;
                mem2[0] = val_17.x;
                mem2[0] = val_17.y;
                mem2[0] = val_17.z;
                return (bool)val_23;
            }
            
            val_23 = 0;
            return (bool)val_23;
        }
        public static UnityEngine.Vector3 ProjectPointOnLine(UnityEngine.Vector3 linePoint, UnityEngine.Vector3 lineVec, UnityEngine.Vector3 point)
        {
            float val_1;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = point.x, y = val_1, z = point.y}, b:  new UnityEngine.Vector3() {x = linePoint.x, y = linePoint.y, z = linePoint.z});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = lineVec.x, y = lineVec.y, z = lineVec.z}, d:  UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = lineVec.x, y = lineVec.y, z = lineVec.z}));
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = linePoint.x, y = linePoint.y, z = linePoint.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        }
        public static UnityEngine.Vector3 ProjectPointOnLineSegment(UnityEngine.Vector3 linePoint1, UnityEngine.Vector3 linePoint2, UnityEngine.Vector3 point)
        {
            float val_9;
            float val_10;
            float val_11;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = linePoint2.x, y = linePoint2.y, z = linePoint2.z}, b:  new UnityEngine.Vector3() {x = linePoint1.x, y = linePoint1.y, z = linePoint1.z});
            UnityEngine.Vector3 val_3 = TzarGames.Common.Math3D.ProjectPointOnLine(linePoint:  new UnityEngine.Vector3() {x = linePoint1.x, y = linePoint1.y, z = linePoint1.z}, lineVec:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, point:  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.y});
            val_9 = val_3.y;
            val_10 = val_3.z;
            val_11 = val_3.x;
            int val_4 = TzarGames.Common.Math3D.PointOnWhichSideOfLineSegment(linePoint1:  new UnityEngine.Vector3() {x = linePoint1.x, y = linePoint1.y, z = linePoint1.z}, linePoint2:  new UnityEngine.Vector3() {x = linePoint2.x, y = linePoint2.y, z = linePoint2.z}, point:  new UnityEngine.Vector3() {x = val_11, y = val_10, z = point.y});
            if(val_4 == 0)
            {
                    return new UnityEngine.Vector3() {x = val_11, y = val_9, z = val_10};
            }
            
            if(val_4 == 1)
            {
                    val_11 = linePoint1.x;
                val_9 = linePoint1.y;
                val_10 = linePoint1.z;
                return new UnityEngine.Vector3() {x = val_11, y = val_9, z = val_10};
            }
            
            if(val_4 == 2)
            {
                    val_11 = linePoint2.x;
                val_9 = linePoint2.y;
                val_10 = linePoint2.z;
                return new UnityEngine.Vector3() {x = val_11, y = val_9, z = val_10};
            }
            
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            val_11 = val_5.x;
            val_9 = val_5.y;
            val_10 = val_5.z;
            return new UnityEngine.Vector3() {x = val_11, y = val_9, z = val_10};
        }
        public static UnityEngine.Vector3 ProjectPointOnPlane(UnityEngine.Vector3 planeNormal, UnityEngine.Vector3 planePoint, UnityEngine.Vector3 point)
        {
            float val_1;
            float val_4;
            float val_5;
            float val_6;
            float val_7;
            val_4 = val_1;
            val_5 = point.y;
            val_6 = point.x;
            val_7 = planePoint.z;
            val_5 = val_5;
            val_4 = val_4;
            val_6 = val_6;
            val_7 = val_7;
            val_5 = val_5;
            val_4 = val_4;
            val_6 = val_6;
            UnityEngine.Vector3 val_3 = TzarGames.Common.Math3D.SetVectorLength(vector:  new UnityEngine.Vector3() {x = planeNormal.x, y = planeNormal.y, z = planeNormal.z}, size:  -(TzarGames.Common.Math3D.SignedDistancePlanePoint(planeNormal:  new UnityEngine.Vector3() {x = planeNormal.x, y = planeNormal.y, z = planeNormal.z}, planePoint:  new UnityEngine.Vector3() {x = planePoint.x, y = planePoint.y, z = val_7}, point:  new UnityEngine.Vector3() {x = val_6, y = val_5, z = ???})));
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6, y = val_4, z = val_5}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        }
        public static UnityEngine.Vector3 ProjectVectorOnPlane(UnityEngine.Vector3 planeNormal, UnityEngine.Vector3 vector)
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(d:  UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = vector.x, y = vector.y, z = vector.z}, rhs:  new UnityEngine.Vector3() {x = planeNormal.x, y = planeNormal.y, z = planeNormal.z}), a:  new UnityEngine.Vector3() {x = planeNormal.x, y = planeNormal.y, z = planeNormal.z});
            return UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = vector.x, y = vector.y, z = vector.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        public static float SignedDistancePlanePoint(UnityEngine.Vector3 planeNormal, UnityEngine.Vector3 planePoint, UnityEngine.Vector3 point)
        {
            float val_1;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = point.x, y = val_1, z = point.y}, b:  new UnityEngine.Vector3() {x = planePoint.x, y = planePoint.y, z = planePoint.z});
            return UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = planeNormal.x, y = planeNormal.y, z = planeNormal.z}, rhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        public static float SignedDotProduct(UnityEngine.Vector3 vectorA, UnityEngine.Vector3 vectorB, UnityEngine.Vector3 normal)
        {
            float val_1;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = normal.x, y = val_1, z = normal.y}, rhs:  new UnityEngine.Vector3() {x = vectorA.x, y = vectorA.y, z = vectorA.z});
            return UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = vectorB.x, y = vectorB.y, z = vectorB.z});
        }
        public static float SignedVectorAngle(UnityEngine.Vector3 referenceVector, UnityEngine.Vector3 otherVector, UnityEngine.Vector3 normal)
        {
            float val_1;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = normal.x, y = val_1, z = normal.y}, rhs:  new UnityEngine.Vector3() {x = referenceVector.x, y = referenceVector.y, z = referenceVector.z});
            float val_5 = UnityEngine.Mathf.Sign(f:  UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = otherVector.x, y = otherVector.y, z = otherVector.z}));
            val_5 = (UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = referenceVector.x, y = referenceVector.y, z = referenceVector.z}, to:  new UnityEngine.Vector3() {x = otherVector.x, y = otherVector.y, z = otherVector.z})) * val_5;
            return (float)val_5;
        }
        public static float AngleVectorPlane(UnityEngine.Vector3 vector, UnityEngine.Vector3 normal)
        {
            float val_2 = (float)(double)UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = vector.x, y = vector.y, z = vector.z}, rhs:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z});
            val_2 = 1.570796f - val_2;
            return (float)val_2;
        }
        public static float DotProductAngle(UnityEngine.Vector3 vec1, UnityEngine.Vector3 vec2)
        {
            return (float)(float)(double)UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = vec1.x, y = vec1.y, z = vec1.z}, rhs:  new UnityEngine.Vector3() {x = vec2.x, y = vec2.y, z = vec2.z});
        }
        public static void PlaneFrom3Points(out UnityEngine.Vector3 planeNormal, out UnityEngine.Vector3 planePoint, UnityEngine.Vector3 pointA, UnityEngine.Vector3 pointB, UnityEngine.Vector3 pointC)
        {
            float val_1;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            planePoint.x = val_2.x;
            planePoint.y = val_2.y;
            planePoint.z = val_2.z;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            mem2[0] = val_3.x;
            mem2[0] = val_3.y;
            mem2[0] = val_3.z;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = pointB.x, y = pointB.y, z = pointB.z}, b:  new UnityEngine.Vector3() {x = pointA.x, y = pointA.y, z = pointA.z});
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = pointC.x, y = val_1, z = pointC.y}, b:  new UnityEngine.Vector3() {x = pointA.x, y = pointA.y, z = pointA.z});
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, rhs:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.Normalize(value:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            planePoint.x = val_7.x;
            planePoint.y = val_7.y;
            planePoint.z = val_7.z;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  2f);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = pointA.x, y = pointA.y, z = pointA.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  2f);
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = pointA.x, y = pointA.y, z = pointA.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = pointC.x, y = val_1, z = pointC.y}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = pointB.x, y = pointB.y, z = pointB.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            bool val_14 = TzarGames.Common.Math3D.ClosestPointsOnTwoLines(closestPointLine1: out  new UnityEngine.Vector3(), closestPointLine2: out  new UnityEngine.Vector3() {x = X2, y = X2, z = X2}, linePoint1:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, lineVec1:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, linePoint2:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.z, z = val_13.x}, lineVec2:  new UnityEngine.Vector3() {x = val_13.z, y = val_5.y, z = val_12.z});
        }
        public static UnityEngine.Vector3 GetForwardVector(UnityEngine.Quaternion q)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.forward;
            return UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = q.x, y = q.y, z = q.z, w = q.w}, point:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
        public static UnityEngine.Vector3 GetUpVector(UnityEngine.Quaternion q)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.up;
            return UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = q.x, y = q.y, z = q.z, w = q.w}, point:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
        public static UnityEngine.Vector3 GetRightVector(UnityEngine.Quaternion q)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.right;
            return UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = q.x, y = q.y, z = q.z, w = q.w}, point:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
        public static UnityEngine.Quaternion QuaternionFromMatrix(UnityEngine.Matrix4x4 m)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector4() {x = V0.16B, y = V1.16B, z = V2.16B, w = V3.16B});
            UnityEngine.Vector3 val_2 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector4() {x = val_1.x, y = val_1.y, z = val_1.z, w = V3.16B});
            return UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, upwards:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        public static UnityEngine.Vector3 PositionFromMatrix(UnityEngine.Matrix4x4 m)
        {
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public static void LookRotationExtended(ref UnityEngine.GameObject gameObjectInOut, UnityEngine.Vector3 alignWithVector, UnityEngine.Vector3 alignWithNormal, UnityEngine.Vector3 customForward, UnityEngine.Vector3 customUp)
        {
            float val_1;
            float val_2;
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = alignWithVector.x, y = alignWithVector.y, z = alignWithVector.z}, upwards:  new UnityEngine.Vector3() {x = alignWithNormal.x, y = alignWithNormal.y, z = alignWithNormal.z});
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = customForward.x, y = val_2, z = customForward.y}, upwards:  new UnityEngine.Vector3() {x = customForward.z, y = val_1, z = customUp.x});
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w});
            UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}, rhs:  new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w});
            X1.transform.rotation = new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w};
        }
        public static void TransformWithParent(out UnityEngine.Quaternion childRotation, out UnityEngine.Vector3 childPosition, UnityEngine.Quaternion parentRotation, UnityEngine.Vector3 parentPosition, UnityEngine.Quaternion startParentRotation, UnityEngine.Vector3 startParentPosition, UnityEngine.Quaternion startChildRotation, UnityEngine.Vector3 startChildPosition)
        {
            float val_3;
            float val_4;
            float val_5;
            float val_7;
            float val_8;
            float val_9;
            var val_13;
            UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
            childPosition.x = val_1.x;
            childPosition.y = val_1.y;
            childPosition.z = val_1.z;
            mem[1152921511135507548] = val_1.w;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            mem2[0] = val_2.x;
            mem2[0] = val_2.y;
            mem2[0] = val_2.z;
            val_13 = null;
            val_13 = null;
            TzarGames.Common.Math3D.tempParent.rotation = new UnityEngine.Quaternion() {x = startParentRotation.x, y = val_4, z = startParentRotation.y, w = val_3};
            TzarGames.Common.Math3D.tempParent.position = new UnityEngine.Vector3() {x = startParentRotation.z, y = val_5, z = startParentRotation.w};
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
            TzarGames.Common.Math3D.tempParent.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            TzarGames.Common.Math3D.tempChild.rotation = new UnityEngine.Quaternion() {x = startParentPosition.x, y = val_8, z = startParentPosition.y, w = val_7};
            TzarGames.Common.Math3D.tempChild.position = new UnityEngine.Vector3() {x = startParentPosition.z, y = val_9, z = startChildRotation.x};
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
            TzarGames.Common.Math3D.tempChild.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            TzarGames.Common.Math3D.tempParent.rotation = new UnityEngine.Quaternion() {x = parentRotation.x, y = parentRotation.y, z = parentRotation.z, w = parentRotation.w};
            TzarGames.Common.Math3D.tempParent.position = new UnityEngine.Vector3() {x = parentPosition.x, y = parentPosition.y, z = parentPosition.z};
            UnityEngine.Quaternion val_11 = TzarGames.Common.Math3D.tempChild.rotation;
            childPosition.x = val_11.x;
            childPosition.y = val_11.y;
            childPosition.z = val_11.z;
            mem[1152921511135507548] = val_11.w;
            UnityEngine.Vector3 val_12 = TzarGames.Common.Math3D.tempChild.position;
            mem2[0] = val_12.x;
            mem2[0] = val_12.y;
            mem2[0] = val_12.z;
        }
        public static void PreciseAlign(ref UnityEngine.GameObject gameObjectInOut, UnityEngine.Vector3 alignWithVector, UnityEngine.Vector3 alignWithNormal, UnityEngine.Vector3 alignWithPosition, UnityEngine.Vector3 triangleForward, UnityEngine.Vector3 triangleNormal, UnityEngine.Vector3 trianglePosition)
        {
            float val_1;
            var val_2;
            float val_4;
            float val_10;
            float val_11;
            float val_12;
            float val_13;
            float val_14;
            float val_15;
            val_11 = val_2;
            val_10 = triangleForward.z;
            val_12 = triangleForward.y;
            val_13 = alignWithNormal.x;
            val_14 = alignWithVector.y;
            val_12 = val_12;
            val_10 = val_10;
            val_11 = val_11;
            val_15 = val_14;
            val_13 = val_13;
            val_14 = val_15;
            val_12 = val_12;
            val_10 = val_10;
            val_11 = val_11;
            val_15 = val_14;
            TzarGames.Common.Math3D.LookRotationExtended(gameObjectInOut: ref  null, alignWithVector:  new UnityEngine.Vector3() {x = alignWithVector.x, y = val_15, z = alignWithVector.z}, alignWithNormal:  new UnityEngine.Vector3() {x = val_13, y = alignWithNormal.y, z = alignWithNormal.z}, customForward:  new UnityEngine.Vector3() {x = alignWithPosition.z, y = triangleForward.x, z = val_12}, customUp:  new UnityEngine.Vector3() {x = val_10, z = alignWithNormal.z});
            UnityEngine.Vector3 val_7 = X1.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = triangleNormal.x, y = val_1, z = triangleNormal.y});
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = alignWithPosition.x, y = val_4, z = alignWithPosition.y}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            X1.transform.Translate(translation:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, relativeTo:  0);
        }
        public static void VectorsToTransform(ref UnityEngine.GameObject gameObjectInOut, UnityEngine.Vector3 positionVector, UnityEngine.Vector3 directionVector, UnityEngine.Vector3 normalVector)
        {
            float val_1;
            X1.transform.position = new UnityEngine.Vector3() {x = positionVector.x, y = positionVector.y, z = positionVector.z};
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = directionVector.x, y = directionVector.y, z = directionVector.z}, upwards:  new UnityEngine.Vector3() {x = normalVector.x, y = val_1, z = normalVector.y});
            X1.transform.rotation = new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w};
        }
        public static int PointOnWhichSideOfLineSegment(UnityEngine.Vector3 linePoint1, UnityEngine.Vector3 linePoint2, UnityEngine.Vector3 point)
        {
            float val_1;
            float val_7;
            var val_8;
            val_7 = linePoint1.z;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = linePoint2.x, y = linePoint2.y, z = linePoint2.z}, b:  new UnityEngine.Vector3() {x = linePoint1.x, y = linePoint1.y, z = val_7});
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = point.x, y = val_1, z = point.y}, b:  new UnityEngine.Vector3() {x = linePoint1.x, y = linePoint1.y, z = val_7});
            float val_4 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, rhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            if(val_4 > 0f)
            {
                    val_7 = val_4;
                val_8 = ((val_7 > val_4) ? 1 : 0) << 1;
                return (int)val_8;
            }
            
            val_8 = 1;
            return (int)val_8;
        }
        public static float MouseDistanceToLine(UnityEngine.Vector3 linePoint1, UnityEngine.Vector3 linePoint2)
        {
            UnityEngine.Camera val_1 = UnityEngine.Camera.main;
            UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
            UnityEngine.Vector3 val_3 = val_1.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = linePoint1.x, y = linePoint1.y, z = linePoint1.z});
            UnityEngine.Vector3 val_4 = val_1.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = linePoint2.x, y = linePoint2.y, z = linePoint2.z});
            UnityEngine.Vector3 val_5 = TzarGames.Common.Math3D.ProjectPointOnLineSegment(linePoint1:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, linePoint2:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, point:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.z, z = 0f});
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            return (float)val_6.x;
        }
        public static float MouseDistanceToCircle(UnityEngine.Vector3 point, float radius)
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
            UnityEngine.Vector3 val_3 = UnityEngine.Camera.main.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            val_4.x = val_4.x - radius;
            return (float)val_4.x;
        }
        public static bool IsLineInRectangle(UnityEngine.Vector3 linePoint1, UnityEngine.Vector3 linePoint2, UnityEngine.Vector3 rectA, UnityEngine.Vector3 rectB, UnityEngine.Vector3 rectC, UnityEngine.Vector3 rectD)
        {
            var val_1;
            var val_3;
            float val_4;
            float val_15;
            var val_16;
            float val_17;
            float val_18;
            float val_19;
            var val_20;
            float val_21;
            float val_22;
            float val_23;
            float val_24;
            float val_25;
            float val_26;
            var val_27;
            val_16 = val_1;
            val_15 = rectC.y;
            val_17 = rectB.z;
            val_18 = val_3;
            val_19 = rectB.x;
            val_20 = 1152921504896143360;
            val_21 = rectC.x;
            val_22 = rectB.y;
            val_23 = rectA.z;
            val_24 = val_4;
            val_23 = val_23;
            val_17 = val_17;
            val_22 = val_22;
            val_19 = val_19;
            val_18 = val_18;
            val_15 = val_15;
            val_16 = val_16;
            val_21 = val_21;
            val_25 = val_17;
            val_26 = val_18;
            if((TzarGames.Common.Math3D.IsPointInRectangle(point:  new UnityEngine.Vector3() {x = linePoint1.x, y = linePoint1.y, z = linePoint1.z}, rectA:  new UnityEngine.Vector3() {x = rectA.x, y = val_24, z = rectA.y}, rectC:  new UnityEngine.Vector3() {x = val_22, y = val_17, z = val_23}, rectB:  new UnityEngine.Vector3() {x = val_19, y = val_21, z = val_15}, rectD:  new UnityEngine.Vector3())) == true)
            {
                goto label_3;
            }
            
            val_19 = val_22;
            val_26 = val_15;
            val_25 = val_26;
            if((TzarGames.Common.Math3D.IsPointInRectangle(point:  new UnityEngine.Vector3() {x = linePoint2.x, y = linePoint2.y, z = linePoint2.z}, rectA:  new UnityEngine.Vector3() {x = rectA.x, y = val_24, z = rectA.y}, rectC:  new UnityEngine.Vector3() {x = val_19, y = val_25, z = val_23}, rectB:  new UnityEngine.Vector3() {x = val_19, y = val_21, z = val_26}, rectD:  new UnityEngine.Vector3())) == false)
            {
                goto label_6;
            }
            
            label_3:
            val_27 = 1;
            return (bool)val_27;
            label_6:
            val_24 = linePoint2.y;
            val_19 = val_16;
            val_26 = linePoint1.y;
            val_25 = linePoint2.x;
            val_20 = TzarGames.Common.Math3D.AreLineSegmentsCrossing(pointA1:  new UnityEngine.Vector3() {x = linePoint1.x, y = val_26, z = linePoint1.z}, pointA2:  new UnityEngine.Vector3() {x = val_25, y = val_24, z = linePoint2.z}, pointB1:  new UnityEngine.Vector3() {x = val_22, y = val_25, z = val_21}, pointB2:  new UnityEngine.Vector3() {x = val_15, y = val_21, z = val_26});
            bool val_14 = ((TzarGames.Common.Math3D.AreLineSegmentsCrossing(pointA1:  new UnityEngine.Vector3() {x = linePoint1.x, y = linePoint1.y, z = linePoint1.z}, pointA2:  new UnityEngine.Vector3() {x = linePoint2.x, y = linePoint2.y, z = linePoint2.z}, pointB1:  new UnityEngine.Vector3() {x = rectA.x, y = rectA.y, z = val_23}, pointB2:  new UnityEngine.Vector3() {x = val_19, y = val_21, z = val_26})) | (TzarGames.Common.Math3D.AreLineSegmentsCrossing(pointA1:  new UnityEngine.Vector3() {x = linePoint1.x, y = linePoint1.y, z = linePoint1.z}, pointA2:  new UnityEngine.Vector3() {x = linePoint2.x, y = val_24, z = linePoint2.z}, pointB1:  new UnityEngine.Vector3() {x = val_23, y = val_19, z = val_22}, pointB2:  new UnityEngine.Vector3() {x = val_25, y = val_21, z = val_26}))) | val_20;
            val_14 = val_14 | (TzarGames.Common.Math3D.AreLineSegmentsCrossing(pointA1:  new UnityEngine.Vector3() {x = linePoint1.x, y = val_26, z = linePoint1.z}, pointA2:  new UnityEngine.Vector3() {x = val_25, y = val_24, z = linePoint2.z}, pointB1:  new UnityEngine.Vector3() {x = val_21, y = val_15, z = rectA.x}, pointB2:  new UnityEngine.Vector3() {x = rectA.y, y = val_21, z = val_26}));
            val_27 = val_14;
            return (bool)val_27;
        }
        public static bool IsPointInRectangle(UnityEngine.Vector3 point, UnityEngine.Vector3 rectA, UnityEngine.Vector3 rectC, UnityEngine.Vector3 rectB, UnityEngine.Vector3 rectD)
        {
            float val_1;
            float val_2;
            float val_3;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = rectC.x, y = val_1, z = rectC.y}, b:  new UnityEngine.Vector3() {x = rectA.x, y = rectA.y, z = rectA.z});
            UnityEngine.Vector3 val_6 = TzarGames.Common.Math3D.AddVectorLength(vector:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, size:  val_4.x * (-0.5f));
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = rectA.x, y = rectA.y, z = rectA.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = rectC.z, y = val_3, z = rectB.x}, b:  new UnityEngine.Vector3() {x = rectA.x, y = rectA.y, z = rectA.z});
            val_8.x = val_8.x * 0.5f;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = rectB.y, y = val_2, z = rectB.z}, b:  new UnityEngine.Vector3() {x = rectA.x, y = rectA.y, z = rectA.z});
            UnityEngine.Vector3 val_10 = TzarGames.Common.Math3D.ProjectPointOnLine(linePoint:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, lineVec:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, point:  new UnityEngine.Vector3() {x = point.x, y = point.z, z = val_3});
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z});
            UnityEngine.Vector3 val_12 = TzarGames.Common.Math3D.ProjectPointOnLine(linePoint:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, lineVec:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, point:  new UnityEngine.Vector3() {x = point.x, y = point.z, z = val_3});
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z});
            float val_17 = 0.5f;
            val_17 = val_9.x * val_17;
            return (bool)((val_13.x <= val_8.x) ? 1 : 0) & ((val_11.x <= val_17) ? 1 : 0);
        }
        public static bool AreLineSegmentsCrossing(UnityEngine.Vector3 pointA1, UnityEngine.Vector3 pointA2, UnityEngine.Vector3 pointB1, UnityEngine.Vector3 pointB2)
        {
            float val_1;
            float val_2;
            float val_10;
            float val_11;
            float val_12;
            float val_13;
            var val_14;
            float val_15;
            var val_16;
            val_10 = pointA1.y;
            val_11 = pointA1.x;
            val_11 = val_11;
            val_10 = val_10;
            val_11 = val_11;
            val_10 = val_10;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = pointA2.x, y = pointA2.y, z = pointA2.z}, b:  new UnityEngine.Vector3() {x = val_11, y = val_10, z = pointA1.z});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = pointB1.z, y = val_1, z = pointB2.x}, b:  new UnityEngine.Vector3() {x = pointB1.x, y = val_2, z = pointB1.y});
            val_12 = val_4.x;
            val_13 = val_4.y;
            val_14 = 1152921504896143360;
            val_15 = val_10;
            if((TzarGames.Common.Math3D.ClosestPointsOnTwoLines(closestPointLine1: out  new UnityEngine.Vector3(), closestPointLine2: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, linePoint1:  new UnityEngine.Vector3() {x = val_11, y = val_15, z = pointA1.z}, lineVec1:  new UnityEngine.Vector3() {x = val_12, y = val_13, z = val_4.z}, linePoint2:  new UnityEngine.Vector3() {x = pointB1.x, y = pointB1.y, z = val_4.x}, lineVec2:  new UnityEngine.Vector3() {x = val_4.z, z = pointA2.x})) != false)
            {
                    val_13 = val_11;
                val_15 = 0f;
                val_12 = 0f;
                val_14 = TzarGames.Common.Math3D.PointOnWhichSideOfLineSegment(linePoint1:  new UnityEngine.Vector3() {x = val_13, y = val_15, z = pointA1.z}, linePoint2:  new UnityEngine.Vector3() {x = pointA2.x, y = pointA2.y, z = pointA2.z}, point:  new UnityEngine.Vector3() {x = val_15, y = val_12, z = val_4.x});
                var val_9 = ((val_14 | (TzarGames.Common.Math3D.PointOnWhichSideOfLineSegment(linePoint1:  new UnityEngine.Vector3() {x = pointB1.x, y = val_2, z = pointB1.y}, linePoint2:  new UnityEngine.Vector3() {x = pointB1.z, y = val_1, z = pointB2.x}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = val_4.x}))) == 0) ? 1 : 0;
                return (bool)val_16;
            }
            
            val_16 = 0;
            return (bool)val_16;
        }
        public static bool LinearAcceleration(out UnityEngine.Vector3 vector, UnityEngine.Vector3 position, int samples)
        {
            float val_15;
            float val_16;
            float val_29;
            float val_30;
            float val_31;
            float val_32;
            var val_35;
            var val_37;
            var val_39;
            var val_40;
            var val_41;
            UnityEngine.Vector3[] val_42;
            float val_46;
            var val_47;
            var val_48;
            var val_49;
            var val_50;
            UnityEngine.Vector3[] val_51;
            System.Single[] val_52;
            var val_53;
            UnityEngine.Vector3[] val_54;
            val_29 = position.y;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_30 = val_1.x;
            val_31 = val_1.y;
            val_32 = val_1.z;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            mem2[0] = val_2.x;
            mem2[0] = val_2.y;
            mem2[0] = val_2.z;
            val_35 = null;
            val_35 = null;
            if(TzarGames.Common.Math3D.positionRegister == null)
            {
                goto label_5;
            }
            
            val_37 = 0;
            goto label_9;
            label_5:
            TzarGames.Common.Math3D.positionRegister = null;
            val_37 = 0;
            TzarGames.Common.Math3D.posTimeRegister = null;
            goto label_9;
            label_23:
            val_37 = 1;
            (TzarGames.Common.Math3D.__il2cppRuntimeField_static_fields + (W2 < 0x3 ? 3 : W2) << 2).__unknownFiledOffset_20 = ???;
            label_9:
            val_40 = null;
            val_40 = null;
            if(null == null)
            {
                    val_40 = null;
            }
            
            val_41 = null;
            UnityEngine.Vector3[] val_41 = TzarGames.Common.Math3D.positionRegister;
            val_42 = val_41;
            if(null == null)
            {
                    val_42 = TzarGames.Common.Math3D.positionRegister;
                if(null == null)
            {
                    val_42 = 0;
            }
            
            }
            
            var val_40 = 12;
            val_40 = val_41 + (1 * val_40);
            val_41 = val_40 + 32;
            var val_43 = (long)val_37 + 1;
            var val_42 = 12;
            val_42 = val_42 + (val_43 * val_42);
            mem2[0] = ((long)(int)((val_37 + 1)) * 12) + val_42 + 40;
            mem2[0] = ((long)(int)((val_37 + 1)) * 12) + val_42 + 32;
            System.Single[] val_9 = TzarGames.Common.Math3D.posTimeRegister + (((long)(int)((val_37 + 1))) << 2);
            val_43 = val_43 - 1;
            goto label_23;
            label_66:
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_30, y = val_32}, d:  V9.16B);
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = position.x, y = val_16, z = val_15});
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_31, y = position.z, z = val_29}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            val_48 = null;
            val_30 = val_18.x;
            val_31 = val_18.y;
            val_32 = val_18.z;
            val_48 = null;
            if(null == null)
            {
                    val_48 = null;
            }
            
            val_50 = null;
            val_51 = TzarGames.Common.Math3D.positionRegister;
            if(null == null)
            {
                    val_51 = TzarGames.Common.Math3D.positionRegister;
                if(null == null)
            {
                    val_51 = 0;
            }
            
            }
            
            var val_23 = TzarGames.Common.Math3D.positionRegister + (((long) + 1) * 12);
            var val_25 = val_51 + (0 * 12);
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = ((long)(int)((val_47 + 1)) * 12) + TzarGames.Common.Math3D.positionRegister + 32, y = ((long)(int)((val_47 + 1)) * 12) + TzarGames.Common.Math3D.positionRegister + 32 + 4, z = ((long)(int)((val_47 + 1)) * 12) + TzarGames.Common.Math3D.positionRegister + 40}, b:  new UnityEngine.Vector3() {x = (0 * 12) + val_51 + 32, y = (0 * 12) + val_51 + 32 + 4, z = (0 * 12) + val_51 + 40});
            val_46 = val_26.x;
            val_29 = val_26.z;
            System.Single[] val_28 = TzarGames.Common.Math3D.posTimeRegister + (((long)(int)((val_47 + 1))) << 2);
            float val_46 = mem[(TzarGames.Common.Math3D.posTimeRegister + ((long)(int)((val_47 + 1))) << 2) + 32];
            val_52 = TzarGames.Common.Math3D.posTimeRegister;
            val_39 = ((((long) + 1) - 1) + 1) - 1;
            val_46 = val_46 - (System.Single[].__il2cppRuntimeField_namespaze + 32);
            if(val_46 == 0f)
            {
                goto label_63;
            }
            
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_46, y = val_26.y, z = val_29}, d:  val_46);
            val_53 = null;
            val_15 = val_29.z;
            val_16 = val_29.y;
            val_52 = TzarGames.Common.Math3D.positionRegister;
            val_54 = val_52;
            if(null == null)
            {
                    val_54 = TzarGames.Common.Math3D.positionRegister;
                if(null == null)
            {
                    val_54 = 0;
            }
            
            }
            
            val_31 = val_30;
            val_39 = val_39 + 2;
            var val_31 = val_52 + (((long) + 2) * 12);
            val_29 = val_32;
            val_39 = val_39 - 1;
            var val_32 = val_54 + (((long) + 1) * 12);
            UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = ((long)(int)((val_47 + 2)) * 12) + val_52 + 32, y = ((long)(int)((val_47 + 2)) * 12) + val_52 + 32 + 4, z = ((long)(int)((val_47 + 2)) * 12) + val_52 + 40}, b:  new UnityEngine.Vector3() {x = ((long)(int)((val_47 + 1)) * 12) + val_54 + 32, y = ((long)(int)((val_47 + 1)) * 12) + val_54 + 32 + 4, z = ((long)(int)((val_47 + 1)) * 12) + val_54 + 40});
            val_30 = val_33.x;
            val_46 = val_33.z;
            val_39 = val_39 + 1;
            System.Single[] val_34 = TzarGames.Common.Math3D.posTimeRegister + (((long)(int)((val_47 + 2))) << 2);
            float val_47 = mem[(TzarGames.Common.Math3D.posTimeRegister + ((long)(int)((val_47 + 2))) << 2) + 32];
            val_47 = val_39 - 1;
            System.Single[] val_35 = TzarGames.Common.Math3D.posTimeRegister + (((long)(int)((val_47 + 1))) << 2);
            val_47 = val_47 - (mem[(TzarGames.Common.Math3D.posTimeRegister + ((long)(int)((val_47 + 1))) << 2) + 32]);
            if(val_47 == 0f)
            {
                goto label_63;
            }
            
            goto label_66;
            label_63:
            val_49 = 0;
            return (bool);
        }
        public static bool AngularAcceleration(out UnityEngine.Vector3 vector, UnityEngine.Quaternion rotation, int samples)
        {
            float val_17;
            float val_19;
            float val_20;
            float val_32;
            float val_33;
            float val_34;
            float val_35;
            float val_36;
            var val_39;
            var val_41;
            System.Single[] val_43;
            var val_44;
            var val_45;
            UnityEngine.Quaternion[] val_46;
            float val_50;
            var val_51;
            var val_52;
            var val_53;
            float val_54;
            var val_55;
            UnityEngine.Quaternion[] val_56;
            float val_57;
            UnityEngine.Quaternion[] val_58;
            val_32 = rotation.z;
            val_33 = rotation.x;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_34 = val_1.x;
            val_35 = val_1.y;
            val_36 = val_1.z;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            mem2[0] = val_2.x;
            mem2[0] = val_2.y;
            mem2[0] = val_2.z;
            val_39 = null;
            val_39 = null;
            if(TzarGames.Common.Math3D.rotationRegister == null)
            {
                goto label_5;
            }
            
            val_41 = 0;
            goto label_9;
            label_5:
            TzarGames.Common.Math3D.rotationRegister = null;
            val_41 = 0;
            TzarGames.Common.Math3D.rotTimeRegister = null;
            goto label_9;
            label_23:
            val_41 = 1;
            (TzarGames.Common.Math3D.__il2cppRuntimeField_static_fields + (W2 < 0x3 ? 3 : W2) << 2).__unknownFiledOffset_20 = ???;
            label_9:
            val_44 = null;
            val_44 = null;
            if(null == null)
            {
                    val_44 = null;
            }
            
            val_45 = null;
            val_46 = TzarGames.Common.Math3D.rotationRegister;
            if(null == null)
            {
                    val_46 = TzarGames.Common.Math3D.rotationRegister;
                if(null == null)
            {
                    val_46 = 0;
            }
            
            }
            
            var val_46 = (long)val_41 + 1;
            var val_10 = val_46 + (((long)(int)((val_41 + 1))) << 4);
            mem2[0] = (val_46 + ((long)(int)((val_41 + 1))) << 4) + 32;
            System.Single[] val_11 = TzarGames.Common.Math3D.rotTimeRegister + (((long)(int)((val_41 + 1))) << 2);
            val_46 = val_46 - 1;
            goto label_23;
            label_63:
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {y = val_35, z = val_36}, b:  new UnityEngine.Vector3() {x = val_17, y = val_32, z = rotation.y});
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = rotation.w, y = val_20, z = val_19}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            val_52 = null;
            val_34 = val_21.x;
            val_35 = val_21.y;
            val_54 = val_21.z;
            val_52 = null;
            if(null == null)
            {
                    val_52 = null;
            }
            
            val_55 = null;
            val_56 = TzarGames.Common.Math3D.rotationRegister;
            if(null == null)
            {
                    val_56 = TzarGames.Common.Math3D.rotationRegister;
                if(null == null)
            {
                    val_56 = 0;
            }
            
            }
            
            val_19 = val_54;
            val_20 = val_35;
            val_51 = (long)0 + 1;
            UnityEngine.Quaternion[] val_26 = TzarGames.Common.Math3D.rotationRegister + (((long)(int)((0 + 1))) << 4);
            var val_28 = val_56 + 0;
            UnityEngine.Quaternion val_29 = TzarGames.Common.Math3D.SubtractRotation(B:  new UnityEngine.Quaternion() {x = mem[(TzarGames.Common.Math3D.rotationRegister + ((long)(int)((0 + 1))) << 4) + 32], y = mem[(TzarGames.Common.Math3D.rotationRegister + ((long)(int)((0 + 1))) << 4) + 32 + 4], z = mem[(TzarGames.Common.Math3D.rotationRegister + ((long)(int)((0 + 1))) << 4) + 40], w = mem[(TzarGames.Common.Math3D.rotationRegister + ((long)(int)((0 + 1))) << 4) + 40 + 4]}, A:  new UnityEngine.Quaternion() {x = (val_56 + 0) + 32, y = (val_56 + 0) + 32 + 4, z = (val_56 + 0) + 40, w = (val_56 + 0) + 40 + 4});
            val_32 = val_29.y;
            val_50 = val_29.w;
            System.Single[] val_31 = TzarGames.Common.Math3D.rotTimeRegister + (((long)(int)((0 + 1))) << 2);
            val_43 = ((val_51 - 1) + 1) - 1;
            val_57 = (mem[(TzarGames.Common.Math3D.rotTimeRegister + ((long)(int)((0 + 1))) << 2) + 32]) - (System.Single[].__il2cppRuntimeField_namespaze + 32);
            if(val_57 == 0f)
            {
                goto label_58;
            }
            
            UnityEngine.Vector3 val_32 = TzarGames.Common.Math3D.RotDiffToSpeedVec(rotation:  new UnityEngine.Quaternion() {x = val_29.x, y = val_32, z = val_29.z, w = val_50}, deltaTime:  val_57);
            val_32 = val_32.y;
            val_17 = val_32.x;
            val_58 = TzarGames.Common.Math3D.rotationRegister;
            if(null == null)
            {
                    val_58 = TzarGames.Common.Math3D.rotationRegister;
                if(null == null)
            {
                    val_58 = 0;
            }
            
            }
            
            var val_33 = 0 + 2;
            val_43 = val_43 + 2;
            UnityEngine.Quaternion[] val_34 = TzarGames.Common.Math3D.rotationRegister + (((long)(int)((0 + 2))) << 4);
            val_43 = val_43 - 1;
            var val_35 = val_58 + (((long)(int)((0 + 1))) << 4);
            UnityEngine.Quaternion val_36 = TzarGames.Common.Math3D.SubtractRotation(B:  new UnityEngine.Quaternion() {x = mem[(TzarGames.Common.Math3D.rotationRegister + ((long)(int)((0 + 2))) << 4) + 32], y = mem[(TzarGames.Common.Math3D.rotationRegister + ((long)(int)((0 + 2))) << 4) + 32 + 4], z = mem[(TzarGames.Common.Math3D.rotationRegister + ((long)(int)((0 + 2))) << 4) + 40], w = mem[(TzarGames.Common.Math3D.rotationRegister + ((long)(int)((0 + 2))) << 4) + 40 + 4]}, A:  new UnityEngine.Quaternion() {x = (val_58 + ((long)(int)((0 + 1))) << 4) + 32, y = (val_58 + ((long)(int)((0 + 1))) << 4) + 32 + 4, z = (val_58 + ((long)(int)((0 + 1))) << 4) + 40, w = (val_58 + ((long)(int)((0 + 1))) << 4) + 40 + 4});
            val_33 = val_36.x;
            val_50 = val_36.w;
            System.Single[] val_38 = TzarGames.Common.Math3D.rotTimeRegister + (((long)(int)((0 + 2))) << 2);
            val_43 = TzarGames.Common.Math3D.rotTimeRegister;
            var val_39 = (val_43 + 1) - 1;
            System.Single[] val_40 = val_43 + (((long)(int)((0 + 1))) << 2);
            val_57 = (mem[(TzarGames.Common.Math3D.rotTimeRegister + ((long)(int)((0 + 2))) << 2) + 32]) - (mem[(val_43 + ((long)(int)((0 + 1))) << 2) + 32]);
            if(val_57 == 0f)
            {
                goto label_58;
            }
            
            UnityEngine.Vector3 val_41 = TzarGames.Common.Math3D.RotDiffToSpeedVec(rotation:  new UnityEngine.Quaternion() {x = val_33, y = val_36.y, z = val_36.z, w = val_50}, deltaTime:  val_57);
            goto label_63;
            label_58:
            val_53 = 0;
            return (bool);
        }
        public static float LinearFunction2DBasic(float x, float Qx, float Qy)
        {
            Qx = Qy / Qx;
            x = Qx * x;
            return (float)x;
        }
        public static float LinearFunction2DFull(float x, float Px, float Py, float Qx, float Qy)
        {
            Qy = Qy - Py;
            Qx = Qx - Px;
            Qx = Qy / Qx;
            x = x - Px;
            x = x * Qx;
            x = x + Py;
            return (float)x;
        }
        private static UnityEngine.Vector3 RotDiffToSpeedVec(UnityEngine.Quaternion rotation, float deltaTime)
        {
            float val_1 = rotation.x + (-360f);
            rotation.x = val_1 + (-360f);
            rotation.z = (rotation.z > 180f) ? (rotation.z + (-360f)) : rotation.z;
            float val_5 = ((rotation.x > 180f) ? (val_1) : rotation.x) / deltaTime;
            float val_6 = ((val_1 > 180f) ? (rotation.x) : (val_1)) / deltaTime;
            rotation.z = rotation.z / deltaTime;
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        private static Math3D()
        {
        
        }
    
    }

}

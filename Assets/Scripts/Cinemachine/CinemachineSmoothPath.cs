using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    [UnityEngine.AddComponentMenu]
    [Cinemachine.SaveDuringPlayAttribute]
    public class CinemachineSmoothPath : CinemachinePathBase
    {
        // Fields
        [UnityEngine.TooltipAttribute]
        public bool m_Looped;
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachineSmoothPath.Waypoint[] m_Waypoints;
        private Cinemachine.CinemachineSmoothPath.Waypoint[] m_ControlPoints1;
        private Cinemachine.CinemachineSmoothPath.Waypoint[] m_ControlPoints2;
        private bool m_IsLoopedCache;
        
        // Properties
        public override float MinPos { get; }
        public override float MaxPos { get; }
        public override bool Looped { get; }
        public override int DistanceCacheSampleStepsPerSegment { get; }
        
        // Methods
        public CinemachineSmoothPath()
        {
            this.m_Waypoints = null;
        }
        public override float get_MinPos()
        {
            return 0f;
        }
        public override float get_MaxPos()
        {
            int val_2 = this.m_Waypoints.Length;
            int val_1 = val_2 - 1;
            if(val_1 < 1)
            {
                    return 0f;
            }
            
            val_2 = (this.m_Looped == true) ? (val_2) : (val_1);
            return 0f;
        }
        public override bool get_Looped()
        {
            return (bool)this.m_Looped;
        }
        public override int get_DistanceCacheSampleStepsPerSegment()
        {
            return (int)this;
        }
        private void OnValidate()
        {
            goto typeof(Cinemachine.CinemachineSmoothPath).__il2cppRuntimeField_1F0;
        }
        public override void InvalidateDistanceCache()
        {
            this.InvalidateDistanceCache();
            this.m_ControlPoints1 = 0;
            this.m_ControlPoints2 = 0;
        }
        private void UpdateControlPoints()
        {
            var val_7;
            var val_8;
            if(this.m_Waypoints == null)
            {
                    return;
            }
            
            if(this.m_Waypoints.Length < 2)
            {
                    return;
            }
            
            var val_1 = (this.m_IsLoopedCache == true) ? 1 : 0;
            val_1 = val_2 ^ val_1;
            val_1 = val_1 & 1;
            if(((((val_1 & 1) == 0) && (this.m_ControlPoints1 != null)) && (this.m_ControlPoints1.Length == this.m_Waypoints.Length)) && (this.m_ControlPoints2 != null))
            {
                    if(this.m_ControlPoints2.Length == this.m_Waypoints.Length)
            {
                    return;
            }
            
            }
            
            UnityEngine.Vector4[] val_4 = null;
            val_7 = this.m_Waypoints.Length;
            var val_8 = 0;
            var val_7 = 0;
            UnityEngine.Vector4[] val_3 = null;
            do
            {
                if(val_7 >= this.m_Waypoints.Length)
            {
                    val_7 = 0;
            }
            
                val_7 = 0;
                val_7 = val_7 + 1;
                val_8 = val_8 + 16;
                typeof(UnityEngine.Vector4[]).__il2cppRuntimeField_20 = V0.16B;
                typeof(UnityEngine.Vector4[]).__il2cppRuntimeField_24 = V1.16B;
                typeof(UnityEngine.Vector4[]).__il2cppRuntimeField_28 = V2.16B;
                typeof(UnityEngine.Vector4[]).__il2cppRuntimeField_2C = V3.16B;
            }
            while(this.m_Waypoints.Length != val_7);
            
            if((val_2 & 1) != 0)
            {
                    Cinemachine.Utility.SplineHelpers.ComputeSmoothControlPointsLooped(knot: ref  UnityEngine.Vector4[] val_2 = this, ctrl1: ref  val_3, ctrl2: ref  val_4);
            }
            else
            {
                    Cinemachine.Utility.SplineHelpers.ComputeSmoothControlPoints(knot: ref  val_2, ctrl1: ref  val_3, ctrl2: ref  val_4);
            }
            
            this.m_ControlPoints1 = null;
            val_8 = this.m_Waypoints.Length;
            this.m_ControlPoints2 = null;
            var val_9 = 0;
            var val_10 = 32;
            do
            {
                val_8 = 0;
                Waypoint val_5 = CinemachineSmoothPath.Waypoint.FromVector4(v:  new UnityEngine.Vector4() {x = typeof(UnityEngine.Vector4[]).__il2cppRuntimeField_20, y = typeof(UnityEngine.Vector4[]).__il2cppRuntimeField_24, z = typeof(UnityEngine.Vector4[]).__il2cppRuntimeField_28, w = typeof(UnityEngine.Vector4[]).__il2cppRuntimeField_2C});
                if(val_9 >= this.m_ControlPoints1.Length)
            {
                    val_8 = 0;
            }
            
                mem2[0] = typeof(UnityEngine.Vector4[]).__il2cppRuntimeField_20;
                mem2[0] = typeof(UnityEngine.Vector4[]).__il2cppRuntimeField_24;
                mem2[0] = typeof(UnityEngine.Vector4[]).__il2cppRuntimeField_28;
                mem2[0] = typeof(UnityEngine.Vector4[]).__il2cppRuntimeField_2C;
                val_8 = 0;
                Waypoint val_6 = CinemachineSmoothPath.Waypoint.FromVector4(v:  new UnityEngine.Vector4() {x = typeof(UnityEngine.Vector4[]).__il2cppRuntimeField_20, y = typeof(UnityEngine.Vector4[]).__il2cppRuntimeField_24, z = typeof(UnityEngine.Vector4[]).__il2cppRuntimeField_28, w = typeof(UnityEngine.Vector4[]).__il2cppRuntimeField_2C});
                if(val_9 >= this.m_ControlPoints2.Length)
            {
                    val_8 = 0;
            }
            
                val_9 = val_9 + 1;
                val_10 = val_10 + 16;
                mem2[0] = typeof(UnityEngine.Vector4[]).__il2cppRuntimeField_20;
                mem2[0] = typeof(UnityEngine.Vector4[]).__il2cppRuntimeField_24;
                mem2[0] = typeof(UnityEngine.Vector4[]).__il2cppRuntimeField_28;
                mem2[0] = typeof(UnityEngine.Vector4[]).__il2cppRuntimeField_2C;
            }
            while(this.m_Waypoints.Length != val_9);
            
            this.m_IsLoopedCache = 0;
        }
        private float GetBoundingIndices(float pos, out int indexA, out int indexB)
        {
            float val_2;
            var val_3;
            var val_4;
            val_2 = pos;
            if(this.m_Waypoints.Length <= 1)
            {
                goto label_2;
            }
            
            val_3 = 0;
            val_4 = 0;
            int val_1 = UnityEngine.Mathf.FloorToInt(f:  val_2);
            indexA = val_1;
            if(val_1 >= this.m_Waypoints.Length)
            {
                    val_3 = 0;
                val_2 = val_2 - val_2;
                indexA = 0;
            }
            
            int val_2 = val_3 + 1;
            indexB = val_2;
            if(val_2 != this.m_Waypoints.Length)
            {
                    return (float)val_2;
            }
            
            if((this & 1) == 0)
            {
                goto label_7;
            }
            
            indexB = 0;
            return (float)val_2;
            label_2:
            indexB = 0;
            indexA = 0;
            return (float)val_2;
            label_7:
            int val_3 = indexB;
            val_3 = val_3 - 1;
            indexB = val_3;
            indexA = -1;
            return (float)val_2;
        }
        public override UnityEngine.Vector3 EvaluatePosition(float pos)
        {
            float val_8;
            Waypoint val_12;
            Waypoint val_13;
            Waypoint val_14;
            val_8 = pos;
            int val_3 = 0;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_12 = val_1.x;
            val_13 = val_1.y;
            val_14 = val_1.z;
            if(this.m_Waypoints.Length >= 1)
            {
                    this.UpdateControlPoints();
                val_8 = this.GetBoundingIndices(pos:  val_8, indexA: out  0, indexB: out  val_3);
                if((???) == val_3)
            {
                    val_12 = this.m_Waypoints[(???) << 4];
                val_13 = this.m_Waypoints[(???) << 4];
                val_14 = this.m_Waypoints[(???) << 4];
            }
            else
            {
                    Waypoint val_10 = this.m_Waypoints[(???) << 4];
                Waypoint val_15 = this.m_ControlPoints2[(???) << 4];
                Waypoint val_18 = this.m_Waypoints[0];
                float val_20 = (float)???;
                val_20 = val_8 - val_20;
                UnityEngine.Vector3 val_5 = Cinemachine.Utility.SplineHelpers.Bezier3(t:  val_20, p0:  new UnityEngine.Vector3() {x = this.m_Waypoints[(???) << 4], y = val_10, z = this.m_Waypoints[(???) << 4]}, p1:  new UnityEngine.Vector3() {x = this.m_ControlPoints1[(???) << 4], y = this.m_ControlPoints1[(???) << 4], z = this.m_ControlPoints1[(???) << 4]}, p2:  new UnityEngine.Vector3() {x = this.m_ControlPoints2[(???) << 4], y = this.m_ControlPoints2[(???) << 4], z = this.m_Waypoints[0]}, p3:  new UnityEngine.Vector3() {x = this.m_Waypoints[0], y = val_10, z = val_3});
                val_12 = val_5.x;
                val_13 = val_5.y;
                val_14 = val_5.z;
            }
            
            }
            
            UnityEngine.Vector3 val_7 = this.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = val_12, y = val_13, z = val_14});
            return new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        }
        public override UnityEngine.Vector3 EvaluateTangent(float pos)
        {
            float val_11;
            float val_12;
            float val_13;
            float val_17;
            float val_18;
            float val_19;
            var val_20;
            val_11 = pos;
            int val_6 = 0;
            int val_5 = 0;
            UnityEngine.Quaternion val_2 = this.transform.rotation;
            val_12 = val_2.z;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.forward;
            val_13 = val_3.y;
            UnityEngine.Vector3 val_4 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_12, w = val_2.w}, point:  new UnityEngine.Vector3() {x = val_3.x, y = val_13, z = val_3.z});
            val_17 = val_4.x;
            val_18 = val_4.y;
            val_19 = val_4.z;
            if(this.m_Waypoints.Length >= 2)
            {
                    this.UpdateControlPoints();
                val_20 = val_5;
                if((0 & 1) == 0)
            {
                    int val_11 = this.m_Waypoints.Length;
                val_11 = val_11 - 1;
                if(0 == val_11)
            {
                    val_20 = val_20 - 1;
            }
            
            }
            
                Waypoint val_12 = this.m_Waypoints[((long)(int)((val_20 - 1))) << 4];
                val_12 = this.m_ControlPoints1[((long)(int)((val_20 - 1))) << 4];
                val_13 = this.m_ControlPoints1[((long)(int)((val_20 - 1))) << 4];
                val_11 = this.m_ControlPoints2[((long)(int)((val_20 - 1))) << 4];
                Waypoint val_19 = this.m_Waypoints[0];
                float val_21 = (float)val_20;
                val_21 = (this.GetBoundingIndices(pos:  val_11, indexA: out  val_5, indexB: out  val_6)) - val_21;
                UnityEngine.Vector3 val_8 = Cinemachine.Utility.SplineHelpers.BezierTangent3(t:  val_21, p0:  new UnityEngine.Vector3() {x = val_12, y = this.m_Waypoints[((long)(int)((val_20 - 1))) << 4], z = this.m_Waypoints[((long)(int)((val_20 - 1))) << 4]}, p1:  new UnityEngine.Vector3() {x = val_12, y = this.m_ControlPoints1[((long)(int)((val_20 - 1))) << 4], z = val_13}, p2:  new UnityEngine.Vector3() {x = this.m_ControlPoints2[((long)(int)((val_20 - 1))) << 4], y = this.m_ControlPoints2[((long)(int)((val_20 - 1))) << 4], z = this.m_Waypoints[0]}, p3:  new UnityEngine.Vector3() {x = this.m_Waypoints[0], y = val_12, z = val_6});
                val_17 = val_8.x;
                val_18 = val_8.y;
                val_19 = val_8.z;
            }
            
            UnityEngine.Vector3 val_10 = this.transform.TransformDirection(direction:  new UnityEngine.Vector3() {x = val_17, y = val_18, z = val_19});
            return new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        }
        public override UnityEngine.Quaternion EvaluateOrientation(float pos)
        {
            float val_6;
            float val_16;
            var val_17;
            float val_22;
            float val_23;
            float val_24;
            float val_25;
            var val_26;
            Waypoint[] val_27;
            Waypoint val_28;
            val_16 = pos;
            val_17 = this;
            int val_4 = 0;
            UnityEngine.Quaternion val_2 = this.transform.rotation;
            val_22 = val_2.x;
            val_23 = val_2.y;
            val_24 = val_2.z;
            val_25 = val_2.w;
            if(this.m_Waypoints.Length < 1)
            {
                    return new UnityEngine.Quaternion() {x = val_22, y = val_23, z = val_24, w = val_25};
            }
            
            float val_5 = this.GetBoundingIndices(pos:  val_16, indexA: out  0, indexB: out  val_4);
            val_27 = val_4;
            if(val_6 == val_27)
            {
                    val_27 = this.m_Waypoints;
                if(val_6 >= this.m_Waypoints.Length)
            {
                    val_26 = 0;
            }
            
                val_28 = val_27[(val_6) << 4];
            }
            else
            {
                    this.UpdateControlPoints();
                if(val_6 >= this.m_Waypoints.Length)
            {
                    val_26 = 0;
            }
            
                Waypoint val_16 = this.m_Waypoints[(val_6) << 4];
                if(val_6 >= this.m_ControlPoints1.Length)
            {
                    val_26 = 0;
            }
            
                Waypoint val_17 = this.m_ControlPoints1[(val_6) << 4];
                if(val_6 >= this.m_ControlPoints2.Length)
            {
                    val_26 = 0;
            }
            
                if(0 >= this.m_Waypoints.Length)
            {
                    val_26 = 0;
            }
            
                float val_20 = val_6;
                val_20 = val_5 - val_20;
                val_28 = Cinemachine.Utility.SplineHelpers.Bezier1(t:  val_20, p0:  val_16, p1:  val_17, p2:  this.m_ControlPoints2[(val_6) << 4], p3:  this.m_Waypoints[0]);
            }
            
            val_16 = val_5;
            val_6 = val_16;
            if(val_5 < 0)
            {
                    return new UnityEngine.Quaternion() {x = val_22, y = val_23, z = val_24, w = val_25};
            }
            
            val_17 = this.transform;
            UnityEngine.Quaternion val_9 = val_17.rotation;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_11 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w}, point:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            UnityEngine.Quaternion val_12 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_16, y = val_16, z = val_17}, upwards:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.forward;
            UnityEngine.Quaternion val_14 = UnityEngine.Quaternion.AngleAxis(angle:  val_28, axis:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            UnityEngine.Quaternion val_15 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w}, rhs:  new UnityEngine.Quaternion() {x = val_14.x, y = val_14.y, z = val_14.z, w = val_14.w});
            val_22 = val_15.x;
            val_23 = val_15.y;
            val_24 = val_15.z;
            val_25 = val_15.w;
            return new UnityEngine.Quaternion() {x = val_22, y = val_23, z = val_24, w = val_25};
        }
    
    }

}

using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    [UnityEngine.AddComponentMenu]
    [Cinemachine.SaveDuringPlayAttribute]
    public class CinemachinePath : CinemachinePathBase
    {
        // Fields
        [UnityEngine.TooltipAttribute]
        public bool m_Looped;
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachinePath.Waypoint[] m_Waypoints;
        
        // Properties
        public override float MinPos { get; }
        public override float MaxPos { get; }
        public override bool Looped { get; }
        public override int DistanceCacheSampleStepsPerSegment { get; }
        
        // Methods
        public CinemachinePath()
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
        private float GetBoundingIndices(float pos, out int indexA, out int indexB)
        {
            float val_5;
            int val_6;
            int val_7;
            val_5 = pos;
            int val_1 = UnityEngine.Mathf.RoundToInt(f:  val_5);
            float val_5 = (float)val_1;
            val_5 = val_5 - val_5;
            if(System.Math.Abs(val_5) < 0)
            {
                    int val_2 = (val_1 == this.m_Waypoints.Length) ? 0 : (val_1);
                indexB = val_2;
                indexA = val_2;
                return val_5;
            }
            
            val_6 = 0;
            indexA = UnityEngine.Mathf.FloorToInt(f:  val_5);
            if(this.m_Waypoints == null)
            {
                    val_6 = indexA;
            }
            
            if(val_6 >= this.m_Waypoints.Length)
            {
                    val_5 = val_5 - val_5;
                indexA = 0;
            }
            
            val_7 = 0;
            indexB = UnityEngine.Mathf.CeilToInt(f:  val_5);
            if(this.m_Waypoints == null)
            {
                    val_7 = indexB;
            }
            
            if(val_7 < this.m_Waypoints.Length)
            {
                    return val_5;
            }
            
            indexB = 0;
            return val_5;
        }
        public override UnityEngine.Vector3 EvaluatePosition(float pos)
        {
            float val_11;
            Waypoint[] val_13;
            float val_14;
            float val_15;
            float val_16;
            val_11 = pos;
            int val_2 = 0;
            if(this.m_Waypoints.Length == 0)
            {
                goto label_2;
            }
            
            val_13 = val_2;
            val_11 = this.GetBoundingIndices(pos:  val_11, indexA: out  0, indexB: out  val_2);
            var val_11 = 28;
            val_11 = this.m_Waypoints + ((???) * val_11);
            val_14 = mem[(??? * 28) + this.m_Waypoints + 32];
            val_14 = (??? * 28) + this.m_Waypoints + 32;
            val_15 = mem[(??? * 28) + this.m_Waypoints + 32 + 4];
            val_15 = (??? * 28) + this.m_Waypoints + 32 + 4;
            val_16 = mem[(??? * 28) + this.m_Waypoints + 40];
            val_16 = (??? * 28) + this.m_Waypoints + 40;
            if((???) == val_13)
            {
                goto label_5;
            }
            
            var val_12 = 28;
            val_12 = this.m_Waypoints + ((???) * val_12);
            var val_13 = 28;
            val_13 = this.m_Waypoints + (val_13 * val_13);
            val_11 = mem[(val_13 * 28) + this.m_Waypoints + 32 + 4];
            val_11 = (val_13 * 28) + this.m_Waypoints + 32 + 4;
            val_13 = this.m_Waypoints;
            var val_14 = 28;
            val_14 = val_13 + ((???) * val_14);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_14, y = val_15, z = val_16}, b:  new UnityEngine.Vector3() {x = (??? * 28) + this.m_Waypoints + 44, y = (??? * 28) + this.m_Waypoints + 48, z = (??? * 28) + this.m_Waypoints + 52});
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = (val_13 * 28) + this.m_Waypoints + 32, y = val_11, z = (val_13 * 28) + this.m_Waypoints + 40}, b:  new UnityEngine.Vector3() {x = (val_13 * 28) + this.m_Waypoints + 40 + 4, y = (val_13 * 28) + this.m_Waypoints + 48, z = (val_13 * 28) + this.m_Waypoints + 52});
            float val_15 = (float)???;
            val_15 = val_11 - val_15;
            UnityEngine.Vector3 val_6 = Cinemachine.Utility.SplineHelpers.Bezier3(t:  val_15, p0:  new UnityEngine.Vector3() {x = (??? * 28) + this.m_Waypoints + 32, y = (??? * 28) + this.m_Waypoints + 32 + 4, z = (??? * 28) + this.m_Waypoints + 40}, p1:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, p2:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.z, z = (val_13 * 28) + this.m_Waypoints + 32}, p3:  new UnityEngine.Vector3() {x = (val_13 * 28) + this.m_Waypoints + 40, z = (??? * 28) + this.m_Waypoints + 40});
            goto label_12;
            label_2:
            UnityEngine.Vector3 val_8 = this.transform.position;
            label_12:
            val_14 = val_8.x;
            val_15 = val_8.y;
            val_16 = val_8.z;
            label_5:
            UnityEngine.Vector3 val_10 = this.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = val_14, y = val_15, z = val_16});
            return new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        }
        public override UnityEngine.Vector3 EvaluateTangent(float pos)
        {
            Waypoint[] val_14;
            float val_15;
            float val_16;
            float val_17;
            float val_18;
            float val_19;
            float val_20;
            float val_21;
            float val_22;
            int val_2 = 0;
            if(this.m_Waypoints.Length == 0)
            {
                goto label_2;
            }
            
            val_14 = val_2;
            var val_13 = 28;
            if((???) != val_14)
            {
                goto label_5;
            }
            
            val_13 = this.m_Waypoints + ((???) * val_13);
            val_15 = mem[(??? * 28) + this.m_Waypoints + 44];
            val_15 = (??? * 28) + this.m_Waypoints + 44;
            val_16 = mem[(??? * 28) + this.m_Waypoints + 44 + 4];
            val_16 = (??? * 28) + this.m_Waypoints + 44 + 4;
            val_17 = mem[(??? * 28) + this.m_Waypoints + 52];
            val_17 = (??? * 28) + this.m_Waypoints + 52;
            goto label_6;
            label_2:
            UnityEngine.Quaternion val_5 = this.transform.rotation;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.forward;
            val_18 = val_6.x;
            val_19 = val_6.z;
            val_20 = val_5.x;
            val_21 = val_5.y;
            val_22 = val_5.z;
            UnityEngine.Vector3 val_7 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_20, y = val_21, z = val_22, w = val_5.w}, point:  new UnityEngine.Vector3() {x = val_18, y = val_6.y, z = val_19});
            goto label_12;
            label_5:
            val_13 = this.m_Waypoints + ((???) * val_13);
            var val_14 = 28;
            val_14 = this.m_Waypoints + (val_14 * val_14);
            val_14 = this.m_Waypoints;
            var val_15 = 28;
            val_15 = val_14 + ((???) * val_15);
            val_19 = mem[(??? * 28) + this.m_Waypoints + 32 + 4];
            val_19 = (??? * 28) + this.m_Waypoints + 32 + 4;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (??? * 28) + this.m_Waypoints + 32, y = (??? * 28) + this.m_Waypoints + 32 + 4, z = (??? * 28) + this.m_Waypoints + 40}, b:  new UnityEngine.Vector3() {x = (??? * 28) + this.m_Waypoints + 40 + 4, y = (??? * 28) + this.m_Waypoints + 48, z = (??? * 28) + this.m_Waypoints + 52});
            val_18 = val_8.y;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = (val_14 * 28) + this.m_Waypoints + 32, y = (val_14 * 28) + this.m_Waypoints + 32 + 4, z = (val_14 * 28) + this.m_Waypoints + 40}, b:  new UnityEngine.Vector3() {x = (val_14 * 28) + this.m_Waypoints + 40 + 4, y = (val_14 * 28) + this.m_Waypoints + 48, z = (val_14 * 28) + this.m_Waypoints + 52});
            float val_16 = (float)???;
            val_16 = (this.GetBoundingIndices(pos:  pos, indexA: out  0, indexB: out  val_2)) - val_16;
            val_20 = val_16;
            val_21 = (??? * 28) + this.m_Waypoints + 32;
            val_22 = val_19;
            UnityEngine.Vector3 val_10 = Cinemachine.Utility.SplineHelpers.BezierTangent3(t:  val_20, p0:  new UnityEngine.Vector3() {x = val_21, y = val_22, z = (??? * 28) + this.m_Waypoints + 40}, p1:  new UnityEngine.Vector3() {x = val_8.x, y = val_18, z = val_8.z}, p2:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.z, z = (val_14 * 28) + this.m_Waypoints + 32}, p3:  new UnityEngine.Vector3() {x = (val_14 * 28) + this.m_Waypoints + 40, z = (??? * 28) + this.m_Waypoints + 40});
            label_12:
            val_15 = val_10.x;
            val_16 = val_10.y;
            val_17 = val_10.z;
            label_6:
            UnityEngine.Vector3 val_12 = this.transform.TransformDirection(direction:  new UnityEngine.Vector3() {x = val_15, y = val_16, z = val_17});
            return new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        }
        public override UnityEngine.Quaternion EvaluateOrientation(float pos)
        {
            float val_18;
            var val_19;
            float val_24;
            float val_25;
            float val_26;
            float val_27;
            var val_28;
            float val_29;
            float val_30;
            val_18 = pos;
            val_19 = this;
            int val_4 = 0;
            UnityEngine.Quaternion val_2 = this.transform.rotation;
            val_24 = val_2.x;
            val_25 = val_2.y;
            val_26 = val_2.z;
            val_27 = val_2.w;
            if(this.m_Waypoints.Length < 1)
            {
                    return new UnityEngine.Quaternion() {x = val_24, y = val_25, z = val_26, w = val_27};
            }
            
            float val_5 = this.GetBoundingIndices(pos:  val_18, indexA: out  0, indexB: out  val_4);
            if((???) >= this.m_Waypoints.Length)
            {
                    val_28 = 0;
            }
            
            var val_18 = 28;
            val_18 = this.m_Waypoints + ((???) * val_18);
            val_29 = mem[(??? * 28) + this.m_Waypoints + 56];
            val_29 = (??? * 28) + this.m_Waypoints + 56;
            if((???) == val_4)
            {
                
            }
            else
            {
                    var val_19 = 28;
                val_19 = this.m_Waypoints + (val_4 * val_19);
                val_30 = mem[(val_4 * 28) + this.m_Waypoints + 56];
                val_30 = (val_4 * 28) + this.m_Waypoints + 56;
                if(val_4 == 0)
            {
                    val_18 = 360f;
                val_29 = val_29;
                val_30 = val_30;
            }
            
                float val_6 = val_5 - ((float)???);
                val_28 = 0;
            }
            
            if((Cinemachine.Utility.UnityVectorExtensions.AlmostZero(v:  new UnityEngine.Vector3() {x = val_5, y = val_30, z = val_6})) == true)
            {
                    return new UnityEngine.Quaternion() {x = val_24, y = val_25, z = val_26, w = val_27};
            }
            
            val_19 = this.transform;
            UnityEngine.Quaternion val_11 = val_19.rotation;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_13 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w}, point:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            UnityEngine.Quaternion val_14 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_5, y = val_30, z = val_6}, upwards:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            val_18 = val_14.x;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.forward;
            UnityEngine.Quaternion val_16 = UnityEngine.Quaternion.AngleAxis(angle:  UnityEngine.Mathf.Lerp(a:  val_29, b:  val_30, t:  val_6), axis:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            UnityEngine.Quaternion val_17 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_18, y = val_14.y, z = val_14.z, w = val_14.w}, rhs:  new UnityEngine.Quaternion() {x = val_16.x, y = val_16.y, z = val_16.z, w = val_16.w});
            val_24 = val_17.x;
            val_25 = val_17.y;
            val_26 = val_17.z;
            val_27 = val_17.w;
            return new UnityEngine.Quaternion() {x = val_24, y = val_25, z = val_26, w = val_27};
        }
        private void OnValidate()
        {
            goto typeof(Cinemachine.CinemachinePath).__il2cppRuntimeField_1F0;
        }
    
    }

}

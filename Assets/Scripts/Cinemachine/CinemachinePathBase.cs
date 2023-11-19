using UnityEngine;

namespace Cinemachine
{
    public abstract class CinemachinePathBase : MonoBehaviour
    {
        // Fields
        [UnityEngine.TooltipAttribute]
        [UnityEngine.RangeAttribute]
        public int m_Resolution;
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachinePathBase.Appearance m_Appearance;
        private float[] m_DistanceToPos;
        private float[] m_PosToDistance;
        private int m_CachedSampleSteps;
        private float m_PathLength;
        private float m_cachedPosStepSize;
        private float m_cachedDistanceStepSize;
        
        // Properties
        public abstract float MinPos { get; }
        public abstract float MaxPos { get; }
        public abstract bool Looped { get; }
        public abstract int DistanceCacheSampleStepsPerSegment { get; }
        public float PathLength { get; }
        
        // Methods
        protected CinemachinePathBase()
        {
            this.m_Resolution = 20;
            this.m_Appearance = new CinemachinePathBase.Appearance();
        }
        public abstract float get_MinPos(); // 0
        public abstract float get_MaxPos(); // 0
        public abstract bool get_Looped(); // 0
        public virtual float NormalizePos(float pos)
        {
            if(pos == 0f)
            {
                    return 0f;
            }
            
            if((this & 1) == 0)
            {
                    return UnityEngine.Mathf.Clamp(value:  pos, min:  0f, max:  pos);
            }
            
            float val_1 = pos;
            if(val_1 >= 0)
            {
                    return 0f;
            }
            
            val_1 = val_1 + pos;
            return 0f;
        }
        public abstract UnityEngine.Vector3 EvaluatePosition(float pos); // 0
        public abstract UnityEngine.Vector3 EvaluateTangent(float pos); // 0
        public abstract UnityEngine.Quaternion EvaluateOrientation(float pos); // 0
        public virtual float FindClosestPoint(UnityEngine.Vector3 p, int startSegment, int searchRadius, int stepsPerSegment)
        {
            var val_15;
            float val_16;
            float val_19;
            float val_20;
            float val_21;
            float val_22;
            val_16 = p.x;
            if((searchRadius & 2147483648) == 0)
            {
                    val_15 = 1152921504719998976;
                float val_15 = p.x;
                val_15 = val_15 - val_16;
                val_15 = val_15 * 0.5f;
                int val_2 = UnityEngine.Mathf.FloorToInt(f:  UnityEngine.Mathf.Min(a:  (float)searchRadius, b:  val_15));
                val_16 = (float)startSegment - val_2;
                int val_4 = startSegment + val_2;
                val_4 = val_4 + 1;
                if((0 & 1) == 0)
            {
                    float val_5 = UnityEngine.Mathf.Max(a:  val_16, b:  (float)val_4);
                val_16 = val_5;
            }
            
            }
            
            int val_8 = UnityEngine.Mathf.RoundToInt(f:  UnityEngine.Mathf.Clamp(value:  (float)stepsPerSegment, min:  1f, max:  100f));
            var val_17 = 0;
            label_15:
            val_19 = 1f / (float)val_8;
            val_20 = val_16;
            val_21 = val_19;
            val_22 = 100f;
            goto label_10;
            label_13:
            float val_16 = 1f;
            val_16 = val_16 - S9;
            val_16 = val_19 * val_16;
            val_19 = val_16 - val_16;
            goto label_10;
            label_14:
            val_21 = val_19;
            val_22 = val_19;
            val_20 = val_16;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = V10.16B, y = 1f, z = V12.16B}, b:  new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_22}, t:  Cinemachine.Utility.UnityVectorExtensions.ClosestPointOnSegment(p:  new UnityEngine.Vector3() {x = p.x, y = p.y, z = p.z}, s0:  new UnityEngine.Vector3() {x = V10.16B, y = 1f, z = V12.16B}, s1:  new UnityEngine.Vector3() {x = val_20, y = val_22, z = (float)val_8}));
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = p.x, y = p.y, z = p.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            val_19 = val_16;
            if((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z})) < 0)
            {
                goto label_13;
            }
            
            label_10:
            val_16 = val_19 + val_16;
            if(val_16 <= (UnityEngine.Mathf.Max(a:  (float)val_4, b:  val_5)))
            {
                goto label_14;
            }
            
            float val_18 = val_19;
            val_17 = val_17 + 1;
            float val_14 = val_18 - val_19;
            val_18 = val_19 + val_18;
            if(val_17 < ((val_8 == 1) ? 1 : 3))
            {
                goto label_15;
            }
            
            return val_19;
        }
        public float MinUnit(Cinemachine.CinemachinePathBase.PositionUnits units)
        {
            if(units == 1)
            {
                    return 0f;
            }
        
        }
        public float MaxUnit(Cinemachine.CinemachinePathBase.PositionUnits units)
        {
            if(units == 1)
            {
                    return this.PathLength;
            }
        
        }
        public virtual float NormalizeUnit(float pos, Cinemachine.CinemachinePathBase.PositionUnits units)
        {
            if(units == 1)
            {
                    return this.NormalizePathDistance(distance:  pos);
            }
        
        }
        public UnityEngine.Vector3 EvaluatePositionAtUnit(float pos, Cinemachine.CinemachinePathBase.PositionUnits units)
        {
            if(units == 1)
            {
                    float val_1 = this.GetPathPositionFromDistance(distance:  pos);
            }
        
        }
        public UnityEngine.Vector3 EvaluateTangentAtUnit(float pos, Cinemachine.CinemachinePathBase.PositionUnits units)
        {
            if(units == 1)
            {
                    float val_1 = this.GetPathPositionFromDistance(distance:  pos);
            }
        
        }
        public UnityEngine.Quaternion EvaluateOrientationAtUnit(float pos, Cinemachine.CinemachinePathBase.PositionUnits units)
        {
            if(units == 1)
            {
                    float val_1 = this.GetPathPositionFromDistance(distance:  pos);
            }
        
        }
        public abstract int get_DistanceCacheSampleStepsPerSegment(); // 0
        public virtual void InvalidateDistanceCache()
        {
            this.m_PosToDistance = 0;
            this.m_CachedSampleSteps = 0;
            this.m_PathLength = 0f;
            this.m_DistanceToPos = 0;
        }
        public bool DistanceCacheIsValid()
        {
            var val_2;
            if(V0.16B == S0)
            {
                    val_2 = 1;
                return (bool)val_2;
            }
            
            if(((this.m_DistanceToPos != null) && (this.m_PosToDistance != null)) && (this.m_CachedSampleSteps == this))
            {
                    var val_1 = (this.m_CachedSampleSteps > 0) ? 1 : 0;
                return (bool)val_2;
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
        public float get_PathLength()
        {
            if(this >= 1)
            {
                    if(this.DistanceCacheIsValid() == true)
            {
                    return 0f;
            }
            
                this.ResamplePath(stepsPerSegment:  -1458123008);
                return 0f;
            }
            
            return 0f;
        }
        public float NormalizePathDistance(float distance)
        {
            float val_2 = distance;
            float val_1 = this.PathLength;
            if(val_1 < 0)
            {
                    return 0f;
            }
            
            if((this & 1) == 0)
            {
                    return UnityEngine.Mathf.Clamp(value:  val_2 = val_1 + val_2, min:  0f, max:  val_1);
            }
            
            val_2 = val_2;
            if(val_2 >= 0)
            {
                    return UnityEngine.Mathf.Clamp(value:  val_2, min:  0f, max:  val_1);
            }
            
            return UnityEngine.Mathf.Clamp(value:  val_2, min:  0f, max:  val_1);
        }
        public float GetPathPositionFromDistance(float distance)
        {
            float val_6 = distance;
            if(this >= 1)
            {
                    if(this.PathLength < 0)
            {
                
            }
            else
            {
                    val_6 = (this.NormalizePathDistance(distance:  val_6 = distance)) / this.m_cachedDistanceStepSize;
                int val_3 = UnityEngine.Mathf.FloorToInt(f:  val_6);
                int val_6 = this.m_DistanceToPos.Length;
                val_6 = val_6 - 1;
                if(val_3 < val_6)
            {
                    val_6 = val_6 - (float)val_3;
                float val_5 = UnityEngine.Mathf.Lerp(a:  this.m_DistanceToPos[(long)val_3], b:  this.m_DistanceToPos[(long)val_3 + 1], t:  val_6);
                val_5 = val_6 + val_5;
                return (float)val_5;
            }
            
            }
            
            }
        
        }
        public float GetPathDistanceFromPosition(float pos)
        {
            float val_4;
            float val_5;
            val_4 = pos;
            val_5 = 0f;
            if(this < 1)
            {
                    return val_5;
            }
            
            if(this.PathLength < 0)
            {
                    return val_5;
            }
            
            val_4 = val_4 / this.m_cachedPosStepSize;
            int val_2 = UnityEngine.Mathf.FloorToInt(f:  val_4);
            int val_4 = this.m_PosToDistance.Length;
            val_4 = val_4 - 1;
            if(val_2 < val_4)
            {
                    val_4 = val_4 - (float)val_2;
                return UnityEngine.Mathf.Lerp(a:  this.m_PosToDistance[(long)val_2], b:  this.m_PosToDistance[(long)val_2 + 1], t:  val_4);
            }
            
            val_5 = this.m_PathLength;
            return val_5;
        }
        private void ResamplePath(int stepsPerSegment)
        {
            System.Single[] val_9;
            var val_10;
            float val_11;
            float val_12;
            float val_13;
            System.Single[] val_14;
            var val_15;
            float val_16;
            System.Single[] val_17;
            float val_11 = V0.16B;
            float val_2 = 1f / ((float)UnityEngine.Mathf.Max(a:  0, b:  1));
            float val_3 = V0.16B - val_11;
            val_3 = val_3 / val_2;
            int val_4 = UnityEngine.Mathf.RoundToInt(f:  val_3);
            int val_5 = val_4 + 1;
            val_9 = null;
            this.m_cachedPosStepSize = val_2;
            this.m_PosToDistance = val_9;
            this.m_CachedSampleSteps = stepsPerSegment;
            val_11 = 0f;
            val_12 = val_11;
            val_13 = 1f;
            if(this.m_PosToDistance.Length == 0)
            {
                    val_10 = 0;
            }
            
            this.m_PosToDistance[0] = 0f;
            if(val_5 >= 2)
            {
                    val_14 = 1152921504719785984;
                var val_12 = 0;
                val_9 = val_4;
                do
            {
                val_11 = val_2 + val_11;
                var val_6 = val_12 + 1;
                val_13 = (UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_12, y = val_13, z = V2.16B}, b:  new UnityEngine.Vector3() {x = val_11, y = 1f, z = V2.16B})) + this.m_PathLength;
                this.m_PathLength = val_13;
                val_12 = val_12 + 1;
                this.m_PosToDistance[val_12] = val_13;
                val_13 = 1f;
                val_12 = val_11;
            }
            while(val_9 != val_12);
            
            }
            
            this.m_DistanceToPos = null;
            typeof(System.Single[]).__il2cppRuntimeField_20 = 0;
            if(val_5 < 2)
            {
                    return;
            }
            
            val_13 = this.m_PathLength / (float)val_4;
            val_15 = 1;
            this.m_cachedDistanceStepSize = val_13;
            do
            {
                val_16 = this.m_PosToDistance[1];
                val_17 = this.m_PosToDistance;
                val_11 = val_13 + val_11;
                if((val_15 < val_4) && (val_16 < 0))
            {
                    label_21:
                val_15 = 1 + 1;
                var val_8 = 1 + 1;
                val_16 = val_17[1];
                val_17 = this.m_PosToDistance;
                if(val_15 < (long)val_4)
            {
                    if(val_16 < 0)
            {
                goto label_21;
            }
            
            }
            
            }
            
                float val_13 = val_17[(long)val_15 - 1];
                val_14 = this.m_DistanceToPos;
                val_12 = this.m_cachedPosStepSize;
                val_13 = val_11 - val_13;
                val_16 = val_13 / (val_16 - val_13);
                float val_14 = (float)val_15;
                val_14 = val_14 + val_16;
                val_14 = val_14 + (-1f);
                val_16 = val_12 * val_14;
                val_9 = 1 + 1;
                val_14[1] = val_16;
            }
            while(val_9 != val_5);
        
        }
    
    }

}

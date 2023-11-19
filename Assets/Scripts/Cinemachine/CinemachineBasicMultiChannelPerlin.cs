using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    [UnityEngine.AddComponentMenu]
    [UnityEngine.RequireComponent]
    [Cinemachine.SaveDuringPlayAttribute]
    public class CinemachineBasicMultiChannelPerlin : CinemachineComponentBase
    {
        // Fields
        [UnityEngine.HideInInspector]
        [UnityEngine.TooltipAttribute]
        [UnityEngine.Serialization.FormerlySerializedAsAttribute]
        public Cinemachine.NoiseSettings m_NoiseProfile;
        [UnityEngine.TooltipAttribute]
        public float m_AmplitudeGain;
        [UnityEngine.TooltipAttribute]
        public float m_FrequencyGain;
        private bool mInitialized;
        private float mNoiseTime;
        private UnityEngine.Vector3 mNoiseOffsets;
        
        // Properties
        public override bool IsValid { get; }
        public override Cinemachine.CinemachineCore.Stage Stage { get; }
        
        // Methods
        public CinemachineBasicMultiChannelPerlin()
        {
            this.m_AmplitudeGain = 1f;
            this.m_FrequencyGain = 1f;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.mNoiseOffsets = val_1;
            mem[1152921511707212572] = val_1.y;
            mem[1152921511707212576] = val_1.z;
            this = new UnityEngine.MonoBehaviour();
        }
        public override bool get_IsValid()
        {
            if(this.enabled == false)
            {
                    return false;
            }
            
            return UnityEngine.Object.op_Inequality(x:  0, y:  this.m_NoiseProfile);
        }
        public override Cinemachine.CinemachineCore.Stage get_Stage()
        {
            return 2;
        }
        public override void MutateCameraState(ref Cinemachine.CameraState curState, float deltaTime)
        {
            Cinemachine.NoiseSettings val_12;
            float val_13;
            float val_14;
            val_13 = deltaTime;
            if(val_13 < 0)
            {
                    return;
            }
            
            if((this & 1) == 0)
            {
                    return;
            }
            
            bool val_12 = this.mInitialized;
            if((val_12 & 255) != false)
            {
                    val_12 = val_12 >> 32;
                val_14 = val_12;
            }
            else
            {
                    this.Initialize();
                val_14 = this.mNoiseTime;
            }
            
            float val_13 = this.m_FrequencyGain;
            val_13 = val_13 * val_13;
            val_14 = val_14 + val_13;
            this.mNoiseTime = val_14;
            UnityEngine.Vector3 val_3 = Cinemachine.CinemachineBasicMultiChannelPerlin.GetCombinedFilterResults(noiseParams:  this.m_NoiseProfile.PositionNoise, time:  this.mNoiseTime, noiseOffsets:  new UnityEngine.Vector3() {x = this.mNoiseOffsets});
            UnityEngine.Vector3 val_4 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = curState.<PositionCorrection>k__BackingField.y, y = val_13, z = V2.16B, w = V3.16B}, point:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            val_13 = val_4.x;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_13, y = val_4.y, z = val_4.z}, d:  this.m_AmplitudeGain);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = curState.<PositionCorrection>k__BackingField.x, y = curState.<PositionCorrection>k__BackingField.y, z = curState.<PositionCorrection>k__BackingField.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            curState.<PositionCorrection>k__BackingField.x = val_6.x;
            curState.<PositionCorrection>k__BackingField.y = val_6.y;
            curState.<PositionCorrection>k__BackingField.z = val_6.z;
            val_12 = this.m_NoiseProfile;
            UnityEngine.Vector3 val_8 = Cinemachine.CinemachineBasicMultiChannelPerlin.GetCombinedFilterResults(noiseParams:  val_12.OrientationNoise, time:  this.mNoiseTime, noiseOffsets:  new UnityEngine.Vector3() {x = this.mNoiseOffsets, y = val_6.z, z = val_5.x});
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  this.m_AmplitudeGain);
            UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = curState.<OrientationCorrection>k__BackingField.x, y = curState.<OrientationCorrection>k__BackingField.y, z = curState.<OrientationCorrection>k__BackingField.z, w = curState.<OrientationCorrection>k__BackingField.w}, rhs:  new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w});
            curState.<OrientationCorrection>k__BackingField.x = val_11.x;
            curState.<OrientationCorrection>k__BackingField.y = val_11.y;
            curState.<OrientationCorrection>k__BackingField.z = val_11.z;
            curState.<OrientationCorrection>k__BackingField.w = val_11.w;
        }
        private void Initialize()
        {
            this.mInitialized = true;
            this.mNoiseTime = 0f;
            float val_1 = UnityEngine.Random.Range(min:  -10000f, max:  10000f);
            float val_2 = UnityEngine.Random.Range(min:  -10000f, max:  10000f);
            float val_3 = UnityEngine.Random.Range(min:  -10000f, max:  10000f);
            this.mNoiseOffsets = 0;
            mem[1152921511707882268] = 0;
            mem[1152921511707882272] = 0;
        }
        private static UnityEngine.Vector3 GetCombinedFilterResults(Cinemachine.NoiseSettings.TransformNoiseParams[] noiseParams, float time, UnityEngine.Vector3 noiseOffsets)
        {
            float val_8;
            var val_9;
            var val_10;
            if(X1 == 0)
            {
                goto label_1;
            }
            
            val_8 = 0f;
            if((X1 + 24) < 1)
            {
                goto label_2;
            }
            
            do
            {
                var val_1 = X1 + (0 * 24);
                UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, d:  time);
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = noiseOffsets.x, y = noiseOffsets.y, z = noiseOffsets.z});
                float val_7 = (UnityEngine.Mathf.PerlinNoise(x:  val_3.x, y:  0f)) + (-0.5f);
                float val_8 = (UnityEngine.Mathf.PerlinNoise(x:  val_3.y, y:  0f)) + (-0.5f);
                val_3.z = (UnityEngine.Mathf.PerlinNoise(x:  val_3.z, y:  0f)) + (-0.5f);
                float val_10 = 0f;
                float val_11 = 0f;
                float val_12 = 0f;
                val_10 = ((0 * 24) + X1 + 32) * val_10;
                val_8 = val_8 + val_10;
                val_11 = ((0 * 24) + X1 + 36 + 4) * val_11;
                val_9 = val_8 + val_11;
                val_12 = ((0 * 24) + X1 + 44 + 4) * val_12;
                val_10 = val_8 + val_12;
            }
            while((0 + 1) < (X1 + 24));
            
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            label_1:
            val_10 = 0f;
            val_9 = val_10;
            val_8 = val_10;
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            label_2:
            val_10 = val_8;
            val_9 = val_8;
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
    
    }

}

using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    [Serializable]
    public struct AxisState
    {
        // Fields
        [Cinemachine.NoSaveDuringPlayAttribute]
        [UnityEngine.TooltipAttribute]
        public float Value;
        [UnityEngine.TooltipAttribute]
        public float m_MaxSpeed;
        [UnityEngine.TooltipAttribute]
        public float m_AccelTime;
        [UnityEngine.TooltipAttribute]
        public float m_DecelTime;
        [UnityEngine.Serialization.FormerlySerializedAsAttribute]
        [UnityEngine.TooltipAttribute]
        public string m_InputAxisName;
        [Cinemachine.NoSaveDuringPlayAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_InputAxisValue;
        [Cinemachine.NoSaveDuringPlayAttribute]
        [UnityEngine.TooltipAttribute]
        public bool m_InvertAxis;
        private float mCurrentSpeed;
        private float mMinValue;
        private float mMaxValue;
        private bool mWrapAround;
        private const float Epsilon = 0.0001;
        
        // Methods
        public AxisState(float maxSpeed, float accelTime, float decelTime, float val, string name, bool invert)
        {
            mem[1152921511723535492] = maxSpeed;
            this.m_InputAxisValue = accelTime;
            this.m_InvertAxis = decelTime;
            this.m_InputAxisName = val;
            this.mCurrentSpeed = name;
            this.mMaxValue = 0f;
            mem[1152921511723535525] = 0;
            this.mWrapAround = invert;
            mem[1152921511723535520] = 0;
        }
        public void Validate()
        {
            mem2[0] = ???;
            mem2[0] = ???;
            mem2[0] = W1 & 1;
        }
        public void SetThresholds(float minValue, float maxValue, bool wrapAround)
        {
            mem[1152921511723763620] = minValue;
            mem[1152921511723763624] = maxValue;
            mem[1152921511723763628] = wrapAround;
        }
        public bool Update(float deltaTime)
        {
        
        }
        private float GetMaxSpeed()
        {
        
        }
    
    }

}

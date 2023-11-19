using UnityEngine;

namespace Unitycoding.UIWidgets
{
    internal struct Vector3Tween : ITweenValue
    {
        // Fields
        private Unitycoding.UIWidgets.Vector3Tween.Vector3TweenCallback m_Target;
        private Unitycoding.UIWidgets.Vector3Tween.Vector3TweenFinishCallback m_OnFinish;
        private Unitycoding.UIWidgets.EasingEquations.EaseType m_EaseType;
        private UnityEngine.Vector3 m_StartValue;
        private UnityEngine.Vector3 m_TargetValue;
        private float m_Duration;
        private bool m_IgnoreTimeScale;
        
        // Properties
        public Unitycoding.UIWidgets.EasingEquations.EaseType easeType { get; set; }
        public UnityEngine.Vector3 startValue { get; set; }
        public UnityEngine.Vector3 targetValue { get; set; }
        public float duration { get; set; }
        public bool ignoreTimeScale { get; set; }
        
        // Methods
        public Unitycoding.UIWidgets.EasingEquations.EaseType get_easeType()
        {
            return (EaseType)this.m_TargetValue;
        }
        public void set_easeType(Unitycoding.UIWidgets.EasingEquations.EaseType value)
        {
            this.m_TargetValue = value;
        }
        public UnityEngine.Vector3 get_startValue()
        {
            return new UnityEngine.Vector3() {z = this.m_Duration};
        }
        public void set_startValue(UnityEngine.Vector3 value)
        {
            mem[1152921512648411940] = value.x;
            mem[1152921512648411944] = value.y;
            this.m_Duration = value.z;
        }
        public UnityEngine.Vector3 get_targetValue()
        {
            return new UnityEngine.Vector3() {x = this.m_IgnoreTimeScale};
        }
        public void set_targetValue(UnityEngine.Vector3 value)
        {
            this.m_IgnoreTimeScale = value.x;
            mem[1152921512648635956] = value.y;
            mem[1152921512648635960] = value.z;
        }
        public float get_duration()
        {
            return (float)S0;
        }
        public void set_duration(float value)
        {
            mem[1152921512648859964] = value;
        }
        public bool get_ignoreTimeScale()
        {
            return (bool)this;
        }
        public void set_ignoreTimeScale(bool value)
        {
            mem[1152921512649083968] = value;
        }
        public bool ValidTarget()
        {
            return (bool)(this.m_EaseType != 0) ? 1 : 0;
        }
        public void TweenValue(float floatPercentage)
        {
        
        }
        public void AddOnChangedCallback(UnityEngine.Events.UnityAction<UnityEngine.Vector3> callback)
        {
            var val_2 = mem[this.m_EaseType + 8];
            val_2 = this.m_EaseType + 8;
            if(val_2 == 0)
            {
                    UnityEngine.Events.UnityEvent val_1 = null;
                val_2 = val_1;
                val_1 = new UnityEngine.Events.UnityEvent();
                mem2[0] = val_2;
                if(null == 0)
            {
                    val_2 = 0;
            }
            
            }
            
            val_2.AddListener(call:  callback);
        }
        public void AddOnFinishCallback(UnityEngine.Events.UnityAction callback)
        {
            if((this.m_EaseType + 8) == 0)
            {
                    return;
            }
            
            this.m_EaseType + 8.Invoke();
        }
        public void OnFinish()
        {
            if(this == 0)
            {
                    return;
            }
            
            this.Invoke();
        }
    
    }

}

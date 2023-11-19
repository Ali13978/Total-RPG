using UnityEngine;

namespace Unitycoding.UIWidgets
{
    internal struct FloatTween : ITweenValue
    {
        // Fields
        private Unitycoding.UIWidgets.FloatTween.FloatTweenCallback m_Target;
        private Unitycoding.UIWidgets.FloatTween.FloatTweenFinishCallback m_OnFinish;
        private Unitycoding.UIWidgets.EasingEquations.EaseType m_EaseType;
        private float m_StartValue;
        private float m_TargetValue;
        private float m_Duration;
        private bool m_IgnoreTimeScale;
        
        // Properties
        public Unitycoding.UIWidgets.EasingEquations.EaseType easeType { get; set; }
        public float startValue { get; set; }
        public float targetValue { get; set; }
        public float duration { get; set; }
        public bool ignoreTimeScale { get; set; }
        
        // Methods
        public Unitycoding.UIWidgets.EasingEquations.EaseType get_easeType()
        {
            return (EaseType)this.m_IgnoreTimeScale;
        }
        public void set_easeType(Unitycoding.UIWidgets.EasingEquations.EaseType value)
        {
            this.m_IgnoreTimeScale = value;
        }
        public float get_startValue()
        {
            return (float)S0;
        }
        public void set_startValue(float value)
        {
            mem[1152921512645264100] = value;
        }
        public float get_targetValue()
        {
            return (float)S0;
        }
        public void set_targetValue(float value)
        {
            mem[1152921512645488104] = value;
        }
        public float get_duration()
        {
            return (float)S0;
        }
        public void set_duration(float value)
        {
            mem[1152921512645712108] = value;
        }
        public bool get_ignoreTimeScale()
        {
            return (bool)this;
        }
        public void set_ignoreTimeScale(bool value)
        {
            mem[1152921512645936112] = value;
        }
        public bool ValidTarget()
        {
            return (bool)(this.m_EaseType != 0) ? 1 : 0;
        }
        public void TweenValue(float floatPercentage)
        {
            var val_2 = mem[this.m_EaseType];
            val_2 = this.m_EaseType;
            if(val_2 == 0)
            {
                    FloatTween.FloatTweenCallback val_1 = null;
                val_2 = val_1;
                val_1 = new FloatTween.FloatTweenCallback();
                mem2[0] = val_2;
                if(null == 0)
            {
                    val_2 = 0;
            }
            
            }
            
            val_2.AddListener(call:  X1);
        }
        public void AddOnChangedCallback(UnityEngine.Events.UnityAction<float> callback)
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
            if(this.m_TargetValue == 0)
            {
                    return;
            }
            
            this.m_TargetValue.Invoke();
        }
    
    }

}

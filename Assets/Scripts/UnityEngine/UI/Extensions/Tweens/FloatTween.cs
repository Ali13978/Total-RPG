using UnityEngine;

namespace UnityEngine.UI.Extensions.Tweens
{
    public struct FloatTween : ITweenValue
    {
        // Fields
        private float m_StartFloat;
        private float m_TargetFloat;
        private float m_Duration;
        private bool m_IgnoreTimeScale;
        private UnityEngine.UI.Extensions.Tweens.FloatTween.FloatTweenCallback m_Target;
        private UnityEngine.UI.Extensions.Tweens.FloatTween.FloatFinishCallback m_Finish;
        
        // Properties
        public float startFloat { get; set; }
        public float targetFloat { get; set; }
        public float duration { get; set; }
        public bool ignoreTimeScale { get; set; }
        
        // Methods
        public float get_startFloat()
        {
            return (float)this.m_Target;
        }
        public void set_startFloat(float value)
        {
            this.m_Target = value;
        }
        public float get_targetFloat()
        {
            return (float)S0;
        }
        public void set_targetFloat(float value)
        {
            mem[1152921512664570116] = value;
        }
        public float get_duration()
        {
            return (float)this.m_Finish;
        }
        public void set_duration(float value)
        {
            this.m_Finish = value;
        }
        public bool get_ignoreTimeScale()
        {
            return (bool)this;
        }
        public void set_ignoreTimeScale(bool value)
        {
            mem[1152921512665026316] = value;
        }
        public void TweenValue(float floatPercentage)
        {
            var val_2 = mem[this.m_Target + 16];
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
            var val_2 = mem[this.m_Target + 24];
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
        
        }
        public bool GetIgnoreTimescale()
        {
            return (bool)this;
        }
        public float GetDuration()
        {
            return (float)this.m_Finish;
        }
        public bool ValidTarget()
        {
            return (bool)(X8 != 0) ? 1 : 0;
        }
        public void Finished()
        {
            if(this == 0)
            {
                    return;
            }
            
            this.Invoke();
        }
    
    }

}

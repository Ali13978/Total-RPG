using UnityEngine;

namespace UnityEngine.UI.Extensions.Tweens
{
    internal interface ITweenValue
    {
        // Properties
        public abstract bool ignoreTimeScale { get; }
        public abstract float duration { get; }
        
        // Methods
        public abstract void TweenValue(float floatPercentage); // 0
        public abstract bool get_ignoreTimeScale(); // 0
        public abstract float get_duration(); // 0
        public abstract bool ValidTarget(); // 0
        public abstract void Finished(); // 0
    
    }

}

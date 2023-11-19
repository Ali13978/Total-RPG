using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class FloatingLabelBaseUI : MonoBehaviour, IPoolable
    {
        // Fields
        public UnityEngine.Transform Transform;
        [UnityEngine.SerializeField]
        private UnityEngine.Animation _animation;
        
        // Methods
        public FloatingLabelBaseUI()
        {
        
        }
        private void Reset()
        {
            this.Transform = this.transform;
        }
        public virtual void Show()
        {
            if(0 == this._animation)
            {
                    return;
            }
            
            bool val_2 = this._animation.Play();
        }
        public virtual void OnPushedToPool()
        {
            if(0 == this._animation)
            {
                    return;
            }
            
            this._animation.enabled = false;
        }
        public virtual void OnPulledFromPool()
        {
            if(0 == this._animation)
            {
                    return;
            }
            
            this._animation.enabled = true;
        }
    
    }

}

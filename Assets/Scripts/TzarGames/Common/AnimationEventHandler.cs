using UnityEngine;

namespace TzarGames.Common
{
    public class AnimationEventHandler : TzarBehaviour
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<UnityEngine.AnimationEvent> OnAnimationEvent;
        
        // Methods
        public AnimationEventHandler()
        {
        
        }
        public void add_OnAnimationEvent(System.Action<UnityEngine.AnimationEvent> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnAnimationEvent);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511057216096 != this.OnAnimationEvent);
        
        }
        public void remove_OnAnimationEvent(System.Action<UnityEngine.AnimationEvent> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnAnimationEvent);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511057352672 != this.OnAnimationEvent);
        
        }
        public void HandleAnimationEvent(UnityEngine.AnimationEvent animEvent)
        {
            if(this.OnAnimationEvent == null)
            {
                    return;
            }
            
            this.OnAnimationEvent.Invoke(obj:  animEvent);
        }
        public override void OnPushedToPool()
        {
            this.OnPushedToPool();
            this.OnAnimationEvent = 0;
        }
    
    }

}

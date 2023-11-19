using UnityEngine;

namespace TzarGames.TzarHero
{
    public abstract class CharacterAnimationBase : TzarBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        protected float walkingSpeed;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.Common.TG_VoidDelegate OnAttackAnimCompleted;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.Common.TG_VoidDelegate OnDeathAnimCompleted;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<UnityEngine.AnimationEvent> OnAnimationEvent;
        
        // Methods
        protected CharacterAnimationBase()
        {
            this.walkingSpeed = 4f;
        }
        public abstract void SetMoveParameters(float speed, bool isGrounded); // 0
        public abstract void PlayAttackAnimation(int animNumber, float timeDuration); // 0
        public abstract void CancelAttackAnim(); // 0
        public abstract void SetAttackSpeed(float speed); // 0
        public abstract void EnableAnimation(bool enable); // 0
        public abstract void PlayAnimation(string animName, bool play); // 0
        public abstract void PlayAnimationOnce(string animName, System.Action finishedCallback); // 0
        public abstract void ResetToDefaultAnimation(); // 0
        public abstract void PlayAnimationQueued(string animName); // 0
        public void add_OnAttackAnimCompleted(TzarGames.Common.TG_VoidDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnAttackAnimCompleted);
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
            while(1152921511472551992 != this.OnAttackAnimCompleted);
        
        }
        public void remove_OnAttackAnimCompleted(TzarGames.Common.TG_VoidDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnAttackAnimCompleted);
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
            while(1152921511472688568 != this.OnAttackAnimCompleted);
        
        }
        public void add_OnDeathAnimCompleted(TzarGames.Common.TG_VoidDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnDeathAnimCompleted);
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
            while(1152921511472825152 != this.OnDeathAnimCompleted);
        
        }
        public void remove_OnDeathAnimCompleted(TzarGames.Common.TG_VoidDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnDeathAnimCompleted);
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
            while(1152921511472961728 != this.OnDeathAnimCompleted);
        
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
            while(1152921511473098312 != this.OnAnimationEvent);
        
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
            while(1152921511473234888 != this.OnAnimationEvent);
        
        }
        protected void RaiseOnAnimationEvent(UnityEngine.AnimationEvent animEvent)
        {
            if(this.OnAnimationEvent == null)
            {
                    return;
            }
            
            this.OnAnimationEvent.Invoke(obj:  animEvent);
        }
        protected void RaiseOnAttackAnimCompleted()
        {
            if(this.OnAttackAnimCompleted == null)
            {
                    return;
            }
            
            this.OnAttackAnimCompleted.Invoke();
        }
        protected void RaiseOnDeathAnimCompleted()
        {
            if(this.OnDeathAnimCompleted == null)
            {
                    return;
            }
            
            this.OnDeathAnimCompleted.Invoke();
        }
    
    }

}

using UnityEngine;

namespace TzarGames.TzarHero
{
    public class AnimHitEventHandler : MonoBehaviour, IPoolable
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.TzarHero.AnimationHitInfo> OnHit;
        
        // Methods
        public AnimHitEventHandler()
        {
        
        }
        public void add_OnHit(System.Action<TzarGames.TzarHero.AnimationHitInfo> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnHit);
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
            while(1152921511464440168 != this.OnHit);
        
        }
        public void remove_OnHit(System.Action<TzarGames.TzarHero.AnimationHitInfo> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnHit);
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
            while(1152921511464576744 != this.OnHit);
        
        }
        public void NotifyHitTime(TzarGames.TzarHero.AnimationHitInfo animationHitInfo)
        {
            if(this.OnHit == null)
            {
                    return;
            }
            
            this.OnHit.Invoke(obj:  animationHitInfo);
        }
        public void OnPulledFromPool()
        {
        
        }
        public void OnPushedToPool()
        {
            this.OnHit = 0;
        }
    
    }

}

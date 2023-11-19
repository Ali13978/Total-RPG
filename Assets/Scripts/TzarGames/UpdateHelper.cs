using UnityEngine;

namespace TzarGames
{
    public class UpdateHelper : MonoBehaviour
    {
        // Fields
        public float updateRate;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.Common.TG_VoidDelegate OnUpdate;
        private float lastUpdateTickTime;
        
        // Methods
        public UpdateHelper()
        {
            this.updateRate = 0.5f;
        }
        public void add_OnUpdate(TzarGames.Common.TG_VoidDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnUpdate);
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
            while(1152921511629307408 != this.OnUpdate);
        
        }
        public void remove_OnUpdate(TzarGames.Common.TG_VoidDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnUpdate);
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
            while(1152921511629443984 != this.OnUpdate);
        
        }
        private void internalUpdate()
        {
            if(this.OnUpdate == null)
            {
                    return;
            }
            
            this.OnUpdate.Invoke();
        }
        private void Update()
        {
            float val_1 = UnityEngine.Time.realtimeSinceStartup;
            val_1 = val_1 - this.lastUpdateTickTime;
            if(val_1 < this.updateRate)
            {
                    return;
            }
            
            this.lastUpdateTickTime = UnityEngine.Time.realtimeSinceStartup;
            if(this.OnUpdate == null)
            {
                    return;
            }
            
            this.OnUpdate.Invoke();
        }
    
    }

}

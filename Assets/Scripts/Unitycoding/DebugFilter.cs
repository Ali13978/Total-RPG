using UnityEngine;

namespace Unitycoding
{
    public class DebugFilter
    {
        // Fields
        private int level;
        private string prefix;
        
        // Methods
        public DebugFilter(Unitycoding.DebugFilter.FilterLevel level)
        {
            this.level = level;
        }
        public DebugFilter(Unitycoding.DebugFilter.FilterLevel level, string prefix)
        {
            val_1 = new System.Object();
            this.prefix = val_1;
            this.level = level;
        }
        public void LogInfo(object msg)
        {
            if(this.level < 2)
            {
                    return;
            }
            
            string val_1 = 0 + this.prefix + " ";
            UnityEngine.Debug.Log(message:  0);
        }
        public void LogWarning(object msg)
        {
            if(this.level < 1)
            {
                    return;
            }
            
            string val_1 = 0 + this.prefix + " ";
            UnityEngine.Debug.LogWarning(message:  0);
        }
        public void LogError(object msg)
        {
            if((this.level & 2147483648) != 0)
            {
                    return;
            }
            
            string val_1 = 0 + this.prefix + " ";
            UnityEngine.Debug.LogError(message:  0);
        }
    
    }

}

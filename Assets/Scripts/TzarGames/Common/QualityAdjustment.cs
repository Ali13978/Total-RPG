using UnityEngine;

namespace TzarGames.Common
{
    [Serializable]
    internal class QualityAdjustment
    {
        // Fields
        public bool change;
        public bool enable;
        
        // Methods
        private QualityAdjustment()
        {
            this.change = false;
            this.enable = false;
        }
    
    }

}

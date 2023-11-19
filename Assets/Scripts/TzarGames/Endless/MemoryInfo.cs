using UnityEngine;

namespace TzarGames.Endless
{
    [Serializable]
    internal class MemoryInfo
    {
        // Fields
        public int Amount;
        public int QualityLevel;
        public bool OverrideTargetFramerate;
        public int TargetFramerate;
        
        // Methods
        public MemoryInfo()
        {
            this.TargetFramerate = 30;
        }
    
    }

}

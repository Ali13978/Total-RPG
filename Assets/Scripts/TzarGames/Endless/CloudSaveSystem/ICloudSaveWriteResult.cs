using UnityEngine;

namespace TzarGames.Endless.CloudSaveSystem
{
    public interface ICloudSaveWriteResult
    {
        // Properties
        public abstract bool Success { get; }
        
        // Methods
        public abstract bool get_Success(); // 0
    
    }

}

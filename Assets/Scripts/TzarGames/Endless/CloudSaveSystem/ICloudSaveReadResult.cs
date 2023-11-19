using UnityEngine;

namespace TzarGames.Endless.CloudSaveSystem
{
    public interface ICloudSaveReadResult
    {
        // Properties
        public abstract bool Success { get; }
        public abstract byte[] Data { get; }
        
        // Methods
        public abstract bool get_Success(); // 0
        public abstract byte[] get_Data(); // 0
    
    }

}

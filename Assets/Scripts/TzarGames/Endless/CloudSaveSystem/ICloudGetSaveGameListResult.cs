using UnityEngine;

namespace TzarGames.Endless.CloudSaveSystem
{
    public interface ICloudGetSaveGameListResult
    {
        // Properties
        public abstract bool Success { get; }
        public abstract TzarGames.Endless.CloudSaveSystem.ICloudSaveGameFile[] Files { get; }
        
        // Methods
        public abstract bool get_Success(); // 0
        public abstract TzarGames.Endless.CloudSaveSystem.ICloudSaveGameFile[] get_Files(); // 0
    
    }

}

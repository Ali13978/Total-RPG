using UnityEngine;

namespace TzarGames.Endless.CloudSaveSystem
{
    public interface ICloudSaveGameProvider
    {
        // Methods
        public abstract void GetSaveGames(System.Action<TzarGames.Endless.CloudSaveSystem.ICloudGetSaveGameListResult> callback); // 0
        public abstract void Write(string file, System.TimeSpan playedTime, string description, byte[] data, System.Action<TzarGames.Endless.CloudSaveSystem.ICloudSaveWriteResult> callback); // 0
        public abstract void Read(string file, System.Action<TzarGames.Endless.CloudSaveSystem.ICloudSaveReadResult> callback); // 0
        public abstract bool IsReady(); // 0
        public abstract void Initialize(); // 0
    
    }

}

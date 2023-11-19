using UnityEngine;

namespace TzarGames.Endless.CloudSaveSystem
{
    public interface ICloudSaveGameFile
    {
        // Properties
        public abstract string Filename { get; }
        public abstract string Description { get; }
        public abstract System.DateTime Timestamp { get; }
        
        // Methods
        public abstract string get_Filename(); // 0
        public abstract string get_Description(); // 0
        public abstract System.DateTime get_Timestamp(); // 0
    
    }

}

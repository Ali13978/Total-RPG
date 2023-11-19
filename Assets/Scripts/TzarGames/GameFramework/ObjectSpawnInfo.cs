using UnityEngine;

namespace TzarGames.GameFramework
{
    [Serializable]
    public class ObjectSpawnInfo
    {
        // Fields
        public TzarGames.GameFramework.TzarBehaviour ObjectPrefab;
        public uint Count;
        public float SpawnInterval;
        public TzarGames.GameFramework.SpawnPoint[] ObjectSpawnPoints;
        
        // Methods
        public ObjectSpawnInfo()
        {
            this.SpawnInterval = 1f;
        }
    
    }

}

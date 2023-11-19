using UnityEngine;

namespace TzarGames.Endless
{
    [Serializable]
    public class ObjectSpawnInfo
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.TzarBehaviour objectPrefab;
        [UnityEngine.SerializeField]
        private int count;
        [UnityEngine.SerializeField]
        private float spawnInterval;
        
        // Properties
        public TzarGames.GameFramework.TzarBehaviour ObjectPrefab { get; }
        public int Count { get; }
        public float SpawnInterval { get; }
        
        // Methods
        public ObjectSpawnInfo()
        {
        
        }
        public TzarGames.GameFramework.TzarBehaviour get_ObjectPrefab()
        {
            return (TzarGames.GameFramework.TzarBehaviour)this.objectPrefab;
        }
        public int get_Count()
        {
            return (int)this.count;
        }
        public float get_SpawnInterval()
        {
            return (float)this.spawnInterval;
        }
    
    }

}

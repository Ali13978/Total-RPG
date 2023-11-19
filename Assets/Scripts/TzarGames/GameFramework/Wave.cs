using UnityEngine;

namespace TzarGames.GameFramework
{
    [Serializable]
    public class Wave
    {
        // Fields
        public string Name;
        public bool Enabled;
        public TzarGames.GameFramework.ObjectSpawnInfo[] Objects;
        public TzarGames.GameFramework.SpawnPoint[] WaveSpawnPoints;
        
        // Methods
        public Wave()
        {
            this.Enabled = true;
            this.Name = "Unknown wave";
        }
    
    }

}

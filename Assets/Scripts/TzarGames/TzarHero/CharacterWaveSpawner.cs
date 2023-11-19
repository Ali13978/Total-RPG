using UnityEngine;

namespace TzarGames.TzarHero
{
    public class CharacterWaveSpawner : WaveSpawner
    {
        // Methods
        public CharacterWaveSpawner()
        {
            mem[1152921511481640136] = 1;
            mem[1152921511481640140] = 1084227584;
            mem[1152921511481640160] = 5;
            val_1 = new TzarGames.GameFramework.Spawner();
        }
        protected override TzarGames.GameFramework.TzarBehaviour Spawn(TzarGames.GameFramework.TzarBehaviour objectPrefab, TzarGames.GameFramework.SpawnPoint[] spawnPoints)
        {
            var val_4;
            TzarGames.GameFramework.TzarBehaviour val_1 = this.Spawn(objectPrefab:  objectPrefab, spawnPoints:  spawnPoints);
            val_4 = 0;
            if(0 == val_1)
            {
                    return (TzarGames.GameFramework.TzarBehaviour)val_4;
            }
            
            0.Level = -1714984512;
            val_4 = val_1;
            return (TzarGames.GameFramework.TzarBehaviour)val_4;
        }
    
    }

}

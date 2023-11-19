using UnityEngine;

namespace TzarGames.Endless
{
    public class EndlessSpawnerLimiter : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private int maxSpawnedCount;
        [UnityEngine.SerializeField]
        private System.Collections.Generic.List<TzarGames.Endless.EndlessSpawner> spawners;
        
        // Properties
        public int MaxSpawnedCount { get; set; }
        
        // Methods
        public EndlessSpawnerLimiter()
        {
            this.maxSpawnedCount = 15;
        }
        public int get_MaxSpawnedCount()
        {
            return (int)this.maxSpawnedCount;
        }
        public void set_MaxSpawnedCount(int value)
        {
            this.maxSpawnedCount = value;
        }
        private void Start()
        {
            this.UpdateSpawnersList();
        }
        public void UpdateSpawnersList()
        {
            goto label_3;
            label_10:
            0 = 1;
            label_3:
            if(0 >= val_1.Length)
            {
                    return;
            }
            
            T val_3 = UnityEngine.Object.FindObjectsOfType<UnityEngine.Component>()[1];
            UnityEngine.Object.FindObjectsOfType<UnityEngine.Component>()[1] = this.spawners.Contains(item:  val_3);
            if((UnityEngine.Object.FindObjectsOfType<UnityEngine.Component>()[1]) == true)
            {
                goto label_10;
            }
            
            this.spawners.Add(item:  val_3);
            goto label_10;
        }
        private void Update()
        {
            var val_13;
            int val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            TzarGames.Endless.EndlessGameState val_1 = TzarGames.Endless.EndlessGameState.Instance;
            if(0 == val_1)
            {
                goto label_18;
            }
            
            TzarGames.Endless.ICharacterInfo val_3 = val_1.SelectedCharacter;
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_13 = val_3;
            if(val_3 >= 2)
            {
                goto label_10;
            }
            
            val_14 = 5;
            goto label_19;
            label_10:
            TzarGames.Endless.ICharacterInfo val_5 = val_1.SelectedCharacter;
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_15 = val_5;
            if(val_5 != 2)
            {
                goto label_18;
            }
            
            val_14 = 7;
            goto label_19;
            label_18:
            val_14 = this.maxSpawnedCount;
            label_19:
            val_16 = 0;
            val_17 = 0;
            goto label_20;
            label_25:
            val_17 = X21.SpawnedCount + val_17;
            val_16 = 1;
            label_20:
            if(val_16 >= this.spawners.Count)
            {
                goto label_22;
            }
            
            if(this.spawners.Item[1] != null)
            {
                goto label_25;
            }
            
            goto label_25;
            label_22:
            val_18 = 0;
            goto label_26;
            label_31:
            val_18 = 1;
            mem2[0] = (val_17 >= val_14) ? 1 : 0;
            label_26:
            if(val_18 >= this.spawners.Count)
            {
                    return;
            }
            
            if(this.spawners.Item[1] != null)
            {
                goto label_31;
            }
            
            goto label_31;
        }
    
    }

}

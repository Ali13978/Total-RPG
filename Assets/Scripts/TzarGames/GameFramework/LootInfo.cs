using UnityEngine;

namespace TzarGames.GameFramework
{
    [UnityEngine.CreateAssetMenuAttribute]
    public class LootInfo : ScriptableObject
    {
        // Fields
        [UnityEngine.SerializeField]
        private int maximumLootSpawnCount;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Loot[] loots;
        
        // Properties
        public int MaximumLootSpawnCount { get; }
        public TzarGames.GameFramework.Loot[] Loots { get; }
        
        // Methods
        public LootInfo()
        {
            this.maximumLootSpawnCount = 1;
        }
        public int get_MaximumLootSpawnCount()
        {
            return (int)this.maximumLootSpawnCount;
        }
        public TzarGames.GameFramework.Loot[] get_Loots()
        {
            return (TzarGames.GameFramework.Loot[])this.loots;
        }
    
    }

}

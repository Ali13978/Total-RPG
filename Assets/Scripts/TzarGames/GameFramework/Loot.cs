using UnityEngine;

namespace TzarGames.GameFramework
{
    [Serializable]
    public class Loot
    {
        // Fields
        [UnityEngine.SerializeField]
        public string Name;
        [UnityEngine.SerializeField]
        public int Chance;
        [UnityEngine.SerializeField]
        public TzarGames.GameFramework.Item Item;
        
        // Methods
        public Loot()
        {
            this.Chance = 10;
        }
        public static int CompareChanceFromMinimal(TzarGames.GameFramework.Loot x, TzarGames.GameFramework.Loot y)
        {
            return (int)(y.Chance < (X2 + 24)) ? (-1) : 1;
        }
    
    }

}

using UnityEngine;

namespace TzarGames.GameFramework
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class Shield : Armor, IBlockChanceItem
    {
        // Fields
        [UnityEngine.SerializeField]
        private float blockChance;
        
        // Properties
        public float BlockChance { get; }
        
        // Methods
        public Shield()
        {
            this.blockChance = 1f;
        }
        public float get_BlockChance()
        {
            return (float)this.blockChance;
        }
    
    }

}

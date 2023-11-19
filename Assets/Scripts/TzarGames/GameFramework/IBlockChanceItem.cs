using UnityEngine;

namespace TzarGames.GameFramework
{
    public interface IBlockChanceItem
    {
        // Properties
        public abstract float BlockChance { get; }
        
        // Methods
        public abstract float get_BlockChance(); // 0
    
    }

}

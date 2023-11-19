using UnityEngine;

namespace TzarGames.TzarHero.Interfaces
{
    public interface IItemDatabaseProvider
    {
        // Properties
        public abstract TzarGames.GameFramework.ItemDatabaseData ItemDatabase { get; }
        
        // Methods
        public abstract TzarGames.GameFramework.ItemDatabaseData get_ItemDatabase(); // 0
    
    }

}

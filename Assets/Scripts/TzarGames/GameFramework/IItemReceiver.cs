using UnityEngine;

namespace TzarGames.GameFramework
{
    public interface IItemReceiver
    {
        // Properties
        public abstract uint Id { get; }
        
        // Methods
        public abstract uint get_Id(); // 0
        public abstract bool TakeItem(TzarGames.GameFramework.ItemInstance itemInstance, TzarGames.GameFramework.IDropperInfo dropperInfo); // 0
    
    }

}

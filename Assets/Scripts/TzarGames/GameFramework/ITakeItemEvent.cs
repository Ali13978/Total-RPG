using UnityEngine;

namespace TzarGames.GameFramework
{
    public interface ITakeItemEvent
    {
        // Properties
        public abstract TzarGames.GameFramework.IItemReceiver Receiver { get; }
        public abstract TzarGames.GameFramework.IDropperInfo Dropper { get; }
        public abstract TzarGames.GameFramework.ItemInstance ItemInstance { get; }
        
        // Methods
        public abstract TzarGames.GameFramework.IItemReceiver get_Receiver(); // 0
        public abstract TzarGames.GameFramework.IDropperInfo get_Dropper(); // 0
        public abstract TzarGames.GameFramework.ItemInstance get_ItemInstance(); // 0
    
    }

}

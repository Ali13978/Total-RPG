using UnityEngine;

namespace TzarGames.Endless
{
    public interface IItemNotificatorHandler
    {
        // Methods
        public abstract void OnNewItemsAvailable(TzarGames.GameFramework.Item[] items); // 0
    
    }

}

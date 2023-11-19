using UnityEngine;

namespace TzarGames.GameFramework.Events
{
    [Serializable]
    public class ItemTakeEvent : UnityEvent<TzarGames.GameFramework.ITakeItemEvent>
    {
        // Methods
        public ItemTakeEvent()
        {
        
        }
    
    }

}

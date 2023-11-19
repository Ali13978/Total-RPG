using UnityEngine;

namespace TzarGames.GameFramework.Events
{
    [Serializable]
    public class HitEvent : UnityEvent<TzarGames.GameFramework.IHit>
    {
        // Methods
        public HitEvent()
        {
        
        }
    
    }

}

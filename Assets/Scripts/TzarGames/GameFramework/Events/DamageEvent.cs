using UnityEngine;

namespace TzarGames.GameFramework.Events
{
    [Serializable]
    public class DamageEvent : UnityEvent<TzarGames.GameFramework.IDamageInfo>
    {
        // Methods
        public DamageEvent()
        {
        
        }
    
    }

}

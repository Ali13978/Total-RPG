using UnityEngine;

namespace TzarGames.TzarHero
{
    [Serializable]
    public class CharacterDeadEvent : UnityEvent<TzarGames.TzarHero.DeadEventData>
    {
        // Methods
        public CharacterDeadEvent()
        {
        
        }
    
    }

}

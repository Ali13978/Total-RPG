using UnityEngine;

namespace TzarGames.TzarHero
{
    [Serializable]
    public class CharacterHitEvent : UnityEvent<TzarGames.TzarHero.ICharacterDamageInfo>
    {
        // Methods
        public CharacterHitEvent()
        {
        
        }
    
    }

}

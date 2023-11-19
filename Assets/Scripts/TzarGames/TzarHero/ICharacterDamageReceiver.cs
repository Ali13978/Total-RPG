using UnityEngine;

namespace TzarGames.TzarHero
{
    public interface ICharacterDamageReceiver : IDamageReceiver
    {
        // Methods
        public abstract void TakeDamage(TzarGames.TzarHero.CharacterDamageInfo damageInfo); // 0
    
    }

}

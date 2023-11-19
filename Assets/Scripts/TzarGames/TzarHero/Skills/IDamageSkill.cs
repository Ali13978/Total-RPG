using UnityEngine;

namespace TzarGames.TzarHero.Skills
{
    public interface IDamageSkill
    {
        // Properties
        public abstract TzarGames.GameFramework.CharacteristicModificator DamageModificator { get; }
        
        // Methods
        public abstract TzarGames.GameFramework.CharacteristicModificator get_DamageModificator(); // 0
    
    }

}

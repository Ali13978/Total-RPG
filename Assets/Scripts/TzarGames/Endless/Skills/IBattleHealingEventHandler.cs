using UnityEngine;

namespace TzarGames.Endless.Skills
{
    public interface IBattleHealingEventHandler
    {
        // Methods
        public abstract void OnCharacterHealed(TzarGames.TzarHero.TH_Character character, float healValue); // 0
    
    }

}

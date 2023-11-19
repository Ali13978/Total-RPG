using UnityEngine;

namespace TzarGames.TzarHero
{
    internal interface ICharacterEvents
    {
        // Methods
        public abstract void OnCharacterDead(TzarGames.TzarHero.TH_Character deadCharacter, TzarGames.TzarHero.TH_Character killer); // 0
        public abstract void OnCharacterAlive(TzarGames.TzarHero.TH_Character character); // 0
        public abstract void OnPlayerCharacterSpawn(TzarGames.TzarHero.TH_Character character); // 0
    
    }

}

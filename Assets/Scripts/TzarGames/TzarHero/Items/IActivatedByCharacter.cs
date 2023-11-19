using UnityEngine;

namespace TzarGames.TzarHero.Items
{
    public interface IActivatedByCharacter
    {
        // Methods
        public abstract bool CanBeActivatedOnCharacter(TzarGames.TzarHero.TH_CharacterTemplate characterTemplate, TzarGames.GameFramework.ItemInstance itemInstance); // 0
        public abstract void OnActivatedOnCharacter(TzarGames.TzarHero.TH_CharacterTemplate characterTemplate, TzarGames.GameFramework.ItemInstance itemInstance); // 0
        public abstract void OnDeactivatedOnCharacter(TzarGames.TzarHero.TH_CharacterTemplate characterTemplate, TzarGames.GameFramework.ItemInstance itemInstance); // 0
    
    }

}

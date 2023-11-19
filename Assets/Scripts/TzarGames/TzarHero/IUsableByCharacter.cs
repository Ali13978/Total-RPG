using UnityEngine;

namespace TzarGames.TzarHero
{
    public interface IUsableByCharacter
    {
        // Methods
        public abstract bool ApplyToCharacter(TzarGames.TzarHero.TH_Character character); // 0
        public abstract bool MustBeDestroyedAfterUse(); // 0
    
    }

}

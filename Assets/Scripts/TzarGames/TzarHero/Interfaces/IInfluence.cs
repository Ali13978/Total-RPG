using UnityEngine;

namespace TzarGames.TzarHero.Interfaces
{
    public interface IInfluence
    {
        // Properties
        public abstract TzarGames.TzarHero.TH_Character Instigator { get; }
        
        // Methods
        public abstract TzarGames.TzarHero.TH_Character get_Instigator(); // 0
        public abstract void OnAddedToCharacter(TzarGames.TzarHero.TH_Character character); // 0
        public abstract void OnRemovedFromCharacter(TzarGames.TzarHero.TH_Character character); // 0
        public abstract void Update(float timeDelta); // 0
    
    }

}

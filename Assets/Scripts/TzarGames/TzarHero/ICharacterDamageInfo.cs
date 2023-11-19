using UnityEngine;

namespace TzarGames.TzarHero
{
    public interface ICharacterDamageInfo : IDamageInfo
    {
        // Properties
        public abstract bool IsCritical { get; }
        public abstract float CriticalDamage { get; }
        public abstract bool IgnoreDefence { get; }
        public abstract bool IsAuthoritative { get; }
        public abstract TzarGames.TzarHero.TH_Character Instigator { get; }
        public abstract TzarGames.TzarHero.TH_Character Victim { get; }
        
        // Methods
        public abstract bool get_IsCritical(); // 0
        public abstract float get_CriticalDamage(); // 0
        public abstract bool get_IgnoreDefence(); // 0
        public abstract bool get_IsAuthoritative(); // 0
        public abstract TzarGames.TzarHero.TH_Character get_Instigator(); // 0
        public abstract TzarGames.TzarHero.TH_Character get_Victim(); // 0
    
    }

}

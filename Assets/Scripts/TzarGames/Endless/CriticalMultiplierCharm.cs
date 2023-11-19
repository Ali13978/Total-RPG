using UnityEngine;

namespace TzarGames.Endless
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class CriticalMultiplierCharm : Charm<TzarGames.Endless.CriticalMultiplierCharm.CritMultiplierCharmModificator>
    {
        // Methods
        public CriticalMultiplierCharm()
        {
        
        }
        protected override TzarGames.GameFramework.Characteristic getCharacteristic(TzarGames.TzarHero.TH_CharacterTemplate template)
        {
            if(template != null)
            {
                    return template.CritMultiplierCharacteristic;
            }
            
            return template.CritMultiplierCharacteristic;
        }
    
    }

}

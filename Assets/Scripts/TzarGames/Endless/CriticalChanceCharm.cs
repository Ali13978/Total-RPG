using UnityEngine;

namespace TzarGames.Endless
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class CriticalChanceCharm : Charm<TzarGames.Endless.CriticalChanceCharm.CritChanceCharmModificator>
    {
        // Methods
        public CriticalChanceCharm()
        {
        
        }
        protected override TzarGames.GameFramework.Characteristic getCharacteristic(TzarGames.TzarHero.TH_CharacterTemplate template)
        {
            if(template != null)
            {
                    return template.CritChanceCharacteristic;
            }
            
            return template.CritChanceCharacteristic;
        }
    
    }

}

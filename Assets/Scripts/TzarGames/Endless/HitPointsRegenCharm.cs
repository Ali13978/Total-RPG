using UnityEngine;

namespace TzarGames.Endless
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class HitPointsRegenCharm : Charm<TzarGames.Endless.HitPointsRegenCharm.HitPointsRegenCharmModificator>
    {
        // Methods
        public HitPointsRegenCharm()
        {
        
        }
        protected override TzarGames.GameFramework.Characteristic getCharacteristic(TzarGames.TzarHero.TH_CharacterTemplate template)
        {
            if(template != null)
            {
                    return template.HitPointsRegenerationSpeedCharacteristic;
            }
            
            return template.HitPointsRegenerationSpeedCharacteristic;
        }
    
    }

}

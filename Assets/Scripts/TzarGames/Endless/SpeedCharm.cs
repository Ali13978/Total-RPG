using UnityEngine;

namespace TzarGames.Endless
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class SpeedCharm : Charm<TzarGames.Endless.SpeedCharm.SpeedCharmModificator>
    {
        // Methods
        public SpeedCharm()
        {
        
        }
        protected override TzarGames.GameFramework.Characteristic getCharacteristic(TzarGames.TzarHero.TH_CharacterTemplate template)
        {
            if(template != null)
            {
                    return template.WalkingSpeedCharacteristic;
            }
            
            return template.WalkingSpeedCharacteristic;
        }
    
    }

}

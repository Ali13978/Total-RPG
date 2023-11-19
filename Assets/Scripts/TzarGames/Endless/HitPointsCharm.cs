using UnityEngine;

namespace TzarGames.Endless
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class HitPointsCharm : Charm<TzarGames.Endless.HitPointsCharm.HitPointsCharmModificator>
    {
        // Methods
        public HitPointsCharm()
        {
        
        }
        protected override TzarGames.GameFramework.Characteristic getCharacteristic(TzarGames.TzarHero.TH_CharacterTemplate template)
        {
            if(template != null)
            {
                    return template.HitPointsCharacteristic;
            }
            
            return template.HitPointsCharacteristic;
        }
    
    }

}

using UnityEngine;

namespace TzarGames.Endless
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class AttackSpeedCharm : Charm<TzarGames.Endless.AttackSpeedCharm.AttackSpeedCharmModificator>
    {
        // Methods
        public AttackSpeedCharm()
        {
        
        }
        protected override TzarGames.GameFramework.Characteristic getCharacteristic(TzarGames.TzarHero.TH_CharacterTemplate template)
        {
            if(template != null)
            {
                    return template.AttackSpeedCharacteristic;
            }
            
            return template.AttackSpeedCharacteristic;
        }
    
    }

}

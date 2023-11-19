using UnityEngine;

namespace TzarGames.Endless
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class DamageCharm : Charm<TzarGames.Endless.DamageCharm.DamageCharmModificator>
    {
        // Methods
        public DamageCharm()
        {
        
        }
        protected override TzarGames.GameFramework.Characteristic getCharacteristic(TzarGames.TzarHero.TH_CharacterTemplate template)
        {
            if(template != null)
            {
                    return template.DamageCharacteristic;
            }
            
            return template.DamageCharacteristic;
        }
    
    }

}

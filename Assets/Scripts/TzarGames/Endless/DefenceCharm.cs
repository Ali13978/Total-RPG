using UnityEngine;

namespace TzarGames.Endless
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class DefenceCharm : Charm<TzarGames.Endless.DefenceCharm.DefenceCharmModificator>
    {
        // Methods
        public DefenceCharm()
        {
        
        }
        protected override TzarGames.GameFramework.Characteristic getCharacteristic(TzarGames.TzarHero.TH_CharacterTemplate template)
        {
            if(template != null)
            {
                    return template.DefenceCharacteristic;
            }
            
            return template.DefenceCharacteristic;
        }
    
    }

}

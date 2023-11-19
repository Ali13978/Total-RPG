using UnityEngine;

namespace TzarGames.Endless
{
    public class DamageBoostTimer : CharacteristicBoostTimer
    {
        // Fields
        private const string prefix_key = "DAMAGE_BOOST";
        
        // Methods
        public DamageBoostTimer(TzarGames.TzarHero.TH_Character character, TzarGames.Common.SerializableData data)
        {
        
        }
        protected override string GetPrefixSerializationKey()
        {
            return "DAMAGE_BOOST";
        }
        protected override TzarGames.GameFramework.Characteristic getCharacteristic(TzarGames.GameFramework.CharacterTemplate template)
        {
            if(template != null)
            {
                    return template.DamageCharacteristic;
            }
            
            return template.DamageCharacteristic;
        }
        protected override TzarGames.GameFramework.CharacteristicModificator CreateModificator()
        {
            return (TzarGames.GameFramework.CharacteristicModificator)new TzarGames.TzarHero.DamageModificator();
        }
    
    }

}

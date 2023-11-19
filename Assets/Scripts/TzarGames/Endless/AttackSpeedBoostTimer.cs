using UnityEngine;

namespace TzarGames.Endless
{
    public class AttackSpeedBoostTimer : CharacteristicBoostTimer
    {
        // Fields
        private const string prefix_key = "ATTACKSPEED_BOOST";
        
        // Methods
        public AttackSpeedBoostTimer(TzarGames.TzarHero.TH_Character character, TzarGames.Common.SerializableData data)
        {
        
        }
        protected override string GetPrefixSerializationKey()
        {
            return "ATTACKSPEED_BOOST";
        }
        protected override TzarGames.GameFramework.Characteristic getCharacteristic(TzarGames.GameFramework.CharacterTemplate template)
        {
            if(template != null)
            {
                    return template.AttackSpeedCharacteristic;
            }
            
            return template.AttackSpeedCharacteristic;
        }
        protected override TzarGames.GameFramework.CharacteristicModificator CreateModificator()
        {
            return (TzarGames.GameFramework.CharacteristicModificator)new TzarGames.TzarHero.AttackSpeedModificator();
        }
    
    }

}

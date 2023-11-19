using UnityEngine;

namespace TzarGames.Endless
{
    public class SpeedBoostTimer : CharacteristicBoostTimer
    {
        // Fields
        private const string prefix_key = "SPEED_BOOST";
        
        // Methods
        public SpeedBoostTimer(TzarGames.TzarHero.TH_Character character, TzarGames.Common.SerializableData data)
        {
        
        }
        protected override string GetPrefixSerializationKey()
        {
            return "SPEED_BOOST";
        }
        protected override TzarGames.GameFramework.Characteristic getCharacteristic(TzarGames.GameFramework.CharacterTemplate template)
        {
            if(template != null)
            {
                    return template.WalkingSpeedCharacteristic;
            }
            
            return template.WalkingSpeedCharacteristic;
        }
        protected override TzarGames.GameFramework.CharacteristicModificator CreateModificator()
        {
            return (TzarGames.GameFramework.CharacteristicModificator)new TzarGames.TzarHero.SpeedModificator();
        }
    
    }

}

using UnityEngine;

namespace TzarGames.Endless
{
    public class DefenceBoostTimer : CharacteristicBoostTimer
    {
        // Fields
        private const string prefix_key = "DEFENCE_BOOST";
        
        // Methods
        public DefenceBoostTimer(TzarGames.TzarHero.TH_Character character, TzarGames.Common.SerializableData data)
        {
        
        }
        protected override string GetPrefixSerializationKey()
        {
            return "DEFENCE_BOOST";
        }
        protected override TzarGames.GameFramework.Characteristic getCharacteristic(TzarGames.GameFramework.CharacterTemplate template)
        {
            if(template != null)
            {
                    return template.DefenceCharacteristic;
            }
            
            return template.DefenceCharacteristic;
        }
        protected override TzarGames.GameFramework.CharacteristicModificator CreateModificator()
        {
            return (TzarGames.GameFramework.CharacteristicModificator)new TzarGames.TzarHero.DefenceModificator();
        }
    
    }

}

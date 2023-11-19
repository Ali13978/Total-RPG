using UnityEngine;

namespace TzarGames.TzarHero
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class SpeedBoostItem : TimeEffectBoostItem
    {
        // Fields
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private float boostMultiplier;
        private static TzarGames.TzarHero.SpeedModificator modificator;
        
        // Properties
        public override TzarGames.GameFramework.CharacteristicModificator Modificator { get; }
        
        // Methods
        public SpeedBoostItem()
        {
            this.boostMultiplier = 1.2f;
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            if(TzarGames.TzarHero.SpeedBoostItem.modificator != null)
            {
                    return;
            }
            
            TzarGames.TzarHero.SpeedBoostItem.modificator = new TzarGames.TzarHero.TimeEffectModificator();
            typeof(TzarGames.TzarHero.SpeedModificator).__il2cppRuntimeField_10 = 0;
            typeof(TzarGames.TzarHero.SpeedModificator).__il2cppRuntimeField_18 = 2;
            Value = this.boostMultiplier;
            typeof(TzarGames.TzarHero.SpeedModificator).__il2cppRuntimeField_20 = this.EffectTime;
        }
        public override bool ApplyToCharacter(TzarGames.TzarHero.TH_Character character)
        {
            bool val_1 = this.ApplyToCharacter(character:  character);
            this.AddModificator(modificator:  TzarGames.TzarHero.SpeedBoostItem.modificator);
            return true;
        }
        public override bool CanBeStoredInInventory()
        {
            return false;
        }
        public override TzarGames.GameFramework.Characteristic GetModifiableCharacteristic(TzarGames.GameFramework.CharacterTemplate template)
        {
            if(template != null)
            {
                    return template.WalkingSpeedCharacteristic;
            }
            
            return template.WalkingSpeedCharacteristic;
        }
        public override TzarGames.GameFramework.CharacteristicModificator get_Modificator()
        {
            return (TzarGames.GameFramework.CharacteristicModificator)TzarGames.TzarHero.SpeedBoostItem.modificator;
        }
    
    }

}

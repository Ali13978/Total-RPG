using UnityEngine;

namespace TzarGames.TzarHero
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class DefenceBoostItem : TimeEffectBoostItem
    {
        // Fields
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private float boostMultiplier;
        private static TzarGames.TzarHero.DefenceModificator modificator;
        
        // Properties
        public override TzarGames.GameFramework.CharacteristicModificator Modificator { get; }
        
        // Methods
        public DefenceBoostItem()
        {
            this.boostMultiplier = 1.1f;
        }
        protected override void OnEnable()
        {
            var val_3;
            var val_4;
            this.OnEnable();
            val_3 = null;
            val_3 = null;
            if(TzarGames.TzarHero.DefenceBoostItem.modificator != null)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            TzarGames.TzarHero.DefenceBoostItem.modificator = new TzarGames.TzarHero.TimeEffectModificator();
            typeof(TzarGames.TzarHero.DefenceModificator).__il2cppRuntimeField_10 = 0;
            typeof(TzarGames.TzarHero.DefenceModificator).__il2cppRuntimeField_18 = 2;
            Value = this.boostMultiplier;
            typeof(TzarGames.TzarHero.DefenceModificator).__il2cppRuntimeField_20 = this.EffectTime;
        }
        public override bool ApplyToCharacter(TzarGames.TzarHero.TH_Character character)
        {
            var val_3;
            bool val_1 = this.ApplyToCharacter(character:  character);
            TzarGames.TzarHero.TH_CharacterTemplate val_2 = character.TemplateInstance;
            val_3 = null;
            val_3 = null;
            this.AddModificator(modificator:  TzarGames.TzarHero.DefenceBoostItem.modificator);
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
                    return template.DefenceCharacteristic;
            }
            
            return template.DefenceCharacteristic;
        }
        public override TzarGames.GameFramework.CharacteristicModificator get_Modificator()
        {
            null = null;
            return (TzarGames.GameFramework.CharacteristicModificator)TzarGames.TzarHero.DefenceBoostItem.modificator;
        }
        private static DefenceBoostItem()
        {
        
        }
    
    }

}

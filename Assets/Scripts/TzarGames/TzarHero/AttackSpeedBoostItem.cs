using UnityEngine;

namespace TzarGames.TzarHero
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class AttackSpeedBoostItem : TimeEffectBoostItem
    {
        // Fields
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private float boostMultiplier;
        private static TzarGames.TzarHero.AttackSpeedModificator modificator;
        
        // Properties
        public override TzarGames.GameFramework.CharacteristicModificator Modificator { get; }
        
        // Methods
        public AttackSpeedBoostItem()
        {
            this.boostMultiplier = 1.2f;
        }
        protected override void OnEnable()
        {
            var val_3;
            float val_4;
            var val_5;
            this.OnEnable();
            val_3 = null;
            val_3 = null;
            if(TzarGames.TzarHero.AttackSpeedBoostItem.modificator != null)
            {
                    return;
            }
            
            if(null != 0)
            {
                    typeof(TzarGames.TzarHero.AttackSpeedModificator).__il2cppRuntimeField_18 = 2;
                typeof(TzarGames.TzarHero.AttackSpeedModificator).__il2cppRuntimeField_10 = 0;
                val_4 = this.boostMultiplier;
            }
            else
            {
                    mem[16] = 0;
                mem[24] = 2;
                val_4 = this.boostMultiplier;
            }
            
            Value = val_4;
            typeof(TzarGames.TzarHero.AttackSpeedModificator).__il2cppRuntimeField_20 = this.EffectTime;
            val_5 = null;
            val_5 = null;
            TzarGames.TzarHero.AttackSpeedBoostItem.modificator = new TzarGames.TzarHero.TimeEffectModificator();
        }
        public override bool ApplyToCharacter(TzarGames.TzarHero.TH_Character character)
        {
            var val_3;
            bool val_1 = this.ApplyToCharacter(character:  character);
            TzarGames.TzarHero.TH_CharacterTemplate val_2 = character.TemplateInstance;
            val_3 = null;
            val_3 = null;
            this.AddModificator(modificator:  TzarGames.TzarHero.AttackSpeedBoostItem.modificator);
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
                    return template.AttackSpeedCharacteristic;
            }
            
            return template.AttackSpeedCharacteristic;
        }
        public override TzarGames.GameFramework.CharacteristicModificator get_Modificator()
        {
            null = null;
            return (TzarGames.GameFramework.CharacteristicModificator)TzarGames.TzarHero.AttackSpeedBoostItem.modificator;
        }
        private static AttackSpeedBoostItem()
        {
        
        }
    
    }

}

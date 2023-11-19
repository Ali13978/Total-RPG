using UnityEngine;

namespace TzarGames.TzarHero.Influences
{
    public class WalkingSpeedInfluence : IInfluence
    {
        // Fields
        private TzarGames.GameFramework.CharacteristicModificator modificator;
        private TzarGames.TzarHero.TH_Character target;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.TzarHero.TH_Character <Instigator>k__BackingField;
        
        // Properties
        public TzarGames.TzarHero.TH_Character Target { get; }
        public TzarGames.TzarHero.TH_Character Instigator { get; set; }
        
        // Methods
        public WalkingSpeedInfluence(TzarGames.TzarHero.TH_Character instigator, float modificatorValue, TzarGames.GameFramework.ModificatorOperators modificatorOperator)
        {
            this.modificator = new TzarGames.GameFramework.CharacteristicModificator(value:  modificatorValue);
            typeof(TzarGames.GameFramework.CharacteristicModificator).__il2cppRuntimeField_18 = modificatorOperator;
            this.modificator.ModificationMode = 0;
            this.target = 0;
            this.<Instigator>k__BackingField = instigator;
        }
        public TzarGames.TzarHero.TH_Character get_Target()
        {
            return (TzarGames.TzarHero.TH_Character)this.target;
        }
        public TzarGames.TzarHero.TH_Character get_Instigator()
        {
            return (TzarGames.TzarHero.TH_Character)this.<Instigator>k__BackingField;
        }
        public void set_Instigator(TzarGames.TzarHero.TH_Character value)
        {
            this.<Instigator>k__BackingField = value;
        }
        public virtual void OnAddedToCharacter(TzarGames.TzarHero.TH_Character character)
        {
            if(0 != this.target)
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            character.TemplateInstance.WalkingSpeedCharacteristic.AddModificator(modificator:  this.modificator);
        }
        public virtual void OnRemovedFromCharacter(TzarGames.TzarHero.TH_Character character)
        {
            this.target = 0;
            character.TemplateInstance.WalkingSpeedCharacteristic.UnregisterModificator(modificator:  this.modificator);
        }
        public void Update(float timeDelta)
        {
        
        }
    
    }

}

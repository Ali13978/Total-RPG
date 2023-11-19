using UnityEngine;

namespace TzarGames.Endless.Skills
{
    public class ComboStrike : AnimBasedAttackSkill
    {
        // Fields
        private int currentSlot;
        
        // Methods
        public ComboStrike()
        {
        
        }
        protected override void OnStarted()
        {
            var val_5;
            this.OnStarted();
            this.currentSlot = 0;
            TzarGames.TzarHero.TH_Character val_1 = this.Character;
            if(val_1 != null)
            {
                    val_5 = null;
                val_5 = null;
                val_1 = (((TzarGames.TzarHero.TH_Character.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.PlayerCharacter.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_5) ? (val_1) : 0;
            }
            
            TzarGames.GameFramework.Weapon val_2 = 0.ActivateWeaponModificators(slot:  this.currentSlot);
            this.Character.IgnoreDamage.AddModificator(owner:  this, value:  true, booleanOperator:  1);
        }
        protected override void OnCharacterRemoved(TzarGames.TzarHero.TH_Character character)
        {
            this.OnCharacterRemoved(character:  character);
            character.IgnoreDamage.RemoveModificator(owner:  this);
        }
        protected override void OnStopped()
        {
            this.OnStopped();
            this.Character.IgnoreDamage.RemoveModificator(owner:  this);
        }
        protected override void onHit(TzarGames.TzarHero.CharacterDamageInfo hit)
        {
            var val_4;
            var val_5;
            this.onHit(hit:  hit);
            this.currentSlot = (this.currentSlot == 0) ? 1 : 0;
            TzarGames.TzarHero.TH_Character val_2 = this.Character;
            if(val_2 != null)
            {
                    val_4 = 1152921504871968768;
                val_5 = null;
                val_5 = null;
                val_2 = (((TzarGames.TzarHero.TH_Character.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.PlayerCharacter.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_5) ? (val_2) : 0;
            }
            
            TzarGames.GameFramework.Weapon val_3 = 0.ActivateWeaponModificators(slot:  this.currentSlot);
        }
        public override bool Validate()
        {
            if(this.Character != null)
            {
                    0 = 0;
            }
            
            if(0 == )
            {
                    return false;
            }
            
            if(0 != SecondWeapon)
            {
                    return this.Validate();
            }
            
            return false;
        }
    
    }

}

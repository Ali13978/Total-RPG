using UnityEngine;

namespace TzarGames.Endless.Skills
{
    public class ThrowProjectileSkill : AnimBasedAttackSkill
    {
        // Methods
        public ThrowProjectileSkill()
        {
        
        }
        public override bool Validate()
        {
            var val_7;
            var val_8;
            if(this.Character.Target == null)
            {
                    return this.Validate();
            }
            
            TzarGames.TzarHero.TH_InteractiveObject val_4 = this.Character.Target;
            if(val_4 != null)
            {
                    val_7 = null;
                val_7 = null;
                val_4 = (((TzarGames.TzarHero.TH_InteractiveObject.__il2cppRuntimeField_typeHierarchy + (TzarGames.TzarHero.TH_Character.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_7) ? (val_4) : 0;
            }
            else
            {
                    val_8 = 0;
            }
            
            if(val_8.isDead == false)
            {
                    return this.Validate();
            }
            
            return false;
        }
    
    }

}

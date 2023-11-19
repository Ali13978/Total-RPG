using UnityEngine;

namespace TzarGames.Endless.Skills
{
    public class SpreadRangeAttackSkill : AnimationBasedSkill
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Weapon weapon;
        private int currentFireSourceIndex;
        
        // Methods
        public SpreadRangeAttackSkill()
        {
        
        }
        public override bool Validate()
        {
            if(0 == this.weapon)
            {
                    return false;
            }
            
            if(this.weapon.Type != 1)
            {
                    return false;
            }
            
            if(0 == this.Character.RangeCombatSystem)
            {
                    return false;
            }
            
            TzarGames.TzarHero.SimpleRangeCombatSystem val_9 = this.Character.RangeCombatSystem;
            if(val_9.WeaponObject == null)
            {
                    return false;
            }
            
            return this.Validate();
        }
        protected override void OnStarted()
        {
            this.OnStarted();
        }
        protected override void action(TzarGames.Common.StringID animationEvent)
        {
            var val_17;
            var val_18;
            int val_19;
            var val_20;
            TzarGames.TzarHero.SimpleRangeCombatSystem val_2 = this.Character.RangeCombatSystem;
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_17 = val_2.WeaponObject;
            TzarGames.GameFramework.IWeaponObject val_4 = val_2.WeaponObject + ((this.currentFireSourceIndex) << 3);
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_18 = val_2.WeaponObject;
            if((this.currentFireSourceIndex + 1) < null)
            {
                    val_19 = this.currentFireSourceIndex + 1;
            }
            else
            {
                    val_19 = 0;
            }
            
            this.currentFireSourceIndex = val_19;
            UnityEngine.Vector3 val_12 = val_2.WeaponObject.forward;
            TzarGames.TzarHero.TH_InteractiveObject val_14 = this.Character.Target;
            val_20 = 0;
            UnityEngine.GameObject val_16 = this.Character.RangeCombatSystem.Use(weaponTemplate:  this.weapon, speedScale:  this.Character.TemplateInstance.AttackSpeed, attackDirection:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, projectileFireSource:  val_2.WeaponObject, target:  null, autoLaunch:  true);
        }
    
    }

}

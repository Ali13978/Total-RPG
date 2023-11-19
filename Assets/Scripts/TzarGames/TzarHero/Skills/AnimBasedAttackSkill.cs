using UnityEngine;

namespace TzarGames.TzarHero.Skills
{
    public class AnimBasedAttackSkill : CharacterSkill, IDamageSkill
    {
        // Fields
        [UnityEngine.SerializeField]
        private bool tryFindTarget;
        [UnityEngine.SerializeField]
        private string playerAnimationName;
        [UnityEngine.SerializeField]
        protected TzarGames.GameFramework.CharacteristicModificator damageModificator;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Weapon weapon;
        [UnityEngine.SerializeField]
        private float attackRangeMultiplier;
        
        // Properties
        public TzarGames.GameFramework.CharacteristicModificator DamageModificator { get; }
        
        // Methods
        public AnimBasedAttackSkill()
        {
            this.tryFindTarget = true;
            this.attackRangeMultiplier = 1f;
            this.playerAnimationName = "Attack Name";
        }
        public TzarGames.GameFramework.CharacteristicModificator get_DamageModificator()
        {
            return (TzarGames.GameFramework.CharacteristicModificator)this.damageModificator;
        }
        protected override void OnCharacterAssigned()
        {
            TzarGames.TzarHero.AnimationBasedCombatSystem val_1 = AnimBasedCombatSystem;
            if(0 == val_1)
            {
                    return;
            }
            
            TzarGames.TzarHero.AnimationBasedCombatSystem val_3 = val_1.AnimBasedCombatSystem;
            val_3.add_OnAttackFinished(value:  new System.Action<TzarGames.TzarHero.AnimationBasedCombatSystem>(object:  this, method:  System.Void TzarGames.TzarHero.Skills.AnimBasedAttackSkill::AnimBasedCombatSystemOnOnAttackFinished(TzarGames.TzarHero.AnimationBasedCombatSystem animationBasedCombatSystem)));
            val_3.AnimBasedCombatSystem.add_OnHit(value:  new System.Action<TzarGames.TzarHero.CharacterDamageInfo>(object:  this, method:  System.Void TzarGames.TzarHero.Skills.AnimBasedAttackSkill::Character_AnimBasedCombatSystem_OnHit(TzarGames.TzarHero.CharacterDamageInfo obj)));
        }
        private void Character_AnimBasedCombatSystem_OnHit(TzarGames.TzarHero.CharacterDamageInfo obj)
        {
            if(W8 == 0)
            {
                    return;
            }
            
            goto typeof(TzarGames.TzarHero.Skills.AnimBasedAttackSkill).__il2cppRuntimeField_240;
        }
        protected virtual void onHit(TzarGames.TzarHero.CharacterDamageInfo hit)
        {
        
        }
        protected override void OnCharacterRemoved(TzarGames.TzarHero.TH_Character character)
        {
            TzarGames.TzarHero.AnimationBasedCombatSystem val_1 = AnimBasedCombatSystem;
            if(0 == val_1)
            {
                    return;
            }
            
            TzarGames.TzarHero.AnimationBasedCombatSystem val_3 = val_1.AnimBasedCombatSystem;
            val_3.remove_OnAttackFinished(value:  new System.Action<TzarGames.TzarHero.AnimationBasedCombatSystem>(object:  this, method:  System.Void TzarGames.TzarHero.Skills.AnimBasedAttackSkill::AnimBasedCombatSystemOnOnAttackFinished(TzarGames.TzarHero.AnimationBasedCombatSystem animationBasedCombatSystem)));
            val_3.AnimBasedCombatSystem.remove_OnHit(value:  new System.Action<TzarGames.TzarHero.CharacterDamageInfo>(object:  this, method:  System.Void TzarGames.TzarHero.Skills.AnimBasedAttackSkill::Character_AnimBasedCombatSystem_OnHit(TzarGames.TzarHero.CharacterDamageInfo obj)));
        }
        protected override void OnStarted()
        {
            TzarGames.TzarHero.TH_InteractiveObject val_16;
            var val_17;
            TzarGames.GameFramework.Weapon val_18;
            this.OnStarted();
            if(this.tryFindTarget == false)
            {
                goto label_1;
            }
            
            TzarGames.TzarHero.TH_InteractiveObject val_1 = Target;
            if(0 != val_1)
            {
                goto label_5;
            }
            
            if(val_1 == null)
            {
                goto label_6;
            }
            
            val_16 = val_1.TryFindTargetForAttack();
            goto label_7;
            label_1:
            val_17 = 0;
            goto label_15;
            label_6:
            val_16 = 0.TryFindTargetForAttack();
            label_7:
            val_1.Target = val_16;
            label_5:
            val_17 = 0;
            if(val_1.Target != null)
            {
                    val_17 = 0;
            }
            
            if(0 != )
            {
                    UnityEngine.Vector3 val_8 = Position;
                val_16.SetDesiredRotationToPosition(position:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            }
            
            label_15:
            TzarGames.GameFramework.Characteristic val_10 = val_16.TemplateInstance.DamageCharacteristic;
            val_10.AddModificator(modificator:  this.damageModificator);
            if(0 != this.weapon)
            {
                    val_18 = this.weapon;
            }
            else
            {
                    val_18 = this.weapon.ActiveWeaponTemplate;
            }
            
            val_10.AnimBasedCombatSystem.StartAttack(speedScale:  X23.TemplateInstance.AttackSpeed, target:  null, weapon:  val_18, attackRangeMultiplier:  this.attackRangeMultiplier, attackAnimName:  this.playerAnimationName, tryFindTarget:  false);
        }
        protected override void OnStopped()
        {
            this.OnStopped();
            TzarGames.TzarHero.AnimationBasedCombatSystem val_1 = X20.AnimBasedCombatSystem;
            val_1.StopAttack();
            val_1.TemplateInstance.DamageCharacteristic.UnregisterModificator(modificator:  this.damageModificator);
        }
        private void AnimBasedCombatSystemOnOnAttackFinished(TzarGames.TzarHero.AnimationBasedCombatSystem animationBasedCombatSystem)
        {
            if(true == 0)
            {
                    return;
            }
            
            this.Finish();
        }
        protected virtual void onAttackFinished(TzarGames.TzarHero.AnimationBasedCombatSystem animationBasedCombatSystem)
        {
        
        }
    
    }

}

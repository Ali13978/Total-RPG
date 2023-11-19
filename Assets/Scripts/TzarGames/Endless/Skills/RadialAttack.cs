using UnityEngine;

namespace TzarGames.Endless.Skills
{
    public class RadialAttack : EndlessCharacterSkill, IDamageSkill
    {
        // Fields
        [UnityEngine.SerializeField]
        private string playerAnimationName;
        [UnityEngine.SerializeField]
        private int numberOfAttacks;
        [UnityEngine.SerializeField]
        private float timeScale;
        [UnityEngine.SerializeField]
        private float timeShift;
        [UnityEngine.SerializeField]
        private bool clockwise;
        [UnityEngine.SerializeField]
        private float startAngleShift;
        [UnityEngine.SerializeField]
        private float attackAngleScale;
        [UnityEngine.SerializeField]
        private float attackRangeMultiplier;
        private TzarGames.GameFramework.CharacteristicModificator damageModificator;
        private TzarGames.Endless.Skills.RadialAttackSMB radialAttackSMB;
        private float attackAngleStep;
        private float normalizedTimeStep;
        private int currentAttack;
        
        // Properties
        public TzarGames.GameFramework.CharacteristicModificator DamageModificator { get; }
        
        // Methods
        public RadialAttack()
        {
            this.numberOfAttacks = 8;
            this.timeScale = 1f;
            this.attackAngleScale = 1f;
            this.attackRangeMultiplier = 1f;
            this.clockwise = true;
            this.playerAnimationName = "Radial Attack";
        }
        public TzarGames.GameFramework.CharacteristicModificator get_DamageModificator()
        {
            return (TzarGames.GameFramework.CharacteristicModificator)this.damageModificator;
        }
        public override void OnInitialize()
        {
            this.OnInitialize();
            if(this.damageModificator != null)
            {
                    return;
            }
            
            this.damageModificator = new TzarGames.GameFramework.CharacteristicModificator();
            typeof(TzarGames.GameFramework.CharacteristicModificator).__il2cppRuntimeField_18 = 2;
            this.damageModificator.ModificationMode = 0;
            this.damageModificator.Value = 1f;
        }
        protected override void OnCharacterAssigned()
        {
            this.OnCharacterAssigned();
            if(0 == this.Character.AnimBasedCombatSystem)
            {
                    return;
            }
            
            this.Character.AnimBasedCombatSystem.add_OnAttackFinished(value:  new System.Action<TzarGames.TzarHero.AnimationBasedCombatSystem>(object:  this, method:  System.Void TzarGames.Endless.Skills.RadialAttack::AnimBasedCombatSystemOnOnAttackFinished(TzarGames.TzarHero.AnimationBasedCombatSystem animationBasedCombatSystem)));
        }
        protected override void OnCharacterRemoved(TzarGames.TzarHero.TH_Character character)
        {
            this.OnCharacterRemoved(character:  character);
            if(0 == this.Character.AnimBasedCombatSystem)
            {
                    return;
            }
            
            this.Character.AnimBasedCombatSystem.remove_OnAttackFinished(value:  new System.Action<TzarGames.TzarHero.AnimationBasedCombatSystem>(object:  this, method:  System.Void TzarGames.Endless.Skills.RadialAttack::AnimBasedCombatSystemOnOnAttackFinished(TzarGames.TzarHero.AnimationBasedCombatSystem animationBasedCombatSystem)));
        }
        public override bool Validate()
        {
            TzarGames.Endless.Skills.RadialAttackSMB val_4 = this.Character.AnimBasedCombatSystem.Animator.GetBehaviour<TzarGames.Endless.Skills.RadialAttackSMB>();
            if(0 == val_4)
            {
                    UnityEngine.Debug.LogError(message:  0);
                return false;
            }
            
            this.radialAttackSMB = val_4;
            return this.Validate();
        }
        protected override void OnStarted()
        {
            this.OnStarted();
            if(0 == this.radialAttackSMB)
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            float val_12 = this.attackAngleScale;
            float val_13 = this.timeShift;
            val_12 = val_12 * 360f;
            val_13 = val_13 + 0.95f;
            val_12 = val_12 / (float)this.numberOfAttacks;
            val_13 = val_13 / (float)this.numberOfAttacks;
            this.attackAngleStep = val_12;
            this.normalizedTimeStep = val_13;
            this.currentAttack = 0;
            this.Character.TemplateInstance.DamageCharacteristic.AddModificator(modificator:  this.damageModificator);
            this.Character.AnimBasedCombatSystem.StartAttack(speedScale:  this.Character.TemplateInstance.AttackSpeed, target:  0, weapon:  this.Character.ActiveWeaponTemplate, attackRangeMultiplier:  this.attackRangeMultiplier, attackAnimName:  this.playerAnimationName, tryFindTarget:  false);
        }
        public override void UpdatePerformingSkill(float deltaTime)
        {
            float val_5;
            float val_6;
            int val_7;
            var val_8;
            val_5 = deltaTime;
            this.UpdatePerformingSkill(deltaTime:  val_5);
            if(0 == this.radialAttackSMB)
            {
                    return;
            }
            
            int val_5 = this.numberOfAttacks;
            if(this.currentAttack >= val_5)
            {
                    return;
            }
            
            float val_4 = this.normalizedTimeStep;
            val_4 = (float)this.currentAttack * val_4;
            val_5 = val_4 - this.timeShift;
            if(this.radialAttackSMB != null)
            {
                    val_5 = val_5 >> 32;
                val_6 = val_5;
            }
            else
            {
                    val_6 = this.timeScale;
            }
            
            val_6 = (this.radialAttackSMB.<NormalizedTime>k__BackingField) * val_6;
            if(val_6 < val_5)
            {
                    return;
            }
            
            if(val_5 <= 0.0001f)
            {
                goto label_8;
            }
            
            val_6 = val_6 / val_5;
            val_7 = (int)val_6;
            if(val_7 >= (1.401298E-45f))
            {
                goto label_9;
            }
            
            return;
            label_8:
            val_7 = 1;
            label_9:
            val_8 = 0;
            do
            {
                if(this.currentAttack >= this.numberOfAttacks)
            {
                    return;
            }
            
                this.performAttackNumber(attackNum:  this.currentAttack);
                val_8 = val_8 + 1;
                this.currentAttack = this.currentAttack + 1;
            }
            while(val_8 < val_7);
        
        }
        private void performAttackNumber(int attackNum)
        {
            var val_49;
            var val_50;
            val_49 = this;
            UnityEngine.Vector3 val_2 = this.Character.ForwardDirection;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_2.x, y = 0f, z = val_2.z});
            float val_50 = this.attackAngleStep;
            float val_49 = 0.5f;
            val_49 = val_50 * val_49;
            val_50 = (float)attackNum * val_50;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.up;
            UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.AngleAxis(angle:  (this.startAngleShift + (val_50 + val_49)) * ((this.clockwise == true) ? 1f : -1f), axis:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            UnityEngine.Vector3 val_10 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w}, point:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> val_12 = this.Character.GetAllCharactersInAttackRadius(radiusScale:  this.attackRangeMultiplier);
            TzarGames.GameFramework.Weapon val_14 = this.Character.GetActiveWeaponTemplate(slot:  0);
            val_50 = 0;
            goto label_10;
            label_37:
            val_50 = 1;
            label_10:
            if(val_50 >= val_12.Count)
            {
                goto label_12;
            }
            
            TzarGames.TzarHero.TH_Character val_16 = val_12.Item[1];
            if(((this.Character.isCharacterValidForAttack(character:  val_16)) == false) || ((this.Character.TemplateInstance.Group.IsFriendly(group:  val_16.TemplateInstance.Group)) == true))
            {
                goto label_37;
            }
            
            UnityEngine.Vector3 val_26 = val_16.Position;
            UnityEngine.Vector3 val_28 = this.Character.Position;
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, b:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
            if((UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_29.x, y = 0f, z = val_29.z}, to:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z})) > val_49)
            {
                goto label_37;
            }
            
            UnityEngine.Vector3 val_31 = val_16.GroundPivotPosition;
            UnityEngine.Vector3 val_33 = this.Character.GroundPivotPosition;
            UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, b:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z});
            UnityEngine.Vector3 val_35 = val_16.Position;
            UnityEngine.Vector3 val_36 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z}, d:  val_35.x);
            UnityEngine.Vector3 val_37 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z}, b:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z});
            UnityEngine.Quaternion val_38 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z});
            UnityEngine.Vector3 val_39 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_40 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_38.x, y = val_38.y, z = val_38.z, w = val_38.w}, point:  new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z});
            UnityEngine.Vector3 val_41 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z}, b:  new UnityEngine.Vector3() {x = val_40.x, y = val_40.y, z = val_40.z});
            TzarGames.TzarHero.CharacterDamageInfo val_46 = TzarGames.TzarHero.SimpleMeleeCombatSystem.AdjustMeleeDamageTo(instigator:  0, victim:  this.Character, weapon:  val_16, damageForceMultiplier:  this.Character.AnimBasedCombatSystem.DamageForceMultiplier, hitPosition:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z}, hitNormal:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z}, hitDirection:  new UnityEngine.Vector3() {x = val_41.x, y = val_41.z});
            goto label_37;
            label_12:
            if(0 == 0)
            {
                    return;
            }
            
            val_49 = this.Character;
            val_49.Target = 0;
        }
        protected override void OnStopped()
        {
            this.OnStopped();
            this.Character.TemplateInstance.DamageCharacteristic.UnregisterModificator(modificator:  this.damageModificator);
            this.radialAttackSMB = 0;
        }
        private void AnimBasedCombatSystemOnOnAttackFinished(TzarGames.TzarHero.AnimationBasedCombatSystem animationBasedCombatSystem)
        {
            if(this.IsPerforming == false)
            {
                    return;
            }
            
            if(this.currentAttack < this.numberOfAttacks)
            {
                    this.performAttackNumber(attackNum:  this.numberOfAttacks - 1);
            }
            
            this.Finish();
        }
    
    }

}

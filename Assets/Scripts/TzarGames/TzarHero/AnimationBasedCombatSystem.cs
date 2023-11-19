using UnityEngine;

namespace TzarGames.TzarHero
{
    public class AnimationBasedCombatSystem : TzarBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.TH_Character owner;
        [UnityEngine.SerializeField]
        private int attackAnimCount;
        [UnityEngine.SerializeField]
        private UnityEngine.Animator animator;
        [UnityEngine.SerializeField]
        private int attackLayerIndex;
        [UnityEngine.SerializeField]
        private string attackStateTag;
        [UnityEngine.SerializeField]
        private string cancelTriggerName;
        [UnityEngine.SerializeField]
        private float damageForceMultiplier;
        [UnityEngine.SerializeField]
        private bool tryFindTargetWhenHit;
        private TzarGames.TzarHero.TH_Character targetCharacter;
        private bool pendingAttackStart;
        private bool isInAttackState;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.TzarHero.AnimationBasedCombatSystem> OnAttackStarted;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.TzarHero.AnimationBasedCombatSystem> OnAttackFinished;
        private TzarGames.TzarHero.AnimHitEventHandler hitHandler;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.TzarHero.CharacterDamageInfo> OnHit;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action OnHitTime;
        private bool tryFindTargetWhenHit_actual;
        private TzarGames.GameFramework.Weapon lastWeapon;
        private float lastAttackRangeMultiplier;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <IsAttacking>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private int <CurrentAttackAnimNumber>k__BackingField;
        
        // Properties
        public bool IsAttacking { get; set; }
        public UnityEngine.Animator Animator { get; }
        public float DamageForceMultiplier { get; }
        protected int AttackAnimCount { get; }
        protected int CurrentAttackAnimNumber { get; set; }
        
        // Methods
        public AnimationBasedCombatSystem()
        {
            this.attackAnimCount = 1;
            this.attackStateTag = "Attack";
            this.lastAttackRangeMultiplier = 1f;
            this.damageForceMultiplier = 800f;
            this.cancelTriggerName = "Cancel Attack";
        }
        public void add_OnAttackStarted(System.Action<TzarGames.TzarHero.AnimationBasedCombatSystem> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnAttackStarted);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511459354456 != this.OnAttackStarted);
        
        }
        public void remove_OnAttackStarted(System.Action<TzarGames.TzarHero.AnimationBasedCombatSystem> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnAttackStarted);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511459491032 != this.OnAttackStarted);
        
        }
        public void add_OnAttackFinished(System.Action<TzarGames.TzarHero.AnimationBasedCombatSystem> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnAttackFinished);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511459627616 != this.OnAttackFinished);
        
        }
        public void remove_OnAttackFinished(System.Action<TzarGames.TzarHero.AnimationBasedCombatSystem> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnAttackFinished);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511459764192 != this.OnAttackFinished);
        
        }
        public void add_OnHit(System.Action<TzarGames.TzarHero.CharacterDamageInfo> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnHit);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511459900784 != this.OnHit);
        
        }
        public void remove_OnHit(System.Action<TzarGames.TzarHero.CharacterDamageInfo> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnHit);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511460037360 != this.OnHit);
        
        }
        public void add_OnHitTime(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnHitTime);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511460173944 != this.OnHitTime);
        
        }
        public void remove_OnHitTime(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnHitTime);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511460310520 != this.OnHitTime);
        
        }
        public bool get_IsAttacking()
        {
            return (bool)this.<IsAttacking>k__BackingField;
        }
        private void set_IsAttacking(bool value)
        {
            this.<IsAttacking>k__BackingField = value;
        }
        public UnityEngine.Animator get_Animator()
        {
            return (UnityEngine.Animator)this.animator;
        }
        public float get_DamageForceMultiplier()
        {
            return (float)this.damageForceMultiplier;
        }
        protected int get_AttackAnimCount()
        {
            return (int)this.attackAnimCount;
        }
        protected int get_CurrentAttackAnimNumber()
        {
            return (int)this.<CurrentAttackAnimNumber>k__BackingField;
        }
        private void set_CurrentAttackAnimNumber(int value)
        {
            this.<CurrentAttackAnimNumber>k__BackingField = value;
        }
        public void SetAnimator(UnityEngine.Animator newAnimator)
        {
            if(0 != this.animator)
            {
                    this.handleAnimator(register:  false);
            }
            
            this.animator = newAnimator;
            this.handleAnimator(register:  true);
        }
        private void handleAnimator(bool register)
        {
            UnityEngine.Animator val_8 = this.animator;
            if(0 == val_8)
            {
                    return;
            }
            
            if(0 != this.hitHandler)
            {
                    this.hitHandler.remove_OnHit(value:  new System.Action<TzarGames.TzarHero.AnimationHitInfo>(object:  this, method:  public System.Void TzarGames.TzarHero.AnimationBasedCombatSystem::NotifyHitTime(TzarGames.TzarHero.AnimationHitInfo hitInfo)));
            }
            
            val_8 = this.animator.GetComponent<TzarGames.TzarHero.AnimHitEventHandler>();
            this.hitHandler = val_8;
            if(0 == val_8)
            {
                    return;
            }
            
            System.Action<TzarGames.TzarHero.AnimationHitInfo> val_7 = new System.Action<TzarGames.TzarHero.AnimationHitInfo>(object:  this, method:  public System.Void TzarGames.TzarHero.AnimationBasedCombatSystem::NotifyHitTime(TzarGames.TzarHero.AnimationHitInfo hitInfo));
            if(register != false)
            {
                    this.hitHandler.add_OnHit(value:  val_7);
                return;
            }
            
            this.hitHandler.remove_OnHit(value:  val_7);
        }
        private void Start()
        {
            this.handleAnimator(register:  true);
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            this.handleAnimator(register:  false);
        }
        private void Reset()
        {
            this.owner = this.GetComponent<TzarGames.TzarHero.TH_Character>();
        }
        public void StartAttackWithNextAnimation(TzarGames.GameFramework.Weapon weapon, float speedScale, TzarGames.TzarHero.TH_Character target)
        {
            this.<CurrentAttackAnimNumber>k__BackingField = this;
            this.StartAttack(speedScale:  speedScale, target:  target, weapon:  weapon, attackRangeMultiplier:  1f, attackAnimName:  0 + "Attack ", tryFindTarget:  false);
        }
        protected virtual int GetNextAttackNumber()
        {
            return UnityEngine.Random.Range(min:  0, max:  0);
        }
        public void StartAttack(float speedScale, TzarGames.TzarHero.TH_Character target, TzarGames.GameFramework.Weapon weapon, float attackRangeMultiplier, string attackAnimName)
        {
            this.StartAttack(speedScale:  speedScale, target:  target, weapon:  weapon, attackRangeMultiplier:  attackRangeMultiplier, attackAnimName:  attackAnimName, tryFindTarget:  false);
        }
        public void StartAttack(float speedScale, TzarGames.TzarHero.TH_Character target, TzarGames.GameFramework.Weapon weapon, float attackRangeMultiplier, string attackAnimName, bool tryFindTarget)
        {
            UnityEngine.Vector3 val_2 = this.owner.GetDesiredRotationDirection();
            this.StartAttack(speedScale:  speedScale, target:  target, weapon:  weapon, attackRangeMultiplier:  attackRangeMultiplier, attackAnimName:  attackAnimName, tryFindTarget:  (this.tryFindTargetWhenHit == true) ? 1 : 0, attackDirection:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        public void StartAttack(float speedScale, TzarGames.TzarHero.TH_Character target, TzarGames.GameFramework.Weapon weapon, float attackRangeMultiplier, string attackAnimName, bool tryFindTarget, UnityEngine.Vector3 attackDirection)
        {
            string val_5;
            TzarGames.TzarHero.TH_Character val_6;
            val_5 = attackAnimName;
            val_6 = target;
            if((this.<IsAttacking>k__BackingField) == true)
            {
                    return;
            }
            
            this.targetCharacter = val_6;
            val_6 = this.attackLayerIndex;
            this.tryFindTargetWhenHit_actual = tryFindTarget;
            this.lastWeapon = weapon;
            this.lastAttackRangeMultiplier = attackRangeMultiplier;
            this.animator.Play(stateName:  val_5, layer:  val_6, normalizedTime:  0f);
            this.animator.ResetTrigger(name:  this.cancelTriggerName);
            this.animator.SetFloat(name:  "Attack Speed Multiplier", value:  speedScale);
            this.pendingAttackStart = true;
            this.isInAttackState = false;
            this.<IsAttacking>k__BackingField = true;
            this.tryFindTargetFunc();
            val_5 = this.lastWeapon;
            if(0 != val_5)
            {
                    val_5 = this.lastWeapon;
                if(this.lastWeapon.type == 1)
            {
                    val_5 = this.targetCharacter;
                UnityEngine.GameObject val_4 = this.owner.RangeCombatSystem.Use(weaponTemplate:  weapon, speedScale:  speedScale, attackDirection:  new UnityEngine.Vector3() {x = attackDirection.x, y = attackDirection.y, z = attackDirection.z}, projectileFireSource:  0, target:  val_5, autoLaunch:  false);
            }
            
            }
            
            if(this.OnAttackStarted == null)
            {
                    return;
            }
            
            this.OnAttackStarted.Invoke(obj:  this);
        }
        private void Update()
        {
            int val_7;
            if((this.pendingAttackStart & 255) != false)
            {
                    val_7 = this.attackLayerIndex;
                UnityEngine.AnimatorStateInfo val_2 = this.animator.GetCurrentAnimatorStateInfo(layerIndex:  val_7);
                if(((-1734131280) & 1) == 0)
            {
                    return;
            }
            
                this.pendingAttackStart = true;
                this.isInAttackState = true;
                return;
            }
            
            if(this.pendingAttackStart < true)
            {
                    return;
            }
            
            val_7 = this.attackLayerIndex;
            UnityEngine.AnimatorStateInfo val_6 = this.animator.GetCurrentAnimatorStateInfo(layerIndex:  val_7);
            if((0 & 1) != 0)
            {
                    return;
            }
            
            this.StopAttack();
        }
        public void StopAttack()
        {
            if((this.<IsAttacking>k__BackingField) == false)
            {
                    return;
            }
            
            this.isInAttackState = false;
            this.<IsAttacking>k__BackingField = false;
            this.lastWeapon = 0;
            this.lastAttackRangeMultiplier = 1f;
            this.animator.SetFloat(name:  "Attack Speed Multiplier", value:  1f);
            this.animator.Play(stateName:  "Default", layer:  this.attackLayerIndex);
            this.<CurrentAttackAnimNumber>k__BackingField = 0;
            if(this.OnAttackFinished == null)
            {
                    return;
            }
            
            this.OnAttackFinished.Invoke(obj:  this);
        }
        private void tryFindTargetFunc()
        {
            TzarGames.TzarHero.TH_Character val_17;
            float val_18;
            TzarGames.TzarHero.TH_Character val_19;
            float val_1 = this.getAttackRadius();
            if(this.tryFindTargetWhenHit_actual == false)
            {
                    return;
            }
            
            if(0 != this.targetCharacter)
            {
                    if(this.targetCharacter.isDead != true)
            {
                    val_17 = this.targetCharacter;
                val_18 = val_1;
                if((this.owner.IsObjectInAttackRange(obj:  val_17, attackRadius:  val_18)) == true)
            {
                    return;
            }
            
            }
            
            }
            
            TzarGames.TzarHero.TH_Character val_8 = this.owner.TryFindTargetForAttack();
            this.targetCharacter = val_8;
            if(0 != val_8)
            {
                    if(this.targetCharacter.isDead == false)
            {
                goto label_14;
            }
            
            }
            
            val_18 = val_1 + val_1;
            val_17 = this.owner;
            val_19 = this.owner.GetNearestCharacterInRadius(radius:  val_18, onlyAlive:  true, onlyFriend:  true);
            if((val_17.isCharacterValidForAttack(character:  val_19)) == false)
            {
                    return;
            }
            
            this.targetCharacter = val_19;
            goto label_18;
            label_14:
            val_19 = this.targetCharacter;
            label_18:
            UnityEngine.Vector3 val_15 = val_19.Position;
            this.owner.SetDesiredRotationToPosition(position:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
        }
        private float getAttackRadius()
        {
            if(0 != this.lastWeapon)
            {
                    if(this.lastWeapon != null)
            {
                goto label_5;
            }
            
            }
            else
            {
                    float val_2 = this.owner.GetAttackRadius();
            }
            
            label_5:
            val_2 = val_2 * this.lastAttackRangeMultiplier;
            return (float)val_2;
        }
        public void NotifyHitTime(TzarGames.TzarHero.AnimationHitInfo hitInfo)
        {
            TzarGames.TzarHero.TH_Character val_36;
            float val_38;
            TzarGames.TzarHero.TH_Character val_39;
            var val_40;
            float val_41;
            float val_42;
            float val_43;
            float val_44;
            var val_45;
            float val_48;
            float val_49;
            val_36 = this.owner;
            if(val_36.isDead == true)
            {
                    return;
            }
            
            if((this.<IsAttacking>k__BackingField) == false)
            {
                    return;
            }
            
            this.tryFindTargetFunc();
            val_38 = this.getAttackRadius();
            if((0 == this.lastWeapon) || (this.lastWeapon.type != 1))
            {
                goto label_28;
            }
            
            TzarGames.TzarHero.SimpleRangeCombatSystem val_5 = this.owner.RangeCombatSystem;
            if(0 == val_5.currentProjectile)
            {
                goto label_14;
            }
            
            UnityEngine.Vector3 val_8 = this.owner.GetDesiredRotationDirection();
            val_7.<ActualAttackDirection>k__BackingField = val_8;
            mem2[0] = val_8.y;
            mem2[0] = val_8.z;
            TzarGames.TzarHero.SimpleRangeCombatSystem val_9 = this.owner.RangeCombatSystem;
            if(val_9.WeaponObject == null)
            {
                goto label_30;
            }
            
            val_39 = 1152921504910467072;
            var val_36 = 0;
            val_36 = val_36 + 1;
            val_40 = val_9.WeaponObject;
            goto label_23;
            label_14:
            UnityEngine.Vector3 val_12 = this.owner.GetDesiredRotationDirection();
            val_39 = this.targetCharacter;
            val_41 = val_12.x;
            val_42 = val_12.z;
            val_43 = val_41;
            val_44 = val_12.y;
            UnityEngine.GameObject val_13 = this.owner.RangeCombatSystem.Use(weaponTemplate:  this.lastWeapon, speedScale:  this.owner.TemplateInstance.AttackSpeed, attackDirection:  new UnityEngine.Vector3() {x = val_43, y = val_44, z = val_42}, projectileFireSource:  0, target:  val_39, autoLaunch:  true);
            goto label_28;
            label_23:
            if(null < 1)
            {
                goto label_30;
            }
            
            var val_37 = 0;
            val_37 = val_37 + 1;
            val_45 = val_9.WeaponObject;
            goto label_34;
            label_30:
            UnityEngine.Vector3 val_15 = this.owner.Position;
            goto label_36;
            label_34:
            UnityEngine.Vector3 val_17 = val_9.WeaponObject.position;
            label_36:
            val_41 = val_17.y;
            val_43 = val_41;
            val_44 = val_17.z;
            this.owner.RangeCombatSystem.LaunchCurrentProjectile(launchPosition:  new UnityEngine.Vector3() {x = val_17.x, y = val_43, z = val_44});
            label_28:
            val_36 = this.targetCharacter;
            if(0 != val_36)
            {
                    val_36 = this.targetCharacter;
                if(val_36.isDead != true)
            {
                    val_36 = this.owner;
                if((val_36.IsObjectInAttackRange(obj:  this.targetCharacter, attackRadius:  val_38)) != false)
            {
                    val_36 = this.lastWeapon;
                if(0 != val_36)
            {
                    val_36 = this.lastWeapon;
                if(this.lastWeapon.type == 0)
            {
                    UnityEngine.Vector3 val_24 = this.targetCharacter.GroundPivotPosition;
                UnityEngine.Vector3 val_25 = this.owner.GroundPivotPosition;
                UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, b:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
                val_42 = val_26.x;
                val_48 = val_26.y;
                val_49 = val_26.z;
                UnityEngine.Vector3 val_27 = this.targetCharacter.Position;
                UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_42, y = val_48, z = val_49}, d:  val_27.x);
                UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, b:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
                val_38 = val_29.x;
                val_41 = val_29.z;
                if(0 != hitInfo)
            {
                    UnityEngine.Vector3 val_31 = UnityEngine.Vector3.up;
                UnityEngine.Quaternion val_32 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_42, y = val_48, z = val_49}, upwards:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z});
                UnityEngine.Vector3 val_33 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_32.x, y = val_32.y, z = val_32.z, w = val_32.w}, point:  new UnityEngine.Vector3() {x = hitInfo.relativeVelocity, y = val_31.z});
                val_42 = val_33.x;
                val_48 = val_33.y;
                val_49 = val_33.z;
                val_38 = val_38;
            }
            
                UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_42, y = val_48, z = val_49});
                val_36 = this.owner;
                val_36.Target = this.targetCharacter;
                if(this.OnHit != null)
            {
                    this.OnHit.Invoke(obj:  TzarGames.TzarHero.SimpleMeleeCombatSystem.AdjustMeleeDamageTo(instigator:  0, victim:  this.owner, weapon:  this.targetCharacter, damageForceMultiplier:  this.damageForceMultiplier, hitPosition:  new UnityEngine.Vector3() {x = val_38, y = val_29.y, z = val_41}, hitNormal:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z}, hitDirection:  new UnityEngine.Vector3() {x = val_42, y = val_49, z = val_42}));
            }
            
            }
            
            }
            
            }
            
            }
            
            }
            
            if(this.OnHitTime == null)
            {
                    return;
            }
            
            this.OnHitTime.Invoke();
        }
        public override void OnPulledFromPool()
        {
            this.enabled = true;
        }
        public override void OnPushedToPool()
        {
            this.OnPushedToPool();
            this.enabled = false;
            this.pendingAttackStart = false;
            this.isInAttackState = false;
            this.targetCharacter = 0;
            if(0 != this.hitHandler)
            {
                    this.hitHandler.remove_OnHit(value:  new System.Action<TzarGames.TzarHero.AnimationHitInfo>(object:  this, method:  public System.Void TzarGames.TzarHero.AnimationBasedCombatSystem::NotifyHitTime(TzarGames.TzarHero.AnimationHitInfo hitInfo)));
            }
            
            this.<IsAttacking>k__BackingField = false;
            this.hitHandler = 0;
            this.tryFindTargetWhenHit_actual = false;
            this.lastWeapon = 0;
            this.<CurrentAttackAnimNumber>k__BackingField = 0;
            this.lastAttackRangeMultiplier = 1f;
        }
    
    }

}

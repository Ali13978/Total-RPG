using UnityEngine;

namespace TzarGames.TzarHero
{
    public class SimpleMeleeCombatSystem : MonoBehaviour, IPoolable
    {
        // Fields
        [UnityEngine.SerializeField]
        private float meleeHitDelayTime;
        [UnityEngine.SerializeField]
        private float hitHeight;
        [UnityEngine.SerializeField]
        private float damageForceMultiplier;
        public TzarGames.GameFramework.IWeaponObject WeaponObject;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.TzarHero.TH_Character <Owner>k__BackingField;
        
        // Properties
        public TzarGames.TzarHero.TH_Character Owner { get; set; }
        
        // Methods
        public SimpleMeleeCombatSystem()
        {
            this.meleeHitDelayTime = 1.5f;
            this.hitHeight = 1f;
            this.damageForceMultiplier = 800f;
        }
        public TzarGames.TzarHero.TH_Character get_Owner()
        {
            return (TzarGames.TzarHero.TH_Character)this.<Owner>k__BackingField;
        }
        public void set_Owner(TzarGames.TzarHero.TH_Character value)
        {
            this.<Owner>k__BackingField = value;
        }
        public void UseOnCharacter(TzarGames.TzarHero.TH_Character target, TzarGames.GameFramework.Weapon weaponTemplate, float speedScale)
        {
            float val_4 = this.meleeHitDelayTime;
            if(val_4 > 0f)
            {
                    val_4 = val_4 / speedScale;
                UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.meleeHitTimer(template:  weaponTemplate, delayTime:  val_4, lastTarget:  target));
                return;
            }
            
            if(0 == target)
            {
                    return;
            }
            
            this.adjustDamage(target:  target, weapon:  weaponTemplate);
        }
        public static TzarGames.TzarHero.CharacterDamageInfo AdjustMeleeDamageTo(TzarGames.TzarHero.TH_Character instigator, TzarGames.TzarHero.TH_Character victim, TzarGames.GameFramework.Weapon weapon, float damageForceMultiplier)
        {
            UnityEngine.Vector3 val_1 = weapon.GroundPivotPosition;
            UnityEngine.Vector3 val_2 = victim.GroundPivotPosition;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Vector3 val_4 = weapon.Position;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  val_4.x);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            return (TzarGames.TzarHero.CharacterDamageInfo)TzarGames.TzarHero.SimpleMeleeCombatSystem.AdjustMeleeDamageTo(instigator:  0, victim:  victim, weapon:  weapon, damageForceMultiplier:  damageForceMultiplier, hitPosition:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, hitNormal:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, hitDirection:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.z, z = val_3.x});
        }
        public static TzarGames.TzarHero.CharacterDamageInfo AdjustMeleeDamageTo(TzarGames.TzarHero.TH_Character instigator, TzarGames.TzarHero.TH_Character victim, TzarGames.GameFramework.Weapon weapon, float damageForceMultiplier, UnityEngine.Vector3 hitPosition, UnityEngine.Vector3 hitNormal, UnityEngine.Vector3 hitDirection)
        {
            float val_10;
            float val_23;
            float val_24;
            UnityEngine.Object val_25;
            TzarGames.TzarHero.TH_Character val_26;
            float val_27;
            float val_28;
            var val_30;
            TzarGames.GameFramework.ModificatorGroup val_31;
            TzarGames.TzarHero.CharacterDamageInfo val_32;
            val_23 = hitNormal.y;
            val_24 = damageForceMultiplier;
            val_25 = X3;
            val_26 = victim;
            val_27 = val_26.TemplateInstance.Damage;
            if(0 == val_25)
            {
                    val_25 = val_26.ActiveWeaponTemplate;
            }
            
            float val_6 = val_26.TemplateInstance.CritChance;
            val_28 = 0f;
            float val_7 = UnityEngine.Random.Range(min:  val_28, max:  100f);
            if(val_7 <= val_6)
            {
                    float val_9 = val_26.TemplateInstance.CritMultiplier;
                val_9 = val_27 * val_9;
                val_28 = val_9 - val_27;
                val_27 = val_27 + val_28;
            }
            
            if(val_27 <= 0f)
            {
                goto label_12;
            }
            
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = hitDirection.x, y = val_10, z = hitDirection.y}, d:  val_24);
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, d:  val_4.damageForceMultiplier);
            val_24 = val_14.x;
            val_23 = val_14.z;
            if(weapon == null)
            {
                goto label_19;
            }
            
            val_30 = 0.OnClient;
            goto label_20;
            label_12:
            val_31 = val_4.HitModificators;
            val_32 = 0;
            goto label_23;
            label_19:
            val_30 = 0.OnClient;
            label_20:
            TzarGames.GameFramework.DamageInfoBase val_18 = null;
            val_32 = val_18;
            val_18 = new TzarGames.GameFramework.DamageInfoBase(damage:  val_27, force:  new UnityEngine.Vector3() {x = val_24, y = val_14.y, z = val_23}, damageType:  new TzarGames.TzarHero.TH_DamageType_Default(surfaceType:  TzarGames.GameFramework.SurfaceTypeBase.GetOrCreate(surfaceName:  null)), hitInfo:  new TzarGames.GameFramework.Hit(point:  new UnityEngine.Vector3() {x = hitPosition.x, y = hitPosition.y, z = hitPosition.z}, normal:  new UnityEngine.Vector3() {x = hitNormal.x, y = val_23, z = hitNormal.z}, collider:  0, rigidbody:  0, surfaceType:  weapon));
            var val_22 = ~val_30;
            val_22 = val_22 & 1;
            typeof(TzarGames.TzarHero.CharacterDamageInfo).__il2cppRuntimeField_38 = val_26;
            typeof(TzarGames.TzarHero.CharacterDamageInfo).__il2cppRuntimeField_40 = weapon;
            typeof(TzarGames.TzarHero.CharacterDamageInfo).__il2cppRuntimeField_36 = val_22;
            if(null != 0)
            {
                    typeof(TzarGames.TzarHero.CharacterDamageInfo).__il2cppRuntimeField_34 = (val_7 <= val_6) ? 1 : 0;
            }
            else
            {
                    typeof(TzarGames.TzarHero.CharacterDamageInfo).__il2cppRuntimeField_34 = (val_7 <= val_6) ? 1 : 0;
            }
            
            typeof(TzarGames.TzarHero.CharacterDamageInfo).__il2cppRuntimeField_30 = val_28;
            weapon.TakeDamage(damageInfo:  val_32);
            val_31 = val_4.HitModificators;
            label_23:
            val_31.ApplyToTemplate(template:  weapon.TemplateInstance);
            return val_32;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator meleeHitTimer(TzarGames.GameFramework.Weapon template, float delayTime, TzarGames.TzarHero.TH_Character lastTarget)
        {
            if(null != 0)
            {
                    typeof(SimpleMeleeCombatSystem.<meleeHitTimer>c__Iterator0).__il2cppRuntimeField_10 = delayTime;
                typeof(SimpleMeleeCombatSystem.<meleeHitTimer>c__Iterator0).__il2cppRuntimeField_18 = lastTarget;
                typeof(SimpleMeleeCombatSystem.<meleeHitTimer>c__Iterator0).__il2cppRuntimeField_20 = template;
            }
            else
            {
                    mem[16] = delayTime;
                mem[24] = lastTarget;
                mem[32] = template;
            }
            
            typeof(SimpleMeleeCombatSystem.<meleeHitTimer>c__Iterator0).__il2cppRuntimeField_28 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void adjustDamage(TzarGames.TzarHero.TH_Character target, TzarGames.GameFramework.Weapon weapon)
        {
            UnityEngine.Vector3 val_1 = target.GroundPivotPosition;
            UnityEngine.Vector3 val_2 = this.<Owner>k__BackingField.GroundPivotPosition;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Vector3 val_4 = target.Position;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  val_4.x);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  this.hitHeight);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            TzarGames.TzarHero.CharacterDamageInfo val_11 = TzarGames.TzarHero.SimpleMeleeCombatSystem.AdjustMeleeDamageTo(instigator:  0, victim:  this.<Owner>k__BackingField, weapon:  target, damageForceMultiplier:  this.damageForceMultiplier, hitPosition:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, hitNormal:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, hitDirection:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.z, z = val_3.x});
        }
        public static bool CheckCriticalChance(float critChance)
        {
            return (bool)((UnityEngine.Random.Range(min:  0f, max:  100f)) <= critChance) ? 1 : 0;
        }
        public void OnPushedToPool()
        {
            this.WeaponObject = 0;
            this.<Owner>k__BackingField = 0;
            this.enabled = false;
        }
        public void OnPulledFromPool()
        {
            this.enabled = true;
        }
    
    }

}

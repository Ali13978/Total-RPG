using UnityEngine;

namespace TzarGames.TzarHero
{
    public class ProjectileDamageHandler : TzarBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.TH_Projectile projectile;
        [UnityEngine.SerializeField]
        private bool addProjectileWeaponDamage;
        [UnityEngine.SerializeField]
        private bool percentDamage;
        [UnityEngine.SerializeField]
        private bool ignoreDefence;
        private bool alreadyHit;
        
        // Methods
        public ProjectileDamageHandler()
        {
        
        }
        private void Reset()
        {
            this.projectile = this.GetComponent<TzarGames.TzarHero.TH_Projectile>();
        }
        public void HandleCollision(UnityEngine.Collision otherCollision)
        {
            UnityEngine.ContactPoint[] val_1 = otherCollision.contacts;
            UnityEngine.ContactPoint val_4 = val_1[0];
            UnityEngine.ContactPoint val_5 = val_1[0];
            UnityEngine.ContactPoint val_6 = val_1[0];
            this.handleHit(instigator:  this.projectile.Instigator, hittedCollider:  otherCollision.collider, point:  new UnityEngine.Vector3() {x = val_6, y = V1.16B, z = V2.16B}, normal:  new UnityEngine.Vector3() {x = val_6, y = V1.16B, z = V2.16B});
        }
        public void HandleTrigger(UnityEngine.Collider otherTrigger)
        {
            UnityEngine.Vector3 val_2 = this.projectile.CachedTransform.position;
            if(otherTrigger == null)
            {
                goto label_3;
            }
            
            if(null != null)
            {
                goto label_4;
            }
            
            UnityEngine.Vector3 val_3 = otherTrigger.ClosestPoint(position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            goto label_5;
            label_3:
            label_4:
            UnityEngine.Vector3 val_5 = otherTrigger.transform.position;
            label_5:
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            if(val_6.x < 0.0001f)
            {
                    UnityEngine.Vector3 val_8 = this.projectile.CachedTransform.forward;
            }
            else
            {
                
            }
            
            this.handleHit(instigator:  this.projectile.Instigator, hittedCollider:  otherTrigger, point:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, normal:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        }
        private void handleHit(TzarGames.TzarHero.TH_Character instigator, UnityEngine.Collider hittedCollider, UnityEngine.Vector3 point, UnityEngine.Vector3 normal)
        {
            UnityEngine.Object val_22;
            UnityEngine.Collider val_23;
            var val_24;
            TzarGames.TzarHero.TH_Character val_25;
            TzarGames.GameFramework.IHit val_26;
            TzarGames.GameFramework.ISurfaceType val_27;
            TzarGames.TzarHero.TH_Character val_28;
            var val_29;
            var val_30;
            val_23 = hittedCollider;
            if(this.alreadyHit == true)
            {
                    return;
            }
            
            TzarGames.GameFramework.IDamageReceiver val_1 = val_23.GetComponent<TzarGames.GameFramework.IDamageReceiver>();
            val_22 = val_1;
            if((val_22 == null) || (val_1.OnClient == true))
            {
                goto label_17;
            }
            
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_24 = val_22;
            goto label_12;
            label_17:
            val_26 = 0;
            goto label_25;
            label_12:
            val_27 = val_22;
            TzarGames.GameFramework.Hit val_17 = null;
            val_26 = val_17;
            val_17 = new TzarGames.GameFramework.Hit(point:  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z}, normal:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z}, collider:  val_23, rigidbody:  val_23.attachedRigidbody, surfaceType:  val_27);
            val_28 = 0;
            TzarGames.TzarHero.CharacterDamageInfo val_18 = this.calculateDamageAndCreateDamageInfo(instigator:  instigator, victim:  val_28, hit:  val_26);
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_28 = 0;
            val_29 = val_22;
            label_25:
            this.alreadyHit = true;
            val_23 = val_23.GetComponent<TzarGames.GameFramework.IHittable>();
            if(val_23 == null)
            {
                    return;
            }
            
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_25 = 0;
            val_30 = val_23;
        }
        private TzarGames.TzarHero.CharacterDamageInfo calculateDamageAndCreateDamageInfo(TzarGames.TzarHero.TH_Character instigator, TzarGames.TzarHero.TH_Character victim, TzarGames.GameFramework.IHit hit)
        {
            float val_25;
            float val_26;
            float val_27;
            float val_28;
            float val_29;
            float val_30;
            bool val_31;
            val_25 = this.projectile.Damage;
            if(this.addProjectileWeaponDamage != false)
            {
                    TzarGames.GameFramework.Weapon val_2 = this.projectile.WeaponTemplate;
                val_25 = val_25 * val_2.damageModificator.Value;
            }
            
            if(0 != instigator)
            {
                    val_26 = instigator.TemplateInstance.CritChance;
                val_27 = instigator.TemplateInstance.CritMultiplier;
            }
            else
            {
                    val_26 = 0f;
                val_27 = 1f;
            }
            
            val_28 = 100f;
            float val_9 = UnityEngine.Random.Range(min:  0f, max:  val_28);
            val_29 = val_25 * val_27;
            val_25 = (val_9 <= val_26) ? (val_29) : (val_25);
            if(this.percentDamage != false)
            {
                    val_28 = 0.01f;
                val_29 = val_25 * victim.TemplateInstance.HitPoints;
                val_30 = val_29 * val_28;
            }
            
            UnityEngine.Vector3 val_13 = this.projectile.CachedTransform.forward;
            TzarGames.GameFramework.Weapon val_14 = this.projectile.WeaponTemplate;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, d:  val_14.damageForceMultiplier);
            TzarGames.GameFramework.Weapon val_16 = this.projectile.WeaponTemplate;
            TzarGames.TzarHero.TH_DamageType_Default val_18 = new TzarGames.TzarHero.TH_DamageType_Default(surfaceType:  TzarGames.GameFramework.SurfaceTypeBase.GetOrCreate(surfaceName:  null));
            var val_23 = ~val_18.OnClient;
            val_23 = val_23 & 1;
            typeof(TzarGames.TzarHero.CharacterDamageInfo).__il2cppRuntimeField_38 = instigator;
            typeof(TzarGames.TzarHero.CharacterDamageInfo).__il2cppRuntimeField_40 = victim;
            typeof(TzarGames.TzarHero.CharacterDamageInfo).__il2cppRuntimeField_36 = val_23;
            if(null != 0)
            {
                    typeof(TzarGames.TzarHero.CharacterDamageInfo).__il2cppRuntimeField_34 = (val_9 <= val_26) ? 1 : 0;
                val_31 = this.ignoreDefence;
            }
            else
            {
                    typeof(TzarGames.TzarHero.CharacterDamageInfo).__il2cppRuntimeField_34 = (val_9 <= val_26) ? 1 : 0;
                val_31 = this.ignoreDefence;
            }
            
            typeof(TzarGames.TzarHero.CharacterDamageInfo).__il2cppRuntimeField_35 = val_31;
            return (TzarGames.TzarHero.CharacterDamageInfo)new TzarGames.GameFramework.DamageInfoBase(damage:  val_30, force:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, damageType:  val_18, hitInfo:  hit);
        }
        private void adjustDamageToCharacter(TzarGames.GameFramework.Weapon weaponTemplate, TzarGames.TzarHero.TH_Character instigator, TzarGames.TzarHero.TH_Character character, TzarGames.GameFramework.IHit hit)
        {
            TzarGames.GameFramework.IHit val_10 = hit;
            if(20037.OnClient == true)
            {
                    return;
            }
            
            if(0 == character)
            {
                    return;
            }
            
            val_10 = this.calculateDamageAndCreateDamageInfo(instigator:  instigator, victim:  character, hit:  val_10 = hit);
            if(character != null)
            {
                    character.TakeDamage(damageInfo:  val_10);
            }
            else
            {
                    0.TakeDamage(damageInfo:  val_10);
            }
            
            if((System.Object.ReferenceEquals(objA:  0, objB:  character.TemplateInstance)) != false)
            {
                    return;
            }
            
            weaponTemplate.HitModificators.ApplyToTemplate(template:  character.TemplateInstance);
        }
    
    }

}

using UnityEngine;

namespace TzarGames.TzarHero
{
    public class TH_Explosion : TzarBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private float maxDamage;
        [UnityEngine.SerializeField]
        private bool percentDamage;
        [UnityEngine.SerializeField]
        private bool ignoreDefence;
        [UnityEngine.SerializeField]
        private float explosionPower;
        [UnityEngine.SerializeField]
        private bool explodeOnStart;
        [UnityEngine.SerializeField]
        private float explosionRadius;
        [UnityEngine.SerializeField]
        private float explosionDelay;
        
        // Methods
        public TH_Explosion()
        {
            this.maxDamage = 200f;
            this.explosionPower = 500f;
            this.explosionRadius = 5f;
        }
        private void Start()
        {
            if(this.explodeOnStart == false)
            {
                    return;
            }
            
            this.Explode(ignoreDelay:  false);
        }
        private void explodeTimeFunc()
        {
            this.Explode(ignoreDelay:  true);
        }
        public void Explode(bool ignoreDelay)
        {
            if((ignoreDelay != true) && (this.explosionDelay > 0f))
            {
                    this.Invoke(methodName:  "explodeTimeFunc", time:  this.explosionDelay);
                return;
            }
            
            UnityEngine.Transform val_2 = this.transform;
            UnityEngine.Vector3 val_3 = val_2.position;
            TzarGames.TzarHero.TH_Explosion.MakeExplosionDamage(instigator:  val_2, position:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, radius:  this.explosionRadius, damage:  this.maxDamage, percentDamage:  false, throwPower:  this.explosionPower, ignoreDefence:  (this.percentDamage != true) ? 1 : 0, sessionID:  (this.percentDamage > true) ? 1 : 0, stun:  false, stunTime:  0f, exceptThisOnes:  0);
        }
        public static void MakeExplosionDamage(TzarGames.TzarHero.TH_Character instigator, UnityEngine.Vector3 position, float radius, float damage, bool percentDamage, float throwPower, bool ignoreDefence, int sessionID, bool stun, float stunTime, TzarGames.TzarHero.TH_Character[] exceptThisOnes)
        {
            var val_28;
            var val_29;
            UnityEngine.Object val_30;
            float val_32;
            float val_33;
            var val_34;
            var val_35;
            var val_36;
            val_28 = 0;
            if(X6 != 0)
            {
                    if((X6 + 24) != 0)
            {
                    System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> val_1 = null;
                val_28 = val_1;
                val_1 = new System.Collections.Generic.List<TzarGames.TzarHero.TH_Character>(collection:  X6);
            }
            else
            {
                    val_28 = 0;
            }
            
            }
            
            val_29 = 0;
            goto label_4;
            label_44:
            val_29 = 1;
            label_4:
            val_30 = TzarGames.TzarHero.TH_Character.AllCharacters;
            if(val_29 >= val_30.Count)
            {
                    return;
            }
            
            val_30 = TzarGames.TzarHero.TH_Character.AllCharacters.Item[1];
            if(0 != val_30)
            {
                goto label_14;
            }
            
            UnityEngine.Debug.LogError(message:  0);
            goto label_44;
            label_14:
            if(val_28 == 0)
            {
                goto label_18;
            }
            
            bool val_10 = val_28.Contains(item:  val_30);
            if(val_10 == true)
            {
                goto label_44;
            }
            
            label_18:
            if(val_10 != stun)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_11 = X26.position;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            if(val_12.x > (radius * radius))
            {
                goto label_44;
            }
            
            UnityEngine.Vector3 val_13 = X26.position;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            val_32 = damage;
            if(ignoreDefence != false)
            {
                    float val_15 = val_7.characterTemplateInstance.HitPoints;
                val_15 = val_15 * damage;
                val_32 = val_15 * 0.01f;
            }
            
            if(val_13.z >= _TYPE_MAX_)
            {
                    val_33 = val_12.x;
            }
            
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  throwPower);
            typeof(TzarGames.TzarHero.TH_DamageType_Default).__il2cppRuntimeField_10 = val_30;
            if(val_30 != null)
            {
                    val_34 = 1152921510548278032;
                val_35 = stun;
                val_36 = val_30.OnClient;
            }
            else
            {
                    val_34 = 1152921510548278032;
                val_35 = stun;
                val_36 = val_30.OnClient;
            }
            
            UnityEngine.Vector3 val_20 = stun.position;
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  val_20.x);
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            TzarGames.TzarHero.CharacterDamageInfo val_26 = null;
            float val_27 = radius;
            val_27 = val_33 / val_27;
            val_27 = 1f - val_27;
            val_27 = val_32 * val_27;
            val_26 = new TzarGames.TzarHero.CharacterDamageInfo(damage:  val_27, force:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, damageType:  new System.Object(), instigator:  0, victim:  val_30, isAuthoritative:  (~val_36) & 1, hitInfo:  new TzarGames.GameFramework.Hit(point:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, normal:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, collider:  0, rigidbody:  0, surfaceType:  val_30));
            IgnoreDefence = sessionID & 1;
            val_30.TakeDamage(damageInfo:  val_26);
            if((exceptThisOnes & 1) == 0)
            {
                goto label_44;
            }
            
            val_30.Stun(stunTime:  stunTime);
            goto label_44;
        }
    
    }

}

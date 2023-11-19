using UnityEngine;

namespace TzarGames.TzarHero
{
    public class TH_Pusher : MonoBehaviour
    {
        // Fields
        public TzarGames.TzarHero.TH_Character Pusher;
        public float PushForce;
        public float PushDamage;
        private System.Collections.Generic.Dictionary<TzarGames.TzarHero.TH_Character, float> damageInfo;
        public UnityEngine.LayerMask layersForCheck;
        
        // Methods
        public TH_Pusher()
        {
            this.PushForce = 1f;
            this.PushDamage = 0f;
            this.damageInfo = new System.Collections.Generic.Dictionary<TzarGames.TzarHero.TH_Character, System.Single>();
        }
        private void checkCollider(UnityEngine.Collider other)
        {
            TzarGames.TzarHero.TH_Character val_11;
            System.Collections.Generic.Dictionary<TzarGames.TzarHero.TH_Character, System.Single> val_12;
            System.Collections.Generic.Dictionary<TzarGames.TzarHero.TH_Character, System.Single> val_13;
            val_11 = this.Pusher;
            if(0 == val_11)
            {
                    return;
            }
            
            val_11 = this.Pusher;
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            TzarGames.TzarHero.TH_Character val_5 = other.gameObject.GetComponent<TzarGames.TzarHero.TH_Character>();
            if(0 == val_5)
            {
                    return;
            }
            
            val_11 = this.Pusher;
            if(0 == val_5)
            {
                    return;
            }
            
            val_12 = this.damageInfo;
            if((val_12.ContainsKey(key:  val_5)) != false)
            {
                    val_13 = this.damageInfo;
                float val_10 = val_13.Item[val_5];
                val_10 = UnityEngine.Time.time - val_10;
                if(val_10 < 1f)
            {
                    return;
            }
            
            }
            
            this.adjustDamageTo(character:  val_5);
        }
        private void Update()
        {
            float val_4;
            float val_8;
            var val_11;
            UnityEngine.Bounds val_2 = this.GetComponent<UnityEngine.Collider>().bounds;
            UnityEngine.Bounds val_6 = this.GetComponent<UnityEngine.Collider>().bounds;
            int val_9 = this.layersForCheck.value;
            val_11 = 0;
            goto label_3;
            label_7:
            this.checkCollider(other:  null);
            val_11 = 1;
            label_3:
            if(val_11 >= val_10.Length)
            {
                    return;
            }
            
            if(val_11 < val_10.Length)
            {
                goto label_7;
            }
            
            goto label_7;
        }
        private void OnEnable()
        {
        
        }
        private void OnDisable()
        {
            UnityEngine.Object val_9;
            var val_20;
            var val_21;
            if((((0 == this.Pusher) || ((UnityEngine.Object.op_Implicit(exists:  0)) == false)) || (0 == (this.Pusher.GetComponent<UnityEngine.Collider>()))) || ((this.Pusher.GetComponent<UnityEngine.Collider>().enabled) == false))
            {
                goto label_38;
            }
            
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_8 = this.damageInfo.Keys.GetEnumerator();
            label_35:
            if((0 & 1) == 0)
            {
                goto label_16;
            }
            
            if(((((0 == val_9) || ((UnityEngine.Object.op_Implicit(exists:  0)) == false)) || (0 == (val_9.GetComponent<UnityEngine.Collider>()))) || ((val_9.GetComponent<UnityEngine.Collider>().enabled) == false)) || (0 == val_9))
            {
                goto label_35;
            }
            
            UnityEngine.Physics.IgnoreCollision(collider1:  0, collider2:  this.Pusher.GetComponent<UnityEngine.Collider>(), ignore:  val_9.GetComponent<UnityEngine.Collider>());
            goto label_35;
            label_16:
            val_20 = 0;
            val_21 = 1;
            label_38:
            this.damageInfo.Clear();
        }
        private void adjustDamageTo(TzarGames.TzarHero.TH_Character character)
        {
            var val_33;
            UnityEngine.Object val_34;
            UnityEngine.Vector3 val_1 = position;
            UnityEngine.Vector3 val_3 = this.transform.position;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            float val_5 = UnityEngine.Random.Range(min:  0.8f, max:  1.2f);
            val_5 = val_4.x * val_5;
            float val_6 = UnityEngine.Random.Range(min:  0.8f, max:  1.2f);
            val_6 = val_4.z * val_6;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5, y = val_4.y, z = val_6}, d:  this.PushForce);
            typeof(TzarGames.TzarHero.TH_DamageType_Push).__il2cppRuntimeField_10 = TzarGames.GameFramework.SurfaceTypeBase.GetOrCreate(surfaceName:  0);
            if(character != null)
            {
                    val_33 = character.OnClient;
            }
            else
            {
                    val_33 = 0.OnClient;
            }
            
            UnityEngine.Vector3 val_12 = X24.position;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5, y = val_4.y, z = val_6}, d:  val_12.x);
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_5, y = val_4.y, z = val_6});
            character.TakeDamage(damageInfo:  new TzarGames.TzarHero.CharacterDamageInfo(damage:  this.PushDamage, force:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, damageType:  new System.Object(), instigator:  this.Pusher, victim:  character, isAuthoritative:  (~val_33) & 1, hitInfo:  new TzarGames.GameFramework.Hit(point:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, normal:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, collider:  0, rigidbody:  0, surfaceType:  character)));
            this.damageInfo.set_Item(key:  character, value:  UnityEngine.Time.time);
            val_34 = this.Pusher.GetComponent<UnityEngine.Collider>();
            if(0 == val_34)
            {
                    return;
            }
            
            val_34 = this.Pusher.GetComponent<UnityEngine.Collider>();
            if(val_34.enabled == false)
            {
                    return;
            }
            
            val_34 = character.GetComponent<UnityEngine.Collider>();
            if(0 == val_34)
            {
                    return;
            }
            
            val_34 = character.GetComponent<UnityEngine.Collider>();
            if(val_34.enabled == false)
            {
                    return;
            }
            
            val_34 = this.Pusher.GetComponent<UnityEngine.Collider>();
            UnityEngine.Collider val_29 = character.GetComponent<UnityEngine.Collider>();
            if(0 == val_34)
            {
                    return;
            }
            
            UnityEngine.Physics.IgnoreCollision(collider1:  0, collider2:  this.Pusher.GetComponent<UnityEngine.Collider>(), ignore:  character.GetComponent<UnityEngine.Collider>());
        }
    
    }

}

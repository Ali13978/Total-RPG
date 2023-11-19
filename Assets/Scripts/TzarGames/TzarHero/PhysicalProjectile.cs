using UnityEngine;

namespace TzarGames.TzarHero
{
    [UnityEngine.RequireComponent]
    public class PhysicalProjectile : TH_Projectile
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Collider _collider;
        [UnityEngine.SerializeField]
        private float forwardPushForce;
        [UnityEngine.SerializeField]
        private float upPushForce;
        [UnityEngine.SerializeField]
        private bool decreaseUpForceByDistance;
        [UnityEngine.SerializeField]
        private float targetUpOffset;
        [UnityEngine.SerializeField]
        private float colliderEnableDelay;
        [UnityEngine.SerializeField]
        private UnityEngine.Rigidbody rbody;
        [UnityEngine.SerializeField]
        private bool destroyOnCollide;
        [UnityEngine.SerializeField]
        private bool rotateToTargetOnLaunch;
        [UnityEngine.SerializeField]
        private bool changeGravityOnLaunch;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private bool doExplosionDamage;
        [UnityEngine.SerializeField]
        private float explosionRadius;
        [UnityEngine.SerializeField]
        private float explosionForce;
        [UnityEngine.SerializeField]
        private bool stun;
        [UnityEngine.SerializeField]
        private float stunTime;
        [UnityEngine.SerializeField]
        private bool ignoreDefence;
        [UnityEngine.SerializeField]
        private bool percentDamage;
        [UnityEngine.SerializeField]
        private TzarGames.Common.Events.CollisionEvent onCollide;
        [UnityEngine.SerializeField]
        private TzarGames.Common.Events.TriggerEvent onTriggerCollide;
        private bool collided;
        private bool launched;
        
        // Methods
        public PhysicalProjectile()
        {
            this.forwardPushForce = 10f;
            this.decreaseUpForceByDistance = true;
            this.rotateToTargetOnLaunch = true;
            this.changeGravityOnLaunch = true;
            this.explosionRadius = 5f;
            this.explosionForce = 1000f;
            this.stunTime = 2f;
        }
        protected override void Start()
        {
            this.Start();
            if(this.launched != false)
            {
                    return;
            }
            
            if(0 != this._collider)
            {
                    this._collider.enabled = false;
            }
            
            this.rbody.isKinematic = true;
            this.rbody.useGravity = false;
        }
        public override void NotifyLaunched()
        {
            float val_25;
            float val_26;
            float val_27;
            float val_28;
            float val_29;
            float val_30;
            this.NotifyLaunched();
            this.launched = true;
            this.rbody.isKinematic = false;
            if(this.changeGravityOnLaunch != false)
            {
                    this.rbody.useGravity = true;
            }
            
            if(0 != this._collider)
            {
                    val_25 = this.colliderEnableDelay;
                val_26 = 0.0001f;
                if(val_25 < val_26)
            {
                    this._collider.enabled = true;
            }
            else
            {
                    UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.colliderEnableRoutine());
            }
            
            }
            
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  this.upPushForce);
            val_27 = val_6.x;
            val_28 = val_6.y;
            val_29 = val_6.z;
            if(0 != this.Target)
            {
                    UnityEngine.Vector3 val_10 = this.Target.GroundPivotPosition;
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.up;
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  this.targetUpOffset);
                val_25 = val_10.x;
                val_26 = val_10.y;
                val_30 = val_10.z;
                UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_25, y = val_26, z = val_30}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
                if(this.rotateToTargetOnLaunch != false)
            {
                    UnityEngine.Transform val_14 = this.transform;
                val_25 = val_13.x;
                val_26 = val_13.y;
                val_30 = val_13.z;
                val_14.LookAt(worldPosition:  new UnityEngine.Vector3() {x = val_25, y = val_26, z = val_30});
            }
            
                if(this.decreaseUpForceByDistance != false)
            {
                    if((0 != val_14) && (val_25 > 0f))
            {
                    UnityEngine.Vector3 val_17 = this.transform.position;
                float val_25 = val_17.x;
                val_26 = val_28;
                val_25 = (UnityEngine.Mathf.Clamp(value:  UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_25, y = val_17.y, z = val_17.z}), min:  0f, max:  val_13.y)) / (UnityEngine.Mathf.Clamp(value:  UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_25, y = val_17.y, z = val_17.z}), min:  0f, max:  val_13.y));
                val_25 = val_27;
                val_30 = val_29;
                UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_25, y = val_26, z = val_30}, d:  val_25);
                val_27 = val_20.x;
                val_28 = val_20.y;
                val_29 = val_20.z;
            }
            
            }
            
            }
            
            UnityEngine.Vector3 val_22 = this.transform.forward;
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, d:  this.forwardPushForce);
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, b:  new UnityEngine.Vector3() {x = val_27, y = val_28, z = val_29});
            this.rbody.AddForce(force:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, mode:  1);
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator colliderEnableRoutine()
        {
            typeof(PhysicalProjectile.<colliderEnableRoutine>c__Iterator0).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void OnTriggerEnter(UnityEngine.Collider other)
        {
            if(this._collider.isTrigger == false)
            {
                    return;
            }
            
            if((this.handleCollision(otherCollider:  other)) == false)
            {
                    return;
            }
            
            this.onTriggerCollide.Invoke(arg0:  other);
        }
        protected virtual bool ShouldIgnoreCollider(UnityEngine.Collider collider)
        {
            UnityEngine.Object val_12;
            UnityEngine.Object val_13;
            var val_14;
            val_12 = 1152921504721543168;
            val_13 = collider.GetComponent<TzarGames.TzarHero.TH_Character>();
            if(0 == val_13)
            {
                goto label_15;
            }
            
            val_12 = this.Instigator;
            if(0 == val_12)
            {
                goto label_9;
            }
            
            val_13 = val_13.TemplateInstance.Group;
            if((this.Instigator.TemplateInstance.Group.IsFriendly(group:  val_13)) == false)
            {
                goto label_15;
            }
            
            label_9:
            val_14 = 1;
            return (bool)val_14;
            label_15:
            val_14 = 0;
            return (bool)val_14;
        }
        private bool handleCollision(UnityEngine.Collider otherCollider)
        {
            var val_5;
            if((0 & 1) == 0)
            {
                    if(this.collided == false)
            {
                goto label_1;
            }
            
            }
            
            val_5 = 0;
            return (bool)val_5;
            label_1:
            this.collided = true;
            if(this.doExplosionDamage != false)
            {
                    UnityEngine.Vector3 val_3 = this.transform.position;
                TzarGames.TzarHero.TH_Explosion.MakeExplosionDamage(instigator:  0, position:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, radius:  this.explosionRadius, damage:  this.Damage, percentDamage:  this.Instigator, throwPower:  this.explosionForce, ignoreDefence:  this.percentDamage, sessionID:  this.ignoreDefence, stun:  false, stunTime:  this.stunTime, exceptThisOnes:  this.stun);
            }
            
            if(this.destroyOnCollide != false)
            {
                    this.DestroyOnTime();
            }
            
            val_5 = 1;
            return (bool)val_5;
        }
        private void OnCollisionEnter(UnityEngine.Collision other)
        {
            if(this._collider.isTrigger == true)
            {
                    return;
            }
            
            if((this.handleCollision(otherCollider:  other.collider)) == false)
            {
                    return;
            }
            
            this.onCollide.Invoke(arg0:  other);
        }
        private void Reset()
        {
            this.rbody = this.GetComponent<UnityEngine.Rigidbody>();
            this._collider = this.GetComponent<UnityEngine.Collider>();
        }
    
    }

}

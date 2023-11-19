using UnityEngine;

namespace LlockhamIndustries.Decals
{
    [UnityEngine.ExecuteInEditMode]
    [UnityEngine.RequireComponent]
    public class ParticleCollisionPrinter : Printer
    {
        // Fields
        public LlockhamIndustries.Decals.RotationSource rotationSource;
        public float ratio;
        private UnityEngine.ParticleSystem partSystem;
        private float maxparticleCollisionSize;
        private System.Collections.Generic.List<UnityEngine.ParticleCollisionEvent> collisionEvents;
        
        // Methods
        public ParticleCollisionPrinter()
        {
            this.ratio = 1f;
        }
        private void Start()
        {
            this.partSystem = this.GetComponent<UnityEngine.ParticleSystem>();
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            this.collisionEvents = new System.Collections.Generic.List<UnityEngine.ParticleCollisionEvent>();
        }
        private void Update()
        {
            UnityEngine.ParticleSystem val_3;
            var val_4;
            val_3 = this;
            CollisionModule val_1 = this.partSystem.collision;
            if((0 & 1) != 0)
            {
                    val_3 = this.partSystem;
                CollisionModule val_2 = val_3.collision;
                if((0 & 1) != 0)
            {
                    return;
            }
            
                val_4 = "Particle system must send collision messages for the particle system to print decals. This option can be enabled under the collisions menu.";
            }
            else
            {
                    val_4 = "Particle system collisions must be enabled for the particle system to print decals";
            }
            
            UnityEngine.Debug.LogWarning(message:  0);
        }
        private void OnParticleCollision(UnityEngine.GameObject other)
        {
            float val_7;
            float val_8;
            float val_11;
            float val_12;
            var val_33;
            float val_34;
            float val_35;
            float val_36;
            float val_37;
            float val_38;
            UnityEngine.Transform val_40;
            float val_41;
            float val_42;
            float val_43;
            LlockhamIndustries.Decals.RotationSource val_44;
            if(this.enabled == false)
            {
                    return;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            val_34 = this.ratio;
            if(val_34 <= 0f)
            {
                    return;
            }
            
            val_33 = UnityEngine.ParticlePhysicsExtensions.GetCollisionEvents(ps:  0, go:  this.partSystem, collisionEvents:  other);
            if(val_33 < 1)
            {
                    return;
            }
            
            var val_32 = 0;
            val_35 = 1f;
            label_32:
            val_36 = this.ratio;
            if(val_36 == val_35)
            {
                goto label_5;
            }
            
            val_34 = 0f;
            if(val_36 <= (UnityEngine.Random.Range(min:  val_34, max:  val_35)))
            {
                goto label_13;
            }
            
            label_5:
            UnityEngine.ParticleCollisionEvent val_5 = this.collisionEvents.Item[0];
            val_37 = val_7;
            val_38 = V2.16B;
            UnityEngine.ParticleCollisionEvent val_9 = this.collisionEvents.Item[0];
            val_36 = val_12;
            if(other != null)
            {
                    UnityEngine.Transform val_13 = other.transform;
            }
            else
            {
                    UnityEngine.Transform val_14 = 0.transform;
            }
            
            val_40 = 1 << (other.layer & 31);
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_36, y = val_11, z = V2.16B});
            val_41 = val_37;
            val_42 = val_8;
            val_43 = val_38;
            if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_41, y = val_42, z = val_43}, direction:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3(), m_Normal = new UnityEngine.Vector3(), m_UV = new UnityEngine.Vector2()}, maxDistance:  Infinityf, layerMask:  -1375963488)) == false)
            {
                goto label_13;
            }
            
            val_38 = val_35;
            val_44 = this.rotationSource;
            val_40 = 0.Payload.transform;
            if(val_44 != 0)
            {
                goto label_15;
            }
            
            UnityEngine.ParticleCollisionEvent val_21 = this.collisionEvents.Item[0];
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.zero;
            val_41 = val_7;
            val_42 = val_8;
            val_43 = val_43;
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_41, y = val_42, z = val_43}, rhs:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z})) == false)
            {
                goto label_19;
            }
            
            UnityEngine.ParticleCollisionEvent val_24 = this.collisionEvents.Item[0];
            goto label_23;
            label_19:
            val_44 = this.rotationSource;
            label_15:
            if(val_44 == 1)
            {
                    UnityEngine.Vector3 val_25 = UnityEngine.Random.insideUnitSphere;
            }
            else
            {
                    UnityEngine.Vector3 val_26 = UnityEngine.Vector3.up;
            }
            
            label_23:
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_41, y = val_42, z = val_43});
            UnityEngine.Quaternion val_28 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, upwards:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
            val_36 = val_28.x;
            val_37 = val_28.z;
            val_35 = val_38;
            this.Print(Position:  new UnityEngine.Vector3() {x = val_41, y = val_42, z = val_43}, Rotation:  new UnityEngine.Quaternion() {x = val_36, y = val_28.y, z = val_37, w = val_28.w}, Surface:  val_40, Layer:  0.Payload.gameObject.layer);
            label_13:
            val_32 = val_32 + 1;
            if(val_33 != val_32)
            {
                goto label_32;
            }
        
        }
    
    }

}

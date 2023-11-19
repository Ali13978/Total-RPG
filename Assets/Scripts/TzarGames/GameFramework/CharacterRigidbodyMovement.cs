using UnityEngine;

namespace TzarGames.GameFramework
{
    [UnityEngine.RequireComponent]
    [UnityEngine.RequireComponent]
    public class CharacterRigidbodyMovement : TzarBehaviour, ICharacterMovement
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <EnableMovement>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Vector3 <InputVector>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <SyncRotationFromServer>k__BackingField;
        [UnityEngine.SerializeField]
        private UnityEngine.Rigidbody rbody;
        [UnityEngine.SerializeField]
        private UnityEngine.CapsuleCollider capsule;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.CharacterRigidbodyMovement.MovementSettings movementSettings;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.CharacterRigidbodyMovement.AdvancedSettings advancedSettings;
        private bool previouslyGrounded;
        private bool isGrounded;
        private UnityEngine.Vector3 groundContactNormal;
        private bool jumping;
        private bool jump;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.Common.TG_VoidDelegate onPreMovementUpdate;
        
        // Properties
        public float CurrentMoveSpeed { get; }
        public float Height { get; }
        public float Radius { get; }
        public bool Enabled { get; set; }
        public bool EnableMovement { get; set; }
        public UnityEngine.Vector3 InputVector { get; set; }
        public float MaxSpeed { get; set; }
        public bool SyncRotationFromServer { get; set; }
        public UnityEngine.Vector3 Velocity { get; }
        public bool IsGrounded { get; }
        
        // Methods
        public CharacterRigidbodyMovement()
        {
            object val_1 = null;
            typeof(CharacterRigidbodyMovement.AdvancedSettings).__il2cppRuntimeField_10 = 1008981770;
            typeof(CharacterRigidbodyMovement.AdvancedSettings).__il2cppRuntimeField_14 = 1056964608;
            val_1 = new System.Object();
            this.advancedSettings = val_1;
        }
        public float get_CurrentMoveSpeed()
        {
            UnityEngine.Vector3 val_1 = this.rbody.velocity;
            return (float)val_1.x;
        }
        public float get_Height()
        {
            if(this.capsule != null)
            {
                    return this.capsule.height;
            }
            
            return this.capsule.height;
        }
        public float get_Radius()
        {
            if(this.capsule != null)
            {
                    return this.capsule.radius;
            }
            
            return this.capsule.radius;
        }
        public bool get_Enabled()
        {
            return this.enabled;
        }
        public void set_Enabled(bool value)
        {
            value = value;
            this.enabled = value;
            this.rbody.isKinematic = (~value) & 1;
            bool val_2 = value;
            this.rbody.useGravity = val_2;
            this.capsule.enabled = val_2;
        }
        public bool get_EnableMovement()
        {
            return (bool)this.<EnableMovement>k__BackingField;
        }
        public void set_EnableMovement(bool value)
        {
            this.<EnableMovement>k__BackingField = value;
        }
        public UnityEngine.Vector3 get_InputVector()
        {
            return new UnityEngine.Vector3() {x = this.<InputVector>k__BackingField};
        }
        public void set_InputVector(UnityEngine.Vector3 value)
        {
            this.<InputVector>k__BackingField = value;
            mem[1152921511295330584] = value.y;
            mem[1152921511295330588] = value.z;
        }
        public float get_MaxSpeed()
        {
            if(this.movementSettings != null)
            {
                    return (float)this.movementSettings.CurrentTargetSpeed;
            }
            
            return (float)this.movementSettings.CurrentTargetSpeed;
        }
        public void set_MaxSpeed(float value)
        {
            this.movementSettings.CurrentTargetSpeed = value;
        }
        public bool get_SyncRotationFromServer()
        {
            return (bool)this.<SyncRotationFromServer>k__BackingField;
        }
        public void set_SyncRotationFromServer(bool value)
        {
            this.<SyncRotationFromServer>k__BackingField = value;
        }
        public UnityEngine.Vector3 get_Velocity()
        {
            if(this.rbody != null)
            {
                    return this.rbody.velocity;
            }
            
            return this.rbody.velocity;
        }
        public bool get_IsGrounded()
        {
            return (bool)this.isGrounded;
        }
        private void add_onPreMovementUpdate(TzarGames.Common.TG_VoidDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.onPreMovementUpdate);
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
            while(1152921511296151520 != this.onPreMovementUpdate);
        
        }
        private void remove_onPreMovementUpdate(TzarGames.Common.TG_VoidDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.onPreMovementUpdate);
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
            while(1152921511296288096 != this.onPreMovementUpdate);
        
        }
        private void Reset()
        {
            UnityEngine.Rigidbody val_1 = this.GetComponent<UnityEngine.Rigidbody>();
            this.rbody = val_1;
            if(0 != val_1)
            {
                    this.rbody.freezeRotation = true;
            }
            
            this.capsule = this.GetComponent<UnityEngine.CapsuleCollider>();
        }
        public void LockSpeedOverride(object locker, float speed)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        public void NotifyPositionChange(UnityEngine.Vector3 position)
        {
            this.rbody.position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
        }
        public void UnlockSpeedOverride(object locker)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        public void ZeroMovement()
        {
        
        }
        private void Update()
        {
            UnityEngine.Vector3 val_7;
            float val_8;
            MovementSettings val_9;
            float val_10;
            MovementSettings val_11;
            MovementSettings val_13;
            bool val_14;
            this.GroundCheck();
            val_7 = this.<InputVector>k__BackingField;
            if(System.Math.Abs(val_7) <= 0.0001f)
            {
                    if(System.Math.Abs(S9) <= 0.0001f)
            {
                goto label_21;
            }
            
            }
            
            if(this.advancedSettings.airControl != true)
            {
                    if(this.isGrounded == false)
            {
                goto label_21;
            }
            
            }
            
            if(this.onPreMovementUpdate != null)
            {
                    this.onPreMovementUpdate.Invoke();
            }
            
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.ProjectOnPlane(vector:  new UnityEngine.Vector3() {x = val_7, y = V9.16B, z = V8.16B}, planeNormal:  new UnityEngine.Vector3() {x = this.groundContactNormal, y = V12.16B, z = 0.0001f});
            val_9 = this.movementSettings;
            float val_10 = val_1.y;
            val_7 = val_1.z;
            if(val_9 == null)
            {
                goto label_13;
            }
            
            val_10 = this.movementSettings.CurrentTargetSpeed;
            val_11 = val_9;
            val_8 = val_1.x * val_10;
            goto label_16;
            label_13:
            val_10 = this.movementSettings.CurrentTargetSpeed;
            val_11 = this.movementSettings;
            val_8 = val_1.x * val_10;
            if(val_11 == null)
            {
                goto label_15;
            }
            
            val_9 = val_11;
            goto label_16;
            label_15:
            val_9 = this.movementSettings;
            if(val_9 == null)
            {
                goto label_20;
            }
            
            label_16:
            UnityEngine.Vector3 val_2 = this.rbody.velocity;
            val_13 = this.movementSettings;
            if(this.movementSettings != null)
            {
                goto label_19;
            }
            
            val_13 = this.movementSettings;
            if(val_13 == null)
            {
                goto label_20;
            }
            
            label_19:
            float val_9 = this.movementSettings.CurrentTargetSpeed;
            val_9 = val_9 * this.movementSettings.CurrentTargetSpeed;
            if(val_2.x < 0)
            {
                    val_7 = val_7 * this.movementSettings.CurrentTargetSpeed;
                val_10 = val_10 * this.movementSettings.CurrentTargetSpeed;
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8, y = val_10, z = val_7}, d:  this.SlopeMultiplier());
                val_8 = val_4.x;
                val_7 = val_4.z;
                this.rbody.AddForce(force:  new UnityEngine.Vector3() {x = val_8, y = val_4.y, z = val_7}, mode:  1);
            }
            
            label_21:
            val_14 = this.isGrounded;
            if(val_14 == false)
            {
                goto label_26;
            }
            
            this.rbody.drag = 5f;
            if(this.jump == false)
            {
                goto label_36;
            }
            
            this.rbody.drag = 0f;
            UnityEngine.Vector3 val_5 = this.rbody.velocity;
            val_8 = val_5.x;
            UnityEngine.Vector3 val_6 = this.rbody.velocity;
            this.rbody.velocity = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_14 = true;
            this.rbody.AddForce(force:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, mode:  1);
            this.jumping = val_14;
            goto label_36;
            label_26:
            this.rbody.drag = 0f;
            if((this.previouslyGrounded != false) && (this.jumping != true))
            {
                    this.StickToGroundHelper();
            }
            
            label_36:
            this.jump = false;
            return;
            label_20:
        }
        private void GroundCheck()
        {
            this.previouslyGrounded = this.isGrounded;
            UnityEngine.Vector3 val_2 = this.transform.position;
            UnityEngine.Vector3 val_3 = this.capsule.center;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.down;
            float val_15 = 1f;
            val_15 = val_15 - this.advancedSettings.shellOffset;
            float val_10 = this.capsule.height * 0.5f;
            val_10 = val_10 - this.capsule.radius;
            if((UnityEngine.Physics.SphereCast(origin:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, radius:  this.capsule.radius * val_15, direction:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3(), m_Normal = new UnityEngine.Vector3(), m_UV = new UnityEngine.Vector2()}, maxDistance:  val_10 + this.advancedSettings.groundCheckDistance, layerMask:  -1899505744, queryTriggerInteraction:  0)) != false)
            {
                    this.isGrounded = true;
            }
            else
            {
                    this.isGrounded = false;
                UnityEngine.Vector3 val_13 = UnityEngine.Vector3.up;
            }
            
            this.groundContactNormal = val_13;
            mem[1152921511297288144] = val_13.y;
            mem[1152921511297288148] = val_13.z;
            if((this.previouslyGrounded & 255) == true)
            {
                    return;
            }
            
            if(this.previouslyGrounded < true)
            {
                    return;
            }
            
            if(this.jumping == false)
            {
                    return;
            }
            
            this.jumping = false;
        }
        private float SlopeMultiplier()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.up;
            if(this.movementSettings.SlopeCurveModifier != null)
            {
                    return this.movementSettings.SlopeCurveModifier.Evaluate(time:  UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = this.groundContactNormal, y = V9.16B, z = V8.16B}, to:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}));
            }
            
            return this.movementSettings.SlopeCurveModifier.Evaluate(time:  UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = this.groundContactNormal, y = V9.16B, z = V8.16B}, to:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}));
        }
        private void StickToGroundHelper()
        {
            UnityEngine.Rigidbody val_15;
            float val_16;
            float val_17;
            float val_18;
            val_15 = this;
            UnityEngine.Vector3 val_2 = this.transform.position;
            val_16 = val_2.z;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.down;
            val_17 = val_4.x;
            val_18 = this.capsule.radius;
            float val_15 = 1f;
            val_15 = val_15 - this.advancedSettings.shellOffset;
            float val_8 = this.capsule.height * 0.5f;
            val_8 = val_8 - val_18;
            if((UnityEngine.Physics.SphereCast(origin:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_16}, radius:  this.capsule.radius * val_15, direction:  new UnityEngine.Vector3() {x = val_17, y = val_4.y, z = val_4.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3(), m_Normal = new UnityEngine.Vector3(), m_UV = new UnityEngine.Vector2()}, maxDistance:  val_8 + this.advancedSettings.stickToGroundHelperDistance, layerMask:  -1899208016, queryTriggerInteraction:  0)) == false)
            {
                    return;
            }
            
            val_16 = val_16;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.up;
            val_18 = UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_16}, to:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            if(System.Math.Abs(val_18) >= 0)
            {
                    return;
            }
            
            val_15 = this.rbody;
            UnityEngine.Vector3 val_13 = val_15.velocity;
            val_17 = val_13.y;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.ProjectOnPlane(vector:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, planeNormal:  new UnityEngine.Vector3() {x = val_13.x, y = val_17, z = val_13.z});
            val_18 = val_14.x;
            val_16 = val_14.z;
            val_15.velocity = new UnityEngine.Vector3() {x = val_18, y = val_14.y, z = val_16};
        }
        public void AddPreMovementUpdateHandler(TzarGames.Common.TG_VoidDelegate handler)
        {
            this.add_onPreMovementUpdate(value:  handler);
        }
        public void RemovePreMovementUpdateHandler(TzarGames.Common.TG_VoidDelegate handler)
        {
            this.remove_onPreMovementUpdate(value:  handler);
        }
        public void Jump()
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        public void HandleRootMotion(UnityEngine.Vector3 deltaPosition, UnityEngine.Quaternion deltaRotation)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        public void StopJumping()
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
    
    }

}

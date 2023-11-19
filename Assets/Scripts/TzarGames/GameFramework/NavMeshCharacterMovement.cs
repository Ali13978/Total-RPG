using UnityEngine;

namespace TzarGames.GameFramework
{
    public class NavMeshCharacterMovement : MonoBehaviour, ICharacterMovement
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.AI.NavMeshAgent agent;
        [UnityEngine.SerializeField]
        private bool enableRotation;
        private UnityEngine.Coroutine pathCoroutine;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.GameFramework.Player <Owner>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Vector3 <InputVector>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <SyncRotationFromServer>k__BackingField;
        
        // Properties
        public TzarGames.GameFramework.Player Owner { get; set; }
        public float CurrentMoveSpeed { get; }
        public float Height { get; }
        public float Radius { get; }
        public UnityEngine.Vector3 Velocity { get; }
        public UnityEngine.Vector3 InputVector { get; set; }
        public bool SyncRotationFromServer { get; set; }
        public float MaxSpeed { get; set; }
        public bool EnableMovement { get; set; }
        public bool IsGrounded { get; }
        
        // Methods
        public NavMeshCharacterMovement()
        {
        
        }
        public TzarGames.GameFramework.Player get_Owner()
        {
            return (TzarGames.GameFramework.Player)this.<Owner>k__BackingField;
        }
        private void set_Owner(TzarGames.GameFramework.Player value)
        {
            this.<Owner>k__BackingField = value;
        }
        public float get_CurrentMoveSpeed()
        {
            if(this.agent != null)
            {
                    return this.agent.speed;
            }
            
            return this.agent.speed;
        }
        public float get_Height()
        {
            if(this.agent != null)
            {
                    return this.agent.height;
            }
            
            return this.agent.height;
        }
        public float get_Radius()
        {
            if(this.agent != null)
            {
                    return this.agent.radius;
            }
            
            return this.agent.radius;
        }
        public UnityEngine.Vector3 get_Velocity()
        {
            if(this.agent != null)
            {
                    return this.agent.velocity;
            }
            
            return this.agent.velocity;
        }
        public UnityEngine.Vector3 get_InputVector()
        {
            return new UnityEngine.Vector3() {x = this.<InputVector>k__BackingField};
        }
        public void set_InputVector(UnityEngine.Vector3 value)
        {
            this.<InputVector>k__BackingField = value;
            mem[1152921511415826716] = value.y;
            mem[1152921511415826720] = value.z;
        }
        public bool get_SyncRotationFromServer()
        {
            return (bool)this.<SyncRotationFromServer>k__BackingField;
        }
        public void set_SyncRotationFromServer(bool value)
        {
            this.<SyncRotationFromServer>k__BackingField = value;
        }
        public float get_MaxSpeed()
        {
            if(this.agent != null)
            {
                    return this.agent.speed;
            }
            
            return this.agent.speed;
        }
        public void set_MaxSpeed(float value)
        {
            this.agent.speed = value;
        }
        public bool get_EnableMovement()
        {
            if(this.agent != null)
            {
                    return this.agent.isStopped;
            }
            
            return this.agent.isStopped;
        }
        public void set_EnableMovement(bool value)
        {
            value = value;
            this.agent.isStopped = value;
        }
        public bool get_IsGrounded()
        {
            if(this.agent != null)
            {
                    return this.agent.isOnNavMesh;
            }
            
            return this.agent.isOnNavMesh;
        }
        public void AddPreMovementUpdateHandler(TzarGames.Common.TG_VoidDelegate handler)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
            UnityEngine.Debug.LogException(exception:  0);
        }
        public void HandleRootMotion(UnityEngine.Vector3 deltaPosition, UnityEngine.Quaternion deltaRotation)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        public void Jump()
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        public void LockSpeedOverride(object locker, float speed)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        public void MoveToPosition(UnityEngine.Vector3 position, System.Action<TzarGames.GameFramework.IPathResult> onPathCalculationComplete)
        {
            this.agent.destination = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
            if(this.pathCoroutine != null)
            {
                    this.StopCoroutine(routine:  this.pathCoroutine);
                this.pathCoroutine = 0;
            }
            
            this.pathCoroutine = this.StartCoroutine(routine:  this.pathCalculationCoroutine(callback:  onPathCalculationComplete));
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator pathCalculationCoroutine(System.Action<TzarGames.GameFramework.IPathResult> callback)
        {
            if(null != 0)
            {
                    typeof(NavMeshCharacterMovement.<pathCalculationCoroutine>c__Iterator0).__il2cppRuntimeField_18 = callback;
            }
            else
            {
                    mem[24] = callback;
            }
            
            typeof(NavMeshCharacterMovement.<pathCalculationCoroutine>c__Iterator0).__il2cppRuntimeField_20 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public void NotifyPositionChange(UnityEngine.Vector3 position)
        {
            bool val_1 = this.agent.Warp(newPosition:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
        }
        public void RemovePreMovementUpdateHandler(TzarGames.Common.TG_VoidDelegate handler)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
            UnityEngine.Debug.LogException(exception:  0);
        }
        public void SetPlayerOwner(TzarGames.GameFramework.Player player)
        {
            this.<Owner>k__BackingField = player;
        }
        public void UnlockSpeedOverride(object locker)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        public void ZeroMovement()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.agent.velocity = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            this.agent.angularSpeed = 0f;
        }
        private void Start()
        {
            this.agent.updateRotation = (this.enableRotation == true) ? 1 : 0;
        }
        private void Update()
        {
            if(this.agent.isStopped == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = this.<InputVector>k__BackingField, y = V9.16B, z = V8.16B}, rhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z})) == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.<InputVector>k__BackingField, y = V9.16B, z = this.<InputVector>k__BackingField}, d:  this.agent.speed);
            this.agent.Move(offset:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        }
        public void StopJumping()
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
    
    }

}

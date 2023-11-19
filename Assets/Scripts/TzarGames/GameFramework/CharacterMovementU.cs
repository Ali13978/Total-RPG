using UnityEngine;

namespace TzarGames.GameFramework
{
    [UnityEngine.RequireComponent]
    public class CharacterMovementU : TzarBehaviour, ICharacterMovement, ISerializeView
    {
        // Fields
        [UnityEngine.SerializeField]
        private bool doAdditionalGroundTrace;
        [UnityEngine.SerializeField]
        private float groundCheckRayDistance;
        [UnityEngine.SerializeField]
        private UnityEngine.LayerMask additionalGroundTraceLayer;
        private bool isRayHitGround;
        [UnityEngine.SerializeField]
        private bool sendClientRotation;
        protected UnityEngine.Vector3 Acceleration;
        private UnityEngine.Vector3 velocity;
        public float MaxAcceleration;
        public float BrakingDecelerationWalking;
        private TzarGames.GameFramework.FRotator rotator;
        public uint bWantsToCrouch;
        public uint bForceMaxAccel;
        public float CustomTimeDilation;
        [UnityEngine.SerializeField]
        private UnityEngine.CharacterController character;
        public TzarGames.GameFramework.EMovementMode MovementMode;
        public TzarGames.GameFramework.FFindFloorResult CurrentFloor;
        private TzarGames.GameFramework.UPrimitiveComponent UpdatedComponent;
        private TzarGames.GameFramework.UPrimitiveComponent currentBase;
        private UnityEngine.Vector3 PendingLaunchvelocity;
        public static readonly float MinTimeBetweenTimeStampResets;
        private uint bForceNextFloorCheck;
        private TzarGames.GameFramework.FNetworkPredictionData_Client_Character ClientPredictionData;
        private TzarGames.GameFramework.FNetworkPredictionData_Server_Character ServerPredictionData;
        private TzarGames.GameFramework.CharacterMovementU.NetState[] proxyStates;
        private int proxyStateCount;
        [UnityEngine.SerializeField]
        private bool usePrediction;
        public double interpolationBackTime;
        public double extrapolationLimit;
        private UnityEngine.Vector3 simulatedVelocity;
        private UnityEngine.Vector3 lastPosition;
        private UnityEngine.Vector3 serverCorrectLocation;
        public int serverMoveCallCount;
        public int serverMoveOldCallCount;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.Common.TG_VoidDelegate onPreMovementUpdate;
        private UnityEngine.Transform cachedTransform;
        private UnityEngine.Coroutine clientUpdateRoutine;
        private System.Collections.Generic.List<TzarGames.GameFramework.CharacterMovementU.RootMotionData> rootMovements;
        [UnityEngine.SerializeField]
        private bool enableJumping;
        private bool bWasJumping;
        private float JumpKeyHoldTime;
        [UnityEngine.SerializeField]
        private float JumpMaxHoldTime;
        private int jumpCurrentCount;
        [UnityEngine.SerializeField]
        private int JumpMaxCount;
        private bool bPressedJump;
        private bool bClientUpdating;
        [UnityEngine.SerializeField]
        private float jumpVerticalVelocity;
        [UnityEngine.SerializeField]
        private float gravity;
        [UnityEngine.SerializeField]
        private bool allowControlFalling;
        [UnityEngine.SerializeField]
        private float fallingControlSpeed;
        [UnityEngine.SerializeField]
        private bool syncRotationFromServer;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.CharacterMovementU.RotationSyncMode rotationSyncMode;
        [UnityEngine.SerializeField]
        private float maxSpeed;
        private bool enableMovement;
        private float overrideMaxSpeed;
        private object maxSpeedOverrider;
        private System.Collections.Generic.List<TzarGames.GameFramework.CharacterMovementU.SpeedModifier> speedModifiers;
        private UnityEngine.Vector3 input;
        private int overlappingCollidersCount;
        private UnityEngine.Collider[] overlappingColliders;
        private System.Collections.Generic.List<UnityEngine.Collider> ignoredColliders;
        private uint bMaintainHorizontalGroundvelocity;
        [UnityEngine.SerializeField]
        private bool bPathFollowingMovementEnabled;
        private UnityEngine.Vector3 PathMovementDirection;
        private readonly float BRAKE_TO_STOP_velocity;
        private bool isMoveTriggerSet;
        private float moveTriggerDistance;
        private float moveTriggerTime;
        private float moveTriggerMinSpeed;
        private System.Action moveTriggerCallback;
        private float currentMoveTriggerDistance;
        private float currentMoveTriggerTime;
        private bool moveTriggerMinSpeedReached;
        private bool ApplyGravity;
        
        // Properties
        public bool UsePrediction { get; }
        public UnityEngine.Transform CachedTransform { get; }
        public int JumpCurrentCount { get; }
        public bool IsMoveTriggerSet { get; }
        public TzarGames.GameFramework.FRotator Rotator { get; }
        public bool SyncRotationFromServer { get; set; }
        public float MaxSpeed { get; set; }
        public bool EnableMovement { get; set; }
        public UnityEngine.Vector3 Velocity { get; }
        public float CurrentMoveSpeed { get; }
        public UnityEngine.Vector3 InputVector { get; set; }
        public float Height { get; }
        public float Radius { get; }
        public bool IsGrounded { get; }
        
        // Methods
        public CharacterMovementU()
        {
            this.groundCheckRayDistance = 0.2f;
            this.MaxAcceleration = 100f;
            this.BrakingDecelerationWalking = 100f;
            mem[1152921511269119600] = 0;
            this.CustomTimeDilation = 1f;
            this.rotator = 0;
            this.MovementMode = 1;
            this.proxyStates = null;
            this.usePrediction = 1;
            this.interpolationBackTime = ;
            this.extrapolationLimit = 0.5;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.simulatedVelocity = val_1;
            mem[1152921511269119732] = val_1.y;
            mem[1152921511269119736] = val_1.z;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.lastPosition = val_2;
            mem[1152921511269119744] = val_2.y;
            mem[1152921511269119748] = val_2.z;
            mem2[0] = 4294967297;
            this.jumpVerticalVelocity = 7f;
            this.overrideMaxSpeed = 4f;
            this.rootMovements = new System.Collections.Generic.List<RootMotionData>();
            this.enableJumping = 1;
            this.JumpMaxCount = 1;
            this.enableMovement = 1;
            this.gravity = 9.8f;
            this.fallingControlSpeed = 4f;
            this.maxSpeed = 4f;
            this.speedModifiers = new System.Collections.Generic.List<SpeedModifier>();
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            mem[1152921511269119896] = val_5.z;
            this.input = val_5;
            mem[1152921511269119892] = val_5.y;
            this.overlappingColliders = null;
            this.ignoredColliders = new System.Collections.Generic.List<UnityEngine.Collider>(capacity:  256);
            this.bMaintainHorizontalGroundvelocity = 1;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            this.PathMovementDirection = val_7;
            mem[1152921511269119932] = val_7.y;
            mem[1152921511269119936] = val_7.z;
            this.BRAKE_TO_STOP_velocity = 0.2f;
            this.ApplyGravity = 1;
        }
        public bool get_UsePrediction()
        {
            return (bool)this.usePrediction;
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
            while(this.onPreMovementUpdate != this.onPreMovementUpdate);
        
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
            while(this.onPreMovementUpdate != this.onPreMovementUpdate);
        
        }
        public UnityEngine.Transform get_CachedTransform()
        {
            return (UnityEngine.Transform)this.cachedTransform;
        }
        public int get_JumpCurrentCount()
        {
            return (int)this.jumpCurrentCount;
        }
        public bool IsJumpPressed()
        {
            return (bool)this.bPressedJump;
        }
        public void Jump()
        {
            this.bPressedJump = true;
            this.JumpKeyHoldTime = 0f;
        }
        public void StopJumping()
        {
            this.bPressedJump = false;
            this.bWasJumping = false;
            this.JumpKeyHoldTime = 0f;
            if(this.MovementMode == 2)
            {
                    return;
            }
            
            this.jumpCurrentCount = 0;
        }
        public void SendClientAdjustment()
        {
            TzarGames.GameFramework.RPCall<A> val_11;
            System.Object[] val_12;
            if(val_1.PendingAdjustment <= 0f)
            {
                    return;
            }
            
            if(true == 1)
            {
                    TzarGames.GameFramework.RPCall<System.Single> val_3 = null;
                val_11 = val_3;
                val_3 = new TzarGames.GameFramework.RPCall<System.Single>(object:  this, method:  public System.Void TzarGames.GameFramework.CharacterMovementU::ClientAckGoodMove(float TimeStamp));
                TzarGames.GameFramework.Player val_4 = this.PlayerOwner;
                val_12 = null;
                typeof(System.Object[]).__il2cppRuntimeField_20 = val_1.PendingAdjustment;
                typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
                this.MyNetworkView.UnreliableRPC<System.Single>(methodDelegate:  val_11, player:  val_4.NetworkPlayer, args:  val_12);
            }
            else
            {
                    TzarGames.GameFramework.NetworkViewBase val_6 = this.MyNetworkView;
                if((TzarGames.Common.FMath.IsZero(vector:  new UnityEngine.Vector3() {x = val_1.PendingAdjustment})) != false)
            {
                    TzarGames.GameFramework.RPCall<System.Single, UnityEngine.Vector3> val_7 = null;
                val_11 = val_7;
                val_7 = new TzarGames.GameFramework.RPCall<System.Single, UnityEngine.Vector3>(object:  this, method:  public System.Void TzarGames.GameFramework.CharacterMovementU::ClientVeryShortAdjustPosition(float TimeStamp, UnityEngine.Vector3 NewLoc));
                TzarGames.GameFramework.Player val_8 = this.PlayerOwner;
                val_12 = null;
                typeof(System.Object[]).__il2cppRuntimeField_20 = val_1.PendingAdjustment;
                typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
                typeof(System.Object[]).__il2cppRuntimeField_28 = System.Object[].__il2cppRuntimeField_namespaze;
                val_6.UnreliableRPC<System.Single, UnityEngine.Vector3>(methodDelegate:  val_11, player:  val_8.NetworkPlayer, args:  val_12);
            }
            else
            {
                    TzarGames.GameFramework.RPCall<System.Single, UnityEngine.Vector3, UnityEngine.Vector3> val_9 = null;
                val_11 = val_9;
                val_9 = new TzarGames.GameFramework.RPCall<System.Single, UnityEngine.Vector3, UnityEngine.Vector3>(object:  this, method:  public System.Void TzarGames.GameFramework.CharacterMovementU::ClientAdjustPosition(float TimeStamp, UnityEngine.Vector3 NewLocation, UnityEngine.Vector3 Newvelocity));
                TzarGames.GameFramework.Player val_10 = this.PlayerOwner;
                val_12 = null;
                typeof(System.Object[]).__il2cppRuntimeField_20 = val_1.PendingAdjustment;
                typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
                typeof(System.Object[]).__il2cppRuntimeField_28 = System.Object[].__il2cppRuntimeField_namespaze;
                typeof(System.Object[]).__il2cppRuntimeField_30 = System.Object[].__il2cppRuntimeField_namespaze;
                val_6.UnreliableRPC<System.Single, UnityEngine.Vector3, UnityEngine.Vector3>(methodDelegate:  val_11, player:  val_10.NetworkPlayer, args:  val_12);
            }
            
            }
            
            if(this.GetPredictionData_Server_Character() != null)
            {
                    val_1.PendingAdjustment = 0;
            }
            else
            {
                    val_1.PendingAdjustment = 0;
            }
            
            mem2[0] = 0;
        }
        private bool IsPlayingRootMotion()
        {
            return false;
        }
        public void ForcePositionUpdate(double DeltaTime)
        {
            if(this.MovementMode == 0)
            {
                    return;
            }
            
            this.CheckJumpInput(DeltaTime:  (float)DeltaTime);
            if((TzarGames.Common.FMath.IsZero(vector:  new UnityEngine.Vector3() {x = this.velocity})) == false)
            {
                goto typeof(TzarGames.GameFramework.CharacterMovementU).__il2cppRuntimeField_350;
            }
        
        }
        public void SmoothCorrection(UnityEngine.Vector3 OldLocation)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        public FNetworkPredictionData_Client GetPredictionData_Client()
        {
            TzarGames.GameFramework.FNetworkPredictionData_Client_Character val_3 = 0;
            if(this.OnClient == false)
            {
                    return (FNetworkPredictionData_Client)val_3;
            }
            
            val_3 = this.ClientPredictionData;
            if(val_3 != null)
            {
                    return (FNetworkPredictionData_Client)val_3;
            }
            
            TzarGames.GameFramework.FNetworkPredictionData_Client_Character val_2 = null;
            val_3 = val_2;
            val_2 = new TzarGames.GameFramework.FNetworkPredictionData_Client_Character();
            this.ClientPredictionData = val_3;
            return (FNetworkPredictionData_Client)val_3;
        }
        public FNetworkPredictionData_Server GetPredictionData_Server()
        {
            TzarGames.GameFramework.FNetworkPredictionData_Server_Character val_3 = 0;
            if(this.OnServer == false)
            {
                    return (FNetworkPredictionData_Server)val_3;
            }
            
            val_3 = this.ServerPredictionData;
            if(val_3 != null)
            {
                    return (FNetworkPredictionData_Server)val_3;
            }
            
            TzarGames.GameFramework.FNetworkPredictionData_Server_Character val_2 = null;
            val_3 = val_2;
            val_2 = new TzarGames.GameFramework.FNetworkPredictionData_Server_Character();
            this.ServerPredictionData = val_3;
            return (FNetworkPredictionData_Server)val_3;
        }
        public bool HasPredictionData_Client()
        {
            return (bool)(this.ClientPredictionData != 0) ? 1 : 0;
        }
        public bool HasPredictionData_Server()
        {
            return (bool)(this.ServerPredictionData != 0) ? 1 : 0;
        }
        public void ResetPredictionData_Client()
        {
            if(this.ClientPredictionData == null)
            {
                    return;
            }
            
            this.ClientPredictionData = 0;
        }
        public void ResetPredictionData_Server()
        {
            if(this.ServerPredictionData == null)
            {
                    return;
            }
            
            this.ServerPredictionData = 0;
        }
        private void check(object obj)
        {
        
        }
        private bool IsValid(object obj)
        {
            return true;
        }
        public virtual void PerformMovement(float deltaSeconds)
        {
            float val_7;
            float val_8;
            float val_9;
            float val_10;
            float val_11;
            float val_12;
            float val_13;
            float val_22;
            float val_26;
            float val_27;
            float val_28;
            float val_29;
            UnityEngine.CharacterController val_30;
            float val_34;
            float val_38;
            bool val_39;
            val_22 = deltaSeconds;
            if(this.doAdditionalGroundTrace != false)
            {
                    this.traceGround();
            }
            
            if(this.onPreMovementUpdate != null)
            {
                    this.onPreMovementUpdate.Invoke();
            }
            
            if(this.MovementMode == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_1 = this.cachedTransform.position;
            val_26 = val_1.x;
            val_27 = val_1.y;
            val_28 = val_1.z;
            val_29 = val_1.x;
            if(System.Math.Abs(val_29) > 0.0001f)
            {
                    if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    this.velocity = this.PendingLaunchvelocity;
                mem[1152921511271808400] = typeof(TzarGames.GameFramework.CharacterMovementU).__il2cppRuntimeField_360;
                mem[1152921511271808404] = ???;
                this.MovementMode = 2;
                this.OnMovementModeChanged(PreviousMovementMode:  this.UpdatedComponent);
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
                this.PendingLaunchvelocity = val_3;
                mem[1152921511271808500] = val_3.y;
                mem[1152921511271808504] = val_3.z;
            }
            
            }
            
            int val_4 = this.rootMovements.Count;
            if(val_4 >= 1)
            {
                    val_30 = this.character;
                if(val_30.enabled != false)
            {
                    val_30 = val_4 - 1;
                if(val_4 >= 1)
            {
                    var val_21 = 0;
                do
            {
                RootMotionData val_6 = this.rootMovements.Item[0];
                UnityEngine.CollisionFlags val_14 = this.character.Move(motion:  new UnityEngine.Vector3() {x = val_7, y = val_8, z = val_9});
                UnityEngine.Quaternion val_15 = this.cachedTransform.rotation;
                UnityEngine.Quaternion val_16 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_15.x, y = val_15.y, z = val_15.z, w = val_15.w}, rhs:  new UnityEngine.Quaternion() {x = val_10, y = val_11, z = val_12, w = val_13});
                val_29 = val_16.x;
                val_34 = val_16.z;
                this.cachedTransform.rotation = new UnityEngine.Quaternion() {x = val_29, y = val_16.y, z = val_34, w = val_16.w};
                val_21 = val_21 + 1;
            }
            while(val_4 != val_21);
            
            }
            
                RootMotionData val_17 = this.rootMovements.Item[val_30];
                val_27 = val_27;
                UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.velocity, y = val_11, z = val_12}, b:  new UnityEngine.Vector3() {x = val_7, y = val_8, z = val_9});
                this.velocity = val_18;
                mem[1152921511271808400] = val_18.y;
                mem[1152921511271808404] = val_18.z;
                val_38 = val_26;
                val_22 = val_22;
                val_28 = val_28;
            }
            
                this.rootMovements.Clear();
            }
            
            if((this.bPressedJump != false) && (this.JumpKeyHoldTime >= this.JumpMaxHoldTime))
            {
                    this.bPressedJump = false;
            }
            
            this.StartNewPhysics(deltaTime:  val_22, Iterations:  0);
            if(this.MovementMode == 2)
            {
                    val_39 = 1;
            }
            else
            {
                    val_39 = this.IsGrounded;
            }
            
            this.ApplyGravity = val_39;
            if(this.isMoveTriggerSet == false)
            {
                    return;
            }
            
            this.updateMoveTrigger(deltaSeconds:  val_22, oldLocation:  new UnityEngine.Vector3() {x = val_38, y = val_27, z = val_28});
        }
        private void updateMoveTrigger(float deltaSeconds, UnityEngine.Vector3 oldLocation)
        {
            float val_3 = this.currentMoveTriggerTime;
            val_3 = val_3 + deltaSeconds;
            this.currentMoveTriggerTime = val_3;
            if(val_3 >= this.moveTriggerTime)
            {
                goto label_1;
            }
            
            if(this.moveTriggerMinSpeedReached == false)
            {
                goto label_2;
            }
            
            if(val_3 >= 0)
            {
                goto label_6;
            }
            
            this.isMoveTriggerSet = false;
            if(this.moveTriggerCallback == null)
            {
                goto label_6;
            }
            
            this.moveTriggerCallback.Invoke();
            this.moveTriggerCallback = 0;
            goto label_6;
            label_2:
            if(val_3 >= this.moveTriggerMinSpeed)
            {
                    this.moveTriggerMinSpeedReached = true;
            }
            
            label_6:
            if(this.isMoveTriggerSet == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_1 = this.cachedTransform.position;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = oldLocation.x, y = oldLocation.y, z = oldLocation.z});
            val_2.x = this.currentMoveTriggerDistance + val_2.x;
            this.currentMoveTriggerDistance = val_2.x;
            if(val_2.x < this.moveTriggerDistance)
            {
                    return;
            }
            
            label_1:
            this.isMoveTriggerSet = false;
            if(this.moveTriggerCallback == null)
            {
                    return;
            }
            
            this.moveTriggerCallback.Invoke();
            this.moveTriggerCallback = 0;
        }
        private bool IsFalling()
        {
            return (bool)(this.MovementMode == 2) ? 1 : 0;
        }
        private bool test_isGrounded()
        {
            UnityEngine.Vector3 val_1 = this.cachedTransform.position;
            UnityEngine.Vector3 val_2 = this.character.center;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.down;
            float val_19 = 0.5f;
            val_19 = this.character.height * val_19;
            val_19 = val_19 - this.character.radius;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  val_19 + this.character.skinWidth);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            UnityEngine.Color val_13 = UnityEngine.Color.red;
            UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, end:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, color:  new UnityEngine.Color() {r = val_13.r, g = val_13.b, a = val_10.z});
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.down;
            int val_17 = UnityEngine.LayerMask.NameToLayer(layerName:  0);
            return UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, direction:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, maxDistance:  this.character.radius + this.character.skinWidth, layerMask:  0);
        }
        public virtual void UpdateBasedMovement(float DeltaSeconds)
        {
        
        }
        private void StartNewPhysics(float deltaTime, int Iterations)
        {
            UnityEngine.Object val_9;
            if(deltaTime < 0)
            {
                    return;
            }
            
            if(Iterations > 7)
            {
                    return;
            }
            
            val_9 = this.UpdatedComponent;
            if(0 != val_9)
            {
                    val_9 = 0;
                if(this.UpdatedComponent.IsSimulatingPhysics() != false)
            {
                    UnityEngine.Debug.Log(message:  0);
                return;
            }
            
            }
            
            TzarGames.GameFramework.EMovementMode val_9 = this.MovementMode;
            val_9 = (val_9 < 6) ? (val_9 + 10) : 0;
            if(val_9 > 12)
            {
                goto label_10;
            }
            
            if(val_9 == 0)
            {
                goto label_11;
            }
            
            if(val_9 == 11)
            {
                goto label_12;
            }
            
            if(val_9 != 12)
            {
                    return;
            }
            
            this.PhysFalling(deltaTime:  deltaTime);
            goto label_21;
            label_10:
            val_9 = val_9 - 13;
            if(val_9 < 3)
            {
                goto label_21;
            }
            
            return;
            label_11:
            val_9 = 0 + this.gameObject.name;
            UnityEngine.Debug.Log(message:  0);
            this.MovementMode = 0;
            this.OnMovementModeChanged(PreviousMovementMode:  val_9);
            goto label_21;
            label_12:
            this.PhysWalking(deltaTime:  deltaTime, iterations:  val_9);
            label_21:
            this.MovementMode = ((this.IsGrounded & true) != 0) ? (1 + 1) : 1;
            this.OnMovementModeChanged(PreviousMovementMode:  val_9);
        }
        private void PhysWalking(float deltaTime, int iterations)
        {
            float val_9;
            float val_10;
            float val_11;
            float val_12;
            float val_13;
            float val_14;
            this.MaintainHorizontalGroundvelocity();
            val_9 = this.BrakingDecelerationWalking;
            val_10 = 0.18f;
            val_11 = deltaTime;
            mem[1152921511272710196] = 0;
            this.Calcvelocity(DeltaTime:  val_11, Friction:  val_10, bFluid:  false, BrakingDeceleration:  val_9);
            UnityEngine.Vector3 val_1 = this.cachedTransform.position;
            if(this.character.enabled != false)
            {
                    if(System.Math.Abs(S12) > 0.0001f)
            {
                
            }
            else
            {
                    val_12 = -0.1f;
                mem[1152921511272710208] = -1110651699;
            }
            
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.velocity, y = val_12, z = V13.16B}, d:  deltaTime);
                val_13 = val_3.x;
                val_14 = val_3.z;
                val_11 = val_13;
                val_10 = val_3.y;
                val_9 = val_14;
                UnityEngine.CollisionFlags val_4 = this.character.Move(motion:  new UnityEngine.Vector3() {x = val_11, y = val_10, z = val_9});
            }
            
            if(this.character.collisionFlags == 0)
            {
                    return;
            }
            
            this.MaintainHorizontalGroundvelocity();
            UnityEngine.Vector3 val_6 = this.cachedTransform.position;
            val_13 = val_6.x;
            val_14 = val_6.z;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_13, y = val_6.y, z = val_14}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  deltaTime);
            this.velocity = val_8;
            mem[1152921511272710208] = val_8.y;
            mem[1152921511272710212] = val_8.z;
        }
        private void PreCharacterControllerUpdate()
        {
            UnityEngine.CharacterController val_13 = this.character;
            UnityEngine.Vector3 val_1 = val_13.center;
            UnityEngine.Vector3 val_2 = this.cachedTransform.TransformPoint(position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
            float val_13 = 0.5f;
            val_13 = this.character.height * val_13;
            val_13 = val_13 - this.character.radius;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(d:  val_13, a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            int val_10 = UnityEngine.Physics.OverlapCapsuleNonAlloc(point0:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, point1:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, radius:  this.character.radius, results:  0);
            this.overlappingCollidersCount = val_10;
            if(val_10 < 1)
            {
                    return;
            }
            
            var val_15 = 0;
            do
            {
                UnityEngine.Collider val_14 = this.overlappingColliders[0];
                val_13 = val_14.gameObject;
                this.overlappingColliders[0] = val_13.isStatic;
                if(this.overlappingColliders[0] != true)
            {
                    val_13 = this.ignoredColliders;
                val_13.Add(item:  val_14);
                UnityEngine.Physics.IgnoreCollision(collider1:  0, collider2:  this.character, ignore:  val_14);
            }
            
                val_15 = val_15 + 1;
            }
            while(val_15 < this.overlappingCollidersCount);
        
        }
        private void PostCharacterControllerUpdate()
        {
            goto label_1;
            label_4:
            UnityEngine.Physics.IgnoreCollision(collider1:  0, collider2:  this.character, ignore:  X21.Item[0]);
            0 = 1;
            label_1:
            if(0 < this.ignoredColliders.Count)
            {
                goto label_4;
            }
            
            this.ignoredColliders.Clear();
        }
        private void PhysFalling(float deltaTime)
        {
            UnityEngine.Vector3 val_14;
            float val_15;
            float val_16;
            if(this.allowControlFalling != false)
            {
                    float val_12 = this.fallingControlSpeed;
                val_14 = this.input * val_12;
                val_12 = val_12 * S2;
                val_15 = this.gravity * deltaTime;
                mem[1152921511273349316] = val_12;
                val_16 = S4 - val_15;
                this.velocity = val_14;
                mem[1152921511273349312] = val_16;
            }
            else
            {
                    UnityEngine.Vector3 val_1 = UnityEngine.Vector3.down;
                UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  this.gravity);
                this.Acceleration = val_2;
                mem[1152921511273349300] = val_2.y;
                mem[1152921511273349304] = val_2.z;
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  deltaTime);
                val_16 = this.velocity;
                val_14 = V10.16B;
                val_15 = V11.16B;
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_16, y = val_14, z = val_15}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
                this.velocity = val_4;
                mem[1152921511273349312] = val_4.y;
                mem[1152921511273349316] = val_4.z;
            }
            
            UnityEngine.Vector3 val_5 = this.cachedTransform.position;
            if(this.character.enabled != false)
            {
                    UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.velocity, y = V13.16B, z = V12.16B}, d:  deltaTime);
                val_16 = val_7.x;
                val_14 = val_7.y;
                val_15 = val_7.z;
                UnityEngine.CollisionFlags val_8 = this.character.Move(motion:  new UnityEngine.Vector3() {x = val_16, y = val_14, z = val_15});
            }
            
            UnityEngine.Vector3 val_9 = this.cachedTransform.position;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  deltaTime);
            this.velocity = val_11;
            mem[1152921511273349312] = val_11.y;
            mem[1152921511273349316] = val_11.z;
        }
        public void MaintainHorizontalGroundvelocity()
        {
            if(S1 == 0f)
            {
                    return;
            }
            
            if(this.bMaintainHorizontalGroundvelocity != 0)
            {
                    mem[1152921511273481792] = 0;
                return;
            }
            
            UnityEngine.Vector3 val_1 = TzarGames.Common.FMath.SafeNormal2D(src:  new UnityEngine.Vector3() {x = this.velocity}, Tolerance:  1E-08f);
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  val_1.x);
            this.velocity = val_2;
            mem[1152921511273481792] = val_2.y;
            mem[1152921511273481796] = val_2.z;
        }
        public float GetModifiedMaxAcceleration()
        {
            return (float)this.MaxAcceleration;
        }
        public float GetModifiedMaxSpeed()
        {
            float val_2 = this.GetSpeedModifiersTotal();
            val_2 = ((this.maxSpeedOverrider == 0) ? this.maxSpeed : this.overrideMaxSpeed) + val_2;
            return (float)val_2;
        }
        public float GetSpeedModifiersTotal()
        {
            var val_3;
            float val_4;
            val_3 = 0;
            val_4 = 0f;
            goto label_1;
            label_5:
            SpeedModifier val_1 = X21.Item[0];
            val_4 = val_4 + val_1.speed;
            val_3 = 1;
            label_1:
            if(val_3 >= this.speedModifiers.Count)
            {
                    return (float)val_4;
            }
            
            if(this.speedModifiers != null)
            {
                goto label_5;
            }
            
            goto label_5;
        }
        private bool ProcessPathFollowingMovement(ref UnityEngine.Vector3 Newvelocity, ref UnityEngine.Vector3 NewAcceleration, float deltaTime, float maxAccel, float maxSpeed)
        {
            float val_5;
            var val_6;
            val_5 = deltaTime;
            if(this.bPathFollowingMovementEnabled == false)
            {
                goto label_1;
            }
            
            mem[1152921511273964976] = ???;
            this.PathMovementDirection = this.input;
            mem[1152921511273964972] = ???;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.input, y = W9, z = V9.16B}, d:  this.maxSpeed);
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  val_5);
            NewAcceleration.x = val_2.x;
            NewAcceleration.y = val_2.y;
            NewAcceleration.z = val_2.z;
            if(val_2.x <= (maxAccel * maxAccel))
            {
                    if(this.bForceMaxAccel != 1)
            {
                goto label_5;
            }
            
            }
            
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.PathMovementDirection, y = this.input, z = val_5}, d:  maxAccel);
            NewAcceleration.x = val_4.x;
            NewAcceleration.y = val_4.y;
            NewAcceleration.z = val_4.z;
            label_5:
            val_6 = 1;
            Newvelocity.x = val_1.x;
            Newvelocity.y = val_1.y;
            Newvelocity.z = val_1.z;
            return (bool)val_6;
            label_1:
            val_6 = 0;
            return (bool)val_6;
        }
        public void Calcvelocity(float DeltaTime, float Friction, bool bFluid, float BrakingDeceleration)
        {
            float val_31;
            float val_32;
            float val_33;
            float val_34;
            float val_36;
            float val_37;
            float val_38;
            float val_39;
            float val_40;
            float val_43;
            float val_48;
            float val_49;
            float val_50;
            UnityEngine.Vector3 val_57;
            UnityEngine.Vector3 val_58;
            val_31 = BrakingDeceleration;
            val_32 = this.MaxAcceleration;
            val_33 = mem[this.maxSpeedOverrider == null ? this.maxSpeed : this.overrideMaxSpeed];
            val_33 = (this.maxSpeedOverrider == 0) ? this.maxSpeed : this.overrideMaxSpeed;
            val_34 = UnityEngine.Mathf.Max(a:  0f, b:  Friction);
            val_36 = this.GetSpeedModifiersTotal();
            val_37 = DeltaTime;
            val_38 = val_32;
            if((this.ProcessPathFollowingMovement(Newvelocity: ref  new UnityEngine.Vector3() {x = this.velocity, y = this.velocity, z = this.velocity}, NewAcceleration: ref  new UnityEngine.Vector3() {x = this.Acceleration, y = this.Acceleration, z = this.Acceleration}, deltaTime:  val_37, maxAccel:  val_38, maxSpeed:  BrakingDeceleration)) == true)
            {
                    return;
            }
            
            val_39 = val_33 + val_36;
            if(this.bForceMaxAccel != 0)
            {
                    if(val_37 > (1E-08f))
            {
                    val_36 = val_34;
                UnityEngine.Vector3 val_6 = TzarGames.Common.FMath.SafeNormalPrecise(V:  new UnityEngine.Vector3() {x = this.Acceleration, y = val_38, z = BrakingDeceleration});
                val_40 = val_6.y;
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_40, z = val_6.z}, d:  val_32);
                this.Acceleration = val_7;
                mem[1152921511274092980] = val_7.y;
                mem[1152921511274092984] = val_7.z;
                val_43 = val_36;
            }
            else
            {
                    if(val_37 < 0)
            {
                    UnityEngine.Vector3 val_8 = this.cachedTransform.forward;
            }
            else
            {
                    val_37 = this.velocity;
                UnityEngine.Vector3 val_9 = TzarGames.Common.FMath.SafeNormalPrecise(V:  new UnityEngine.Vector3() {x = val_37, y = val_38, z = BrakingDeceleration});
            }
            
                val_40 = val_9.x;
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(d:  val_32, a:  new UnityEngine.Vector3() {x = val_40, y = val_9.y, z = val_9.z});
                val_36 = val_10.x;
                val_48 = val_10.z;
                this.Acceleration = val_10;
                mem[1152921511274092980] = val_10.y;
                mem[1152921511274092984] = val_48;
                val_43 = val_34;
                val_39 = val_39;
            }
            
            }
            
            bool val_11 = this.IsExceedingMaxSpeed(MaxSpeed:  val_39);
            if((val_11 != true) && ((TzarGames.Common.FMath.IsZero(vector:  new UnityEngine.Vector3() {x = this.Acceleration, y = val_10.y, z = val_10.z})) != true))
            {
                    UnityEngine.Vector3 val_14 = TzarGames.Common.FMath.SafeNormalPrecise(V:  new UnityEngine.Vector3() {x = this.Acceleration, y = val_10.y, z = val_10.z});
                val_36 = val_14.x;
                UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  val_36);
                UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.velocity, y = val_48, z = val_31}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
                UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, d:  DeltaTime);
                val_43 = val_43;
                UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, d:  val_43);
                UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.velocity, y = val_48, z = val_31}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
                this.velocity = val_19;
                mem[1152921511274092992] = val_19.y;
                val_39 = val_39;
                mem[1152921511274092996] = val_19.z;
            }
            else
            {
                    this.ApplyvelocityBraking(DeltaTime:  DeltaTime, Friction:  val_43, BrakingDeceleration:  val_31);
                if(val_11 != false)
            {
                    val_36 = val_39 * val_39;
                if(DeltaTime < 0)
            {
                    UnityEngine.Vector3 val_20 = TzarGames.Common.FMath.SafeNormalPrecise(V:  new UnityEngine.Vector3() {x = this.velocity, y = val_48, z = val_9.x});
                val_49 = val_20.x;
                val_31 = val_20.y;
                val_50 = val_20.z;
                UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_49, y = val_31, z = val_50}, d:  val_39);
                this.velocity = val_21;
                mem[1152921511274092992] = val_21.y;
                mem[1152921511274092996] = val_21.z;
            }
            
            }
            
            }
            
            if(bFluid != false)
            {
                    val_50 = this.velocity;
                UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_50, y = val_31, z = val_49}, d:  1f - (val_43 * DeltaTime));
                this.velocity = val_24;
                mem[1152921511274092992] = val_24.y;
                mem[1152921511274092996] = val_24.z;
            }
            
            if((this.IsExceedingMaxSpeed(MaxSpeed:  val_39)) != false)
            {
                    val_39 = val_39;
            }
            
            val_57 = this.velocity;
            val_58 = this.Acceleration;
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_58, y = val_36, z = val_9.x}, d:  DeltaTime);
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_57, y = val_31, z = val_49}, b:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
            this.velocity = val_27;
            mem[1152921511274092992] = val_27.y;
            mem[1152921511274092996] = val_27.z;
            UnityEngine.Vector3 val_28 = TzarGames.Common.FMath.ClampMaxSizePrecise(V:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, MaxSize:  val_39);
            this.velocity = val_28;
            mem[1152921511274092992] = val_28.y;
            mem[1152921511274092996] = val_28.z;
        }
        public bool HasRootMotion()
        {
            return false;
        }
        public void ApplyvelocityBraking(float DeltaTime, float Friction, float BrakingDeceleration)
        {
            float val_16;
            float val_17;
            float val_18;
            float val_19;
            float val_20;
            float val_21;
            UnityEngine.Vector3 val_25;
            val_16 = BrakingDeceleration;
            val_17 = Friction;
            if((TzarGames.Common.FMath.IsZero(vector:  new UnityEngine.Vector3() {x = this.velocity, y = Friction, z = BrakingDeceleration})) == true)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            val_18 = val_3.x;
            val_19 = val_3.y;
            val_20 = val_3.z;
            UnityEngine.Vector3 val_4 = TzarGames.Common.FMath.SafeNormalPrecise(V:  new UnityEngine.Vector3() {x = this.velocity, y = val_3.y, z = V3.16B});
            val_21 = val_4.x;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(d:  -val_16, a:  new UnityEngine.Vector3() {x = val_21, y = val_4.y, z = val_4.z});
            if(DeltaTime <= 0f)
            {
                goto label_7;
            }
            
            float val_16 = -2f;
            val_16 = val_17 * val_16;
            val_17 = DeltaTime;
            label_10:
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(d:  val_16, a:  new UnityEngine.Vector3() {x = this.velocity, y = val_16, z = V15.16B});
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  V11.16B);
            val_21 = val_16;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.velocity, y = val_21, z = V15.16B}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            this.velocity = val_9;
            mem[1152921511274325184] = val_9.y;
            mem[1152921511274325188] = val_9.z;
            if((UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, rhs:  new UnityEngine.Vector3() {x = this.velocity, y = this.velocity, z = this.velocity})) <= 0f)
            {
                goto label_7;
            }
            
            val_17 = val_17 - S11;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(d:  V11.16B, a:  new UnityEngine.Vector3() {x = this.velocity, y = this.velocity, z = val_16});
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  DeltaTime);
            val_21 = val_19;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_18, y = val_21, z = val_20}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            val_18 = val_13.x;
            val_19 = val_13.y;
            val_20 = val_13.z;
            if(val_17 > 0f)
            {
                goto label_10;
            }
            
            label_7:
            this.velocity = val_13;
            mem[1152921511274325184] = val_19;
            mem[1152921511274325188] = val_20;
            val_25 = this.velocity;
            float val_14 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = this.velocity, y = val_25, z = this.velocity}, rhs:  new UnityEngine.Vector3() {x = val_18, y = val_19, z = val_20});
            if(val_14 >= 0)
            {
                    val_25 = this.BRAKE_TO_STOP_velocity * this.BRAKE_TO_STOP_velocity;
                if(val_14 > val_25)
            {
                    return;
            }
            
            }
            
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.zero;
            this.velocity = val_15;
            mem[1152921511274325184] = val_15.y;
            mem[1152921511274325188] = val_15.z;
        }
        public bool IsExceedingMaxSpeed(float MaxSpeed)
        {
            float val_3 = MaxSpeed;
            float val_1 = UnityEngine.Mathf.Max(a:  0f, b:  val_3);
            val_3 = val_1 * val_1;
            float val_4 = 1.01f;
            val_4 = val_3 * val_4;
            return (bool)(val_1 > val_4) ? 1 : 0;
        }
        public void SetMoveTrigger(float distance, float time, float minSpeed, System.Action completeCallback)
        {
            if(this.isMoveTriggerSet == true)
            {
                    return;
            }
            
            this.moveTriggerMinSpeedReached = false;
            this.currentMoveTriggerDistance = 0f;
            this.currentMoveTriggerTime = 0f;
            this.moveTriggerTime = time;
            this.moveTriggerMinSpeed = minSpeed;
            this.moveTriggerDistance = distance;
            this.moveTriggerCallback = completeCallback;
            this.isMoveTriggerSet = true;
        }
        public bool get_IsMoveTriggerSet()
        {
            return (bool)this.isMoveTriggerSet;
        }
        public void CancelMoveTrigger()
        {
            this.isMoveTriggerSet = false;
            this.moveTriggerCallback = 0;
        }
        private void finishMoveTrigger()
        {
            this.isMoveTriggerSet = false;
            if(this.moveTriggerCallback == null)
            {
                    return;
            }
            
            this.moveTriggerCallback.Invoke();
            this.moveTriggerCallback = 0;
        }
        public virtual void FindFloor(UnityEngine.Vector3 CapsuleLocation, ref TzarGames.GameFramework.FFindFloorResult OutFloorResult, bool bZeroDelta, TzarGames.GameFramework.HitResult DownwardSweepResult)
        {
        
        }
        private TzarGames.GameFramework.FNetworkPredictionData_Server_Character GetPredictionData_Server_Character()
        {
            var val_3;
            FNetworkPredictionData_Server val_1 = this.GetPredictionData_Server();
            val_3 = 0;
            return (TzarGames.GameFramework.FNetworkPredictionData_Server_Character);
        }
        public TzarGames.GameFramework.FNetworkPredictionData_Client_Character GetPredictionData_Client_Character()
        {
            var val_4;
            FNetworkPredictionData_Client val_1 = this.GetPredictionData_Client();
            val_4 = 0;
            return (TzarGames.GameFramework.FNetworkPredictionData_Client_Character)val_4;
        }
        private bool IsComponentTickEnabled()
        {
            return this.enabled;
        }
        public void SetBase(TzarGames.GameFramework.UPrimitiveComponent NewBase, bool bNotifyActor = True)
        {
            this.currentBase = NewBase;
        }
        [TzarRPC]
        public void ClientAckGoodMove(float TimeStamp)
        {
            int val_6 = this;
            if(this.enabled == false)
            {
                    return;
            }
            
            TzarGames.GameFramework.FNetworkPredictionData_Client_Character val_2 = this.GetPredictionData_Client_Character();
            if(val_2 == null)
            {
                    return;
            }
            
            val_6 = val_2.GetSavedMoveIndex(TimeStamp:  TimeStamp);
            if(val_6 == TzarGames.Common.FMath.INDEX_NONE)
            {
                    if(val_2.LastAckedMove == null)
            {
                    return;
            }
            
                typeof(System.Object[]).__il2cppRuntimeField_20 = "ClientAckGoodMove_Implementation could not find Move for TimeStamp: ";
                typeof(System.Object[]).__il2cppRuntimeField_28 = TimeStamp;
                typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
                typeof(System.Object[]).__il2cppRuntimeField_30 = "LastAckedTimeStamp: ";
                typeof(System.Object[]).__il2cppRuntimeField_38 = val_2.LastAckedMove.TimeStamp;
                typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
                typeof(System.Object[]).__il2cppRuntimeField_40 = "CurrentTimeStamp: ";
                typeof(System.Object[]).__il2cppRuntimeField_48 = val_2.CurrentTimeStamp;
                typeof(System.Object[]).__il2cppRuntimeField_4C = 268435457;
                val_6 = +0;
                UnityEngine.Debug.Log(message:  0);
                return;
            }
            
            val_2.AckMove(AckedMoveIndex:  val_6);
        }
        public bool IsInWater()
        {
            return false;
        }
        public void SetMovementMode(TzarGames.GameFramework.EMovementMode NewMovementMode)
        {
            this.MovementMode = NewMovementMode;
            this.OnMovementModeChanged(PreviousMovementMode:  NewMovementMode);
        }
        private void OnMovementModeChanged(TzarGames.GameFramework.EMovementMode PreviousMovementMode)
        {
            var val_3;
            TzarGames.GameFramework.EMovementMode val_4;
            if(this.bPressedJump == false)
            {
                goto label_1;
            }
            
            val_3 = this;
            val_4 = this.MovementMode;
            goto label_2;
            label_1:
            this.JumpKeyHoldTime = 0f;
            val_3 = this;
            this.bWasJumping = false;
            val_4 = this.MovementMode;
            if(val_4 == 2)
            {
                goto label_4;
            }
            
            this.jumpCurrentCount = 0;
            label_2:
            if(val_4 == 2)
            {
                goto label_4;
            }
            
            if(val_4 != 1)
            {
                goto label_5;
            }
            
            mem[1152921511276028688] = 0;
            return;
            label_4:
            UnityEngine.Vector3 val_1 = this.GetImpartedMovementBaseVelocity();
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.velocity, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            this.velocity = val_2;
            mem[1152921511276028688] = val_2.y;
            mem[1152921511276028692] = val_2.z;
            val_4 = val_4;
            label_5:
            if(val_4 != 0)
            {
                    return;
            }
            
            if(this.bPressedJump == false)
            {
                    return;
            }
            
            if(this.JumpKeyHoldTime < this.JumpMaxHoldTime)
            {
                    return;
            }
            
            this.bPressedJump = false;
        }
        private UnityEngine.Vector3 GetImpartedMovementBaseVelocity()
        {
            return UnityEngine.Vector3.zero;
        }
        [TzarRPC]
        public void ClientAdjustPosition(float TimeStamp, UnityEngine.Vector3 NewLocation, UnityEngine.Vector3 Newvelocity)
        {
            var val_13;
            var val_14;
            UnityEngine.Vector3 val_15;
            val_13 = this;
            val_14 = 1152921505024093152;
            typeof(System.Object[]).__il2cppRuntimeField_20 = TimeStamp;
            typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
            UnityEngine.Vector3 val_1 = this.cachedTransform.position;
            typeof(System.Object[]).__il2cppRuntimeField_28 = val_1;
            typeof(System.Object[]).__il2cppRuntimeField_30 = TzarGames.GameFramework.GlobalUtility.LogVector3(vec:  new UnityEngine.Vector3() {x = NewLocation.x, y = NewLocation.y, z = NewLocation.z});
            UnityEngine.Vector3 val_3 = this.cachedTransform.position;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = NewLocation.x, y = NewLocation.y, z = NewLocation.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            typeof(System.Object[]).__il2cppRuntimeField_38 = val_4.x;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            val_15 = Newvelocity;
            typeof(System.Object[]).__il2cppRuntimeField_40 = val_15;
            string val_5 = System.String.Format(format:  0, args:  "ClientAdjustPosition. TimeStamp: {0}, Old Pos: {1}, New Pos: ({2}), Difference: {3}, Velocity: {4}");
            UnityEngine.Debug.Log(message:  0);
            if(this.enabled == false)
            {
                    return;
            }
            
            TzarGames.GameFramework.FNetworkPredictionData_Client_Character val_7 = this.GetPredictionData_Client_Character();
            if(val_7 == null)
            {
                    return;
            }
            
            val_15 = val_7.GetSavedMoveIndex(TimeStamp:  TimeStamp);
            if(val_15 == TzarGames.Common.FMath.INDEX_NONE)
            {
                    if(val_7.LastAckedMove == null)
            {
                    return;
            }
            
                typeof(System.Object[]).__il2cppRuntimeField_20 = "ClientAdjustPosition could not find Move for TimeStamp: %f, LastAckedTimeStamp: %f, CurrentTimeStamp: %f";
                typeof(System.Object[]).__il2cppRuntimeField_28 = TimeStamp;
                typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
                val_14 = "  ";
                typeof(System.Object[]).__il2cppRuntimeField_30 = "  ";
                typeof(System.Object[]).__il2cppRuntimeField_38 = val_7.LastAckedMove.TimeStamp;
                typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
                val_15 = "  ";
                typeof(System.Object[]).__il2cppRuntimeField_40 = val_15;
                typeof(System.Object[]).__il2cppRuntimeField_48 = val_7.CurrentTimeStamp;
                typeof(System.Object[]).__il2cppRuntimeField_4C = 268435457;
                val_13 = +0;
                UnityEngine.Debug.LogWarning(message:  0);
                return;
            }
            
            val_7.AckMove(AckedMoveIndex:  val_15);
            this.serverCorrectLocation = NewLocation;
            mem[1152921511276341500] = NewLocation.y;
            mem[1152921511276341504] = NewLocation.z;
            this.velocity = Newvelocity;
            mem[1152921511276341312] = Newvelocity.y;
            mem[1152921511276341316] = Newvelocity.z;
            if(this.clientUpdateRoutine != null)
            {
                    return;
            }
            
            this.clientUpdateRoutine = this.StartCoroutine(routine:  this.clientUpdatePositionRoutine());
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator clientUpdatePositionRoutine()
        {
            typeof(CharacterMovementU.<clientUpdatePositionRoutine>c__Iterator0).__il2cppRuntimeField_18 = this;
            return (System.Collections.IEnumerator)new CharacterMovementU.<clientUpdatePositionRoutine>c__Iterator0();
        }
        [TzarRPC]
        public void ClientVeryShortAdjustPosition(float TimeStamp, UnityEngine.Vector3 NewLoc)
        {
            UnityEngine.Debug.Log(message:  0);
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.ClientAdjustPosition(TimeStamp:  TimeStamp, NewLocation:  new UnityEngine.Vector3() {x = NewLoc.x, y = NewLoc.y, z = NewLoc.z}, Newvelocity:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
        [TzarRPC]
        public void ServerMove_NoRot(float TimeStamp, UnityEngine.Vector3 InAccel, UnityEngine.Vector3 ClientLoc, byte moveFlags)
        {
            UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
            this.ServerMove(TimeStamp:  TimeStamp, InAccel:  new UnityEngine.Vector3() {x = InAccel.x, y = InAccel.y, z = InAccel.z}, ClientLoc:  new UnityEngine.Vector3() {x = ClientLoc.x, y = ClientLoc.y, z = ClientLoc.z}, MoveFlags:  moveFlags, ViewRotationFromClient:  new UnityEngine.Quaternion() {x = val_1.x, y = val_1.z, z = ???, w = ???});
        }
        [TzarRPC]
        public void ServerMove(float TimeStamp, UnityEngine.Vector3 InAccel, UnityEngine.Vector3 ClientLoc, byte MoveFlags, UnityEngine.Quaternion ViewRotationFromClient)
        {
            float val_6;
            float val_7;
            float val_8;
            float val_9;
            float val_10;
            TzarGames.GameFramework.FNetworkPredictionData_Server_Character val_11;
            float val_12;
            float val_13;
            float val_14;
            val_8 = ClientLoc.z;
            val_9 = InAccel.z;
            val_10 = InAccel.x;
            TzarGames.GameFramework.FNetworkPredictionData_Server_Character val_1 = this.GetPredictionData_Server_Character();
            val_11 = val_1;
            if((val_1.VerifyClientTimeStamp(TimeStamp:  TimeStamp, ServerData:  val_11)) == false)
            {
                    return;
            }
            
            val_12 = this.CustomTimeDilation;
            val_1.CurrentClientTimeStamp = TimeStamp;
            val_9 = (val_11.GetServerMoveDeltaTime(TimeStamp:  TimeStamp)) * val_12;
            mem2[0] = TzarGames.GameFramework.GameManagerNetSyncBase.NetworkTime;
            if(val_9 > 0f)
            {
                    val_13 = 0.0001f;
                val_14 = System.Math.Abs(UnityEngine.Time.timeScale);
                if(val_14 > val_13)
            {
                    if(this.sendClientRotation != false)
            {
                    val_10 = ViewRotationFromClient.y;
                val_12 = ViewRotationFromClient.x;
                val_11 = this.cachedTransform;
                val_13 = val_12;
                val_14 = val_7;
                val_11.rotation = new UnityEngine.Quaternion() {x = val_13, y = val_14, z = val_10, w = val_6};
                val_8 = val_8;
            }
            
                mem[1152921511276873736] = val_10;
                this.input = val_13;
                mem[1152921511276873732] = val_14;
                this.MoveAutonomous(ClientTimeStamp:  val_13, DeltaTime:  val_9, CompressedFlags:  MoveFlags, NewAccel:  new UnityEngine.Vector3() {x = val_10, y = InAccel.y, z = val_9});
            }
            
            }
            
            this.ServerMoveHandleClientError(TimeStamp:  TimeStamp, DeltaTime:  val_9, Accel:  new UnityEngine.Vector3() {x = val_10, y = InAccel.y, z = val_9}, ClientLoc:  new UnityEngine.Vector3() {x = ClientLoc.x, y = ClientLoc.y, z = val_8});
        }
        private void OnEnable()
        {
            if(0 == this.MyNetworkView)
            {
                    return;
            }
            
            this.MyNetworkView.RegisterSerializableComponent(serializedComponent:  this);
        }
        private void OnDisable()
        {
            if(0 != this.MyNetworkView)
            {
                    this.MyNetworkView.UnregisterSerializableComponent(serializedComponent:  this);
            }
            
            if((this.bPressedJump != false) && (this.JumpKeyHoldTime >= this.JumpMaxHoldTime))
            {
                    this.bPressedJump = false;
            }
            
            this.clientUpdateRoutine = 0;
        }
        public void OnSerializeEvent(TzarGames.GameFramework._IBitStream stream, TzarGames.GameFramework.INetworkMessageInfo info)
        {
            UnityEngine.Transform val_27;
            var val_28;
            var val_29;
            UnityEngine.Transform val_30;
            var val_31;
            var val_32;
            UnityEngine.Vector3 val_33;
            NetState val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            NetState val_40;
            NetState val_41;
            NetState val_42;
            var val_43;
            var val_44;
            float val_45;
            float val_46;
            float val_47;
            var val_48;
            val_27 = this;
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_28 = 7;
            val_29 = stream;
            if((stream & 1) == 0)
            {
                goto label_6;
            }
            
            val_30 = this.cachedTransform;
            UnityEngine.Vector3 val_2 = val_30.position;
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_28 = 3;
            val_31 = stream;
            goto label_12;
            label_6:
            var val_28 = 0;
            val_28 = val_28 + 1;
            val_32 = info;
            goto label_17;
            label_12:
            val_33 = this.velocity;
            var val_29 = 0;
            val_29 = val_29 + 1;
            val_28 = 3;
            val_35 = stream;
            goto label_22;
            label_17:
            var val_30 = 0;
            val_30 = val_30 + 1;
            val_36 = stream;
            goto label_27;
            label_22:
            bool val_31 = this.syncRotationFromServer;
            if((val_31 & 255) == false)
            {
                    return;
            }
            
            val_31 = val_31 >> 32;
            if(val_31 == true)
            {
                goto label_29;
            }
            
            if(val_31 == true)
            {
                    return;
            }
            
            val_27 = this.cachedTransform;
            UnityEngine.Quaternion val_7 = val_27.rotation;
            val_33 = val_7.x;
            val_34 = val_7.z;
            var val_32 = 0;
            val_32 = val_32 + 1;
            val_37 = stream;
            return;
            label_27:
            var val_33 = 0;
            val_33 = val_33 + 1;
            val_38 = stream;
            bool val_34 = this.syncRotationFromServer;
            if((val_34 & 255) == false)
            {
                goto label_42;
            }
            
            val_34 = val_34 >> 32;
            if(val_34 == true)
            {
                goto label_43;
            }
            
            if(val_34 == true)
            {
                goto label_44;
            }
            
            var val_35 = 0;
            val_35 = val_35 + 1;
            val_39 = stream;
            val_40 = V1.16B;
            val_41 = V0.16B;
            val_42 = V0.16B;
            goto label_71;
            label_42:
            val_40 = V1.16B;
            val_41 = V0.16B;
            val_42 = V0.16B;
            if(S0 != 0f)
            {
                goto label_50;
            }
            
            UnityEngine.Quaternion val_11 = this.cachedTransform.rotation;
            goto label_71;
            label_29:
            UnityEngine.Vector3 val_12 = this.cachedTransform.eulerAngles;
            val_33 = val_12.y;
            val_27 = (int)val_33;
            var val_36 = 0;
            val_36 = val_36 + 1;
            val_28 = 5;
            val_43 = stream;
            return;
            label_43:
            var val_37 = 0;
            val_37 = val_37 + 1;
            val_44 = stream;
            val_42 = V0.16B;
            goto label_63;
            label_44:
            val_40 = V1.16B;
            val_41 = V0.16B;
            val_42 = V0.16B;
            UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.identity;
            goto label_71;
            label_50:
            val_45 = V0.16B;
            val_46 = 0f;
            val_47 = V2.16B;
            UnityEngine.Quaternion val_14 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_45, y = 0f, z = val_47});
            goto label_71;
            label_63:
            val_40 = V1.16B;
            val_41 = V0.16B;
            val_45 = 0f;
            val_46 = (float)(int)stream & 65535;
            val_47 = val_45;
            UnityEngine.Quaternion val_19 = UnityEngine.Quaternion.Euler(x:  val_45, y:  val_46, z:  val_47);
            label_71:
            val_34 = val_19.w;
            val_48 = this.proxyStates.Length - 2;
            goto label_76;
            label_82:
            var val_20 = X23 + (X24 * 48);
            val_48 = val_48 - 1;
            label_76:
            NetState[] val_38 = this.proxyStates;
            int val_21 = val_48 + 1;
            if(val_21 <= 0)
            {
                goto label_78;
            }
            
            val_38 = (val_38 + ((long)val_21 * 48)) + 32;
            if(val_48 < this.proxyStates.Length)
            {
                goto label_82;
            }
            
            goto label_82;
            label_78:
            val_38[0] = ;
            val_38[1] = val_41;
            val_38[1] = val_40;
            val_38[2] = V2.16B;
            val_38[2] = V0.16B;
            val_38[3] = V1.16B;
            val_38[3] = V2.16B;
            val_38[4] = val_19.x;
            val_38[4] = val_19.y;
            val_38[5] = val_19.z;
            val_38[5] = val_34;
            val_30 = this.proxyStates;
            this.proxyStateCount = UnityEngine.Mathf.Min(a:  0, b:  this.proxyStateCount + 1);
            val_33 = this.proxyStates[0];
            NetState val_39 = this.proxyStates[6];
            if(val_33 >= 0)
            {
                    return;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Timestamp inconsistent: ";
            typeof(System.Object[]).__il2cppRuntimeField_28 = this.proxyStates[0];
            val_30 = " should be greater than ";
            typeof(System.Object[]).__il2cppRuntimeField_30 = val_30;
            typeof(System.Object[]).__il2cppRuntimeField_38 = this.proxyStates[6];
            val_27 = +0;
            UnityEngine.Debug.LogError(message:  0);
        }
        public void MoveAutonomous(float ClientTimeStamp, float DeltaTime, TzarGames.GameFramework.FSavedMove_Character.CompressedFlags CompressedFlags, UnityEngine.Vector3 NewAccel)
        {
            if(this.enableMovement == false)
            {
                    return;
            }
            
            this.UpdateFromCompressedFlags(Flags:  CompressedFlags);
            this.CheckJumpInput(DeltaTime:  DeltaTime);
            if(this.IsGrounded != true)
            {
                    if(this.MovementMode != 2)
            {
                goto label_2;
            }
            
            }
            
            NewAccel.y = 0f;
            label_2:
            this.Acceleration = NewAccel;
            mem[1152921511278038452] = NewAccel.y;
            mem[1152921511278038456] = NewAccel.z;
            if(this.bPressedJump == false)
            {
                    return;
            }
            
            if(this.JumpKeyHoldTime < this.JumpMaxHoldTime)
            {
                    return;
            }
            
            this.bPressedJump = false;
        }
        private void CheckJumpInput(float DeltaTime)
        {
            bool val_3;
            if(this.bPressedJump == false)
            {
                goto label_0;
            }
            
            if((this.jumpCurrentCount == 0) && (this.MovementMode == 2))
            {
                    this.jumpCurrentCount = 1;
            }
            
            if(this.CanJump() == false)
            {
                goto label_3;
            }
            
            val_3 = 0;
            if((this.DoJump(bReplayingMoves:  false)) == false)
            {
                goto label_7;
            }
            
            if(this.bWasJumping != true)
            {
                    int val_3 = this.jumpCurrentCount;
                val_3 = val_3 + 1;
                this.jumpCurrentCount = val_3;
            }
            
            if(this.jumpCurrentCount != 0)
            {
                    float val_4 = this.JumpKeyHoldTime;
                val_4 = val_4 + DeltaTime;
                this.JumpKeyHoldTime = val_4;
            }
            
            val_3 = 1;
            goto label_7;
            label_0:
            if(this.bWasJumping == false)
            {
                    return;
            }
            
            if(this.MovementMode == 2)
            {
                    return;
            }
            
            this.bWasJumping = false;
            this.JumpKeyHoldTime = 0f;
            this.jumpCurrentCount = 0;
            return;
            label_3:
            val_3 = false;
            label_7:
            this.bWasJumping = val_3;
        }
        private bool DoJump(bool bReplayingMoves)
        {
            var val_2;
            if(this.CanJump() != false)
            {
                    this.MovementMode = 2;
                mem[1152921511278287040] = this.jumpVerticalVelocity;
                this.OnMovementModeChanged(PreviousMovementMode:  bReplayingMoves);
                val_2 = 1;
                return (bool)val_2;
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
        private bool CanJump()
        {
            var val_6;
            if(this.enableJumping == false)
            {
                goto label_6;
            }
            
            if(this.IsGrounded != true)
            {
                    if(this.MovementMode != 2)
            {
                goto label_6;
            }
            
            }
            
            if((this.JumpMaxHoldTime <= 0f) || (this.bWasJumping == false))
            {
                goto label_4;
            }
            
            if((this.bPressedJump == false) || (this.JumpKeyHoldTime >= 0))
            {
                goto label_6;
            }
            
            if(this.jumpCurrentCount >= this.JumpMaxCount)
            {
                goto label_7;
            }
            
            val_6 = 1;
            return (bool)(this.jumpCurrentCount < this.JumpMaxCount) ? 1 : 0;
            label_6:
            val_6 = 0;
            return (bool)(this.jumpCurrentCount < this.JumpMaxCount) ? 1 : 0;
            label_4:
            if((this.jumpCurrentCount != 0) || (this.MovementMode != 2))
            {
                    return (bool)(this.jumpCurrentCount < this.JumpMaxCount) ? 1 : 0;
            }
            
            var val_3 = (this.JumpMaxCount > 1) ? 1 : 0;
            return (bool)(this.jumpCurrentCount < this.JumpMaxCount) ? 1 : 0;
            label_7:
            var val_5 = (this.jumpCurrentCount == this.JumpMaxCount) ? 1 : 0;
            return (bool)(this.jumpCurrentCount < this.JumpMaxCount) ? 1 : 0;
        }
        private bool IsJumpProvidingForce()
        {
            if(this.bPressedJump == false)
            {
                    return false;
            }
            
            return (bool)(this.JumpKeyHoldTime < 0) ? 1 : 0;
        }
        private void ClearJumpInput()
        {
            if(this.bPressedJump == false)
            {
                    return;
            }
            
            if(this.JumpKeyHoldTime < this.JumpMaxHoldTime)
            {
                    return;
            }
            
            this.bPressedJump = false;
        }
        private float GetJumpMaxHoldTime()
        {
            return (float)this.JumpMaxHoldTime;
        }
        private void UpdateFromCompressedFlags(TzarGames.GameFramework.FSavedMove_Character.CompressedFlags Flags)
        {
            var val_6;
            this.bPressedJump = Flags & 1;
            if(this.OnServer != false)
            {
                    val_6 = 1;
            }
            else
            {
                    val_6 = this.Connected ^ 1;
            }
            
            if(val_6 == false)
            {
                    return;
            }
            
            if(this.bPressedJump == true)
            {
                    return;
            }
            
            this.bWasJumping = false;
            this.JumpKeyHoldTime = 0f;
            if(this.MovementMode == 2)
            {
                    return;
            }
            
            this.jumpCurrentCount = 0;
        }
        private void ResetJumpState()
        {
            this.bWasJumping = false;
            this.JumpKeyHoldTime = 0f;
            if(this.MovementMode == 2)
            {
                    return;
            }
            
            this.jumpCurrentCount = 0;
        }
        private void SimulateMovement(float deltaTime)
        {
            float val_16;
            NetState val_17;
            NetState[] val_18;
            NetState[] val_19;
            double val_20;
            NetState val_21;
            NetState val_22;
            NetState val_23;
            float val_27;
            float val_28;
            val_16 = deltaTime;
            if(this.enableMovement == false)
            {
                    return;
            }
            
            if(this.doAdditionalGroundTrace != false)
            {
                    this.traceGround();
            }
            
            double val_2 = TzarGames.GameFramework.GameManagerNetSyncBase.NetworkTime - this.interpolationBackTime;
            val_17 = this.proxyStates[0];
            if(val_17 <= val_2)
            {
                goto label_7;
            }
            
            if(this.proxyStateCount < 1)
            {
                goto label_25;
            }
            
            var val_18 = 0;
            val_18 = 48;
            label_13:
            val_19 = val_18 + 1;
            var val_3 = this.proxyStates + ((long)val_19 * val_18);
            val_17 = mem[((long)(int)((0 + 1)) * val_18) + this.proxyStates + 32];
            val_17 = ((long)(int)((0 + 1)) * val_18) + this.proxyStates + 32;
            if((val_17 <= val_2) || (val_19 == (this.proxyStateCount - 1)))
            {
                goto label_12;
            }
            
            val_18 = val_18 + 1;
            if((val_18 + 2) < this.proxyStateCount)
            {
                goto label_13;
            }
            
            goto label_25;
            label_7:
            NetState val_19 = this.proxyStates[0];
            val_20 = this.extrapolationLimit;
            val_19 = val_2 - val_19;
            val_17 = (double)(float)val_19;
            if(val_17 >= 0)
            {
                goto label_25;
            }
            
            val_21 = this.proxyStates[2];
            val_23 = this.proxyStates[3];
            val_22 = this.proxyStates[3];
            val_22 = val_22;
            val_23 = val_23;
            val_21 = val_21;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_21, y = val_23, z = val_22}, d:  (float)val_19);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.proxyStates[1], y = this.proxyStates[1], z = this.proxyStates[2]}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            this.cachedTransform.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            val_17 = this.proxyStates[4];
            val_20 = this.proxyStates[4];
            val_27 = this.proxyStates[5];
            this.cachedTransform.rotation = new UnityEngine.Quaternion() {x = val_17, y = val_20, z = val_27, w = this.proxyStates[5]};
            val_16 = val_16;
            if(this.character.enabled == false)
            {
                goto label_25;
            }
            
            val_20 = val_23;
            val_17 = val_21;
            val_27 = val_22;
            bool val_9 = this.character.SimpleMove(speed:  new UnityEngine.Vector3() {x = val_17, y = val_20, z = val_27});
            goto label_25;
            label_12:
            val_19 = this.proxyStates;
            var val_27 = 48;
            val_27 = val_19 + (((long)UnityEngine.Mathf.Max(a:  0, b:  0)) * val_27);
            val_18 = this.proxyStates;
            val_18 = val_18 + 1;
            var val_28 = 48;
            val_28 = val_18 + ((long)val_19 * val_28);
            float val_29 = ((long)(int)((0 + 1)) * 48) + this.proxyStates + 32;
            double val_11 = (((long)(int)(val_10) * 48) + this.proxyStates + 32) - val_29;
            if(val_11 > 0.0001)
            {
                    val_29 = val_2 - val_29;
                val_29 = val_29 / val_11;
                val_28 = (float)val_29;
            }
            else
            {
                    val_28 = 0f;
            }
            
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = ((long)(int)((0 + 1)) * 48) + this.proxyStates + 40, y = ((long)(int)((0 + 1)) * 48) + this.proxyStates + 40 + 4, z = ((long)(int)((0 + 1)) * 48) + this.proxyStates + 48}, b:  new UnityEngine.Vector3() {x = ((long)(int)(val_10) * 48) + this.proxyStates + 40, y = ((long)(int)(val_10) * 48) + this.proxyStates + 40 + 4, z = ((long)(int)(val_10) * 48) + this.proxyStates + 48}, t:  val_28);
            this.cachedTransform.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            val_16 = val_16;
            UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.Slerp(a:  new UnityEngine.Quaternion() {x = ((long)(int)((0 + 1)) * 48) + this.proxyStates + 64, y = ((long)(int)((0 + 1)) * 48) + this.proxyStates + 68, z = ((long)(int)((0 + 1)) * 48) + this.proxyStates + 72, w = ((long)(int)((0 + 1)) * 48) + this.proxyStates + 76}, b:  new UnityEngine.Quaternion() {x = ((long)(int)(val_10) * 48) + this.proxyStates + 64, y = ((long)(int)(val_10) * 48) + this.proxyStates + 68, z = ((long)(int)(val_10) * 48) + this.proxyStates + 72, w = ((long)(int)(val_10) * 48) + this.proxyStates + 76}, t:  val_28);
            val_17 = val_13.x;
            val_20 = val_13.y;
            val_27 = val_13.z;
            this.cachedTransform.localRotation = new UnityEngine.Quaternion() {x = val_17, y = val_20, z = val_27, w = val_13.w};
            label_25:
            if((this.isMoveTriggerSet != false) && (this.usePrediction != true))
            {
                    val_20 = this.lastPosition;
                val_17 = val_16;
                this.updateMoveTrigger(deltaSeconds:  val_17, oldLocation:  new UnityEngine.Vector3() {x = val_20, y = val_27, z = val_13.w});
            }
            
            UnityEngine.Vector3 val_14 = this.cachedTransform.position;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = this.lastPosition, y = val_13.w, z = val_13.z});
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, d:  val_16);
            this.simulatedVelocity = val_16;
            mem[1152921511279329252] = val_16.y;
            mem[1152921511279329256] = val_16.z;
            UnityEngine.Vector3 val_17 = this.cachedTransform.position;
            this.lastPosition = val_17;
            mem[1152921511279329264] = val_17.y;
            mem[1152921511279329268] = val_17.z;
        }
        public void ServerMoveHandleClientError(float TimeStamp, float DeltaTime, UnityEngine.Vector3 Accel, UnityEngine.Vector3 ClientLoc)
        {
            TzarGames.GameFramework.FClientAdjustment val_20;
            var val_21;
            float val_22;
            UnityEngine.Transform val_23;
            float val_24;
            float val_25;
            float val_26;
            bool val_27;
            val_20 = TimeStamp;
            val_21 = this;
            val_22 = ClientLoc.x;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_22, y = ClientLoc.y, z = ClientLoc.z}, rhs:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f})) == true)
            {
                    return;
            }
            
            TzarGames.GameFramework.FNetworkPredictionData_Server_Character val_3 = this.GetPredictionData_Server_Character();
            if((double)val_3.LastUpdateTime != TzarGames.GameFramework.GameManagerNetSyncBase.NetworkTime)
            {
                    val_22 = val_3.LastUpdateTime;
                if((TzarGames.GameFramework.GlobalUtility.WithinUpdateDelayBounds(LastUpdateTime:  val_22)) == true)
            {
                    return;
            }
            
            }
            
            val_23 = this.cachedTransform;
            UnityEngine.Vector3 val_7 = val_23.position;
            val_24 = val_7.x;
            val_25 = val_7.y;
            val_26 = val_24;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_26, y = val_25, z = val_7.z}, b:  new UnityEngine.Vector3() {x = ClientLoc.x, y = ClientLoc.y, z = ClientLoc.z});
            if((TzarGames.GameFramework.GlobalUtility.ExceedsAllowablePositionError(LocDiff:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z})) == false)
            {
                goto label_13;
            }
            
            mem2[0] = this.velocity;
            mem2[0] = ???;
            mem2[0] = ???;
            if(val_3 == null)
            {
                goto label_15;
            }
            
            mem2[0] = this.currentBase;
            goto label_16;
            label_13:
            if(val_3 == null)
            {
                goto label_17;
            }
            
            val_3.PendingAdjustment = val_20;
            goto label_18;
            label_15:
            mem[80] = this.currentBase;
            label_16:
            val_27 = TzarGames.GameFramework.MovementBaseUtility.UseRelativePosition(MovementBase:  0);
            mem2[0] = val_27;
            UnityEngine.Vector3 val_11 = this.cachedTransform.position;
            val_20 = val_11.y;
            if(val_27 == false)
            {
                goto label_21;
            }
            
            UnityEngine.Vector3 val_12 = this.currentBase.GetComponentLocation();
            val_24 = val_12.z;
            val_26 = val_11.x;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_26, y = val_20, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_24});
            mem2[0] = val_13.x;
            mem2[0] = val_13.y;
            mem2[0] = val_13.z;
            goto label_25;
            label_17:
            mem[24] = val_20;
            label_18:
            mem2[0] = 1;
            return;
            label_21:
            mem2[0] = val_11.x;
            mem2[0] = val_20;
            mem2[0] = val_11.z;
            label_25:
            val_25 = DeltaTime;
            mem2[0] = this.rotator;
            mem2[0] = 80;
            val_3.PendingAdjustment = val_20;
            mem2[0] = val_25;
            val_3.LastUpdateTime = (float)TzarGames.GameFramework.GameManagerNetSyncBase.NetworkTime;
            mem2[0] = 0;
            UnityEngine.Vector3 val_15 = this.cachedTransform.position;
            val_23 = ClientLoc.x;
            val_21 = System.String.Format(format:  0, arg0:  "Correction: ServerPos: ({0}), ClientPos: ({1}), Difference: {2}", arg1:  TzarGames.GameFramework.GlobalUtility.LogVector3(vec:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}), arg2:  TzarGames.GameFramework.GlobalUtility.LogVector3(vec:  new UnityEngine.Vector3() {x = ClientLoc.x, y = ClientLoc.y, z = ClientLoc.z}));
            UnityEngine.Debug.Log(message:  0);
        }
        public bool VerifyClientTimeStamp(float TimeStamp, TzarGames.GameFramework.FNetworkPredictionData_Server_Character ServerData)
        {
            var val_5;
            var val_6;
            float val_1 = TimeStamp - ServerData.CurrentClientTimeStamp;
            val_5 = null;
            val_5 = null;
            float val_6 = TzarGames.GameFramework.CharacterMovementU.MinTimeBetweenTimeStampResets;
            val_6 = val_6 * 0.5f;
            if(System.Math.Abs(val_1) <= val_6)
            {
                goto label_6;
            }
            
            if(val_1 >= 0)
            {
                goto label_7;
            }
            
            UnityEngine.Debug.Log(message:  0);
            ServerData.CurrentClientTimeStamp = 0f;
            val_6 = 1;
            return (bool)val_6;
            label_6:
            var val_4 = (ServerData.CurrentClientTimeStamp < TimeStamp) ? 1 : 0;
            return (bool)val_6;
            label_7:
            UnityEngine.Debug.Log(message:  0);
            val_6 = 0;
            return (bool)val_6;
        }
        public virtual void UpdateMovementModeFromAdjustment()
        {
            if(this.MovementMode == 0)
            {
                    return;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            this.MovementMode = ((this.IsGrounded & true) != 0) ? (1 + 1) : 1;
            this.OnMovementModeChanged(PreviousMovementMode:  this.UpdatedComponent);
        }
        public virtual void UpdateComponentvelocity()
        {
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            this.UpdatedComponent.Componentvelocity = this.velocity;
            mem2[0] = ???;
            mem2[0] = this;
        }
        public TzarGames.GameFramework.EMovementMode DetermineSimulatedMovementMode()
        {
            return (TzarGames.GameFramework.EMovementMode)((this.IsGrounded & true) != 0) ? (1 + 1) : 1;
        }
        public UnityEngine.Vector3 ConstrainInputAcceleration(UnityEngine.Vector3 InputAcceleration)
        {
            if(this.IsGrounded != true)
            {
                    if(this.MovementMode != 2)
            {
                    return new UnityEngine.Vector3() {x = InputAcceleration.x, y = InputAcceleration.y, z = InputAcceleration.z};
            }
            
            }
            
            InputAcceleration.y = 0f;
            return new UnityEngine.Vector3() {x = InputAcceleration.x, y = InputAcceleration.y, z = InputAcceleration.z};
        }
        public UnityEngine.Vector3 ScaleInputAcceleration(UnityEngine.Vector3 InputAcceleration)
        {
            if(InputAcceleration.x > 0f)
            {
                    UnityEngine.Vector3 val_1 = TzarGames.Common.FMath.SafeNormalPrecise(V:  new UnityEngine.Vector3() {x = InputAcceleration.x, y = InputAcceleration.y, z = InputAcceleration.z});
                UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(d:  this.MaxAcceleration, a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
                return new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            }
            
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            return new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        protected override void Awake()
        {
            this.Awake();
            this.character = this.GetComponent<UnityEngine.CharacterController>();
            this.cachedTransform = this.transform;
            if(this.doAdditionalGroundTrace == false)
            {
                    return;
            }
            
            this.traceGround();
        }
        public void HandleRootMotion(UnityEngine.Vector3 deltaPos, UnityEngine.Quaternion deltaRot)
        {
            if(this.enableMovement == false)
            {
                    return;
            }
            
            this = this.rootMovements;
            this.Add(item:  new RootMotionData() {DeltaPosition = new UnityEngine.Vector3() {x = deltaPos.x, y = deltaPos.y, z = deltaPos.z}, DeltaRotation = new UnityEngine.Quaternion() {x = deltaRot.x, y = deltaRot.y, z = deltaRot.z, w = deltaRot.w}});
        }
        private void ReplicateMoveToServer(float DeltaTime, UnityEngine.Vector3 NewAcceleration)
        {
            float val_10;
            float val_11;
            TzarGames.GameFramework.CharacterMovementU val_12;
            TzarGames.GameFramework.FSavedMove_Character val_13;
            TzarGames.GameFramework.FSavedMove_Character val_14;
            val_10 = NewAcceleration.z;
            val_11 = NewAcceleration.x;
            TzarGames.GameFramework.FNetworkPredictionData_Client_Character val_1 = this.GetPredictionData_Client_Character();
            if(val_1 == null)
            {
                    return;
            }
            
            val_12 = this;
            float val_2 = val_1.UpdateTimeStampAndDeltaTime(DeltaTime:  DeltaTime, CharacterMovementComponent:  this);
            val_13 = 0;
            if(val_1.LastAckedMove == null)
            {
                goto label_8;
            }
            
            var val_10 = 0;
            label_7:
            val_12 = public System.Int32 System.Collections.Generic.List<TzarGames.GameFramework.FSavedMove_Character>::get_Count();
            if(val_10 >= (val_1.SavedMoves.Count - 1))
            {
                goto label_4;
            }
            
            val_14 = val_1.LastAckedMove;
            val_13 = val_1.SavedMoves.Item[0];
            val_12 = val_14;
            val_10 = val_10 + 1;
            if(((val_13 & 1) & 1) == 0)
            {
                goto label_7;
            }
            
            goto label_8;
            label_4:
            val_13 = 0;
            label_8:
            if(val_1 == null)
            {
                    return;
            }
            
            this.Acceleration = new UnityEngine.Vector3();
            mem[1152921511280855028] = typeof(TzarGames.GameFramework.FNetworkPredictionData_Client_Character).__il2cppRuntimeField_150;
            mem[1152921511280855032] = ???;
            val_1.SavedMoves.Push(item:  val_1);
            val_1.ClientUpdateTime = (float)TzarGames.GameFramework.GameManagerNetSyncBase.NetworkTime;
            UnityEngine.Vector3 val_8 = this.cachedTransform.position;
            val_14 = this.cachedTransform;
            val_10 = val_8.x;
            val_11 = val_8.z;
            UnityEngine.Quaternion val_9 = val_14.rotation;
            this.CallServerMove(NewMove:  val_1, ClientLoc:  new UnityEngine.Vector3() {x = val_10, y = val_8.y, z = val_11}, View:  new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w}, OldMove:  val_13);
            val_1.PendingMove = 0;
        }
        public void CallServerMove(TzarGames.GameFramework.FSavedMove_Character NewMove, UnityEngine.Vector3 ClientLoc, UnityEngine.Quaternion View, TzarGames.GameFramework.FSavedMove_Character OldMove)
        {
            UnityEngine.Vector3 val_7;
            float val_8;
            float val_9;
            var val_10;
            System.Object[] val_11;
            var val_12;
            var val_13;
            byte val_14;
            TzarGames.GameFramework.FSavedMove_Character val_15;
            var val_18;
            var val_19;
            val_7 = View.w;
            val_8 = View.z;
            val_9 = View.x;
            if((OldMove != null) && (this.serverMoveOldCallCount >= 1))
            {
                    val_10 = 1152921504608444416;
                do
            {
                val_11 = null;
                typeof(System.Object[]).__il2cppRuntimeField_20 = OldMove.TimeStamp;
                typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
                if(OldMove.Acceleration != 0)
            {
                    val_12 = mem[null + 48];
                if(OldMove.Acceleration == 0)
            {
                    val_12 = 0;
            }
            
            }
            
                val_12 = 0;
                typeof(System.Object[]).__il2cppRuntimeField_28 = OldMove.Acceleration;
                typeof(System.Object[]).__il2cppRuntimeField_30 = OldMove;
                typeof(System.Object[]).__il2cppRuntimeField_31 = 26071494;
                this.UnreliableRPC(methodDelegate:  new TzarGames.GameFramework.RPCall<System.Single, UnityEngine.Vector3, System.Byte>(object:  this, method:  public System.Void TzarGames.GameFramework.CharacterMovementU::ServerMoveOld(float OldTimeStamp, UnityEngine.Vector3 OldAccel, byte oldMoveFlags)), callTarget:  5, parameters:  val_11);
                val_13 = 0 + 1;
            }
            while(val_13 < this.serverMoveOldCallCount);
            
            }
            
            val_14 = this.GetPredictionData_Client_Character();
            if(val_2.PendingMove == null)
            {
                goto label_15;
            }
            
            float val_7 = 182.0444f;
            ClientLoc.x = ClientLoc.x * val_7;
            val_7 = ClientLoc.x * val_7;
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.Euler(x:  ClientLoc.x, y:  val_7, z:  ClientLoc.x);
            val_11 = val_2.PendingMove;
            val_15 = val_11;
            if(val_11 != null)
            {
                goto label_21;
            }
            
            val_15 = val_2.PendingMove;
            if(val_15 == null)
            {
                goto label_22;
            }
            
            label_21:
            val_8 = ClientLoc.x;
            val_14 = val_15;
            if(NewMove == null)
            {
                goto label_24;
            }
            
            val_9 = NewMove.TimeStamp;
            val_7 = NewMove.Acceleration;
            goto label_25;
            label_15:
            if(this.serverMoveCallCount < 1)
            {
                    return;
            }
            
            val_10 = 1152921504608444416;
            do
            {
                val_14 = this.MyNetworkView;
                if(this.sendClientRotation != false)
            {
                    val_11 = null;
                typeof(System.Object[]).__il2cppRuntimeField_20 = NewMove.TimeStamp;
                typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
                typeof(System.Object[]).__il2cppRuntimeField_28 = NewMove.Acceleration;
                if(ClientLoc != 0)
            {
                    val_18 = mem[null + 48];
                if(ClientLoc == 0)
            {
                    val_18 = 0;
            }
            
            }
            
                val_18 = 0;
                typeof(System.Object[]).__il2cppRuntimeField_30 = ClientLoc;
                typeof(System.Object[]).__il2cppRuntimeField_38 = NewMove;
                typeof(System.Object[]).__il2cppRuntimeField_39 = 26071674;
                typeof(System.Object[]).__il2cppRuntimeField_40 = View;
                val_14.UnreliableRPC<System.Single, UnityEngine.Vector3, UnityEngine.Vector3, System.Byte, UnityEngine.Quaternion>(methodDelegate:  new TzarGames.GameFramework.RPCall<System.Single, UnityEngine.Vector3, UnityEngine.Vector3, System.Byte, UnityEngine.Quaternion>(object:  this, method:  public System.Void TzarGames.GameFramework.CharacterMovementU::ServerMove(float TimeStamp, UnityEngine.Vector3 InAccel, UnityEngine.Vector3 ClientLoc, byte MoveFlags, UnityEngine.Quaternion ViewRotationFromClient)), mode:  5, args:  val_11);
            }
            else
            {
                    val_11 = null;
                typeof(System.Object[]).__il2cppRuntimeField_20 = NewMove.TimeStamp;
                typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
                typeof(System.Object[]).__il2cppRuntimeField_28 = NewMove.Acceleration;
                if(ClientLoc != 0)
            {
                    val_19 = mem[null + 48];
                if(ClientLoc == 0)
            {
                    val_19 = 0;
            }
            
            }
            
                val_19 = 0;
                typeof(System.Object[]).__il2cppRuntimeField_30 = ClientLoc;
                typeof(System.Object[]).__il2cppRuntimeField_38 = NewMove;
                typeof(System.Object[]).__il2cppRuntimeField_39 = 26071762;
                val_14.UnreliableRPC<System.Single, UnityEngine.Vector3, UnityEngine.Vector3, System.Byte>(methodDelegate:  new TzarGames.GameFramework.RPCall<System.Single, UnityEngine.Vector3, UnityEngine.Vector3, System.Byte>(object:  this, method:  public System.Void TzarGames.GameFramework.CharacterMovementU::ServerMove_NoRot(float TimeStamp, UnityEngine.Vector3 InAccel, UnityEngine.Vector3 ClientLoc, byte moveFlags)), mode:  5, args:  val_11);
            }
            
                val_13 = 0 + 1;
            }
            while(val_13 < this.serverMoveCallCount);
            
            return;
            label_24:
            val_9 = 8.96831E-44f;
            val_7 = NewMove.Acceleration;
            label_25:
            this.ServerMoveDual(TimeStamp0:  val_2.PendingMove.TimeStamp, InAccel0:  new UnityEngine.Vector3() {x = val_2.PendingMove.Acceleration, y = val_2.PendingMove.Acceleration, z = val_2.PendingMove.Acceleration}, pendingFlags:  val_14, View0:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}, TimeStamp:  val_9, InAccel:  new UnityEngine.Vector3() {x = val_7, y = ClientLoc.y, z = val_8}, newFlags:  NewMove, ClientLoc:  new UnityEngine.Vector3() {x = ClientLoc.z, y = val_9, z = val_8}, View:  new UnityEngine.Quaternion() {w = val_2.PendingMove.Acceleration});
            return;
            label_22:
        }
        [TzarRPC]
        public void ServerMoveOld(float OldTimeStamp, UnityEngine.Vector3 OldAccel, byte oldMoveFlags)
        {
            TzarGames.GameFramework.FNetworkPredictionData_Server_Character val_6;
            float val_7;
            if(this.enabled == false)
            {
                    return;
            }
            
            TzarGames.GameFramework.FNetworkPredictionData_Server_Character val_2 = this.GetPredictionData_Server_Character();
            val_6 = val_2;
            if((val_2.VerifyClientTimeStamp(TimeStamp:  OldTimeStamp, ServerData:  val_6)) == false)
            {
                    return;
            }
            
            if(val_6 != null)
            {
                    val_7 = val_2.MaxResponseTime;
            }
            else
            {
                    val_7 = 8.260437E-38f;
            }
            
            float val_5 = UnityEngine.Mathf.Min(a:  OldTimeStamp - val_2.CurrentClientTimeStamp, b:  val_7);
            this.MoveAutonomous(ClientTimeStamp:  val_5, DeltaTime:  val_5, CompressedFlags:  oldMoveFlags, NewAccel:  new UnityEngine.Vector3() {x = OldAccel.x, y = OldAccel.y, z = OldAccel.z});
            val_2.CurrentClientTimeStamp = OldTimeStamp;
        }
        public void ServerMoveDual(float TimeStamp0, UnityEngine.Vector3 InAccel0, byte pendingFlags, UnityEngine.Quaternion View0, float TimeStamp, UnityEngine.Vector3 InAccel, byte newFlags, UnityEngine.Vector3 ClientLoc, UnityEngine.Quaternion View)
        {
            var val_1;
            var val_5;
            var val_6;
            var val_9;
            var val_10;
            System.Delegate val_11;
            System.Object[] val_12;
            UnityEngine.Vector3 val_13;
            float val_14;
            var val_15;
            if(this.sendClientRotation != false)
            {
                    typeof(System.Object[]).__il2cppRuntimeField_20 = TimeStamp0;
                typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
                val_9 = 1152921504719785984;
                typeof(System.Object[]).__il2cppRuntimeField_28 = InAccel0;
                typeof(System.Object[]).__il2cppRuntimeField_30 = 0;
                typeof(System.Object[]).__il2cppRuntimeField_38 = pendingFlags;
                typeof(System.Object[]).__il2cppRuntimeField_39 = 26073045;
                val_10 = 1152921504719839232;
                typeof(System.Object[]).__il2cppRuntimeField_40 = View0;
                this.RPC(methodDelegate:  new TzarGames.GameFramework.RPCall<System.Single, UnityEngine.Vector3, UnityEngine.Vector3, System.Byte, UnityEngine.Quaternion>(object:  this, method:  public System.Void TzarGames.GameFramework.CharacterMovementU::ServerMove(float TimeStamp, UnityEngine.Vector3 InAccel, UnityEngine.Vector3 ClientLoc, byte MoveFlags, UnityEngine.Quaternion ViewRotationFromClient)), rpcMode:  5, parameters:  null);
                TzarGames.GameFramework.RPCall<System.Single, UnityEngine.Vector3, UnityEngine.Vector3, System.Byte, UnityEngine.Quaternion> val_4 = null;
                val_11 = val_4;
                val_4 = new TzarGames.GameFramework.RPCall<System.Single, UnityEngine.Vector3, UnityEngine.Vector3, System.Byte, UnityEngine.Quaternion>(object:  this, method:  public System.Void TzarGames.GameFramework.CharacterMovementU::ServerMove(float TimeStamp, UnityEngine.Vector3 InAccel, UnityEngine.Vector3 ClientLoc, byte MoveFlags, UnityEngine.Quaternion ViewRotationFromClient));
                val_12 = null;
                typeof(System.Object[]).__il2cppRuntimeField_20 = TimeStamp;
                typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
                typeof(System.Object[]).__il2cppRuntimeField_28 = InAccel;
                val_13 = InAccel.z;
                typeof(System.Object[]).__il2cppRuntimeField_30 = val_13;
                val_14 = val_5;
                val_15 = val_6;
                typeof(System.Object[]).__il2cppRuntimeField_38 = newFlags;
                typeof(System.Object[]).__il2cppRuntimeField_39 = 26073133;
                typeof(System.Object[]).__il2cppRuntimeField_40 = ClientLoc.y;
            }
            else
            {
                    val_14 = TimeStamp;
                TzarGames.GameFramework.RPCall<System.Single, UnityEngine.Vector3, UnityEngine.Vector3, System.Byte> val_7 = null;
                val_15 = val_1;
                val_10 = 1152921511281057600;
                val_7 = new TzarGames.GameFramework.RPCall<System.Single, UnityEngine.Vector3, UnityEngine.Vector3, System.Byte>(object:  this, method:  public System.Void TzarGames.GameFramework.CharacterMovementU::ServerMove_NoRot(float TimeStamp, UnityEngine.Vector3 InAccel, UnityEngine.Vector3 ClientLoc, byte moveFlags));
                val_9 = 1152921504608444416;
                typeof(System.Object[]).__il2cppRuntimeField_20 = TimeStamp0;
                typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
                typeof(System.Object[]).__il2cppRuntimeField_28 = InAccel0;
                typeof(System.Object[]).__il2cppRuntimeField_30 = 0;
                typeof(System.Object[]).__il2cppRuntimeField_38 = pendingFlags;
                typeof(System.Object[]).__il2cppRuntimeField_39 = 26073217;
                this.RPC(methodDelegate:  val_7, rpcMode:  5, parameters:  null);
                TzarGames.GameFramework.RPCall<System.Single, UnityEngine.Vector3, UnityEngine.Vector3, System.Byte> val_8 = null;
                val_11 = val_8;
                val_8 = new TzarGames.GameFramework.RPCall<System.Single, UnityEngine.Vector3, UnityEngine.Vector3, System.Byte>(object:  this, method:  public System.Void TzarGames.GameFramework.CharacterMovementU::ServerMove_NoRot(float TimeStamp, UnityEngine.Vector3 InAccel, UnityEngine.Vector3 ClientLoc, byte moveFlags));
                val_12 = null;
                typeof(System.Object[]).__il2cppRuntimeField_20 = val_14;
                typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
                typeof(System.Object[]).__il2cppRuntimeField_28 = InAccel;
                val_13 = InAccel.z;
                typeof(System.Object[]).__il2cppRuntimeField_30 = val_13;
                typeof(System.Object[]).__il2cppRuntimeField_38 = newFlags;
                typeof(System.Object[]).__il2cppRuntimeField_39 = 26073285;
            }
            
            this.RPC(methodDelegate:  val_11, rpcMode:  5, parameters:  val_12);
        }
        private bool ClientUpdatePositionAfterServerUpdate()
        {
            TzarGames.GameFramework.TArray<TzarGames.GameFramework.FSavedMove_Character> val_8;
            TzarGames.GameFramework.TArray<TzarGames.GameFramework.FSavedMove_Character> val_9;
            var val_10;
            var val_11;
            float val_12;
            var val_13;
            val_8 = this;
            TzarGames.GameFramework.FNetworkPredictionData_Client_Character val_1 = this.GetPredictionData_Client_Character();
            if(val_1.bUpdatePosition == 0)
            {
                goto label_2;
            }
            
            val_1.bUpdatePosition = 0;
            this.cachedTransform.position = new UnityEngine.Vector3() {x = this.serverCorrectLocation, y = V9.16B, z = V10.16B};
            val_9 = val_1.SavedMoves;
            if(val_9.Num() == 0)
            {
                goto label_5;
            }
            
            this.bForceNextFloorCheck = 1;
            this.bClientUpdating = 1;
            val_10 = 0;
            goto label_6;
            label_19:
            val_10 = 1;
            label_6:
            if(val_10 >= val_1.SavedMoves.Num())
            {
                goto label_9;
            }
            
            val_11 = static_value_0210D750;
            TzarGames.GameFramework.FSavedMove_Character val_4 = val_1.SavedMoves.Item[1];
            if(val_4 != null)
            {
                    val_12 = val_4.DeltaTime;
            }
            else
            {
                    val_12 = val_4.DeltaTime;
            }
            
            this.MoveAutonomous(ClientTimeStamp:  this.serverCorrectLocation, DeltaTime:  val_12, CompressedFlags:  val_4, NewAccel:  new UnityEngine.Vector3() {x = val_4.Acceleration});
            if(val_4 != null)
            {
                goto label_19;
            }
            
            goto label_19;
            label_9:
            this.bClientUpdating = false;
            this.bPressedJump = this.bPressedJump;
            this.bForceMaxAccel = (this.bForceMaxAccel != 0) ? 1 : 0;
            this.bForceNextFloorCheck = 1;
            val_8 = val_1.SavedMoves;
            var val_7 = (val_8.Num() > 0) ? 1 : 0;
            return (bool)val_13;
            label_5:
            UnityEngine.Debug.Log(message:  0);
            label_2:
            val_13 = 0;
            return (bool)val_13;
        }
        private void Reset()
        {
            this.character = this.GetComponent<UnityEngine.CharacterController>();
        }
        private void traceGround()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_2 = this.cachedTransform.position;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  this.character.height);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  0.499f);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector3 val_7 = this.character.center;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            this.isRayHitGround = UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, direction:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, maxDistance:  this.groundCheckRayDistance, layerMask:  0, queryTriggerInteraction:  UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask()));
        }
        private void LateUpdate()
        {
            UnityEngine.Vector3 val_23;
            float val_24;
            float val_25;
            float val_26;
            float val_30;
            float val_1 = UnityEngine.Time.deltaTime;
            TzarGames.GameFramework.Player val_3 = this.PlayerOwner;
            if(this.OnServer == false)
            {
                goto label_1;
            }
            
            if((val_3 == null) || (this.PlayerOwner.itsMe == false))
            {
                goto label_4;
            }
            
            if(this.enableMovement == false)
            {
                goto label_5;
            }
            
            val_23 = this.input;
            if(this.IsGrounded != true)
            {
                    if(this.MovementMode != 2)
            {
                goto label_7;
            }
            
            }
            
            val_24 = 0f;
            label_7:
            UnityEngine.Vector3 val_8 = this.ScaleInputAcceleration(InputAcceleration:  new UnityEngine.Vector3() {x = val_23, y = val_24, z = V9.16B});
            goto label_8;
            label_1:
            if((val_3 == null) || (this.PlayerOwner.itsMe == false))
            {
                goto label_11;
            }
            
            if(this.OnClient != false)
            {
                    bool val_12 = this.ClientUpdatePositionAfterServerUpdate();
            }
            
            val_25 = val_1;
            this.CheckJumpInput(DeltaTime:  val_25);
            if(this.enableMovement == false)
            {
                goto label_13;
            }
            
            val_23 = this.input;
            if(this.IsGrounded != true)
            {
                    if(this.MovementMode != 2)
            {
                goto label_15;
            }
            
            }
            
            val_26 = 0f;
            label_15:
            val_25 = val_23;
            UnityEngine.Vector3 val_15 = this.ScaleInputAcceleration(InputAcceleration:  new UnityEngine.Vector3() {x = val_25, y = val_26, z = V9.16B});
            goto label_16;
            label_4:
            if(this.usePrediction == false)
            {
                goto label_17;
            }
            
            this.SendClientAdjustment();
            return;
            label_11:
            if(this.OnClient == false)
            {
                goto label_18;
            }
            
            label_17:
            this.SimulateMovement(deltaTime:  val_1);
            return;
            label_18:
            val_23 = this.input;
            if(this.IsGrounded != true)
            {
                    if(this.MovementMode != 2)
            {
                goto label_20;
            }
            
            }
            
            val_30 = 0f;
            label_20:
            UnityEngine.Vector3 val_19 = this.ScaleInputAcceleration(InputAcceleration:  new UnityEngine.Vector3() {x = val_23, y = val_30, z = V9.16B});
            this.Acceleration = val_19;
            mem[1152921511282152244] = val_19.y;
            mem[1152921511282152248] = val_19.z;
            goto typeof(TzarGames.GameFramework.CharacterMovementU).__il2cppRuntimeField_350;
            label_5:
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.zero;
            label_8:
            this.Acceleration = val_20;
            mem[1152921511282152244] = val_20.y;
            mem[1152921511282152248] = val_20.z;
            goto typeof(TzarGames.GameFramework.CharacterMovementU).__il2cppRuntimeField_350;
            label_13:
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.zero;
            label_16:
            this.Acceleration = val_21;
            mem[1152921511282152244] = val_21.y;
            mem[1152921511282152248] = val_21.z;
            if((this.OnClient != false) && (this.usePrediction != false))
            {
                    this.ReplicateMoveToServer(DeltaTime:  val_1, NewAcceleration:  new UnityEngine.Vector3() {x = this.Acceleration, y = val_21.z});
            }
        
        }
        private void checkForForceUpdate(float DeltaSeconds)
        {
            float val_6;
            float val_7;
            val_6 = DeltaSeconds;
            if(this.GetPredictionData_Server() != null)
            {
                    val_7 = TzarGames.GameFramework.GameManagerNetSyncBase.NetworkTime - val_1.ServerTimeStamp;
            }
            else
            {
                    val_7 = 0;
            }
            
            float val_5 = 0.06f;
            val_5 = val_6 + val_5;
            if(val_7 <= ((double)UnityEngine.Mathf.Max(a:  val_5, b:  0.25f)))
            {
                    return;
            }
            
            this.ForcePositionUpdate(DeltaTime:  val_7);
            val_6 = TzarGames.GameFramework.GameManagerNetSyncBase.NetworkTime;
            val_1.ServerTimeStamp = val_6;
        }
        public TzarGames.GameFramework.FRotator get_Rotator()
        {
            TzarGames.GameFramework.FRotator val_0;
            val_0._q.z = ;
            val_0._transform = this.rotator;
            return val_0;
        }
        internal TzarGames.GameFramework.UPrimitiveComponent GetMovementBase()
        {
            return (TzarGames.GameFramework.UPrimitiveComponent)this.currentBase;
        }
        public bool get_SyncRotationFromServer()
        {
            return (bool)this.syncRotationFromServer;
        }
        public void set_SyncRotationFromServer(bool value)
        {
            this.syncRotationFromServer = value;
        }
        public float get_MaxSpeed()
        {
            return (float)this.maxSpeed;
        }
        public void set_MaxSpeed(float value)
        {
            this.maxSpeed = value;
        }
        public bool get_EnableMovement()
        {
            return (bool)this.enableMovement;
        }
        public void set_EnableMovement(bool value)
        {
            this.enableMovement = value;
        }
        public void LockSpeedOverride(object obj, float overMaxSpeed)
        {
            if(this.maxSpeedOverrider != null)
            {
                    string val_1 = 0 + "maxSpeedOverride locked by ";
                UnityEngine.Debug.LogWarning(message:  0);
                return;
            }
            
            this.overrideMaxSpeed = overMaxSpeed;
            this.maxSpeedOverrider = obj;
        }
        public void UnlockSpeedOverride(object obj)
        {
            if(this.maxSpeedOverrider != obj)
            {
                    return;
            }
            
            this.maxSpeedOverrider = 0;
        }
        public void ZeroMovement()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.velocity = val_1;
            mem[1152921511283598592] = val_1.y;
            mem[1152921511283598596] = val_1.z;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.Acceleration = val_2;
            mem[1152921511283598580] = val_2.y;
            mem[1152921511283598584] = val_2.z;
            this.rootMovements.Clear();
        }
        public void NotifyPositionChange(UnityEngine.Vector3 position)
        {
            if(UnityEngine.Time.inFixedTimeStep != false)
            {
                    this.cachedTransform.position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
                return;
            }
            
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.changePositionRoutine(position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}));
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator changePositionRoutine(UnityEngine.Vector3 position)
        {
            if(null != 0)
            {
                    typeof(CharacterMovementU.<changePositionRoutine>c__Iterator1).__il2cppRuntimeField_10 = position.x;
                typeof(CharacterMovementU.<changePositionRoutine>c__Iterator1).__il2cppRuntimeField_14 = position.y;
                typeof(CharacterMovementU.<changePositionRoutine>c__Iterator1).__il2cppRuntimeField_18 = position.z;
            }
            else
            {
                    mem[16] = position.x;
                typeof(CharacterMovementU.<changePositionRoutine>c__Iterator1).__il2cppRuntimeField_14 = position.y;
                mem[24] = position.z;
            }
            
            typeof(CharacterMovementU.<changePositionRoutine>c__Iterator1).__il2cppRuntimeField_20 = this;
            return (System.Collections.IEnumerator)new CharacterMovementU.<changePositionRoutine>c__Iterator1();
        }
        public UnityEngine.Vector3 get_Velocity()
        {
            if(this.OnClient != true)
            {
                    if(this.usePrediction == true)
            {
                    return new UnityEngine.Vector3() {x = this.simulatedVelocity};
            }
            
            }
            
            if(this.PlayerOwner == null)
            {
                    return new UnityEngine.Vector3() {x = this.simulatedVelocity};
            }
            
            if(this.PlayerOwner.itsMe != false)
            {
                    return new UnityEngine.Vector3() {x = this.simulatedVelocity};
            }
            
            return new UnityEngine.Vector3() {x = this.simulatedVelocity};
        }
        public float get_CurrentMoveSpeed()
        {
        
        }
        public UnityEngine.Vector3 get_InputVector()
        {
            return new UnityEngine.Vector3() {x = this.input};
        }
        public void set_InputVector(UnityEngine.Vector3 value)
        {
            this.input = value;
            mem[1152921511284315972] = value.y;
            mem[1152921511284315976] = value.z;
            if(value.x > 0f)
            {
                
            }
            else
            {
                    UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            }
            
            this.input = val_1;
            mem[1152921511284315972] = val_1.y;
            mem[1152921511284315976] = val_1.z;
        }
        public float get_Height()
        {
            if(this.character != null)
            {
                    return this.character.height;
            }
            
            return this.character.height;
        }
        public float get_Radius()
        {
            if(this.character != null)
            {
                    return this.character.radius;
            }
            
            return this.character.radius;
        }
        public bool get_IsGrounded()
        {
            if((this.doAdditionalGroundTrace != false) && (this.isRayHitGround != false))
            {
                    return true;
            }
            
            if(this.character != null)
            {
                    return this.character.isGrounded;
            }
            
            return this.character.isGrounded;
        }
        public void AddPreMovementUpdateHandler(TzarGames.Common.TG_VoidDelegate handler)
        {
            this.add_onPreMovementUpdate(value:  handler);
        }
        public void RemovePreMovementUpdateHandler(TzarGames.Common.TG_VoidDelegate handler)
        {
            this.remove_onPreMovementUpdate(value:  handler);
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            this.onPreMovementUpdate = 0;
        }
        [TzarGames.Common.ConsoleCommand]
        private static void ToggleLocalPlayerPathFollowingMovementMode()
        {
            UnityEngine.Object val_10;
            bool val_11;
            bool val_12;
            var val_13;
            object val_14;
            val_10 = TzarGames.GameFramework.GameManager.Instance;
            if(0 == val_10)
            {
                goto label_5;
            }
            
            TzarGames.GameFramework.Player val_4 = TzarGames.GameFramework.GameManager.Instance.LocalPlayer;
            val_10 = val_4.PlayerObject;
            TzarGames.GameFramework.CharacterMovementU val_5 = val_10.GetComponentInChildren<TzarGames.GameFramework.CharacterMovementU>();
            if(0 == val_5)
            {
                goto label_13;
            }
            
            if(val_5 == null)
            {
                goto label_14;
            }
            
            val_11 = val_5.bPathFollowingMovementEnabled;
            val_12 = val_5.bPathFollowingMovementEnabled;
            goto label_15;
            label_5:
            val_13 = "Failed to get GameManager instance";
            val_14 = 0;
            goto label_18;
            label_13:
            val_13 = "Failed to find movement component on local player object";
            val_14 = 0;
            label_18:
            UnityEngine.Debug.LogWarning(message:  val_14);
            return;
            label_14:
            val_11 = val_5.bPathFollowingMovementEnabled;
            val_12 = val_5.bPathFollowingMovementEnabled;
            label_15:
            mem2[0] = val_11 ^ 1;
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Path following movement mode toggled to ";
            typeof(System.Object[]).__il2cppRuntimeField_28 = val_12;
            typeof(System.Object[]).__il2cppRuntimeField_29 = 26087423;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " for character";
            typeof(System.Object[]).__il2cppRuntimeField_38 = val_5.name;
            string val_9 = +0;
            UnityEngine.Debug.Log(message:  0);
        }
        public override void OnPulledFromPool()
        {
            this.OnPulledFromPool();
            this.enabled = true;
            this.character.enabled = true;
        }
        public override void OnPushedToPool()
        {
            var val_8;
            this.OnPushedToPool();
            this.enabled = false;
            this.character.enabled = false;
            this.isRayHitGround = false;
            this.bWantsToCrouch = 0;
            this.bPressedJump = false;
            this.bWasJumping = false;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.Acceleration = val_1;
            mem[1152921511285526980] = val_1.y;
            mem[1152921511285526984] = val_1.z;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.velocity = val_2;
            mem[1152921511285526992] = val_2.y;
            mem[1152921511285526996] = val_2.z;
            this.CurrentFloor = 0;
            this.MovementMode = 1;
            this.currentBase = 0;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            val_8 = 0;
            this.PendingLaunchvelocity = val_3;
            mem[1152921511285527092] = val_3.y;
            mem[1152921511285527096] = val_3.z;
            mem[1152921511285527116] = 0;
            mem[1152921511285527108] = 0;
            this.bForceNextFloorCheck = 0;
            this.ClientPredictionData = null;
            goto label_4;
            label_9:
            var val_4 = X23 + (X24 * 48);
            val_8 = 1;
            mem2[0] = 0;
            label_4:
            if(val_8 >= this.proxyStates.Length)
            {
                goto label_6;
            }
            
            if(val_8 < this.proxyStates.Length)
            {
                goto label_9;
            }
            
            goto label_9;
            label_6:
            this.proxyStateCount = 0;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            this.simulatedVelocity = val_5;
            mem[1152921511285527156] = val_5.y;
            mem[1152921511285527160] = val_5.z;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            if(this.rootMovements != null)
            {
                    this.rootMovements.Clear();
            }
            
            this.enableMovement = true;
            this.jumpCurrentCount = 0;
            this.bClientUpdating = false;
            this.overrideMaxSpeed = 4f;
            this.maxSpeedOverrider = 0;
            this.speedModifiers.Clear();
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            mem[1152921511285527320] = val_7.z;
            this.input = val_7;
            mem[1152921511285527316] = val_7.y;
        }
        private static CharacterMovementU()
        {
            TzarGames.GameFramework.CharacterMovementU.MinTimeBetweenTimeStampResets = 240f;
        }
    
    }

}

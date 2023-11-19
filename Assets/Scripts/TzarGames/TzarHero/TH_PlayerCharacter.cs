using UnityEngine;

namespace TzarGames.TzarHero
{
    public class TH_PlayerCharacter : TH_Character, IPlayerComponent
    {
        // Fields
        public TzarGames.TzarHero.TH_ThirdPersonCamera PlayerCamera;
        public UnityEngine.LayerMask RaycastLayers;
        public UnityEngine.GameObject PickObject;
        public UnityEngine.GameObject CharacterPickObject;
        private UnityEngine.Transform currentPickedTarget;
        public TzarGames.CircleToucher circleToucher;
        private UnityEngine.GameObject currentCharacterPickObject;
        private UnityEngine.GameObject currentPickObject;
        private bool isHoldingPosition;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.TzarHero.TH_PlayerCharacter.dlgInteractiveObjectPick OnInteractiveObjectPickedEvent;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.TzarHero.TH_PlayerCharacter.dlgPositionPick OnPositionPickedEvent;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.TzarHero.TH_PlayerCharacter.dlgCharacterPick OnCharacterPickedEvent;
        [UnityEngine.SerializeField]
        private bool pickingEnabled;
        private TzarGames.TzarHero.TH_Character _pickedCharacter;
        private TzarGames.TzarHero.TH_InteractiveObject pickedObject;
        private UnityEngine.Vector3 pickedPosition;
        private TzarGames.TzarHero.PlayerPickTypes currentPickType;
        private TzarGames.TzarHero.PlayerMovementTypes movementType;
        
        // Properties
        public TzarGames.TzarHero.TH_Character PickedCharacter { get; }
        public TzarGames.TzarHero.TH_InteractiveObject PickedObject { get; }
        public UnityEngine.Vector3 PickedPosition { get; }
        public TzarGames.TzarHero.PlayerPickTypes CurrentPickType { get; }
        public UnityEngine.Transform CurrentPickTransform { get; }
        public bool IsHoldingPosition { get; }
        
        // Methods
        public TH_PlayerCharacter()
        {
            this.pickingEnabled = true;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.movementType = 3;
            this.pickedPosition = val_1;
            mem[1152921511602104772] = val_1.y;
            mem[1152921511602104776] = val_1.z;
        }
        protected void add_OnInteractiveObjectPickedEvent(TzarGames.TzarHero.TH_PlayerCharacter.dlgInteractiveObjectPick value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnInteractiveObjectPickedEvent);
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
            while(this.OnInteractiveObjectPickedEvent != this.OnInteractiveObjectPickedEvent);
        
        }
        protected void remove_OnInteractiveObjectPickedEvent(TzarGames.TzarHero.TH_PlayerCharacter.dlgInteractiveObjectPick value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnInteractiveObjectPickedEvent);
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
            while(this.OnInteractiveObjectPickedEvent != this.OnInteractiveObjectPickedEvent);
        
        }
        protected void add_OnPositionPickedEvent(TzarGames.TzarHero.TH_PlayerCharacter.dlgPositionPick value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnPositionPickedEvent);
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
            while(this.OnPositionPickedEvent != this.OnPositionPickedEvent);
        
        }
        protected void remove_OnPositionPickedEvent(TzarGames.TzarHero.TH_PlayerCharacter.dlgPositionPick value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnPositionPickedEvent);
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
            while(this.OnPositionPickedEvent != this.OnPositionPickedEvent);
        
        }
        protected void add_OnCharacterPickedEvent(TzarGames.TzarHero.TH_PlayerCharacter.dlgCharacterPick value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnCharacterPickedEvent);
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
            while(this.OnCharacterPickedEvent != this.OnCharacterPickedEvent);
        
        }
        protected void remove_OnCharacterPickedEvent(TzarGames.TzarHero.TH_PlayerCharacter.dlgCharacterPick value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnCharacterPickedEvent);
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
            while(this.OnCharacterPickedEvent != this.OnCharacterPickedEvent);
        
        }
        public TzarGames.TzarHero.TH_Character get_PickedCharacter()
        {
            return (TzarGames.TzarHero.TH_Character)this._pickedCharacter;
        }
        public TzarGames.TzarHero.TH_InteractiveObject get_PickedObject()
        {
            return (TzarGames.TzarHero.TH_InteractiveObject)this.pickedObject;
        }
        public UnityEngine.Vector3 get_PickedPosition()
        {
            return new UnityEngine.Vector3() {x = this.pickedPosition};
        }
        public TzarGames.TzarHero.PlayerPickTypes get_CurrentPickType()
        {
            return (TzarGames.TzarHero.PlayerPickTypes)this.currentPickType;
        }
        public UnityEngine.Transform get_CurrentPickTransform()
        {
            return (UnityEngine.Transform)this.currentPickedTarget;
        }
        public bool IsMovingToTarget()
        {
            return (bool)(this.movementType != 3) ? 1 : 0;
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            if(0 == this.PlayerCamera)
            {
                    return;
            }
            
            UnityEngine.GameObject val_2 = this.PlayerCamera.gameObject;
            UnityEngine.Object.Destroy(obj:  0);
        }
        protected override void Init()
        {
            var val_16;
            var val_17;
            val_16 = this;
            this.Init();
            if((this.PlayerOwner != null) && (this.PlayerOwner.itsMe != false))
            {
                    val_17 = 1152921504721543168;
                if(0 != this.PickObject)
            {
                    this.currentPickObject = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0);
                this.showPickObject(show:  false);
            }
            
                if(0 != this.CharacterPickObject)
            {
                    this.currentCharacterPickObject = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0);
                this.showCharacterPickObject(show:  false);
            }
            
            }
            
            if(0 == this.PlayerCamera)
            {
                    return;
            }
            
            this.PlayerCamera.transform.parent = 0;
            val_16 = ???;
            val_17 = ???;
            goto typeof(TzarGames.TzarHero.TH_ThirdPersonCamera).__il2cppRuntimeField_150;
        }
        private void setMovementType(TzarGames.TzarHero.PlayerMovementTypes moveType)
        {
            if(this.movementType == moveType)
            {
                    return;
            }
            
            this.movementType = moveType;
        }
        protected override void OnCompleteMovingToPosition()
        {
            this.OnCompleteMovingToPosition();
            if(this.movementType != 3)
            {
                    this.movementType = 3;
            }
            
            this.showPickObject(show:  false);
        }
        protected virtual void OnPickedCharacterDead(TzarGames.TzarHero.DeadEventData character)
        {
            this.showCharacterPickObject(show:  false);
            this.detachCharacterPickObject();
        }
        protected override void OnStateChanged()
        {
            State val_1 = this.CurrentState;
            this.checkPickingEnabledState();
        }
        public void SetHoldPosition(bool hold)
        {
            var val_5;
            bool val_5 = hold;
            var val_1 = (this.isHoldingPosition == true) ? 1 : 0;
            val_1 = val_1 ^ val_5;
            if(val_1 == false)
            {
                    return;
            }
            
            this.isHoldingPosition = val_5;
            if(val_5 != false)
            {
                    this.StopMove();
            }
            
            val_5 = val_5 ^ 1;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_5 = this;
            bool val_4 = val_5;
        }
        public bool get_IsHoldingPosition()
        {
            return (bool)this.isHoldingPosition;
        }
        protected override void TargetObjectReached(TzarGames.TzarHero.TH_InteractiveObject obj)
        {
            System.Delegate val_7;
            mem[1152921511604821961] = 0;
            if(this.movementType != 3)
            {
                    this.movementType = 3;
            }
            
            if(this.OnClient == true)
            {
                    return;
            }
            
            if((this.TakeItem(itemInstance:  0, dropperInfo:  typeof(TzarGames.TzarHero.TH_InteractiveObject).__il2cppRuntimeField_278)) != false)
            {
                    if(DestroyOnPickup != false)
            {
                    obj.DestroySelf();
            }
            
            }
            
            if(this.OnServer == false)
            {
                    return;
            }
            
            TzarGames.GameFramework.RPCall<System.UInt32> val_6 = null;
            val_7 = val_6;
            val_6 = new TzarGames.GameFramework.RPCall<System.UInt32>(object:  this, method:  System.Void TzarGames.TzarHero.TH_PlayerCharacter::client_objectReachedResult(uint id));
            obj.generateId();
            typeof(System.Object[]).__il2cppRuntimeField_20 = obj._id;
            typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
            this.RPC(methodDelegate:  val_7, rpcMode:  2, parameters:  null);
        }
        [TzarRPC]
        private void server_objectReached(uint id)
        {
            object val_9;
            UnityEngine.Object val_10;
            val_9 = this;
            val_10 = TzarGames.TzarHero.TH_InteractiveObject.GetObjectById(id:  317251584);
            if(0 != val_10)
            {
                    if(val_10 == null)
            {
                    return;
            }
            
                if(this.OnServer == false)
            {
                    return;
            }
            
                if((this.TakeItem(itemInstance:  0, dropperInfo:  0)) == false)
            {
                    return;
            }
            
                if(X22.DestroyOnPickup != false)
            {
                    val_10.DestroySelf();
            }
            
                string val_6 = 0 + "Item taken: "("Item taken: ");
                UnityEngine.Debug.Log(message:  0);
                TzarGames.GameFramework.RPCall<System.UInt32> val_7 = null;
                val_10 = val_7;
                val_7 = new TzarGames.GameFramework.RPCall<System.UInt32>(object:  this, method:  System.Void TzarGames.TzarHero.TH_PlayerCharacter::client_objectReachedResult(uint id));
                typeof(System.Object[]).__il2cppRuntimeField_20 = id;
                typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
                this.RPC(methodDelegate:  val_10, rpcMode:  2, parameters:  null);
                return;
            }
            
            val_9 = 0 + "Interactive object not found by id: "("Interactive object not found by id: ");
            UnityEngine.Debug.LogWarning(message:  0);
        }
        [TzarRPC]
        private void client_objectReachedResult(uint id)
        {
            uint val_8 = id;
            TzarGames.TzarHero.TH_InteractiveObject val_1 = TzarGames.TzarHero.TH_InteractiveObject.GetObjectById(id:  317251584);
            if(0 != val_1)
            {
                    if(val_1 == null)
            {
                    return;
            }
            
                if(this.OnClient == false)
            {
                    return;
            }
            
                if((this.TakeItem(itemInstance:  0, dropperInfo:  0)) == false)
            {
                    return;
            }
            
                if(this.DestroyOnPickup != false)
            {
                    val_1.DestroySelf();
            }
            
                val_8 = 0 + "Item taken: "("Item taken: ");
                UnityEngine.Debug.Log(message:  0);
                return;
            }
            
            val_8 = 0 + "Interactive object not found by id: "("Interactive object not found by id: ");
            UnityEngine.Debug.LogWarning(message:  0);
        }
        protected override void OnStopMove()
        {
            this.showPickObject(show:  false);
            if(this.movementType == 3)
            {
                    return;
            }
            
            this.movementType = 3;
        }
        public void EnablePicking(bool enable)
        {
            var val_1 = (this.pickingEnabled == true) ? 1 : 0;
            val_1 = val_1 ^ enable;
            if(val_1 == false)
            {
                    return;
            }
            
            this.pickingEnabled = enable;
            this.checkPickingEnabledState();
        }
        private void checkPickingEnabledState()
        {
            if(this.pickingEnabled != false)
            {
                    return;
            }
            
            this.showPickObject(show:  false);
            this.showCharacterPickObject(show:  false);
        }
        public void HandleClick(float x, float y)
        {
            float val_20;
            float val_21;
            var val_33;
            UnityEngine.Object val_34;
            var val_35;
            if(this.pickingEnabled == false)
            {
                    return;
            }
            
            if(this.pickingEnabled == true)
            {
                    return;
            }
            
            CircleTouchable val_1 = this.circleToucher.CheckPoint(x:  x, y:  y);
            val_33 = 1152921504721543168;
            if(0 == val_1)
            {
                goto label_28;
            }
            
            val_34 = val_1.GetComponent<TzarGames.TzarHero.TH_InteractiveObject>();
            if(0 == val_34)
            {
                goto label_28;
            }
            
            val_33 = val_34.gameObject;
            if(val_33.activeSelf == false)
            {
                goto label_28;
            }
            
            if(val_34.GetType() == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_17;
            }
            
            val_33 = val_34.GetType();
            System.Type val_10 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            if((val_33 & 1) == 0)
            {
                goto label_22;
            }
            
            label_17:
            this.showPickObject(show:  false);
            this.currentPickType = 3;
            if(this.OnCharacterPickedEvent == null)
            {
                goto label_23;
            }
            
            val_35 = 0;
            goto label_26;
            label_22:
            this.currentPickType = 2;
            if(this.OnInteractiveObjectPickedEvent != null)
            {
                    if((this.OnInteractiveObjectPickedEvent.Invoke(interObject:  val_34)) == true)
            {
                goto label_28;
            }
            
            }
            
            if(this.Connected != false)
            {
                    if(this.Connected != false)
            {
                    if(this.OnServer == true)
            {
                goto label_31;
            }
            
            }
            
            }
            
            label_31:
            bool val_17 = this.handleInteractiveObjectPick(obj:  val_34);
            label_28:
            UnityEngine.Ray val_19 = this.PlayerCamera.GetComponent<UnityEngine.Camera>().ScreenPointToRay(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            bool val_22 = this.rayCast(r:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_21, y = val_21, z = val_21}, m_Direction = new UnityEngine.Vector3() {x = val_21, y = val_20, z = val_20}}, mask:  new UnityEngine.LayerMask() {m_Mask = this.RaycastLayers});
            return;
            label_26:
            null = this.OnCharacterPickedEvent.Invoke(character:  null);
            if(null == true)
            {
                    return;
            }
            
            label_23:
            if(this.Connected != false)
            {
                    if((this.Connected == false) || (this.OnServer == false))
            {
                goto label_38;
            }
            
            }
            
            if(val_34 == null)
            {
                goto label_43;
            }
            
            goto label_42;
            label_38:
            if(val_34 == null)
            {
                goto label_43;
            }
            
            label_42:
            label_43:
            val_34 = 0;
            bool val_32 = this.handleCharacterPick(character:  val_34);
        }
        private bool rayCast(UnityEngine.Ray r, UnityEngine.LayerMask mask)
        {
            UnityEngine.Object val_32;
            var val_33;
            GooglePlayGames.BasicApi.ResponseStatus val_1 = mask.m_Mask.Status;
            if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3(), m_Direction = new UnityEngine.Vector3()}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = r.m_Origin.x}, m_Normal = new UnityEngine.Vector3() {y = r.m_Direction.y}, m_UV = new UnityEngine.Vector2() {x = r.m_Origin.x}}, maxDistance:  999f, layerMask:  -1590911576)) == false)
            {
                goto label_8;
            }
            
            if(0 == 0)
            {
                goto label_8;
            }
            
            if(0 == 0.gameObject)
            {
                goto label_8;
            }
            
            val_32 = 0.gameObject.GetComponent<TzarGames.TzarHero.TH_InteractiveObject>();
            if((0 == val_32) || (val_32.gameObject.activeSelf == false))
            {
                goto label_16;
            }
            
            if(val_32.GetType() != (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                    System.Type val_14 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
                if((val_32.GetType() & 1) == 0)
            {
                    return false;
            }
            
            }
            
            this.showPickObject(show:  false);
            this.currentPickType = 3;
            if(this.OnCharacterPickedEvent == null)
            {
                goto label_26;
            }
            
            val_33 = 0;
            goto label_29;
            label_8:
            this.currentPickType = 0;
            return false;
            label_16:
            this.showCharacterPickObject(show:  false);
            if(0 != this._pickedCharacter)
            {
                    typeof(TH_Character.dlgDeadEvent).__il2cppRuntimeField_20 = this;
                typeof(TH_Character.dlgDeadEvent).__il2cppRuntimeField_28 = typeof(TzarGames.TzarHero.TH_PlayerCharacter).__il2cppRuntimeField_518;
                typeof(TH_Character.dlgDeadEvent).__il2cppRuntimeField_10 = typeof(TzarGames.TzarHero.TH_PlayerCharacter).__il2cppRuntimeField_518;
                this._pickedCharacter.remove_OnCharacterDead(value:  null);
                this._pickedCharacter = 0;
            }
            
            this.currentPickType = 1;
            this.pickedPosition = 999f;
            mem[1152921511605882964] = ???;
            mem[1152921511605882968] = ???;
            if(this.OnPositionPickedEvent != null)
            {
                    if((this.OnPositionPickedEvent.Invoke(position:  new UnityEngine.Vector3() {x = 999f})) == true)
            {
                    return false;
            }
            
            }
            
            this.setPickObjectLocation(loc:  new UnityEngine.Vector3() {x = 999f});
            if(this.Connected != false)
            {
                    if(this.Connected != false)
            {
                    bool val_20 = this.OnServer;
            }
            
            }
            
            bool val_21 = this.handlePositionPick(pos:  new UnityEngine.Vector3() {x = 999f});
            return false;
            label_29:
            null = this.OnCharacterPickedEvent.Invoke(character:  null);
            if(null == true)
            {
                    return false;
            }
            
            label_26:
            if(this.Connected != false)
            {
                    if((this.Connected == false) || (this.OnServer == false))
            {
                goto label_43;
            }
            
            }
            
            if(val_32 == null)
            {
                goto label_48;
            }
            
            goto label_47;
            label_43:
            if(val_32 == null)
            {
                goto label_48;
            }
            
            label_47:
            label_48:
            val_32 = 0;
            bool val_31 = this.handleCharacterPick(character:  val_32);
            return false;
        }
        private void showPickObject(bool show)
        {
            if(0 == this.currentPickObject)
            {
                    return;
            }
            
            this.currentPickObject.SetActive(value:  show);
        }
        private void showCharacterPickObject(bool show)
        {
            if(0 == this.currentCharacterPickObject)
            {
                    return;
            }
            
            this.currentCharacterPickObject.SetActive(value:  show);
        }
        private void attachCharacterPickObjectTo(TzarGames.TzarHero.TH_InteractiveObject obj)
        {
            UnityEngine.GameObject val_12 = this.currentCharacterPickObject;
            if(0 == val_12)
            {
                    return;
            }
            
            if(0 != (this.currentCharacterPickObject.GetComponent<FollowGameObject>()))
            {
                    val_2.objectToFollow = obj.gameObject.transform;
                UnityEngine.Vector3 val_6 = obj.GroundPivotPosition;
                UnityEngine.Vector3 val_7 = obj.cachedTransform.position;
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
                val_2.displacement = val_8;
                mem2[0] = val_8.y;
                mem2[0] = val_8.z;
            }
            else
            {
                    UnityEngine.Debug.LogWarning(message:  0);
            }
            
            val_12 = this.currentCharacterPickObject.transform;
            UnityEngine.Vector3 val_10 = obj.GroundPivotPosition;
            val_12.position = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            this.currentPickedTarget = this.currentCharacterPickObject.transform;
        }
        private void detachCharacterPickObject()
        {
            if(0 == this.currentCharacterPickObject)
            {
                    return;
            }
            
            this.currentCharacterPickObject.transform.parent = 0;
        }
        private void setPickObjectLocation(UnityEngine.Vector3 loc)
        {
            if(0 != this.currentPickObject)
            {
                    this.currentPickObject.transform.position = new UnityEngine.Vector3() {x = loc.x, y = loc.y, z = loc.z};
            }
            
            this.currentPickedTarget = this.currentPickObject.transform;
        }
        private bool handlePositionPick(UnityEngine.Vector3 pos)
        {
            var val_5;
            this.StopAttack();
            this.StopFollow();
            this.currentPickType = 1;
            if(this.isHoldingPosition != false)
            {
                    val_5 = 0;
            }
            else
            {
                    val_5 = 1;
            }
            
            this.showPickObject(show:  true);
            if((this.CurrentState.CanBeInterruptedBy<PrepareToGoPosition>()) != true)
            {
                    if(this.isHoldingPosition == false)
            {
                goto label_5;
            }
            
            }
            
            bool val_4 = this.GoToPosition(targetPosition:  new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z}, reachPositionHandler:  0, stoppingDistance:  null);
            return true;
            label_5:
            this.GotoStateAfterAttack<PrepareToGoPosition>();
            return true;
        }
        private bool handleCharacterPick(TzarGames.TzarHero.TH_Character character)
        {
            var val_6;
            var val_7;
            if(character._characterIsDead == true)
            {
                goto label_2;
            }
            
            val_6 = 1152921504721543168;
            if(0 != character)
            {
                goto label_5;
            }
            
            label_2:
            val_7 = 0;
            return (bool)val_7;
            label_5:
            this.attachCharacterPickObjectTo(obj:  character);
            this.showCharacterPickObject(show:  true);
            if(0 != this._pickedCharacter)
            {
                    typeof(TH_Character.dlgDeadEvent).__il2cppRuntimeField_20 = this;
                typeof(TH_Character.dlgDeadEvent).__il2cppRuntimeField_28 = typeof(TzarGames.TzarHero.TH_PlayerCharacter).__il2cppRuntimeField_518;
                typeof(TH_Character.dlgDeadEvent).__il2cppRuntimeField_10 = typeof(TzarGames.TzarHero.TH_PlayerCharacter).__il2cppRuntimeField_518;
                this._pickedCharacter.remove_OnCharacterDead(value:  null);
            }
            
            this.currentPickType = 3;
            this._pickedCharacter = character;
            typeof(TH_Character.dlgDeadEvent).__il2cppRuntimeField_20 = this;
            typeof(TH_Character.dlgDeadEvent).__il2cppRuntimeField_28 = typeof(TzarGames.TzarHero.TH_PlayerCharacter).__il2cppRuntimeField_518;
            typeof(TH_Character.dlgDeadEvent).__il2cppRuntimeField_10 = typeof(TzarGames.TzarHero.TH_PlayerCharacter).__il2cppRuntimeField_518;
            character.add_OnCharacterDead(value:  null);
            UnityEngine.Vector3 val_5 = this._pickedCharacter.position;
            mem[1152921511606940552] = val_5.z;
            this.pickedPosition = val_5;
            mem[1152921511606940548] = val_5.y;
            val_7 = 1;
            return (bool)val_7;
        }
        private bool handleInteractiveObjectPick(TzarGames.TzarHero.TH_InteractiveObject obj)
        {
            this.currentPickType = 2;
            this.pickedObject = obj;
            UnityEngine.Vector3 val_1 = obj.cachedTransform.position;
            mem[1152921511607077128] = val_1.z;
            this.pickedPosition = val_1;
            mem[1152921511607077124] = val_1.y;
            return true;
        }
        protected virtual void OnPositionPick(UnityEngine.Vector3 position)
        {
        
        }
        protected virtual void OnCharacterPick(TzarGames.TzarHero.TH_Character character)
        {
        
        }
        protected virtual void OnInteractiveObjectPick(TzarGames.TzarHero.TH_InteractiveObject obj)
        {
        
        }
        public virtual void SetupForServer(TzarGames.GameFramework.Player owner)
        {
            string val_1 = owner.Login;
            string val_2 = 0 + "Setup for server, owner - "("Setup for server, owner - ");
            UnityEngine.Debug.Log(message:  0);
            goto typeof(TzarGames.TzarHero.TH_PlayerCharacter).__il2cppRuntimeField_190;
        }
        public virtual void SetupForLocalOrClient(TzarGames.GameFramework.Player owner)
        {
            string val_1 = owner.Login;
            string val_2 = 0 + "Setup for client, owner - "("Setup for client, owner - ");
            UnityEngine.Debug.Log(message:  0);
            goto typeof(TzarGames.TzarHero.TH_PlayerCharacter).__il2cppRuntimeField_190;
        }
        public virtual void SetPlayerData(object data)
        {
        
        }
        public virtual object GetPlayerData()
        {
            return 0;
        }
        public override void SetPlayerOwner(TzarGames.GameFramework.Player owner)
        {
            string val_9;
            this.SetPlayerOwner(player:  owner);
            if((owner != null) && (owner.itsMe != false))
            {
                    if(this.OnServer != false)
            {
                    mem[1152921511608087828] = 0;
            }
            
                val_9 = 0 + this.gameObject.name;
                this.gameObject.name = val_9;
            }
            else
            {
                    val_9 = 1152921504721543168;
                if(0 != this.PlayerCamera)
            {
                    UnityEngine.GameObject val_8 = this.PlayerCamera.gameObject;
                UnityEngine.Object.Destroy(obj:  0);
            }
            
            }
            
            this.SetNetworkInstantiatedFlag(netInstantiated:  true);
        }
        public virtual void SetActive(bool active)
        {
        
        }
        public virtual void Respawn(UnityEngine.Vector3 spawnPosition, UnityEngine.Quaternion spawnRotation)
        {
            var val_4;
            float val_6;
            this.ResetToDefaultState();
            if(X20 != 0)
            {
                    val_6 = X20.HitPoints;
            }
            else
            {
                    val_6 = 0.HitPoints;
                val_4 = 0;
            }
            
            val_4.ActualHitPoints = val_6;
            this.Position = new UnityEngine.Vector3() {x = spawnPosition.x, y = spawnPosition.y, z = spawnPosition.z};
            this.transform.rotation = new UnityEngine.Quaternion() {x = spawnRotation.x, y = spawnRotation.y, z = spawnRotation.z, w = spawnRotation.w};
        }
        public byte[] GetPlayerDataAsBytes()
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        public void SetPlayerDataFromBytes(byte[] data)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
    
    }

}

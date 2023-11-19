using UnityEngine;

namespace TzarGames.TzarHero
{
    public abstract class TH_InteractiveObject : TzarBehaviour
    {
        // Fields
        private uint _id;
        private UnityEngine.Vector2 position2d;
        [UnityEngine.SerializeField]
        private UnityEngine.Vector3 groundPivotDisplacement;
        [UnityEngine.SerializeField]
        private float attackHeightOffset;
        [UnityEngine.SerializeField]
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredBool authoritative;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredBool authoritative_runtime;
        private static System.Collections.Generic.Dictionary<uint, TzarGames.TzarHero.TH_InteractiveObject> idToObjs;
        private static uint id_counter;
        private bool isSpawnedLocally;
        protected UnityEngine.Transform cachedTransform;
        [UnityEngine.SerializeField]
        private UnityEngine.LayerMask traceCollideLayer;
        [UnityEngine.SerializeField]
        private UnityEngine.QueryTriggerInteraction traceTriggerInteraction;
        [UnityEngine.SerializeField]
        private bool syncData;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.TzarHero.TH_InteractiveObject.InteractiveObjectDelegate OnObjectDestroy;
        public const uint UnassignedId = 0;
        private bool initProcessed;
        private string pendingDataToApply;
        
        // Properties
        public bool Authoritative { get; set; }
        public bool IsSpawnedLocally { get; }
        public uint Id { get; set; }
        public UnityEngine.Vector3 GroundPivotPosition { get; }
        public float AttackHeightOffset { get; }
        public UnityEngine.Vector3 Position { get; set; }
        public UnityEngine.Vector3 ForwardDirection { get; }
        public UnityEngine.Vector2 Position2D { get; }
        
        // Methods
        protected TH_InteractiveObject()
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            this.position2d = val_1;
            mem[1152921511595291240] = val_1.y;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.groundPivotDisplacement = val_2;
            mem[1152921511595291248] = val_2.y;
            this.attackHeightOffset = 1.4f;
            mem[1152921511595291252] = val_2.z;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            this.authoritative = val_3;
            mem[1152921511595291268] = val_3.inited;
            mem[1152921511595291269] = val_3.fakeValue;
            mem[1152921511595291270] = val_3.fakeValueActive;
            UnityEngine.LayerMask val_4 = UnityEngine.LayerMask.op_Implicit(intVal:  0);
            this.traceCollideLayer = val_4;
            this.syncData = true;
        }
        public bool get_Authoritative()
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {inited = this.authoritative_runtime, fakeValue = this.authoritative_runtime, fakeValueActive = this.authoritative_runtime});
        }
        public void set_Authoritative(bool value)
        {
            value = value;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            this.authoritative_runtime = val_1;
            mem[1152921511595515280] = val_1.inited;
            mem[1152921511595515281] = val_1.fakeValue;
            mem[1152921511595515282] = val_1.fakeValueActive;
        }
        public void add_OnObjectDestroy(TzarGames.TzarHero.TH_InteractiveObject.InteractiveObjectDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnObjectDestroy);
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
            while(1152921511595639600 != this.OnObjectDestroy);
        
        }
        public void remove_OnObjectDestroy(TzarGames.TzarHero.TH_InteractiveObject.InteractiveObjectDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnObjectDestroy);
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
            while(1152921511595776176 != this.OnObjectDestroy);
        
        }
        public void SetSpawnedLocallyFlag(bool local)
        {
            this.isSpawnedLocally = local;
        }
        public bool get_IsSpawnedLocally()
        {
            return (bool)this.isSpawnedLocally;
        }
        public static bool IsIdUnassigned(uint id)
        {
            return (bool)(W1 == 0) ? 1 : 0;
        }
        private void generateId()
        {
            TzarGames.TzarHero.TH_InteractiveObject val_4;
            var val_5;
            var val_6;
            var val_7;
            val_4 = this;
            if(this._id != 0)
            {
                    return;
            }
            
            if(this.OnClient == true)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            if((TzarGames.TzarHero.TH_InteractiveObject.UnassignedId.ContainsKey(key:  TzarGames.TzarHero.TH_InteractiveObject.id_counter)) != false)
            {
                    val_6 = null;
                val_4 = null;
                val_6 = null;
                typeof(System.Object[]).__il2cppRuntimeField_20 = TzarGames.TzarHero.TH_InteractiveObject.id_counter;
                typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
                UnityEngine.Debug.LogErrorFormat(format:  0, args:  "Id {0} is already in list");
                return;
            }
            
            val_7 = null;
            val_7 = null;
            this._id = TzarGames.TzarHero.TH_InteractiveObject.id_counter;
            uint val_4 = TzarGames.TzarHero.TH_InteractiveObject.id_counter;
            val_4 = val_4 + 1;
            TzarGames.TzarHero.TH_InteractiveObject.id_counter = val_4;
            TzarGames.TzarHero.TH_InteractiveObject.UnassignedId.Add(key:  this._id, value:  this);
        }
        public uint get_Id()
        {
            this.generateId();
            return (uint)this._id;
        }
        public void set_Id(uint value)
        {
            uint val_9;
            uint val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_15;
            var val_16;
            val_9 = value;
            val_10 = this._id;
            if(val_10 == val_9)
            {
                    return;
            }
            
            if(val_9 == 0)
            {
                goto label_2;
            }
            
            val_11 = null;
            val_11 = null;
            if((TzarGames.TzarHero.TH_InteractiveObject.UnassignedId.ContainsKey(key:  val_9)) == false)
            {
                goto label_6;
            }
            
            if(this.OnClient == false)
            {
                goto label_7;
            }
            
            val_12 = null;
            val_12 = null;
            TzarGames.TzarHero.TH_InteractiveObject val_3 = TzarGames.TzarHero.TH_InteractiveObject.UnassignedId.Item[val_9];
            bool val_4 = TzarGames.TzarHero.TH_InteractiveObject.UnassignedId.Remove(key:  val_9);
            val_3._id = 0;
            label_6:
            val_13 = null;
            val_13 = null;
            val_10 = TzarGames.TzarHero.TH_InteractiveObject.UnassignedId;
            val_10.Add(key:  val_9, value:  this);
            this._id = val_9;
            if(TzarGames.TzarHero.TH_InteractiveObject.id_counter > val_9)
            {
                    return;
            }
            
            TzarGames.TzarHero.TH_InteractiveObject.id_counter = val_9 + 1;
            return;
            label_2:
            if(val_10 != 0)
            {
                    val_15 = null;
                val_15 = null;
                val_10 = this._id;
                val_9 = TzarGames.TzarHero.TH_InteractiveObject.UnassignedId;
                bool val_6 = val_9.Remove(key:  val_10);
            }
            
            this._id = 0;
            return;
            label_7:
            typeof(System.Object[]).__il2cppRuntimeField_20 = "This id already exist: ";
            typeof(System.Object[]).__il2cppRuntimeField_28 = val_9;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " and used by ";
            val_16 = null;
            val_16 = null;
            val_10 = TzarGames.TzarHero.TH_InteractiveObject.UnassignedId;
            typeof(System.Object[]).__il2cppRuntimeField_38 = val_10.Item[val_9];
            val_9 = +0;
            UnityEngine.Debug.LogError(message:  0);
        }
        protected override void Awake()
        {
            this.Awake();
            this.authoritative_runtime = this.authoritative;
            mem[1152921511596621936] = ???;
            this.cachedTransform = this.transform;
            this.generateId();
        }
        protected virtual void Start()
        {
            if(this.syncData != false)
            {
                    this.sendInfo();
            }
            
            if(this.OnServer == false)
            {
                goto label_2;
            }
            
            if(this.IsNetworkInstantiated == true)
            {
                goto label_9;
            }
            
            TzarGames.GameFramework.Player val_5 = TzarGames.GameFramework.GameManager.Instance.LocalPlayer;
            goto label_7;
            label_2:
            if((this.OnClient == false) || (this.IsNetworkInstantiated == true))
            {
                goto label_9;
            }
            
            label_7:
            this.SetPlayerOwner(player:  TzarGames.GameFramework.GameManager.Instance.Net.ServerPlayer);
            label_9:
            this.initProcessed = true;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                    return;
            }
            
            this.client_info(info:  this.pendingDataToApply);
            this.pendingDataToApply = 0;
        }
        protected virtual void Init()
        {
        
        }
        public static TzarGames.TzarHero.TH_InteractiveObject GetObjectById(uint id)
        {
            var val_4;
            TzarGames.TzarHero.TH_InteractiveObject val_1 = 0;
            val_4 = null;
            val_4 = null;
            return (TzarGames.TzarHero.TH_InteractiveObject)((TzarGames.TzarHero.TH_InteractiveObject.UnassignedId.TryGetValue(key:  W1, value: out  val_1)) != true) ? (val_1) : 0;
        }
        protected bool checkClientAuthority()
        {
            var val_5;
            TzarGames.GameFramework.Player val_1 = this.PlayerOwner;
            if((val_1 != null) && (val_1.itsMe != false))
            {
                    if(this.Authoritative != false)
            {
                    val_5 = 0;
                return (bool)val_5;
            }
            
            }
            
            val_5 = 1;
            return (bool)val_5;
        }
        protected virtual void CollectObjectInfo(System.Collections.Generic.Dictionary<string, string> data)
        {
            this.generateId();
            data.set_Item(key:  "id", value:  this._id);
        }
        protected virtual void ApplyObjectInfo(System.Collections.Generic.Dictionary<string, string> data)
        {
            this.generateId();
            if(this._id != 0)
            {
                    this.Id = 0;
            }
            
            string val_1 = data.Item["id"];
            this.Id = System.UInt32.Parse(s:  0);
        }
        private void sendInfo()
        {
            if(0 == this.MyNetworkView)
            {
                    return;
            }
            
            if(0 == this.MyGameManager)
            {
                    return;
            }
            
            if(0 == this.MyGameManager.Net)
            {
                    return;
            }
            
            this.DynamicBufferedRPC(methodDelegate:  new TzarGames.GameFramework.RPCall<System.String>(object:  this, method:  System.Void TzarGames.TzarHero.TH_InteractiveObject::client_info(string info)), sessionID:  -1599288160, getParamFunc:  new GameManager.dlgGetParameters(object:  this, method:  System.Object[] TzarGames.TzarHero.TH_InteractiveObject::getEncodedInfo()));
        }
        private object[] getEncodedInfo()
        {
            System.Collections.Generic.Dictionary<System.String, System.String> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            typeof(System.Object[]).__il2cppRuntimeField_20 = TzarGames.TzarHero.TH_InteractiveObject.encode(data:  null);
            return (System.Object[])null;
        }
        [TzarRPC]
        protected void client_info(string info)
        {
            var val_9;
            var val_10;
            var val_11;
            val_10 = info;
            val_11 = this;
            if(this.checkClientAuthority() == false)
            {
                    return;
            }
            
            if(this.initProcessed != false)
            {
                    System.Collections.Generic.Dictionary<System.String, System.String> val_2 = TzarGames.TzarHero.TH_InteractiveObject.decode(json:  null);
                val_10 = ???;
                val_11 = ???;
                val_9 = ???;
            }
            else
            {
                    mem2[0] = val_10;
            }
        
        }
        protected static string encode(System.Collections.Generic.Dictionary<string, string> data)
        {
            TH_InteractiveObject.EncodedData val_1 = new TH_InteractiveObject.EncodedData();
            Dictionary.Enumerator<TKey, TValue> val_2 = X1.GetEnumerator();
            label_5:
            if((0 & 1) == 0)
            {
                goto label_8;
            }
            
            UnityEngine.Playables.PlayableHandle val_3 = 0.GetHandle();
            object val_5 = new System.Object();
            typeof(TH_InteractiveObject.StringPair).__il2cppRuntimeField_10 = val_3.m_Handle.InitializationCallback;
            typeof(TH_InteractiveObject.StringPair).__il2cppRuntimeField_18 = ;
            Add(item:  null);
            goto label_5;
            label_8:
            0.Dispose();
            return (string)UnityEngine.JsonUtility.ToJson(obj:  0);
        }
        protected static System.Collections.Generic.Dictionary<string, string> decode(string json)
        {
            var val_5;
            string val_7;
            var val_8;
            T val_9;
            EncodedData val_2 = UnityEngine.JsonUtility.FromJson<EncodedData>(json:  0);
            List.Enumerator<T> val_3 = val_2.Data.GetEnumerator();
            goto label_3;
            label_7:
            val_7 = val_5.InitializationCallback;
            Add(key:  11993091, value:  val_7);
            label_3:
            if((0 & 1) != 0)
            {
                goto label_7;
            }
            
            val_8 = 0;
            val_9 = 87;
            val_5.Dispose();
            if( == 87)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.String>)new System.Collections.Generic.Dictionary<System.String, System.String>();
            }
            
            if( == 0)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.String>)new System.Collections.Generic.Dictionary<System.String, System.String>();
            }
            
            return (System.Collections.Generic.Dictionary<System.String, System.String>)new System.Collections.Generic.Dictionary<System.String, System.String>();
        }
        public abstract float GetRadius(); // 0
        public UnityEngine.Vector3 get_GroundPivotPosition()
        {
            UnityEngine.Vector3 val_1 = this.cachedTransform.position;
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.groundPivotDisplacement, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
        public float get_AttackHeightOffset()
        {
            return (float)this.attackHeightOffset;
        }
        public UnityEngine.Vector3 GetGroundPivotDisplacement()
        {
            return new UnityEngine.Vector3() {x = this.groundPivotDisplacement};
        }
        public UnityEngine.Vector3 get_Position()
        {
            if(this.cachedTransform != null)
            {
                    return this.cachedTransform.position;
            }
            
            return this.cachedTransform.position;
        }
        public void set_Position(UnityEngine.Vector3 value)
        {
            this.cachedTransform.position = new UnityEngine.Vector3() {x = value.x, y = value.y, z = value.z};
            goto typeof(TzarGames.TzarHero.TH_InteractiveObject).__il2cppRuntimeField_230;
        }
        public UnityEngine.Vector3 get_ForwardDirection()
        {
            if(this.cachedTransform != null)
            {
                    return this.cachedTransform.forward;
            }
            
            return this.cachedTransform.forward;
        }
        public UnityEngine.Vector2 get_Position2D()
        {
            UnityEngine.Vector3 val_1 = this.cachedTransform.position;
            this.position2d = val_1.x;
            mem[1152921511598892872] = val_1.z;
            return new UnityEngine.Vector2() {x = val_1.x, y = val_1.z};
        }
        protected virtual void OnSetPosition(UnityEngine.Vector3 position)
        {
        
        }
        protected virtual void Reset()
        {
        
        }
        protected virtual void OnEnable()
        {
        
        }
        protected virtual void OnDisable()
        {
        
        }
        protected override void OnDestroy()
        {
            var val_3;
            this.OnDestroy();
            val_3 = null;
            val_3 = null;
            bool val_1 = TzarGames.TzarHero.TH_InteractiveObject.UnassignedId.Remove(key:  this._id);
            this.RemoveCustomBufferedRPC(methodDelegate:  new TzarGames.GameFramework.RPCall<System.String>(object:  this, method:  System.Void TzarGames.TzarHero.TH_InteractiveObject::client_info(string info)));
            if(this.OnObjectDestroy == null)
            {
                    return;
            }
            
            this.OnObjectDestroy.Invoke(obj:  this);
        }
        protected void InteractWith(TzarGames.TzarHero.TH_InteractiveObject obj)
        {
            if(obj == null)
            {
                
            }
        
        }
        protected virtual void Interact(TzarGames.TzarHero.TH_InteractiveObject other)
        {
        
        }
        public static bool IsObjectsTouching(TzarGames.TzarHero.TH_InteractiveObject firstObject, TzarGames.TzarHero.TH_InteractiveObject secondObject, float allowedDistanceError = 0)
        {
            var val_11;
            float val_12;
            var val_13;
            val_11 = X2;
            UnityEngine.Vector2 val_2 = secondObject.Position2D;
            float val_3 = (allowedDistanceError + allowedDistanceError) + allowedDistanceError;
            UnityEngine.Vector2 val_4 = val_11.Position2D;
            val_12 = val_4.x;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, b:  new UnityEngine.Vector2() {x = val_12, y = val_4.y});
            if(val_5.x.sqrMagnitude > (val_3 * val_3))
            {
                goto label_6;
            }
            
            UnityEngine.Vector3 val_8 = secondObject.cachedTransform.position;
            val_12 = val_8.y;
            val_11 = mem[X2 + 152];
            val_11 = X2 + 152;
            UnityEngine.Vector3 val_9 = val_11.position;
            if((System.Math.Abs(val_12 - val_9.y)) <= val_3)
            {
                goto label_13;
            }
            
            label_6:
            val_13 = 0;
            return (bool)val_13;
            label_13:
            val_13 = 1;
            return (bool)val_13;
        }
        public bool IsObjectInRadius(TzarGames.TzarHero.TH_InteractiveObject obj, float radius)
        {
            UnityEngine.Vector3 val_1 = obj.GroundPivotPosition;
            UnityEngine.Vector3 val_2 = this.GroundPivotPosition;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            val_3.x = val_3.x - val_3.x;
            return (bool)(val_3.x <= radius) ? 1 : 0;
        }
        protected bool IsSelfPositionValid()
        {
            var val_7;
            var val_8;
            val_7 = this;
            UnityEngine.Vector3 val_1 = this.cachedTransform.position;
            float val_7 = val_1.y;
            val_1.x = val_1.x + 0.25f;
            val_7 = val_7 + val_1.x;
            if(val_2.Length < 1)
            {
                goto label_3;
            }
            
            if(val_2.Length != 1)
            {
                goto label_8;
            }
            
            val_7 = this.gameObject.GetComponent<UnityEngine.Collider>();
            if(0 != (UnityEngine.Physics.OverlapSphere(position:  new UnityEngine.Vector3() {x = val_1.x, y = val_7, z = val_1.z}, radius:  val_1.x)[0]))
            {
                goto label_8;
            }
            
            label_3:
            val_8 = 1;
            return (bool)val_8;
            label_8:
            val_8 = 0;
            return (bool)val_8;
        }
        public bool IsSphereContainsOtherColliders(UnityEngine.Vector3 center, float radius, int layerMask = 2147483647)
        {
            var val_6;
            var val_7;
            val_6 = this;
            if(val_1.Length < 1)
            {
                goto label_2;
            }
            
            if(val_1.Length != 1)
            {
                goto label_7;
            }
            
            val_6 = this.gameObject;
            if(0 != (UnityEngine.Physics.OverlapSphere(position:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, radius:  radius, layerMask:  0, queryTriggerInteraction:  layerMask)[0].gameObject))
            {
                goto label_7;
            }
            
            label_2:
            val_7 = 0;
            return (bool)val_7;
            label_7:
            val_7 = 1;
            return (bool)val_7;
        }
        public bool TryGetFreePositionNearObject(TzarGames.TzarHero.TH_InteractiveObject interObject, out UnityEngine.Vector3 result, float offset = 0, int numberOfChecks = 1, float angleStep = 30)
        {
            return TzarGames.TzarHero.TH_InteractiveObject.TryGetFreePositionForObject(sourceObject:  null, target:  this, result: out  new UnityEngine.Vector3() {x = interObject, y = interObject, z = interObject}, offset:  offset, numberOfChecks:  -1596225088, angleStep:  angleStep);
        }
        public static bool TryGetFreePositionForObject(TzarGames.TzarHero.TH_InteractiveObject sourceObject, TzarGames.TzarHero.TH_InteractiveObject target, out UnityEngine.Vector3 result, float offset = 0, int numberOfChecks = 1, float angleStep = 30)
        {
            UnityEngine.QueryTriggerInteraction val_29;
            float val_30;
            float val_31;
            float val_32;
            float val_33;
            float val_34;
            float val_35;
            float val_36;
            var val_37;
            UnityEngine.Vector3 val_1 = target.cachedTransform.position;
            val_29 = mem[1152921511600746408];
            val_30 = val_1.x;
            val_31 = val_1.y;
            UnityEngine.Vector3 val_2 = val_29.position;
            val_32 = val_2.x;
            val_33 = val_2.z;
            val_34 = val_30;
            val_35 = val_31;
            val_36 = val_1.z;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_34, y = val_35, z = val_36}, b:  new UnityEngine.Vector3() {x = val_32, y = val_2.y, z = val_33});
            if(W4 < 1)
            {
                goto label_7;
            }
            
            float val_28 = offset;
            float val_5 = offset + val_28;
            val_28 = (offset + offset) + val_28;
            float val_29 = 360f;
            val_36 = val_28 * 3.141593f;
            val_5 = val_36 / val_5;
            val_35 = (float)(int)val_5;
            val_29 = val_29 / val_35;
            val_34 = offset + offset;
            var val_31 = 0;
            label_22:
            if((int)val_5 < (1.401298E-45f))
            {
                goto label_8;
            }
            
            var val_30 = 0;
            float val_6 = 0f * angleStep;
            label_21:
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.up;
            UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.AngleAxis(angle:  val_6, axis:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            UnityEngine.Vector3 val_9 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w}, point:  new UnityEngine.Vector3() {x = val_3.x, y = 0f, z = val_3.z});
            mem2[0] = val_9.x;
            mem2[0] = val_9.y;
            mem2[0] = val_9.z;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(d:  val_28, a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            UnityEngine.Vector3 val_11 = result.x.GroundPivotPosition;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, d:  offset);
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            mem2[0] = val_15.x;
            mem2[0] = val_15.y;
            mem2[0] = val_15.z;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.forward;
            val_30 = val_16.x;
            val_31 = val_16.z;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, d:  offset);
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = numberOfChecks, y = numberOfChecks + 4, z = numberOfChecks + 8}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            val_32 = val_18.y;
            val_33 = val_18.z;
            if(target != null)
            {
                    val_29 = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask());
            }
            else
            {
                    val_29 = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask());
            }
            
            val_35 = val_32;
            val_36 = val_33;
            if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_18.x, y = val_35, z = val_36}, direction:  new UnityEngine.Vector3() {x = val_30, y = val_16.y, z = val_31}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3(), m_Normal = new UnityEngine.Vector3(), m_UV = new UnityEngine.Vector2()}, maxDistance:  val_34, layerMask:  -1596087728, queryTriggerInteraction:  val_29)) == false)
            {
                goto label_20;
            }
            
            val_29 = 0.Payload.gameObject;
            UnityEngine.GameObject val_24 = target.gameObject;
            if(0 == val_29)
            {
                goto label_20;
            }
            
            val_34 = val_29;
            val_30 = val_30 + 1;
            val_6 = val_34 + val_6;
            if(val_30 < (int)val_5)
            {
                goto label_21;
            }
            
            label_8:
            val_31 = val_31 + 1;
            if(val_31 < W4)
            {
                goto label_22;
            }
            
            label_7:
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.zero;
            val_37 = 0;
            mem2[0] = val_27.x;
            mem2[0] = val_27.y;
            mem2[0] = val_27.z;
            return (bool)val_37;
            label_20:
            val_37 = 1;
            return (bool)val_37;
        }
        protected UnityEngine.Vector3 GetPositionNearObject(TzarGames.TzarHero.TH_InteractiveObject interObject, float offset = 0)
        {
            float val_10 = offset;
            val_10 = offset + val_10;
            UnityEngine.Vector3 val_1 = this.cachedTransform.position;
            val_10 = offset + val_10;
            UnityEngine.Vector3 val_2 = interObject.cachedTransform.position;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(d:  val_10, a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Vector3 val_5 = interObject.GroundPivotPosition;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  val_10);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            return new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        }
        public override void OnPulledFromPool()
        {
            this.OnPulledFromPool();
            this.generateId();
        }
        public override void OnPushedToPool()
        {
            var val_3;
            this.OnPushedToPool();
            mem[1152921511601136400] = ???;
            this.authoritative_runtime = this.authoritative;
            val_3 = null;
            val_3 = null;
            bool val_1 = TzarGames.TzarHero.TH_InteractiveObject.UnassignedId.Remove(key:  this._id);
            this.RemoveCustomBufferedRPC(methodDelegate:  new TzarGames.GameFramework.RPCall<System.String>(object:  this, method:  System.Void TzarGames.TzarHero.TH_InteractiveObject::client_info(string info)));
            if(this.OnObjectDestroy == null)
            {
                    return;
            }
            
            this.OnObjectDestroy.Invoke(obj:  this);
        }
        private static TH_InteractiveObject()
        {
            TzarGames.TzarHero.TH_InteractiveObject.UnassignedId = new System.Collections.Generic.Dictionary<System.UInt32, TzarGames.TzarHero.TH_InteractiveObject>();
            TzarGames.TzarHero.TH_InteractiveObject.UnassignedId.__il2cppRuntimeField_3 = 268435456;
            TzarGames.TzarHero.TH_InteractiveObject.id_counter = 1;
        }
    
    }

}

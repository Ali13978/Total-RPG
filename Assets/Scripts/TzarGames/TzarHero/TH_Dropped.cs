using UnityEngine;

namespace TzarGames.TzarHero
{
    public class TH_Dropped : TH_InteractiveObject, IPoolable
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Item item;
        private TzarGames.GameFramework.ItemInstance itemInstance;
        private bool notifiedByDropper;
        private bool isPickedUp;
        private System.Collections.Generic.List<UnityEngine.Collider> triggeredList;
        private UnityEngine.Coroutine triggeredCheckRoutine;
        [UnityEngine.SerializeField]
        private string[] tags;
        [UnityEngine.SerializeField]
        private float radius;
        [UnityEngine.SerializeField]
        private UnityEngine.Vector3 spawnOffset;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Events.ItemTakeEvent onItemTaken;
        private const string ITEM_INSTANCE_KEY = "THDRP_ITEMID";
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private ulong <DropperID>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private uint <DropperLevel>k__BackingField;
        private TzarGames.TzarHero.DropperInfo dropper;
        
        // Properties
        public TzarGames.GameFramework.Events.ItemTakeEvent OnItemTaken { get; }
        public UnityEngine.Vector3 SpawnOffset { get; }
        public bool ShouldDestroyOnPickUp { get; }
        public TzarGames.GameFramework.Item ItemTemplate { get; }
        public ulong DropperID { get; set; }
        public uint DropperLevel { get; set; }
        public TzarGames.GameFramework.IDropperInfo Dropper { get; }
        public TzarGames.GameFramework.ItemInstance ItemInstance { get; }
        
        // Methods
        public TH_Dropped()
        {
            typeof(System.String[]).__il2cppRuntimeField_20 = "Player";
            this.radius = 0.5f;
            this.tags = null;
            this.dropper = new TzarGames.TzarHero.DropperInfo();
        }
        public TzarGames.GameFramework.Events.ItemTakeEvent get_OnItemTaken()
        {
            return (TzarGames.GameFramework.Events.ItemTakeEvent)this.onItemTaken;
        }
        public UnityEngine.Vector3 get_SpawnOffset()
        {
            return new UnityEngine.Vector3() {x = this.spawnOffset};
        }
        public bool get_ShouldDestroyOnPickUp()
        {
            if(this.item != null)
            {
                    return this.item.DestroyOnPickup;
            }
            
            return this.item.DestroyOnPickup;
        }
        public override float GetRadius()
        {
            return (float)this.radius;
        }
        public TzarGames.GameFramework.Item get_ItemTemplate()
        {
            return (TzarGames.GameFramework.Item)this.item;
        }
        public ulong get_DropperID()
        {
            return (ulong)this.<DropperID>k__BackingField;
        }
        private void set_DropperID(ulong value)
        {
            this.<DropperID>k__BackingField = value;
        }
        public uint get_DropperLevel()
        {
            return (uint)this.<DropperLevel>k__BackingField;
        }
        private void set_DropperLevel(uint value)
        {
            this.<DropperLevel>k__BackingField = value;
        }
        public TzarGames.GameFramework.IDropperInfo get_Dropper()
        {
            return (TzarGames.GameFramework.IDropperInfo)this.dropper;
        }
        public void SetItemTemplateAndCreateInstance(TzarGames.GameFramework.Item itemTemplate)
        {
            this.item = itemTemplate;
            this.itemInstance = 0;
            this.notifiedByDropper = false;
            this.initialize();
        }
        public void NotifyDroppedBy(uint dropperId, uint dropperLevel)
        {
            this.dropper.ID = dropperId;
            this.dropper.Level = dropperLevel;
            if(this.itemInstance.GetTemplateInstance() == null)
            {
                    return;
            }
            
            if(this.notifiedByDropper == true)
            {
                    return;
            }
            
            this.notifiedByDropper = true;
        }
        private void initItemInstance()
        {
            TzarGames.GameFramework.ItemInstance val_1 = this.item.CreateItemInstance();
            this.itemInstance = val_1;
            if(val_1 == null)
            {
                    return;
            }
            
            TzarGames.GameFramework.Item val_2 = val_1.GetTemplateInstance();
        }
        public TzarGames.GameFramework.ItemInstance get_ItemInstance()
        {
            return (TzarGames.GameFramework.ItemInstance)this.itemInstance;
        }
        private void initialize()
        {
            if(0 == this.item)
            {
                    return;
            }
            
            if(this.itemInstance != null)
            {
                    return;
            }
            
            this.initItemInstance();
        }
        protected override void Start()
        {
            this.Start();
            this.triggeredList = new System.Collections.Generic.List<UnityEngine.Collider>();
            if(this.itemInstance == null)
            {
                    return;
            }
            
            if(this.itemInstance.GetTemplateInstance() == null)
            {
                    return;
            }
            
            if(this.notifiedByDropper == true)
            {
                    return;
            }
            
            this.notifiedByDropper = true;
        }
        protected override void Init()
        {
            this.initialize();
        }
        protected override void CollectObjectInfo(System.Collections.Generic.Dictionary<string, string> data)
        {
            this.CollectObjectInfo(data:  data);
            data.set_Item(key:  "THDRP_ITEMID", value:  this.itemInstance.GetInstanceID());
        }
        protected override void ApplyObjectInfo(System.Collections.Generic.Dictionary<string, string> data)
        {
            this.ApplyObjectInfo(data:  data);
            this.itemInstance.SetInstanceID(newId:  data.Item["THDRP_ITEMID"]);
        }
        private void OnTriggerEnter(UnityEngine.Collider other)
        {
            System.Collections.Generic.List<UnityEngine.Collider> val_3;
            if(this.isPickedUp == true)
            {
                    return;
            }
            
            val_3 = this.triggeredList;
            val_3.Add(item:  other);
            if(this.triggeredCheckRoutine != null)
            {
                    return;
            }
            
            this.triggeredCheckRoutine = this.StartCoroutine(routine:  this.triggeredCheck());
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator triggeredCheck()
        {
            typeof(TH_Dropped.<triggeredCheck>c__Iterator0).__il2cppRuntimeField_18 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private bool tryTakeItem(UnityEngine.GameObject go)
        {
            TzarGames.GameFramework.Item val_6;
            if(((this.OnClient == true) || (this.tags == null)) || (this.tags.Length < 1))
            {
                    return false;
            }
            
            val_6 = this.item;
            if(0 == val_6)
            {
                    return false;
            }
            
            var val_6 = 0;
            do
            {
                val_6 = this.tags;
                if(val_6 >= this.tags.Length)
            {
                    return false;
            }
            
                val_6 = this.tags[0];
                val_6 = val_6 + 1;
            }
            while((go.CompareTag(tag:  val_6)) == false);
            
            TzarGames.GameFramework.IItemReceiver val_5 = go.GetComponent<TzarGames.GameFramework.IItemReceiver>();
            return false;
        }
        public void TakeBy(TzarGames.GameFramework.IItemReceiver itemReceiver)
        {
            var val_10;
            TzarGames.GameFramework.ITakeItemEvent val_11;
            TzarGames.GameFramework.ItemInstance val_12;
            var val_13;
            this.isPickedUp = true;
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_10 = itemReceiver;
            TzarGames.GameFramework.Events.ItemTakeEventData val_2 = null;
            val_11 = val_2;
            val_2 = new TzarGames.GameFramework.Events.ItemTakeEventData();
            if(null != 0)
            {
                    Receiver = itemReceiver;
                Dropper = this.dropper;
                val_12 = this.itemInstance;
            }
            else
            {
                    Receiver = itemReceiver;
                Dropper = this.dropper;
                val_12 = this.itemInstance;
            }
            
            ItemInstance = val_12;
            this.onItemTaken.Invoke(arg0:  val_11);
            if(this.OnServer != false)
            {
                    TzarGames.GameFramework.RPCall<System.UInt32> val_4 = null;
                val_11 = val_4;
                val_4 = new TzarGames.GameFramework.RPCall<System.UInt32>(object:  this, method:  System.Void TzarGames.TzarHero.TH_Dropped::client_itemTaken(uint receiverID));
                var val_11 = 0;
                val_11 = val_11 + 1;
                val_13 = itemReceiver;
                typeof(System.Object[]).__il2cppRuntimeField_20 = itemReceiver;
                typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
                this.RPC(methodDelegate:  val_11, rpcMode:  2, parameters:  null);
            }
            
            if(this.item.DestroyOnPickup == false)
            {
                    return;
            }
            
            UnityEngine.GameObject val_7 = this.gameObject;
            if((TzarGames.GameFramework.Instantiator.IsPoolableInstance(instanceObject:  0)) != false)
            {
                    UnityEngine.GameObject val_9 = this.gameObject;
                TzarGames.GameFramework.Instantiator.PushToPool(instanceObject:  0);
                return;
            }
            
            this.DestroySelf();
        }
        [TzarRPC]
        protected void client_itemTaken(uint receiverID)
        {
            TzarGames.TzarHero.TH_InteractiveObject val_1 = TzarGames.TzarHero.TH_InteractiveObject.GetObjectById(id:  317251584);
            if(0 == val_1)
            {
                    typeof(System.Object[]).__il2cppRuntimeField_20 = receiverID;
                typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
                UnityEngine.Debug.LogErrorFormat(format:  0, args:  "No receiver found with ID: {0}");
                return;
            }
            
            this.TakeBy(itemReceiver:  val_1);
        }
        public void DestroySelf()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.Object.Destroy(obj:  0);
        }
        public override void OnPushedToPool()
        {
            this.OnPushedToPool();
            this.isPickedUp = false;
            this.itemInstance = 0;
            this.notifiedByDropper = false;
            if(this.triggeredList != null)
            {
                    this.triggeredList.Clear();
            }
            
            if(this.triggeredCheckRoutine == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.triggeredCheckRoutine);
            this.triggeredCheckRoutine = 0;
        }
        public override void OnPulledFromPool()
        {
            this.OnPulledFromPool();
            this.generateId();
            this.initialize();
        }
    
    }

}

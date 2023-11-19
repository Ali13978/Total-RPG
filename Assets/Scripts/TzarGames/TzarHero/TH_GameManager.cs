using UnityEngine;

namespace TzarGames.TzarHero
{
    public class TH_GameManager : GameManager, IItemDatabaseProvider
    {
        // Fields
        public TzarGames.GameFramework.ItemDatabaseData itemDatabase;
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.CharacterEvent onLocalPlayerCharacterSpawned;
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.CharacterDeadEvent onCharacterDead;
        private System.Collections.Generic.List<TzarGames.TzarHero.TH_Dropped> spawnedPickups;
        
        // Properties
        public TzarGames.GameFramework.ItemDatabaseData ItemDatabase { get; }
        public TzarGames.TzarHero.CharacterEvent OnLocalPlayerCharacterSpawned { get; }
        
        // Methods
        public TH_GameManager()
        {
            this.spawnedPickups = new System.Collections.Generic.List<TzarGames.TzarHero.TH_Dropped>();
        }
        public TzarGames.GameFramework.ItemDatabaseData get_ItemDatabase()
        {
            return (TzarGames.GameFramework.ItemDatabaseData)this.itemDatabase;
        }
        public TzarGames.TzarHero.CharacterEvent get_OnLocalPlayerCharacterSpawned()
        {
            return (TzarGames.TzarHero.CharacterEvent)this.onLocalPlayerCharacterSpawned;
        }
        protected override void Start()
        {
            UnityEngine.Object val_9;
            this.Start();
            val_9 = this.Net;
            if(0 == val_9)
            {
                    return;
            }
            
            val_9 = 1152921504912596992;
            if(TzarGames.GameFramework.GameManagerNetSyncBase.Connected == false)
            {
                    return;
            }
            
            if(TzarGames.GameFramework.GameManagerNetSyncBase.IsServer == false)
            {
                    return;
            }
            
            UnityEngine.Physics.IgnoreLayerCollision(layer1:  0, layer2:  UnityEngine.LayerMask.NameToLayer(layerName:  0), ignore:  UnityEngine.LayerMask.NameToLayer(layerName:  0));
            UnityEngine.Physics.IgnoreLayerCollision(layer1:  0, layer2:  UnityEngine.LayerMask.NameToLayer(layerName:  0), ignore:  UnityEngine.LayerMask.NameToLayer(layerName:  0));
        }
        protected override void OnDestroy()
        {
            var val_5;
            var val_6;
            this.OnDestroy();
            List.Enumerator<T> val_1 = this.spawnedPickups.GetEnumerator();
            label_10:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_2 = 0.InitializationCallback;
            if((0 == val_2) || ((UnityEngine.Object.op_Implicit(exists:  0)) == false))
            {
                goto label_10;
            }
            
            typeof(TH_InteractiveObject.InteractiveObjectDelegate).__il2cppRuntimeField_20 = this;
            typeof(TH_InteractiveObject.InteractiveObjectDelegate).__il2cppRuntimeField_28 = System.Void TzarGames.TzarHero.TH_GameManager::_onObjectDestroy(TzarGames.TzarHero.TH_InteractiveObject obj);
            typeof(TH_InteractiveObject.InteractiveObjectDelegate).__il2cppRuntimeField_10 = System.Void TzarGames.TzarHero.TH_GameManager::_onObjectDestroy(TzarGames.TzarHero.TH_InteractiveObject obj);
            val_2.remove_OnObjectDestroy(value:  null);
            goto label_10;
            label_2:
            val_5 = 0;
            val_6 = 1;
            0.Dispose();
            this.spawnedPickups.Clear();
        }
        public void Teleport(TzarGames.TzarHero.TH_InteractiveObject obj, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
        {
            if(obj != null)
            {
                    obj.Position = new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z};
            }
            else
            {
                    0.Position = new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z};
            }
            
            obj.transform.rotation = new UnityEngine.Quaternion() {x = rot.x, y = rot.y, z = rot.z, w = rot.w};
        }
        public void NotifyCharacterDead(TzarGames.TzarHero.DeadEventData deadInfo)
        {
            this.onCharacterDead.Invoke(arg0:  deadInfo);
        }
        protected virtual void OnCharacterDead(TzarGames.TzarHero.DeadEventData deadEventData)
        {
        
        }
        protected override void PostSpawnPlayerObject(TzarGames.GameFramework.Player player)
        {
            TzarGames.GameFramework.Player val_6;
            var val_7;
            val_6 = player;
            this.PostSpawnPlayerObject(player:  val_6);
            val_7 = 0;
            typeof(TH_GameManager.<PostSpawnPlayerObject>c__AnonStorey0).__il2cppRuntimeField_10 = ;
            if(0 == (typeof(TH_GameManager.<PostSpawnPlayerObject>c__AnonStorey0).__il2cppRuntimeField_10))
            {
                    return;
            }
            
            if(val_6.itsMe != false)
            {
                    this.onLocalPlayerCharacterSpawned.Invoke(arg0:  typeof(TH_GameManager.<PostSpawnPlayerObject>c__AnonStorey0).__il2cppRuntimeField_10);
            }
            
            val_6 = System.Void TH_GameManager.<PostSpawnPlayerObject>c__AnonStorey0::<>m__0(TzarGames.TzarHero.ICharacterEvents x);
            Event.EventFunction<TzarGames.TzarHero.ICharacterEvents> val_5 = new Event.EventFunction<TzarGames.TzarHero.ICharacterEvents>(object:  new System.Object(), method:  val_6);
            TzarGames.Common.EventSystem.Event<TzarGames.TzarHero.ICharacterEvents>.Execute(functor:  0);
        }
        public TzarGames.TzarHero.TH_Dropped SpawnLoot(TzarGames.GameFramework.Item item, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, int sessionID, TzarGames.TzarHero.TH_InteractiveObject dropper)
        {
            TzarGames.TzarHero.TH_GameManager val_14;
            UnityEngine.Object val_15;
            UnityEngine.Object val_16;
            UnityEngine.Object val_17;
            var val_18;
            val_14 = this;
            val_15 = 0;
            if(val_15 != this.Net)
            {
                    val_15 = 0;
                bool val_3 = TzarGames.GameFramework.GameManagerNetSyncBase.IsClient;
                val_16 = 0;
                if(val_3 == true)
            {
                    return (TzarGames.TzarHero.TH_Dropped)val_16;
            }
            
            }
            
            val_16 = TzarGames.TzarHero.TH_GameManager._spawnLoot(item:  val_3, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, rotation:  new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w}, dropper:  item);
            if(0 != val_16)
            {
                    this.spawnedPickups.Add(item:  val_16);
                typeof(TH_InteractiveObject.InteractiveObjectDelegate).__il2cppRuntimeField_20 = val_14;
                typeof(TH_InteractiveObject.InteractiveObjectDelegate).__il2cppRuntimeField_28 = System.Void TzarGames.TzarHero.TH_GameManager::_onObjectDestroy(TzarGames.TzarHero.TH_InteractiveObject obj);
                typeof(TH_InteractiveObject.InteractiveObjectDelegate).__il2cppRuntimeField_10 = System.Void TzarGames.TzarHero.TH_GameManager::_onObjectDestroy(TzarGames.TzarHero.TH_InteractiveObject obj);
                val_16.add_OnObjectDestroy(value:  null);
            }
            
            val_17 = this.Net;
            if(0 == val_17)
            {
                    return (TzarGames.TzarHero.TH_Dropped)val_16;
            }
            
            if(TzarGames.GameFramework.GameManagerNetSyncBase.IsServer == false)
            {
                    return (TzarGames.TzarHero.TH_Dropped)val_16;
            }
            
            val_17 = this.Net;
            val_14 = this.Net.MyNetworkView;
            val_16.generateId();
            if(1152921505024093152 != 0)
            {
                    val_18 = mem[null + 48];
                if(1152921505024093152 == 0)
            {
                    val_18 = 0;
            }
            
            }
            
            val_18 = 0;
            typeof(System.Object[]).__il2cppRuntimeField_20 = 1152921505024093152;
            typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_28 = item;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = position;
            dropper.generateId();
            typeof(System.Object[]).__il2cppRuntimeField_38 = dropper._id;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            val_17.ObjectBufferedRPC(methodDelegate:  new TzarGames.GameFramework.RPCall<System.UInt32, System.Int32, UnityEngine.Vector3, System.UInt32>(object:  this, method:  System.Void TzarGames.TzarHero.TH_GameManager::client_spawnLoot(uint instanceId, int itemId, UnityEngine.Vector3 position, uint dropperID)), sessionID:  sessionID, obj:  val_16, caller:  val_14, callForConnectedPlayers:  true, parameters:  null);
            return (TzarGames.TzarHero.TH_Dropped)val_16;
        }
        private void _onObjectDestroy(TzarGames.TzarHero.TH_InteractiveObject obj)
        {
            System.Collections.Generic.List<TzarGames.TzarHero.TH_Dropped> val_6;
            if(obj == null)
            {
                    return;
            }
            
            typeof(TH_InteractiveObject.InteractiveObjectDelegate).__il2cppRuntimeField_20 = this;
            typeof(TH_InteractiveObject.InteractiveObjectDelegate).__il2cppRuntimeField_28 = System.Void TzarGames.TzarHero.TH_GameManager::_onObjectDestroy(TzarGames.TzarHero.TH_InteractiveObject obj);
            typeof(TH_InteractiveObject.InteractiveObjectDelegate).__il2cppRuntimeField_10 = System.Void TzarGames.TzarHero.TH_GameManager::_onObjectDestroy(TzarGames.TzarHero.TH_InteractiveObject obj);
            obj.remove_OnObjectDestroy(value:  null);
            val_6 = this.spawnedPickups;
            if((val_6.Contains(item:  obj)) == false)
            {
                    return;
            }
            
            bool val_2 = this.spawnedPickups.Remove(item:  obj);
            val_6 = this.Net;
            if(0 == val_6)
            {
                    return;
            }
            
            this.Net.RemoveCustomBufferedRpcByObject(related:  obj);
        }
        [TzarRPC]
        protected void client_spawnLoot(uint instanceId, int itemId, UnityEngine.Vector3 position, uint dropperID)
        {
            uint val_8 = instanceId;
            TzarGames.GameFramework.Item val_1 = this.itemDatabase.GetItemByID(id:  itemId);
            if(0 != val_1)
            {
                    TzarGames.TzarHero.TH_InteractiveObject val_3 = TzarGames.TzarHero.TH_InteractiveObject.GetObjectById(id:  317251584);
                UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.identity;
                TzarGames.TzarHero.TH_Dropped val_5 = TzarGames.TzarHero.TH_GameManager._spawnLoot(item:  0, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, dropper:  val_1);
                if(0 == val_5)
            {
                    return;
            }
            
                val_5.Id = val_8;
                return;
            }
            
            val_8 = 0 + "Failed to find item in database. Id: "("Failed to find item in database. Id: ");
            UnityEngine.Debug.LogWarning(message:  0);
        }
        private static TzarGames.TzarHero.TH_Dropped _spawnLoot(TzarGames.GameFramework.Item item, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, TzarGames.TzarHero.TH_InteractiveObject dropper)
        {
            UnityEngine.Object val_13;
            float val_14;
            float val_15;
            float val_16;
            float val_17;
            UnityEngine.Object val_19;
            var val_20;
            uint val_21;
            val_13 = X2;
            val_14 = rotation.w;
            val_15 = rotation.y;
            val_16 = position.y;
            val_17 = position.x;
            if(0 == 34807808)
            {
                goto label_4;
            }
            
            if((TzarGames.GameFramework.Instantiator.IsPoolablePrefab(prefab:  0)) == false)
            {
                goto label_5;
            }
            
            UnityEngine.GameObject val_3 = TzarGames.GameFramework.Instantiator.InstantiateFromPool(originalObject:  0, position:  new UnityEngine.Vector3() {x = val_17, y = val_16, z = position.z}, rotation:  new UnityEngine.Quaternion() {x = rotation.x, y = val_15, z = rotation.z, w = val_14}, parent:  34807808);
            goto label_6;
            label_4:
            val_13 = 0 + "There is no prefab attached to item ";
            UnityEngine.Debug.LogWarning(message:  0);
            val_19 = 0;
            return (TzarGames.TzarHero.TH_Dropped)val_19;
            label_5:
            UnityEngine.GameObject val_5 = TzarGames.GameFramework.GameManager.MakeInstance(obj:  0);
            label_6:
            val_19 = val_5.GetComponent<TzarGames.TzarHero.TH_Dropped>();
            if(0 == val_19)
            {
                    val_19 = val_5.AddComponent<TzarGames.TzarHero.TH_Dropped>();
            }
            
            val_17 = rotation.x;
            val_15 = val_14;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_17, y = val_16, z = position.z}, b:  new UnityEngine.Vector3() {x = val_8.spawnOffset, y = val_14, z = V15.16B});
            val_14 = val_10.x;
            val_16 = val_10.z;
            val_5.transform.SetPositionAndRotation(position:  new UnityEngine.Vector3() {x = val_14, y = val_10.y, z = val_16}, rotation:  new UnityEngine.Quaternion() {x = val_17, y = val_15, z = rotation.z, w = val_15});
            val_8.item = dropper;
            val_8.itemInstance = 0;
            val_8.notifiedByDropper = false;
            val_19.initialize();
            if(0 == val_13)
            {
                goto label_27;
            }
            
            val_13.generateId();
            val_20 = mem[X2 + 96];
            val_20 = X2 + 96;
            goto label_29;
            label_27:
            val_20 = 0;
            val_21 = 0;
            if(val_13 == 0)
            {
                goto label_33;
            }
            
            label_29:
            val_21 = 0;
            label_33:
            val_19.NotifyDroppedBy(dropperId:  0, dropperLevel:  null);
            return (TzarGames.TzarHero.TH_Dropped)val_19;
        }
    
    }

}

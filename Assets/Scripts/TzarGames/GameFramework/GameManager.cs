using UnityEngine;

namespace TzarGames.GameFramework
{
    public class GameManager : TzarBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject playerPrefab;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject playerServerPrefab;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.SpawnPoint[] playerSpawnPoints;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.GameManagerNetSyncBase netSync;
        [UnityEngine.SerializeField]
        private bool enterMatchWhenOffline;
        [UnityEngine.SerializeField]
        private bool allowRespawing;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.PlayerEvent onLocalPlayerObjectSpawned;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.PlayerEvent onPlayerObjectSpawned;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.PlayerEvent onPlayerEnterToGame;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.PlayerEvent onPlayerExitFromGame;
        private System.Collections.Generic.List<TzarGames.GameFramework.Player> players;
        private TzarGames.GameFramework.Player localPlayer;
        private static TzarGames.GameFramework.GameManager _instance;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.Common.TG_VoidDelegate OnGamemanagerDestroy;
        
        // Properties
        public UnityEngine.GameObject PlayerPrefab { get; }
        public UnityEngine.GameObject PlayerServerPrefab { get; }
        public bool AllowRespawning { get; }
        public bool EnterMatchWhenOffline { get; }
        public TzarGames.GameFramework.PlayerEvent OnLocalPlayerObjectSpawned { get; }
        public TzarGames.GameFramework.PlayerEvent OnPlayerObjectSpawned { get; }
        public TzarGames.GameFramework.PlayerEvent OnPlayerEnterToGame { get; }
        public TzarGames.GameFramework.PlayerEvent OnPlayerExitFromGame { get; }
        public TzarGames.GameFramework.GameManagerNetSyncBase Net { get; }
        public static TzarGames.GameFramework.GameManager Instance { get; }
        public TzarGames.GameFramework.Player LocalPlayer { get; }
        
        // Methods
        public GameManager()
        {
            this.enterMatchWhenOffline = true;
            this.allowRespawing = true;
            this.players = new System.Collections.Generic.List<TzarGames.GameFramework.Player>();
        }
        public UnityEngine.GameObject get_PlayerPrefab()
        {
            return (UnityEngine.GameObject)this.playerPrefab;
        }
        public UnityEngine.GameObject get_PlayerServerPrefab()
        {
            return (UnityEngine.GameObject)this.playerServerPrefab;
        }
        public bool get_AllowRespawning()
        {
            return (bool)this.allowRespawing;
        }
        public bool get_EnterMatchWhenOffline()
        {
            return (bool)this.enterMatchWhenOffline;
        }
        public TzarGames.GameFramework.PlayerEvent get_OnLocalPlayerObjectSpawned()
        {
            return (TzarGames.GameFramework.PlayerEvent)this.onLocalPlayerObjectSpawned;
        }
        public TzarGames.GameFramework.PlayerEvent get_OnPlayerObjectSpawned()
        {
            return (TzarGames.GameFramework.PlayerEvent)this.onPlayerObjectSpawned;
        }
        public TzarGames.GameFramework.PlayerEvent get_OnPlayerEnterToGame()
        {
            return (TzarGames.GameFramework.PlayerEvent)this.onPlayerEnterToGame;
        }
        public TzarGames.GameFramework.PlayerEvent get_OnPlayerExitFromGame()
        {
            return (TzarGames.GameFramework.PlayerEvent)this.onPlayerExitFromGame;
        }
        public TzarGames.GameFramework.GameManagerNetSyncBase get_Net()
        {
            return (TzarGames.GameFramework.GameManagerNetSyncBase)this.netSync;
        }
        public void add_OnGamemanagerDestroy(TzarGames.Common.TG_VoidDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnGamemanagerDestroy);
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
            while(1152921511328221576 != this.OnGamemanagerDestroy);
        
        }
        public void remove_OnGamemanagerDestroy(TzarGames.Common.TG_VoidDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnGamemanagerDestroy);
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
            while(1152921511328358152 != this.OnGamemanagerDestroy);
        
        }
        public static TzarGames.GameFramework.GameManager get_Instance()
        {
            null = null;
            return (TzarGames.GameFramework.GameManager)TzarGames.GameFramework.GameManager._instance;
        }
        public static T GetInstance<T>()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if(TzarGames.GameFramework.GameManager._instance != null)
            {
                    val_3 = TzarGames.GameFramework.GameManager._instance;
                if(val_3 != null)
            {
                    return (object)val_3;
            }
            
            }
            
            val_3 = 0;
            return (object)val_3;
        }
        public TzarGames.GameFramework.Player get_LocalPlayer()
        {
            TzarGames.GameFramework.Player val_4;
            if(this.localPlayer != null)
            {
                    return (TzarGames.GameFramework.Player)this.localPlayer;
            }
            
            val_4 = "Local player";
            TzarGames.GameFramework.Player val_1 = TzarGames.GameFramework.Player.GetPlayerByLogin(login:  0);
            this.localPlayer = val_1;
            if(val_1 == null)
            {
                    this.localPlayer = TzarGames.GameFramework.Player.Create(login:  0);
            }
            
            if(0 == this.netSync)
            {
                    return (TzarGames.GameFramework.Player)this.localPlayer;
            }
            
            val_4 = this.localPlayer;
            this.localPlayer.NetworkPlayer = this.netSync;
            return (TzarGames.GameFramework.Player)this.localPlayer;
        }
        public static UnityEngine.GameObject MakeInstance(UnityEngine.GameObject obj)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
            return TzarGames.GameFramework.GameManager.MakeInstance(obj:  null, position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w});
        }
        public static T MakeInstance<T>(T obj)
        {
            var val_20;
            var val_21;
            float val_22;
            float val_23;
            float val_24;
            float val_25;
            val_21 = X2;
            UnityEngine.GameObject val_1 = __RuntimeMethodHiddenParam.gameObject;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            val_22 = val_2.x;
            val_23 = val_2.z;
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
            val_24 = val_3.y;
            val_25 = val_3.z;
            if(0 == (TzarGames.GameFramework.GameManager.MakeInstance(obj:  0, position:  new UnityEngine.Vector3() {x = val_22, y = val_2.y, z = val_23}, rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_24, z = val_25, w = val_3.w})))
            {
                    return 0;
            }
            
            val_21 = ???;
            val_20 = ???;
            val_22 = ???;
            val_23 = ???;
            val_24 = ???;
            val_25 = ???;
            goto X2 + 48 + 8;
        }
        public static UnityEngine.GameObject MakeInstance(UnityEngine.GameObject obj, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
        {
            bool val_1 = TzarGames.GameFramework.Instantiator.IsPoolablePrefab(prefab:  10741);
            if(val_1 == false)
            {
                    return UnityEngine.Object.Instantiate<TzarGames.GameFramework.TzarBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, rotation:  new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w});
            }
            
            return TzarGames.GameFramework.Instantiator.InstantiateFromPool(originalObject:  val_1, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, rotation:  new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w}, parent:  X1);
        }
        public static void DestroyInstance(UnityEngine.GameObject obj)
        {
            bool val_1 = TzarGames.GameFramework.Instantiator.IsPoolableInstance(instanceObject:  10733);
            if(val_1 != false)
            {
                    TzarGames.GameFramework.Instantiator.PushToPool(instanceObject:  val_1);
                return;
            }
            
            UnityEngine.Object.Destroy(obj:  0);
        }
        protected override void Awake()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if(0 != TzarGames.GameFramework.GameManager._instance)
            {
                    UnityEngine.Debug.LogWarning(message:  0);
                UnityEngine.GameObject val_2 = this.gameObject;
                UnityEngine.Object.Destroy(obj:  0);
                return;
            }
            
            val_4 = null;
            val_4 = null;
            TzarGames.GameFramework.GameManager._instance = this;
            this.Awake();
        }
        protected override void OnDestroy()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if(0 == TzarGames.GameFramework.GameManager._instance)
            {
                    val_4 = null;
                val_4 = null;
                TzarGames.GameFramework.GameManager._instance = 0;
            }
            
            bool val_2 = UnityEngine.Object.op_Inequality(x:  0, y:  this.netSync);
            if(this.localPlayer != null)
            {
                    TzarGames.GameFramework.Player.Remove(player:  0);
            }
            
            if(this.OnGamemanagerDestroy == null)
            {
                    return;
            }
            
            this.OnGamemanagerDestroy.Invoke();
        }
        protected virtual void Start()
        {
            bool val_1 = UnityEngine.Object.op_Inequality(x:  0, y:  this.netSync);
            if(TzarGames.GameFramework.ApplicationManager.IsBatchMode == true)
            {
                    return;
            }
            
            if(this.enterMatchWhenOffline == false)
            {
                    return;
            }
            
            if(0 != this.netSync)
            {
                    if(0 == this.netSync)
            {
                    return;
            }
            
                if(TzarGames.GameFramework.GameManagerNetSyncBase.Connected != false)
            {
                    return;
            }
            
            }
            
            TzarGames.GameFramework.Player val_9 = this.LocalPlayer;
            UnityEngine.Coroutine val_10 = this.StartCoroutine(routine:  this);
        }
        public virtual void GetPlayerData(TzarGames.GameFramework.Player player, System.Action<byte[]> getDataMethod)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        public virtual void SetPlayerData(TzarGames.GameFramework.Player player, byte[] data, System.Action completeCallback)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        public UnityEngine.Coroutine HandlePlayerEnteredToGame(TzarGames.GameFramework.Player player)
        {
            return this.StartCoroutine(routine:  this);
        }
        public void OnPlayerExitGame(TzarGames.GameFramework.Player player)
        {
            UnityEngine.Coroutine val_1 = this.StartCoroutine(routine:  this);
        }
        public UnityEngine.GameObject SpawnObjectForPlayer(TzarGames.GameFramework.Player player, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, byte[] playerData)
        {
            bool val_20;
            UnityEngine.Object val_21;
            UnityEngine.GameObject val_22;
            UnityEngine.GameObject val_23;
            UnityEngine.GameObject val_24;
            var val_25;
            TzarGames.GameFramework.GameManagerNetSyncBase val_27;
            val_20 = playerData;
            if(0 != player.PlayerObject)
            {
                goto label_4;
            }
            
            val_21 = 0;
            bool val_2 = UnityEngine.Object.op_Inequality(x:  val_21, y:  this.netSync);
            if(val_2 == false)
            {
                goto label_13;
            }
            
            val_21 = null;
            if(TzarGames.GameFramework.GameManagerNetSyncBase.IsServer == false)
            {
                goto label_13;
            }
            
            val_21 = 0;
            if(TzarGames.GameFramework.ApplicationManager.IsBatchMode == false)
            {
                goto label_13;
            }
            
            val_22 = this.playerServerPrefab;
            val_23 = this.playerPrefab;
            goto label_14;
            label_4:
            val_24 = player.PlayerObject;
            val_25 = 0;
            goto label_16;
            label_13:
            val_23 = this.playerPrefab;
            val_22 = val_23;
            label_14:
            if((TzarGames.GameFramework.Instantiator.IsPoolablePrefab(prefab:  val_2)) == false)
            {
                goto label_17;
            }
            
            bool val_6 = player.itsMe;
            if(val_6 == false)
            {
                goto label_19;
            }
            
            TzarGames.GameFramework.TzarBehaviour val_7 = UnityEngine.Object.Instantiate<TzarGames.GameFramework.TzarBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, rotation:  new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w});
            goto label_25;
            label_17:
            UnityEngine.GameObject val_8 = TzarGames.GameFramework.GameManager.MakeInstance(obj:  null, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, rotation:  new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w});
            goto label_25;
            label_19:
            label_25:
            val_24 = TzarGames.GameFramework.Instantiator.InstantiateFromPool(originalObject:  val_6, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, rotation:  new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w}, parent:  mem[this.playerPrefab]);
            player.PlayerObject = val_24;
            val_25 = 1;
            label_16:
            TzarGames.GameFramework.GameManager.SetupSpawnedObject(playerObject:  null, playerData:  val_24, forServer:  val_20, owner:  TzarGames.GameFramework.GameManagerNetSyncBase.IsServer);
            val_27 = this.netSync;
            if((0 == val_27) || (TzarGames.GameFramework.GameManagerNetSyncBase.IsServer == false))
            {
                goto label_36;
            }
            
            val_27 = this.netSync;
            bool val_14 = val_27.HandleSpawnObjectForPlayer(player:  player, go:  val_24, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, rotation:  new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w}, playerData:  val_20);
            if((val_25 & val_14) == true)
            {
                goto label_38;
            }
            
            val_24 = (val_14 != true) ? (val_24) : 0;
            return val_24;
            label_36:
            if(val_25 == 0)
            {
                    return val_24;
            }
            
            label_38:
            if(player.itsMe != false)
            {
                    val_20 = this.onLocalPlayerObjectSpawned;
                val_27 = 1152921511330425904;
                val_20.Invoke(arg0:  player);
                this.onPlayerObjectSpawned.Invoke(arg0:  player);
                return val_24;
            }
            
            this.onPlayerObjectSpawned.Invoke(arg0:  player);
            return val_24;
        }
        public static void SetupSpawnedObject(UnityEngine.GameObject playerObject, byte[] playerData, bool forServer, TzarGames.GameFramework.Player owner)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            if(0 == playerData)
            {
                    return;
            }
            
            TzarGames.GameFramework.IPlayerComponent val_2 = playerData.GetComponentInChildren<TzarGames.GameFramework.IPlayerComponent>();
            if(val_2 == null)
            {
                    return;
            }
            
            mem2[0] = val_2;
            val_6 = 1152921504908763136;
            if((owner & 1) != 0)
            {
                    var val_6 = 0;
                val_6 = val_6 + 1;
            }
            else
            {
                    var val_7 = 0;
                val_7 = val_7 + 1;
            }
            
            val_7 = val_2;
            if(forServer == false)
            {
                    return;
            }
            
            if((forServer + 24) < 1)
            {
                    return;
            }
            
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_8 = 5;
            val_9 = val_2;
        }
        public virtual void HandleConnectedToServerEvent()
        {
        
        }
        [TzarGames.Common.ConsoleCommand]
        public void RespawnLocalPlayer()
        {
            if(this.LocalPlayer == null)
            {
                    return;
            }
            
            TzarGames.GameFramework.Player val_3 = this.LocalPlayer;
            UnityEngine.Vector3 val_5 = val_3.PlayerObject.transform.position;
            TzarGames.GameFramework.Player val_6 = this.LocalPlayer;
            UnityEngine.Quaternion val_8 = val_6.PlayerObject.transform.rotation;
            this.RespawnPlayerObject(player:  this.LocalPlayer, position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, rotation:  new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w});
        }
        public void RespawnPlayerObject(TzarGames.GameFramework.Player player, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
        {
            TzarGames.GameFramework.GameManagerNetSyncBase val_6;
            var val_7;
            if(this.allowRespawing == false)
            {
                    return;
            }
            
            if(0 != player.PlayerObject)
            {
                    player.PlayerObject.transform.position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
                player.PlayerObject.transform.rotation = new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w};
            }
            
            if(player.PlayerComponent != null)
            {
                    var val_6 = 0;
                val_6 = val_6 + 1;
                val_7 = player.PlayerComponent;
            }
            
            val_6 = this.netSync;
            if(0 == val_6)
            {
                    return;
            }
            
            this.netSync.HandleRespawnPlayerObject(player:  player, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, rotation:  new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w});
        }
        public TzarGames.GameFramework.SpawnPoint GetRandomSpawnPoint()
        {
            TzarGames.GameFramework.SpawnPoint val_2;
            if((this.playerSpawnPoints != null) && (this.playerSpawnPoints.Length >= 1))
            {
                    val_2 = this.playerSpawnPoints[(long)UnityEngine.Random.Range(min:  0, max:  0)];
                return (TzarGames.GameFramework.SpawnPoint)val_2;
            }
            
            val_2 = 0;
            return (TzarGames.GameFramework.SpawnPoint)val_2;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        protected virtual System.Collections.IEnumerator HandlePlayerEnter(TzarGames.GameFramework.Player player)
        {
            if(null != 0)
            {
                    typeof(GameManager.<HandlePlayerEnter>c__Iterator0).__il2cppRuntimeField_10 = player;
            }
            else
            {
                    mem[16] = player;
            }
            
            typeof(GameManager.<HandlePlayerEnter>c__Iterator0).__il2cppRuntimeField_18 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        protected virtual TzarGames.GameFramework.SpawnPoint GetSpawnPointForPlayer(TzarGames.GameFramework.Player player)
        {
            TzarGames.GameFramework.SpawnPoint[] val_4 = this.playerSpawnPoints;
            if(val_4 != null)
            {
                goto label_1;
            }
            
            if(7254272 != 0)
            {
                    val_4 = this.playerSpawnPoints;
            }
            else
            {
                    System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
                val_4 = UnityEngine.Object.FindObjectsOfType(type:  0);
                this.playerSpawnPoints = val_4;
            }
            
            if(val_4 == null)
            {
                goto label_11;
            }
            
            label_1:
            label_11:
            return (TzarGames.GameFramework.SpawnPoint)val_4[(long)UnityEngine.Random.Range(min:  0, max:  0)];
        }
        protected virtual void PostSpawnPlayerObject(TzarGames.GameFramework.Player player)
        {
        
        }
        protected virtual void PostPlayerExit(TzarGames.GameFramework.Player player)
        {
            UnityEngine.GameObject val_7;
            if(0 == player.PlayerObject)
            {
                    return;
            }
            
            bool val_2 = player.itsMe;
            if(val_2 != false)
            {
                    return;
            }
            
            if(player == null)
            {
                goto label_7;
            }
            
            val_7 = player.PlayerObject;
            if((TzarGames.GameFramework.Instantiator.IsPoolableInstance(instanceObject:  val_2)) == false)
            {
                goto label_10;
            }
            
            goto label_9;
            label_7:
            bool val_6 = TzarGames.GameFramework.Instantiator.IsPoolableInstance(instanceObject:  val_2);
            val_7 = player.PlayerObject;
            if(val_6 == false)
            {
                goto label_10;
            }
            
            label_9:
            TzarGames.GameFramework.Instantiator.PushToPool(instanceObject:  val_6);
            return;
            label_10:
            UnityEngine.Object.Destroy(obj:  0);
        }
        private void OnPlayerExit(TzarGames.GameFramework.Player player)
        {
            UnityEngine.Coroutine val_1 = this.StartCoroutine(routine:  this);
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        protected virtual System.Collections.IEnumerator HandlePlayerExit(TzarGames.GameFramework.Player player)
        {
            if(null != 0)
            {
                    typeof(GameManager.<HandlePlayerExit>c__Iterator1).__il2cppRuntimeField_10 = player;
            }
            else
            {
                    mem[16] = player;
            }
            
            typeof(GameManager.<HandlePlayerExit>c__Iterator1).__il2cppRuntimeField_20 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private static GameManager()
        {
        
        }
    
    }

}

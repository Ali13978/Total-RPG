using UnityEngine;

namespace TzarGames.GameFramework
{
    public class TzarBehaviour : StateMachine, IPoolable
    {
        // Fields
        public const int EverythingLayer = 2147483647;
        private TzarGames.GameFramework.NetworkViewBase _networkView;
        public int SessionID;
        private bool isNetworkInstantiated;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.GameFramework.dlgTzarDestroy OnComponentDestroy;
        private TzarGames.GameFramework.Player _owner;
        
        // Properties
        public TzarGames.GameFramework.Player PlayerOwner { get; }
        public TzarGames.GameFramework.NetworkViewBase MyNetworkView { get; }
        public bool IsNetworkInstantiated { get; }
        public TzarGames.GameFramework.GameManager MyGameManager { get; }
        public System.Collections.Generic.List<TzarGames.GameFramework.Player> SessionPlayers { get; }
        public bool Connected { get; }
        public bool OnServer { get; }
        public bool OnClient { get; }
        
        // Methods
        public TzarBehaviour()
        {
        
        }
        public void add_OnComponentDestroy(TzarGames.GameFramework.dlgTzarDestroy value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnComponentDestroy);
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
            while(1152921511447175808 != this.OnComponentDestroy);
        
        }
        public void remove_OnComponentDestroy(TzarGames.GameFramework.dlgTzarDestroy value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnComponentDestroy);
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
            while(1152921511447312384 != this.OnComponentDestroy);
        
        }
        public TzarGames.GameFramework.Player get_PlayerOwner()
        {
            return (TzarGames.GameFramework.Player)this._owner;
        }
        public virtual void SetPlayerOwner(TzarGames.GameFramework.Player player)
        {
            this._owner = player;
            if(player == null)
            {
                    return;
            }
            
            this.SessionID = player.SessionID;
        }
        public TzarGames.GameFramework.NetworkViewBase get_MyNetworkView()
        {
            TzarGames.GameFramework.NetworkViewBase val_4;
            if(0 == this._networkView)
            {
                    this._networkView = this.GetComponent<TzarGames.GameFramework.NetworkViewBase>();
                return val_4;
            }
            
            val_4 = this._networkView;
            return val_4;
        }
        public bool get_IsNetworkInstantiated()
        {
            return (bool)this.isNetworkInstantiated;
        }
        public void SetNetworkInstantiatedFlag(bool netInstantiated)
        {
            this.isNetworkInstantiated = netInstantiated;
        }
        public TzarGames.GameFramework.GameManager get_MyGameManager()
        {
            return TzarGames.GameFramework.GameManager.Instance;
        }
        public System.Collections.Generic.List<TzarGames.GameFramework.Player> get_SessionPlayers()
        {
            TzarGames.GameFramework.GameManagerNetSyncBase val_2 = TzarGames.GameFramework.GameManager.Instance.Net;
            if(val_2 != null)
            {
                    return val_2.GetPlayersInSession(sessionID:  this.SessionID);
            }
            
            return val_2.GetPlayersInSession(sessionID:  this.SessionID);
        }
        public bool get_Connected()
        {
            return TzarGames.GameFramework.GameManagerNetSyncBase.Connected;
        }
        public bool get_OnServer()
        {
            if(TzarGames.GameFramework.GameManagerNetSyncBase.Connected == false)
            {
                    return false;
            }
            
            return TzarGames.GameFramework.GameManagerNetSyncBase.IsServer;
        }
        public bool get_OnClient()
        {
            if(TzarGames.GameFramework.GameManagerNetSyncBase.Connected == false)
            {
                    return false;
            }
            
            return TzarGames.GameFramework.GameManagerNetSyncBase.IsClient;
        }
        public void NetworkDestroy()
        {
            UnityEngine.GameObject val_3 = this.gameObject;
            if(this.MyGameManager.Net == null)
            {
                
            }
        
        }
        protected virtual void OnDestroy()
        {
            this.RemoveRPCs();
            if(this.OnComponentDestroy == null)
            {
                    return;
            }
            
            this.OnComponentDestroy.Invoke(behaviour:  this);
        }
        public void RemoveRPCs()
        {
            bool val_2 = UnityEngine.Object.op_Inequality(x:  0, y:  this.MyNetworkView);
            if(val_2 == false)
            {
                    return;
            }
            
            if(val_2.OnServer != false)
            {
                    TzarGames.GameFramework.GameManagerNetSyncBase val_5 = TzarGames.GameFramework.GameManager.Instance.Net;
                TzarGames.GameFramework.NetworkViewBase val_6 = this.MyNetworkView;
            }
            
            if(0 == TzarGames.GameFramework.GameManager.Instance)
            {
                    return;
            }
            
            if(0 == TzarGames.GameFramework.GameManager.Instance.Net)
            {
                    return;
            }
            
            TzarGames.GameFramework.GameManager.Instance.Net.RemoveCustomBufferedRPCsByCaller(caller:  this.MyNetworkView);
        }
        public void RPC(System.Delegate methodDelegate, TzarGames.GameFramework.NetworkPlayer target, object[] parameters)
        {
            if(0 == this.MyNetworkView)
            {
                    return;
            }
            
            this.MyNetworkView.RPC(methodDelegate:  methodDelegate, player:  target, args:  parameters);
        }
        public void UnreliableRPC(System.Delegate methodDelegate, TzarGames.GameFramework.NetworkPlayer callTarget, object[] parameters)
        {
            if(0 == this.MyNetworkView)
            {
                    return;
            }
            
            this.MyNetworkView.UnreliableRPC(methodDelegate:  methodDelegate, player:  callTarget, args:  parameters);
        }
        public void UnreliableRPC(System.Delegate methodDelegate, TzarGames.GameFramework.TzarRPCModes callTarget, object[] parameters)
        {
            if(0 == this.MyNetworkView)
            {
                    return;
            }
            
            this.MyNetworkView.UnreliableRPC(methodDelegate:  methodDelegate, mode:  callTarget, args:  parameters);
        }
        public void CustomBufferedRPC(System.Delegate methodDelegate, bool callForCurrentPlayers, object[] parameters)
        {
            UnityEngine.Object val_9 = TzarGames.GameFramework.GameManager.Instance;
            if(0 != val_9)
            {
                    val_9 = this.MyNetworkView;
                if(0 != val_9)
            {
                    TzarGames.GameFramework.GameManager.Instance.Net.BufferedRPC(methodDelegate:  methodDelegate, sessionID:  this.SessionID, caller:  this.MyNetworkView, callForConnectedPlayers:  callForCurrentPlayers, parameters:  parameters);
                return;
            }
            
            }
            
            UnityEngine.Debug.LogWarning(message:  0);
        }
        public void RemoveCustomBufferedRPC(System.Delegate methodDelegate)
        {
            UnityEngine.Object val_12 = TzarGames.GameFramework.GameManager.Instance;
            if(0 == val_12)
            {
                    return;
            }
            
            val_12 = val_12.Net;
            if(0 == val_12)
            {
                    return;
            }
            
            TzarGames.GameFramework.NetworkViewBase val_7 = this.MyNetworkView;
            if(0 == val_7)
            {
                    return;
            }
            
            TzarGames.GameFramework.GameManager.Instance.Net.RemoveCustomBufferedRpcByMethodName(caller:  val_7, methodName:  methodDelegate.Method);
        }
        public void DynamicBufferedRPC(System.Delegate methodDelegate, int sessionID, TzarGames.GameFramework.GameManager.dlgGetParameters getParamFunc)
        {
            UnityEngine.Object val_11 = TzarGames.GameFramework.GameManager.Instance;
            if(0 != val_11)
            {
                    val_11 = this.MyNetworkView;
                if(0 != val_11)
            {
                    val_11 = TzarGames.GameFramework.GameManager.Instance.Net;
                if(0 != val_11)
            {
                    TzarGames.GameFramework.GameManager.Instance.Net.DynamicBufferedRPC(methodDelegate:  methodDelegate, sessionID:  sessionID, caller:  this.MyNetworkView, paramGetFunc:  getParamFunc);
                return;
            }
            
            }
            
            }
            
            UnityEngine.Debug.LogWarning(message:  0);
        }
        public void RPC(System.Delegate methodDelegate, TzarGames.GameFramework.TzarRPCModes rpcMode, object[] parameters)
        {
            var val_8;
            if(rpcMode == 4)
            {
                    if(this.OnClient != false)
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            }
            
            TzarGames.GameFramework.NetworkViewBase val_2 = this.MyNetworkView;
            if(0 == val_2)
            {
                    return;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            if(((val_2 & 1) & 1) != 0)
            {
                    return;
            }
            
            if(rpcMode != 4)
            {
                goto label_14;
            }
            
            List.Enumerator<T> val_6 = this._owner.NeighbourPlayers.GetEnumerator();
            label_31:
            if((0 & 1) == 0)
            {
                goto label_35;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_9 = val_8.InitializationCallback;
            if(this._owner == val_9)
            {
                goto label_18;
            }
            
            if(val_9 == val_9.MyGameManager.Net.ServerPlayer)
            {
                goto label_31;
            }
            
            val_2.RPC(methodDelegate:  methodDelegate, player:  val_9, args:  parameters = parameters);
            goto label_31;
            label_18:
            System.Reflection.MethodInfo val_13 = methodDelegate.Method;
            string val_14 = 0 + "Self reference found in neighbour players list, failed to send RPC ";
            UnityEngine.Debug.LogError(message:  0);
            goto label_31;
            label_35:
            val_8.Dispose();
            if((0 & 1) != 0)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
            
            return;
            label_14:
            val_2.RPC(methodDelegate:  methodDelegate, mode:  rpcMode, args:  parameters);
        }
        public virtual void OnPushedToPool()
        {
            this._owner = 0;
            this.SessionID = 0;
            this.isNetworkInstantiated = false;
            this.RemoveRPCs();
            this._owner = 0;
            if(this.OnComponentDestroy == null)
            {
                    return;
            }
            
            this.OnComponentDestroy.Invoke(behaviour:  this);
        }
        public virtual void OnPulledFromPool()
        {
        
        }
    
    }

}

using UnityEngine;

namespace TzarGames.GameFramework.NetworkSubsystem_Photon
{
    [UnityEngine.RequireComponent]
    public class NetworkView_Photon : NetworkViewBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private PhotonView photonView;
        private TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.NetworkViewID_Photon _viewId;
        
        // Properties
        public PhotonView NativeView { get; }
        public override bool HasUnassignedViewID { get; }
        public override TzarGames.GameFramework.NetworkViewID ViewID { get; }
        public override int Group { get; set; }
        
        // Methods
        public NetworkView_Photon()
        {
        
        }
        public PhotonView get_NativeView()
        {
            return (PhotonView)this.photonView;
        }
        private void Reset()
        {
            this.photonView = this.GetComponent<PhotonView>();
            if(val_1.ObservedComponents == null)
            {
                    this.photonView.ObservedComponents = new System.Collections.Generic.List<UnityEngine.Component>();
            }
            
            this.photonView.ObservedComponents.Add(item:  this);
        }
        private void OnDestroy()
        {
            var val_5;
            if(0 != this.photonView)
            {
                    UnityEngine.Object.Destroy(obj:  0);
            }
            
            val_5 = null;
            val_5 = null;
            if(PhotonNetwork.SendMonoMessageTargets == null)
            {
                    return;
            }
            
            bool val_3 = PhotonNetwork.SendMonoMessageTargets.Remove(item:  this.gameObject);
        }
        private void Awake()
        {
            PhotonView val_9;
            var val_10;
            var val_11;
            if(0 == this.photonView)
            {
                    val_9 = this.GetComponent<PhotonView>();
                this.photonView = val_9;
            }
            else
            {
                    val_9 = this.photonView;
            }
            
            if((this.photonView.ObservedComponents.Contains(item:  this)) != true)
            {
                    this.photonView.ObservedComponents.Add(item:  this);
            }
            
            TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.Initialize();
            val_10 = null;
            val_10 = null;
            if(PhotonNetwork.SendMonoMessageTargets == null)
            {
                    val_11 = null;
                val_11 = null;
                PhotonNetwork.SendMonoMessageTargets = new System.Collections.Generic.HashSet<UnityEngine.GameObject>();
                val_10 = null;
            }
            
            val_10 = null;
            bool val_8 = Add(item:  this.gameObject);
        }
        public override bool get_HasUnassignedViewID()
        {
            return (bool)(this.photonView.viewID < 1) ? 1 : 0;
        }
        public override TzarGames.GameFramework.NetworkViewID get_ViewID()
        {
            Network_Photon.NetworkViewID_Photon val_5;
            if((TzarGames.GameFramework.NetworkViewID.op_Equality(a:  0, b:  this._viewId)) != false)
            {
                    TzarGames.GameFramework.NetworkViewID val_4 = null;
                val_5 = val_4;
                val_4 = new TzarGames.GameFramework.NetworkViewID();
                typeof(Network_Photon.NetworkViewID_Photon).__il2cppRuntimeField_10 = this.photonView.viewID;
                this._viewId = val_5;
                return (TzarGames.GameFramework.NetworkViewID)val_5;
            }
            
            val_5 = this._viewId;
            return (TzarGames.GameFramework.NetworkViewID)val_5;
        }
        public override int get_Group()
        {
            if(this.photonView != null)
            {
                    return (int)this.photonView.group;
            }
            
            return (int)this.photonView.group;
        }
        public override void set_Group(int value)
        {
            this.photonView.group = value;
        }
        protected override void RPC(string rpcName, TzarGames.GameFramework.TzarRPCModes mode, object[] args)
        {
            this.photonView.RPC(methodName:  rpcName, target:  TzarGames.GameFramework.NetworkSubsystem_Photon.NetworkView_Photon.getNetTarget(targetPlayer:  this), parameters:  args);
        }
        protected override void RPC(string rpcName, TzarGames.GameFramework.NetworkPlayer player, object[] args)
        {
            this.photonView.RPC(methodName:  rpcName, targetPlayer:  TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.GetNativeNetworkPlayer(player:  null), parameters:  args);
        }
        public override void SetViewID(TzarGames.GameFramework.NetworkViewID newId, TzarGames.GameFramework.NetworkPlayer player)
        {
            var val_3;
            if(newId != null)
            {
                    val_3 = null;
            }
            
            val_3 = null;
            var val_2 = (((TzarGames.GameFramework.NetworkViewID.__il2cppRuntimeField_typeHierarchy + Network_Photon.NetworkViewID_Photon.__il2cppRuntimeField_typeHierarchyDepth) + -8) == val_3) ? newId : 0;
            this.photonView.viewID = (TzarGames.GameFramework.NetworkViewID.__il2cppRuntimeField_typeHierarchy + Network_Photon.NetworkViewID_Photon.__il2cppRuntimeField_typeHierarchyDepth) + -8 == val_3 ? newId : 0 + 16;
        }
        protected override void UnreliableRPC(string rpcName, TzarGames.GameFramework.TzarRPCModes mode, object[] args)
        {
            this.photonView.UnreliableRPC(methodName:  rpcName, target:  TzarGames.GameFramework.NetworkSubsystem_Photon.NetworkView_Photon.getNetTarget(targetPlayer:  this), parameters:  args);
        }
        protected override void UnreliableRPC(string rpcName, TzarGames.GameFramework.NetworkPlayer player, object[] args)
        {
            this.photonView.UnreliableRPC(methodName:  rpcName, targetPlayer:  TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.GetNativeNetworkPlayer(player:  null), parameters:  args);
        }
        private void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
        {
            var val_7;
            var val_8;
            var val_9;
            TzarGames.GameFramework.NetworkSubsystem_Photon.PhotonBitStream val_1 = new TzarGames.GameFramework.NetworkSubsystem_Photon.PhotonBitStream(stream:  stream);
            TzarGames.GameFramework.NetworkPlayer val_2 = TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.GetOrCreatePlayerByNativeNetworkPlayer(nativePlayer:  null);
            TzarGames.GameFramework.INetworkMessageInfo val_3 = TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.CreateNetworkMessageInfo(player:  info.timeInt, timeStamp:  null);
            List.Enumerator<T> val_4 = info.timeInt.GetEnumerator();
            label_10:
            if((0 & 1) == 0)
            {
                goto label_4;
            }
            
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_7 = 0.InitializationCallback;
            goto label_10;
            label_4:
            val_8 = 0;
            val_9 = 1;
            0.Dispose();
            if((val_9 & 1) != 0)
            {
                    return;
            }
            
            if(val_8 == 0)
            {
                    return;
            }
        
        }
        private static PhotonTargets getNetTarget(TzarGames.GameFramework.TzarRPCModes targetPlayer)
        {
            var val_3 = 0;
            var val_2 = (W1 < 6) ? (W1 + 3) : 0;
            val_2 = val_2 - 4;
            if(val_2 > 4)
            {
                    return (PhotonTargets);
            }
            
            var val_3 = 25807672 + ((W1 < 0x6 ? (W1 + 3) : 0 - 4)) << 2;
            val_3 = val_3 + 25807672;
            goto (25807672 + ((W1 < 0x6 ? (W1 + 3) : 0 - 4)) << 2 + 25807672);
        }
        public override void UnassignViewID()
        {
            null = null;
            bool val_1 = PhotonNetwork.networkingPeer.LocalCleanPhotonView(view:  this.photonView);
            if(this.photonView.viewID != 0)
            {
                    this.photonView.viewID = 0;
            }
            
            this._viewId = 0;
        }
        public override void OnPulledFromPool()
        {
            this.OnPulledFromPool();
            this.photonView.enabled = true;
        }
        public override void OnPushedToPool()
        {
            this.OnPushedToPool();
            this.photonView.enabled = false;
        }
    
    }

}

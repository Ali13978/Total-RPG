using UnityEngine;

namespace TzarGames.GameFramework.NetworkSubsystem_Photon
{
    public class GameManagerNetSync_Photon : GameManagerNetSyncBase
    {
        // Methods
        public GameManagerNetSync_Photon()
        {
        
        }
        public override void Initialize(TzarGames.GameFramework.GameManager targetGameManager)
        {
            var val_6;
            this.Initialize(targetGameManager:  targetGameManager);
            if(TzarGames.GameFramework.GameManagerNetSyncBase.IsServer != false)
            {
                    if(this != null)
            {
                    val_6 = null;
            }
            
                val_6 = null;
                var val_3 = (((TzarGames.GameFramework.NetworkSubsystem_Photon.GameManagerNetSync_Photon.__il2cppRuntimeField_typeHierarchy + TzarGames.GameFramework.NetworkSubsystem_Photon.NetworkView_Photon.__il2cppRuntimeField_ + -8) == val_6) ? (this) : 0;
            }
            
            if(PhotonNetwork.connected != false)
            {
                    return;
            }
            
            PhotonNetwork.autoCleanUpPlayerObjects = false;
        }
        protected override TzarGames.GameFramework.INetInfoProvider InitializeNetInfoProvider()
        {
            return (TzarGames.GameFramework.INetInfoProvider)new TzarGames.GameFramework.NetworkSubsystem_Photon.PhotonNetInfoProvider();
        }
        protected override TzarGames.GameFramework.NetworkPlayer InitializeServerPlayer()
        {
            var val_7;
            PhotonPlayer val_8;
            val_7 = 1152921504973725696;
            if(PhotonNetwork.isMasterClient != false)
            {
                    val_7 = ???;
            }
            else
            {
                    PhotonPlayer val_2 = PhotonNetwork.masterClient;
                val_8 = null;
                return TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.GetOrCreatePlayerByNativeNetworkPlayer(nativePlayer:  val_8);
            }
        
        }
        public override TzarGames.GameFramework.INetworkMessageInfo CreateNetworkMessageInfo(TzarGames.GameFramework.NetworkPlayer player)
        {
            return TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.CreateNetworkMessageInfo(player:  null, timeStamp:  PhotonNetwork.time);
        }
        public override void CloseConnection(TzarGames.GameFramework.Player player, bool sendDisconnectNotification)
        {
            PhotonPlayer val_1 = TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.GetNativeNetworkPlayer(player:  null);
            bool val_2 = PhotonNetwork.CloseConnection(kickPlayer:  0);
        }
        public override void NetDestroy(UnityEngine.GameObject obj)
        {
            PhotonNetwork.Destroy(targetGo:  0);
        }
        protected override void SetNetViewVisibilityForPlayer(TzarGames.GameFramework.NetworkPlayer player, TzarGames.GameFramework.NetworkViewBase netView, bool visible)
        {
            UnityEngine.Debug.LogError(message:  0);
        }
        protected override void Handle_UnallocateViewID(TzarGames.GameFramework.NetworkViewID viewId)
        {
            TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.DeallocateNetworkViewID(viewId:  null);
        }
        protected override TzarGames.GameFramework.NetworkViewID Handle_AllocateNetworkViewID()
        {
            return TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.AllocateNetworkViewID();
        }
        public override void RemoveRPCs(TzarGames.GameFramework.NetworkViewBase netView)
        {
            var val_5;
            this.RemoveCustomBufferedRPCsByCaller(caller:  netView);
            if(netView != null)
            {
                    val_5 = null;
            }
            
            val_5 = null;
            var val_2 = (((TzarGames.GameFramework.NetworkViewBase.__il2cppRuntimeField_typeHierarchy + TzarGames.GameFramework.NetworkSubsystem_Photon.NetworkView_Photon.__il2cppRuntimeField_typeHierarchyDepth) + -8) == val_5) ? netView : 0;
            if(((TzarGames.GameFramework.NetworkViewBase.__il2cppRuntimeField_typeHierarchy + TzarGames.GameFramework.NetworkSubsystem_Photon.NetworkView_Photon.__il2cppRuntimeField_typeHierarchyDepth) + -8 == val_5 ? netView : 0 + 32.owner) == null)
            {
                    return;
            }
            
            PhotonPlayer val_4 = (TzarGames.GameFramework.NetworkViewBase.__il2cppRuntimeField_typeHierarchy + TzarGames.GameFramework.NetworkSubsystem_Photon.NetworkView_Photon.__il2cppRuntimeField_typeHierarchyDepth) + -8 == val_5 ? netView : 0 + 32.owner;
            if(val_4.IsLocal == false)
            {
                    return;
            }
            
            PhotonNetwork.RemoveRPCs(targetPhotonView:  0);
        }
        protected override TzarGames.GameFramework.NetworkPlayer GetOrCreateNetworkPlayerForLocalPlayer()
        {
            PhotonPlayer val_4;
            var val_5;
            PhotonPlayer val_1 = PhotonNetwork.player;
            val_4 = null;
            TzarGames.GameFramework.NetworkPlayer val_2 = TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.GetOrCreatePlayerByNativeNetworkPlayer(nativePlayer:  val_4);
            val_5 = 0;
            return (TzarGames.GameFramework.NetworkPlayer);
        }
        protected override TzarGames.GameFramework.NetworkPlayer[] GetAllNetworkPlayers()
        {
            goto label_4;
            label_14:
            var val_2 = null + ((X24) << 3);
            0 = 1;
            mem2[0] = val_1.Length;
            label_4:
            if(0 >= val_1.Length)
            {
                    return (TzarGames.GameFramework.NetworkPlayer[])null;
            }
            
            PhotonPlayer val_4 = PhotonNetwork.playerList[1];
            TzarGames.GameFramework.NetworkPlayer val_3 = TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.GetOrCreatePlayerByNativeNetworkPlayer(nativePlayer:  null);
            if((val_3 == null) || (val_3 != null))
            {
                goto label_14;
            }
            
            goto label_14;
        }
        protected override void RemoveNetworkPlayer(TzarGames.GameFramework.NetworkPlayer player)
        {
            var val_3;
            if(player != null)
            {
                    val_3 = null;
            }
            
            val_3 = null;
            var val_2 = (((TzarGames.GameFramework.NetworkPlayer.__il2cppRuntimeField_typeHierarchy + TzarGames.GameFramework.NetworkSubsystem_Photon.NetworkPlayer_Photon.__il2cppRuntimeField_typeHierarchyDepth) + -8) == val_3) ? player : 0;
            TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.RemoveNetworkPlayer(nativePlayer:  null);
        }
        protected override void SetupPlayerObjectNetworkView(TzarGames.GameFramework.Player player, TzarGames.GameFramework.NetworkViewBase networkView)
        {
            var val_6;
            UnityEngine.Object val_7;
            val_6 = 0;
            val_7 = 1152921504721543168;
            if(0 == )
            {
                goto label_6;
            }
            
            val_7 = mem[(TzarGames.GameFramework.NetworkViewBase.__il2cppRuntimeField_typeHierarchy + (TzarGames.GameFramework.NetworkSubsystem_Photon.NetworkView_Photon.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? networkView : 0 + 32];
            val_7 = (TzarGames.GameFramework.NetworkViewBase.__il2cppRuntimeField_typeHierarchy + (TzarGames.GameFramework.NetworkSubsystem_Photon.NetworkView_Photon.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? networkView : 0 + 32;
            if(0 != val_7)
            {
                goto label_10;
            }
            
            label_6:
            UnityEngine.Debug.LogError(message:  0);
            return;
            label_10:
            (TzarGames.GameFramework.NetworkViewBase.__il2cppRuntimeField_typeHierarchy + (TzarGames.GameFramework.NetworkSubsystem_Photon.NetworkView_Photon.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? networkView : 0 + 32.TransferOwnership(newOwner:  TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.GetNativeNetworkPlayer(player:  null));
        }
        private void OnJoinedRoom()
        {
            if(PhotonNetwork.isMasterClient != false)
            {
                    this.Handle_OnServerInitialized();
                return;
            }
            
            this.Handle_OnConnectedToServer();
        }
        private void OnPhotonPlayerDisconnected(PhotonPlayer player)
        {
            this.Handle_OnPlayerDisconnected(player:  TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.GetOrCreatePlayerByNativeNetworkPlayer(nativePlayer:  null));
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator photonPlayerDisconnectedRoutine(TzarGames.GameFramework.NetworkPlayer player)
        {
            if(null != 0)
            {
                    typeof(GameManagerNetSync_Photon.<photonPlayerDisconnectedRoutine>c__Iterator0).__il2cppRuntimeField_10 = player;
            }
            else
            {
                    mem[16] = player;
            }
            
            typeof(GameManagerNetSync_Photon.<photonPlayerDisconnectedRoutine>c__Iterator0).__il2cppRuntimeField_18 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void OnDisconnectedFromPhoton()
        {
            goto typeof(TzarGames.GameFramework.NetworkSubsystem_Photon.GameManagerNetSync_Photon).__il2cppRuntimeField_1F0;
        }
        private void OnPhotonPlayerConnected(PhotonPlayer connectedPlayer)
        {
            var val_11;
            var val_12;
            var val_13;
            System.Collections.Generic.IEnumerator<System.Collections.DictionaryEntry> val_3 = connectedPlayer.CustomProperties.GetEnumerator();
            label_16:
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_11 = val_3;
            if(((val_3 & 1) & 1) == 0)
            {
                goto label_26;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_12 = val_3;
            Add(key:  val_3.InitializationCallback.ToString(), value:  val_3);
            goto label_16;
            label_26:
            if(val_3 != null)
            {
                    var val_13 = 0;
                val_13 = val_13 + 1;
                val_13 = val_3;
            }
            
            this.Handle_OnPlayerConnected(connectedPlayer:  TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.GetOrCreatePlayerByNativeNetworkPlayer(nativePlayer:  null), localData:  new System.Collections.Generic.Dictionary<System.String, System.Object>());
        }
        private void OnMasterClientSwitched(PhotonPlayer newMasterClient)
        {
            this.Handle_OnServerChanged(newServerPlayer:  TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.GetOrCreatePlayerByNativeNetworkPlayer(nativePlayer:  null));
        }
        protected override bool ShouldSendClientDisconnectedEventToOtherClients()
        {
            return false;
        }
        [TzarGames.Common.ConsoleCommand]
        private static void pun_log(bool enable)
        {
            var val_3;
            var val_4;
            NetworkingPeer val_5;
            var val_6;
            var val_7;
            val_3 = null;
            if((W1 & 1) != 0)
            {
                    val_4 = null;
                PhotonNetwork.logLevel = 2;
                val_5 = PhotonNetwork.networkingPeer;
                val_6 = 5;
            }
            else
            {
                    val_7 = null;
                PhotonNetwork.logLevel = 0;
                val_5 = PhotonNetwork.networkingPeer;
                val_6 = 1;
            }
            
            PhotonNetwork.networkingPeer.__unknownFiledOffset_38 = val_6;
        }
    
    }

}

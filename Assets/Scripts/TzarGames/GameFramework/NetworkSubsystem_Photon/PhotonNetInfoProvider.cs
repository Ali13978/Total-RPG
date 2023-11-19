using UnityEngine;

namespace TzarGames.GameFramework.NetworkSubsystem_Photon
{
    internal class PhotonNetInfoProvider : INetInfoProvider
    {
        // Fields
        public const string AveragePingKey = "average_ping";
        public const string LastPingKey = "last_ping";
        
        // Properties
        public bool isServer { get; }
        public bool isClient { get; }
        public bool Connected { get; }
        public bool Connecting { get; }
        public bool Disconnecting { get; }
        public double NetworkTime { get; }
        
        // Methods
        public PhotonNetInfoProvider()
        {
        
        }
        public bool get_isServer()
        {
            if(PhotonNetwork.connected == false)
            {
                    return false;
            }
            
            return PhotonNetwork.isMasterClient;
        }
        public bool get_isClient()
        {
            return PhotonNetwork.isNonMasterClientInRoom;
        }
        public bool get_Connected()
        {
            return PhotonNetwork.connected;
        }
        public bool get_Connecting()
        {
            return PhotonNetwork.connecting;
        }
        public bool get_Disconnecting()
        {
            return (bool)(PhotonNetwork.connectionState == 3) ? 1 : 0;
        }
        public double get_NetworkTime()
        {
            return PhotonNetwork.time;
        }
        public int GetAveragePing(TzarGames.GameFramework.NetworkPlayer player)
        {
            var val_7;
            if(player != null)
            {
                    val_7 = null;
                val_7 = null;
                var val_1 = (((TzarGames.GameFramework.NetworkPlayer.__il2cppRuntimeField_typeHierarchy + (TzarGames.GameFramework.NetworkSubsystem_Photon.NetworkPlayer_Photon.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_7) ? player : 0;
            }
            
            object val_4 = 0.NativePlayer.CustomProperties.Item["average_ping"];
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            return (int)null;
        }
        public int GetLastPing(TzarGames.GameFramework.NetworkPlayer player)
        {
            var val_7;
            if(player != null)
            {
                    val_7 = null;
                val_7 = null;
                var val_1 = (((TzarGames.GameFramework.NetworkPlayer.__il2cppRuntimeField_typeHierarchy + (TzarGames.GameFramework.NetworkSubsystem_Photon.NetworkPlayer_Photon.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_7) ? player : 0;
            }
            
            object val_4 = 0.NativePlayer.CustomProperties.Item["last_ping"];
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            return (int)null;
        }
    
    }

}

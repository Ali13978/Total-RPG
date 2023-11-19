using UnityEngine;

namespace TzarGames.GameFramework.NetworkSubsystem_Photon
{
    internal static class Network_Photon
    {
        // Fields
        private static System.Collections.Generic.List<TzarGames.GameFramework.NetworkSubsystem_Photon.NetworkPlayerInfo> nativeToCommonPlayers;
        private static System.Collections.Generic.Dictionary<TzarGames.GameFramework.NetworkSubsystem_Photon.NetworkPlayer_Photon, PhotonPlayer> commonToNativePlayers;
        
        // Methods
        public static TzarGames.GameFramework.NetworkViewID AllocateNetworkViewID()
        {
            typeof(Network_Photon.NetworkViewID_Photon).__il2cppRuntimeField_10 = PhotonNetwork.AllocateViewID();
            return (TzarGames.GameFramework.NetworkViewID)new TzarGames.GameFramework.NetworkViewID();
        }
        public static void DeallocateNetworkViewID(TzarGames.GameFramework.NetworkViewID viewId)
        {
            var val_3;
            var val_5;
            if(X1 != 0)
            {
                    val_3 = null;
                val_5 = mem[X1 + 176];
                val_5 = X1 + 176;
            }
            
            val_3 = null;
            val_5 = mem[X1 + 176];
            val_5 = X1 + 176;
            var val_2 = (((X1 + 176 + Network_Photon.NetworkViewID_Photon.__il2cppRuntimeField_typeHierarchyDepth) + -8) == val_3) ? (X1) : 0;
            PhotonNetwork.UnAllocateViewID(viewID:  0);
        }
        public static TzarGames.GameFramework.INetworkMessageInfo CreateNetworkMessageInfo(TzarGames.GameFramework.NetworkPlayer player, double timeStamp)
        {
            typeof(Network_Photon.NetworkMessageInfo_Photon).__il2cppRuntimeField_18 = timeStamp;
            typeof(Network_Photon.NetworkMessageInfo_Photon).__il2cppRuntimeField_10 = X1;
            return (TzarGames.GameFramework.INetworkMessageInfo)new System.Object();
        }
        private static TzarGames.GameFramework.NetworkSubsystem_Photon.NetworkPlayer_Photon getNetworkPlayerByNative(PhotonPlayer nativePlayer)
        {
            var val_5;
            var val_6;
            val_5 = null;
            val_5 = null;
            List.Enumerator<T> val_1 = TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.nativeToCommonPlayers.GetEnumerator();
            label_6:
            if((0 & 1) == 0)
            {
                goto label_4;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_2 = 0.InitializationCallback;
            if((System.Object.ReferenceEquals(objA:  0, objB:  X1)) == false)
            {
                goto label_6;
            }
            
            0.Dispose();
            return (TzarGames.GameFramework.NetworkSubsystem_Photon.NetworkPlayer_Photon)val_6;
            label_4:
            0.Dispose();
            val_6 = 0;
            return (TzarGames.GameFramework.NetworkSubsystem_Photon.NetworkPlayer_Photon)val_6;
        }
        private static TzarGames.GameFramework.NetworkSubsystem_Photon.NetworkPlayerInfo removeNetworkPlayerByNative(PhotonPlayer nativePlayer)
        {
            var val_6;
            TzarGames.GameFramework.NetworkSubsystem_Photon.NetworkPlayerInfo val_7;
            System.Collections.Generic.List<TzarGames.GameFramework.NetworkSubsystem_Photon.NetworkPlayerInfo> val_8;
            var val_9;
            var val_10;
            val_6 = null;
            val_6 = null;
            List.Enumerator<T> val_1 = TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.nativeToCommonPlayers.GetEnumerator();
            label_6:
            if((0 & 1) == 0)
            {
                goto label_4;
            }
            
            val_7 = 0.InitializationCallback;
            if((System.Object.ReferenceEquals(objA:  0, objB:  X1)) == false)
            {
                goto label_6;
            }
            
            val_8 = 0;
            goto label_7;
            label_4:
            val_8 = 0;
            val_7 = 0;
            label_7:
            val_9 = 1;
            0.Dispose();
            if(val_7 == 0)
            {
                    return val_7;
            }
            
            val_10 = null;
            val_10 = null;
            val_8 = TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.nativeToCommonPlayers;
            bool val_5 = val_8.Remove(item:  val_7);
            return val_7;
        }
        public static TzarGames.GameFramework.NetworkPlayer GetOrCreatePlayerByNativeNetworkPlayer(PhotonPlayer nativePlayer)
        {
            TzarGames.GameFramework.NetworkSubsystem_Photon.NetworkPlayer_Photon val_4;
            var val_5;
            val_4 = TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.getNetworkPlayerByNative(nativePlayer:  null);
            if(val_4 != null)
            {
                    return (TzarGames.GameFramework.NetworkPlayer)val_4;
            }
            
            object val_2 = null;
            val_4 = val_2;
            val_2 = new System.Object();
            typeof(TzarGames.GameFramework.NetworkSubsystem_Photon.NetworkPlayer_Photon).__il2cppRuntimeField_10 = X1;
            if(null != 0)
            {
                    typeof(TzarGames.GameFramework.NetworkSubsystem_Photon.NetworkPlayerInfo).__il2cppRuntimeField_10 = X1;
            }
            else
            {
                    mem[16] = X1;
            }
            
            typeof(TzarGames.GameFramework.NetworkSubsystem_Photon.NetworkPlayerInfo).__il2cppRuntimeField_18 = val_4;
            val_5 = null;
            val_5 = null;
            TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.nativeToCommonPlayers.Add(item:  new System.Object());
            TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.commonToNativePlayers.Add(key:  val_4, value:  X1);
            return (TzarGames.GameFramework.NetworkPlayer)val_4;
        }
        public static PhotonPlayer GetNativePlayerByID(int id)
        {
            var val_3;
            if(val_1.Length >= 1)
            {
                    var val_3 = 0;
                do
            {
                if(1152921507646855696.ID == W1)
            {
                    return (PhotonPlayer)val_3;
            }
            
                val_3 = val_3 + 1;
            }
            while(val_3 < (long)val_1.Length);
            
            }
            
            val_3 = 0;
            return (PhotonPlayer)val_3;
        }
        public static PhotonPlayer GetNativeNetworkPlayer(TzarGames.GameFramework.NetworkPlayer player)
        {
            var val_5;
            var val_6;
            PhotonPlayer val_2 = 0;
            val_5 = null;
            val_5 = null;
            val_6 = 0;
            return (PhotonPlayer)((TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.commonToNativePlayers.TryGetValue(key:  null, value: out  val_2)) != true) ? (val_2) : 0;
        }
        public static void RemoveNetworkPlayer(PhotonPlayer nativePlayer)
        {
            var val_3;
            if((TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.removeNetworkPlayerByNative(nativePlayer:  null)) == null)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            bool val_2 = TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.commonToNativePlayers.Remove(key:  val_1.NetworkPlayer);
        }
        private static Network_Photon()
        {
            TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.nativeToCommonPlayers = new System.Collections.Generic.List<TzarGames.GameFramework.NetworkSubsystem_Photon.NetworkPlayerInfo>();
            TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.commonToNativePlayers = new System.Collections.Generic.Dictionary<TzarGames.GameFramework.NetworkSubsystem_Photon.NetworkPlayer_Photon, PhotonPlayer>();
        }
    
    }

}

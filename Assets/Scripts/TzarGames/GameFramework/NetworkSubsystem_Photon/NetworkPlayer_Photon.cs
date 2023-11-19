using UnityEngine;

namespace TzarGames.GameFramework.NetworkSubsystem_Photon
{
    public class NetworkPlayer_Photon : NetworkPlayer
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private PhotonPlayer <NativePlayer>k__BackingField;
        
        // Properties
        public PhotonPlayer NativePlayer { get; set; }
        public override bool ItsMe { get; }
        public override bool IsConnected { get; }
        public override int ID { get; }
        
        // Methods
        internal NetworkPlayer_Photon(PhotonPlayer player)
        {
            val_1 = new System.Object();
            this.<NativePlayer>k__BackingField = player;
        }
        public PhotonPlayer get_NativePlayer()
        {
            return (PhotonPlayer)this.<NativePlayer>k__BackingField;
        }
        public void set_NativePlayer(PhotonPlayer value)
        {
            this.<NativePlayer>k__BackingField = value;
        }
        public override bool get_ItsMe()
        {
            return (bool)((this.<NativePlayer>k__BackingField) == PhotonNetwork.player) ? 1 : 0;
        }
        public override bool get_IsConnected()
        {
            return PhotonNetwork.connected;
        }
        public override int get_ID()
        {
            if((this.<NativePlayer>k__BackingField) != null)
            {
                    return this.<NativePlayer>k__BackingField.ID;
            }
            
            return this.<NativePlayer>k__BackingField.ID;
        }
    
    }

}

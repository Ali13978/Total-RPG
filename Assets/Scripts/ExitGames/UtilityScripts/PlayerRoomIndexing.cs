using UnityEngine;

namespace ExitGames.UtilityScripts
{
    public class PlayerRoomIndexing : PunBehaviour
    {
        // Fields
        public static ExitGames.UtilityScripts.PlayerRoomIndexing instance;
        public ExitGames.UtilityScripts.PlayerRoomIndexing.RoomIndexingChanged OnRoomIndexingChanged;
        public const string RoomPlayerIndexedProp = "PlayerIndexes";
        private int[] _playerIds;
        private object _indexes;
        private System.Collections.Generic.Dictionary<int, int> _indexesLUT;
        private System.Collections.Generic.List<bool> _indexesPool;
        private PhotonPlayer _p;
        
        // Properties
        public int[] PlayerIds { get; }
        
        // Methods
        public PlayerRoomIndexing()
        {
        
        }
        public int[] get_PlayerIds()
        {
            return (System.Int32[])this._playerIds;
        }
        public void Awake()
        {
            if(0 != ExitGames.UtilityScripts.PlayerRoomIndexing.RoomPlayerIndexedProp)
            {
                    UnityEngine.Debug.LogError(message:  0);
            }
            
            ExitGames.UtilityScripts.PlayerRoomIndexing.RoomPlayerIndexedProp = this;
            if(PhotonNetwork.room == null)
            {
                    return;
            }
            
            this.SanitizeIndexing(forceIndexing:  true);
        }
        public override void OnJoinedRoom()
        {
            if(PhotonNetwork.isMasterClient != false)
            {
                    this.AssignIndex(player:  PhotonNetwork.player);
                return;
            }
            
            this.RefreshData();
        }
        public override void OnLeftRoom()
        {
            this.RefreshData();
        }
        public override void OnPhotonPlayerConnected(PhotonPlayer newPlayer)
        {
            if(PhotonNetwork.isMasterClient == false)
            {
                    return;
            }
            
            this.AssignIndex(player:  newPlayer);
        }
        public override void OnPhotonPlayerDisconnected(PhotonPlayer otherPlayer)
        {
            if(PhotonNetwork.isMasterClient == false)
            {
                    return;
            }
            
            this.UnAssignIndex(player:  otherPlayer);
        }
        public override void OnPhotonCustomRoomPropertiesChanged(ExitGames.Client.Photon.Hashtable propertiesThatChanged)
        {
            if((propertiesThatChanged.ContainsKey(key:  "PlayerIndexes")) == false)
            {
                    return;
            }
            
            this.RefreshData();
        }
        public override void OnMasterClientSwitched(PhotonPlayer newMasterClient)
        {
            if(PhotonNetwork.isMasterClient == false)
            {
                    return;
            }
            
            this.SanitizeIndexing(forceIndexing:  false);
        }
        public int GetRoomIndex(PhotonPlayer player)
        {
            if(this._indexesLUT == null)
            {
                    return 0;
            }
            
            if((this._indexesLUT.ContainsKey(key:  player.ID)) == false)
            {
                    return 0;
            }
            
            if(this._indexesLUT != null)
            {
                    return this._indexesLUT.Item[player.ID];
            }
            
            return this._indexesLUT.Item[player.ID];
        }
        private void SanitizeIndexing(bool forceIndexing = False)
        {
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            if(forceIndexing != true)
            {
                    if(PhotonNetwork.isMasterClient == false)
            {
                    return;
            }
            
            }
            
            if(PhotonNetwork.room == null)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_4 = null;
            val_16 = val_4;
            val_4 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
            if((PhotonNetwork.room.CustomProperties.TryGetValue(key:  "PlayerIndexes", value: out  this._indexes)) == false)
            {
                goto label_12;
            }
            
            val_16 = mem[this._indexes];
            if(val_16 == 0)
            {
                goto label_16;
            }
            
            label_12:
            if(val_16 == 0)
            {
                goto label_16;
            }
            
            val_17 = 0;
            goto label_17;
            label_16:
            val_16 = 0;
            val_17 = 1;
            label_17:
            val_15 = val_16.Count;
            if(val_15 == PhotonNetwork.room.PlayerCount)
            {
                    return;
            }
            
            val_15 = PhotonNetwork.playerList;
            val_18 = 0;
            goto label_24;
            label_31:
            val_18 = 1;
            label_24:
            if(val_18 >= val_12.Length)
            {
                    return;
            }
            
            PhotonPlayer val_15 = val_15[1];
            val_15[1] = val_16.ContainsKey(key:  val_15.ID);
            if(val_15[1] == true)
            {
                goto label_31;
            }
            
            this.AssignIndex(player:  val_15);
            goto label_31;
        }
        private void RefreshData()
        {
            var val_10;
            ExitGames.Client.Photon.Hashtable val_16;
            if(PhotonNetwork.room == null)
            {
                goto label_3;
            }
            
            int val_3 = PhotonNetwork.room.MaxPlayers;
            this._playerIds = null;
            val_16 = PhotonNetwork.room.CustomProperties;
            if((val_16.TryGetValue(key:  "PlayerIndexes", value: out  this._indexes)) == false)
            {
                goto label_21;
            }
            
            this._indexesLUT = 0;
            Dictionary.Enumerator<TKey, TValue> val_8 = 0.GetEnumerator();
            goto label_13;
            label_18:
            var val_11 = X26 + (((long)(int)(this._indexes)) << 2);
            mem2[0] = val_16;
            label_13:
            if((0 & 1) == 0)
            {
                goto label_25;
            }
            
            GooglePlayGames.BasicApi.ResponseStatus val_13 = val_10.InitializationCallback.Status;
            this._p = PhotonPlayer.Find(ID:  0);
            if( < this._playerIds.Length)
            {
                goto label_18;
            }
            
            goto label_18;
            label_25:
            val_10.Dispose();
            if((( & 1) != 0) || (this._p.ID == 0))
            {
                goto label_21;
            }
            
            goto label_21;
            label_3:
            this._playerIds = null;
            label_21:
            if(this.OnRoomIndexingChanged == null)
            {
                    return;
            }
            
            this.OnRoomIndexingChanged.Invoke();
        }
        private void AssignIndex(PhotonPlayer player)
        {
            var val_12;
            var val_19;
            System.Collections.Generic.List<T> val_20;
            var val_21;
            if((PhotonNetwork.room.CustomProperties.TryGetValue(key:  "PlayerIndexes", value: out  this._indexes)) == false)
            {
                goto label_5;
            }
            
            val_19 = 0;
            goto label_8;
            label_5:
            this._indexesLUT = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
            goto label_9;
            label_8:
            this._indexesLUT = ;
            label_9:
            int val_8 = PhotonNetwork.room.MaxPlayers;
            System.Collections.Generic.List<System.Boolean> val_9 = new System.Collections.Generic.List<System.Boolean>(collection:  null);
            Dictionary.Enumerator<TKey, TValue> val_10 = this._indexesLUT.GetEnumerator();
            label_16:
            if((0 & 1) == 0)
            {
                goto label_14;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_13 = val_12.InitializationCallback;
            set_Item(index:  -720324344, value:  true);
            goto label_16;
            label_14:
            val_20 = 0;
            val_21 = 1;
            val_12.Dispose();
            int val_15 = IndexOf(item:  false);
            this._indexesLUT.set_Item(key:  player.ID, value:  UnityEngine.Mathf.Max(a:  0, b:  0));
            Add(key:  "PlayerIndexes", value:  this._indexesLUT);
            PhotonNetwork.room.SetCustomProperties(propertiesToSet:  new ExitGames.Client.Photon.Hashtable(), expectedValues:  0, webForward:  false);
            this.RefreshData();
        }
        private void UnAssignIndex(PhotonPlayer player)
        {
            object val_10;
            var val_11;
            val_10 = this._indexes;
            if((PhotonNetwork.room.CustomProperties.TryGetValue(key:  "PlayerIndexes", value: out  val_10)) != false)
            {
                    val_11 = 0;
                this._indexesLUT = ;
                bool val_7 = Remove(key:  player.ID);
                ExitGames.Client.Photon.Hashtable val_9 = null;
                val_10 = val_9;
                val_9 = new ExitGames.Client.Photon.Hashtable();
                Add(key:  "PlayerIndexes", value:  this._indexesLUT);
                PhotonNetwork.room.SetCustomProperties(propertiesToSet:  val_10, expectedValues:  0, webForward:  false);
            }
            
            this.RefreshData();
        }
    
    }

}

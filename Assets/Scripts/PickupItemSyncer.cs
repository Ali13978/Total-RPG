using UnityEngine;
[UnityEngine.RequireComponent]
public class PickupItemSyncer : MonoBehaviour
{
    // Fields
    public bool IsWaitingForPickupInit;
    private const float TimeDeltaToIgnore = 0.2;
    
    // Methods
    public PickupItemSyncer()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }
    public void OnPhotonPlayerConnected(PhotonPlayer newPlayer)
    {
        if(PhotonNetwork.isMasterClient == false)
        {
                return;
        }
        
        this.SendPickedUpItems(targetPlayer:  newPlayer);
    }
    public void OnJoinedRoom()
    {
        typeof(System.Object[]).__il2cppRuntimeField_20 = "Joined Room. isMasterClient: ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = PhotonNetwork.isMasterClient;
        typeof(System.Object[]).__il2cppRuntimeField_29 = 30754421;
        typeof(System.Object[]).__il2cppRuntimeField_30 = " id: ";
        PhotonPlayer val_3 = PhotonNetwork.player;
        typeof(System.Object[]).__il2cppRuntimeField_38 = val_3.actorID;
        typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
        string val_4 = +0;
        UnityEngine.Debug.Log(message:  0);
        bool val_7 = ~PhotonNetwork.isMasterClient;
        val_7 = val_7 & 1;
        this.IsWaitingForPickupInit = val_7;
        PhotonPlayer[] val_6 = PhotonNetwork.playerList;
        if(val_6.Length < 2)
        {
                return;
        }
        
        this.Invoke(methodName:  "AskForPickupItemSpawnTimes", time:  2f);
    }
    public void AskForPickupItemSpawnTimes()
    {
        PhotonPlayer val_12;
        var val_13;
        if(this.IsWaitingForPickupInit == false)
        {
                return;
        }
        
        PhotonPlayer[] val_1 = PhotonNetwork.playerList;
        if(val_1.Length <= 1)
        {
            goto label_5;
        }
        
        val_12 = PhotonNetwork.masterClient.GetNextFor(currentPlayerId:  val_2.actorID);
        if(val_12 != null)
        {
                if((val_12.Equals(other:  PhotonNetwork.player)) == false)
        {
            goto label_12;
        }
        
        }
        
        val_12 = PhotonNetwork.player.GetNextFor(currentPlayerId:  val_6.actorID);
        label_12:
        if(val_12 != null)
        {
                if((val_12.Equals(other:  PhotonNetwork.player)) == false)
        {
            goto label_19;
        }
        
        }
        
        val_13 = "No player left to ask";
        goto label_22;
        label_5:
        val_13 = "Cant ask anyone else for PickupItem spawn times.";
        label_22:
        UnityEngine.Debug.Log(message:  0);
        this.IsWaitingForPickupInit = false;
        return;
        label_19:
        this.photonView.RPC(methodName:  "RequestForPickupItems", targetPlayer:  val_12, parameters:  null);
    }
    [TzarRPC]
    [System.ObsoleteAttribute]
    public void RequestForPickupTimes(PhotonMessageInfo msgInfo)
    {
        this.RequestForPickupItems(msgInfo:  new PhotonMessageInfo() {timeInt = msgInfo.timeInt, photonView = msgInfo.photonView});
    }
    [TzarRPC]
    public void RequestForPickupItems(PhotonMessageInfo msgInfo)
    {
        if(msgInfo.sender != null)
        {
                this.SendPickedUpItems(targetPlayer:  msgInfo.sender);
            return;
        }
        
        UnityEngine.Debug.LogError(message:  0);
    }
    private void SendPickedUpItems(PhotonPlayer targetPlayer)
    {
        var val_17;
        var val_18;
        var val_19;
        if(targetPlayer != null)
        {
                val_17 = null;
        }
        else
        {
                UnityEngine.Debug.LogWarning(message:  0);
            return;
        }
        
        int val_2 = PickupItem.DisabledPickupItems.Count;
        PickupItem.DisabledPickupItems.CopyTo(array:  null);
        double val_3 = PhotonNetwork.time + 0.200000002980232;
        null = new System.Collections.Generic.List<System.Single>(capacity:  PickupItem[].__il2cppRuntimeField_namespaze << 1);
        val_18 = 0;
        goto label_18;
        label_64:
        val_18 = 1;
        label_18:
        float val_17 = PhotonNetwork.time;
        PhotonView val_7 = PickupItem[].__il2cppRuntimeField_this_arg.photonView;
        typeof(System.Object[]).__il2cppRuntimeField_20 = val_7.viewIdField;
        typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_28 = " respawn: ";
        typeof(System.Object[]).__il2cppRuntimeField_30 = PickupItem[].__il2cppRuntimeField_this_arg + 56;
        val_17 = (PickupItem[].__il2cppRuntimeField_this_arg + 56) - val_17;
        typeof(System.Object[]).__il2cppRuntimeField_38 = " timeUntilRespawn: ";
        typeof(System.Object[]).__il2cppRuntimeField_40 = val_17;
        typeof(System.Object[]).__il2cppRuntimeField_48 = " (now: ";
        typeof(System.Object[]).__il2cppRuntimeField_50 = PhotonNetwork.time;
        typeof(System.Object[]).__il2cppRuntimeField_58 = ")";
        string val_9 = +0;
        UnityEngine.Debug.Log(message:  0);
        PhotonView val_10 = PickupItem[].__il2cppRuntimeField_this_arg.photonView;
        if(null != 0)
        {
                Add(item:  (float)val_10.viewIdField);
        }
        else
        {
                Add(item:  (float)val_10.viewIdField);
        }
        
        val_19 = public System.Void System.Collections.Generic.List<System.Single>::Add(System.Single item);
        Add(item:  (float)val_17);
        goto label_64;
    }
    [TzarRPC]
    public void PickupItemInit(double timeBase, float[] inactivePickupsAndTimes)
    {
        int val_6;
        this.IsWaitingForPickupInit = false;
        var val_10 = 0;
        var val_7 = 0;
        goto label_1;
        label_41:
        19194.PickedUp(timeUntilRespawn:  timeBase);
        label_1:
        val_6 = inactivePickupsAndTimes.Length;
        val_7 = val_7 + 1;
        if(val_7 >= (((val_6 < 0) ? (val_6 + 1) : (val_6)) >> 1))
        {
                return;
        }
        
        if(val_10 >= val_6)
        {
                val_6 = inactivePickupsAndTimes.Length;
        }
        
        float val_8 = inactivePickupsAndTimes[0];
        float val_9 = inactivePickupsAndTimes[(long)val_10 + 1];
        val_10 = val_10 + 2;
        PickupItem val_4 = PhotonView.Find(viewID:  19194).GetComponent<PickupItem>();
        if(val_9 <= 0f)
        {
            goto label_7;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_20 = val_3.viewIdField;
        typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
        double val_11 = (double)val_9;
        val_11 = val_11 + timeBase;
        typeof(System.Object[]).__il2cppRuntimeField_28 = " respawn: ";
        typeof(System.Object[]).__il2cppRuntimeField_30 = val_11;
        typeof(System.Object[]).__il2cppRuntimeField_38 = " timeUntilRespawnBasedOnTimeBase:";
        typeof(System.Object[]).__il2cppRuntimeField_40 = val_9;
        typeof(System.Object[]).__il2cppRuntimeField_44 = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_48 = " SecondsBeforeRespawn: ";
        typeof(System.Object[]).__il2cppRuntimeField_50 = val_4.SecondsBeforeRespawn;
        typeof(System.Object[]).__il2cppRuntimeField_54 = 268435457;
        string val_5 = +0;
        UnityEngine.Debug.Log(message:  0);
        val_11 = val_11 - PhotonNetwork.time;
        if(val_4 != null)
        {
            goto label_41;
        }
        
        goto label_41;
        label_7:
        if(val_4 != null)
        {
            goto label_41;
        }
        
        goto label_41;
    }

}

using UnityEngine;
public class PunTeams : MonoBehaviour
{
    // Fields
    public static System.Collections.Generic.Dictionary<PunTeams.Team, System.Collections.Generic.List<PhotonPlayer>> PlayersPerTeam;
    public const string TeamPlayerProp = "team";
    
    // Methods
    public PunTeams()
    {
    
    }
    public void Start()
    {
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        PunTeams.TeamPlayerProp = new System.Collections.Generic.Dictionary<Team, System.Collections.Generic.List<PhotonPlayer>>();
        System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        System.Collections.IEnumerator val_4 = System.Enum.GetValues(enumType:  0).GetEnumerator();
        label_20:
        var val_12 = 0;
        val_12 = val_12 + 1;
        val_12 = val_4;
        if(((val_4 & 1) & 1) == 0)
        {
            goto label_29;
        }
        
        var val_13 = 0;
        val_13 = val_13 + 1;
        val_13 = val_4;
        System.Collections.Generic.List<PhotonPlayer> val_8 = new System.Collections.Generic.List<PhotonPlayer>();
        UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        set_Item(key:  null, value:  null);
        goto label_20;
        label_30:
        val_14 = PunTeams.TeamPlayerProp;
        if(1152921504608018432 != 1)
        {
            goto label_21;
        }
        
        label_29:
        if(val_4 != null)
        {
                var val_14 = 0;
            val_14 = val_14 + 1;
            val_15 = val_4;
        }
        
        if(0 == 102)
        {
                return;
        }
        
        if(null == 0)
        {
                return;
        }
        
        return;
        label_21:
        goto label_30;
    }
    public void OnDisable()
    {
        PunTeams.TeamPlayerProp = new System.Collections.Generic.Dictionary<Team, System.Collections.Generic.List<PhotonPlayer>>();
    }
    public void OnJoinedRoom()
    {
        this.UpdateTeams();
    }
    public void OnLeftRoom()
    {
        this.Start();
    }
    public void OnPhotonPlayerPropertiesChanged(object[] playerAndUpdatedProps)
    {
        this.UpdateTeams();
    }
    public void OnPhotonPlayerDisconnected(PhotonPlayer otherPlayer)
    {
        this.UpdateTeams();
    }
    public void OnPhotonPlayerConnected(PhotonPlayer newPlayer)
    {
        this.UpdateTeams();
    }
    public void UpdateTeams()
    {
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        System.Collections.IEnumerator val_3 = System.Enum.GetValues(enumType:  0).GetEnumerator();
        label_21:
        var val_15 = 0;
        val_15 = val_15 + 1;
        val_15 = val_3;
        if(((val_3 & 1) & 1) == 0)
        {
            goto label_42;
        }
        
        var val_16 = 0;
        val_16 = val_16 + 1;
        val_16 = val_3;
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        System.Collections.Generic.List<PhotonPlayer> val_8 = PunTeams.TeamPlayerProp.Item[null];
        val_8.Clear();
        goto label_21;
        label_43:
        val_17 = val_8;
        if((public System.Void System.Collections.Generic.List<PhotonPlayer>::Clear()) != 1)
        {
            goto label_22;
        }
        
        label_42:
        if(val_3 != null)
        {
                var val_17 = 0;
            val_17 = val_17 + 1;
            val_18 = val_3;
        }
        
        val_19 = 0;
        if((0 == 92) || (null == null))
        {
            goto label_30;
        }
        
        val_19 = 0;
        goto label_30;
        label_41:
        1152921504617496576.Add(item:  val_3);
        val_19 = 1;
        label_30:
        PhotonPlayer[] val_10 = PhotonNetwork.playerList;
        if(val_19 >= val_10.Length)
        {
                return;
        }
        
        PhotonPlayer val_18 = PhotonNetwork.playerList[1];
        if((PunTeams.TeamPlayerProp.Item[TeamExtensions.GetTeam(player:  0)]) != null)
        {
            goto label_41;
        }
        
        goto label_41;
        label_22:
        goto label_43;
    }

}

using UnityEngine;
[System.Runtime.CompilerServices.ExtensionAttribute]
public static class TeamExtensions
{
    // Methods
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static PunTeams.Team GetTeam(PhotonPlayer player)
    {
        var val_6;
        var val_7;
        val_6 = X1.CustomProperties;
        if((val_6.TryGetValue(key:  "team", value: out  0)) != false)
        {
                val_6 = null;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            val_7 = 127;
            return (Team)val_7;
        }
        
        val_7 = 0;
        return (Team)val_7;
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static void SetTeam(PhotonPlayer player, PunTeams.Team team)
    {
        var val_8;
        ExitGames.Client.Photon.Hashtable val_9;
        val_8 = team;
        val_9 = 1152921504973725696;
        bool val_1 = PhotonNetwork.connectedAndReady;
        if(val_1 != false)
        {
                if(((TeamExtensions.GetTeam(player:  val_1)) & 255) == W2)
        {
                return;
        }
        
            ExitGames.Client.Photon.Hashtable val_5 = null;
            val_9 = val_5;
            val_5 = new ExitGames.Client.Photon.Hashtable();
            Add(key:  "team", value:  W2);
            val_8.SetCustomProperties(propertiesToSet:  val_9, expectedValues:  0, webForward:  false);
            return;
        }
        
        val_8 = 0 + "JoinTeam was called in state: "("JoinTeam was called in state: ") + PhotonNetwork.connectionStateDetailed;
        UnityEngine.Debug.LogWarning(message:  0);
    }

}

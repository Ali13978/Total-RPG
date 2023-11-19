using UnityEngine;
public class MultiplayerManagerExample : MonoBehaviour
{
    // Methods
    public MultiplayerManagerExample()
    {
    
    }
    private void Awake()
    {
        GameCenterManager.Init();
        System.Action<GK_RTM_MatchStartedResult> val_1 = new System.Action<GK_RTM_MatchStartedResult>(object:  this, method:  System.Void MultiplayerManagerExample::HandleActionMatchStarted(GK_RTM_MatchStartedResult result));
        GameCenter_RTM.add_ActionMatchStarted(value:  0);
        System.Action<GK_Player, GK_PlayerConnectionState, GK_RTM_Match> val_2 = new System.Action<GK_Player, GK_PlayerConnectionState, GK_RTM_Match>(object:  this, method:  System.Void MultiplayerManagerExample::HandleActionPlayerStateChanged(GK_Player player, GK_PlayerConnectionState state, GK_RTM_Match match));
        GameCenter_RTM.add_ActionPlayerStateChanged(value:  0);
        System.Action<GK_Player, System.Byte[]> val_3 = new System.Action<GK_Player, System.Byte[]>(object:  this, method:  System.Void MultiplayerManagerExample::HandleActionDataReceived(GK_Player player, byte[] data));
        GameCenter_RTM.add_ActionDataReceived(value:  0);
        System.Action<GK_MatchType, System.String[], GK_Player[]> val_4 = new System.Action<GK_MatchType, System.String[], GK_Player[]>(object:  this, method:  System.Void MultiplayerManagerExample::HandleActionPlayerRequestedMatchWithRecipients(GK_MatchType matchType, string[] recepientIds, GK_Player[] recepients));
        GameCenterInvitations.add_ActionPlayerRequestedMatchWithRecipients(value:  0);
        System.Action<GK_MatchType, GK_Invite> val_5 = new System.Action<GK_MatchType, GK_Invite>(object:  this, method:  System.Void MultiplayerManagerExample::HandleActionPlayerAcceptedInvitation(GK_MatchType math, GK_Invite invite));
        GameCenterInvitations.add_ActionPlayerAcceptedInvitation(value:  0);
    }
    private void HandleActionPlayerAcceptedInvitation(GK_MatchType math, GK_Invite invite)
    {
        SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.StartMatchWithInvite(invite:  invite, useNativeUI:  true);
    }
    private void HandleActionPlayerRequestedMatchWithRecipients(GK_MatchType matchType, string[] recepientIds, GK_Player[] recepients)
    {
        ISN_Logger.Log(message:  16854, logType:  "inictation received");
        if(matchType != 1)
        {
                return;
        }
        
        SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.FindMatchWithNativeUI(minPlayers:  recepientIds.Length, maxPlayers:  recepientIds.Length, msg:  "Come play with me, bro.", playersToInvite:  recepientIds);
    }
    private void OnGUI()
    {
    
    }
    private void HandleActionPlayerStateChanged(GK_Player player, GK_PlayerConnectionState state, GK_RTM_Match match)
    {
        typeof(System.Object[]).__il2cppRuntimeField_20 = "Player State Changed ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = player.Alias;
        typeof(System.Object[]).__il2cppRuntimeField_30 = " state: ";
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        typeof(System.Object[]).__il2cppRuntimeField_38 = state.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_40 = "\n  ExpectedPlayerCount: ";
        typeof(System.Object[]).__il2cppRuntimeField_48 = match.ExpectedPlayerCount;
        typeof(System.Object[]).__il2cppRuntimeField_4C = 268435457;
        string val_5 = +0;
        ISN_Logger.Log(message:  val_5, logType:  val_5);
    }
    private void HandleActionMatchStarted(GK_RTM_MatchStartedResult result)
    {
        if(result == null)
        {
            goto label_1;
        }
        
        if(result.IsSucceeded == true)
        {
            goto label_2;
        }
        
        goto label_4;
        label_1:
        if(0.IsSucceeded == false)
        {
            goto label_4;
        }
        
        label_2:
        int val_6 = result.Match.Players.Count;
        string val_7 = 0 + "let\'s play now\n  Others players count: "("let\'s play now\n  Others players count: ");
        return;
        label_4:
        string val_9 = result.Error.Message;
    }
    private void HandleActionDataReceived(GK_Player player, byte[] data)
    {
    
    }

}

using UnityEngine;
public class TBM_Multiplayer_Example : BaseIOSFeaturePreview
{
    // Fields
    private static bool IsInitialized;
    
    // Properties
    public GK_TBM_Match CurrentMatch { get; }
    
    // Methods
    public TBM_Multiplayer_Example()
    {
    
    }
    private void Awake()
    {
        var val_13;
        var val_14;
        val_13 = null;
        val_13 = null;
        if(TBM_Multiplayer_Example.IsInitialized != true)
        {
                GameCenterManager.Init();
            System.Action<SA.Common.Models.Result> val_1 = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void TBM_Multiplayer_Example::OnAuthFinished(SA.Common.Models.Result res));
            GameCenterManager.add_OnAuthFinished(value:  0);
            val_14 = null;
            val_14 = null;
            TBM_Multiplayer_Example.IsInitialized = true;
        }
        
        SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.SetPlayerAttributes(attributes:  4);
        typeof(System.String[]).__il2cppRuntimeField_20 = GameCenterManager.FriendsList.Item[0];
        SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.FindMatchWithNativeUI(minPlayers:  2, maxPlayers:  2, msg:  "Come play with me, bro.", playersToInvite:  null);
        GK_Player val_6 = GameCenterManager.Player;
        System.Action<GK_UserPhotoLoadResult> val_7 = new System.Action<GK_UserPhotoLoadResult>(object:  this, method:  System.Void TBM_Multiplayer_Example::HandleOnPlayerPhotoLoaded(GK_UserPhotoLoadResult result));
        if(val_6 != null)
        {
                val_6.add_OnPlayerPhotoLoaded(value:  val_7);
        }
        else
        {
                0.add_OnPlayerPhotoLoaded(value:  val_7);
        }
        
        val_6.LoadPhoto(size:  1);
        System.Action<GK_RTM_MatchStartedResult> val_8 = new System.Action<GK_RTM_MatchStartedResult>(object:  this, method:  System.Void TBM_Multiplayer_Example::HandleActionMatchStarted(GK_RTM_MatchStartedResult result));
        GameCenter_RTM.add_ActionMatchStarted(value:  0);
        System.Action<GK_MatchType, System.String[], GK_Player[]> val_9 = new System.Action<GK_MatchType, System.String[], GK_Player[]>(object:  this, method:  System.Void TBM_Multiplayer_Example::HandleActionPlayerRequestedMatchWithRecipients(GK_MatchType matchType, string[] recepientIds, GK_Player[] recepients));
        GameCenterInvitations.add_ActionPlayerRequestedMatchWithRecipients(value:  0);
        System.Action<GK_MatchType, GK_Invite> val_10 = new System.Action<GK_MatchType, GK_Invite>(object:  this, method:  System.Void TBM_Multiplayer_Example::HandleActionPlayerAcceptedInvitation(GK_MatchType matchType, GK_Invite invite));
        GameCenterInvitations.add_ActionPlayerAcceptedInvitation(value:  0);
        System.Action<GK_Player, System.Boolean> val_11 = new System.Action<GK_Player, System.Boolean>(object:  this, method:  System.Void TBM_Multiplayer_Example::HandleActionNearbyPlayerStateUpdated(GK_Player player, bool IsAvaliable));
        GameCenter_RTM.add_ActionNearbyPlayerStateUpdated(value:  0);
        SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.StartBrowsingForNearbyPlayers();
    }
    private void HandleActionNearbyPlayerStateUpdated(GK_Player player, bool IsAvaliable)
    {
        typeof(System.Object[]).__il2cppRuntimeField_20 = "Player: ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = player.DisplayName;
        typeof(System.Object[]).__il2cppRuntimeField_30 = "IsAvaliable: ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = IsAvaliable;
        typeof(System.Object[]).__il2cppRuntimeField_39 = 22540684;
        ISN_Logger.Log(message:  0, logType:  +0);
        int val_6 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.NearbyPlayers.Count;
        ISN_Logger.Log(message:  0, logType:  0 + "Nearby Players Count: "("Nearby Players Count: "));
    }
    private void HandleActionPlayerAcceptedInvitation(GK_MatchType matchType, GK_Invite invite)
    {
        if(matchType != 1)
        {
                return;
        }
        
        SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.StartMatchWithInvite(invite:  invite, useNativeUI:  true);
    }
    private void HandleActionPlayerRequestedMatchWithRecipients(GK_MatchType matchType, string[] recepientIds, GK_Player[] recepients)
    {
        if(matchType != 1)
        {
                return;
        }
        
        SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.FindMatchWithNativeUI(minPlayers:  recepientIds.Length, maxPlayers:  recepientIds.Length, msg:  "Come play with me, bro.", playersToInvite:  recepientIds);
    }
    private void HandleActionMatchStarted(GK_RTM_MatchStartedResult result)
    {
        if(true != 0)
        {
                ISN_Logger.Log(message:  0, logType:  0 + "Match is creation failed with error: "("Match is creation failed with error: "));
            return;
        }
        
        ISN_Logger.Log(message:  0, logType:  "Match is successfully created");
        int val_3 = result.Match.ExpectedPlayerCount;
    }
    private void HandleOnPlayerPhotoLoaded(GK_UserPhotoLoadResult result)
    {
        if(true != 0)
        {
                return;
        }
        
        ISN_Logger.Log(message:  0, logType:  result.Photo);
        ISN_Logger.Log(message:  0, logType:  GameCenterManager.Player.BigPhoto);
    }
    private void OnGUI()
    {
        float val_54;
        var val_55;
        IntPtr val_56;
        var val_57;
        var val_58;
        var val_59;
        this.UpdateToStartPos();
        int val_3 = UnityEngine.Screen.width;
        if(GameCenterManager.IsPlayerAuthenticated != false)
        {
                val_54 = 0f;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_54, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0, style:  "TBM Multiplayer Example Scene.");
            val_55 = 0;
        }
        else
        {
                val_54 = 0f;
            float val_53 = 0f;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_54, m_YMin = val_53, m_Width = 0f, m_Height = 0f}, text:  0, style:  "TBM Multiplayer Example Scene, Authentication....");
            val_55 = 0;
        }
        
        UnityEngine.GUI.enabled = false;
        UnityEngine.GUI.enabled = false;
        val_53 = val_53 + 0f;
        mem[1152921510378224984] = val_53;
        float val_54 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_54, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.LoadMatchesInfo();
            val_56 = public System.Void TBM_Multiplayer_Example::ActionMatchesResultLoaded(GK_TBM_LoadMatchesResult res);
            System.Action<GK_TBM_LoadMatchesResult> val_6 = new System.Action<GK_TBM_LoadMatchesResult>(object:  this, method:  val_56);
            GameCenter_TBM.add_ActionMatchesInfoLoaded(value:  0);
        }
        
        val_54 = 0f + val_54;
        mem[1152921510378224988] = val_54;
        float val_55 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_55, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                val_57 = null;
            val_57 = null;
            SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.FindMatch(minPlayers:  2, maxPlayers:  2, msg:  System.String.Empty, playersToInvite:  0);
            val_56 = System.Void TBM_Multiplayer_Example::ActionMatchFound(GK_TBM_MatchInitResult result);
            System.Action<GK_TBM_MatchInitResult> val_9 = new System.Action<GK_TBM_MatchInitResult>(object:  this, method:  val_56);
            GameCenter_TBM.add_ActionMatchFound(value:  0);
        }
        
        val_55 = 0f + val_55;
        mem[1152921510378224988] = val_55;
        float val_56 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_56, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                val_58 = null;
            val_58 = null;
            SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.FindMatchWithNativeUI(minPlayers:  2, maxPlayers:  2, msg:  System.String.Empty, playersToInvite:  0);
            val_56 = System.Void TBM_Multiplayer_Example::ActionMatchFound(GK_TBM_MatchInitResult result);
            System.Action<GK_TBM_MatchInitResult> val_12 = new System.Action<GK_TBM_MatchInitResult>(object:  this, method:  val_56);
            GameCenter_TBM.add_ActionMatchFound(value:  0);
        }
        
        if(this.CurrentMatch != null)
        {
                val_59 = 0;
        }
        else
        {
                val_59 = 0;
        }
        
        UnityEngine.GUI.enabled = false;
        val_56 = 0f + val_56;
        mem[1152921510378224988] = null;
        mem[1152921510378224984] = val_56;
        float val_57 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_57, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                System.Text.Encoding val_17 = System.Text.Encoding.UTF8;
            string val_20 = 0 + val_17.CurrentMatch.UTF8StringData;
            SA_EditorAd val_21 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
            GK_TBM_Match val_22 = val_21.CurrentMatch;
            val_21.SaveCurrentTurn(matchId:  val_22.Id, matchData:  val_17);
            val_56 = System.Void TBM_Multiplayer_Example::ActionMatchDataUpdated(GK_TBM_MatchDataUpdateResult res);
            System.Action<GK_TBM_MatchDataUpdateResult> val_23 = new System.Action<GK_TBM_MatchDataUpdateResult>(object:  this, method:  val_56);
            GameCenter_TBM.add_ActionMatchDataUpdated(value:  0);
        }
        
        val_57 = 0f + val_57;
        mem[1152921510378224988] = val_57;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) == false)
        {
            goto label_83;
        }
        
        System.Text.Encoding val_25 = System.Text.Encoding.UTF8;
        GK_TBM_Match val_26 = val_25.CurrentMatch;
        val_26.CurrentParticipant.SetOutcome(outcome:  6);
        GK_TBM_Match val_27 = val_26.CurrentParticipant.CurrentMatch;
        val_56 = val_27.Participants;
        List.Enumerator<T> val_28 = val_56.GetEnumerator();
        float val_58 = 0f;
        label_73:
        if((0 & 1) == 0)
        {
            goto label_68;
        }
        
        System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_30 = val_58.InitializationCallback;
        string val_31 = val_30.PlayerId;
        GK_TBM_Match val_32 = val_31.CurrentMatch;
        if((val_31.Equals(value:  val_32.CurrentParticipant.PlayerId)) == true)
        {
            goto label_73;
        }
        
        SA_EditorAd val_36 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
        GK_TBM_Match val_37 = val_36.CurrentMatch;
        val_36.EndTurn(matchId:  val_37.Id, matchData:  val_25, nextPlayerId:  val_30.PlayerId);
        val_56 = System.Void TBM_Multiplayer_Example::ActionTrunEnded(GK_TBM_EndTrunResult result);
        System.Action<GK_TBM_EndTrunResult> val_39 = new System.Action<GK_TBM_EndTrunResult>(object:  this, method:  val_56);
        GameCenter_TBM.add_ActionTrunEnded(value:  0);
        val_58.Dispose();
        return;
        label_68:
        val_58.Dispose();
        label_83:
        val_58 = 0f + val_58;
        mem[1152921510378224988] = val_58;
        float val_59 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_59, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                System.Text.Encoding val_41 = System.Text.Encoding.UTF8;
            GK_TBM_Match val_42 = val_41.CurrentMatch;
            GK_TBM_Participant val_43 = val_42.Participants.Item[0];
            val_43.SetOutcome(outcome:  2);
            GK_TBM_Match val_44 = val_43.CurrentMatch;
            val_44.Participants.Item[1].SetOutcome(outcome:  3);
            SA_EditorAd val_46 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
            GK_TBM_Match val_47 = val_46.CurrentMatch;
            val_46.EndMatch(matchId:  val_47.Id, matchData:  val_41);
            val_56 = System.Void TBM_Multiplayer_Example::ActionMacthEnded(GK_TBM_MatchEndResult result);
            System.Action<GK_TBM_MatchEndResult> val_48 = new System.Action<GK_TBM_MatchEndResult>(object:  this, method:  val_56);
            GameCenter_TBM.add_ActionMacthEnded(value:  0);
        }
        
        val_59 = 0f + val_59;
        mem[1152921510378224988] = val_59;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) == false)
        {
                return;
        }
        
        SA_EditorAd val_50 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
        GK_TBM_Match val_51 = val_50.CurrentMatch;
        val_50.RemoveMatch(matchId:  val_51.Id);
        val_56 = System.Void TBM_Multiplayer_Example::ActionMacthRemoved(GK_TBM_MatchRemovedResult result);
        System.Action<GK_TBM_MatchRemovedResult> val_52 = new System.Action<GK_TBM_MatchRemovedResult>(object:  this, method:  val_56);
        GameCenter_TBM.add_ActionMatchRemoved(value:  0);
    }
    private void OnAuthFinished(SA.Common.Models.Result res)
    {
        var val_1 = (res._Error == 0) ? 1 : 0;
        ISN_Logger.Log(message:  0, logType:  0 + "Auth IsSucceeded: "("Auth IsSucceeded: "));
    }
    public void ActionMatchesResultLoaded(GK_TBM_LoadMatchesResult res)
    {
        var val_7;
        var val_8;
        var val_9;
        val_7 = res;
        System.Action<GK_TBM_LoadMatchesResult> val_1 = null;
        val_8 = val_1;
        val_1 = new System.Action<GK_TBM_LoadMatchesResult>(object:  this, method:  public System.Void TBM_Multiplayer_Example::ActionMatchesResultLoaded(GK_TBM_LoadMatchesResult res));
        GameCenter_TBM.remove_ActionMatchesInfoLoaded(value:  0);
        var val_2 = (GameCenter_TBM.__il2cppRuntimeField_cctor_finished == 0) ? 1 : 0;
        ISN_Logger.Log(message:  0, logType:  0 + "ActionMatchesResultLoaded: "("ActionMatchesResultLoaded: "));
        if(("ActionMatchesResultLoaded: ") != 0)
        {
                return;
        }
        
        if(res.LoadedMatches.Count == 0)
        {
                return;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_5 = res.LoadedMatches.GetEnumerator();
        val_8 = 1152921510200145536;
        label_14:
        if((0 & 1) == 0)
        {
            goto label_11;
        }
        
        UnityEngine.Playables.PlayableHandle val_6 = 0.GetHandle();
        GameCenter_TBM.PrintMatchInfo(match:  0);
        goto label_14;
        label_11:
        val_7 = 0;
        val_9 = 1;
        0.Dispose();
        if((val_9 & 1) != 0)
        {
                return;
        }
        
        if(val_7 == 0)
        {
                return;
        }
    
    }
    private void ActionMatchDataUpdated(GK_TBM_MatchDataUpdateResult res)
    {
        GK_TBM_MatchDataUpdateResult val_5 = res;
        System.Action<GK_TBM_MatchDataUpdateResult> val_1 = new System.Action<GK_TBM_MatchDataUpdateResult>(object:  this, method:  System.Void TBM_Multiplayer_Example::ActionMatchDataUpdated(GK_TBM_MatchDataUpdateResult res));
        GameCenter_TBM.remove_ActionMatchDataUpdated(value:  0);
        var val_2 = (GameCenter_TBM.__il2cppRuntimeField_cctor_finished == 0) ? 1 : 0;
        ISN_Logger.Log(message:  0, logType:  0 + "ActionMatchDataUpdated: "("ActionMatchDataUpdated: "));
        ISN_Logger.Log(message:  0, logType:  "ActionMacthEnded IsSucceeded: ");
    }
    private void ActionTrunEnded(GK_TBM_EndTrunResult result)
    {
        System.Action<GK_TBM_EndTrunResult> val_1 = new System.Action<GK_TBM_EndTrunResult>(object:  this, method:  System.Void TBM_Multiplayer_Example::ActionTrunEnded(GK_TBM_EndTrunResult result));
        GameCenter_TBM.remove_ActionTrunEnded(value:  0);
        var val_2 = (GameCenter_TBM.__il2cppRuntimeField_cctor_finished == 0) ? 1 : 0;
        ISN_Logger.Log(message:  0, logType:  0 + "ActionTrunEnded IsSucceeded: "("ActionTrunEnded IsSucceeded: "));
        IOSMessage val_4 = IOSMessage.Create(title:  0, message:  "ActionTrunEnded");
        ISN_Logger.Log(message:  0, logType:  result._Match);
    }
    private void ActionMacthEnded(GK_TBM_MatchEndResult result)
    {
        GK_TBM_MatchEndResult val_5 = result;
        System.Action<GK_TBM_MatchEndResult> val_1 = new System.Action<GK_TBM_MatchEndResult>(object:  this, method:  System.Void TBM_Multiplayer_Example::ActionMacthEnded(GK_TBM_MatchEndResult result));
        GameCenter_TBM.remove_ActionMacthEnded(value:  0);
        var val_2 = (GameCenter_TBM.__il2cppRuntimeField_cctor_finished == 0) ? 1 : 0;
        ISN_Logger.Log(message:  0, logType:  0 + "ActionMacthEnded IsSucceeded: "("ActionMacthEnded IsSucceeded: "));
        ISN_Logger.Log(message:  0, logType:  "ActionMatchFound IsSucceeded: ");
    }
    private void ActionMacthRemoved(GK_TBM_MatchRemovedResult result)
    {
        var val_6;
        UnityEngine.LogType val_7;
        val_6 = result;
        System.Action<GK_TBM_MatchRemovedResult> val_1 = new System.Action<GK_TBM_MatchRemovedResult>(object:  this, method:  System.Void TBM_Multiplayer_Example::ActionMacthRemoved(GK_TBM_MatchRemovedResult result));
        GameCenter_TBM.remove_ActionMatchRemoved(value:  0);
        var val_2 = (GameCenter_TBM.__il2cppRuntimeField_cctor_finished == 0) ? 1 : 0;
        ISN_Logger.Log(message:  0, logType:  0 + "ActionMacthRemoved IsSucceeded: "("ActionMacthRemoved IsSucceeded: "));
        val_7 = "iCloudManager.Instance.init()";
        ISN_Logger.Log(message:  0, logType:  null);
    }
    public GK_TBM_Match get_CurrentMatch()
    {
        var val_7;
        var val_8;
        val_7 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.Matches;
        if(val_7.Count >= 1)
        {
                val_7 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.MatchesList;
            GK_TBM_Match val_6 = val_7.Item[0];
            return (GK_TBM_Match)val_8;
        }
        
        val_8 = 0;
        return (GK_TBM_Match)val_8;
    }
    private void ActionMatchFound(GK_TBM_MatchInitResult result)
    {
        GK_TBM_MatchInitResult val_5 = result;
        System.Action<GK_TBM_MatchInitResult> val_1 = new System.Action<GK_TBM_MatchInitResult>(object:  this, method:  System.Void TBM_Multiplayer_Example::ActionMatchFound(GK_TBM_MatchInitResult result));
        GameCenter_TBM.remove_ActionMatchFound(value:  0);
        var val_2 = (GameCenter_TBM.__il2cppRuntimeField_cctor_finished == 0) ? 1 : 0;
        ISN_Logger.Log(message:  0, logType:  0 + "ActionMatchFound IsSucceeded: "("ActionMatchFound IsSucceeded: "));
        ISN_Logger.Log(message:  0, logType:  "OnCloudDataReceivedAction");
    }
    private static TBM_Multiplayer_Example()
    {
    
    }

}

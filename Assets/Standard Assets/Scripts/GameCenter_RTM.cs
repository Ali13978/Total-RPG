using UnityEngine;
public class GameCenter_RTM : Singleton<GameCenter_RTM>
{
    // Fields
    private GK_RTM_Match _CurrentMatch;
    private System.Collections.Generic.Dictionary<string, GK_Player> _NearbyPlayers;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<GK_RTM_MatchStartedResult> ActionMatchStarted;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<SA.Common.Models.Error> ActionMatchFailed;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<GK_Player, bool> ActionNearbyPlayerStateUpdated;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<GK_RTM_QueryActivityResult> ActionActivityResultReceived;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<SA.Common.Models.Error> ActionDataSendError;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<GK_Player, byte[]> ActionDataReceived;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<GK_Player, GK_PlayerConnectionState, GK_RTM_Match> ActionPlayerStateChanged;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<GK_Player> ActionDiconnectedPlayerReinvited;
    
    // Properties
    public GK_RTM_Match CurrentMatch { get; }
    public System.Collections.Generic.List<GK_Player> NearbyPlayersList { get; }
    public System.Collections.Generic.Dictionary<string, GK_Player> NearbyPlayers { get; }
    
    // Methods
    public GameCenter_RTM()
    {
        this._NearbyPlayers = new System.Collections.Generic.Dictionary<System.String, GK_Player>();
    }
    public static void add_ActionMatchStarted(System.Action<GK_RTM_MatchStartedResult> value)
    {
        var val_3;
        System.Action<GK_RTM_MatchStartedResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_RTM.ActionMatchStarted;
        System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  null);
        val_5 = 0;
        if(val_1 == null)
        {
                return;
        }
        
        val_5 = val_1;
        if(null == null)
        {
                return;
        }
        
        val_5 = 0;
    }
    public static void remove_ActionMatchStarted(System.Action<GK_RTM_MatchStartedResult> value)
    {
        var val_3;
        System.Action<GK_RTM_MatchStartedResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_RTM.ActionMatchStarted;
        System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  null);
        val_5 = 0;
        if(val_1 == null)
        {
                return;
        }
        
        val_5 = val_1;
        if(null == null)
        {
                return;
        }
        
        val_5 = 0;
    }
    public static void add_ActionMatchFailed(System.Action<SA.Common.Models.Error> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Error> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_RTM.ActionMatchFailed;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_RTM.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504840929288 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionMatchFailed(System.Action<SA.Common.Models.Error> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Error> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_RTM.ActionMatchFailed;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_RTM.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504840929288 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_ActionNearbyPlayerStateUpdated(System.Action<GK_Player, bool> value)
    {
        var val_3;
        System.Action<GK_Player, System.Boolean> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_RTM.ActionNearbyPlayerStateUpdated;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_RTM.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504840929296 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionNearbyPlayerStateUpdated(System.Action<GK_Player, bool> value)
    {
        var val_3;
        System.Action<GK_Player, System.Boolean> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_RTM.ActionNearbyPlayerStateUpdated;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_RTM.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504840929296 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_ActionActivityResultReceived(System.Action<GK_RTM_QueryActivityResult> value)
    {
        var val_3;
        System.Action<GK_RTM_QueryActivityResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_RTM.ActionActivityResultReceived;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_RTM.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504840929304 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionActivityResultReceived(System.Action<GK_RTM_QueryActivityResult> value)
    {
        var val_3;
        System.Action<GK_RTM_QueryActivityResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_RTM.ActionActivityResultReceived;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_RTM.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504840929304 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_ActionDataSendError(System.Action<SA.Common.Models.Error> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Error> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_RTM.ActionDataSendError;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_RTM.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504840929312 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionDataSendError(System.Action<SA.Common.Models.Error> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Error> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_RTM.ActionDataSendError;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_RTM.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504840929312 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_ActionDataReceived(System.Action<GK_Player, byte[]> value)
    {
        var val_3;
        System.Action<GK_Player, System.Byte[]> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_RTM.ActionDataReceived;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_RTM.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504840929320 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionDataReceived(System.Action<GK_Player, byte[]> value)
    {
        var val_3;
        System.Action<GK_Player, System.Byte[]> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_RTM.ActionDataReceived;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_RTM.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504840929320 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_ActionPlayerStateChanged(System.Action<GK_Player, GK_PlayerConnectionState, GK_RTM_Match> value)
    {
        var val_3;
        System.Action<GK_Player, GK_PlayerConnectionState, GK_RTM_Match> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_RTM.ActionPlayerStateChanged;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_RTM.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504840929328 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionPlayerStateChanged(System.Action<GK_Player, GK_PlayerConnectionState, GK_RTM_Match> value)
    {
        var val_3;
        System.Action<GK_Player, GK_PlayerConnectionState, GK_RTM_Match> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_RTM.ActionPlayerStateChanged;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_RTM.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504840929328 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_ActionDiconnectedPlayerReinvited(System.Action<GK_Player> value)
    {
        var val_3;
        System.Action<GK_Player> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_RTM.ActionDiconnectedPlayerReinvited;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_RTM.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504840929336 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionDiconnectedPlayerReinvited(System.Action<GK_Player> value)
    {
        var val_3;
        System.Action<GK_Player> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_RTM.ActionDiconnectedPlayerReinvited;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_RTM.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504840929336 != val_4)
        {
            goto label_8;
        }
    
    }
    private void Awake()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  0);
    }
    public void FindMatch(int minPlayers, int maxPlayers, string msg = "", string[] playersToInvite)
    {
    
    }
    public void FindMatchWithNativeUI(int minPlayers, int maxPlayers, string msg = "", string[] playersToInvite)
    {
    
    }
    public void SetPlayerGroup(int group)
    {
    
    }
    public void SetPlayerAttributes(int attributes)
    {
    
    }
    public void StartMatchWithInvite(GK_Invite invite, bool useNativeUI)
    {
    
    }
    public void CancelPendingInviteToPlayer(GK_Player player)
    {
    
    }
    public void CancelMatchSearch()
    {
    
    }
    public void FinishMatchmaking()
    {
    
    }
    public void QueryActivity()
    {
    
    }
    public void QueryPlayerGroupActivity(int group)
    {
    
    }
    public void StartBrowsingForNearbyPlayers()
    {
    
    }
    public void StopBrowsingForNearbyPlayers()
    {
    
    }
    public void Rematch()
    {
    
    }
    public void Disconnect()
    {
        this._CurrentMatch = 0;
    }
    public void SendDataToAll(byte[] data, GK_MatchSendDataMode dataMode)
    {
    
    }
    public void SendData(byte[] data, GK_MatchSendDataMode dataMode, GK_Player[] players)
    {
    
    }
    public GK_RTM_Match get_CurrentMatch()
    {
        return (GK_RTM_Match)this._CurrentMatch;
    }
    public System.Collections.Generic.List<GK_Player> get_NearbyPlayersList()
    {
        System.Collections.Generic.List<T> val_4;
        var val_5;
        Dictionary.Enumerator<TKey, TValue> val_2 = this._NearbyPlayers.GetEnumerator();
        label_4:
        if((0 & 1) == 0)
        {
            goto label_2;
        }
        
        UnityEngine.Playables.PlayableHandle val_3 = 0.GetHandle();
        Add(item:  val_3.m_Handle);
        goto label_4;
        label_2:
        val_4 = 0;
        val_5 = 1;
        0.Dispose();
        if((val_5 & 1) != 0)
        {
                return (System.Collections.Generic.List<GK_Player>)new System.Collections.Generic.List<GK_Player>();
        }
        
        if(val_4 == 0)
        {
                return (System.Collections.Generic.List<GK_Player>)new System.Collections.Generic.List<GK_Player>();
        }
        
        return (System.Collections.Generic.List<GK_Player>)new System.Collections.Generic.List<GK_Player>();
    }
    public System.Collections.Generic.Dictionary<string, GK_Player> get_NearbyPlayers()
    {
        return (System.Collections.Generic.Dictionary<System.String, GK_Player>)this._NearbyPlayers;
    }
    private void OnMatchStartFailed(string errorData)
    {
        var val_2 = null;
        GameCenter_RTM.ActionMatchStarted.Invoke(obj:  new GK_RTM_MatchStartedResult(errorData:  errorData));
    }
    private void OnMatchStarted(string matchData)
    {
        var val_3;
        typeof(GK_RTM_MatchStartedResult).__il2cppRuntimeField_18 = this.ParseMatchData(matchData:  matchData);
        val_3 = null;
        val_3 = null;
        GameCenter_RTM.ActionMatchStarted.Invoke(obj:  new SA.Common.Models.Result());
    }
    private void OnMatchFailed(string errorData)
    {
        var val_2;
        this._CurrentMatch = 0;
        val_2 = null;
        val_2 = null;
        GameCenter_RTM.ActionMatchFailed.Invoke(obj:  new SA.Common.Models.Error(errorData:  errorData));
    }
    private void OnNearbyPlayerInfoReceived(string data)
    {
        var val_8;
        typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
        System.String[] val_1 = data.Split(separator:  null);
        string val_8 = val_1[0];
        GK_Player val_2 = GameCenterManager.GetPlayerById(playerID:  null);
        string val_9 = val_1[1];
        bool val_3 = System.Convert.ToBoolean(value:  0);
        bool val_4 = this._NearbyPlayers.ContainsKey(key:  val_2._PlayerId);
        if(val_3 == false)
        {
            goto label_13;
        }
        
        if(val_4 == true)
        {
            goto label_18;
        }
        
        this._NearbyPlayers.Add(key:  val_2._PlayerId, value:  val_2);
        goto label_18;
        label_13:
        if(val_4 != false)
        {
                bool val_6 = this._NearbyPlayers.Remove(key:  val_2._PlayerId);
        }
        
        label_18:
        val_8 = null;
        val_8 = null;
        GameCenter_RTM.ActionNearbyPlayerStateUpdated.Invoke(arg1:  val_2, arg2:  val_3);
    }
    private void OnQueryActivity(string data)
    {
        var val_3;
        typeof(GK_RTM_QueryActivityResult).__il2cppRuntimeField_18 = System.Convert.ToInt32(value:  0);
        val_3 = null;
        val_3 = null;
        GameCenter_RTM.ActionActivityResultReceived.Invoke(obj:  new SA.Common.Models.Result());
    }
    private void OnQueryActivityFailed(string errorData)
    {
        var val_2 = null;
        GameCenter_RTM.ActionActivityResultReceived.Invoke(obj:  new GK_RTM_QueryActivityResult(errorData:  errorData));
    }
    private void OnMatchInfoUpdated(string matchData)
    {
        GK_RTM_Match val_1 = this.ParseMatchData(matchData:  matchData);
        if(val_1._Players.Count != 0)
        {
                return;
        }
        
        if(val_1._ExpectedPlayerCount != 0)
        {
                return;
        }
        
        this._CurrentMatch = 0;
    }
    private void OnMatchPlayerStateChanged(string data)
    {
        var val_4;
        if(this._CurrentMatch == null)
        {
                return;
        }
        
        typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
        System.String[] val_1 = data.Split(separator:  null);
        string val_4 = val_1[0];
        string val_5 = val_1[1];
        val_4 = null;
        val_4 = null;
        GameCenter_RTM.ActionPlayerStateChanged.Invoke(arg1:  GameCenterManager.GetPlayerById(playerID:  null), arg2:  System.Convert.ToInt32(value:  0), arg3:  this._CurrentMatch);
    }
    private void OnDiconnectedPlayerReinvited(string playerId)
    {
        var val_2 = null;
        GameCenter_RTM.ActionDiconnectedPlayerReinvited.Invoke(obj:  GameCenterManager.GetPlayerById(playerID:  null));
    }
    private void OnMatchDataReceived(string data)
    {
        var val_4;
        typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
        System.String[] val_1 = data.Split(separator:  null);
        string val_4 = val_1[0];
        string val_5 = val_1[1];
        val_4 = null;
        val_4 = null;
        GameCenter_RTM.ActionDataReceived.Invoke(arg1:  GameCenterManager.GetPlayerById(playerID:  null), arg2:  System.Convert.FromBase64String(s:  0));
    }
    private void OnSendDataError(string errorData)
    {
        var val_2 = null;
        GameCenter_RTM.ActionDataSendError.Invoke(obj:  new SA.Common.Models.Error(errorData:  errorData));
    }
    private GK_RTM_Match ParseMatchData(string matchData)
    {
        GK_RTM_Match val_1 = new GK_RTM_Match(matchData:  matchData);
        this._CurrentMatch = val_1;
        return val_1;
    }
    private static GameCenter_RTM()
    {
        GameCenter_RTM.ActionMatchStarted = new System.Action<GK_RTM_MatchStartedResult>(object:  0, method:  static System.Void GameCenter_RTM::<ActionMatchStarted>m__0(GK_RTM_MatchStartedResult ));
        GameCenter_RTM.ActionMatchFailed = new System.Action<SA.Common.Models.Error>(object:  0, method:  static System.Void GameCenter_RTM::<ActionMatchFailed>m__1(SA.Common.Models.Error ));
        GameCenter_RTM.ActionNearbyPlayerStateUpdated = new System.Action<GK_Player, System.Boolean>(object:  0, method:  static System.Void GameCenter_RTM::<ActionNearbyPlayerStateUpdated>m__2(GK_Player , bool ));
        GameCenter_RTM.ActionActivityResultReceived = new System.Action<GK_RTM_QueryActivityResult>(object:  0, method:  static System.Void GameCenter_RTM::<ActionActivityResultReceived>m__3(GK_RTM_QueryActivityResult ));
        GameCenter_RTM.ActionDataSendError = new System.Action<SA.Common.Models.Error>(object:  0, method:  static System.Void GameCenter_RTM::<ActionDataSendError>m__4(SA.Common.Models.Error ));
        GameCenter_RTM.ActionDataReceived = new System.Action<GK_Player, System.Byte[]>(object:  0, method:  static System.Void GameCenter_RTM::<ActionDataReceived>m__5(GK_Player , byte[] ));
        GameCenter_RTM.ActionPlayerStateChanged = new System.Action<GK_Player, GK_PlayerConnectionState, GK_RTM_Match>(object:  0, method:  static System.Void GameCenter_RTM::<ActionPlayerStateChanged>m__6(GK_Player , GK_PlayerConnectionState , GK_RTM_Match ));
        GameCenter_RTM.ActionDiconnectedPlayerReinvited = new System.Action<GK_Player>(object:  0, method:  static System.Void GameCenter_RTM::<ActionDiconnectedPlayerReinvited>m__7(GK_Player ));
    }
    private static void <ActionMatchStarted>m__0(GK_RTM_MatchStartedResult )
    {
    
    }
    private static void <ActionMatchFailed>m__1(SA.Common.Models.Error )
    {
    
    }
    private static void <ActionNearbyPlayerStateUpdated>m__2(GK_Player , bool )
    {
    
    }
    private static void <ActionActivityResultReceived>m__3(GK_RTM_QueryActivityResult )
    {
    
    }
    private static void <ActionDataSendError>m__4(SA.Common.Models.Error )
    {
    
    }
    private static void <ActionDataReceived>m__5(GK_Player , byte[] )
    {
    
    }
    private static void <ActionPlayerStateChanged>m__6(GK_Player , GK_PlayerConnectionState , GK_RTM_Match )
    {
    
    }
    private static void <ActionDiconnectedPlayerReinvited>m__7(GK_Player )
    {
    
    }

}

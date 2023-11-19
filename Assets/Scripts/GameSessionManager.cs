using UnityEngine;
public class GameSessionManager
{
    // Fields
    public GameSessionManager.SessionCallback onSessionCreated;
    public GameSessionManager.SessionCallback onSessionDestroyed;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private int <maxPlayersPerSession>k__BackingField;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private int <maxSessions>k__BackingField;
    private System.Collections.Generic.Dictionary<int, SessionInfo> _runningGameSessions;
    private System.Collections.Generic.Dictionary<TzarGames.GameFramework.Player, SessionInfo> _playerToSessionMapping;
    private int _lastUsedGroupIndex;
    private TzarGames.Common.IntegerIndex groupIndex;
    
    // Properties
    public int maxPlayersPerSession { get; set; }
    public int maxSessions { get; set; }
    public int sessionCount { get; }
    
    // Methods
    public GameSessionManager(int maxPlayersPerSession, int maxSessions, int startGroupIndex)
    {
        string val_6;
        System.ArgumentException val_7;
        string val_8;
        object val_9;
        object val_10;
        this._runningGameSessions = new System.Collections.Generic.Dictionary<System.Int32, SessionInfo>();
        this._playerToSessionMapping = new System.Collections.Generic.Dictionary<TzarGames.GameFramework.Player, SessionInfo>();
        this._lastUsedGroupIndex = 1;
        if(maxPlayersPerSession <= 0)
        {
            goto label_1;
        }
        
        if(maxSessions <= 0)
        {
            goto label_2;
        }
        
        if(maxSessions > 65536)
        {
            goto label_3;
        }
        
        this.<maxPlayersPerSession>k__BackingField = maxPlayersPerSession;
        this.<maxSessions>k__BackingField = maxSessions;
        this._lastUsedGroupIndex = startGroupIndex;
        return;
        label_1:
        val_6 = 0 + "Maximum number players per session must be greater than zero. (You set it to " + maxPlayersPerSession;
        val_7 = null;
        val_8 = "maxPlayersPerSession";
        goto label_6;
        label_2:
        val_9 = maxSessions;
        val_10 = "Maximum number of sessions must be greater than zero. (You set it to ";
        goto label_9;
        label_3:
        val_9 = maxSessions;
        val_10 = "The maximum allowed sessions per server is 65536. (You set it to ";
        label_9:
        val_6 = 0 + val_10 + maxSessions;
        val_7 = null;
        val_8 = "maxSessions";
        label_6:
        val_7 = new System.ArgumentException(message:  val_6, paramName:  val_8);
    }
    public int get_maxPlayersPerSession()
    {
        return (int)this.<maxPlayersPerSession>k__BackingField;
    }
    private void set_maxPlayersPerSession(int value)
    {
        this.<maxPlayersPerSession>k__BackingField = value;
    }
    public int get_maxSessions()
    {
        return (int)this.<maxSessions>k__BackingField;
    }
    private void set_maxSessions(int value)
    {
        this.<maxSessions>k__BackingField = value;
    }
    public int get_sessionCount()
    {
        if(this._runningGameSessions != null)
        {
                return this._runningGameSessions.Count;
        }
        
        return this._runningGameSessions.Count;
    }
    public int GetPlayerCountInSession(int sessionID)
    {
        SessionInfo val_1 = 0;
        if((this._runningGameSessions.TryGetValue(key:  sessionID, value: out  val_1)) != false)
        {
                if(val_1 != 0)
        {
                return 1;
        }
        
            return 1;
        }
        
        System.Exception val_4 = new System.Exception(message:  0 + "Couldn\'t find any session with ID " + sessionID);
    }
    public int GetSessionOfPlayer(TzarGames.GameFramework.Player player)
    {
        SessionInfo val_1 = 0;
        if((this._playerToSessionMapping.TryGetValue(key:  player, value: out  val_1)) != false)
        {
                if(val_1 != 0)
        {
                return 11993091;
        }
        
            return 11993091;
        }
        
        System.Exception val_4 = new System.Exception(message:  0 + "Couldn\'t find player " + player);
    }
    public bool TryAddPlayerToAnySession(TzarGames.GameFramework.Player player, out int sessionId)
    {
        var val_4;
        var val_5;
        SessionInfo val_1 = 0;
        if((this.TryFindSessionForNewPlayer(session: out  val_1)) != true)
        {
                sessionId = 0;
            return false;
        }
        
        if(val_1 == 0)
        {
                val_4 = 20;
            val_5 = 1;
        }
        else
        {
                val_4 = val_1;
            val_5 = 1;
        }
        
        mem[20] = 2;
        this._playerToSessionMapping.Add(key:  player, value:  val_1);
        System.NotImplementedException val_3 = new System.NotImplementedException();
    }
    public bool TryAddPlayerToSession(TzarGames.GameFramework.Player player, int sessionId)
    {
        int val_4;
        var val_5;
        var val_6;
        val_4 = sessionId;
        SessionInfo val_1 = 0;
        if((this._runningGameSessions.TryGetValue(key:  val_4, value: out  val_1)) == false)
        {
                return false;
        }
        
        val_4 = val_1;
        if(1 >= (this.<maxPlayersPerSession>k__BackingField))
        {
                return false;
        }
        
        if(val_1 == 0)
        {
                val_5 = 20;
            val_6 = 1;
        }
        else
        {
                val_5 = val_1;
            val_6 = 1;
        }
        
        mem[20] = 2;
        this._playerToSessionMapping.Add(key:  player, value:  val_1);
        System.NotImplementedException val_3 = new System.NotImplementedException();
    }
    public bool TryAddPlayerToOtherPlayerSession(TzarGames.GameFramework.Player player, TzarGames.GameFramework.Player otherPlayer)
    {
        TzarGames.GameFramework.Player val_4;
        var val_5;
        val_4 = otherPlayer;
        SessionInfo val_1 = 0;
        if((this._playerToSessionMapping.TryGetValue(key:  val_4, value: out  val_1)) != false)
        {
                val_4 = val_1;
            val_5 = this;
            bool val_3 = this.TryAddPlayerToSession(player:  player, sessionId:  11993091);
        }
        else
        {
                val_5 = 0;
        }
        
        val_5 = val_5 & 1;
        return (bool)val_5;
    }
    public bool RemovePlayer(TzarGames.GameFramework.Player player)
    {
        System.Collections.Generic.Dictionary<TzarGames.GameFramework.Player, SessionInfo> val_5;
        var val_6;
        var val_7;
        var val_8;
        SessionInfo val_1 = 0;
        val_5 = this._playerToSessionMapping;
        if((val_5.TryGetValue(key:  player, value: out  val_1)) == false)
        {
            goto label_2;
        }
        
        val_6 = val_1;
        if(val_6 == 0)
        {
            goto label_3;
        }
        
        val_7 = 1;
        goto label_4;
        label_2:
        val_8 = 0;
        return (bool)val_8;
        label_3:
        val_6 = 20;
        val_7 = 1;
        label_4:
        mem[20] = 0;
        val_5 = val_1;
        if(mem[20] == 0)
        {
                bool val_3 = this.DeallocateSession(session:  val_1);
        }
        
        bool val_4 = this._playerToSessionMapping.Remove(key:  player);
        val_8 = 1;
        return (bool)val_8;
    }
    private void AddPlayerToSession(TzarGames.GameFramework.Player player, SessionInfo session)
    {
        var val_3;
        int val_4;
        if(session == null)
        {
                val_3 = 20;
            val_4 = 1;
        }
        else
        {
                val_3 = session;
            val_4 = session.playerCount;
        }
        
        mem2[0] = val_4 + 1;
        this._playerToSessionMapping.Add(key:  player, value:  session);
        System.NotImplementedException val_2 = new System.NotImplementedException();
    }
    private bool TryFindSessionForNewPlayer(out SessionInfo session)
    {
        System.Collections.Generic.Dictionary<System.Int32, SessionInfo> val_6;
        var val_7;
        val_6 = this._runningGameSessions;
        Dictionary.Enumerator<TKey, TValue> val_1 = val_6.GetEnumerator();
        label_4:
        if((0 & 1) == 0)
        {
            goto label_2;
        }
        
        UnityEngine.Playables.PlayableHandle val_2 = 0.GetHandle();
        val_6;
        if((???) >= (this.<maxPlayersPerSession>k__BackingField))
        {
            goto label_4;
        }
        
        session = val_2.m_Handle;
        0.Dispose();
        val_7 = 1;
        return (bool)this.TryAllocateSession(session: out  SessionInfo val_3 = session);
        label_2:
        0.Dispose();
        val_7 = this;
        return (bool)this.TryAllocateSession(session: out  val_3);
    }
    private bool TryAllocateSession(out SessionInfo session)
    {
        var val_5;
        SessionInfo val_6;
        var val_7;
        SessionInfo val_8;
        val_5 = 1152921511384522912;
        label_3:
        if((this._runningGameSessions.ContainsKey(key:  this._lastUsedGroupIndex)) == false)
        {
            goto label_2;
        }
        
        int val_3 = (this._lastUsedGroupIndex == (this.<maxSessions>k__BackingField)) ? 1 : (this._lastUsedGroupIndex + 1);
        this._lastUsedGroupIndex = val_3;
        if(val_3 != this._lastUsedGroupIndex)
        {
            goto label_3;
        }
        
        val_7 = 0;
        session = 0;
        return (bool)val_7;
        label_2:
        SessionInfo val_4 = null;
        val_6 = val_4;
        val_4 = new SessionInfo(id:  this._lastUsedGroupIndex, playerCount:  0);
        session = val_6;
        val_8 = val_6;
        if(null == 0)
        {
                val_8 = session;
        }
        
        this._runningGameSessions.Add(key:  -1651086000, value:  val_8);
        val_7 = 1;
        return (bool)val_7;
    }
    private bool DeallocateSession(SessionInfo session)
    {
        var val_2;
        if((this._runningGameSessions.ContainsKey(key:  session.id)) != false)
        {
                if(session.playerCount == 0)
        {
            goto label_5;
        }
        
        }
        
        val_2 = 0;
        return (bool)val_2;
        label_5:
        if(this.onSessionDestroyed != null)
        {
                this.onSessionDestroyed.Invoke(sessionId:  session.id);
        }
        
        val_2 = 1;
        return (bool)val_2;
    }
    private int GetNextIndex()
    {
        return (int)(this._lastUsedGroupIndex == (this.<maxSessions>k__BackingField)) ? 1 : (this._lastUsedGroupIndex + 1);
    }

}

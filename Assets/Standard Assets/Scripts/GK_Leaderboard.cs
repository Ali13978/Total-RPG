using UnityEngine;
[Serializable]
public class GK_Leaderboard
{
    // Fields
    public bool IsOpen;
    private bool _CurrentPlayerScoreLoaded;
    public GK_ScoreCollection SocsialCollection;
    public GK_ScoreCollection GlobalCollection;
    private System.Collections.Generic.List<GK_Score> CurrentPlayerScore;
    private System.Collections.Generic.Dictionary<int, GK_LocalPlayerScoreUpdateListener> ScoreUpdateListners;
    [UnityEngine.SerializeField]
    private GK_LeaderBoardInfo _info;
    
    // Properties
    public GK_LeaderBoardInfo Info { get; }
    public string Id { get; }
    public bool CurrentPlayerScoreLoaded { get; }
    [System.ObsoleteAttribute]
    public string id { get; }
    
    // Methods
    public GK_Leaderboard(string leaderboardId)
    {
        this.IsOpen = true;
        this.SocsialCollection = new GK_ScoreCollection();
        this.GlobalCollection = new GK_ScoreCollection();
        this.CurrentPlayerScore = new System.Collections.Generic.List<GK_Score>();
        this.ScoreUpdateListners = new System.Collections.Generic.Dictionary<System.Int32, GK_LocalPlayerScoreUpdateListener>();
        this._info = new GK_LeaderBoardInfo();
        typeof(GK_LeaderBoardInfo).__il2cppRuntimeField_20 = leaderboardId;
    }
    public void Refresh()
    {
        this.SocsialCollection = new GK_ScoreCollection();
        this.GlobalCollection = new GK_ScoreCollection();
        this.CurrentPlayerScore = new System.Collections.Generic.List<GK_Score>();
        this.ScoreUpdateListners = new System.Collections.Generic.Dictionary<System.Int32, GK_LocalPlayerScoreUpdateListener>();
    }
    public GK_Score GetCurrentPlayerScore(GK_TimeSpan timeSpan, GK_CollectionType collection)
    {
        var val_3;
        var val_4;
        val_3 = collection;
        List.Enumerator<T> val_1 = this.CurrentPlayerScore.GetEnumerator();
        label_5:
        if((0 & 1) == 0)
        {
            goto label_2;
        }
        
        val_4 = 0.InitializationCallback;
        if((0 != timeSpan) || (0 != val_3))
        {
            goto label_5;
        }
        
        0.Dispose();
        return (GK_Score)val_4;
        label_2:
        0.Dispose();
        val_4 = 0;
        return (GK_Score)val_4;
    }
    public GK_Score GetScoreByPlayerId(string playerId, GK_TimeSpan timeSpan, GK_CollectionType collection)
    {
        GK_TimeSpan val_8;
        string val_9;
        string val_10;
        var val_11;
        val_8 = timeSpan;
        val_9 = playerId;
        GK_Player val_1 = GameCenterManager.Player;
        val_10 = val_1._PlayerId;
        if((val_9.Equals(value:  val_10)) != false)
        {
                val_11 = this.GetCurrentPlayerScore(timeSpan:  val_8, collection:  collection);
            return (GK_Score)val_11;
        }
        
        List.Enumerator<T> val_5 = this.GetScoresList(timeSpan:  val_8, collection:  collection).GetEnumerator();
        val_10 = 1152921510237112224;
        label_11:
        if((0 & 1) == 0)
        {
            goto label_8;
        }
        
        val_11 = 0.InitializationCallback;
        if((val_8.Equals(value:  val_9)) == false)
        {
            goto label_11;
        }
        
        0.Dispose();
        return (GK_Score)val_11;
        label_8:
        0.Dispose();
        val_11 = 0;
        return (GK_Score)val_11;
    }
    public System.Collections.Generic.List<GK_Score> GetScoresList(GK_TimeSpan timeSpan, GK_CollectionType collection)
    {
        var val_4;
        var val_1 = (collection == 0) ? this.SocsialCollection : this.GlobalCollection;
        if(timeSpan == 1)
        {
            goto label_2;
        }
        
        if(timeSpan != 0)
        {
            goto label_3;
        }
        
        val_4 = val_1 + 32;
        goto label_5;
        label_2:
        val_4 = val_1 + 24;
        goto label_5;
        label_3:
        val_4 = val_1 + 16;
        label_5:
        AddRange(collection:  val_4.Values);
        return (System.Collections.Generic.List<GK_Score>)new System.Collections.Generic.List<GK_Score>();
    }
    public GK_Score GetScore(int rank, GK_TimeSpan timeSpan, GK_CollectionType collection)
    {
        var val_4;
        var val_5;
        var val_1 = (collection == 0) ? this.SocsialCollection : this.GlobalCollection;
        if(timeSpan == 1)
        {
            goto label_2;
        }
        
        if(timeSpan != 0)
        {
            goto label_3;
        }
        
        val_4 = val_1 + 32;
        goto label_5;
        label_2:
        val_4 = val_1 + 24;
        goto label_5;
        label_3:
        val_4 = val_1 + 16;
        label_5:
        if((val_4.ContainsKey(key:  rank)) != false)
        {
                GK_Score val_3 = val_4.Item[rank];
            return (GK_Score)val_5;
        }
        
        val_5 = 0;
        return (GK_Score)val_5;
    }
    public GK_LeaderBoardInfo get_Info()
    {
        return (GK_LeaderBoardInfo)this._info;
    }
    public string get_Id()
    {
        if(this._info != null)
        {
                return (string)this._info.Identifier;
        }
        
        return (string)this._info.Identifier;
    }
    public bool get_CurrentPlayerScoreLoaded()
    {
        return (bool)this._CurrentPlayerScoreLoaded;
    }
    public void CreateScoreListener(int requestId, bool isInternal)
    {
        this.ScoreUpdateListners.Add(key:  -2125781600, value:  new GK_LocalPlayerScoreUpdateListener(requestId:  requestId, leaderboardId:  this._info.Identifier, isInternal:  isInternal));
    }
    public void ReportLocalPlayerScoreUpdate(GK_Score score, int requestId)
    {
        this.ScoreUpdateListners.Item[requestId].ReportScoreUpdate(score:  score);
    }
    public void UpdateCurrentPlayerScore(System.Collections.Generic.List<GK_Score> newScores)
    {
        var val_3;
        var val_4;
        this.CurrentPlayerScore.Clear();
        List.Enumerator<T> val_1 = newScores.GetEnumerator();
        label_5:
        if((0 & 1) == 0)
        {
            goto label_3;
        }
        
        this.CurrentPlayerScore.Add(item:  0.InitializationCallback);
        goto label_5;
        label_3:
        val_3 = 0;
        val_4 = 1;
        0.Dispose();
        this._CurrentPlayerScoreLoaded = true;
    }
    public void UpdateCurrentPlayerScore(GK_Score score)
    {
        GK_TimeSpan val_3;
        if(score != null)
        {
                val_3 = score._TimeSpan;
        }
        else
        {
                val_3 = 1638426;
        }
        
        GK_Score val_1 = this.GetCurrentPlayerScore(timeSpan:  val_3, collection:  score._Collection);
        if(val_1 != null)
        {
                bool val_2 = this.CurrentPlayerScore.Remove(item:  val_1);
        }
        
        this.CurrentPlayerScore.Add(item:  score);
        this._CurrentPlayerScoreLoaded = true;
    }
    public void ReportLocalPlayerScoreUpdateFail(string errorData, int requestId)
    {
        this.ScoreUpdateListners.Item[requestId].ReportScoreUpdateFail(errorData:  errorData);
    }
    public void UpdateScore(GK_Score s)
    {
        GK_ScoreCollection val_4;
        System.Collections.Generic.Dictionary<System.Int32, GK_Score> val_5;
        int val_6;
        val_4 = this.GlobalCollection;
        if(s._Collection == 0)
        {
            goto label_2;
        }
        
        if(s._Collection != 1)
        {
            goto label_4;
        }
        
        val_4 = this.GlobalCollection;
        goto label_4;
        label_2:
        val_4 = this.SocsialCollection;
        label_4:
        val_5 = this.SocsialCollection.AllTimeScores;
        if(s._TimeSpan == 0)
        {
            goto label_7;
        }
        
        if(s._TimeSpan == 1)
        {
            goto label_8;
        }
        
        if(s._TimeSpan != 2)
        {
            goto label_13;
        }
        
        val_5 = this.SocsialCollection.AllTimeScores;
        goto label_13;
        label_7:
        val_5 = this.SocsialCollection.TodayScores;
        goto label_13;
        label_8:
        val_5 = this.SocsialCollection.WeekScores;
        label_13:
        if(val_5 == null)
        {
            goto label_16;
        }
        
        val_6 = s._Rank;
        if((val_5.ContainsKey(key:  s._Rank)) == true)
        {
            goto label_17;
        }
        
        goto label_19;
        label_16:
        val_6 = s._Rank;
        val_5 = 0;
        if((0.ContainsKey(key:  s._Rank)) == false)
        {
            goto label_19;
        }
        
        label_17:
        val_5.set_Item(key:  val_6, value:  s);
        return;
        label_19:
        val_5.Add(key:  val_6, value:  s);
    }
    public string get_id()
    {
        if(this._info != null)
        {
                return (string)this._info.Identifier;
        }
        
        return (string)this._info.Identifier;
    }
    public void UpdateMaxRange(int MR)
    {
        this._info.MaxRange = MR;
    }

}

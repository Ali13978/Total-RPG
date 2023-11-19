using UnityEngine;
public class GK_Score
{
    // Fields
    private int _Rank;
    private long _Score;
    private long _Context;
    private string _PlayerId;
    private string _LeaderboardId;
    private GK_CollectionType _Collection;
    private GK_TimeSpan _TimeSpan;
    
    // Properties
    public int Rank { get; }
    public long LongScore { get; }
    public float CurrencyScore { get; }
    public float DecimalFloat_1 { get; }
    public float DecimalFloat_2 { get; }
    public float DecimalFloat_3 { get; }
    public long Context { get; }
    public System.TimeSpan Minutes { get; }
    public System.TimeSpan Seconds { get; }
    public System.TimeSpan Milliseconds { get; }
    public string PlayerId { get; }
    public GK_Player Player { get; }
    public string LeaderboardId { get; }
    public GK_Leaderboard Leaderboard { get; }
    public GK_CollectionType Collection { get; }
    public GK_TimeSpan TimeSpan { get; }
    [System.ObsoleteAttribute]
    public int rank { get; }
    [System.ObsoleteAttribute]
    public long score { get; }
    [System.ObsoleteAttribute]
    public string playerId { get; }
    [System.ObsoleteAttribute]
    public string leaderboardId { get; }
    [System.ObsoleteAttribute]
    public GK_TimeSpan timeSpan { get; }
    [System.ObsoleteAttribute]
    public GK_CollectionType collection { get; }
    
    // Methods
    public GK_Score(long vScore, int vRank, long vContext, GK_TimeSpan vTimeSpan, GK_CollectionType sCollection, string lid, string pid)
    {
        val_1 = new System.Object();
        this._Score = vScore;
        this._Context = vContext;
        this._Rank = vRank;
        this._PlayerId = pid;
        this._LeaderboardId = val_1;
        this._Collection = sCollection;
        this._TimeSpan = vTimeSpan;
    }
    public int get_Rank()
    {
        return (int)this._Rank;
    }
    public long get_LongScore()
    {
        return (long)this._Score;
    }
    public float get_CurrencyScore()
    {
        float val_1 = 100f;
        val_1 = (float)this._Score / val_1;
        return (float)val_1;
    }
    public float get_DecimalFloat_1()
    {
        float val_1 = (float)this._Score;
        val_1 = val_1 / 10f;
        return (float)val_1;
    }
    public float get_DecimalFloat_2()
    {
        float val_1 = 100f;
        val_1 = (float)this._Score / val_1;
        return (float)val_1;
    }
    public float get_DecimalFloat_3()
    {
        float val_1 = 100f;
        val_1 = (float)this._Score / val_1;
        return (float)val_1;
    }
    public long get_Context()
    {
        return (long)this._Context;
    }
    public System.TimeSpan get_Minutes()
    {
        return System.TimeSpan.FromMinutes(value:  (double)this._Score);
    }
    public System.TimeSpan get_Seconds()
    {
        return System.TimeSpan.FromSeconds(value:  (double)this._Score);
    }
    public System.TimeSpan get_Milliseconds()
    {
        return System.TimeSpan.FromMilliseconds(value:  (double)this._Score);
    }
    public string get_PlayerId()
    {
        return (string)this._PlayerId;
    }
    public GK_Player get_Player()
    {
        return GameCenterManager.GetPlayerById(playerID:  null);
    }
    public string get_LeaderboardId()
    {
        return (string)this._LeaderboardId;
    }
    public GK_Leaderboard get_Leaderboard()
    {
        return GameCenterManager.GetLeaderboard(id:  null);
    }
    public GK_CollectionType get_Collection()
    {
        return (GK_CollectionType)this._Collection;
    }
    public GK_TimeSpan get_TimeSpan()
    {
        return (GK_TimeSpan)this._TimeSpan;
    }
    public int get_rank()
    {
        return (int)this._Rank;
    }
    public long get_score()
    {
        return (long)this._Score;
    }
    public string get_playerId()
    {
        return (string)this._PlayerId;
    }
    public string get_leaderboardId()
    {
        return (string)this._LeaderboardId;
    }
    public GK_TimeSpan get_timeSpan()
    {
        return (GK_TimeSpan)this._TimeSpan;
    }
    public GK_CollectionType get_collection()
    {
        return (GK_CollectionType)this._Collection;
    }

}

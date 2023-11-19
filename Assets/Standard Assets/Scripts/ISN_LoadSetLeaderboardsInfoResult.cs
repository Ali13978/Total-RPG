using UnityEngine;
public class ISN_LoadSetLeaderboardsInfoResult : Result
{
    // Fields
    public GK_LeaderboardSet _LeaderBoardsSet;
    
    // Properties
    public GK_LeaderboardSet LeaderBoardsSet { get; }
    
    // Methods
    public ISN_LoadSetLeaderboardsInfoResult(GK_LeaderboardSet lbset)
    {
        this._LeaderBoardsSet = lbset;
    }
    public ISN_LoadSetLeaderboardsInfoResult(GK_LeaderboardSet lbset, SA.Common.Models.Error error)
    {
        this._LeaderBoardsSet = lbset;
    }
    public GK_LeaderboardSet get_LeaderBoardsSet()
    {
        return (GK_LeaderboardSet)this._LeaderBoardsSet;
    }

}

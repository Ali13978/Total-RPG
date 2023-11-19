using UnityEngine;
public class GK_LeaderboardResult : Result
{
    // Fields
    private GK_Leaderboard _Leaderboard;
    
    // Properties
    public GK_Leaderboard Leaderboard { get; }
    
    // Methods
    public GK_LeaderboardResult(GK_Leaderboard leaderboard)
    {
        this._Leaderboard = leaderboard;
    }
    public GK_LeaderboardResult(GK_Leaderboard leaderboard, SA.Common.Models.Error error)
    {
        this._Leaderboard = leaderboard;
    }
    private void Setinfo(GK_Leaderboard leaderboard)
    {
        this._Leaderboard = leaderboard;
    }
    public GK_Leaderboard get_Leaderboard()
    {
        return (GK_Leaderboard)this._Leaderboard;
    }

}

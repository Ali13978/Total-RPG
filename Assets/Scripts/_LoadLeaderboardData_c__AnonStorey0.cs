using UnityEngine;
private sealed class LeaderboardManager.<LoadLeaderboardData>c__AnonStorey0
{
    // Fields
    internal GooglePlayGames.BasicApi.ScorePageToken token;
    internal string playerId;
    internal int rowCount;
    internal System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> callback;
    internal GooglePlayGames.Native.PInvoke.LeaderboardManager $this;
    
    // Methods
    public LeaderboardManager.<LoadLeaderboardData>c__AnonStorey0()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.FetchResponse rsp)
    {
        this.$this.HandleFetch(token:  this.token, response:  rsp, selfPlayerId:  this.playerId, maxResults:  this.rowCount, callback:  this.callback);
    }

}

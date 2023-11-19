using UnityEngine;
private sealed class LeaderboardManager.<HandleFetch>c__AnonStorey1
{
    // Fields
    internal GooglePlayGames.BasicApi.LeaderboardScoreData data;
    internal string selfPlayerId;
    internal int maxResults;
    internal GooglePlayGames.BasicApi.ScorePageToken token;
    internal System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> callback;
    internal GooglePlayGames.Native.PInvoke.LeaderboardManager $this;
    
    // Methods
    public LeaderboardManager.<HandleFetch>c__AnonStorey1()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.FetchScoreSummaryResponse rsp)
    {
        this.$this.HandleFetchScoreSummary(data:  this.data, response:  rsp, selfPlayerId:  this.selfPlayerId, maxResults:  this.maxResults, token:  this.token, callback:  this.callback);
    }

}

using UnityEngine;
private sealed class LeaderboardManager.<LoadScorePage>c__AnonStorey2
{
    // Fields
    internal GooglePlayGames.BasicApi.LeaderboardScoreData data;
    internal GooglePlayGames.BasicApi.ScorePageToken token;
    internal System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> callback;
    internal GooglePlayGames.Native.PInvoke.LeaderboardManager $this;
    
    // Methods
    public LeaderboardManager.<LoadScorePage>c__AnonStorey2()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.FetchScorePageResponse rsp)
    {
        this.$this.HandleFetchScorePage(data:  this.data, token:  this.token, rsp:  rsp, callback:  this.callback);
    }

}

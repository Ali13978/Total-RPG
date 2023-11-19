using UnityEngine;
private sealed class PlayGamesPlatform.<LoadScores>c__AnonStorey6
{
    // Fields
    internal UnityEngine.SocialPlatforms.ILeaderboard board;
    internal System.Action<bool> callback;
    internal GooglePlayGames.PlayGamesPlatform $this;
    
    // Methods
    public PlayGamesPlatform.<LoadScores>c__AnonStorey6()
    {
    
    }
    internal void <>m__0(GooglePlayGames.BasicApi.LeaderboardScoreData scoreData)
    {
        this.board = 0;
        this.$this.HandleLoadingScores(board:  this.board, scoreData:  scoreData, callback:  this.callback);
    }

}

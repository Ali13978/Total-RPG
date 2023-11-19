using UnityEngine;
private sealed class PlayGamesPlatform.<HandleLoadingScores>c__AnonStorey7
{
    // Fields
    internal GooglePlayGames.PlayGamesLeaderboard board;
    internal System.Action<bool> callback;
    internal GooglePlayGames.PlayGamesPlatform $this;
    
    // Methods
    public PlayGamesPlatform.<HandleLoadingScores>c__AnonStorey7()
    {
    
    }
    internal void <>m__0(GooglePlayGames.BasicApi.LeaderboardScoreData nextScoreData)
    {
        this.$this.HandleLoadingScores(board:  this.board, scoreData:  nextScoreData, callback:  this.callback);
    }

}

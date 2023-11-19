using UnityEngine;
private sealed class PlayGamesPlatform.<LoadScores>c__AnonStorey5
{
    // Fields
    internal System.Action<UnityEngine.SocialPlatforms.IScore[]> callback;
    
    // Methods
    public PlayGamesPlatform.<LoadScores>c__AnonStorey5()
    {
    
    }
    internal void <>m__0(GooglePlayGames.BasicApi.LeaderboardScoreData scoreData)
    {
        this.callback.Invoke(obj:  scoreData.Scores);
    }

}

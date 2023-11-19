using UnityEngine;
private sealed class PlayGamesLocalUser.<GetStats>c__AnonStorey0
{
    // Fields
    internal System.Action<GooglePlayGames.BasicApi.CommonStatusCodes, GooglePlayGames.BasicApi.PlayerStats> callback;
    internal GooglePlayGames.PlayGamesLocalUser $this;
    
    // Methods
    public PlayGamesLocalUser.<GetStats>c__AnonStorey0()
    {
    
    }
    internal void <>m__0(GooglePlayGames.BasicApi.CommonStatusCodes rc, GooglePlayGames.BasicApi.PlayerStats stats)
    {
        this.$this.mStats = stats;
        this.callback.Invoke(arg1:  rc, arg2:  stats);
    }

}

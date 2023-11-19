using UnityEngine;
private sealed class NativeTurnBasedMultiplayerClient.<RegisterMatchDelegate>c__AnonStoreyA
{
    // Fields
    internal GooglePlayGames.BasicApi.Multiplayer.MatchDelegate del;
    
    // Methods
    public NativeTurnBasedMultiplayerClient.<RegisterMatchDelegate>c__AnonStoreyA()
    {
    
    }
    internal void <>m__0(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, bool autoLaunch)
    {
        autoLaunch = autoLaunch;
        this.del.Invoke(match:  match, shouldAutoLaunch:  autoLaunch);
    }

}

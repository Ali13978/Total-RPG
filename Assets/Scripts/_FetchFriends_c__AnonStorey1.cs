using UnityEngine;
private sealed class PlayerManager.<FetchFriends>c__AnonStorey1
{
    // Fields
    internal System.Action<GooglePlayGames.BasicApi.ResponseStatus, System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Player>> callback;
    internal GooglePlayGames.Native.PInvoke.PlayerManager $this;
    
    // Methods
    public PlayerManager.<FetchFriends>c__AnonStorey1()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.PlayerManager.FetchListResponse rsp)
    {
        this.$this.HandleFetchCollected(rsp:  rsp, callback:  this.callback);
    }

}

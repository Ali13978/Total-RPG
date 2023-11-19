using UnityEngine;
private sealed class PlayerManager.<FetchList>c__AnonStorey0
{
    // Fields
    internal GooglePlayGames.Native.PInvoke.PlayerManager.FetchResponseCollector coll;
    internal GooglePlayGames.Native.PInvoke.PlayerManager $this;
    
    // Methods
    public PlayerManager.<FetchList>c__AnonStorey0()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.PlayerManager.FetchResponse rsp)
    {
        this.$this.HandleFetchResponse(collector:  this.coll, resp:  rsp);
    }

}

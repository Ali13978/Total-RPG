using UnityEngine;
internal class PlayerManager.FetchResponseCollector
{
    // Fields
    internal int pendingCount;
    internal System.Collections.Generic.List<GooglePlayGames.Native.PInvoke.NativePlayer> results;
    internal System.Action<GooglePlayGames.Native.PInvoke.NativePlayer[]> callback;
    
    // Methods
    public PlayerManager.FetchResponseCollector()
    {
        this.results = new System.Collections.Generic.List<GooglePlayGames.Native.PInvoke.NativePlayer>();
    }

}

using UnityEngine;
private sealed class PlayGamesPlatform.<InitializeNearby>c__AnonStorey0
{
    // Fields
    internal System.Action<GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient> callback;
    
    // Methods
    public PlayGamesPlatform.<InitializeNearby>c__AnonStorey0()
    {
    
    }
    internal void <>m__0(GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient client)
    {
        UnityEngine.Debug.Log(message:  0);
        GooglePlayGames.PlayGamesPlatform.sNearbyConnectionClient = client;
        if(this.callback != null)
        {
                this.callback.Invoke(obj:  client);
            return;
        }
        
        UnityEngine.Debug.Log(message:  0);
    }

}

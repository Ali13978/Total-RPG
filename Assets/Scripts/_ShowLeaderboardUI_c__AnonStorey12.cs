using UnityEngine;
private sealed class NativeClient.<ShowLeaderboardUI>c__AnonStorey12
{
    // Fields
    internal System.Action<GooglePlayGames.BasicApi.UIStatus> cb;
    
    // Methods
    public NativeClient.<ShowLeaderboardUI>c__AnonStorey12()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.Cwrapper.CommonErrorStatus.UIStatus result)
    {
        this.cb.Invoke(obj:  result);
    }

}

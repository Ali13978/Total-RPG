using UnityEngine;
private sealed class NativeClient.<ShowAchievementsUI>c__AnonStorey11
{
    // Fields
    internal System.Action<GooglePlayGames.BasicApi.UIStatus> cb;
    
    // Methods
    public NativeClient.<ShowAchievementsUI>c__AnonStorey11()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.Cwrapper.CommonErrorStatus.UIStatus result)
    {
        this.cb.Invoke(obj:  result);
    }

}

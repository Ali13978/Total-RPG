using UnityEngine;
private sealed class NativeClient.<LoadAchievements>c__AnonStoreyB
{
    // Fields
    internal System.Action<GooglePlayGames.BasicApi.Achievement[]> callback;
    internal GooglePlayGames.BasicApi.Achievement[] data;
    
    // Methods
    public NativeClient.<LoadAchievements>c__AnonStoreyB()
    {
    
    }
    internal void <>m__0()
    {
        this.callback.Invoke(obj:  this.data);
    }

}

using UnityEngine;
private sealed class PlayGamesPlatform.<Authenticate>c__AnonStorey1
{
    // Fields
    internal System.Action<bool> callback;
    
    // Methods
    public PlayGamesPlatform.<Authenticate>c__AnonStorey1()
    {
    
    }
    internal void <>m__0(bool success, string msg)
    {
        success = success;
        this.callback.Invoke(obj:  success);
    }

}

using UnityEngine;
private sealed class EndlessInAppManager.<buy>c__AnonStorey0
{
    // Fields
    internal System.Action<TzarGames.Common.IPurchaseResult> resultCallback;
    
    // Methods
    public EndlessInAppManager.<buy>c__AnonStorey0()
    {
    
    }
    internal void <>m__0(TzarGames.Common.IPurchaseResult result)
    {
        if(this.resultCallback == null)
        {
                return;
        }
        
        this.resultCallback.Invoke(obj:  result);
    }

}

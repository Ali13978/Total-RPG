using UnityEngine;
private sealed class Callbacks.<AsOnGameThreadCallback>c__AnonStorey2<T>
{
    // Fields
    internal System.Action<T> toInvokeOnGameThread;
    
    // Methods
    public Callbacks.<AsOnGameThreadCallback>c__AnonStorey2<T>()
    {
        if(this != null)
        {
                return;
        }
    
    }
    internal void <>m__0(T result)
    {
        if((__RuntimeMethodHiddenParam + 24 + 168) != 0)
        {
                mem2[0] = this;
        }
        else
        {
                mem[24] = this;
        }
        
        mem2[0] = result;
        if(24 == 0)
        {
                return;
        }
        
        System.Action val_1 = new System.Action(object:  __RuntimeMethodHiddenParam + 24 + 168, method:  __RuntimeMethodHiddenParam + 24 + 168 + 16);
        GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  0);
    }

}

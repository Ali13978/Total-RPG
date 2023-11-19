using UnityEngine;
private sealed class Callbacks.<AsOnGameThreadCallback>c__AnonStorey4<T1, T2>
{
    // Fields
    internal System.Action<T1, T2> toInvokeOnGameThread;
    
    // Methods
    public Callbacks.<AsOnGameThreadCallback>c__AnonStorey4<T1, T2>()
    {
        if(this != null)
        {
                return;
        }
    
    }
    internal void <>m__0(T1 result1, T2 result2)
    {
        if((__RuntimeMethodHiddenParam + 24 + 168) != 0)
        {
                mem2[0] = this;
            mem2[0] = result1;
        }
        else
        {
                mem[32] = this;
            mem[16] = result1;
        }
        
        mem2[0] = result2;
        if(16 == 0)
        {
                return;
        }
        
        System.Action val_1 = new System.Action(object:  __RuntimeMethodHiddenParam + 24 + 168, method:  __RuntimeMethodHiddenParam + 24 + 168 + 16);
        GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  0);
    }

}

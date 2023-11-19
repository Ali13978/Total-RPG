using UnityEngine;
private sealed class CallbackUtils.<ToOnGameThread>c__AnonStorey2<T1, T2>
{
    // Fields
    internal System.Action<T1, T2> toConvert;
    
    // Methods
    public CallbackUtils.<ToOnGameThread>c__AnonStorey2<T1, T2>()
    {
        if(this != null)
        {
                return;
        }
    
    }
    internal void <>m__0(T1 val1, T2 val2)
    {
        if((__RuntimeMethodHiddenParam + 24 + 168) != 0)
        {
                mem2[0] = this;
            mem2[0] = val1;
        }
        else
        {
                mem[32] = this;
            mem[16] = val1;
        }
        
        mem2[0] = val2;
        System.Action val_1 = new System.Action(object:  __RuntimeMethodHiddenParam + 24 + 168, method:  __RuntimeMethodHiddenParam + 24 + 168 + 16);
        GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  0);
    }

}

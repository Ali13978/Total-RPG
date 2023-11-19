using UnityEngine;
private sealed class CallbackUtils.<ToOnGameThread>c__AnonStorey0<T>
{
    // Fields
    internal System.Action<T> toConvert;
    
    // Methods
    public CallbackUtils.<ToOnGameThread>c__AnonStorey0<T>()
    {
        if(this != null)
        {
                return;
        }
    
    }
    internal void <>m__0(T val)
    {
        if((__RuntimeMethodHiddenParam + 24 + 168) != 0)
        {
                mem2[0] = this;
        }
        else
        {
                mem[24] = this;
        }
        
        mem2[0] = val;
        System.Action val_1 = new System.Action(object:  __RuntimeMethodHiddenParam + 24 + 168, method:  __RuntimeMethodHiddenParam + 24 + 168 + 16);
        GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  0);
    }

}

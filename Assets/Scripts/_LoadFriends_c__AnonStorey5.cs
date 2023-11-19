using UnityEngine;
private sealed class NativeClient.<LoadFriends>c__AnonStorey5
{
    // Fields
    internal System.Action<bool> callback;
    internal GooglePlayGames.Native.NativeClient $this;
    
    // Methods
    public NativeClient.<LoadFriends>c__AnonStorey5()
    {
    
    }
    internal void <>m__0()
    {
        this.callback.Invoke(obj:  false);
    }
    internal void <>m__1()
    {
        this.callback.Invoke(obj:  true);
    }
    internal void <>m__2(GooglePlayGames.BasicApi.ResponseStatus status, System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Player> players)
    {
        if((status - 1) <= 1)
        {
                this.$this.mFriends = players;
            System.Action val_2 = new System.Action(object:  this, method:  System.Void NativeClient.<LoadFriends>c__AnonStorey5::<>m__3());
            GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  0);
            return;
        }
        
        this.$this.mFriends = new System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Player>();
        string val_4 = 0 + "Got " + status;
        GooglePlayGames.OurUtils.Logger.e(msg:  0);
        System.Action val_5 = new System.Action(object:  this, method:  System.Void NativeClient.<LoadFriends>c__AnonStorey5::<>m__4());
        GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  0);
    }
    internal void <>m__3()
    {
        this.callback.Invoke(obj:  true);
    }
    internal void <>m__4()
    {
        this.callback.Invoke(obj:  false);
    }

}

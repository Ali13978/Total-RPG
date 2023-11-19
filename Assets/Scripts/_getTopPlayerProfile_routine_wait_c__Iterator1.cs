using UnityEngine;
private sealed class SocialSystem.<getTopPlayerProfile_routine_wait>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal string leaderboardId;
    internal bool friend;
    internal System.Action<bool, UnityEngine.SocialPlatforms.IUserProfile> callback;
    internal TzarGames.Endless.SocialSystem $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public SocialSystem.<getTopPlayerProfile_routine_wait>c__Iterator1()
    {
    
    }
    public bool MoveNext()
    {
        int val_3;
        int val_3 = this.$PC;
        this.$PC = 0;
        val_3 = val_3 | 1;
        if(val_3 != 1)
        {
            goto label_1;
        }
        
        if(this.$this.getTopPlayerCallbacks.Count <= 0)
        {
            goto label_4;
        }
        
        val_3 = 1;
        this.$current = 0;
        if(this.$disposing == true)
        {
                return (bool)val_3;
        }
        
        this.$PC = val_3;
        return (bool)val_3;
        label_1:
        val_3 = 0;
        return (bool)val_3;
        label_4:
        this.$this.getTopPlayerProfile_routine(leaderboardId:  this.leaderboardId, friend:  (this.friend == true) ? 1 : 0, callback:  this.callback);
        val_3 = 0;
        this.$PC = 0;
        return (bool)val_3;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private object System.Collections.Generic.IEnumerator<object>.get_Current()
    {
        return (object)this.$current;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.$current;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public void Dispose()
    {
        this.$disposing = true;
        this.$PC = 0;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public void Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }

}

using UnityEngine;
private sealed class SocialSystem.<getTopPlayerRoutine>c__Iterator2 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal string leaderboardId;
    internal bool friend;
    internal string <id>__0;
    internal TzarGames.Endless.SocialSystem.TopPlayerCallbackList <list>__0;
    internal System.Collections.Generic.List.Enumerator<System.Action<bool, UnityEngine.SocialPlatforms.IUserProfile>> $locvar0;
    internal TzarGames.Endless.SocialSystem $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    private TzarGames.Endless.SocialSystem.<getTopPlayerRoutine>c__Iterator2.<getTopPlayerRoutine>c__AnonStorey5 $locvar1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public SocialSystem.<getTopPlayerRoutine>c__Iterator2()
    {
    
    }
    public bool MoveNext()
    {
        var val_10;
        List.Enumerator<System.Action<System.Boolean, UnityEngine.SocialPlatforms.IUserProfile>> val_11;
        int val_18;
        <getTopPlayerRoutine>c__AnonStorey5 val_19;
        <getTopPlayerRoutine>c__AnonStorey5 val_20;
        string val_21;
        System.Action<System.Boolean, UnityEngine.SocialPlatforms.IUserProfile> val_22;
        <getTopPlayerRoutine>c__AnonStorey5 val_23;
        string val_24;
        <getTopPlayerRoutine>c__AnonStorey5 val_25;
        var val_29;
        var val_30;
        int val_18 = this.$PC;
        this.$PC = 0;
        val_18 = ((val_18 == 1) ? 1 : 0) << 2;
        var val_2 = (val_18 == 0) ? 3 : (val_18);
        if(val_2 == 3)
        {
            goto label_1;
        }
        
        val_18 = 0;
        if(val_2 != 4)
        {
                return (bool)val_18;
        }
        
        val_19 = this.$locvar1;
        goto label_3;
        label_1:
        val_19 = this;
        this.$locvar1 = new System.Object();
        typeof(SocialSystem.<getTopPlayerRoutine>c__Iterator2.<getTopPlayerRoutine>c__AnonStorey5).__il2cppRuntimeField_28 = this;
        this.$locvar1.leaderboardId = this.leaderboardId;
        this.$locvar1.friend = this.friend;
        typeof(SocialSystem.<getTopPlayerRoutine>c__Iterator2.<getTopPlayerRoutine>c__AnonStorey5).__il2cppRuntimeField_1A = 0;
        typeof(SocialSystem.<getTopPlayerRoutine>c__Iterator2.<getTopPlayerRoutine>c__AnonStorey5).__il2cppRuntimeField_20 = 0;
        typeof(SocialSystem.<getTopPlayerRoutine>c__Iterator2.<getTopPlayerRoutine>c__AnonStorey5).__il2cppRuntimeField_19 = 1;
        val_20 = this.$locvar1;
        if(this.$locvar1 != null)
        {
            goto label_10;
        }
        
        val_20 = this.$locvar1;
        if(null == 0)
        {
            goto label_46;
        }
        
        label_10:
        val_21 = this.$locvar1.leaderboardId;
        System.Action<System.Boolean, UnityEngine.SocialPlatforms.IUserProfile> val_4 = null;
        val_22 = val_4;
        val_4 = new System.Action<System.Boolean, UnityEngine.SocialPlatforms.IUserProfile>(object:  val_20, method:  System.Void SocialSystem.<getTopPlayerRoutine>c__Iterator2.<getTopPlayerRoutine>c__AnonStorey5::<>m__0(bool result, UnityEngine.SocialPlatforms.IUserProfile profile));
        this.$this.getTopPlayerProfile(leaderboardId:  val_21, friend:  ((SocialSystem.<getTopPlayerRoutine>c__Iterator2.<getTopPlayerRoutine>c__AnonStorey5.__il2cppRuntimeField_namespaze) != 0) ? 1 : 0, callback:  val_22);
        label_3:
        if((typeof(SocialSystem.<getTopPlayerRoutine>c__Iterator2.<getTopPlayerRoutine>c__AnonStorey5).__il2cppRuntimeField_19) != 0)
        {
                val_18 = 1;
            this.$current = 0;
            if(this.$disposing == true)
        {
                return (bool)val_18;
        }
        
            this.$PC = val_18;
            return (bool)val_18;
        }
        
        val_23 = this.$locvar1;
        if(this.$locvar1 != null)
        {
            goto label_17;
        }
        
        val_23 = this.$locvar1;
        if(null == 0)
        {
            goto label_46;
        }
        
        label_17:
        val_24 = this.$this.buildCallbackId(leaderboardId:  this.$locvar1.leaderboardId, friend:  ((SocialSystem.<getTopPlayerRoutine>c__Iterator2.<getTopPlayerRoutine>c__AnonStorey5.__il2cppRuntimeField_namespaze) != 0) ? 1 : 0);
        this.<id>__0 = val_24;
        if(this.$this == null)
        {
                val_24 = this.<id>__0;
        }
        
        TopPlayerCallbackList val_8 = this.$this.getTopPlayerCallbacks.Item[val_24];
        this.<list>__0 = val_8;
        List.Enumerator<T> val_9 = val_8.GetEnumerator();
        mem[1152921510849476080] = val_10;
        this.$locvar0 = val_11;
        label_33:
        if(((this.$locvar0 & 1) & 1) == 0)
        {
            goto label_23;
        }
        
        val_25 = this.$locvar1;
        if(null != 0)
        {
                var val_14 = ((typeof(SocialSystem.<getTopPlayerRoutine>c__Iterator2.<getTopPlayerRoutine>c__AnonStorey5).__il2cppRuntimeField_1A) != 0) ? 1 : 0;
        }
        else
        {
                val_25 = this.$locvar1;
            if(null == 0)
        {
                val_25 = 0;
        }
        
        }
        
        this.$locvar0.InitializationCallback.Invoke(arg1:  ((typeof(SocialSystem.<getTopPlayerRoutine>c__Iterator2.<getTopPlayerRoutine>c__AnonStorey5).__il2cppRuntimeField_1A) != 0) ? 1 : 0, arg2:  64);
        goto label_33;
        label_23:
        val_29 = 0;
        val_30 = 1;
        this.$locvar0.Dispose();
        val_21 = this.<id>__0;
        bool val_16 = this.$this.getTopPlayerCallbacks.Remove(key:  val_21);
        if(this.$this.LogDebugInfo != false)
        {
                string val_17 = 0 + "get top player profile removed: "("get top player profile removed: ");
            UnityEngine.Debug.Log(message:  0);
        }
        
        val_18 = 0;
        this.$PC = 0;
        return (bool)val_18;
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

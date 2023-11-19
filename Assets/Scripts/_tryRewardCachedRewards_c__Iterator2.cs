using UnityEngine;
private sealed class Rewarder.<tryRewardCachedRewards>c__Iterator2 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal TzarGames.Endless.EndlessGameState <game>__0;
    internal TzarGames.Common.SerializableData <data>__0;
    internal bool <needSave>__0;
    internal System.Collections.Generic.List<TzarGames.Endless.Reward> <processingRewards>__0;
    internal TzarGames.Endless.Rewarder $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public Rewarder.<tryRewardCachedRewards>c__Iterator2()
    {
    
    }
    public bool MoveNext()
    {
        Rewarder.<tryRewardCachedRewards>c__Iterator2 val_19;
        Rewarder.<tryRewardCachedRewards>c__Iterator2 val_20;
        int val_21;
        System.Collections.Generic.List<TzarGames.Endless.Reward> val_22;
        TzarGames.Common.SerializableData val_23;
        TzarGames.Endless.EndlessGameState val_24;
        bool val_25;
        int val_26;
        val_20 = this;
        int val_18 = this.$PC;
        this.$PC = 0;
        val_18 = ((val_18 == 1) ? 1 : 0) << 2;
        var val_2 = (val_18 == 0) ? 3 : (val_18);
        if(val_2 == 3)
        {
            goto label_1;
        }
        
        val_21 = 0;
        if(val_2 != 4)
        {
                return (bool)val_21;
        }
        
        val_22 = this.<processingRewards>__0;
        val_23 = this.<data>__0;
        val_24 = this.<game>__0;
        val_25 = this.<needSave>__0;
        goto label_32;
        label_1:
        TzarGames.Endless.EndlessGameState val_3 = TzarGames.Endless.EndlessGameState.Instance;
        val_24 = val_20;
        this.<game>__0 = val_3;
        if((val_3.IsItSafeStateToSaveGame() == false) || ((this.<game>__0.SelectedCharacter) == null))
        {
            goto label_7;
        }
        
        val_23 = val_20;
        this.<data>__0 = this.<game>__0.CommonSaveGameData;
        this.<needSave>__0 = false;
        System.Collections.Generic.List<TzarGames.Endless.Reward> val_7 = null;
        val_25 = 1152921510813083760;
        val_20 = val_7;
        val_7 = new System.Collections.Generic.List<TzarGames.Endless.Reward>(collection:  this.$this.rewards);
        val_22 = val_20;
        this.<processingRewards>__0 = val_20;
        label_32:
        val_19 = 1152921510813084784;
        if(Count <= 0)
        {
            goto label_11;
        }
        
        val_26 = Count - 1;
        goto label_13;
        label_31:
        val_26 = val_26 - 1;
        label_13:
        val_20 = this.<processingRewards>__0;
        if((val_26 & 2147483648) != 0)
        {
            goto label_15;
        }
        
        TzarGames.Endless.Reward val_10 = Item[val_26];
        if((val_10 & 1) == 0)
        {
            goto label_31;
        }
        
        string val_11 = val_10.Name;
        if((this.<data>__0.HasInt(id:  val_11)) == false)
        {
            goto label_31;
        }
        
        if((this.<data>__0.GetInt(id:  val_11)) <= 0)
        {
            goto label_21;
        }
        
        if((this.<game>__0.IsInMainMenu()) != false)
        {
                if(((val_10 & 1) & 1) == 0)
        {
            goto label_31;
        }
        
        }
        
        this.<data>__0.DeleteInt(id:  val_11);
        mem2[0] = 1;
        bool val_16 = Remove(item:  val_10);
        goto label_31;
        label_21:
        this.<data>__0.DeleteInt(id:  val_11);
        goto label_31;
        label_15:
        if(Count < 1)
        {
            goto label_32;
        }
        
        val_21 = 1;
        mem[1152921510813120104] = 0;
        if(mem[1152921510813120112] == true)
        {
                return (bool)val_21;
        }
        
        this.$PC = val_21;
        return (bool)val_21;
        label_7:
        val_21 = 0;
        return (bool)val_21;
        label_11:
        val_19 = val_20;
        if((this.<needSave>__0) != 0)
        {
                this.<game>__0.SaveGame();
        }
        
        val_21 = 0;
        this.$PC = 0;
        return (bool)val_21;
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

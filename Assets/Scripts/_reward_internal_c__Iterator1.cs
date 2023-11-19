using UnityEngine;
private sealed class Rewarder.<reward_internal>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal int count;
    internal int <totalCount>__0;
    internal TzarGames.Endless.EndlessGameState <game>__0;
    internal TzarGames.Endless.Reward reward;
    internal string <key>__0;
    internal TzarGames.Common.SerializableData <data>__0;
    internal TzarGames.Endless.Rewarder $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public Rewarder.<reward_internal>c__Iterator1()
    {
    
    }
    public bool MoveNext()
    {
        int val_26;
        TzarGames.Endless.EndlessGameState val_27;
        var val_28;
        var val_29;
        int val_30;
        int val_26 = this.$PC;
        this.$PC = 0;
        val_26 = ((val_26 == 1) ? 1 : 0) << 2;
        var val_2 = (val_26 == 0) ? 3 : (val_26);
        if(val_2 != 3)
        {
                val_26 = 0;
            if(val_2 != 4)
        {
                return (bool)val_26;
        }
        
            val_27 = this.<game>__0;
        }
        else
        {
                this.<totalCount>__0 = this.count;
            val_27 = this.<game>__0;
            this.<game>__0 = TzarGames.Endless.EndlessGameState.Instance;
            this.<key>__0 = this.reward.Name;
        }
        
        if((mem[this.<game>__0].IsInitializing()) != false)
        {
                val_26 = 1;
            this.$current = 0;
            if(this.$disposing == true)
        {
                return (bool)val_26;
        }
        
            this.$PC = val_26;
            return (bool)val_26;
        }
        
        this.<data>__0 = mem[this.<game>__0].CommonSaveGameData;
        if((this.<game>__0.IsItSafeStateToSaveGame()) == false)
        {
            goto label_11;
        }
        
        if((mem[this.<game>__0].IsInMainMenu()) != false)
        {
                if(((this.reward & 1) & 1) == 0)
        {
            goto label_15;
        }
        
        }
        
        val_28 = 0;
        if((this.<data>__0.HasInt(id:  this.<key>__0)) != false)
        {
                this.<totalCount>__0 = (this.<data>__0.GetInt(id:  this.<key>__0)) + (this.<totalCount>__0);
            val_28 = 0;
            this.<data>__0.DeleteInt(id:  this.<key>__0);
        }
        
        if(this.reward != null)
        {
            goto label_21;
        }
        
        goto label_21;
        label_11:
        val_29 = 0;
        if((this.<data>__0.HasInt(id:  this.<key>__0)) != false)
        {
                val_29 = 0;
            this.<totalCount>__0 = (this.<data>__0.GetInt(id:  this.<key>__0)) + (this.<totalCount>__0);
        }
        
        if(((mem[this.<game>__0].IsInGameState()) == false) || ((this.reward & 1) == 0))
        {
            goto label_28;
        }
        
        this.<data>__0.DeleteInt(id:  this.<key>__0);
        goto label_33;
        label_28:
        this.<data>__0.SetInt(id:  this.<key>__0, val:  this.<totalCount>__0);
        goto label_33;
        label_15:
        val_30 = this.<totalCount>__0;
        if((this.<data>__0.HasInt(id:  this.<key>__0)) != false)
        {
                val_30 = (this.<data>__0.GetInt(id:  this.<key>__0)) + val_30;
            this.<totalCount>__0 = val_30;
        }
        
        this.<data>__0.SetInt(id:  this.<key>__0, val:  val_30);
        label_21:
        mem[this.<game>__0].SaveGame();
        label_33:
        if(0 != TzarGames.Endless.UI.GlobalUI.Instance)
        {
                TzarGames.Endless.UI.GlobalUI.Instance.Alert.Show(message:  this.reward);
        }
        
        this.$this.OnCustomReward.Invoke(arg0:  this.reward.Name);
        val_26 = 0;
        this.$PC = 0;
        return (bool)val_26;
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

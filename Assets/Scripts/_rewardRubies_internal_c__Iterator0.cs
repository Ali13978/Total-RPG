using UnityEngine;
private sealed class Rewarder.<rewardRubies_internal>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal int rubyCount;
    internal int <totalCount>__0;
    internal TzarGames.Endless.EndlessGameState <game>__0;
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
    public Rewarder.<rewardRubies_internal>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_24;
        TzarGames.Endless.EndlessGameState val_25;
        TzarGames.Endless.EndlessGameState val_26;
        var val_27;
        TzarGames.Common.SerializableData val_28;
        var val_29;
        int val_30;
        int val_24 = this.$PC;
        this.$PC = 0;
        val_24 = ((val_24 == 1) ? 1 : 0) << 2;
        var val_2 = (val_24 == 0) ? 3 : (val_24);
        if(val_2 != 3)
        {
                val_24 = 0;
            if(val_2 != 4)
        {
                return (bool)val_24;
        }
        
            val_25 = this;
            val_26 = this.<game>__0;
        }
        else
        {
                this.<totalCount>__0 = this.rubyCount;
            val_26 = TzarGames.Endless.EndlessGameState.Instance;
            val_25 = this.<game>__0;
            this.<game>__0 = val_26;
        }
        
        if((val_26.IsInitializing() == true) || ((mem[this.<game>__0].CharacterCount) == 0))
        {
            goto label_7;
        }
        
        this.<data>__0 = mem[this.<game>__0].CommonSaveGameData;
        val_27 = 0;
        bool val_9 = this.<data>__0.HasInt(id:  "COMMON_RUBY_REWARD");
        if((this.<game>__0.IsItSafeStateToSaveGame()) == false)
        {
            goto label_11;
        }
        
        if(val_9 != false)
        {
                this.<totalCount>__0 = (this.<data>__0.GetInt(id:  "COMMON_RUBY_REWARD")) + (this.<totalCount>__0);
            val_27 = 0;
            this.<data>__0.DeleteInt(id:  "COMMON_RUBY_REWARD");
        }
        
        val_28 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
        var val_25 = 0;
        val_25 = val_25 + 1;
        val_27 = 5;
        val_29 = val_28;
        goto label_20;
        label_7:
        val_24 = 1;
        this.$current = 0;
        if(this.$disposing == true)
        {
                return (bool)val_24;
        }
        
        this.$PC = val_24;
        return (bool)val_24;
        label_11:
        val_30 = this.<totalCount>__0;
        if(val_9 != false)
        {
                val_30 = (this.<data>__0.GetInt(id:  "COMMON_RUBY_REWARD")) + val_30;
            this.<totalCount>__0 = val_30;
        }
        
        val_28 = this.<data>__0;
        val_28.SetInt(id:  "COMMON_RUBY_REWARD", val:  val_30);
        goto label_28;
        label_20:
        if((mem[this.<game>__0].IsItSafeStateToSaveGame()) != false)
        {
                mem[this.<game>__0].SaveGame();
        }
        
        label_28:
        if(0 != TzarGames.Endless.UI.GlobalUI.Instance)
        {
                val_28 = TzarGames.Endless.UI.GlobalUI.Instance.Alert;
            val_28.Show(message:  System.String.Format(format:  0, arg0:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0)));
        }
        
        if(TzarGames.Endless.Rewarder.OnRubiesRewarded != null)
        {
                TzarGames.Endless.Rewarder.OnRubiesRewarded.Invoke(obj:  this.<totalCount>__0);
        }
        
        val_24 = 0;
        this.$PC = 0;
        return (bool)val_24;
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

using UnityEngine;
private sealed class PlayerCharacterUI.<checkForNewItems>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal TzarGames.Endless.UI.PlayerCharacterUI $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public PlayerCharacterUI.<checkForNewItems>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_11;
        TzarGames.Endless.UI.PlayerCharacterUI val_12;
        var val_13;
        int val_11 = this.$PC;
        this.$PC = 0;
        val_11 = ((val_11 == 1) ? 1 : 0) << 2;
        var val_2 = (val_11 == 0) ? 3 : (val_11);
        if(val_2 != 4)
        {
                val_11 = 0;
            if(val_2 != 3)
        {
                return (bool)val_11;
        }
        
            val_11 = 1;
            this.$current = 0;
            if(this.$disposing == true)
        {
                return (bool)val_11;
        }
        
            this.$PC = val_11;
            return (bool)val_11;
        }
        
        val_12 = 1152921504721543168;
        if(0 == this.$this.gameState)
        {
                this.$this.gameState = TzarGames.Endless.EndlessGameState.Instance;
        }
        
        if(((0 != this.$this.itemNotificator) && (0 != this.$this.gameState)) && (this.$this.gameState.IsInLobby() != false))
        {
                this.$this.itemNotificator.CheckForNewItems();
            TzarGames.GameFramework.Player val_8 = this.$this.PlayerOwner;
            val_12 = this.$this;
            if(val_8.PlayerComponent != null)
        {
                val_12 = 1152921504921595904;
            val_13 = null;
            val_13 = null;
            var val_10 = (((TzarGames.GameFramework.IPlayerComponent.__il2cppRuntimeField_typeHierarchy + (TzarGames.TzarHero.TH_Character.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_13) ? val_8.PlayerComponent : 0;
        }
        
            0.add_OnCharacterLevelUp(value:  new TH_Character.dlgCharacterEvent(object:  val_12, method:  System.Void TzarGames.Endless.UI.PlayerCharacterUI::Handle_OnCharacterLevelUp(TzarGames.TzarHero.TH_Character character)));
        }
        
        val_11 = 0;
        this.$PC = 0;
        return (bool)val_11;
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

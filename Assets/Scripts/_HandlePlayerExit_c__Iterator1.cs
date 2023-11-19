using UnityEngine;
private sealed class GameManager.<HandlePlayerExit>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal TzarGames.GameFramework.Player player;
    internal byte[] <playerData>__1;
    internal TzarGames.GameFramework.GameManager $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    private TzarGames.GameFramework.GameManager.<HandlePlayerExit>c__Iterator1.<HandlePlayerExit>c__AnonStorey4 $locvar0;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public GameManager.<HandlePlayerExit>c__Iterator1()
    {
    
    }
    public bool MoveNext()
    {
        int val_7;
        <HandlePlayerExit>c__AnonStorey4 val_8;
        var val_9;
        TzarGames.GameFramework.Player val_10;
        int val_7 = this.$PC;
        this.$PC = 0;
        val_7 = ((val_7 == 1) ? 1 : 0) << 2;
        var val_2 = (val_7 == 0) ? 3 : (val_7);
        if(val_2 == 3)
        {
            goto label_1;
        }
        
        val_7 = 0;
        if(val_2 != 4)
        {
                return (bool)val_7;
        }
        
        val_8 = this.$locvar0;
        goto label_3;
        label_1:
        if((this.player == null) || (this.player.PlayerComponent == null))
        {
            goto label_5;
        }
        
        val_8 = this;
        this.$locvar0 = new System.Object();
        typeof(GameManager.<HandlePlayerExit>c__Iterator1.<HandlePlayerExit>c__AnonStorey4).__il2cppRuntimeField_18 = this;
        bool val_4 = this.$this.players.Remove(item:  this.player);
        var val_8 = 0;
        val_8 = val_8 + 1;
        val_9 = this.player.PlayerComponent;
        this.<playerData>__1 = this.player.PlayerComponent;
        this.$locvar0.isCompleted = false;
        val_10 = this.player;
        System.Action val_6 = new System.Action(object:  this.$locvar0, method:  System.Void GameManager.<HandlePlayerExit>c__Iterator1.<HandlePlayerExit>c__AnonStorey4::<>m__0());
        label_3:
        if((GameManager.<HandlePlayerExit>c__Iterator1.<HandlePlayerExit>c__AnonStorey4) == null)
        {
            goto label_18;
        }
        
        val_10 = this.player;
        this.$this.onPlayerExitFromGame.Invoke(arg0:  val_10);
        label_5:
        val_7 = 0;
        this.$PC = 0;
        return (bool)val_7;
        label_18:
        val_7 = 1;
        this.$current = 0;
        if(this.$disposing == true)
        {
                return (bool)val_7;
        }
        
        this.$PC = val_7;
        return (bool)val_7;
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

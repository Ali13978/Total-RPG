using UnityEngine;
private sealed class GameManager.<HandlePlayerEnter>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal TzarGames.GameFramework.Player player;
    internal TzarGames.GameFramework.GameManager $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    private TzarGames.GameFramework.GameManager.<HandlePlayerEnter>c__Iterator0.<HandlePlayerEnter>c__AnonStorey3 $locvar0;
    private TzarGames.GameFramework.GameManager.<HandlePlayerEnter>c__Iterator0.<HandlePlayerEnter>c__AnonStorey2 $locvar1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public GameManager.<HandlePlayerEnter>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_23;
        <HandlePlayerEnter>c__AnonStorey2 val_24;
        var val_25;
        <HandlePlayerEnter>c__AnonStorey3 val_26;
        float val_27;
        float val_28;
        float val_29;
        int val_23 = this.$PC;
        this.$PC = 0;
        val_23 = ((val_23 == 1) ? 1 : 0) << 2;
        var val_2 = (val_23 == 0) ? 3 : (val_23);
        if(val_2 == 3)
        {
            goto label_1;
        }
        
        val_23 = 0;
        if(val_2 != 4)
        {
                return (bool)val_23;
        }
        
        val_24 = this.$locvar1;
        goto label_28;
        label_1:
        this.$locvar0 = new System.Object();
        typeof(GameManager.<HandlePlayerEnter>c__Iterator0.<HandlePlayerEnter>c__AnonStorey3).__il2cppRuntimeField_18 = this;
        val_25 = this;
        if(this.$this.OnServer != false)
        {
                if(this.player.IsConnected == false)
        {
            goto label_39;
        }
        
        }
        
        this.$locvar0.playerData = 0;
        if(this.$this.OnClient == true)
        {
            goto label_35;
        }
        
        val_24 = this;
        this.$locvar1 = new System.Object();
        typeof(GameManager.<HandlePlayerEnter>c__Iterator0.<HandlePlayerEnter>c__AnonStorey2).__il2cppRuntimeField_18 = this;
        this.$locvar1.<>f__ref$3 = this.$locvar0;
        typeof(GameManager.<HandlePlayerEnter>c__Iterator0.<HandlePlayerEnter>c__AnonStorey2).__il2cppRuntimeField_10 = 1;
        if(((this.player.itsMe != false) && (0 != this.$this.netSync)) && ((this.$this.Connected != false) && (this.$this.netSync.receiveDataFromOwnerPlayer != false)))
        {
                val_26 = this.$locvar0;
            this.$locvar0.playerData = null;
            typeof(GameManager.<HandlePlayerEnter>c__Iterator0.<HandlePlayerEnter>c__AnonStorey2).__il2cppRuntimeField_10 = 0;
        }
        else
        {
                val_26 = this.$this;
            System.Action<System.Byte[]> val_12 = new System.Action<System.Byte[]>(object:  this.$locvar1, method:  System.Void GameManager.<HandlePlayerEnter>c__Iterator0.<HandlePlayerEnter>c__AnonStorey2::<>m__0(byte[] data));
        }
        
        label_28:
        if((typeof(GameManager.<HandlePlayerEnter>c__Iterator0.<HandlePlayerEnter>c__AnonStorey2).__il2cppRuntimeField_10) != 0)
        {
                val_23 = 1;
            this.$current = 0;
            if(this.$disposing == true)
        {
                return (bool)val_23;
        }
        
            this.$PC = val_23;
            return (bool)val_23;
        }
        
        val_25 = this;
        if(this.$this.OnServer != false)
        {
                if((this.player.DisconnectingFlag == true) || (this.player.IsConnected == false))
        {
            goto label_39;
        }
        
        }
        
        label_35:
        this.$this.players.Add(item:  this.player);
        val_26 = this.player;
        this.$this.onPlayerEnterToGame.Invoke(arg0:  val_26);
        if(this.$this.OnClient == true)
        {
            goto label_45;
        }
        
        if(0 != this.$this)
        {
            goto label_49;
        }
        
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.zero;
        val_27 = val_18.x;
        val_28 = val_18.y;
        val_29 = val_18.z;
        UnityEngine.Quaternion val_19 = UnityEngine.Quaternion.identity;
        goto label_54;
        label_39:
        val_23 = 0;
        return (bool)val_23;
        label_49:
        UnityEngine.Vector3 val_20 = this.$this.Position;
        val_27 = val_20.x;
        val_28 = val_20.y;
        val_29 = val_20.z;
        UnityEngine.Quaternion val_21 = this.$this.Rotation;
        label_54:
        val_26 = this.$this;
        UnityEngine.GameObject val_22 = val_26.SpawnObjectForPlayer(player:  this.player, position:  new UnityEngine.Vector3() {x = val_27, y = val_28, z = val_29}, rotation:  new UnityEngine.Quaternion() {x = val_21.x, y = val_21.y, z = val_21.z, w = val_21.w}, playerData:  this.$locvar0.playerData);
        label_45:
        val_23 = 0;
        this.$PC = 0;
        return (bool)val_23;
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

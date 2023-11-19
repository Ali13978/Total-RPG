using UnityEngine;
private sealed class EndlessSpawner.Spawning.<spawnRoutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal TzarGames.Endless.SpawnGroup spawingGroup;
    internal TzarGames.Endless.ObjectSpawnInfo[] $locvar0;
    internal int $locvar1;
    internal TzarGames.Endless.ObjectSpawnInfo <group>__1;
    internal TzarGames.GameFramework.SpawnPoint[] <spawnPoints>__2;
    internal int <i>__3;
    internal TzarGames.GameFramework.TzarBehaviour <spawned>__4;
    internal TzarGames.Endless.EndlessSpawner.Spawning $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public EndlessSpawner.Spawning.<spawnRoutine>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_27;
        var val_28;
        EndlessSpawner.Spawning val_29;
        int val_30;
        TzarGames.Endless.ObjectSpawnInfo[] val_31;
        TzarGames.GameFramework.TzarBehaviour val_32;
        TzarGames.Endless.ObjectSpawnInfo val_33;
        int val_34;
        var val_35;
        uint val_36;
        float val_37;
        int val_38;
        int val_25 = this.$PC;
        val_27 = 0;
        this.$PC = 0;
        val_25 = (val_25 < 5) ? (val_25 + 3) : 0;
        val_25 = val_25 - 3;
        if(val_25 > 4)
        {
                return (bool)val_27;
        }
        
        var val_26 = 25804244 + ((this.$PC < 5 ? (this.$PC + 3) : 0 - 3)) << 2;
        val_26 = val_26 + 25804244;
        goto (25804244 + ((this.$PC < 5 ? (this.$PC + 3) : 0 - 3)) << 2 + 25804244);
        label_50:
        val_31 = this.spawingGroup.Objects;
        val_29 = this;
        val_28 = this;
        val_30 = 0;
        this.$locvar0 = val_31;
        this.$locvar1 = 0;
        if(val_30 >= val_2.Length)
        {
            goto label_9;
        }
        
        val_33 = this;
        this.<group>__1 = val_2.Length + 32;
        TzarGames.Endless.EndlessSpawner val_3 = this.$this.Spawner;
        val_34 = 0;
        this.<i>__3 = 0;
        this.<spawnPoints>__2 = val_3.commonSpawnPoints;
        if(val_34 >= (this.<group>__1.Count))
        {
            goto label_15;
        }
        
        val_29 = this;
        TzarGames.Endless.EndlessSpawner val_5 = this.$this.Spawner;
        if((val_5.<Paused>k__BackingField) == false)
        {
            goto label_18;
        }
        
        val_27 = 1;
        this.$current = 0;
        if(this.$disposing == true)
        {
                return (bool)val_27;
        }
        
        this.$PC = val_27;
        return (bool)val_27;
        label_9:
        val_35 = this.$this.Spawner;
        if(val_35 == null)
        {
            goto label_22;
        }
        
        val_36 = val_6.waveCount;
        goto label_23;
        label_15:
        val_37 = this.spawingGroup.DelayBetweenObjects;
        this.$current = new UnityEngine.WaitForSeconds(seconds:  val_37);
        if(this.$disposing == true)
        {
            goto label_40;
        }
        
        val_38 = 4;
        goto label_37;
        label_18:
        val_32 = this;
        this.<spawned>__4 = 0;
        label_35:
        TzarGames.Endless.EndlessSpawner val_10 = this.$this.Spawner;
        if(0 != (this.<spawned>__4))
        {
            goto label_30;
        }
        
        TzarGames.GameFramework.TzarBehaviour val_12 = this.<group>__1.ObjectPrefab;
        val_33 = this.<spawnPoints>__2;
        this.<spawned>__4 = val_10;
        if(0 != val_10)
        {
            goto label_35;
        }
        
        this.$current = 0;
        if(this.$disposing == true)
        {
            goto label_40;
        }
        
        val_38 = 2;
        goto label_37;
        label_30:
        val_33 = this.<spawned>__4;
        val_10.handleSpawnedObject(obj:  val_33);
        val_37 = this.<group>__1.SpawnInterval;
        this.$current = new UnityEngine.WaitForSeconds(seconds:  val_37);
        if(this.$disposing == true)
        {
            goto label_40;
        }
        
        val_38 = 3;
        label_37:
        this.$PC = val_38;
        label_40:
        val_27 = 1;
        return (bool)val_27;
        label_22:
        val_35 = 212;
        val_36 = 0;
        label_23:
        mem[212] = 1;
        TzarGames.Endless.EndlessSpawner val_16 = this.$this.Spawner;
        if(val_16.OnWaveFinished != null)
        {
                TzarGames.Endless.EndlessSpawner val_17 = this.$this.Spawner;
            val_17.OnWaveFinished.Invoke(obj:  this.$this.Spawner);
        }
        
        TzarGames.Endless.EndlessSpawner val_19 = this.$this.Spawner;
        if(val_19.infinity == true)
        {
            goto label_50;
        }
        
        if(this.$this.Spawner.SpawnedCount != 0)
        {
                val_22.pendingObjectsDestroy = true;
        }
        else
        {
                this.$this.Spawner.notifyAllObjectsDestroyed();
        }
        
        bool val_24 = this.$this.Spawner.GotoState<EndlessSpawner.Idle>(stateData:  0);
        this.$PC = 0;
        return (bool)val_27;
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

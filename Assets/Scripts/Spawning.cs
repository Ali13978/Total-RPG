using UnityEngine;
private class EndlessSpawner.Spawning : EndlessSpawner.SpawnerStateBase
{
    // Fields
    private bool spawningStarted;
    private UnityEngine.Coroutine spawningCrt;
    
    // Methods
    public EndlessSpawner.Spawning()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_39;
        TzarGames.Endless.SpawnGroup val_40;
        TzarGames.Endless.EndlessSpawner val_1 = this.Spawner;
        val_1.pendingObjectsDestroy = false;
        TzarGames.Endless.EndlessSpawner val_2 = this.Spawner;
        if(0 == val_2.spawnInfo)
        {
            goto label_8;
        }
        
        TzarGames.Endless.EndlessSpawner val_5 = this.Spawner;
        if(val_5.spawnInfo.GroupCount == 0)
        {
            goto label_8;
        }
        
        if(0 == TzarGames.Endless.EndlessGameState.Instance)
        {
            goto label_23;
        }
        
        TzarGames.Endless.ICharacterInfo val_10 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
        var val_34 = 0;
        val_34 = val_34 + 1;
        val_34 = val_10;
        goto label_17;
        label_8:
        string val_12 = this.Spawner.name;
        string val_13 = 0 + "Invalid spawn info data for spawner: "("Invalid spawn info data for spawner: ");
        UnityEngine.Debug.LogError(message:  0);
        this.ForceGotoState<EndlessSpawner.Idle>(stateData:  0);
        return;
        label_17:
        label_23:
        TzarGames.Endless.EndlessSpawner val_15 = this.Spawner;
        System.Collections.Generic.IEnumerable<TzarGames.Endless.SpawnGroup> val_16 = val_15.spawnInfo.Groups;
        System.Collections.Generic.Dictionary<System.Int32, TzarGames.Endless.SpawnGroup> val_17 = new System.Collections.Generic.Dictionary<System.Int32, TzarGames.Endless.SpawnGroup>();
        var val_35 = 0;
        val_35 = val_35 + 1;
        val_35 = val_16;
        goto label_32;
        label_45:
        var val_36 = 0;
        val_36 = val_36 + 1;
        val_36 = val_16;
        if(val_16.MinimumStage <= val_10)
        {
            goto label_39;
        }
        
        label_32:
        var val_37 = 0;
        val_37 = val_37 + 1;
        val_37 = val_16;
        if(((val_16 & 1) & 1) != 0)
        {
            goto label_45;
        }
        
        goto label_70;
        label_39:
        Add(key:  1, value:  val_16);
        goto label_32;
        label_70:
        if(val_16 != null)
        {
                var val_38 = 0;
            val_38 = val_38 + 1;
            val_39 = val_16;
        }
        
        int val_24 = Count;
        val_40 = Item[UnityEngine.Random.Range(min:  0, max:  0)];
        if(val_40 == null)
        {
                string val_27 = 0 + "Failed to get random group with index ";
            UnityEngine.Debug.LogError(message:  0);
            TzarGames.Endless.EndlessSpawner val_28 = this.Spawner;
            val_40 = val_28.spawnInfo.GetGroupAtIndex(index:  0);
        }
        
        this.spawningCrt = this.Owner.StartCoroutine(routine:  this.spawnRoutine(spawingGroup:  val_40));
        TzarGames.Endless.EndlessSpawner val_33 = this.Spawner;
        val_33.onSpawningStarted.Invoke();
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        this.Owner.StopCoroutine(routine:  this.spawningCrt);
        this.spawningCrt = 0;
        if(this.spawningStarted == false)
        {
                return;
        }
        
        this.spawningStarted = false;
        TzarGames.Endless.EndlessSpawner val_2 = this.Spawner;
        this = val_2.onSpawningFinished;
        this.Invoke();
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private System.Collections.IEnumerator spawnRoutine(TzarGames.Endless.SpawnGroup spawingGroup)
    {
        if(null != 0)
        {
                typeof(EndlessSpawner.Spawning.<spawnRoutine>c__Iterator0).__il2cppRuntimeField_10 = spawingGroup;
        }
        else
        {
                mem[16] = spawingGroup;
        }
        
        typeof(EndlessSpawner.Spawning.<spawnRoutine>c__Iterator0).__il2cppRuntimeField_48 = this;
        return (System.Collections.IEnumerator)new System.Object();
    }

}

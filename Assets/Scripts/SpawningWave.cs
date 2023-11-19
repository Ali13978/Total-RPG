using UnityEngine;
private class WaveSpawner.SpawningWave : WaveSpawner.WaveSpawnerBaseState
{
    // Fields
    private TzarGames.GameFramework.Wave currentWave;
    private int currentObjectGroupNumber;
    private TzarGames.GameFramework.ObjectSpawnInfo currentSpawnInfo;
    private int spawnedCount;
    private float spawnTimeCounter;
    private bool waveFinished;
    private TzarGames.GameFramework.TzarBehaviour pendingObjectToSpawn;
    private System.Collections.Generic.List<TzarGames.GameFramework.TzarBehaviour> spawnedObjects;
    private bool pendingWaveStart;
    
    // Methods
    public WaveSpawner.SpawningWave()
    {
        this.spawnedObjects = new System.Collections.Generic.List<TzarGames.GameFramework.TzarBehaviour>();
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        TzarGames.GameFramework.Wave val_2 = this.Spawner.getCurrentWave();
        this.currentWave = val_2;
        if(((val_2 != null) && (val_2.Objects != null)) && (val_2.Objects.Length != 0))
        {
                this.spawnedCount = 0;
            this.currentObjectGroupNumber = 0;
            this.spawnTimeCounter = 0f;
            this.waveFinished = false;
            this.currentSpawnInfo = val_2.Objects[0];
            this.pendingObjectToSpawn = 0;
            this.spawnedObjects.Clear();
            TzarGames.GameFramework.WaveSpawner val_3 = this.Spawner;
            val_3.spawnedObjectsReference = this.spawnedObjects;
            this.pendingWaveStart = true;
            return;
        }
        
        TzarGames.GameFramework.WaveSpawner val_4 = this.Spawner;
        string val_5 = 0 + "Invalid wave ";
        UnityEngine.Debug.LogError(message:  0);
        this = this.Spawner;
        bool val_7 = this.GotoState<Idle>(stateData:  0);
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        goto label_1;
        label_9:
        0 = 1;
        label_1:
        if(0 >= this.spawnedObjects.Count)
        {
                return;
        }
        
        TzarGames.GameFramework.TzarBehaviour val_2 = this.spawnedObjects.Item[1];
        if(0 == val_2)
        {
            goto label_9;
        }
        
        val_2.remove_OnComponentDestroy(value:  new TzarGames.GameFramework.dlgTzarDestroy(object:  this, method:  System.Void WaveSpawner.SpawningWave::OnObjectDestroy(TzarGames.GameFramework.TzarBehaviour destroyingObject)));
        goto label_9;
    }
    public override void Update()
    {
        uint val_10;
        TzarGames.GameFramework.ObjectSpawnInfo val_11;
        TzarGames.GameFramework.ObjectSpawnInfo val_12;
        if(0 != this.pendingObjectToSpawn)
        {
                if((this.TrySpawn(objectToSpawn:  this.pendingObjectToSpawn)) != false)
        {
                this.pendingObjectToSpawn = 0;
        }
        
        }
        
        if(this.currentWave.Enabled != true)
        {
                this.switchToNextWave(withDelay:  false);
        }
        
        if(this.waveFinished == true)
        {
                return;
        }
        
        if(this.pendingWaveStart != false)
        {
                TzarGames.GameFramework.WaveSpawner val_3 = this.Spawner;
            string val_4 = 0 + "Wave started: "("Wave started: ");
            UnityEngine.Debug.Log(message:  0);
            TzarGames.GameFramework.WaveSpawner val_5 = this.Spawner;
            TzarGames.GameFramework.WaveSpawner val_6 = this.Spawner;
            val_10 = val_6.currentWaveNumber;
            val_5.onWaveStarted.Invoke(arg0:  val_10);
            this.pendingWaveStart = false;
        }
        
        float val_7 = UnityEngine.Time.deltaTime;
        val_7 = this.spawnTimeCounter - val_7;
        this.spawnTimeCounter = val_7;
        if(val_7 > 0f)
        {
                return;
        }
        
        val_11 = this.currentSpawnInfo;
        if(this.currentSpawnInfo == null)
        {
                val_11 = this.currentSpawnInfo;
        }
        
        val_10 = this.spawnedCount + 1;
        this.pendingObjectToSpawn = this.currentSpawnInfo.ObjectPrefab;
        this.spawnedCount = val_10;
        if((long)val_10 >= this.currentSpawnInfo.Count)
        {
            goto label_20;
        }
        
        val_12 = this.currentSpawnInfo;
        goto label_21;
        label_20:
        this.spawnedCount = 0;
        int val_8 = this.currentObjectGroupNumber + 1;
        this.currentObjectGroupNumber = val_8;
        val_10 = this.currentWave.Objects;
        if(val_8 >= this.currentWave.Objects.Length)
        {
            goto label_24;
        }
        
        val_10 = this.currentObjectGroupNumber;
        val_12 = this.currentWave.Objects[val_10];
        this.currentSpawnInfo = val_12;
        label_21:
        this.spawnTimeCounter = this.currentWave.Objects[this.currentObjectGroupNumber][0].SpawnInterval;
        return;
        label_24:
        this.waveFinished = true;
    }
    private bool TrySpawn(TzarGames.GameFramework.TzarBehaviour objectToSpawn)
    {
        object val_11;
        TzarGames.GameFramework.SpawnPoint[] val_12;
        var val_13;
        val_11 = this;
        if((this.currentSpawnInfo.ObjectSpawnPoints == null) || (this.currentSpawnInfo.ObjectSpawnPoints.Length < 1))
        {
            goto label_5;
        }
        
        val_12 = this.currentSpawnInfo.ObjectSpawnPoints;
        goto label_21;
        label_5:
        if((this.currentWave.WaveSpawnPoints == null) || (this.currentWave.WaveSpawnPoints.Length < 1))
        {
            goto label_12;
        }
        
        val_12 = this.currentWave.WaveSpawnPoints;
        goto label_21;
        label_12:
        TzarGames.GameFramework.WaveSpawner val_1 = this.Spawner;
        if(val_1.commonSpawnPoints == null)
        {
            goto label_19;
        }
        
        TzarGames.GameFramework.WaveSpawner val_2 = this.Spawner;
        if(val_2.commonSpawnPoints.Length < 1)
        {
            goto label_19;
        }
        
        TzarGames.GameFramework.WaveSpawner val_3 = this.Spawner;
        val_12 = val_3.commonSpawnPoints;
        goto label_21;
        label_19:
        TzarGames.GameFramework.WaveSpawner val_4 = this.Spawner;
        string val_5 = 0 + "No attached spawn points on spawner ";
        UnityEngine.Debug.LogError(message:  0);
        val_12 = 0;
        label_21:
        TzarGames.GameFramework.TzarBehaviour val_7 = this.Spawner.Spawn(objectPrefab:  objectToSpawn, spawnPoints:  val_12);
        if(0 == val_7)
        {
                val_13 = 0;
            return (bool)val_13;
        }
        
        TzarGames.GameFramework.dlgTzarDestroy val_10 = null;
        val_12 = val_10;
        val_10 = new TzarGames.GameFramework.dlgTzarDestroy(object:  this, method:  System.Void WaveSpawner.SpawningWave::OnObjectDestroy(TzarGames.GameFramework.TzarBehaviour destroyingObject));
        val_7.add_OnComponentDestroy(value:  val_12);
        val_11 = this.spawnedObjects;
        val_11.Add(item:  val_7);
        val_13 = 1;
        return (bool)val_13;
    }
    private void OnObjectDestroy(TzarGames.GameFramework.TzarBehaviour destroyingObject)
    {
        destroyingObject.remove_OnComponentDestroy(value:  new TzarGames.GameFramework.dlgTzarDestroy(object:  this, method:  System.Void WaveSpawner.SpawningWave::OnObjectDestroy(TzarGames.GameFramework.TzarBehaviour destroyingObject)));
        bool val_2 = this.spawnedObjects.Remove(item:  destroyingObject);
        if(this.currentWave == null)
        {
                return;
        }
        
        if(this.waveFinished == false)
        {
                return;
        }
        
        if(this.spawnedObjects.Count != 0)
        {
                return;
        }
        
        this.switchToNextWave(withDelay:  true);
    }
    private void switchToNextWave(bool withDelay)
    {
        var val_10;
        uint val_11;
        float val_12;
        this.waveFinished = true;
        val_10 = this.Spawner;
        if(val_10 != null)
        {
                val_11 = val_1.currentWaveNumber;
        }
        else
        {
                val_10 = 192;
            val_11 = 33348528;
        }
        
        mem[192] = 33348529;
        TzarGames.GameFramework.WaveSpawner val_2 = this.Spawner;
        if(val_2.currentWaveNumber >= this.Spawner.getMaxWaveCount())
        {
            goto label_5;
        }
        
        if(withDelay == false)
        {
            goto label_6;
        }
        
        TzarGames.GameFramework.WaveSpawner val_5 = this.Spawner;
        val_12 = val_5.delayBetweenWaves;
        goto label_8;
        label_5:
        bool val_7 = this.Spawner.GotoState<Idle>(stateData:  0);
        return;
        label_6:
        val_12 = 0f;
        label_8:
        bool val_9 = this.Spawner.GotoState<PendingWave>(stateData:  val_12);
    }

}

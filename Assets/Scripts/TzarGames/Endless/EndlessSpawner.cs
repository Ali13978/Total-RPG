using UnityEngine;

namespace TzarGames.Endless
{
    public class EndlessSpawner : Spawner
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.SpawnInfo spawnInfo;
        [UnityEngine.SerializeField]
        private int levelAddition;
        [UnityEngine.SerializeField]
        private float stageLevelMultiplier;
        [UnityEngine.SerializeField]
        private bool incrementLevelByWave;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.SpawnPoint[] commonSpawnPoints;
        [UnityEngine.SerializeField]
        private bool infinity;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onSpawningStarted;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onSpawningFinished;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onAllObjectsDestroyed;
        public System.Action<TzarGames.Endless.EndlessSpawner> OnWaveFinished;
        private bool finishedSpawning;
        private uint waveCount;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <Paused>k__BackingField;
        private bool pendingObjectsDestroy;
        
        // Properties
        public uint WaveCount { get; }
        public bool IsSpawningFinished { get; }
        public bool IsSpawning { get; }
        public TzarGames.GameFramework.SpawnPoint[] CommonSpawnPoints { get; }
        public bool Paused { get; set; }
        public UnityEngine.Events.UnityEvent OnAllObjectsDestroyed { get; }
        
        // Methods
        public EndlessSpawner()
        {
            this.stageLevelMultiplier = 1f;
        }
        public uint get_WaveCount()
        {
            return (uint)this.waveCount;
        }
        public bool get_IsSpawningFinished()
        {
            return (bool)this.finishedSpawning;
        }
        public bool get_IsSpawning()
        {
            var val_3;
            State val_1 = this.CurrentState;
            val_3 = 0;
            return (bool);
        }
        public TzarGames.GameFramework.SpawnPoint[] get_CommonSpawnPoints()
        {
            return (TzarGames.GameFramework.SpawnPoint[])this.commonSpawnPoints;
        }
        public bool get_Paused()
        {
            return (bool)this.<Paused>k__BackingField;
        }
        public void set_Paused(bool value)
        {
            this.<Paused>k__BackingField = value;
        }
        public UnityEngine.Events.UnityEvent get_OnAllObjectsDestroyed()
        {
            return (UnityEngine.Events.UnityEvent)this.onAllObjectsDestroyed;
        }
        public void StartSpawning()
        {
            bool val_1 = this.GotoState<EndlessSpawner.Spawning>(stateData:  0);
        }
        public void StopSpawning()
        {
            bool val_1 = this.GotoState<EndlessSpawner.Idle>(stateData:  0);
        }
        private void handleSpawnedObject(TzarGames.GameFramework.TzarBehaviour obj)
        {
            bool val_2 = UnityEngine.Object.op_Equality(x:  0, y:  obj);
            UnityEngine.Debug.LogError(message:  0);
        }
        private void OnDisable()
        {
            this.StopSpawning();
        }
        private void notifyAllObjectsDestroyed()
        {
            this.finishedSpawning = true;
            this.onAllObjectsDestroyed.Invoke();
        }
        protected override void onObjectDestroy(TzarGames.GameFramework.TzarBehaviour obj)
        {
            this.onObjectDestroy(obj:  obj);
            if(this.SpawnedCount != 0)
            {
                    return;
            }
            
            if(this.pendingObjectsDestroy == false)
            {
                    return;
            }
            
            this.pendingObjectsDestroy = false;
            this.notifyAllObjectsDestroyed();
        }
    
    }

}

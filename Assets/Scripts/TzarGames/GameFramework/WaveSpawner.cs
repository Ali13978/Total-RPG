using UnityEngine;

namespace TzarGames.GameFramework
{
    public class WaveSpawner : Spawner
    {
        // Fields
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private bool runOnStart;
        [UnityEngine.SerializeField]
        private float delayToStart;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Wave[] initialWaves;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Wave[] loopWaves;
        [UnityEngine.SerializeField]
        private uint loopCount;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private float delayBetweenWaves;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.SpawnPoint[] commonSpawnPoints;
        [UnityEngine.SerializeField]
        private TzarGames.Common.Events.UnsignedIntEvent onWaveStarted;
        private System.Collections.Generic.List<TzarGames.GameFramework.TzarBehaviour> spawnedObjectsReference;
        private uint currentWaveNumber;
        
        // Properties
        public bool IsRunning { get; }
        public TzarGames.Common.Events.UnsignedIntEvent OnWaveStarted { get; }
        public uint CurrentWaveNumber { get; }
        
        // Methods
        public WaveSpawner()
        {
            this.runOnStart = true;
            this.delayToStart = 5f;
            this.loopCount = 5;
            this.delayBetweenWaves = 5f;
        }
        public bool get_IsRunning()
        {
            var val_4;
            State val_1 = this.CurrentState;
            val_4 = 1;
            return (bool);
        }
        public TzarGames.Common.Events.UnsignedIntEvent get_OnWaveStarted()
        {
            return (TzarGames.Common.Events.UnsignedIntEvent)this.onWaveStarted;
        }
        public uint get_CurrentWaveNumber()
        {
            return (uint)this.currentWaveNumber;
        }
        private TzarGames.GameFramework.Wave getCurrentWave()
        {
            uint val_4;
            TzarGames.GameFramework.Wave[] val_5;
            val_4 = this;
            val_5 = this.initialWaves;
            if(this.currentWaveNumber < this.initialWaves.Length)
            {
                    val_4 = this.currentWaveNumber;
            }
            else
            {
                    val_5 = this.currentWaveNumber;
                if(val_5 == this.initialWaves.Length)
            {
                    return (TzarGames.GameFramework.Wave)null;
            }
            
                val_4 = this.loopWaves;
                uint val_1 = val_5 - this.initialWaves.Length;
            }
            
            return (TzarGames.GameFramework.Wave)null;
        }
        private uint getMaxWaveCount()
        {
            var val_2;
            if(this.loopCount != 0)
            {
                    val_2 = this.initialWaves.Length + (this.loopWaves.Length * this.loopCount);
                return (uint)val_2;
            }
            
            val_2 = 2147483647;
            return (uint)val_2;
        }
        public void RestartWaves()
        {
            this.currentWaveNumber = 0;
            bool val_1 = this.GotoState<PendingWave>(stateData:  this.delayToStart);
        }
        public void Stop()
        {
            bool val_1 = this.GotoState<Idle>(stateData:  0);
        }
        public void StopAndDestroyAllSpawnedObjects()
        {
            System.Collections.Generic.List<TzarGames.GameFramework.TzarBehaviour> val_6;
            var val_7;
            this.Stop();
            val_6 = this.spawnedObjectsReference;
            if(val_6 == null)
            {
                    return;
            }
            
            val_7 = 0;
            goto label_2;
            label_12:
            val_6 = this.spawnedObjectsReference;
            val_7 = 1;
            label_2:
            if(val_7 >= val_6.Count)
            {
                    return;
            }
            
            TzarGames.GameFramework.TzarBehaviour val_2 = this.spawnedObjectsReference.Item[1];
            if(0 == val_2)
            {
                goto label_12;
            }
            
            UnityEngine.GameObject val_5 = val_2.gameObject;
            UnityEngine.Object.Destroy(obj:  0);
            goto label_12;
        }
        private void Start()
        {
            if(this.runOnStart == false)
            {
                    return;
            }
            
            this.RestartWaves();
        }
        private void Update()
        {
            if(this.CurrentState == null)
            {
                
            }
        
        }
    
    }

}

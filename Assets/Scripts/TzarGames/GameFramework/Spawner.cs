using UnityEngine;

namespace TzarGames.GameFramework
{
    public class Spawner : TzarBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.SpawnerMode spawnMode;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.TzarBehaviourEvent onObjectSpawned;
        [UnityEngine.SerializeField]
        protected TzarGames.GameFramework.TzarBehaviourEvent onObjectDestroyed;
        private System.Collections.Generic.List<TzarGames.GameFramework.TzarBehaviour> spawnedObjects;
        private System.Collections.Generic.Dictionary<object, TzarGames.Common.PrimeSearch> pseudoRandomSets;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static int <GlobalSpawnedCount>k__BackingField;
        
        // Properties
        public static int GlobalSpawnedCount { get; set; }
        public TzarGames.GameFramework.TzarBehaviourEvent OnObjectSpawned { get; }
        public int SpawnedCount { get; }
        
        // Methods
        public Spawner()
        {
            this.spawnedObjects = new System.Collections.Generic.List<TzarGames.GameFramework.TzarBehaviour>();
            this.pseudoRandomSets = new System.Collections.Generic.Dictionary<System.Object, TzarGames.Common.PrimeSearch>();
        }
        public static int get_GlobalSpawnedCount()
        {
            return (int)TzarGames.GameFramework.Spawner.<GlobalSpawnedCount>k__BackingField;
        }
        private static void set_GlobalSpawnedCount(int value)
        {
            TzarGames.GameFramework.Spawner.<GlobalSpawnedCount>k__BackingField = W1;
        }
        public TzarGames.GameFramework.TzarBehaviourEvent get_OnObjectSpawned()
        {
            return (TzarGames.GameFramework.TzarBehaviourEvent)this.onObjectSpawned;
        }
        public int get_SpawnedCount()
        {
            if(this.spawnedObjects != null)
            {
                    return this.spawnedObjects.Count;
            }
            
            return this.spawnedObjects.Count;
        }
        public TzarGames.GameFramework.TzarBehaviour GetSpawnedObject(int objectNum)
        {
            var val_3;
            if(this.spawnedObjects.Count > objectNum)
            {
                    TzarGames.GameFramework.TzarBehaviour val_2 = this.spawnedObjects.Item[objectNum];
                return (TzarGames.GameFramework.TzarBehaviour)val_3;
            }
            
            UnityEngine.Debug.LogError(message:  0);
            val_3 = 0;
            return (TzarGames.GameFramework.TzarBehaviour)val_3;
        }
        protected virtual TzarGames.GameFramework.TzarBehaviour Spawn(TzarGames.GameFramework.TzarBehaviour objectPrefab, TzarGames.GameFramework.SpawnPoint[] spawnPoints)
        {
            object val_24;
            TzarGames.GameFramework.SpawnPoint val_25;
            var val_26;
            var val_27;
            int val_28;
            var val_29;
            TzarGames.GameFramework.TzarBehaviour val_30;
            val_24 = this;
            if(this.spawnMode == 1)
            {
                goto label_1;
            }
            
            val_25 = 0;
            if(this.spawnMode != 0)
            {
                goto label_33;
            }
            
            if((this.pseudoRandomSets.TryGetValue(key:  spawnPoints, value: out  0)) == false)
            {
                goto label_4;
            }
            
            goto label_5;
            label_1:
            System.Collections.Generic.List<TzarGames.GameFramework.SpawnPoint> val_3 = new System.Collections.Generic.List<TzarGames.GameFramework.SpawnPoint>(collection:  spawnPoints);
            val_27 = 1152921511438577664;
            val_28 = Count - 1;
            goto label_7;
            label_13:
            val_28 = val_28 - 1;
            label_7:
            if((val_28 & 2147483648) != 0)
            {
                goto label_9;
            }
            
            if(Item[val_28].isFree() == true)
            {
                goto label_13;
            }
            
            RemoveAt(index:  val_28);
            goto label_13;
            label_9:
            if(Count < 1)
            {
                goto label_21;
            }
            
            int val_8 = Count;
            val_25 = Item[UnityEngine.Random.Range(min:  0, max:  0)];
            goto label_33;
            label_4:
            TzarGames.Common.PrimeSearch val_11 = null;
            val_26 = spawnPoints;
            val_11 = new TzarGames.Common.PrimeSearch(elements:  spawnPoints.Length);
            this.pseudoRandomSets.Add(key:  spawnPoints, value:  val_11);
            label_5:
            val_27 = 1152921504721543168;
            var val_23 = 0;
            label_32:
            val_23 = val_23 + 1;
            if(val_23 >= (spawnPoints + 24))
            {
                goto label_21;
            }
            
            if(Done() != false)
            {
                    Restart();
            }
            
            val_25 = spawnPoints[(long)GetNext(restart:  false)];
            if((0 == val_25) || (val_25.isFree() == false))
            {
                goto label_32;
            }
            
            goto label_33;
            label_21:
            val_25 = 0;
            label_33:
            val_29 = 1152921504721543168;
            val_30 = 0;
            if(0 == val_25)
            {
                    return val_30;
            }
            
            UnityEngine.Vector3 val_18 = val_25.Position;
            UnityEngine.Quaternion val_19 = val_25.Rotation;
            val_30 = UnityEngine.Object.Instantiate<TzarGames.GameFramework.TzarBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, rotation:  new UnityEngine.Quaternion() {x = val_19.x, y = val_19.y, z = val_19.z, w = val_19.w});
            val_30.add_OnComponentDestroy(value:  new TzarGames.GameFramework.dlgTzarDestroy(object:  this, method:  System.Void TzarGames.GameFramework.Spawner::onObjectDestroy_internal(TzarGames.GameFramework.TzarBehaviour obj)));
            this.spawnedObjects.Add(item:  val_30);
            TzarGames.GameFramework.Spawner.<GlobalSpawnedCount>k__BackingField = (TzarGames.GameFramework.Spawner.<GlobalSpawnedCount>k__BackingField) + 1;
            val_24 = this.onObjectSpawned;
            val_24.Invoke(arg0:  val_30);
            return val_30;
        }
        protected virtual void onObjectDestroy(TzarGames.GameFramework.TzarBehaviour obj)
        {
        
        }
        private void onObjectDestroy_internal(TzarGames.GameFramework.TzarBehaviour obj)
        {
            obj.remove_OnComponentDestroy(value:  new TzarGames.GameFramework.dlgTzarDestroy(object:  this, method:  System.Void TzarGames.GameFramework.Spawner::onObjectDestroy_internal(TzarGames.GameFramework.TzarBehaviour obj)));
            bool val_2 = this.spawnedObjects.Remove(item:  obj);
            TzarGames.GameFramework.Spawner.<GlobalSpawnedCount>k__BackingField = (TzarGames.GameFramework.Spawner.<GlobalSpawnedCount>k__BackingField) - 1;
            this.onObjectDestroyed.Invoke(arg0:  obj);
        }
        protected override void OnDestroy()
        {
            var val_5;
            var val_6;
            this.OnDestroy();
            List.Enumerator<T> val_1 = this.spawnedObjects.GetEnumerator();
            label_7:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_2 = 0.InitializationCallback;
            if(0 == val_2)
            {
                goto label_7;
            }
            
            TzarGames.GameFramework.dlgTzarDestroy val_4 = new TzarGames.GameFramework.dlgTzarDestroy(object:  this, method:  System.Void TzarGames.GameFramework.Spawner::onObjectDestroy_internal(TzarGames.GameFramework.TzarBehaviour obj));
            val_2.remove_OnComponentDestroy(value:  null);
            goto label_7;
            label_2:
            val_5 = 0;
            val_6 = 1;
            0.Dispose();
            if((val_6 & 1) != 0)
            {
                    return;
            }
            
            if(val_5 == 0)
            {
                    return;
            }
        
        }
    
    }

}

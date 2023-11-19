using UnityEngine;

namespace TzarGames.Endless.Skills
{
    public class SpawnerSkill : EndlessCharacterSkill
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.TH_Character[] spawnList;
        [UnityEngine.SerializeField]
        private int maxSpawnCount;
        [UnityEngine.SerializeField]
        private float maxDistance;
        [UnityEngine.SerializeField]
        private bool needsPath;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject spawnEffect;
        private UnityEngine.Coroutine spawnCoroutine;
        private TzarGames.GameFramework.IPathResult lastPathResult;
        private bool prevNoRandomAttemptFailed;
        private static System.Collections.Generic.List<TzarGames.GameFramework.TzarBehaviour> spawned;
        private static TzarGames.GameFramework.dlgTzarDestroy <>f__mg$cache0;
        private static TzarGames.GameFramework.dlgTzarDestroy <>f__mg$cache1;
        private static TzarGames.GameFramework.dlgTzarDestroy <>f__mg$cache2;
        
        // Methods
        public SpawnerSkill()
        {
            this.maxSpawnCount = 10;
            this.maxDistance = 6f;
            this.needsPath = true;
        }
        public override bool Validate()
        {
            null = null;
            if((TzarGames.GameFramework.Spawner.GlobalSpawnedCount + TzarGames.Endless.Skills.SpawnerSkill.spawned.Count) >= this.maxSpawnCount)
            {
                    return false;
            }
            
            if(0 != this.Character.Pathfinder)
            {
                    return this.Validate();
            }
            
            return false;
        }
        protected override void OnStarted()
        {
            this.OnStarted();
            this.spawnCoroutine = this.Character.StartCoroutine(routine:  this.teleportingProcess());
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator teleportingProcess()
        {
            typeof(SpawnerSkill.<teleportingProcess>c__Iterator0).__il2cppRuntimeField_A8 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private bool canContinue()
        {
            return this.IsPerforming;
        }
        protected override void OnStopped()
        {
            this.OnStopped();
            if(this.spawnCoroutine == null)
            {
                    return;
            }
            
            this.Character.StopCoroutine(routine:  this.spawnCoroutine);
            this.spawnCoroutine = 0;
        }
        private void spawn(UnityEngine.Vector3 targetPosition)
        {
            float val_27;
            var val_29;
            var val_30;
            if(0 != this.Character.Target)
            {
                    val_27 = targetPosition.z;
                UnityEngine.Vector3 val_6 = this.Character.Target.Position;
                UnityEngine.Vector3 val_8 = this.Character.Position;
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.up;
                UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, upwards:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            }
            else
            {
                    val_27 = targetPosition.z;
                UnityEngine.Quaternion val_12 = UnityEngine.Quaternion.identity;
            }
            
            UnityEngine.Vector3 val_14 = this.spawnList[(long)UnityEngine.Random.Range(min:  0, max:  0)].GetGroundPivotDisplacement();
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = targetPosition.x, y = targetPosition.y, z = val_27}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            TzarGames.GameFramework.TzarBehaviour val_16 = UnityEngine.Object.Instantiate<TzarGames.GameFramework.TzarBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, rotation:  new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w});
            if(0 == (val_16.GetComponent<TzarGames.Endless.EndlessEnemyAI>()))
            {
                    TzarGames.Endless.EndlessEnemyAI val_20 = val_16.gameObject.AddComponent<TzarGames.Endless.EndlessEnemyAI>();
            }
            
            val_29 = null;
            val_29 = null;
            if((TzarGames.Endless.Skills.SpawnerSkill.<>f__mg$cache0) == null)
            {
                    val_30 = null;
                val_30 = null;
                TzarGames.Endless.Skills.SpawnerSkill.<>f__mg$cache0 = new TzarGames.GameFramework.dlgTzarDestroy(object:  0, method:  static System.Void TzarGames.Endless.Skills.SpawnerSkill::SpawnedCharacter_OnComponentDestroy(TzarGames.GameFramework.TzarBehaviour behaviour));
                val_29 = null;
            }
            
            val_29 = null;
            val_16.add_OnComponentDestroy(value:  TzarGames.Endless.Skills.SpawnerSkill.<>f__mg$cache0);
            val_16.Level = this.Character.Level;
            TzarGames.Endless.Skills.SpawnerSkill.spawned.Add(item:  val_16);
            if(0 == this.spawnEffect)
            {
                    return;
            }
            
            UnityEngine.Quaternion val_25 = UnityEngine.Quaternion.identity;
            TzarGames.GameFramework.TzarBehaviour val_26 = UnityEngine.Object.Instantiate<TzarGames.GameFramework.TzarBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, rotation:  new UnityEngine.Quaternion() {x = val_25.x, y = val_25.y, z = val_25.z, w = val_25.w});
        }
        private static void SpawnedCharacter_OnComponentDestroy(TzarGames.GameFramework.TzarBehaviour behaviour)
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if((TzarGames.Endless.Skills.SpawnerSkill.<>f__mg$cache1) == null)
            {
                    val_4 = null;
                val_4 = null;
                TzarGames.Endless.Skills.SpawnerSkill.<>f__mg$cache1 = new TzarGames.GameFramework.dlgTzarDestroy(object:  0, method:  static System.Void TzarGames.Endless.Skills.SpawnerSkill::SpawnedCharacter_OnComponentDestroy(TzarGames.GameFramework.TzarBehaviour behaviour));
                val_3 = null;
            }
            
            val_3 = null;
            X1.remove_OnComponentDestroy(value:  TzarGames.Endless.Skills.SpawnerSkill.<>f__mg$cache1);
            bool val_2 = TzarGames.Endless.Skills.SpawnerSkill.spawned.Remove(item:  X1);
        }
        private void OnDestroy()
        {
            var val_3;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            val_8 = null;
            val_8 = null;
            List.Enumerator<T> val_1 = TzarGames.Endless.Skills.SpawnerSkill.spawned.GetEnumerator();
            label_16:
            if((0 & 1) == 0)
            {
                goto label_7;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_4 = val_3.InitializationCallback;
            if(0 == val_4)
            {
                goto label_7;
            }
            
            val_9 = null;
            val_9 = null;
            if((TzarGames.Endless.Skills.SpawnerSkill.<>f__mg$cache2) == null)
            {
                    TzarGames.GameFramework.dlgTzarDestroy val_7 = new TzarGames.GameFramework.dlgTzarDestroy(object:  0, method:  static System.Void TzarGames.Endless.Skills.SpawnerSkill::SpawnedCharacter_OnComponentDestroy(TzarGames.GameFramework.TzarBehaviour behaviour));
                val_10 = null;
                val_10 = null;
                TzarGames.Endless.Skills.SpawnerSkill.<>f__mg$cache2 = null;
                val_9 = null;
            }
            
            val_9 = null;
            val_4.remove_OnComponentDestroy(value:  TzarGames.Endless.Skills.SpawnerSkill.<>f__mg$cache2);
            goto label_16;
            label_7:
            val_11 = 0;
            val_12 = 1;
            val_3.Dispose();
            if((val_12 & 1) != 0)
            {
                    return;
            }
            
            if(val_11 == 0)
            {
                    return;
            }
        
        }
        private void pathCalculationCallback(TzarGames.GameFramework.IPathResult result)
        {
            if(this.IsPerforming == false)
            {
                    return;
            }
            
            this.lastPathResult = result;
        }
        private static SpawnerSkill()
        {
            TzarGames.Endless.Skills.SpawnerSkill.spawned = new System.Collections.Generic.List<TzarGames.GameFramework.TzarBehaviour>();
        }
    
    }

}

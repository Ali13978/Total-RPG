using UnityEngine;

namespace TzarGames.TzarHero
{
    public class CharacterLootSpawner : TzarBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.TH_Character character;
        [UnityEngine.SerializeField]
        private UnityEngine.Transform spawnPosition;
        [UnityEngine.SerializeField]
        private float spawnDelay;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onSpawnStarted;
        private static System.Comparison<TzarGames.GameFramework.Loot> <>f__mg$cache0;
        
        // Methods
        public CharacterLootSpawner()
        {
        
        }
        private void Reset()
        {
            this.character = this.GetComponent<TzarGames.TzarHero.TH_Character>();
        }
        public void SpawnLoot()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.spawnLoot());
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator spawnLoot()
        {
            typeof(CharacterLootSpawner.<spawnLoot>c__Iterator0).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}

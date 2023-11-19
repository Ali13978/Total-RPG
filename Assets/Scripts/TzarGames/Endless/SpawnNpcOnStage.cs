using UnityEngine;

namespace TzarGames.Endless
{
    public class SpawnNpcOnStage : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.TH_Character characterPrefab;
        [UnityEngine.SerializeField]
        private int stage;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.EndlessStageGameManager gameManager;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onSpawned;
        
        // Methods
        public SpawnNpcOnStage()
        {
            this.stage = 1;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator Start()
        {
            typeof(SpawnNpcOnStage.<Start>c__Iterator0).__il2cppRuntimeField_48 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}

using UnityEngine;

namespace TzarGames.Endless.Quests
{
    public class BringItemQuestBehaviour : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onQuestStarted;
        [UnityEngine.SerializeField]
        private UnityEngine.Transform[] itemSpawnPoints;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onItemFound;
        private TzarGames.Endless.UI.NotificationBehaviour _notificationBehaviour;
        private TzarGames.Endless.ObjectDistanceIndicator _indicator;
        private TzarGames.Endless.UI.DistanceIndicatorUI _indicatorUI;
        
        // Methods
        public BringItemQuestBehaviour()
        {
        
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator Start()
        {
            typeof(BringItemQuestBehaviour.<Start>c__Iterator0).__il2cppRuntimeField_40 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}

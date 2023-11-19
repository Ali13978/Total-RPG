using UnityEngine;

namespace TzarGames.Endless.Quests
{
    public class PortalPrefabBehaviour : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Transform playerSpawnPosition;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onActivated;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onDeactivated;
        
        // Properties
        public UnityEngine.Transform PortalSpawnPosition { get; }
        
        // Methods
        public PortalPrefabBehaviour()
        {
        
        }
        public UnityEngine.Transform get_PortalSpawnPosition()
        {
            return (UnityEngine.Transform)this.playerSpawnPosition;
        }
        public void Activate()
        {
            this.onActivated.Invoke();
        }
        public void Deactivate()
        {
            this.onDeactivated.Invoke();
        }
    
    }

}

using UnityEngine;

namespace TzarGames.Endless
{
    public class PortalBehaviour : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.Quests.PortalPrefabBehaviour portal;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject enemySpawnTrigger;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject newWorldPortal;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject[] crystals;
        
        // Properties
        public UnityEngine.GameObject EnemySpawnTrigger { get; }
        public UnityEngine.GameObject NewWorldPortal { get; }
        public TzarGames.Endless.Quests.PortalPrefabBehaviour Portal { get; }
        
        // Methods
        public PortalBehaviour()
        {
        
        }
        public UnityEngine.GameObject get_EnemySpawnTrigger()
        {
            return (UnityEngine.GameObject)this.enemySpawnTrigger;
        }
        public UnityEngine.GameObject get_NewWorldPortal()
        {
            return (UnityEngine.GameObject)this.newWorldPortal;
        }
        public TzarGames.Endless.Quests.PortalPrefabBehaviour get_Portal()
        {
            return (TzarGames.Endless.Quests.PortalPrefabBehaviour)this.portal;
        }
        public void SetCrystalState(bool enable)
        {
            goto label_0;
            label_5:
            X20.SetActive(value:  enable);
            0 = 1;
            label_0:
            if(0 >= this.crystals.Length)
            {
                    return;
            }
            
            if(this.crystals[1] != null)
            {
                goto label_5;
            }
            
            goto label_5;
        }
        [UnityEngine.ContextMenu]
        private void SetupPortals()
        {
            this.portal = this.GetComponentInChildren<TzarGames.Endless.Quests.PortalPrefabBehaviour>();
        }
    
    }

}

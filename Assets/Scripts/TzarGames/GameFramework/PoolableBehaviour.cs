using UnityEngine;

namespace TzarGames.GameFramework
{
    public class PoolableBehaviour : MonoBehaviour, IPoolable
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onPulledFromPool;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onPushedToPool;
        
        // Methods
        public PoolableBehaviour()
        {
        
        }
        public void OnPulledFromPool()
        {
            this.onPulledFromPool.Invoke();
        }
        public void OnPushedToPool()
        {
            this.onPushedToPool.Invoke();
        }
    
    }

}

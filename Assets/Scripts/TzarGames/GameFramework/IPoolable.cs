using UnityEngine;

namespace TzarGames.GameFramework
{
    public interface IPoolable
    {
        // Methods
        public abstract void OnPushedToPool(); // 0
        public abstract void OnPulledFromPool(); // 0
    
    }

}

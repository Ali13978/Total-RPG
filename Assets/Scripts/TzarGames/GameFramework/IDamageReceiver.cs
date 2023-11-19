using UnityEngine;

namespace TzarGames.GameFramework
{
    public interface IDamageReceiver
    {
        // Methods
        public abstract void TakeDamage(TzarGames.GameFramework.IDamageInfo damageInfo); // 0
        public abstract TzarGames.GameFramework.ISurfaceType GetSurfaceType(); // 0
    
    }

}

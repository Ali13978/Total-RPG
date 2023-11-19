using UnityEngine;

namespace TzarGames.GameFramework
{
    public interface IDamageHit
    {
        // Properties
        public abstract TzarGames.GameFramework.IDamageInfo DamageInfo { get; }
        public abstract TzarGames.GameFramework.ISurfaceType HitSurfaceType { get; }
        
        // Methods
        public abstract TzarGames.GameFramework.IDamageInfo get_DamageInfo(); // 0
        public abstract TzarGames.GameFramework.ISurfaceType get_HitSurfaceType(); // 0
    
    }

}

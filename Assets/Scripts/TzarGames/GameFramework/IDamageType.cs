using UnityEngine;

namespace TzarGames.GameFramework
{
    public interface IDamageType
    {
        // Properties
        public abstract TzarGames.GameFramework.ISurfaceType SurfaceType { get; }
        
        // Methods
        public abstract TzarGames.GameFramework.ISurfaceType get_SurfaceType(); // 0
    
    }

}

using UnityEngine;

namespace TzarGames.GameFramework
{
    public interface IHit
    {
        // Properties
        public abstract UnityEngine.Vector3 Point { get; }
        public abstract UnityEngine.Vector3 Normal { get; }
        public abstract UnityEngine.Collider Collider { get; }
        public abstract UnityEngine.Rigidbody Rigidbody { get; }
        public abstract TzarGames.GameFramework.ISurfaceType SurfaceType { get; }
        
        // Methods
        public abstract UnityEngine.Vector3 get_Point(); // 0
        public abstract UnityEngine.Vector3 get_Normal(); // 0
        public abstract UnityEngine.Collider get_Collider(); // 0
        public abstract UnityEngine.Rigidbody get_Rigidbody(); // 0
        public abstract TzarGames.GameFramework.ISurfaceType get_SurfaceType(); // 0
    
    }

}

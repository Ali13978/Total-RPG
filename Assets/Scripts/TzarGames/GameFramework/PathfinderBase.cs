using UnityEngine;

namespace TzarGames.GameFramework
{
    public abstract class PathfinderBase : MonoBehaviour
    {
        // Methods
        protected PathfinderBase()
        {
        
        }
        public abstract void Initialize(float actorHeight, float actorRadius); // 0
        public abstract bool CalculatePath(UnityEngine.Vector3 sourcePosition, UnityEngine.Vector3 targetPosition, UnityEngine.Events.UnityAction<TzarGames.GameFramework.IPathResult> pathResultCallback); // 0
        public abstract bool GetNearestPosition(UnityEngine.Vector3 position, out UnityEngine.Vector3 result); // 0
        public abstract void Activate(); // 0
        public abstract void Deactivate(); // 0
        public abstract void OnStartMovement(); // 0
        public abstract void OnStopMovement(); // 0
        public abstract bool HasObstacleBetweenPoints(UnityEngine.Vector3 sourcePosition, UnityEngine.Vector3 targetPosition); // 0
    
    }

}

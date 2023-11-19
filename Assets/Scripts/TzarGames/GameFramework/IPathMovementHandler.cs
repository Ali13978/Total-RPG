using UnityEngine;

namespace TzarGames.GameFramework
{
    public interface IPathMovementHandler
    {
        // Methods
        public abstract void MoveToPosition(UnityEngine.Vector3 position, System.Action<TzarGames.GameFramework.IPathResult> onPathCalculationComplete); // 0
    
    }

}

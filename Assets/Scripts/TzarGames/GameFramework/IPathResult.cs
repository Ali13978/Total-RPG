using UnityEngine;

namespace TzarGames.GameFramework
{
    public interface IPathResult
    {
        // Properties
        public abstract bool Success { get; }
        public abstract TzarGames.GameFramework.PathResultType ResultType { get; }
        public abstract int CornerCount { get; }
        
        // Methods
        public abstract bool get_Success(); // 0
        public abstract TzarGames.GameFramework.PathResultType get_ResultType(); // 0
        public abstract UnityEngine.Vector3 GetCornerAtIndex(int index); // 0
        public abstract int get_CornerCount(); // 0
    
    }

}

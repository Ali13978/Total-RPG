using UnityEngine;

namespace TzarGames.GameFramework
{
    public interface IObjectActionResult
    {
        // Properties
        public abstract bool Success { get; }
        public abstract string Message { get; }
        
        // Methods
        public abstract bool get_Success(); // 0
        public abstract string get_Message(); // 0
    
    }

}

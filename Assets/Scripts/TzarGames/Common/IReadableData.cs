using UnityEngine;

namespace TzarGames.Common
{
    public interface IReadableData
    {
        // Methods
        public abstract string GetString(string key); // 0
        public abstract float GetFloat(string key); // 0
        public abstract bool HasString(string key); // 0
        public abstract bool HasFloat(string key); // 0
    
    }

}

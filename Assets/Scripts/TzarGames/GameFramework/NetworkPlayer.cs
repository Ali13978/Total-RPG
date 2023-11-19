using UnityEngine;

namespace TzarGames.GameFramework
{
    public abstract class NetworkPlayer
    {
        // Properties
        public abstract int ID { get; }
        public abstract bool ItsMe { get; }
        public abstract bool IsConnected { get; }
        
        // Methods
        protected NetworkPlayer()
        {
        
        }
        public abstract int get_ID(); // 0
        public abstract bool get_ItsMe(); // 0
        public abstract bool get_IsConnected(); // 0
    
    }

}

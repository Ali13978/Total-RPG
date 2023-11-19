using UnityEngine;

namespace TzarGames.GameFramework
{
    public interface INetworkMessageInfo
    {
        // Properties
        public abstract TzarGames.GameFramework.NetworkPlayer Sender { get; }
        public abstract double Timestamp { get; }
        
        // Methods
        public abstract TzarGames.GameFramework.NetworkPlayer get_Sender(); // 0
        public abstract double get_Timestamp(); // 0
    
    }

}

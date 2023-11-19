using UnityEngine;

namespace TzarGames.GameFramework
{
    public interface INetInfoProvider
    {
        // Properties
        public abstract bool isServer { get; }
        public abstract bool isClient { get; }
        public abstract bool Connected { get; }
        public abstract bool Connecting { get; }
        public abstract bool Disconnecting { get; }
        public abstract double NetworkTime { get; }
        
        // Methods
        public abstract int GetLastPing(TzarGames.GameFramework.NetworkPlayer player); // 0
        public abstract int GetAveragePing(TzarGames.GameFramework.NetworkPlayer player); // 0
        public abstract bool get_isServer(); // 0
        public abstract bool get_isClient(); // 0
        public abstract bool get_Connected(); // 0
        public abstract bool get_Connecting(); // 0
        public abstract bool get_Disconnecting(); // 0
        public abstract double get_NetworkTime(); // 0
    
    }

}

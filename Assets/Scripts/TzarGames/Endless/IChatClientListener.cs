using UnityEngine;

namespace TzarGames.Endless
{
    internal interface IChatClientListener
    {
        // Methods
        public abstract void OnConnected(); // 0
        public abstract void OnDisconnected(); // 0
        public abstract void OnGetMessages(string channelName, string[] senders, object[] messages); // 0
    
    }

}

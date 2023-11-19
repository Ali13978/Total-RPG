using UnityEngine;

namespace ExitGames.Client.Photon.Chat
{
    public interface IChatClientListener
    {
        // Methods
        public abstract void DebugReturn(ExitGames.Client.Photon.DebugLevel level, string message); // 0
        public abstract void OnDisconnected(); // 0
        public abstract void OnConnected(); // 0
        public abstract void OnChatStateChange(ExitGames.Client.Photon.Chat.ChatState state); // 0
        public abstract void OnGetMessages(string channelName, string[] senders, object[] messages); // 0
        public abstract void OnPrivateMessage(string sender, object message, string channelName); // 0
        public abstract void OnSubscribed(string[] channels, bool[] results); // 0
        public abstract void OnUnsubscribed(string[] channels); // 0
        public abstract void OnStatusUpdate(string user, int status, bool gotMessage, object message); // 0
    
    }

}

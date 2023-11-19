using UnityEngine;

namespace TzarGames.Endless
{
    internal interface IChatProvider
    {
        // Properties
        public abstract string ActiveChannel { get; set; }
        public abstract string UserID { get; }
        
        // Methods
        public abstract string get_ActiveChannel(); // 0
        public abstract void set_ActiveChannel(string value); // 0
        public abstract void SubscribeToChannels(string[] channels); // 0
        public abstract void SendMessageToChannel(string channel, string message); // 0
        public abstract void Connect(string userId); // 0
        public abstract void Disconnect(); // 0
        public abstract TzarGames.Endless.TzarChatState GetState(); // 0
        public abstract void UpdateState(); // 0
        public abstract void AddListener(TzarGames.Endless.IChatClientListener listener); // 0
        public abstract void RemoveListener(TzarGames.Endless.IChatClientListener listener); // 0
        public abstract string get_UserID(); // 0
    
    }

}

using UnityEngine;

namespace GooglePlayGames.BasicApi.Multiplayer
{
    public interface RealTimeMultiplayerListener
    {
        // Methods
        public abstract void OnRoomSetupProgress(float percent); // 0
        public abstract void OnRoomConnected(bool success); // 0
        public abstract void OnLeftRoom(); // 0
        public abstract void OnParticipantLeft(GooglePlayGames.BasicApi.Multiplayer.Participant participant); // 0
        public abstract void OnPeersConnected(string[] participantIds); // 0
        public abstract void OnPeersDisconnected(string[] participantIds); // 0
        public abstract void OnRealTimeMessageReceived(bool isReliable, string senderId, byte[] data); // 0
    
    }

}

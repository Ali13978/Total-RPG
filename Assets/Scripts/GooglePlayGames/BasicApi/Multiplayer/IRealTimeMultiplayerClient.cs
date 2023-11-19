using UnityEngine;

namespace GooglePlayGames.BasicApi.Multiplayer
{
    public interface IRealTimeMultiplayerClient
    {
        // Methods
        public abstract void CreateQuickGame(uint minOpponents, uint maxOpponents, uint variant, GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener listener); // 0
        public abstract void CreateQuickGame(uint minOpponents, uint maxOpponents, uint variant, ulong exclusiveBitMask, GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener listener); // 0
        public abstract void CreateWithInvitationScreen(uint minOpponents, uint maxOppponents, uint variant, GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener listener); // 0
        public abstract void ShowWaitingRoomUI(); // 0
        public abstract void GetAllInvitations(System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation[]> callback); // 0
        public abstract void AcceptFromInbox(GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener listener); // 0
        public abstract void AcceptInvitation(string invitationId, GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener listener); // 0
        public abstract void SendMessageToAll(bool reliable, byte[] data); // 0
        public abstract void SendMessageToAll(bool reliable, byte[] data, int offset, int length); // 0
        public abstract void SendMessage(bool reliable, string participantId, byte[] data); // 0
        public abstract void SendMessage(bool reliable, string participantId, byte[] data, int offset, int length); // 0
        public abstract System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant> GetConnectedParticipants(); // 0
        public abstract GooglePlayGames.BasicApi.Multiplayer.Participant GetSelf(); // 0
        public abstract GooglePlayGames.BasicApi.Multiplayer.Participant GetParticipant(string participantId); // 0
        public abstract GooglePlayGames.BasicApi.Multiplayer.Invitation GetInvitation(); // 0
        public abstract void LeaveRoom(); // 0
        public abstract bool IsRoomConnected(); // 0
        public abstract void DeclineInvitation(string invitationId); // 0
    
    }

}

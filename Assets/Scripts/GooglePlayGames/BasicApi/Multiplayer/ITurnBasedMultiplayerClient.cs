using UnityEngine;

namespace GooglePlayGames.BasicApi.Multiplayer
{
    public interface ITurnBasedMultiplayerClient
    {
        // Methods
        public abstract void CreateQuickMatch(uint minOpponents, uint maxOpponents, uint variant, System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback); // 0
        public abstract void CreateQuickMatch(uint minOpponents, uint maxOpponents, uint variant, ulong exclusiveBitmask, System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback); // 0
        public abstract void CreateWithInvitationScreen(uint minOpponents, uint maxOpponents, uint variant, System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback); // 0
        public abstract void CreateWithInvitationScreen(uint minOpponents, uint maxOpponents, uint variant, System.Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback); // 0
        public abstract void GetAllInvitations(System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation[]> callback); // 0
        public abstract void GetAllMatches(System.Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch[]> callback); // 0
        public abstract void AcceptFromInbox(System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback); // 0
        public abstract void AcceptInvitation(string invitationId, System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback); // 0
        public abstract void RegisterMatchDelegate(GooglePlayGames.BasicApi.Multiplayer.MatchDelegate del); // 0
        public abstract void TakeTurn(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, byte[] data, string pendingParticipantId, System.Action<bool> callback); // 0
        public abstract int GetMaxMatchDataSize(); // 0
        public abstract void Finish(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, byte[] data, GooglePlayGames.BasicApi.Multiplayer.MatchOutcome outcome, System.Action<bool> callback); // 0
        public abstract void AcknowledgeFinished(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, System.Action<bool> callback); // 0
        public abstract void Leave(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, System.Action<bool> callback); // 0
        public abstract void LeaveDuringTurn(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, string pendingParticipantId, System.Action<bool> callback); // 0
        public abstract void Cancel(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, System.Action<bool> callback); // 0
        public abstract void Rematch(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback); // 0
        public abstract void DeclineInvitation(string invitationId); // 0
    
    }

}

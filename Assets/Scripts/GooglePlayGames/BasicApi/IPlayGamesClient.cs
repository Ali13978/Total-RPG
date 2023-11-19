using UnityEngine;

namespace GooglePlayGames.BasicApi
{
    public interface IPlayGamesClient
    {
        // Methods
        public abstract void Authenticate(System.Action<bool, string> callback, bool silent); // 0
        public abstract bool IsAuthenticated(); // 0
        public abstract void SignOut(); // 0
        public abstract string GetUserId(); // 0
        public abstract void LoadFriends(System.Action<bool> callback); // 0
        public abstract string GetUserDisplayName(); // 0
        public abstract string GetIdToken(); // 0
        public abstract string GetServerAuthCode(); // 0
        public abstract void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, System.Action<string> callback); // 0
        public abstract string GetUserEmail(); // 0
        public abstract string GetUserImageUrl(); // 0
        public abstract void GetPlayerStats(System.Action<GooglePlayGames.BasicApi.CommonStatusCodes, GooglePlayGames.BasicApi.PlayerStats> callback); // 0
        public abstract void LoadUsers(string[] userIds, System.Action<UnityEngine.SocialPlatforms.IUserProfile[]> callback); // 0
        public abstract GooglePlayGames.BasicApi.Achievement GetAchievement(string achievementId); // 0
        public abstract void LoadAchievements(System.Action<GooglePlayGames.BasicApi.Achievement[]> callback); // 0
        public abstract void UnlockAchievement(string achievementId, System.Action<bool> successOrFailureCalllback); // 0
        public abstract void RevealAchievement(string achievementId, System.Action<bool> successOrFailureCalllback); // 0
        public abstract void IncrementAchievement(string achievementId, int steps, System.Action<bool> successOrFailureCalllback); // 0
        public abstract void SetStepsAtLeast(string achId, int steps, System.Action<bool> callback); // 0
        public abstract void ShowAchievementsUI(System.Action<GooglePlayGames.BasicApi.UIStatus> callback); // 0
        public abstract void ShowLeaderboardUI(string leaderboardId, GooglePlayGames.BasicApi.LeaderboardTimeSpan span, System.Action<GooglePlayGames.BasicApi.UIStatus> callback); // 0
        public abstract void LoadScores(string leaderboardId, GooglePlayGames.BasicApi.LeaderboardStart start, int rowCount, GooglePlayGames.BasicApi.LeaderboardCollection collection, GooglePlayGames.BasicApi.LeaderboardTimeSpan timeSpan, System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> callback); // 0
        public abstract void LoadMoreScores(GooglePlayGames.BasicApi.ScorePageToken token, int rowCount, System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> callback); // 0
        public abstract int LeaderboardMaxResults(); // 0
        public abstract void SubmitScore(string leaderboardId, long score, System.Action<bool> successOrFailureCalllback); // 0
        public abstract void SubmitScore(string leaderboardId, long score, string metadata, System.Action<bool> successOrFailureCalllback); // 0
        public abstract GooglePlayGames.BasicApi.Multiplayer.IRealTimeMultiplayerClient GetRtmpClient(); // 0
        public abstract GooglePlayGames.BasicApi.Multiplayer.ITurnBasedMultiplayerClient GetTbmpClient(); // 0
        public abstract GooglePlayGames.BasicApi.SavedGame.ISavedGameClient GetSavedGameClient(); // 0
        public abstract GooglePlayGames.BasicApi.Events.IEventsClient GetEventsClient(); // 0
        public abstract GooglePlayGames.BasicApi.Video.IVideoClient GetVideoClient(); // 0
        public abstract void RegisterInvitationDelegate(GooglePlayGames.BasicApi.InvitationReceivedDelegate invitationDelegate); // 0
        public abstract UnityEngine.SocialPlatforms.IUserProfile[] GetFriends(); // 0
        public abstract IntPtr GetApiClient(); // 0
        public abstract void SetGravityForPopups(GooglePlayGames.BasicApi.Gravity gravity); // 0
    
    }

}

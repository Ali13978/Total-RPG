using UnityEngine;

namespace GooglePlayGames.BasicApi
{
    public class DummyClient : IPlayGamesClient
    {
        // Methods
        public DummyClient()
        {
        
        }
        public void Authenticate(System.Action<bool, string> callback, bool silent)
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
            if(callback == null)
            {
                    return;
            }
            
            callback.Invoke(arg1:  false, arg2:  "Not implemented on this platform");
        }
        public bool IsAuthenticated()
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
            return false;
        }
        public void SignOut()
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
        }
        public string GetIdToken()
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
            return 0;
        }
        public string GetUserId()
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
            return "DummyID";
        }
        public string GetServerAuthCode()
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
            return 0;
        }
        public void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, System.Action<string> callback)
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
            callback.Invoke(obj:  0);
        }
        public string GetUserEmail()
        {
            null = null;
            return (string)System.String.Empty;
        }
        public void GetPlayerStats(System.Action<GooglePlayGames.BasicApi.CommonStatusCodes, GooglePlayGames.BasicApi.PlayerStats> callback)
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
            typeof(GooglePlayGames.BasicApi.PlayerStats).__il2cppRuntimeField_10 = 0;
            callback.Invoke(arg1:  17, arg2:  new System.Object());
        }
        public string GetUserDisplayName()
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
            return "Player";
        }
        public string GetUserImageUrl()
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
            return 0;
        }
        public void LoadUsers(string[] userIds, System.Action<UnityEngine.SocialPlatforms.IUserProfile[]> callback)
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
            if(callback == null)
            {
                    return;
            }
            
            callback.Invoke(obj:  0);
        }
        public void LoadAchievements(System.Action<GooglePlayGames.BasicApi.Achievement[]> callback)
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
            if(callback == null)
            {
                    return;
            }
            
            callback.Invoke(obj:  0);
        }
        public GooglePlayGames.BasicApi.Achievement GetAchievement(string achId)
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
            return 0;
        }
        public void UnlockAchievement(string achId, System.Action<bool> callback)
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
            if(callback == null)
            {
                    return;
            }
            
            callback.Invoke(obj:  false);
        }
        public void RevealAchievement(string achId, System.Action<bool> callback)
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
            if(callback == null)
            {
                    return;
            }
            
            callback.Invoke(obj:  false);
        }
        public void IncrementAchievement(string achId, int steps, System.Action<bool> callback)
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
            if(callback == null)
            {
                    return;
            }
            
            callback.Invoke(obj:  false);
        }
        public void SetStepsAtLeast(string achId, int steps, System.Action<bool> callback)
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
            if(callback == null)
            {
                    return;
            }
            
            callback.Invoke(obj:  false);
        }
        public void ShowAchievementsUI(System.Action<GooglePlayGames.BasicApi.UIStatus> callback)
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
            if(callback == null)
            {
                    return;
            }
            
            callback.Invoke(obj:  -4);
        }
        public void ShowLeaderboardUI(string leaderboardId, GooglePlayGames.BasicApi.LeaderboardTimeSpan span, System.Action<GooglePlayGames.BasicApi.UIStatus> callback)
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
            if(callback == null)
            {
                    return;
            }
            
            callback.Invoke(obj:  -4);
        }
        public int LeaderboardMaxResults()
        {
            return 25;
        }
        public void LoadScores(string leaderboardId, GooglePlayGames.BasicApi.LeaderboardStart start, int rowCount, GooglePlayGames.BasicApi.LeaderboardCollection collection, GooglePlayGames.BasicApi.LeaderboardTimeSpan timeSpan, System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> callback)
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
            if(callback == null)
            {
                    return;
            }
            
            callback.Invoke(obj:  new GooglePlayGames.BasicApi.LeaderboardScoreData(leaderboardId:  leaderboardId, status:  0));
        }
        public void LoadMoreScores(GooglePlayGames.BasicApi.ScorePageToken token, int rowCount, System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> callback)
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
            if(callback == null)
            {
                    return;
            }
            
            callback.Invoke(obj:  new GooglePlayGames.BasicApi.LeaderboardScoreData(leaderboardId:  token.mId, status:  0));
        }
        public void SubmitScore(string leaderboardId, long score, System.Action<bool> callback)
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
            if(callback == null)
            {
                    return;
            }
            
            callback.Invoke(obj:  false);
        }
        public void SubmitScore(string leaderboardId, long score, string metadata, System.Action<bool> callback)
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
            if(callback == null)
            {
                    return;
            }
            
            callback.Invoke(obj:  false);
        }
        public GooglePlayGames.BasicApi.Multiplayer.IRealTimeMultiplayerClient GetRtmpClient()
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
            return 0;
        }
        public GooglePlayGames.BasicApi.Multiplayer.ITurnBasedMultiplayerClient GetTbmpClient()
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
            return 0;
        }
        public GooglePlayGames.BasicApi.SavedGame.ISavedGameClient GetSavedGameClient()
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
            return 0;
        }
        public GooglePlayGames.BasicApi.Events.IEventsClient GetEventsClient()
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
            return 0;
        }
        public GooglePlayGames.BasicApi.Video.IVideoClient GetVideoClient()
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
            return 0;
        }
        public void RegisterInvitationDelegate(GooglePlayGames.BasicApi.InvitationReceivedDelegate invitationDelegate)
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
        }
        public GooglePlayGames.BasicApi.Multiplayer.Invitation GetInvitationFromNotification()
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
            return 0;
        }
        public bool HasInvitationFromNotification()
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
            return false;
        }
        public void LoadFriends(System.Action<bool> callback)
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
            callback.Invoke(obj:  false);
        }
        public UnityEngine.SocialPlatforms.IUserProfile[] GetFriends()
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
        }
        public IntPtr GetApiClient()
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
            return 0;
        }
        public void SetGravityForPopups(GooglePlayGames.BasicApi.Gravity gravity)
        {
            GooglePlayGames.BasicApi.DummyClient.LogUsage();
        }
        private static void LogUsage()
        {
            GooglePlayGames.OurUtils.Logger.d(msg:  0);
        }
    
    }

}

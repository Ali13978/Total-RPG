using UnityEngine;

namespace GooglePlayGames.BasicApi
{
    public class LeaderboardScoreData
    {
        // Fields
        private string mId;
        private GooglePlayGames.BasicApi.ResponseStatus mStatus;
        private ulong mApproxCount;
        private string mTitle;
        private UnityEngine.SocialPlatforms.IScore mPlayerScore;
        private GooglePlayGames.BasicApi.ScorePageToken mPrevPage;
        private GooglePlayGames.BasicApi.ScorePageToken mNextPage;
        private System.Collections.Generic.List<GooglePlayGames.PlayGamesScore> mScores;
        
        // Properties
        public bool Valid { get; }
        public GooglePlayGames.BasicApi.ResponseStatus Status { get; set; }
        public ulong ApproximateCount { get; set; }
        public string Title { get; set; }
        public string Id { get; set; }
        public UnityEngine.SocialPlatforms.IScore PlayerScore { get; set; }
        public UnityEngine.SocialPlatforms.IScore[] Scores { get; }
        public GooglePlayGames.BasicApi.ScorePageToken PrevPageToken { get; set; }
        public GooglePlayGames.BasicApi.ScorePageToken NextPageToken { get; set; }
        
        // Methods
        internal LeaderboardScoreData(string leaderboardId)
        {
            this.mScores = new System.Collections.Generic.List<GooglePlayGames.PlayGamesScore>();
            this.mId = leaderboardId;
        }
        internal LeaderboardScoreData(string leaderboardId, GooglePlayGames.BasicApi.ResponseStatus status)
        {
            this.mScores = new System.Collections.Generic.List<GooglePlayGames.PlayGamesScore>();
            this.mStatus = status;
            this.mId = leaderboardId;
        }
        public bool get_Valid()
        {
            GooglePlayGames.BasicApi.ResponseStatus val_2 = this.mStatus;
            val_2 = val_2 - 1;
            return (bool)(val_2 < 2) ? 1 : 0;
        }
        public GooglePlayGames.BasicApi.ResponseStatus get_Status()
        {
            return (GooglePlayGames.BasicApi.ResponseStatus)this.mStatus;
        }
        internal void set_Status(GooglePlayGames.BasicApi.ResponseStatus value)
        {
            this.mStatus = value;
        }
        public ulong get_ApproximateCount()
        {
            return (ulong)this.mApproxCount;
        }
        internal void set_ApproximateCount(ulong value)
        {
            this.mApproxCount = value;
        }
        public string get_Title()
        {
            return (string)this.mTitle;
        }
        internal void set_Title(string value)
        {
            this.mTitle = value;
        }
        public string get_Id()
        {
            return (string)this.mId;
        }
        internal void set_Id(string value)
        {
            this.mId = value;
        }
        public UnityEngine.SocialPlatforms.IScore get_PlayerScore()
        {
            return (UnityEngine.SocialPlatforms.IScore)this.mPlayerScore;
        }
        internal void set_PlayerScore(UnityEngine.SocialPlatforms.IScore value)
        {
            this.mPlayerScore = value;
        }
        public UnityEngine.SocialPlatforms.IScore[] get_Scores()
        {
            if(this.mScores != null)
            {
                    return this.mScores.ToArray();
            }
            
            return this.mScores.ToArray();
        }
        internal int AddScore(GooglePlayGames.PlayGamesScore score)
        {
            this.mScores.Add(item:  score);
            if(this.mScores != null)
            {
                    return this.mScores.Count;
            }
            
            return this.mScores.Count;
        }
        public GooglePlayGames.BasicApi.ScorePageToken get_PrevPageToken()
        {
            return (GooglePlayGames.BasicApi.ScorePageToken)this.mPrevPage;
        }
        internal void set_PrevPageToken(GooglePlayGames.BasicApi.ScorePageToken value)
        {
            this.mPrevPage = value;
        }
        public GooglePlayGames.BasicApi.ScorePageToken get_NextPageToken()
        {
            return (GooglePlayGames.BasicApi.ScorePageToken)this.mNextPage;
        }
        internal void set_NextPageToken(GooglePlayGames.BasicApi.ScorePageToken value)
        {
            this.mNextPage = value;
        }
        public override string ToString()
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = this.mId;
            typeof(System.Object[]).__il2cppRuntimeField_28 = this.mStatus;
            typeof(System.Object[]).__il2cppRuntimeField_30 = this.mApproxCount;
            typeof(System.Object[]).__il2cppRuntimeField_38 = this.mTitle;
            return (string)System.String.Format(format:  0, args:  "[LeaderboardScoreData: mId={0},  mStatus={1}, mApproxCount={2}, mTitle={3}]");
        }
    
    }

}

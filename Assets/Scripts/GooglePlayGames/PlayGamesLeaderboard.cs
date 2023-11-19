using UnityEngine;

namespace GooglePlayGames
{
    public class PlayGamesLeaderboard : ILeaderboard
    {
        // Fields
        private string mId;
        private UnityEngine.SocialPlatforms.UserScope mUserScope;
        private UnityEngine.SocialPlatforms.Range mRange;
        private UnityEngine.SocialPlatforms.TimeScope mTimeScope;
        private string[] mFilteredUserIds;
        private bool mLoading;
        private UnityEngine.SocialPlatforms.IScore mLocalUserScore;
        private uint mMaxRange;
        private System.Collections.Generic.List<GooglePlayGames.PlayGamesScore> mScoreList;
        private string mTitle;
        
        // Properties
        public bool loading { get; set; }
        public string id { get; set; }
        public UnityEngine.SocialPlatforms.UserScope userScope { get; set; }
        public UnityEngine.SocialPlatforms.Range range { get; set; }
        public UnityEngine.SocialPlatforms.TimeScope timeScope { get; set; }
        public UnityEngine.SocialPlatforms.IScore localUserScore { get; }
        public uint maxRange { get; }
        public UnityEngine.SocialPlatforms.IScore[] scores { get; }
        public string title { get; }
        public int ScoreCount { get; }
        
        // Methods
        public PlayGamesLeaderboard(string id)
        {
            this.mScoreList = new System.Collections.Generic.List<GooglePlayGames.PlayGamesScore>();
            this.mId = id;
        }
        public void SetUserFilter(string[] userIDs)
        {
            this.mFilteredUserIds = userIDs;
        }
        public void LoadScores(System.Action<bool> callback)
        {
            GooglePlayGames.PlayGamesPlatform.Instance.LoadScores(board:  this, callback:  callback);
        }
        public bool get_loading()
        {
            return (bool)this.mLoading;
        }
        internal void set_loading(bool value)
        {
            this.mLoading = value;
        }
        public string get_id()
        {
            return (string)this.mId;
        }
        public void set_id(string value)
        {
            this.mId = value;
        }
        public UnityEngine.SocialPlatforms.UserScope get_userScope()
        {
            return (UnityEngine.SocialPlatforms.UserScope)this.mUserScope;
        }
        public void set_userScope(UnityEngine.SocialPlatforms.UserScope value)
        {
            this.mUserScope = value;
        }
        public UnityEngine.SocialPlatforms.Range get_range()
        {
            return new UnityEngine.SocialPlatforms.Range() {from = this.mRange, count = this.mRange};
        }
        public void set_range(UnityEngine.SocialPlatforms.Range value)
        {
            this.mRange = value;
        }
        public UnityEngine.SocialPlatforms.TimeScope get_timeScope()
        {
            return (UnityEngine.SocialPlatforms.TimeScope)this.mTimeScope;
        }
        public void set_timeScope(UnityEngine.SocialPlatforms.TimeScope value)
        {
            this.mTimeScope = value;
        }
        public UnityEngine.SocialPlatforms.IScore get_localUserScore()
        {
            return (UnityEngine.SocialPlatforms.IScore)this.mLocalUserScore;
        }
        public uint get_maxRange()
        {
            return (uint)this.mMaxRange;
        }
        public UnityEngine.SocialPlatforms.IScore[] get_scores()
        {
            int val_1 = this.mScoreList.Count;
            this.mScoreList.CopyTo(array:  null);
            return (UnityEngine.SocialPlatforms.IScore[])null;
        }
        public string get_title()
        {
            return (string)this.mTitle;
        }
        internal bool SetFromData(GooglePlayGames.BasicApi.LeaderboardScoreData data)
        {
            bool val_19;
            UnityEngine.SocialPlatforms.IScore val_20;
            var val_21;
            if(data.Valid == false)
            {
                    return (bool)data.Valid;
            }
            
            string val_2 = 0 + "Setting leaderboard from: "("Setting leaderboard from: ");
            UnityEngine.Debug.Log(message:  0);
            if(data != null)
            {
                    this.mMaxRange = data.ApproximateCount;
                this.mTitle = data.Title;
            }
            else
            {
                    this.mMaxRange = 0.ApproximateCount;
                this.mTitle = 0.Title;
            }
            
            UnityEngine.SocialPlatforms.IScore val_7 = data.PlayerScore;
            val_20 = 0;
            if(val_7 != null)
            {
                    val_20 = val_7;
                val_20 = 0;
            }
            
            this.mLocalUserScore = val_20;
            val_21 = 0;
            goto label_13;
            label_20:
            int val_11 = this.AddScore(score:  0);
            val_21 = 1;
            label_13:
            if(val_21 >= val_10.Length)
            {
                goto label_15;
            }
            
            if(data.Scores[1] == null)
            {
                goto label_20;
            }
            
            goto label_20;
            label_15:
            UnityEngine.SocialPlatforms.IScore[] val_14 = data.Scores;
            if(val_14.Length != 0)
            {
                    val_19 = this.HasAllScores();
            }
            else
            {
                    val_19 = true;
            }
            
            this.mLoading = val_19;
            return (bool)data.Valid;
        }
        internal void SetMaxRange(ulong val)
        {
            this.mMaxRange = val;
        }
        internal void SetTitle(string value)
        {
            this.mTitle = value;
        }
        internal void SetLocalUserScore(GooglePlayGames.PlayGamesScore score)
        {
            this.mLocalUserScore = score;
        }
        internal int AddScore(GooglePlayGames.PlayGamesScore score)
        {
            string val_2;
            System.Collections.Generic.List<GooglePlayGames.PlayGamesScore> val_3;
            if((this.mFilteredUserIds == null) || (this.mFilteredUserIds.Length == 0))
            {
                goto label_3;
            }
            
            var val_2 = 0;
            label_7:
            if(val_2 >= this.mFilteredUserIds.Length)
            {
                goto label_3;
            }
            
            val_2 = this.mFilteredUserIds[0];
            val_2 = val_2 + 1;
            if((val_2.Equals(value:  score.mPlayerId)) == false)
            {
                goto label_7;
            }
            
            val_3 = this.mScoreList;
            if(val_3 != null)
            {
                    return val_3.Count;
            }
            
            return val_3.Count;
            label_3:
            val_2 = this.mScoreList;
            val_2.Add(item:  score);
            val_3 = val_3;
            if(val_3 != null)
            {
                    return val_3.Count;
            }
            
            return val_3.Count;
        }
        public int get_ScoreCount()
        {
            if(this.mScoreList != null)
            {
                    return this.mScoreList.Count;
            }
            
            return this.mScoreList.Count;
        }
        internal bool HasAllScores()
        {
            var val_4;
            if(this.mScoreList.Count < true)
            {
                    var val_3 = ((long)this.mScoreList.Count >= this.mMaxRange) ? 1 : 0;
                return (bool)val_4;
            }
            
            val_4 = 1;
            return (bool)val_4;
        }
    
    }

}

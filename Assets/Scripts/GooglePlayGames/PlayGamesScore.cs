using UnityEngine;

namespace GooglePlayGames
{
    public class PlayGamesScore : IScore
    {
        // Fields
        private string mLbId;
        private long mValue;
        private ulong mRank;
        private string mPlayerId;
        private string mMetadata;
        private System.DateTime mDate;
        
        // Properties
        public string leaderboardID { get; set; }
        public long value { get; set; }
        public System.DateTime date { get; }
        public string formattedValue { get; }
        public string userID { get; }
        public int rank { get; }
        public string metaData { get; }
        
        // Methods
        internal PlayGamesScore(System.DateTime date, string leaderboardId, ulong rank, string playerId, ulong value, string metadata)
        {
            null = null;
            System.DateTime val_1;
            this.mPlayerId = System.String.Empty;
            this.mMetadata = System.String.Empty;
            val_1 = new System.DateTime(year:  178, month:  1, day:  1, hour:  0, minute:  0, second:  0);
            this.mDate = val_1.ticks._ticks;
            mem[1152921511915326544] = val_1.kind;
            this.mDate = date;
            mem[1152921511915326544] = date.kind;
            this.mRank = rank;
            this.mPlayerId = playerId;
            this.mValue = value;
            this.mMetadata = metadata;
        }
        public void ReportScore(System.Action<bool> callback)
        {
            GooglePlayGames.PlayGamesPlatform.Instance.ReportScore(score:  this.mValue, board:  this.mLbId, metadata:  this.mMetadata, callback:  callback);
        }
        public string get_leaderboardID()
        {
            return (string)this.mLbId;
        }
        public void set_leaderboardID(string value)
        {
            this.mLbId = value;
        }
        public long get_value()
        {
            return (long)this.mValue;
        }
        public void set_value(long value)
        {
            this.mValue = value;
        }
        public System.DateTime get_date()
        {
            return new System.DateTime() {ticks = new System.TimeSpan() {_ticks = this.mDate}};
        }
        public string get_formattedValue()
        {
        
        }
        public string get_userID()
        {
            return (string)this.mPlayerId;
        }
        public int get_rank()
        {
            return (int)this.mRank;
        }
        public string get_metaData()
        {
            return (string)this.mMetadata;
        }
    
    }

}

using UnityEngine;

namespace GooglePlayGames.BasicApi
{
    public class ScorePageToken
    {
        // Fields
        private string mId;
        private object mInternalObject;
        private GooglePlayGames.BasicApi.LeaderboardCollection mCollection;
        private GooglePlayGames.BasicApi.LeaderboardTimeSpan mTimespan;
        
        // Properties
        public GooglePlayGames.BasicApi.LeaderboardCollection Collection { get; }
        public GooglePlayGames.BasicApi.LeaderboardTimeSpan TimeSpan { get; }
        public string LeaderboardId { get; }
        internal object InternalObject { get; }
        
        // Methods
        internal ScorePageToken(object internalObject, string id, GooglePlayGames.BasicApi.LeaderboardCollection collection, GooglePlayGames.BasicApi.LeaderboardTimeSpan timespan)
        {
            val_1 = new System.Object();
            this.mId = val_1;
            this.mInternalObject = internalObject;
            this.mCollection = collection;
            this.mTimespan = timespan;
        }
        public GooglePlayGames.BasicApi.LeaderboardCollection get_Collection()
        {
            return (GooglePlayGames.BasicApi.LeaderboardCollection)this.mCollection;
        }
        public GooglePlayGames.BasicApi.LeaderboardTimeSpan get_TimeSpan()
        {
            return (GooglePlayGames.BasicApi.LeaderboardTimeSpan)this.mTimespan;
        }
        public string get_LeaderboardId()
        {
            return (string)this.mId;
        }
        internal object get_InternalObject()
        {
            return (object)this.mInternalObject;
        }
    
    }

}

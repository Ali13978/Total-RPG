using UnityEngine;

namespace GooglePlayGames.BasicApi.SavedGame
{
    public interface ISavedGameMetadata
    {
        // Properties
        public abstract bool IsOpen { get; }
        public abstract string Filename { get; }
        public abstract string Description { get; }
        public abstract string CoverImageURL { get; }
        public abstract System.TimeSpan TotalTimePlayed { get; }
        public abstract System.DateTime LastModifiedTimestamp { get; }
        
        // Methods
        public abstract bool get_IsOpen(); // 0
        public abstract string get_Filename(); // 0
        public abstract string get_Description(); // 0
        public abstract string get_CoverImageURL(); // 0
        public abstract System.TimeSpan get_TotalTimePlayed(); // 0
        public abstract System.DateTime get_LastModifiedTimestamp(); // 0
    
    }

}

using UnityEngine;

namespace GooglePlayGames.BasicApi.SavedGame
{
    public struct SavedGameMetadataUpdate
    {
        // Fields
        private readonly bool mDescriptionUpdated;
        private readonly string mNewDescription;
        private readonly bool mCoverImageUpdated;
        private readonly byte[] mNewPngCoverImage;
        private readonly System.Nullable<System.TimeSpan> mNewPlayedTime;
        
        // Properties
        public bool IsDescriptionUpdated { get; }
        public string UpdatedDescription { get; }
        public bool IsCoverImageUpdated { get; }
        public byte[] UpdatedPngCoverImage { get; }
        public bool IsPlayedTimeUpdated { get; }
        public System.Nullable<System.TimeSpan> UpdatedPlayedTime { get; }
        
        // Methods
        private SavedGameMetadataUpdate(GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate.Builder builder)
        {
            this.mCoverImageUpdated = builder.mDescriptionUpdated;
            this.mNewPngCoverImage = builder.mNewDescription;
            this.mNewPlayedTime = builder.mCoverImageUpdated;
            mem[1152921511889751352] = builder.mNewPngCoverImage;
            mem[1152921511889751360] = builder.mNewPlayedTime.HasValue;
            mem[1152921511889751368] = mem[1152921511889783352];
        }
        public bool get_IsDescriptionUpdated()
        {
            return (bool)this.mCoverImageUpdated;
        }
        public string get_UpdatedDescription()
        {
            return (string)this.mNewPngCoverImage;
        }
        public bool get_IsCoverImageUpdated()
        {
            return (bool)this.mNewPlayedTime;
        }
        public byte[] get_UpdatedPngCoverImage()
        {
            return (System.Byte[])this;
        }
        public bool get_IsPlayedTimeUpdated()
        {
            return (bool)this.mCoverImageUpdated + 32;
        }
        public System.Nullable<System.TimeSpan> get_UpdatedPlayedTime()
        {
            return (System.Nullable<System.TimeSpan>)X8;
        }
    
    }

}

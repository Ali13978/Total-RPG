using UnityEngine;

namespace GooglePlayGames
{
    internal class PlayGamesAchievement : IAchievement, IAchievementDescription
    {
        // Fields
        private readonly GooglePlayGames.ReportProgress mProgressCallback;
        private string mId;
        private bool mIsIncremental;
        private int mCurrentSteps;
        private int mTotalSteps;
        private double mPercentComplete;
        private bool mCompleted;
        private bool mHidden;
        private System.DateTime mLastModifiedTime;
        private string mTitle;
        private string mRevealedImageUrl;
        private string mUnlockedImageUrl;
        private UnityEngine.WWW mImageFetcher;
        private UnityEngine.Texture2D mImage;
        private string mDescription;
        private ulong mPoints;
        
        // Properties
        public string id { get; set; }
        public bool isIncremental { get; }
        public int currentSteps { get; }
        public int totalSteps { get; }
        public double percentCompleted { get; set; }
        public bool completed { get; }
        public bool hidden { get; }
        public System.DateTime lastReportedDate { get; }
        public string title { get; }
        public UnityEngine.Texture2D image { get; }
        public string achievedDescription { get; }
        public string unachievedDescription { get; }
        public int points { get; }
        
        // Methods
        internal PlayGamesAchievement()
        {
            typeof(GooglePlayGames.ReportProgress).__il2cppRuntimeField_20 = GooglePlayGames.PlayGamesPlatform.Instance;
            typeof(GooglePlayGames.ReportProgress).__il2cppRuntimeField_28 = public System.Void GooglePlayGames.PlayGamesPlatform::ReportProgress(string achievementID, double progress, System.Action<bool> callback);
            typeof(GooglePlayGames.ReportProgress).__il2cppRuntimeField_10 = public System.Void GooglePlayGames.PlayGamesPlatform::ReportProgress(string achievementID, double progress, System.Action<bool> callback);
        }
        internal PlayGamesAchievement(GooglePlayGames.ReportProgress progressCallback)
        {
            null = null;
            this.mId = System.String.Empty;
            this.mLastModifiedTime = 0;
            mem[1152921511896058888] = 0;
            this.mTitle = System.String.Empty;
            this.mRevealedImageUrl = System.String.Empty;
            this.mUnlockedImageUrl = System.String.Empty;
            this.mDescription = System.String.Empty;
            this.mProgressCallback = progressCallback;
        }
        internal PlayGamesAchievement(GooglePlayGames.BasicApi.Achievement ach)
        {
            var val_34;
            double val_35;
            if(ach != null)
            {
                    this.mId = ach.Id;
            }
            else
            {
                    this.mId = 0.Id;
            }
            
            this.mIsIncremental = ach.IsIncremental;
            if(ach == null)
            {
                goto label_2;
            }
            
            this.mCurrentSteps = ach.CurrentSteps;
            this.mTotalSteps = ach.TotalSteps;
            if(ach.IsIncremental == true)
            {
                goto label_3;
            }
            
            goto label_5;
            label_2:
            this.mCurrentSteps = 0.CurrentSteps;
            this.mTotalSteps = 0.TotalSteps;
            val_34 = 0.IsIncremental;
            if(val_34 == false)
            {
                goto label_5;
            }
            
            label_3:
            if(ach.TotalSteps < 1)
            {
                goto label_6;
            }
            
            if(ach == null)
            {
                goto label_7;
            }
            
            val_34 = ach.CurrentSteps;
            goto label_8;
            label_5:
            var val_15 = (ach.IsUnlocked != true) ? 100 : 0;
            goto label_9;
            label_6:
            this.mPercentComplete = 0;
            goto label_10;
            label_7:
            val_34 = 0.CurrentSteps;
            label_8:
            double val_34 = (double)val_34;
            val_34 = val_34 / (double)ach.TotalSteps;
            val_35 = val_34 * 100;
            label_9:
            this.mPercentComplete = val_35;
            label_10:
            if(ach != null)
            {
                    this.mCompleted = ach.IsUnlocked;
            }
            else
            {
                    this.mCompleted = 0.IsUnlocked;
            }
            
            bool val_35 = ~ach.IsRevealed;
            val_35 = val_35 & 1;
            this.mHidden = val_35;
            if(ach != null)
            {
                    System.DateTime val_23 = ach.LastModifiedTime;
                this.mLastModifiedTime = val_23;
                mem[1152921511896215944] = val_23.kind;
                this.mTitle = ach.Name;
                this.mDescription = ach.Description;
                this.mPoints = ach.Points;
                this.mRevealedImageUrl = ach.RevealedImageUrl;
            }
            else
            {
                    System.DateTime val_28 = 0.LastModifiedTime;
                this.mLastModifiedTime = val_28;
                mem[1152921511896215944] = val_28.kind;
                this.mTitle = 0.Name;
                this.mDescription = 0.Description;
                this.mPoints = 0.Points;
                this.mRevealedImageUrl = 0.RevealedImageUrl;
            }
            
            this.mUnlockedImageUrl = ach.UnlockedImageUrl;
        }
        public void ReportProgress(System.Action<bool> callback)
        {
            this.mProgressCallback.Invoke(id:  this.mId, progress:  this.mPercentComplete, callback:  callback);
        }
        private UnityEngine.Texture2D LoadImage()
        {
            UnityEngine.WWW val_11;
            UnityEngine.Texture2D val_12;
            var val_13;
            UnityEngine.Texture2D val_14;
            val_11 = this;
            if(this.mHidden != false)
            {
                    val_12 = 0;
                return val_10;
            }
            
            val_13 = 1152921504608284672;
            val_12 = 0;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                    return val_10;
            }
            
            if(this.mImageFetcher != null)
            {
                    if((System.String.op_Inequality(a:  0, b:  this.mImageFetcher.url)) == false)
            {
                goto label_9;
            }
            
            }
            
            this.mImageFetcher = new UnityEngine.WWW(url:  (this.mCompleted == false) ? this.mRevealedImageUrl : this.mUnlockedImageUrl);
            val_13 = val_11;
            val_14 = 0;
            this.mImage = 0;
            goto label_10;
            label_9:
            val_13 = val_11;
            val_14 = this.mImage;
            label_10:
            if(0 != val_14)
            {
                    val_12 = this.mImage;
                return val_10;
            }
            
            val_12 = 0;
            if(this.mImageFetcher.isDone == false)
            {
                    return val_10;
            }
            
            val_11 = this.mImageFetcher;
            UnityEngine.Texture2D val_10 = val_11.texture;
            this.mImage = val_10;
            return val_10;
        }
        public string get_id()
        {
            return (string)this.mId;
        }
        public void set_id(string value)
        {
            this.mId = value;
        }
        public bool get_isIncremental()
        {
            return (bool)this.mIsIncremental;
        }
        public int get_currentSteps()
        {
            return (int)this.mCurrentSteps;
        }
        public int get_totalSteps()
        {
            return (int)this.mTotalSteps;
        }
        public double get_percentCompleted()
        {
            return (double)this.mPercentComplete;
        }
        public void set_percentCompleted(double value)
        {
            this.mPercentComplete = value;
        }
        public bool get_completed()
        {
            return (bool)this.mCompleted;
        }
        public bool get_hidden()
        {
            return (bool)this.mHidden;
        }
        public System.DateTime get_lastReportedDate()
        {
            return new System.DateTime() {ticks = new System.TimeSpan() {_ticks = this.mLastModifiedTime}};
        }
        public string get_title()
        {
            return (string)this.mTitle;
        }
        public UnityEngine.Texture2D get_image()
        {
            return this.LoadImage();
        }
        public string get_achievedDescription()
        {
            return (string)this.mDescription;
        }
        public string get_unachievedDescription()
        {
            return (string)this.mDescription;
        }
        public int get_points()
        {
            return (int)this.mPoints;
        }
    
    }

}

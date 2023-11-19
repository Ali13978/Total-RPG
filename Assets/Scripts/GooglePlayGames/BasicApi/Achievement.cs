using UnityEngine;

namespace GooglePlayGames.BasicApi
{
    public class Achievement
    {
        // Fields
        private static readonly System.DateTime UnixEpoch;
        private string mId;
        private bool mIsIncremental;
        private bool mIsRevealed;
        private bool mIsUnlocked;
        private int mCurrentSteps;
        private int mTotalSteps;
        private string mDescription;
        private string mName;
        private long mLastModifiedTime;
        private ulong mPoints;
        private string mRevealedImageUrl;
        private string mUnlockedImageUrl;
        
        // Properties
        public bool IsIncremental { get; set; }
        public int CurrentSteps { get; set; }
        public int TotalSteps { get; set; }
        public bool IsUnlocked { get; set; }
        public bool IsRevealed { get; set; }
        public string Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public System.DateTime LastModifiedTime { get; set; }
        public ulong Points { get; set; }
        public string RevealedImageUrl { get; set; }
        public string UnlockedImageUrl { get; set; }
        
        // Methods
        public Achievement()
        {
            null = null;
            this.mId = System.String.Empty;
            this.mDescription = System.String.Empty;
            this.mName = System.String.Empty;
        }
        public override string ToString()
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = this.mId;
            typeof(System.Object[]).__il2cppRuntimeField_28 = this.mName;
            typeof(System.Object[]).__il2cppRuntimeField_30 = this.mDescription;
            typeof(System.Object[]).__il2cppRuntimeField_38 = (this.mIsIncremental == true) ? "INCREMENTAL" : "STANDARD";
            typeof(System.Object[]).__il2cppRuntimeField_40 = this.mIsRevealed;
            typeof(System.Object[]).__il2cppRuntimeField_41 = 28321231;
            typeof(System.Object[]).__il2cppRuntimeField_48 = this.mIsUnlocked;
            typeof(System.Object[]).__il2cppRuntimeField_49 = 28321247;
            typeof(System.Object[]).__il2cppRuntimeField_50 = this.mCurrentSteps;
            typeof(System.Object[]).__il2cppRuntimeField_54 = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_58 = this.mTotalSteps;
            typeof(System.Object[]).__il2cppRuntimeField_5C = 268435457;
            return (string)System.String.Format(format:  0, args:  "[Achievement] id={0}, name={1}, desc={2}, type={3}, revealed={4}, unlocked={5}, steps={6}/{7}");
        }
        public bool get_IsIncremental()
        {
            return (bool)this.mIsIncremental;
        }
        public void set_IsIncremental(bool value)
        {
            this.mIsIncremental = value;
        }
        public int get_CurrentSteps()
        {
            return (int)this.mCurrentSteps;
        }
        public void set_CurrentSteps(int value)
        {
            this.mCurrentSteps = value;
        }
        public int get_TotalSteps()
        {
            return (int)this.mTotalSteps;
        }
        public void set_TotalSteps(int value)
        {
            this.mTotalSteps = value;
        }
        public bool get_IsUnlocked()
        {
            return (bool)this.mIsUnlocked;
        }
        public void set_IsUnlocked(bool value)
        {
            this.mIsUnlocked = value;
        }
        public bool get_IsRevealed()
        {
            return (bool)this.mIsRevealed;
        }
        public void set_IsRevealed(bool value)
        {
            this.mIsRevealed = value;
        }
        public string get_Id()
        {
            return (string)this.mId;
        }
        public void set_Id(string value)
        {
            this.mId = value;
        }
        public string get_Description()
        {
            return (string)this.mDescription;
        }
        public void set_Description(string value)
        {
            this.mDescription = value;
        }
        public string get_Name()
        {
            return (string)this.mName;
        }
        public void set_Name(string value)
        {
            this.mName = value;
        }
        public System.DateTime get_LastModifiedTime()
        {
            null = null;
            return new System.DateTime() {ticks = new System.TimeSpan() {}};
        }
        public void set_LastModifiedTime(System.DateTime value)
        {
            null = null;
            System.TimeSpan val_1 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {ticks = new System.TimeSpan(), kind = value.ticks._ticks}, d2:  new System.DateTime() {ticks = new System.TimeSpan() {_ticks = value.kind}, kind = GooglePlayGames.BasicApi.Achievement.UnixEpoch});
            this.mLastModifiedTime = (long)D0;
        }
        public ulong get_Points()
        {
            return (ulong)this.mPoints;
        }
        public void set_Points(ulong value)
        {
            this.mPoints = value;
        }
        public string get_RevealedImageUrl()
        {
            return (string)this.mRevealedImageUrl;
        }
        public void set_RevealedImageUrl(string value)
        {
            this.mRevealedImageUrl = value;
        }
        public string get_UnlockedImageUrl()
        {
            return (string)this.mUnlockedImageUrl;
        }
        public void set_UnlockedImageUrl(string value)
        {
            this.mUnlockedImageUrl = value;
        }
        private static Achievement()
        {
            GooglePlayGames.BasicApi.Achievement.UnixEpoch = 0;
            GooglePlayGames.BasicApi.Achievement.UnixEpoch.__il2cppRuntimeField_8 = 0;
        }
    
    }

}

using UnityEngine;

namespace GooglePlayGames.BasicApi.Video
{
    public class VideoCapabilities
    {
        // Fields
        private bool mIsCameraSupported;
        private bool mIsMicSupported;
        private bool mIsWriteStorageSupported;
        private bool[] mCaptureModesSupported;
        private bool[] mQualityLevelsSupported;
        private static System.Func<bool, string> <>f__am$cache0;
        private static System.Func<bool, string> <>f__am$cache1;
        
        // Properties
        public bool IsCameraSupported { get; }
        public bool IsMicSupported { get; }
        public bool IsWriteStorageSupported { get; }
        
        // Methods
        internal VideoCapabilities(bool isCameraSupported, bool isMicSupported, bool isWriteStorageSupported, bool[] captureModesSupported, bool[] qualityLevelsSupported)
        {
            this.mCaptureModesSupported = captureModesSupported;
            this.mQualityLevelsSupported = qualityLevelsSupported;
            this.mIsWriteStorageSupported = isWriteStorageSupported;
            this.mIsCameraSupported = isCameraSupported;
            this.mIsMicSupported = isMicSupported;
        }
        public bool get_IsCameraSupported()
        {
            return (bool)this.mIsCameraSupported;
        }
        public bool get_IsMicSupported()
        {
            return (bool)this.mIsMicSupported;
        }
        public bool get_IsWriteStorageSupported()
        {
            return (bool)this.mIsWriteStorageSupported;
        }
        public bool SupportsCaptureMode(GooglePlayGames.BasicApi.VideoCaptureMode captureMode)
        {
            var val_2;
            var val_3;
            if(captureMode != 1)
            {
                    val_2 = (long)captureMode;
                var val_1 = (this.mCaptureModesSupported[val_2] == true) ? 1 : 0;
                return (bool)val_3;
            }
            
            GooglePlayGames.OurUtils.Logger.w(msg:  0);
            val_3 = 0;
            return (bool)val_3;
        }
        public bool SupportsQualityLevel(GooglePlayGames.BasicApi.VideoQualityLevel qualityLevel)
        {
            var val_2;
            var val_3;
            if(qualityLevel != 1)
            {
                    val_2 = (long)qualityLevel;
                var val_1 = (this.mQualityLevelsSupported[val_2] == true) ? 1 : 0;
                return (bool)val_3;
            }
            
            GooglePlayGames.OurUtils.Logger.w(msg:  0);
            val_3 = 0;
            return (bool)val_3;
        }
        public override string ToString()
        {
            var val_10;
            IntPtr val_11;
            typeof(System.Object[]).__il2cppRuntimeField_20 = this.mIsCameraSupported;
            typeof(System.Object[]).__il2cppRuntimeField_21 = 28463266;
            typeof(System.Object[]).__il2cppRuntimeField_28 = this.mIsMicSupported;
            typeof(System.Object[]).__il2cppRuntimeField_29 = 28463282;
            typeof(System.Object[]).__il2cppRuntimeField_30 = this.mIsWriteStorageSupported;
            typeof(System.Object[]).__il2cppRuntimeField_31 = 28463298;
            val_10 = null;
            if((GooglePlayGames.BasicApi.Video.VideoCapabilities.<>f__am$cache0) == null)
            {
                    GooglePlayGames.BasicApi.Video.VideoCapabilities.<>f__am$cache0 = new System.Func<System.Boolean, System.String>(object:  0, method:  static System.String GooglePlayGames.BasicApi.Video.VideoCapabilities::<ToString>m__0(bool p));
                val_10 = null;
            }
            
            System.Collections.Generic.IEnumerable<TResult> val_2 = System.Linq.Enumerable.Select<System.Boolean, System.Object>(source:  0, selector:  this.mCaptureModesSupported);
            val_11 = System.Linq.Enumerable.ToArray<System.Type>(source:  0);
            typeof(System.Object[]).__il2cppRuntimeField_38 = System.String.Join(separator:  0, value:  ",");
            if((GooglePlayGames.BasicApi.Video.VideoCapabilities.<>f__am$cache1) == null)
            {
                    val_11 = static System.String GooglePlayGames.BasicApi.Video.VideoCapabilities::<ToString>m__1(bool p);
                GooglePlayGames.BasicApi.Video.VideoCapabilities.<>f__am$cache1 = new System.Func<System.Boolean, System.String>(object:  0, method:  val_11);
            }
            
            System.Collections.Generic.IEnumerable<TResult> val_6 = System.Linq.Enumerable.Select<System.Boolean, System.Object>(source:  0, selector:  this.mQualityLevelsSupported);
            TSource[] val_7 = System.Linq.Enumerable.ToArray<System.Type>(source:  0);
            typeof(System.Object[]).__il2cppRuntimeField_40 = System.String.Join(separator:  0, value:  ",");
            return (string)System.String.Format(format:  0, args:  "[VideoCapabilities: mIsCameraSupported={0}, mIsMicSupported={1}, mIsWriteStorageSupported={2}, mCaptureModesSupported={3}, mQualityLevelsSupported={4}]");
        }
        private static string <ToString>m__0(bool p)
        {
            var val_1 = W1 & 1;
            return -1303090065;
        }
        private static string <ToString>m__1(bool p)
        {
            var val_1 = W1 & 1;
            return -1302978065;
        }
    
    }

}

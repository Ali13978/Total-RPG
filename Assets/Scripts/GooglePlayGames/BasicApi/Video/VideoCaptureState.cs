using UnityEngine;

namespace GooglePlayGames.BasicApi.Video
{
    public class VideoCaptureState
    {
        // Fields
        private bool mIsCapturing;
        private GooglePlayGames.BasicApi.VideoCaptureMode mCaptureMode;
        private GooglePlayGames.BasicApi.VideoQualityLevel mQualityLevel;
        private bool mIsOverlayVisible;
        private bool mIsPaused;
        
        // Properties
        public bool IsCapturing { get; }
        public GooglePlayGames.BasicApi.VideoCaptureMode CaptureMode { get; }
        public GooglePlayGames.BasicApi.VideoQualityLevel QualityLevel { get; }
        public bool IsOverlayVisible { get; }
        public bool IsPaused { get; }
        
        // Methods
        internal VideoCaptureState(bool isCapturing, GooglePlayGames.BasicApi.VideoCaptureMode captureMode, GooglePlayGames.BasicApi.VideoQualityLevel qualityLevel, bool isOverlayVisible, bool isPaused)
        {
            this.mCaptureMode = captureMode;
            this.mQualityLevel = qualityLevel;
            this.mIsPaused = isPaused;
            this.mIsCapturing = isCapturing;
            this.mIsOverlayVisible = isOverlayVisible;
        }
        public bool get_IsCapturing()
        {
            return (bool)this.mIsCapturing;
        }
        public GooglePlayGames.BasicApi.VideoCaptureMode get_CaptureMode()
        {
            return (GooglePlayGames.BasicApi.VideoCaptureMode)this.mCaptureMode;
        }
        public GooglePlayGames.BasicApi.VideoQualityLevel get_QualityLevel()
        {
            return (GooglePlayGames.BasicApi.VideoQualityLevel)this.mQualityLevel;
        }
        public bool get_IsOverlayVisible()
        {
            return (bool)this.mIsOverlayVisible;
        }
        public bool get_IsPaused()
        {
            return (bool)this.mIsPaused;
        }
        public override string ToString()
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = this.mIsCapturing;
            typeof(System.Object[]).__il2cppRuntimeField_21 = 28468165;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            mem2[0] = null;
            typeof(System.Object[]).__il2cppRuntimeField_28 = this.mCaptureMode.ToString();
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y});
            mem2[0] = null;
            typeof(System.Object[]).__il2cppRuntimeField_30 = this.mQualityLevel.ToString();
            typeof(System.Object[]).__il2cppRuntimeField_38 = this.mIsOverlayVisible;
            typeof(System.Object[]).__il2cppRuntimeField_39 = 28468245;
            typeof(System.Object[]).__il2cppRuntimeField_40 = this.mIsPaused;
            typeof(System.Object[]).__il2cppRuntimeField_41 = 28468261;
            return (string)System.String.Format(format:  0, args:  "[VideoCaptureState: mIsCapturing={0}, mCaptureMode={1}, mQualityLevel={2}, mIsOverlayVisible={3}, mIsPaused={4}]");
        }
    
    }

}

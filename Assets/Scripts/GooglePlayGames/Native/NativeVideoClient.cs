using UnityEngine;

namespace GooglePlayGames.Native
{
    internal class NativeVideoClient : IVideoClient
    {
        // Fields
        private readonly GooglePlayGames.Native.PInvoke.VideoManager mManager;
        
        // Methods
        internal NativeVideoClient(GooglePlayGames.Native.PInvoke.VideoManager manager)
        {
            this.mManager = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
        }
        public void GetCaptureCapabilities(System.Action<GooglePlayGames.BasicApi.ResponseStatus, GooglePlayGames.BasicApi.Video.VideoCapabilities> callback)
        {
            var val_7;
            System.Action<T1, T2> val_8;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_7 = val_1;
                typeof(NativeVideoClient.<GetCaptureCapabilities>c__AnonStorey0).__il2cppRuntimeField_10 = callback;
                NativeVideoClient.<GetCaptureCapabilities>c__AnonStorey0.__il2cppRuntimeField_name.__il2cppRuntimeField_8 = this;
                GooglePlayGames.BasicApi.IPlayGamesClient val_2 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
                val_8 = GooglePlayGames.Native.CallbackUtils.ToOnGameThread<GooglePlayGames.BasicApi.ResponseStatus, System.Object>(toConvert:  0);
            }
            else
            {
                    val_7 = 16;
                mem[16] = callback;
                mem[24] = this;
                GooglePlayGames.BasicApi.IPlayGamesClient val_4 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
                val_8 = GooglePlayGames.Native.CallbackUtils.ToOnGameThread<GooglePlayGames.BasicApi.ResponseStatus, System.Object>(toConvert:  0);
            }
            
            mem[16] = val_8;
            this.mManager.GetCaptureCapabilities(callback:  new System.Action<GooglePlayGames.Native.PInvoke.GetCaptureCapabilitiesResponse>(object:  val_1, method:  System.Void NativeVideoClient.<GetCaptureCapabilities>c__AnonStorey0::<>m__0(GooglePlayGames.Native.PInvoke.GetCaptureCapabilitiesResponse response)));
        }
        private GooglePlayGames.BasicApi.Video.VideoCapabilities FromNativeVideoCapabilities(GooglePlayGames.Native.PInvoke.NativeVideoCapabilities capabilities)
        {
            int val_1 = this.mManager.NumCaptureModes;
            System.Runtime.InteropServices.HandleRef val_2 = capabilities.SelfPtr();
            typeof(System.Boolean[]).__il2cppRuntimeField_20 = GooglePlayGames.Native.Cwrapper.VideoCapabilities.VideoCapabilities_SupportsCaptureMode(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_2.wrapper}, capture_mode:  val_2.handle);
            System.Runtime.InteropServices.HandleRef val_5 = capabilities.SelfPtr();
            typeof(System.Boolean[]).__il2cppRuntimeField_21 = GooglePlayGames.Native.Cwrapper.VideoCapabilities.VideoCapabilities_SupportsCaptureMode(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_5.wrapper}, capture_mode:  val_5.handle);
            int val_8 = this.mManager.NumQualityLevels;
            System.Runtime.InteropServices.HandleRef val_9 = capabilities.SelfPtr();
            typeof(System.Boolean[]).__il2cppRuntimeField_20 = GooglePlayGames.Native.Cwrapper.VideoCapabilities.VideoCapabilities_SupportsQualityLevel(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_9.wrapper}, quality_level:  val_9.handle);
            System.Runtime.InteropServices.HandleRef val_12 = capabilities.SelfPtr();
            typeof(System.Boolean[]).__il2cppRuntimeField_21 = GooglePlayGames.Native.Cwrapper.VideoCapabilities.VideoCapabilities_SupportsQualityLevel(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_12.wrapper}, quality_level:  val_12.handle);
            System.Runtime.InteropServices.HandleRef val_15 = capabilities.SelfPtr();
            typeof(System.Boolean[]).__il2cppRuntimeField_22 = GooglePlayGames.Native.Cwrapper.VideoCapabilities.VideoCapabilities_SupportsQualityLevel(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_15.wrapper}, quality_level:  val_15.handle);
            System.Runtime.InteropServices.HandleRef val_18 = capabilities.SelfPtr();
            typeof(System.Boolean[]).__il2cppRuntimeField_23 = GooglePlayGames.Native.Cwrapper.VideoCapabilities.VideoCapabilities_SupportsQualityLevel(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_18.wrapper}, quality_level:  val_18.handle);
            System.Runtime.InteropServices.HandleRef val_21 = capabilities.SelfPtr();
            System.Runtime.InteropServices.HandleRef val_23 = capabilities.SelfPtr();
            System.Runtime.InteropServices.HandleRef val_25 = capabilities.SelfPtr();
            return (GooglePlayGames.BasicApi.Video.VideoCapabilities)new GooglePlayGames.BasicApi.Video.VideoCapabilities(isCameraSupported:  GooglePlayGames.Native.Cwrapper.VideoCapabilities.VideoCapabilities_IsCameraSupported(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_21.wrapper}), isMicSupported:  GooglePlayGames.Native.Cwrapper.VideoCapabilities.VideoCapabilities_IsMicSupported(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_23.wrapper}), isWriteStorageSupported:  GooglePlayGames.Native.Cwrapper.VideoCapabilities.VideoCapabilities_IsWriteStorageSupported(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_25.wrapper}), captureModesSupported:  null, qualityLevelsSupported:  null);
        }
        public void ShowCaptureOverlay()
        {
            this.mManager.ShowCaptureOverlay();
        }
        public void GetCaptureState(System.Action<GooglePlayGames.BasicApi.ResponseStatus, GooglePlayGames.BasicApi.Video.VideoCaptureState> callback)
        {
            var val_7;
            System.Action<T1, T2> val_8;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_7 = val_1;
                typeof(NativeVideoClient.<GetCaptureState>c__AnonStorey1).__il2cppRuntimeField_10 = callback;
                NativeVideoClient.<GetCaptureState>c__AnonStorey1.__il2cppRuntimeField_name.__il2cppRuntimeField_8 = this;
                GooglePlayGames.BasicApi.IPlayGamesClient val_2 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
                val_8 = GooglePlayGames.Native.CallbackUtils.ToOnGameThread<GooglePlayGames.BasicApi.ResponseStatus, System.Object>(toConvert:  0);
            }
            else
            {
                    val_7 = 16;
                mem[16] = callback;
                mem[24] = this;
                GooglePlayGames.BasicApi.IPlayGamesClient val_4 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
                val_8 = GooglePlayGames.Native.CallbackUtils.ToOnGameThread<GooglePlayGames.BasicApi.ResponseStatus, System.Object>(toConvert:  0);
            }
            
            mem[16] = val_8;
            this.mManager.GetCaptureState(callback:  new System.Action<GooglePlayGames.Native.PInvoke.GetCaptureStateResponse>(object:  val_1, method:  System.Void NativeVideoClient.<GetCaptureState>c__AnonStorey1::<>m__0(GooglePlayGames.Native.PInvoke.GetCaptureStateResponse response)));
        }
        private GooglePlayGames.BasicApi.Video.VideoCaptureState FromNativeVideoCaptureState(GooglePlayGames.Native.PInvoke.NativeVideoCaptureState captureState)
        {
            System.Runtime.InteropServices.HandleRef val_1 = captureState.SelfPtr();
            System.Runtime.InteropServices.HandleRef val_3 = captureState.SelfPtr();
            VideoCaptureMode val_4 = GooglePlayGames.Native.Cwrapper.VideoCaptureState.VideoCaptureState_CaptureMode(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_3.wrapper});
            System.Runtime.InteropServices.HandleRef val_6 = captureState.SelfPtr();
            VideoQualityLevel val_7 = GooglePlayGames.Native.Cwrapper.VideoCaptureState.VideoCaptureState_QualityLevel(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_6.wrapper});
            System.Runtime.InteropServices.HandleRef val_9 = captureState.SelfPtr();
            System.Runtime.InteropServices.HandleRef val_11 = captureState.SelfPtr();
            return (GooglePlayGames.BasicApi.Video.VideoCaptureState)new GooglePlayGames.BasicApi.Video.VideoCaptureState(isCapturing:  GooglePlayGames.Native.Cwrapper.VideoCaptureState.VideoCaptureState_IsCapturing(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}), captureMode:  GooglePlayGames.Native.ConversionUtils.ConvertNativeVideoCaptureMode(nativeCaptureMode:  0), qualityLevel:  GooglePlayGames.Native.ConversionUtils.ConvertNativeVideoQualityLevel(nativeQualityLevel:  0), isOverlayVisible:  GooglePlayGames.Native.Cwrapper.VideoCaptureState.VideoCaptureState_IsOverlayVisible(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_9.wrapper}), isPaused:  GooglePlayGames.Native.Cwrapper.VideoCaptureState.VideoCaptureState_IsPaused(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_11.wrapper}));
        }
        public void IsCaptureAvailable(GooglePlayGames.BasicApi.VideoCaptureMode captureMode, System.Action<GooglePlayGames.BasicApi.ResponseStatus, bool> callback)
        {
            var val_8;
            System.Action<T1, T2> val_9;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_8 = val_1;
                typeof(NativeVideoClient.<IsCaptureAvailable>c__AnonStorey2).__il2cppRuntimeField_10 = callback;
                GooglePlayGames.BasicApi.IPlayGamesClient val_2 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
                val_9 = GooglePlayGames.Native.CallbackUtils.ToOnGameThread<GooglePlayGames.BasicApi.ResponseStatus, System.Boolean>(toConvert:  0);
            }
            else
            {
                    val_8 = 16;
                mem[16] = callback;
                GooglePlayGames.BasicApi.IPlayGamesClient val_4 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
                val_9 = GooglePlayGames.Native.CallbackUtils.ToOnGameThread<GooglePlayGames.BasicApi.ResponseStatus, System.Boolean>(toConvert:  0);
            }
            
            mem[16] = val_9;
            this.mManager.IsCaptureAvailable(captureMode:  GooglePlayGames.Native.ConversionUtils.ConvertVideoCaptureMode(captureMode:  0), callback:  new System.Action<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(object:  val_1, method:  System.Void NativeVideoClient.<IsCaptureAvailable>c__AnonStorey2::<>m__0(GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse response)));
        }
        public bool IsCaptureSupported()
        {
            if(this.mManager != null)
            {
                    return this.mManager.IsCaptureSupported();
            }
            
            return this.mManager.IsCaptureSupported();
        }
        public void RegisterCaptureOverlayStateChangedListener(GooglePlayGames.BasicApi.Video.CaptureOverlayStateListener listener)
        {
            GooglePlayGames.BasicApi.Video.CaptureOverlayStateListener val_6 = listener;
            if(null != 0)
            {
                    typeof(NativeVideoClient.<RegisterCaptureOverlayStateChangedListener>c__AnonStorey3).__il2cppRuntimeField_10 = val_6;
            }
            else
            {
                    mem[16] = val_6;
                val_6 = mem[16];
            }
            
            GooglePlayGames.BasicApi.IPlayGamesClient val_2 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            this.mManager.RegisterCaptureOverlayStateChangedListener(helper:  GooglePlayGames.Native.PInvoke.CaptureOverlayStateListenerHelper.Create().SetOnCaptureOverlayStateChangedCallback(callback:  new System.Action<VideoCaptureOverlayState>(object:  new System.Object(), method:  System.Void NativeVideoClient.<RegisterCaptureOverlayStateChangedListener>c__AnonStorey3::<>m__0(GooglePlayGames.Native.Cwrapper.Types.VideoCaptureOverlayState response))));
        }
        public void UnregisterCaptureOverlayStateChangedListener()
        {
            this.mManager.UnregisterCaptureOverlayStateChangedListener();
        }
    
    }

}

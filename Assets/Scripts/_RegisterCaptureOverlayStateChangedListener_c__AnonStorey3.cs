using UnityEngine;
private sealed class NativeVideoClient.<RegisterCaptureOverlayStateChangedListener>c__AnonStorey3
{
    // Fields
    internal GooglePlayGames.BasicApi.Video.CaptureOverlayStateListener listener;
    
    // Methods
    public NativeVideoClient.<RegisterCaptureOverlayStateChangedListener>c__AnonStorey3()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.Cwrapper.Types.VideoCaptureOverlayState response)
    {
        var val_4;
        var val_5;
        val_4 = 0;
        GooglePlayGames.BasicApi.VideoCaptureOverlayState val_1 = GooglePlayGames.Native.ConversionUtils.ConvertNativeVideoCaptureOverlayState(nativeOverlayState:  0);
        var val_4 = 0;
        val_4 = val_4 + 1;
        val_4 = 0;
        val_5 = this.listener;
        GooglePlayGames.Native.PInvoke.AchievementManager.InternalFetchAllCallback(response:  new IntPtr(1152921512119765400), data:  this.listener);
        if((???) == 0)
        {
                return;
        }
    
    }

}

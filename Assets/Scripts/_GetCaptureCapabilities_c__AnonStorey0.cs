using UnityEngine;
private sealed class NativeVideoClient.<GetCaptureCapabilities>c__AnonStorey0
{
    // Fields
    internal System.Action<GooglePlayGames.BasicApi.ResponseStatus, GooglePlayGames.BasicApi.Video.VideoCapabilities> callback;
    internal GooglePlayGames.Native.NativeVideoClient $this;
    
    // Methods
    public NativeVideoClient.<GetCaptureCapabilities>c__AnonStorey0()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.GetCaptureCapabilitiesResponse response)
    {
        var val_8;
        GooglePlayGames.Native.NativeVideoClient val_9;
        GooglePlayGames.BasicApi.ResponseStatus val_10;
        GooglePlayGames.BasicApi.Video.VideoCapabilities val_11;
        var val_12;
        val_8 = response;
        val_9 = this;
        System.Runtime.InteropServices.HandleRef val_1 = val_8.SelfPtr();
        ResponseStatus val_2 = GooglePlayGames.Native.Cwrapper.VideoManager.VideoManager_GetCaptureCapabilitiesResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        GooglePlayGames.BasicApi.ResponseStatus val_3 = GooglePlayGames.Native.ConversionUtils.ConvertResponseStatus(status:  0);
        System.Runtime.InteropServices.HandleRef val_4 = val_8.SelfPtr();
        if((GooglePlayGames.Native.Cwrapper.VideoManager.VideoManager_GetCaptureCapabilitiesResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_4.wrapper})) > 0)
        {
                val_9 = this.$this;
            val_8 = val_9.FromNativeVideoCapabilities(capabilities:  val_8.GetData());
            val_10 = val_3;
            val_11 = val_8;
            val_12 = public System.Void System.Action<GooglePlayGames.BasicApi.ResponseStatus, GooglePlayGames.BasicApi.Video.VideoCapabilities>::Invoke(GooglePlayGames.BasicApi.ResponseStatus arg1, GooglePlayGames.BasicApi.Video.VideoCapabilities arg2);
        }
        else
        {
                val_11 = 0;
            val_10 = val_3;
            val_12 = public System.Void System.Action<GooglePlayGames.BasicApi.ResponseStatus, GooglePlayGames.BasicApi.Video.VideoCapabilities>::Invoke(GooglePlayGames.BasicApi.ResponseStatus arg1, GooglePlayGames.BasicApi.Video.VideoCapabilities arg2);
        }
        
        this.callback.Invoke(arg1:  val_10, arg2:  val_11);
    }

}

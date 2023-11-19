using UnityEngine;
private sealed class NativeVideoClient.<IsCaptureAvailable>c__AnonStorey2
{
    // Fields
    internal System.Action<GooglePlayGames.BasicApi.ResponseStatus, bool> callback;
    
    // Methods
    public NativeVideoClient.<IsCaptureAvailable>c__AnonStorey2()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse response)
    {
        var val_9;
        var val_10;
        var val_11;
        val_9 = response;
        System.Runtime.InteropServices.HandleRef val_1 = val_9.SelfPtr();
        ResponseStatus val_2 = GooglePlayGames.Native.Cwrapper.VideoManager.VideoManager_IsCaptureAvailableResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        System.Runtime.InteropServices.HandleRef val_4 = val_9.SelfPtr();
        if((GooglePlayGames.Native.Cwrapper.VideoManager.VideoManager_IsCaptureAvailableResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_4.wrapper})) > 0)
        {
                System.Runtime.InteropServices.HandleRef val_6 = val_9.SelfPtr();
            val_9 = GooglePlayGames.Native.Cwrapper.VideoManager.VideoManager_IsCaptureAvailableResponse_GetIsCaptureAvailable(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_6.wrapper});
            val_10 = val_9;
            val_11 = public System.Void System.Action<GooglePlayGames.BasicApi.ResponseStatus, System.Boolean>::Invoke(GooglePlayGames.BasicApi.ResponseStatus arg1, System.Boolean arg2);
        }
        else
        {
                val_10 = 0;
            val_11 = public System.Void System.Action<GooglePlayGames.BasicApi.ResponseStatus, System.Boolean>::Invoke(GooglePlayGames.BasicApi.ResponseStatus arg1, System.Boolean arg2);
        }
        
        this.callback.Invoke(arg1:  GooglePlayGames.Native.ConversionUtils.ConvertResponseStatus(status:  0), arg2:  false);
    }

}

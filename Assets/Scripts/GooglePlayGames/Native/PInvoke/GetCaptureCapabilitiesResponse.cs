using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class GetCaptureCapabilitiesResponse : BaseReferenceHolder
    {
        // Methods
        internal GetCaptureCapabilitiesResponse(IntPtr selfPointer)
        {
        
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.VideoManager.VideoManager_GetCaptureCapabilitiesResponse_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus GetStatus()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.VideoManager.VideoManager_GetCaptureCapabilitiesResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal bool RequestSucceeded()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return (bool)((GooglePlayGames.Native.Cwrapper.VideoManager.VideoManager_GetCaptureCapabilitiesResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper})) > 0) ? 1 : 0;
        }
        internal GooglePlayGames.Native.PInvoke.NativeVideoCapabilities GetData()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.PInvoke.NativeVideoCapabilities.FromPointer(pointer:  GooglePlayGames.Native.Cwrapper.VideoManager.VideoManager_GetCaptureCapabilitiesResponse_GetVideoCapabilities(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}));
        }
        internal static GooglePlayGames.Native.PInvoke.GetCaptureCapabilitiesResponse FromPointer(IntPtr pointer)
        {
            var val_2;
            val_2 = 0;
            if((0 & 1) != 0)
            {
                    return (GooglePlayGames.Native.PInvoke.GetCaptureCapabilitiesResponse)val_2;
            }
            
            GooglePlayGames.Native.PInvoke.GetCaptureCapabilitiesResponse val_1 = null;
            val_2 = val_1;
            val_1 = new GooglePlayGames.Native.PInvoke.GetCaptureCapabilitiesResponse(selfPointer:  ???);
            return (GooglePlayGames.Native.PInvoke.GetCaptureCapabilitiesResponse)val_2;
        }
    
    }

}

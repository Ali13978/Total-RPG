using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class GetCaptureStateResponse : BaseReferenceHolder
    {
        // Methods
        internal GetCaptureStateResponse(IntPtr selfPointer)
        {
        
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.VideoManager.VideoManager_GetCaptureStateResponse_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal GooglePlayGames.Native.PInvoke.NativeVideoCaptureState GetData()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.PInvoke.NativeVideoCaptureState.FromPointer(pointer:  GooglePlayGames.Native.Cwrapper.VideoManager.VideoManager_GetCaptureStateResponse_GetVideoCaptureState(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}));
        }
        internal GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus GetStatus()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.VideoManager.VideoManager_GetCaptureStateResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal bool RequestSucceeded()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return (bool)((GooglePlayGames.Native.Cwrapper.VideoManager.VideoManager_GetCaptureStateResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper})) > 0) ? 1 : 0;
        }
        internal static GooglePlayGames.Native.PInvoke.GetCaptureStateResponse FromPointer(IntPtr pointer)
        {
            var val_2;
            val_2 = 0;
            if((0 & 1) != 0)
            {
                    return (GooglePlayGames.Native.PInvoke.GetCaptureStateResponse)val_2;
            }
            
            GooglePlayGames.Native.PInvoke.GetCaptureStateResponse val_1 = null;
            val_2 = val_1;
            val_1 = new GooglePlayGames.Native.PInvoke.GetCaptureStateResponse(selfPointer:  ???);
            return (GooglePlayGames.Native.PInvoke.GetCaptureStateResponse)val_2;
        }
    
    }

}

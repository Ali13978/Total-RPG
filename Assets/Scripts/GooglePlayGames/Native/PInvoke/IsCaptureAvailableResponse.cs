using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class IsCaptureAvailableResponse : BaseReferenceHolder
    {
        // Methods
        internal IsCaptureAvailableResponse(IntPtr selfPointer)
        {
        
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.VideoManager.VideoManager_IsCaptureAvailableResponse_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
        internal GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus GetStatus()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.VideoManager.VideoManager_IsCaptureAvailableResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal bool RequestSucceeded()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return (bool)((GooglePlayGames.Native.Cwrapper.VideoManager.VideoManager_IsCaptureAvailableResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper})) > 0) ? 1 : 0;
        }
        internal bool IsCaptureAvailable()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.VideoManager.VideoManager_IsCaptureAvailableResponse_GetIsCaptureAvailable(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal static GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse FromPointer(IntPtr pointer)
        {
            var val_2;
            val_2 = 0;
            if((0 & 1) != 0)
            {
                    return (GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse)val_2;
            }
            
            GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse val_1 = null;
            val_2 = val_1;
            val_1 = new GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse(selfPointer:  ???);
            return (GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse)val_2;
        }
    
    }

}

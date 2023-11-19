using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class NativeVideoCaptureState : BaseReferenceHolder
    {
        // Methods
        internal NativeVideoCaptureState(IntPtr selfPtr)
        {
        
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.VideoCaptureState.VideoCaptureState_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
        internal bool IsCapturing()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.VideoCaptureState.VideoCaptureState_IsCapturing(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal GooglePlayGames.Native.Cwrapper.Types.VideoCaptureMode CaptureMode()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.VideoCaptureState.VideoCaptureState_CaptureMode(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal GooglePlayGames.Native.Cwrapper.Types.VideoQualityLevel QualityLevel()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.VideoCaptureState.VideoCaptureState_QualityLevel(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal bool IsOverlayVisible()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.VideoCaptureState.VideoCaptureState_IsOverlayVisible(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal bool IsPaused()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.VideoCaptureState.VideoCaptureState_IsPaused(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal static GooglePlayGames.Native.PInvoke.NativeVideoCaptureState FromPointer(IntPtr pointer)
        {
            var val_2;
            val_2 = 0;
            if((0 & 1) != 0)
            {
                    return (GooglePlayGames.Native.PInvoke.NativeVideoCaptureState)val_2;
            }
            
            GooglePlayGames.Native.PInvoke.NativeVideoCaptureState val_1 = null;
            val_2 = val_1;
            val_1 = new GooglePlayGames.Native.PInvoke.NativeVideoCaptureState(selfPtr:  ???);
            return (GooglePlayGames.Native.PInvoke.NativeVideoCaptureState)val_2;
        }
    
    }

}

using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class NativeVideoCapabilities : BaseReferenceHolder
    {
        // Methods
        internal NativeVideoCapabilities(IntPtr selfPtr)
        {
        
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.VideoCapabilities.VideoCapabilities_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
        internal bool IsCameraSupported()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.VideoCapabilities.VideoCapabilities_IsCameraSupported(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal bool IsMicSupported()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.VideoCapabilities.VideoCapabilities_IsMicSupported(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal bool IsWriteStorageSupported()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.VideoCapabilities.VideoCapabilities_IsWriteStorageSupported(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal bool SupportsCaptureMode(GooglePlayGames.Native.Cwrapper.Types.VideoCaptureMode captureMode)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.VideoCapabilities.VideoCapabilities_SupportsCaptureMode(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, capture_mode:  val_1.handle);
        }
        internal bool SupportsQualityLevel(GooglePlayGames.Native.Cwrapper.Types.VideoQualityLevel qualityLevel)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.VideoCapabilities.VideoCapabilities_SupportsQualityLevel(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, quality_level:  val_1.handle);
        }
        internal static GooglePlayGames.Native.PInvoke.NativeVideoCapabilities FromPointer(IntPtr pointer)
        {
            var val_2;
            val_2 = 0;
            if((0 & 1) != 0)
            {
                    return (GooglePlayGames.Native.PInvoke.NativeVideoCapabilities)val_2;
            }
            
            GooglePlayGames.Native.PInvoke.NativeVideoCapabilities val_1 = null;
            val_2 = val_1;
            val_1 = new GooglePlayGames.Native.PInvoke.NativeVideoCapabilities(selfPtr:  ???);
            return (GooglePlayGames.Native.PInvoke.NativeVideoCapabilities)val_2;
        }
    
    }

}

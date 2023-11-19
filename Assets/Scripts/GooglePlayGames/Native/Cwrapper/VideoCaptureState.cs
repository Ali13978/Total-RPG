using UnityEngine;

namespace GooglePlayGames.Native.Cwrapper
{
    internal static class VideoCaptureState
    {
        // Methods
        internal static extern bool VideoCaptureState_IsCapturing(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (bool)(X2 != 255) ? 1 : 0;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.Types.VideoCaptureMode VideoCaptureState_CaptureMode(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (VideoCaptureMode)X2;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.Types.VideoQualityLevel VideoCaptureState_QualityLevel(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (VideoQualityLevel)X2;
            }
        
        }
        internal static extern bool VideoCaptureState_IsOverlayVisible(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (bool)(X2 != 255) ? 1 : 0;
            }
        
        }
        internal static extern bool VideoCaptureState_IsPaused(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (bool)(X2 != 255) ? 1 : 0;
            }
        
        }
        internal static extern void VideoCaptureState_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern bool VideoCaptureState_Valid(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (bool)(X2 != 255) ? 1 : 0;
            }
        
        }
    
    }

}

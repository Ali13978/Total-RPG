using UnityEngine;

namespace GooglePlayGames.Native.Cwrapper
{
    internal static class VideoManager
    {
        // Methods
        internal static extern void VideoManager_GetCaptureCapabilities(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.VideoManager.CaptureCapabilitiesCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void VideoManager_ShowCaptureOverlay(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void VideoManager_GetCaptureState(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.VideoManager.CaptureStateCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void VideoManager_IsCaptureAvailable(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.Types.VideoCaptureMode capture_mode, GooglePlayGames.Native.Cwrapper.VideoManager.IsCaptureAvailableCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern bool VideoManager_IsCaptureSupported(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (bool)(X2 != 255) ? 1 : 0;
            }
        
        }
        internal static extern void VideoManager_RegisterCaptureOverlayStateChangedListener(System.Runtime.InteropServices.HandleRef self, IntPtr helper)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void VideoManager_UnregisterCaptureOverlayStateChangedListener(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void VideoManager_GetCaptureCapabilitiesResponse_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus VideoManager_GetCaptureCapabilitiesResponse_GetStatus(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (ResponseStatus)X2;
            }
        
        }
        internal static extern IntPtr VideoManager_GetCaptureCapabilitiesResponse_GetVideoCapabilities(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)X2;
            }
        
        }
        internal static extern void VideoManager_GetCaptureStateResponse_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus VideoManager_GetCaptureStateResponse_GetStatus(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (ResponseStatus)X2;
            }
        
        }
        internal static extern IntPtr VideoManager_GetCaptureStateResponse_GetVideoCaptureState(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)X2;
            }
        
        }
        internal static extern void VideoManager_IsCaptureAvailableResponse_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus VideoManager_IsCaptureAvailableResponse_GetStatus(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (ResponseStatus)X2;
            }
        
        }
        internal static extern bool VideoManager_IsCaptureAvailableResponse_GetIsCaptureAvailable(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (bool)(X2 != 255) ? 1 : 0;
            }
        
        }
    
    }

}

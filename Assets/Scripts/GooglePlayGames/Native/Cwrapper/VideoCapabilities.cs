using UnityEngine;

namespace GooglePlayGames.Native.Cwrapper
{
    internal static class VideoCapabilities
    {
        // Methods
        internal static extern bool VideoCapabilities_IsCameraSupported(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (bool)(X2 != 255) ? 1 : 0;
            }
        
        }
        internal static extern bool VideoCapabilities_IsMicSupported(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (bool)(X2 != 255) ? 1 : 0;
            }
        
        }
        internal static extern bool VideoCapabilities_IsWriteStorageSupported(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (bool)(X2 != 255) ? 1 : 0;
            }
        
        }
        internal static extern bool VideoCapabilities_SupportsCaptureMode(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.Types.VideoCaptureMode capture_mode)
        {
            if(25808612 != 0)
            {
                    return (bool)(capture_mode != 255) ? 1 : 0;
            }
        
        }
        internal static extern bool VideoCapabilities_SupportsQualityLevel(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.Types.VideoQualityLevel quality_level)
        {
            if(25808612 != 0)
            {
                    return (bool)(quality_level != 255) ? 1 : 0;
            }
        
        }
        internal static extern void VideoCapabilities_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern bool VideoCapabilities_Valid(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (bool)(X2 != 255) ? 1 : 0;
            }
        
        }
    
    }

}

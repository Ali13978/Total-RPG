using UnityEngine;

namespace GooglePlayGames.Native
{
    internal static class ConversionUtils
    {
        // Methods
        internal static GooglePlayGames.BasicApi.ResponseStatus ConvertResponseStatus(GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus status)
        {
            var val_3 = ((W1 + 5) < 8) ? (W1 + 8) : 0;
            val_3 = val_3 - 3;
            if(val_3 <= 7)
            {
                    var val_6 = 25822344 + ((val_1 < 0x8 ? (W1 + 8) : 0 - 3)) << 2;
                val_6 = val_6 + 25822344;
            }
            else
            {
                    System.InvalidOperationException val_5 = new System.InvalidOperationException(message:  0 + "Unknown status: "("Unknown status: "));
            }
        
        }
        internal static GooglePlayGames.BasicApi.CommonStatusCodes ConvertResponseStatusToCommonStatus(GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus status)
        {
            object val_5;
            var val_6;
            val_5 = W1;
            var val_3 = ((val_5 + 5) < 8) ? (val_5 + 8) : 0;
            val_3 = val_3 - 3;
            if(val_3 <= 7)
            {
                    var val_5 = 25822376 + ((val_1 < 0x8 ? (W1 + 8) : 0 - 3)) << 2;
                val_5 = val_5 + 25822376;
            }
            else
            {
                    val_5 = 0 + "Unknown ResponseStatus: "("Unknown ResponseStatus: ") + val_5;
                UnityEngine.Debug.LogWarning(message:  0);
                val_6 = 13;
                return (GooglePlayGames.BasicApi.CommonStatusCodes);
            }
        
        }
        internal static GooglePlayGames.BasicApi.UIStatus ConvertUIStatus(GooglePlayGames.Native.Cwrapper.CommonErrorStatus.UIStatus status)
        {
            var val_4;
            if((W1 + 6) > 7)
            {
                goto label_1;
            }
            
            var val_4 = 25834928 + ((W1 + 6)) << 2;
            val_4 = val_4 - 3;
            if(val_4 > 6)
            {
                goto label_4;
            }
            
            var val_5 = 25822408 + ((25834928 + ((W1 + 6)) << 2 - 3)) << 2;
            val_5 = val_5 + 25822408;
            goto (25822408 + ((25834928 + ((W1 + 6)) << 2 - 3)) << 2 + 25822408);
            label_1:
            if(W1 == 12)
            {
                    val_4 = 11;
                return (GooglePlayGames.BasicApi.UIStatus)val_4;
            }
            
            label_4:
            System.InvalidOperationException val_3 = new System.InvalidOperationException(message:  0 + "Unknown status: "("Unknown status: "));
        }
        internal static GooglePlayGames.Native.Cwrapper.Types.DataSource AsDataSource(GooglePlayGames.BasicApi.DataSource source)
        {
            var val_3;
            if(W1 == 0)
            {
                goto label_1;
            }
            
            if(W1 != 1)
            {
                goto label_2;
            }
            
            val_3 = 2;
            return (DataSource)val_3;
            label_1:
            val_3 = 1;
            return (DataSource)val_3;
            label_2:
            System.InvalidOperationException val_2 = new System.InvalidOperationException(message:  0 + "Found unhandled DataSource: "("Found unhandled DataSource: "));
        }
        internal static GooglePlayGames.Native.Cwrapper.Types.VideoCaptureMode ConvertVideoCaptureMode(GooglePlayGames.BasicApi.VideoCaptureMode captureMode)
        {
            object val_5;
            var val_6;
            val_5 = W1;
            var val_3 = ((val_5 + 1) < 3) ? (val_5 + 4) : 0;
            if(val_3 != 3)
            {
                    val_6 = 0;
                if(val_3 == 4)
            {
                    return (VideoCaptureMode)val_6;
            }
            
                if(val_3 == 5)
            {
                    val_6 = 1;
                return (VideoCaptureMode)val_6;
            }
            
                val_5 = 0 + "Unknown VideoCaptureMode: "("Unknown VideoCaptureMode: ") + val_5;
                UnityEngine.Debug.LogWarning(message:  0);
            }
            
            val_6 = 0;
            return (VideoCaptureMode)val_6;
        }
        internal static GooglePlayGames.BasicApi.VideoCaptureMode ConvertNativeVideoCaptureMode(GooglePlayGames.Native.Cwrapper.Types.VideoCaptureMode nativeCaptureMode)
        {
            object val_5;
            var val_6;
            val_5 = W1;
            var val_3 = ((val_5 + 1) < 3) ? (val_5 + 4) : 0;
            if(val_3 != 3)
            {
                    val_6 = 0;
                if(val_3 == 4)
            {
                    return (GooglePlayGames.BasicApi.VideoCaptureMode)val_6;
            }
            
                if(val_3 == 5)
            {
                    val_6 = 1;
                return (GooglePlayGames.BasicApi.VideoCaptureMode)val_6;
            }
            
                val_5 = 0 + "Unknown Types.VideoCaptureMode: "("Unknown Types.VideoCaptureMode: ") + val_5;
                UnityEngine.Debug.LogWarning(message:  0);
            }
            
            val_6 = 0;
            return (GooglePlayGames.BasicApi.VideoCaptureMode)val_6;
        }
        internal static GooglePlayGames.BasicApi.VideoQualityLevel ConvertNativeVideoQualityLevel(GooglePlayGames.Native.Cwrapper.Types.VideoQualityLevel nativeQualityLevel)
        {
            object val_5;
            var val_6;
            val_5 = W1;
            var val_3 = ((val_5 + 1) < 5) ? (val_5 + 4) : 0;
            val_3 = val_3 - 3;
            if(val_3 <= 4)
            {
                    var val_5 = 25822436 + ((val_1 < 0x5 ? (W1 + 4) : 0 - 3)) << 2;
                val_5 = val_5 + 25822436;
            }
            else
            {
                    val_5 = 0 + "Unknown Types.VideoQualityLevel: "("Unknown Types.VideoQualityLevel: ") + val_5;
                UnityEngine.Debug.LogWarning(message:  0);
                val_6 = 0;
                return (GooglePlayGames.BasicApi.VideoQualityLevel);
            }
        
        }
        internal static GooglePlayGames.BasicApi.VideoCaptureOverlayState ConvertNativeVideoCaptureOverlayState(GooglePlayGames.Native.Cwrapper.Types.VideoCaptureOverlayState nativeOverlayState)
        {
            object val_5;
            var val_6;
            val_5 = W1;
            var val_3 = ((val_5 + 1) < 6) ? (val_5 + 4) : 0;
            val_3 = val_3 - 3;
            if(val_3 <= 5)
            {
                    var val_5 = 25822456 + ((val_1 < 0x6 ? (W1 + 4) : 0 - 3)) << 2;
                val_5 = val_5 + 25822456;
            }
            else
            {
                    val_5 = 0 + "Unknown Types.VideoCaptureOverlayState: "("Unknown Types.VideoCaptureOverlayState: ") + val_5;
                UnityEngine.Debug.LogWarning(message:  0);
                val_6 = 0;
                return (GooglePlayGames.BasicApi.VideoCaptureOverlayState);
            }
        
        }
    
    }

}

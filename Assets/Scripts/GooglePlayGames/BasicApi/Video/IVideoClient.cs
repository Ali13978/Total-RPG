using UnityEngine;

namespace GooglePlayGames.BasicApi.Video
{
    public interface IVideoClient
    {
        // Methods
        public abstract void GetCaptureCapabilities(System.Action<GooglePlayGames.BasicApi.ResponseStatus, GooglePlayGames.BasicApi.Video.VideoCapabilities> callback); // 0
        public abstract void ShowCaptureOverlay(); // 0
        public abstract void GetCaptureState(System.Action<GooglePlayGames.BasicApi.ResponseStatus, GooglePlayGames.BasicApi.Video.VideoCaptureState> callback); // 0
        public abstract void IsCaptureAvailable(GooglePlayGames.BasicApi.VideoCaptureMode captureMode, System.Action<GooglePlayGames.BasicApi.ResponseStatus, bool> callback); // 0
        public abstract bool IsCaptureSupported(); // 0
        public abstract void RegisterCaptureOverlayStateChangedListener(GooglePlayGames.BasicApi.Video.CaptureOverlayStateListener listener); // 0
        public abstract void UnregisterCaptureOverlayStateChangedListener(); // 0
    
    }

}

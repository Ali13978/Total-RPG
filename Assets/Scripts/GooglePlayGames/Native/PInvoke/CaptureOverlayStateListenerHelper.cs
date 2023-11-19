using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class CaptureOverlayStateListenerHelper : BaseReferenceHolder
    {
        // Fields
        private static GooglePlayGames.Native.Cwrapper.CaptureOverlayStateListenerHelper.OnCaptureOverlayStateChangedCallback <>f__mg$cache0;
        
        // Methods
        internal CaptureOverlayStateListenerHelper(IntPtr selfPointer)
        {
        
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.CaptureOverlayStateListenerHelper.CaptureOverlayStateListenerHelper_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
        internal GooglePlayGames.Native.PInvoke.CaptureOverlayStateListenerHelper SetOnCaptureOverlayStateChangedCallback(System.Action<GooglePlayGames.Native.Cwrapper.Types.VideoCaptureOverlayState> callback)
        {
            CaptureOverlayStateListenerHelper.OnCaptureOverlayStateChangedCallback val_4;
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            val_4 = GooglePlayGames.Native.PInvoke.CaptureOverlayStateListenerHelper.<>f__mg$cache0;
            if(val_4 == null)
            {
                    GooglePlayGames.Native.PInvoke.CaptureOverlayStateListenerHelper.<>f__mg$cache0 = new CaptureOverlayStateListenerHelper.OnCaptureOverlayStateChangedCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.CaptureOverlayStateListenerHelper::InternalOnCaptureOverlayStateChangedCallback(GooglePlayGames.Native.Cwrapper.Types.VideoCaptureOverlayState response, IntPtr data));
                val_4 = GooglePlayGames.Native.PInvoke.CaptureOverlayStateListenerHelper.<>f__mg$cache0;
            }
            
            IntPtr val_3 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr(callback:  null);
            GooglePlayGames.Native.Cwrapper.CaptureOverlayStateListenerHelper.CaptureOverlayStateListenerHelper_SetOnCaptureOverlayStateChangedCallback(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, callback:  val_1.handle, callback_arg:  val_4);
            return (GooglePlayGames.Native.PInvoke.CaptureOverlayStateListenerHelper)this;
        }
        [AOT.MonoPInvokeCallbackAttribute]
        internal static void InternalOnCaptureOverlayStateChangedCallback(GooglePlayGames.Native.Cwrapper.Types.VideoCaptureOverlayState response, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.IntPtrToPermanentCallback<System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom, GooglePlayGames.Native.PInvoke.MultiplayerParticipant, System.Byte[], System.Boolean>>(handle:  0).Invoke(obj:  data);
        }
        internal static GooglePlayGames.Native.PInvoke.CaptureOverlayStateListenerHelper Create()
        {
            return (GooglePlayGames.Native.PInvoke.CaptureOverlayStateListenerHelper)new GooglePlayGames.Native.PInvoke.CaptureOverlayStateListenerHelper(selfPointer:  GooglePlayGames.Native.Cwrapper.CaptureOverlayStateListenerHelper.CaptureOverlayStateListenerHelper_Construct());
        }
    
    }

}

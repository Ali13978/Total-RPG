using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class NativeEndpointDiscoveryListenerHelper : BaseReferenceHolder
    {
        // Fields
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.NativeEndpointDetails> <>f__mg$cache0;
        private static GooglePlayGames.Native.Cwrapper.EndpointDiscoveryListenerHelper.OnEndpointFoundCallback <>f__mg$cache1;
        private static GooglePlayGames.Native.Cwrapper.EndpointDiscoveryListenerHelper.OnEndpointLostCallback <>f__mg$cache2;
        
        // Methods
        internal NativeEndpointDiscoveryListenerHelper()
        {
            IntPtr val_1 = GooglePlayGames.Native.Cwrapper.EndpointDiscoveryListenerHelper.EndpointDiscoveryListenerHelper_Construct();
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.EndpointDiscoveryListenerHelper.EndpointDiscoveryListenerHelper_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
        internal void SetOnEndpointFound(System.Action<long, GooglePlayGames.Native.PInvoke.NativeEndpointDetails> callback)
        {
            var val_5;
            EndpointDiscoveryListenerHelper.OnEndpointFoundCallback val_7;
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            val_5 = null;
            val_7 = GooglePlayGames.Native.PInvoke.NativeEndpointDiscoveryListenerHelper.<>f__mg$cache1;
            if(val_7 == null)
            {
                    GooglePlayGames.Native.PInvoke.NativeEndpointDiscoveryListenerHelper.<>f__mg$cache1 = new EndpointDiscoveryListenerHelper.OnEndpointFoundCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.NativeEndpointDiscoveryListenerHelper::InternalOnEndpointFoundCallback(long id, IntPtr data, IntPtr userData));
                val_5 = null;
                val_7 = GooglePlayGames.Native.PInvoke.NativeEndpointDiscoveryListenerHelper.<>f__mg$cache1;
            }
            
            if(GooglePlayGames.Native.PInvoke.NativeEndpointDiscoveryListenerHelper.__il2cppRuntimeField_static_fields == null)
            {
                    GooglePlayGames.Native.PInvoke.NativeEndpointDiscoveryListenerHelper.<>f__mg$cache0 = new System.Func<System.IntPtr, GooglePlayGames.Native.PInvoke.NativeEndpointDetails>(object:  0, method:  static GooglePlayGames.Native.PInvoke.NativeEndpointDetails GooglePlayGames.Native.PInvoke.NativeEndpointDetails::FromPointer(IntPtr pointer));
                val_5 = null;
            }
            
            IntPtr val_4 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<System.Int64, System.Object>(callback:  0, conversionFunction:  callback);
            GooglePlayGames.Native.Cwrapper.EndpointDiscoveryListenerHelper.EndpointDiscoveryListenerHelper_SetOnEndpointFoundCallback(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, callback:  val_1.handle, callback_arg:  val_7);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        private static void InternalOnEndpointFoundCallback(long id, IntPtr data, IntPtr userData)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback<System.Int64>(callbackName:  0, callbackType:  "NativeEndpointDiscoveryListenerHelper#InternalOnEndpointFoundCallback", param1:  0, param2:  data, userData:  userData);
        }
        internal void SetOnEndpointLostCallback(System.Action<long, string> callback)
        {
            EndpointDiscoveryListenerHelper.OnEndpointLostCallback val_4;
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            val_4 = GooglePlayGames.Native.PInvoke.NativeEndpointDiscoveryListenerHelper.<>f__mg$cache2;
            if(val_4 == null)
            {
                    GooglePlayGames.Native.PInvoke.NativeEndpointDiscoveryListenerHelper.<>f__mg$cache2 = new EndpointDiscoveryListenerHelper.OnEndpointLostCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.NativeEndpointDiscoveryListenerHelper::InternalOnEndpointLostCallback(long id, string lostEndpointId, IntPtr userData));
                val_4 = GooglePlayGames.Native.PInvoke.NativeEndpointDiscoveryListenerHelper.<>f__mg$cache2;
            }
            
            IntPtr val_3 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr(callback:  null);
            GooglePlayGames.Native.Cwrapper.EndpointDiscoveryListenerHelper.EndpointDiscoveryListenerHelper_SetOnEndpointLostCallback(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, callback:  val_1.handle, callback_arg:  val_4);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        private static void InternalOnEndpointLostCallback(long id, string lostEndpointId, IntPtr userData)
        {
            System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom, GooglePlayGames.Native.PInvoke.MultiplayerParticipant, System.Byte[], System.Boolean> val_1 = GooglePlayGames.Native.PInvoke.Callbacks.IntPtrToPermanentCallback<System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom, GooglePlayGames.Native.PInvoke.MultiplayerParticipant, System.Byte[], System.Boolean>>(handle:  0);
            if(val_1 == null)
            {
                    return;
            }
            
            val_1.Invoke(arg1:  lostEndpointId, arg2:  userData);
        }
    
    }

}

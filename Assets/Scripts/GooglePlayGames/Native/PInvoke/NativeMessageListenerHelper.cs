using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class NativeMessageListenerHelper : BaseReferenceHolder
    {
        // Fields
        private static GooglePlayGames.Native.Cwrapper.MessageListenerHelper.OnMessageReceivedCallback <>f__mg$cache0;
        private static GooglePlayGames.Native.Cwrapper.MessageListenerHelper.OnDisconnectedCallback <>f__mg$cache1;
        
        // Methods
        internal NativeMessageListenerHelper()
        {
            IntPtr val_1 = GooglePlayGames.Native.Cwrapper.MessageListenerHelper.MessageListenerHelper_Construct();
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.MessageListenerHelper.MessageListenerHelper_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
        internal void SetOnMessageReceivedCallback(GooglePlayGames.Native.PInvoke.NativeMessageListenerHelper.OnMessageReceived callback)
        {
            MessageListenerHelper.OnMessageReceivedCallback val_4;
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            val_4 = GooglePlayGames.Native.PInvoke.NativeMessageListenerHelper.<>f__mg$cache0;
            if(val_4 == null)
            {
                    GooglePlayGames.Native.PInvoke.NativeMessageListenerHelper.<>f__mg$cache0 = new MessageListenerHelper.OnMessageReceivedCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.NativeMessageListenerHelper::InternalOnMessageReceivedCallback(long id, string name, IntPtr data, UIntPtr dataLength, bool isReliable, IntPtr userData));
                val_4 = GooglePlayGames.Native.PInvoke.NativeMessageListenerHelper.<>f__mg$cache0;
            }
            
            IntPtr val_3 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr(callback:  null);
            GooglePlayGames.Native.Cwrapper.MessageListenerHelper.MessageListenerHelper_SetOnMessageReceivedCallback(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, callback:  val_1.handle, callback_arg:  val_4);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        private static void InternalOnMessageReceivedCallback(long id, string name, IntPtr data, UIntPtr dataLength, bool isReliable, IntPtr userData)
        {
            System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom, GooglePlayGames.Native.PInvoke.MultiplayerParticipant, System.Byte[], System.Boolean> val_1 = GooglePlayGames.Native.PInvoke.Callbacks.IntPtrToPermanentCallback<System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom, GooglePlayGames.Native.PInvoke.MultiplayerParticipant, System.Byte[], System.Boolean>>(handle:  0);
            if(val_1 == null)
            {
                    return;
            }
            
            val_1.Invoke(localClientId:  name, remoteEndpointId:  data, data:  GooglePlayGames.Native.PInvoke.Callbacks.IntPtrAndSizeToByteArray(data:  null, dataLength:  dataLength), isReliable:  userData & 1);
        }
        internal void SetOnDisconnectedCallback(System.Action<long, string> callback)
        {
            MessageListenerHelper.OnDisconnectedCallback val_4;
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            val_4 = GooglePlayGames.Native.PInvoke.NativeMessageListenerHelper.<>f__mg$cache1;
            if(val_4 == null)
            {
                    GooglePlayGames.Native.PInvoke.NativeMessageListenerHelper.<>f__mg$cache1 = new MessageListenerHelper.OnDisconnectedCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.NativeMessageListenerHelper::InternalOnDisconnectedCallback(long id, string lostEndpointId, IntPtr userData));
                val_4 = GooglePlayGames.Native.PInvoke.NativeMessageListenerHelper.<>f__mg$cache1;
            }
            
            IntPtr val_3 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr(callback:  null);
            GooglePlayGames.Native.Cwrapper.MessageListenerHelper.MessageListenerHelper_SetOnDisconnectedCallback(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, callback:  val_1.handle, callback_arg:  val_4);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        private static void InternalOnDisconnectedCallback(long id, string lostEndpointId, IntPtr userData)
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

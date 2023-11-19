using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class RealTimeEventListenerHelper : BaseReferenceHolder
    {
        // Fields
        private static GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.OnRoomStatusChangedCallback <>f__mg$cache0;
        private static GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.OnRoomConnectedSetChangedCallback <>f__mg$cache1;
        private static GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.OnP2PConnectedCallback <>f__mg$cache2;
        private static GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.OnP2PDisconnectedCallback <>f__mg$cache3;
        private static GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.OnParticipantStatusChangedCallback <>f__mg$cache4;
        private static GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.OnDataReceivedCallback <>f__mg$cache5;
        
        // Methods
        internal RealTimeEventListenerHelper(IntPtr selfPointer)
        {
        
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.RealTimeEventListenerHelper_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
        internal GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper SetOnRoomStatusChangedCallback(System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom> callback)
        {
            RealTimeEventListenerHelper.OnRoomStatusChangedCallback val_4;
            RealTimeEventListenerHelper.OnRoomStatusChangedCallback val_5;
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            val_5 = GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper.<>f__mg$cache0;
            if(val_5 == null)
            {
                    val_4 = null;
                val_4 = new RealTimeEventListenerHelper.OnRoomStatusChangedCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper::InternalOnRoomStatusChangedCallback(IntPtr response, IntPtr data));
                GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper.<>f__mg$cache0 = val_4;
                val_5 = GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper.<>f__mg$cache0;
            }
            
            IntPtr val_2 = GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper.ToCallbackPointer(callback:  val_4);
            GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.RealTimeEventListenerHelper_SetOnRoomStatusChangedCallback(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, callback:  val_1.handle, callback_arg:  val_5);
            return (GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper)this;
        }
        [AOT.MonoPInvokeCallbackAttribute]
        internal static void InternalOnRoomStatusChangedCallback(IntPtr response, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback(callbackName:  0, callbackType:  "RealTimeEventListenerHelper#InternalOnRoomStatusChangedCallback", response:  0, userData:  data);
        }
        internal GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper SetOnRoomConnectedSetChangedCallback(System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom> callback)
        {
            RealTimeEventListenerHelper.OnRoomConnectedSetChangedCallback val_4;
            RealTimeEventListenerHelper.OnRoomConnectedSetChangedCallback val_5;
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            val_5 = GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper.<>f__mg$cache1;
            if(val_5 == null)
            {
                    val_4 = null;
                val_4 = new RealTimeEventListenerHelper.OnRoomConnectedSetChangedCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper::InternalOnRoomConnectedSetChangedCallback(IntPtr response, IntPtr data));
                GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper.<>f__mg$cache1 = val_4;
                val_5 = GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper.<>f__mg$cache1;
            }
            
            IntPtr val_2 = GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper.ToCallbackPointer(callback:  val_4);
            GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.RealTimeEventListenerHelper_SetOnRoomConnectedSetChangedCallback(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, callback:  val_1.handle, callback_arg:  val_5);
            return (GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper)this;
        }
        [AOT.MonoPInvokeCallbackAttribute]
        internal static void InternalOnRoomConnectedSetChangedCallback(IntPtr response, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback(callbackName:  0, callbackType:  "RealTimeEventListenerHelper#InternalOnRoomConnectedSetChangedCallback", response:  0, userData:  data);
        }
        internal GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper SetOnP2PConnectedCallback(System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom, GooglePlayGames.Native.PInvoke.MultiplayerParticipant> callback)
        {
            RealTimeEventListenerHelper.OnP2PConnectedCallback val_4;
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            val_4 = GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper.<>f__mg$cache2;
            if(val_4 == null)
            {
                    GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper.<>f__mg$cache2 = new RealTimeEventListenerHelper.OnP2PConnectedCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper::InternalOnP2PConnectedCallback(IntPtr room, IntPtr participant, IntPtr data));
                val_4 = GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper.<>f__mg$cache2;
            }
            
            IntPtr val_3 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr(callback:  0);
            GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.RealTimeEventListenerHelper_SetOnP2PConnectedCallback(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, callback:  val_1.handle, callback_arg:  val_4);
            return (GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper)this;
        }
        [AOT.MonoPInvokeCallbackAttribute]
        internal static void InternalOnP2PConnectedCallback(IntPtr room, IntPtr participant, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper.PerformRoomAndParticipantCallback(callbackName:  21250, room:  "InternalOnP2PConnectedCallback", participant:  participant, data:  data);
        }
        internal GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper SetOnP2PDisconnectedCallback(System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom, GooglePlayGames.Native.PInvoke.MultiplayerParticipant> callback)
        {
            RealTimeEventListenerHelper.OnP2PDisconnectedCallback val_4;
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            val_4 = GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper.<>f__mg$cache3;
            if(val_4 == null)
            {
                    GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper.<>f__mg$cache3 = new RealTimeEventListenerHelper.OnP2PDisconnectedCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper::InternalOnP2PDisconnectedCallback(IntPtr room, IntPtr participant, IntPtr data));
                val_4 = GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper.<>f__mg$cache3;
            }
            
            IntPtr val_3 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr(callback:  0);
            GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.RealTimeEventListenerHelper_SetOnP2PDisconnectedCallback(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, callback:  val_1.handle, callback_arg:  val_4);
            return (GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper)this;
        }
        [AOT.MonoPInvokeCallbackAttribute]
        internal static void InternalOnP2PDisconnectedCallback(IntPtr room, IntPtr participant, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper.PerformRoomAndParticipantCallback(callbackName:  21251, room:  "InternalOnP2PDisconnectedCallback", participant:  participant, data:  data);
        }
        internal GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper SetOnParticipantStatusChangedCallback(System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom, GooglePlayGames.Native.PInvoke.MultiplayerParticipant> callback)
        {
            RealTimeEventListenerHelper.OnParticipantStatusChangedCallback val_4;
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            val_4 = GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper.<>f__mg$cache4;
            if(val_4 == null)
            {
                    GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper.<>f__mg$cache4 = new RealTimeEventListenerHelper.OnParticipantStatusChangedCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper::InternalOnParticipantStatusChangedCallback(IntPtr room, IntPtr participant, IntPtr data));
                val_4 = GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper.<>f__mg$cache4;
            }
            
            IntPtr val_3 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr(callback:  0);
            GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.RealTimeEventListenerHelper_SetOnParticipantStatusChangedCallback(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, callback:  val_1.handle, callback_arg:  val_4);
            return (GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper)this;
        }
        [AOT.MonoPInvokeCallbackAttribute]
        internal static void InternalOnParticipantStatusChangedCallback(IntPtr room, IntPtr participant, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper.PerformRoomAndParticipantCallback(callbackName:  21252, room:  "InternalOnParticipantStatusChangedCallback", participant:  participant, data:  data);
        }
        internal static void PerformRoomAndParticipantCallback(string callbackName, IntPtr room, IntPtr participant, IntPtr data)
        {
            string val_6;
            var val_7;
            string val_1 = 0 + "Entering ";
            val_6 = null;
            GooglePlayGames.OurUtils.Logger.d(msg:  val_6);
            GooglePlayGames.Native.PInvoke.MultiplayerParticipant val_3 = GooglePlayGames.Native.PInvoke.MultiplayerParticipant.FromPointer(pointer:  0);
            System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom, GooglePlayGames.Native.PInvoke.MultiplayerParticipant, System.Byte[], System.Boolean> val_4 = GooglePlayGames.Native.PInvoke.Callbacks.IntPtrToPermanentCallback<System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom, GooglePlayGames.Native.PInvoke.MultiplayerParticipant, System.Byte[], System.Boolean>>(handle:  0);
            if(val_4 != null)
            {
                    val_4.Invoke(arg1:  GooglePlayGames.Native.PInvoke.NativeRealTimeRoom.FromPointer(selfPointer:  0), arg2:  val_3);
            }
            
            if(val_3 != null)
            {
                    var val_6 = 0;
                val_6 = val_6 + 1;
                val_7 = val_3;
            }
            
            if(69 == 69)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        internal GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper SetOnDataReceivedCallback(System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom, GooglePlayGames.Native.PInvoke.MultiplayerParticipant, byte[], bool> callback)
        {
            string val_5;
            var val_6;
            IntPtr val_1 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr(callback:  0);
            string val_2 = 0 + "OnData Callback has addr: "("OnData Callback has addr: ");
            val_5 = null;
            GooglePlayGames.OurUtils.Logger.d(msg:  val_5);
            System.Runtime.InteropServices.HandleRef val_3 = this.SelfPtr();
            val_6 = null;
            if((GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper.<>f__mg$cache5) == null)
            {
                    GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper.<>f__mg$cache5 = new RealTimeEventListenerHelper.OnDataReceivedCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper::InternalOnDataReceived(IntPtr room, IntPtr participant, IntPtr data, UIntPtr dataLength, bool isReliable, IntPtr userData));
                val_6 = null;
            }
            
            GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.RealTimeEventListenerHelper_SetOnDataReceivedCallback(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_3.wrapper}, callback:  val_3.handle, callback_arg:  GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper.<>f__mg$cache5);
            return (GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper)this;
        }
        [AOT.MonoPInvokeCallbackAttribute]
        internal static void InternalOnDataReceived(IntPtr room, IntPtr participant, IntPtr data, UIntPtr dataLength, bool isReliable, IntPtr userData)
        {
            string val_11;
            System.Byte[] val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            string val_1 = 0 + "Entering InternalOnDataReceived: "("Entering InternalOnDataReceived: ");
            val_11 = null;
            GooglePlayGames.OurUtils.Logger.d(msg:  val_11);
            System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom, GooglePlayGames.Native.PInvoke.MultiplayerParticipant, System.Byte[], System.Boolean> val_2 = GooglePlayGames.Native.PInvoke.Callbacks.IntPtrToPermanentCallback<System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom, GooglePlayGames.Native.PInvoke.MultiplayerParticipant, System.Byte[], System.Boolean>>(handle:  0);
            GooglePlayGames.Native.PInvoke.NativeRealTimeRoom val_3 = GooglePlayGames.Native.PInvoke.NativeRealTimeRoom.FromPointer(selfPointer:  0);
            GooglePlayGames.Native.PInvoke.MultiplayerParticipant val_4 = GooglePlayGames.Native.PInvoke.MultiplayerParticipant.FromPointer(pointer:  0);
            if(val_2 == null)
            {
                goto label_9;
            }
            
            if(isReliable.InitializationCallback == null)
            {
                goto label_10;
            }
            
            GooglePlayGames.BasicApi.ResponseStatus val_6 = isReliable.Status;
            val_12 = null;
            GooglePlayGames.BasicApi.ResponseStatus val_7 = isReliable.Status;
            System.Runtime.InteropServices.Marshal.Copy(source:  0, destination:  dataLength, startIndex:  460851360, length:  0);
            goto label_13;
            label_9:
            val_13 = 0;
            val_14 = 181;
            goto label_14;
            label_10:
            val_12 = 0;
            label_13:
            val_2.Invoke(arg1:  val_3, arg2:  val_4, arg3:  val_12, arg4:  userData & 1);
            val_13 = 0;
            val_14 = 163;
            label_14:
            if(val_4 != null)
            {
                    var val_11 = 0;
                val_11 = val_11 + 1;
                val_15 = val_4;
            }
            
            val_16 = 181;
            if((163 != 163) && (163 != 181))
            {
                    val_13 = 0;
                val_16 = 181;
            }
            
            if(val_3 != null)
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                val_17 = val_3;
            }
            
            if(181 == 181)
            {
                    return;
            }
            
            if(val_13 == 0)
            {
                    return;
            }
        
        }
        private static IntPtr ToCallbackPointer(System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom> callback)
        {
            typeof(RealTimeEventListenerHelper.<ToCallbackPointer>c__AnonStorey0).__il2cppRuntimeField_10 = X1;
            System.Action<System.IntPtr> val_2 = new System.Action<System.IntPtr>(object:  new System.Object(), method:  System.Void RealTimeEventListenerHelper.<ToCallbackPointer>c__AnonStorey0::<>m__0(IntPtr result));
            return GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr(callback:  0);
        }
        internal static GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper Create()
        {
            return (GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper)new GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper(selfPointer:  GooglePlayGames.Native.Cwrapper.RealTimeEventListenerHelper.RealTimeEventListenerHelper_Construct());
        }
    
    }

}

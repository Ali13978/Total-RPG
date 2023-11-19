using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class NearbyConnectionsManager : BaseReferenceHolder
    {
        // Fields
        private static readonly string sServiceId;
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.NativeStartAdvertisingResult> <>f__mg$cache0;
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.NativeConnectionRequest> <>f__mg$cache1;
        private static GooglePlayGames.Native.Cwrapper.NearbyConnectionTypes.StartAdvertisingCallback <>f__mg$cache2;
        private static GooglePlayGames.Native.Cwrapper.NearbyConnectionTypes.ConnectionRequestCallback <>f__mg$cache3;
        private static System.Func<GooglePlayGames.Native.PInvoke.NativeAppIdentifier, IntPtr> <>f__am$cache0;
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.NativeConnectionResponse> <>f__mg$cache4;
        private static GooglePlayGames.Native.Cwrapper.NearbyConnectionTypes.ConnectionResponseCallback <>f__mg$cache5;
        
        // Properties
        public string AppBundleId { get; }
        public static string ServiceId { get; }
        
        // Methods
        internal NearbyConnectionsManager(IntPtr selfPointer)
        {
        
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.NearbyConnections.NearbyConnections_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
        internal void SendUnreliable(string remoteEndpointId, byte[] payload)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.NearbyConnections.NearbyConnections_SendUnreliableMessage(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, remote_endpoint_id:  val_1.handle, payload:  remoteEndpointId, payload_size:  payload);
        }
        internal void SendReliable(string remoteEndpointId, byte[] payload)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.NearbyConnections.NearbyConnections_SendReliableMessage(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, remote_endpoint_id:  val_1.handle, payload:  remoteEndpointId, payload_size:  payload);
        }
        internal void StartAdvertising(string name, System.Collections.Generic.List<GooglePlayGames.Native.PInvoke.NativeAppIdentifier> appIds, long advertisingDuration, System.Action<long, GooglePlayGames.Native.PInvoke.NativeStartAdvertisingResult> advertisingCallback, System.Action<long, GooglePlayGames.Native.PInvoke.NativeConnectionRequest> connectionRequestCallback)
        {
            System.Func<System.IntPtr, P> val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            string val_18;
            System.Func<System.IntPtr, P> val_19;
            var val_20;
            var val_21;
            UIntPtr val_22;
            IntPtr val_23;
            var val_24;
            val_12 = advertisingCallback;
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            val_13 = null;
            val_13 = null;
            if((GooglePlayGames.Native.PInvoke.NearbyConnectionsManager.<>f__am$cache0) == null)
            {
                    val_14 = null;
                val_12 = val_12;
                GooglePlayGames.Native.PInvoke.NearbyConnectionsManager.<>f__am$cache0 = new System.Func<GooglePlayGames.Native.PInvoke.NativeAppIdentifier, System.IntPtr>(object:  0, method:  static System.IntPtr GooglePlayGames.Native.PInvoke.NearbyConnectionsManager::<StartAdvertising>m__0(GooglePlayGames.Native.PInvoke.NativeAppIdentifier id));
                val_13 = null;
            }
            
            val_13 = null;
            System.Collections.Generic.IEnumerable<TResult> val_3 = System.Linq.Enumerable.Select<System.Object, System.IntPtr>(source:  0, selector:  appIds);
            int val_5 = appIds.Count;
            val_15 = null;
            if((GooglePlayGames.Native.PInvoke.NearbyConnectionsManager.<>f__mg$cache2) == null)
            {
                    val_16 = null;
                val_16 = null;
                GooglePlayGames.Native.PInvoke.NearbyConnectionsManager.<>f__mg$cache2 = new NearbyConnectionTypes.StartAdvertisingCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.NearbyConnectionsManager::InternalStartAdvertisingCallback(long id, IntPtr result, IntPtr userData));
                val_15 = null;
                val_12 = ;
            }
            
            val_15 = null;
            if((GooglePlayGames.Native.PInvoke.NearbyConnectionsManager.<>f__mg$cache0) == null)
            {
                    val_17 = null;
                val_17 = null;
                GooglePlayGames.Native.PInvoke.NearbyConnectionsManager.<>f__mg$cache0 = new System.Func<System.IntPtr, GooglePlayGames.Native.PInvoke.NativeStartAdvertisingResult>(object:  0, method:  static GooglePlayGames.Native.PInvoke.NativeStartAdvertisingResult GooglePlayGames.Native.PInvoke.NativeStartAdvertisingResult::FromPointer(IntPtr pointer));
                val_15 = null;
            }
            
            val_18 = val_1.handle;
            val_19 = connectionRequestCallback;
            val_20 = null;
            if((GooglePlayGames.Native.PInvoke.NearbyConnectionsManager.<>f__mg$cache3) == null)
            {
                    val_21 = null;
                val_21 = null;
                GooglePlayGames.Native.PInvoke.NearbyConnectionsManager.<>f__mg$cache3 = new NearbyConnectionTypes.ConnectionRequestCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.NearbyConnectionsManager::InternalConnectionRequestCallback(long id, IntPtr result, IntPtr userData));
                val_20 = null;
            }
            
            val_22 = System.Linq.Enumerable.ToArray<System.IntPtr>(source:  0);
            val_23 = val_1.wrapper;
            if((GooglePlayGames.Native.PInvoke.NearbyConnectionsManager.<>f__mg$cache1) == null)
            {
                    val_24 = null;
                val_24 = null;
                GooglePlayGames.Native.PInvoke.NearbyConnectionsManager.<>f__mg$cache1 = new System.Func<System.IntPtr, GooglePlayGames.Native.PInvoke.NativeConnectionRequest>(object:  0, method:  static GooglePlayGames.Native.PInvoke.NativeConnectionRequest GooglePlayGames.Native.PInvoke.NativeConnectionRequest::FromPointer(IntPtr pointer));
                val_20 = null;
            }
            
            val_20 = null;
            IntPtr val_11 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<System.Int64, System.Object>(callback:  0, conversionFunction:  null);
            GooglePlayGames.Native.Cwrapper.NearbyConnections.NearbyConnections_StartAdvertising(self:  new System.Runtime.InteropServices.HandleRef() {}, name:  null, app_identifiers:  name, app_identifiers_size:  null, duration:  0, start_advertising_callback:  advertisingDuration, start_advertising_callback_arg:  GooglePlayGames.Native.PInvoke.NearbyConnectionsManager.<>f__mg$cache2, request_callback:  GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<System.Int64, System.Object>(callback:  0, conversionFunction:  val_12), request_callback_arg:  GooglePlayGames.Native.PInvoke.NearbyConnectionsManager.<>f__mg$cache3);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        private static void InternalStartAdvertisingCallback(long id, IntPtr result, IntPtr userData)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback<System.Int64>(callbackName:  0, callbackType:  "NearbyConnectionsManager#InternalStartAdvertisingCallback", param1:  0, param2:  result, userData:  userData);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        private static void InternalConnectionRequestCallback(long id, IntPtr result, IntPtr userData)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback<System.Int64>(callbackName:  0, callbackType:  "NearbyConnectionsManager#InternalConnectionRequestCallback", param1:  0, param2:  result, userData:  userData);
        }
        internal void StopAdvertising()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.NearbyConnections.NearbyConnections_StopAdvertising(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, System.Action<long, GooglePlayGames.Native.PInvoke.NativeConnectionResponse> callback, GooglePlayGames.Native.PInvoke.NativeMessageListenerHelper listener)
        {
            var val_6;
            var val_7;
            var val_8;
            System.Runtime.InteropServices.HandleRef val_1 = listener.SelfPtr();
            val_6 = null;
            val_6 = null;
            if((GooglePlayGames.Native.PInvoke.NearbyConnectionsManager.<>f__mg$cache5) == null)
            {
                    val_7 = null;
                val_7 = null;
                GooglePlayGames.Native.PInvoke.NearbyConnectionsManager.<>f__mg$cache5 = new NearbyConnectionTypes.ConnectionResponseCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.NearbyConnectionsManager::InternalConnectResponseCallback(long localClientId, IntPtr response, IntPtr userData));
                val_6 = null;
            }
            
            val_6 = null;
            if((GooglePlayGames.Native.PInvoke.NearbyConnectionsManager.<>f__mg$cache4) == null)
            {
                    val_8 = null;
                val_8 = null;
                GooglePlayGames.Native.PInvoke.NearbyConnectionsManager.<>f__mg$cache4 = new System.Func<System.IntPtr, GooglePlayGames.Native.PInvoke.NativeConnectionResponse>(object:  0, method:  static GooglePlayGames.Native.PInvoke.NativeConnectionResponse GooglePlayGames.Native.PInvoke.NativeConnectionResponse::FromPointer(IntPtr pointer));
                val_6 = null;
            }
            
            val_6 = null;
            System.Runtime.InteropServices.HandleRef val_5 = listener.SelfPtr();
            GooglePlayGames.Native.Cwrapper.NearbyConnections.NearbyConnections_SendConnectionRequest(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, name:  val_1.handle, remote_endpoint_id:  name, payload:  remoteEndpointId, payload_size:  payload, callback:  0, callback_arg:  GooglePlayGames.Native.PInvoke.NearbyConnectionsManager.<>f__mg$cache5, helper:  GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<System.Int64, System.Object>(callback:  0, conversionFunction:  callback));
        }
        [AOT.MonoPInvokeCallbackAttribute]
        private static void InternalConnectResponseCallback(long localClientId, IntPtr response, IntPtr userData)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback<System.Int64>(callbackName:  0, callbackType:  "NearbyConnectionManager#InternalConnectResponseCallback", param1:  1, param2:  response, userData:  userData);
        }
        internal void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, GooglePlayGames.Native.PInvoke.NativeMessageListenerHelper listener)
        {
            System.Runtime.InteropServices.HandleRef val_1 = listener.SelfPtr();
            System.Runtime.InteropServices.HandleRef val_2 = listener.SelfPtr();
            GooglePlayGames.Native.Cwrapper.NearbyConnections.NearbyConnections_AcceptConnectionRequest(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, remote_endpoint_id:  val_1.handle, payload:  remoteEndpointId, payload_size:  payload, helper:  0);
        }
        internal void DisconnectFromEndpoint(string remoteEndpointId)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.NearbyConnections.NearbyConnections_Disconnect(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, remote_endpoint_id:  val_1.handle);
        }
        internal void StopAllConnections()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.NearbyConnections.NearbyConnections_Stop(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal void StartDiscovery(string serviceId, long duration, GooglePlayGames.Native.PInvoke.NativeEndpointDiscoveryListenerHelper listener)
        {
            System.Runtime.InteropServices.HandleRef val_1 = listener.SelfPtr();
            System.Runtime.InteropServices.HandleRef val_2 = listener.SelfPtr();
            GooglePlayGames.Native.Cwrapper.NearbyConnections.NearbyConnections_StartDiscovery(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, service_id:  val_1.handle, duration:  serviceId, helper:  duration);
        }
        internal void StopDiscovery(string serviceId)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.NearbyConnections.NearbyConnections_StopDiscovery(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, service_id:  val_1.handle);
        }
        internal void RejectConnectionRequest(string remoteEndpointId)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.NearbyConnections.NearbyConnections_RejectConnectionRequest(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, remote_endpoint_id:  val_1.handle);
        }
        internal void Shutdown()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.NearbyConnections.NearbyConnections_Stop(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        public string get_AppBundleId()
        {
            var val_4;
            if(null == 0)
            {
                goto label_3;
            }
            
            UnityEngine.AndroidJavaClass val_6 = null;
            if((mem[null + 258]) == 0)
            {
                goto label_4;
            }
            
            var val_4 = mem[null + 152];
            var val_5 = 0;
            val_4 = val_4 + 8;
            label_6:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_5;
            }
            
            val_5 = val_5 + 1;
            val_4 = val_4 + 16;
            if(val_5 < (mem[null + 258]))
            {
                goto label_6;
            }
            
            label_4:
            val_4 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
            goto label_7;
            label_5:
            val_6 = val_6 + (((mem[null + 152] + 8)) << 4);
            label_7:
            label_3:
            if(59 == 59)
            {
                    return (string)GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity").Call<System.String>(methodName:  "getPackageName", args:  null);
            }
            
            if(0 == 0)
            {
                    return (string)GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity").Call<System.String>(methodName:  "getPackageName", args:  null);
            }
            
            return (string)GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity").Call<System.String>(methodName:  "getPackageName", args:  null);
        }
        internal static string ReadServiceId()
        {
            var val_10;
            var val_11;
            var val_12;
            UnityEngine.Debug.Log(message:  0);
            UnityEngine.AndroidJavaObject val_2 = GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
            typeof(System.Object[]).__il2cppRuntimeField_20 = val_2.Call<System.String>(methodName:  "getPackageName", args:  null);
            typeof(System.Object[]).__il2cppRuntimeField_28 = 128;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_20 = "com.google.android.gms.nearby.connection.SERVICE_ID";
            string val_8 = 0 + "SystemId from Manifest: "("SystemId from Manifest: ");
            UnityEngine.Debug.Log(message:  0);
            val_10 = 0;
            if(val_2 != null)
            {
                    var val_10 = 0;
                val_10 = val_10 + 1;
                val_11 = val_2;
            }
            
            if((199 != 199) && (val_10 != 0))
            {
                    val_10 = 0;
            }
            
            if(null == 0)
            {
                goto label_31;
            }
            
            UnityEngine.AndroidJavaClass val_13 = null;
            if((mem[null + 258]) == 0)
            {
                goto label_32;
            }
            
            var val_11 = mem[null + 152];
            var val_12 = 0;
            val_11 = val_11 + 8;
            label_34:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_33;
            }
            
            val_12 = val_12 + 1;
            val_11 = val_11 + 16;
            if(val_12 < (mem[null + 258]))
            {
                goto label_34;
            }
            
            label_32:
            val_12 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
            goto label_35;
            label_33:
            val_13 = val_13 + (((mem[null + 152] + 8)) << 4);
            label_35:
            label_31:
            if(199 == 199)
            {
                    return (string)val_2.Call<UnityEngine.AndroidJavaObject>(methodName:  "getPackageManager", args:  null).Call<UnityEngine.AndroidJavaObject>(methodName:  "getApplicationInfo", args:  null).Get<UnityEngine.AndroidJavaObject>(fieldName:  "metaData").Call<System.String>(methodName:  "getString", args:  null);
            }
            
            if(val_10 == 0)
            {
                    return (string)val_2.Call<UnityEngine.AndroidJavaObject>(methodName:  "getPackageManager", args:  null).Call<UnityEngine.AndroidJavaObject>(methodName:  "getApplicationInfo", args:  null).Get<UnityEngine.AndroidJavaObject>(fieldName:  "metaData").Call<System.String>(methodName:  "getString", args:  null);
            }
            
            return (string)val_2.Call<UnityEngine.AndroidJavaObject>(methodName:  "getPackageManager", args:  null).Call<UnityEngine.AndroidJavaObject>(methodName:  "getApplicationInfo", args:  null).Get<UnityEngine.AndroidJavaObject>(fieldName:  "metaData").Call<System.String>(methodName:  "getString", args:  null);
        }
        public static string get_ServiceId()
        {
            null = null;
            return (string)GooglePlayGames.Native.PInvoke.NearbyConnectionsManager.sServiceId;
        }
        private static NearbyConnectionsManager()
        {
            GooglePlayGames.Native.PInvoke.NearbyConnectionsManager.sServiceId = GooglePlayGames.Native.PInvoke.NearbyConnectionsManager.ReadServiceId();
        }
        private static IntPtr <StartAdvertising>m__0(GooglePlayGames.Native.PInvoke.NativeAppIdentifier id)
        {
            System.Runtime.InteropServices.HandleRef val_1 = X1.SelfPtr();
            return (IntPtr);
        }
    
    }

}

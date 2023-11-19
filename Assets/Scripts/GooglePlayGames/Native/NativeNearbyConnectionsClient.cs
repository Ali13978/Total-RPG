using UnityEngine;

namespace GooglePlayGames.Native
{
    internal class NativeNearbyConnectionsClient : INearbyConnectionClient
    {
        // Fields
        private readonly GooglePlayGames.Native.PInvoke.NearbyConnectionsManager mManager;
        private static System.Func<string, GooglePlayGames.Native.PInvoke.NativeAppIdentifier> <>f__mg$cache0;
        
        // Methods
        internal NativeNearbyConnectionsClient(GooglePlayGames.Native.PInvoke.NearbyConnectionsManager manager)
        {
            this.mManager = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
        }
        public int MaxUnreliableMessagePayloadLength()
        {
            return 1168;
        }
        public int MaxReliableMessagePayloadLength()
        {
            return 4096;
        }
        public void SendReliable(System.Collections.Generic.List<string> recipientEndpointIds, byte[] payload)
        {
            this.InternalSend(recipientEndpointIds:  recipientEndpointIds, payload:  payload, isReliable:  true);
        }
        public void SendUnreliable(System.Collections.Generic.List<string> recipientEndpointIds, byte[] payload)
        {
            this.InternalSend(recipientEndpointIds:  recipientEndpointIds, payload:  payload, isReliable:  false);
        }
        private void InternalSend(System.Collections.Generic.List<string> recipientEndpointIds, byte[] payload, bool isReliable)
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            System.ArgumentNullException val_14;
            string val_15;
            var val_16;
            val_10 = isReliable;
            if(recipientEndpointIds == null)
            {
                goto label_1;
            }
            
            if(payload == null)
            {
                goto label_2;
            }
            
            if((recipientEndpointIds.Contains(item:  0)) == true)
            {
                goto label_3;
            }
            
            if(recipientEndpointIds.Count == 0)
            {
                goto label_4;
            }
            
            if(val_10 == false)
            {
                goto label_5;
            }
            
            if(payload.Length <= 4096)
            {
                goto label_6;
            }
            
            val_11 = null;
            val_12 = 4096;
            goto label_7;
            label_4:
            GooglePlayGames.OurUtils.Logger.w(msg:  0);
            return;
            label_5:
            if(payload.Length >= 1169)
            {
                goto label_11;
            }
            
            label_6:
            List.Enumerator<T> val_3 = recipientEndpointIds.GetEnumerator();
            label_17:
            if((0 & 1) == 0)
            {
                goto label_12;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_4 = 0.InitializationCallback;
            if(val_10 == false)
            {
                goto label_13;
            }
            
            this.mManager.SendReliable(remoteEndpointId:  val_4, payload:  payload);
            goto label_17;
            label_13:
            this.mManager.SendUnreliable(remoteEndpointId:  val_4, payload:  payload);
            goto label_17;
            label_12:
            val_10 = 0;
            val_13 = 1;
            0.Dispose();
            if((val_13 & 1) != 0)
            {
                    return;
            }
            
            if(val_10 == 0)
            {
                    return;
            }
            
            return;
            label_1:
            val_14 = null;
            val_15 = "recipientEndpointIds";
            goto label_21;
            label_2:
            val_14 = null;
            val_15 = "payload";
            label_21:
            val_16 = val_14;
            val_14 = new System.ArgumentNullException(paramName:  val_15);
            goto label_22;
            label_3:
            System.InvalidOperationException val_6 = null;
            val_16 = val_6;
            val_6 = new System.InvalidOperationException(message:  "Cannot send a message to a null recipient");
            label_22:
            label_11:
            val_11 = null;
            val_12 = 1168;
            label_7:
            System.InvalidOperationException val_8 = new System.InvalidOperationException(message:  0 + "cannot send more than " + 1168);
        }
        public void StartAdvertising(string name, System.Collections.Generic.List<string> appIdentifiers, System.Nullable<System.TimeSpan> advertisingDuration, System.Action<GooglePlayGames.BasicApi.Nearby.AdvertisingResult> resultCallback, System.Action<GooglePlayGames.BasicApi.Nearby.ConnectionRequest> requestCallback)
        {
            string val_16;
            var val_17;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_16 = val_1;
                typeof(NativeNearbyConnectionsClient.<StartAdvertising>c__AnonStorey0).__il2cppRuntimeField_10 = requestCallback;
            }
            else
            {
                    val_16 = 16;
                mem[16] = requestCallback;
            }
            
            typeof(NativeNearbyConnectionsClient.<StartAdvertising>c__AnonStorey0).__il2cppRuntimeField_18 = X6;
            GooglePlayGames.BasicApi.Nearby.IDiscoveryListener val_2 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.Nearby.IDiscoveryListener>(value:  0, paramName:  appIdentifiers);
            if(null != 0)
            {
                    GooglePlayGames.BasicApi.Nearby.IDiscoveryListener val_3 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.Nearby.IDiscoveryListener>(value:  0, paramName:  val_16);
            }
            else
            {
                    GooglePlayGames.BasicApi.Nearby.IDiscoveryListener val_4 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.Nearby.IDiscoveryListener>(value:  0, paramName:  mem[16]);
            }
            
            GooglePlayGames.BasicApi.Nearby.IDiscoveryListener val_5 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.Nearby.IDiscoveryListener>(value:  0, paramName:  typeof(NativeNearbyConnectionsClient.<StartAdvertising>c__AnonStorey0).__il2cppRuntimeField_18);
            if(((-1133468016) & 1) != 0)
            {
                    if((advertisingDuration.HasValue.InitializationCallback & 9223372036854775808) != 0)
            {
                goto label_6;
            }
            
            }
            
            mem[16] = GooglePlayGames.Native.PInvoke.Callbacks.AsOnGameThreadCallback<GooglePlayGames.BasicApi.Nearby.AdvertisingResult>(toInvokeOnGameThread:  0);
            typeof(NativeNearbyConnectionsClient.<StartAdvertising>c__AnonStorey0).__il2cppRuntimeField_18 = GooglePlayGames.Native.PInvoke.Callbacks.AsOnGameThreadCallback<GooglePlayGames.BasicApi.Nearby.ConnectionRequest>(toInvokeOnGameThread:  0);
            val_17 = null;
            if((GooglePlayGames.Native.NativeNearbyConnectionsClient.<>f__mg$cache0) == null)
            {
                    GooglePlayGames.Native.NativeNearbyConnectionsClient.<>f__mg$cache0 = new System.Func<System.String, GooglePlayGames.Native.PInvoke.NativeAppIdentifier>(object:  0, method:  static GooglePlayGames.Native.PInvoke.NativeAppIdentifier GooglePlayGames.Native.PInvoke.NativeAppIdentifier::FromString(string appId));
                val_17 = null;
            }
            
            System.Collections.Generic.IEnumerable<TResult> val_10 = System.Linq.Enumerable.Select<System.Type, System.String>(source:  0, selector:  appIdentifiers);
            System.Collections.Generic.List<TSource> val_11 = System.Linq.Enumerable.ToList<UnityEngine.Component>(source:  0);
            this.mManager.StartAdvertising(name:  name, appIds:  val_11, advertisingDuration:  GooglePlayGames.Native.NativeNearbyConnectionsClient.ToTimeoutMillis(span:  new System.Nullable<System.TimeSpan>() {HasValue = val_11}), advertisingCallback:  new System.Action<System.Int64, GooglePlayGames.Native.PInvoke.NativeStartAdvertisingResult>(object:  val_1, method:  System.Void NativeNearbyConnectionsClient.<StartAdvertising>c__AnonStorey0::<>m__0(long localClientId, GooglePlayGames.Native.PInvoke.NativeStartAdvertisingResult result)), connectionRequestCallback:  new System.Action<System.Int64, GooglePlayGames.Native.PInvoke.NativeConnectionRequest>(object:  val_1, method:  System.Void NativeNearbyConnectionsClient.<StartAdvertising>c__AnonStorey0::<>m__1(long localClientId, GooglePlayGames.Native.PInvoke.NativeConnectionRequest request)));
            return;
            label_6:
            System.InvalidOperationException val_15 = new System.InvalidOperationException(message:  "advertisingDuration must be positive");
        }
        private static long ToTimeoutMillis(System.Nullable<System.TimeSpan> span)
        {
            var val_2;
            var val_3;
            if(( & 1) != 0)
            {
                    val_2 = ;
                long val_1 = GooglePlayGames.Native.PInvoke.PInvokeUtilities.ToMilliseconds(span:  new System.TimeSpan());
                return (long)val_3;
            }
            
            val_3 = 0;
            return (long)val_3;
        }
        public void StopAdvertising()
        {
            this.mManager.StopAdvertising();
        }
        public void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, System.Action<GooglePlayGames.BasicApi.Nearby.ConnectionResponse> responseCallback, GooglePlayGames.BasicApi.Nearby.IMessageListener listener)
        {
            string val_22;
            GooglePlayGames.Native.PInvoke.NativeMessageListenerHelper val_23;
            System.Action<System.Int64, GooglePlayGames.Native.PInvoke.NativeConnectionResponse> val_24;
            var val_25;
            var val_26;
            val_22 = name;
            typeof(NativeNearbyConnectionsClient.<SendConnectionRequest>c__AnonStorey1).__il2cppRuntimeField_10 = responseCallback;
            GooglePlayGames.BasicApi.Nearby.IDiscoveryListener val_2 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.Nearby.IDiscoveryListener>(value:  0, paramName:  remoteEndpointId);
            GooglePlayGames.BasicApi.Nearby.IDiscoveryListener val_3 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.Nearby.IDiscoveryListener>(value:  0, paramName:  payload);
            if(null != 0)
            {
                    GooglePlayGames.BasicApi.Nearby.IDiscoveryListener val_4 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.Nearby.IDiscoveryListener>(value:  0, paramName:  typeof(NativeNearbyConnectionsClient.<SendConnectionRequest>c__AnonStorey1).__il2cppRuntimeField_10);
                GooglePlayGames.BasicApi.Nearby.IDiscoveryListener val_5 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.Nearby.IDiscoveryListener>(value:  0, paramName:  listener);
            }
            else
            {
                    GooglePlayGames.BasicApi.Nearby.IDiscoveryListener val_6 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.Nearby.IDiscoveryListener>(value:  0, paramName:  typeof(NativeNearbyConnectionsClient.<SendConnectionRequest>c__AnonStorey1).__il2cppRuntimeField_10);
                GooglePlayGames.BasicApi.Nearby.IDiscoveryListener val_7 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.Nearby.IDiscoveryListener>(value:  0, paramName:  listener);
            }
            
            System.Action<T> val_8 = GooglePlayGames.Native.PInvoke.Callbacks.AsOnGameThreadCallback<GooglePlayGames.BasicApi.Nearby.ConnectionResponse>(toInvokeOnGameThread:  0);
            typeof(NativeNearbyConnectionsClient.<SendConnectionRequest>c__AnonStorey1).__il2cppRuntimeField_10 = val_8;
            val_23 = GooglePlayGames.Native.NativeNearbyConnectionsClient.ToMessageListener(listener:  val_8);
            val_24 = null;
            val_24 = new System.Action<System.Int64, GooglePlayGames.Native.PInvoke.NativeConnectionResponse>(object:  new System.Object(), method:  System.Void NativeNearbyConnectionsClient.<SendConnectionRequest>c__AnonStorey1::<>m__0(long localClientId, GooglePlayGames.Native.PInvoke.NativeConnectionResponse response));
            this.mManager.SendConnectionRequest(name:  val_22, remoteEndpointId:  remoteEndpointId, payload:  payload, callback:  val_24, listener:  val_23);
            val_25 = 0;
            if(val_23 != null)
            {
                    var val_22 = 0;
                val_22 = val_22 + 1;
                val_26 = val_23;
            }
            
            if(138 == 138)
            {
                    return;
            }
            
            if(val_25 == 0)
            {
                    return;
            }
            
            val_25 = ???;
            val_22 = ???;
            val_23 = ???;
            val_24 = ???;
        }
        private static GooglePlayGames.Native.PInvoke.NativeMessageListenerHelper ToMessageListener(GooglePlayGames.BasicApi.Nearby.IMessageListener listener)
        {
            GooglePlayGames.BasicApi.Nearby.IMessageListener val_6;
            var val_7;
            val_6 = X1;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_7 = val_1;
                typeof(NativeNearbyConnectionsClient.<ToMessageListener>c__AnonStorey2).__il2cppRuntimeField_10 = val_6;
            }
            else
            {
                    val_7 = 16;
                mem[16] = val_6;
                val_6 = mem[16];
            }
            
            mem[16] = new NativeNearbyConnectionsClient.OnGameThreadMessageListener(listener:  val_6);
            SetOnMessageReceivedCallback(callback:  new NativeMessageListenerHelper.OnMessageReceived(object:  val_1, method:  System.Void NativeNearbyConnectionsClient.<ToMessageListener>c__AnonStorey2::<>m__0(long localClientId, string endpointId, byte[] data, bool isReliable)));
            SetOnDisconnectedCallback(callback:  new System.Action<System.Int64, System.String>(object:  val_1, method:  System.Void NativeNearbyConnectionsClient.<ToMessageListener>c__AnonStorey2::<>m__1(long localClientId, string endpointId)));
            return (GooglePlayGames.Native.PInvoke.NativeMessageListenerHelper)new GooglePlayGames.Native.PInvoke.NativeMessageListenerHelper();
        }
        public void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, GooglePlayGames.BasicApi.Nearby.IMessageListener listener)
        {
            GooglePlayGames.BasicApi.Nearby.IDiscoveryListener val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.Nearby.IDiscoveryListener>(value:  0, paramName:  remoteEndpointId);
            GooglePlayGames.BasicApi.Nearby.IDiscoveryListener val_2 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.Nearby.IDiscoveryListener>(value:  0, paramName:  payload);
            GooglePlayGames.BasicApi.Nearby.IDiscoveryListener val_3 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.Nearby.IDiscoveryListener>(value:  0, paramName:  listener);
            GooglePlayGames.OurUtils.Logger.d(msg:  0);
            this.mManager.AcceptConnectionRequest(remoteEndpointId:  remoteEndpointId, payload:  payload, listener:  GooglePlayGames.Native.NativeNearbyConnectionsClient.ToMessageListener(listener:  0));
            GooglePlayGames.OurUtils.Logger.d(msg:  0);
        }
        public void StartDiscovery(string serviceId, System.Nullable<System.TimeSpan> advertisingTimeout, GooglePlayGames.BasicApi.Nearby.IDiscoveryListener listener)
        {
            GooglePlayGames.Native.PInvoke.NearbyConnectionsManager val_14;
            GooglePlayGames.Native.PInvoke.NativeEndpointDiscoveryListenerHelper val_15;
            var val_16;
            var val_17;
            GooglePlayGames.BasicApi.Nearby.IDiscoveryListener val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.Nearby.IDiscoveryListener>(value:  0, paramName:  serviceId);
            GooglePlayGames.Native.PInvoke.NativeEndpointDiscoveryListenerHelper val_3 = GooglePlayGames.Native.NativeNearbyConnectionsClient.ToDiscoveryListener(listener:  GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.Nearby.IDiscoveryListener>(value:  0, paramName:  X4));
            val_14 = this.mManager;
            val_15 = val_3;
            val_14.StartDiscovery(serviceId:  serviceId, duration:  GooglePlayGames.Native.NativeNearbyConnectionsClient.ToTimeoutMillis(span:  new System.Nullable<System.TimeSpan>() {HasValue = val_3}), listener:  val_15);
            val_16 = 68;
            if(val_15 != null)
            {
                    var val_14 = 0;
                val_14 = val_14 + 1;
                val_17 = val_15;
            }
            
            if(68 == 68)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            val_15 = ???;
            val_16 = ???;
            val_14 = ???;
        }
        private static GooglePlayGames.Native.PInvoke.NativeEndpointDiscoveryListenerHelper ToDiscoveryListener(GooglePlayGames.BasicApi.Nearby.IDiscoveryListener listener)
        {
            GooglePlayGames.BasicApi.Nearby.IDiscoveryListener val_6;
            var val_7;
            val_6 = X1;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_7 = val_1;
                typeof(NativeNearbyConnectionsClient.<ToDiscoveryListener>c__AnonStorey3).__il2cppRuntimeField_10 = val_6;
            }
            else
            {
                    val_7 = 16;
                mem[16] = val_6;
                val_6 = mem[16];
            }
            
            mem[16] = new NativeNearbyConnectionsClient.OnGameThreadDiscoveryListener(listener:  val_6);
            SetOnEndpointFound(callback:  new System.Action<System.Int64, GooglePlayGames.Native.PInvoke.NativeEndpointDetails>(object:  val_1, method:  System.Void NativeNearbyConnectionsClient.<ToDiscoveryListener>c__AnonStorey3::<>m__0(long localClientId, GooglePlayGames.Native.PInvoke.NativeEndpointDetails endpoint)));
            SetOnEndpointLostCallback(callback:  new System.Action<System.Int64, System.String>(object:  val_1, method:  System.Void NativeNearbyConnectionsClient.<ToDiscoveryListener>c__AnonStorey3::<>m__1(long localClientId, string lostEndpointId)));
            return (GooglePlayGames.Native.PInvoke.NativeEndpointDiscoveryListenerHelper)new GooglePlayGames.Native.PInvoke.NativeEndpointDiscoveryListenerHelper();
        }
        public void StopDiscovery(string serviceId)
        {
            GooglePlayGames.BasicApi.Nearby.IDiscoveryListener val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.Nearby.IDiscoveryListener>(value:  0, paramName:  serviceId);
            this.mManager.StopDiscovery(serviceId:  serviceId);
        }
        public void RejectConnectionRequest(string requestingEndpointId)
        {
            GooglePlayGames.BasicApi.Nearby.IDiscoveryListener val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.Nearby.IDiscoveryListener>(value:  0, paramName:  requestingEndpointId);
            this.mManager.RejectConnectionRequest(remoteEndpointId:  requestingEndpointId);
        }
        public void DisconnectFromEndpoint(string remoteEndpointId)
        {
            this.mManager.DisconnectFromEndpoint(remoteEndpointId:  remoteEndpointId);
        }
        public void StopAllConnections()
        {
            this.mManager.StopAllConnections();
        }
        public string GetAppBundleId()
        {
            if(this.mManager != null)
            {
                    return this.mManager.AppBundleId;
            }
            
            return this.mManager.AppBundleId;
        }
        public string GetServiceId()
        {
            return GooglePlayGames.Native.PInvoke.NearbyConnectionsManager.ServiceId;
        }
    
    }

}

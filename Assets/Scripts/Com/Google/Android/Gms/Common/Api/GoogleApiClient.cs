using UnityEngine;

namespace Com.Google.Android.Gms.Common.Api
{
    public class GoogleApiClient : JavaObjWrapper
    {
        // Fields
        private const string CLASS_NAME = "com/google/android/gms/common/api/GoogleApiClient";
        
        // Methods
        public GoogleApiClient(IntPtr ptr)
        {
        
        }
        public GoogleApiClient()
        {
        
        }
        public object getContext()
        {
            return this.InvokeCall<System.Object>(name:  "getContext", sig:  "()Landroid/content/Context;", args:  null);
        }
        public void connect()
        {
            this.InvokeCallVoid(name:  "connect", sig:  "()V", args:  null);
        }
        public void disconnect()
        {
            this.InvokeCallVoid(name:  "disconnect", sig:  "()V", args:  null);
        }
        public void dump(string arg_string_1, object arg_object_2, object arg_object_3, string[] arg_string_4)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = arg_string_1;
            typeof(System.Object[]).__il2cppRuntimeField_28 = arg_object_2;
            typeof(System.Object[]).__il2cppRuntimeField_30 = arg_object_3;
            typeof(System.Object[]).__il2cppRuntimeField_38 = arg_string_4;
            this.InvokeCallVoid(name:  "dump", sig:  "(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", args:  null);
        }
        public Com.Google.Android.Gms.Common.ConnectionResult blockingConnect(long arg_long_1, object arg_object_2)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = arg_long_1;
            typeof(System.Object[]).__il2cppRuntimeField_28 = arg_object_2;
            return (Com.Google.Android.Gms.Common.ConnectionResult)this.InvokeCall<Com.Google.Android.Gms.Common.ConnectionResult>(name:  "blockingConnect", sig:  "(JLjava/util/concurrent/TimeUnit;)Lcom/google/android/gms/common/ConnectionResult;", args:  null);
        }
        public Com.Google.Android.Gms.Common.ConnectionResult blockingConnect()
        {
            return this.InvokeCall<Com.Google.Android.Gms.Common.ConnectionResult>(name:  "blockingConnect", sig:  "()Lcom/google/android/gms/common/ConnectionResult;", args:  null);
        }
        public Com.Google.Android.Gms.Common.Api.PendingResult<Com.Google.Android.Gms.Common.Api.Status> clearDefaultAccountAndReconnect()
        {
            return this.InvokeCall<Com.Google.Android.Gms.Common.Api.PendingResult<Com.Google.Android.Gms.Common.Api.Status>>(name:  "clearDefaultAccountAndReconnect", sig:  "()Lcom/google/android/gms/common/api/PendingResult;", args:  null);
        }
        public Com.Google.Android.Gms.Common.ConnectionResult getConnectionResult(object arg_object_1)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = arg_object_1;
            return this.InvokeCall<Com.Google.Android.Gms.Common.ConnectionResult>(name:  "getConnectionResult", sig:  "(Lcom/google/android/gms/common/api/Api;)Lcom/google/android/gms/common/ConnectionResult;", args:  null);
        }
        public int getSessionId()
        {
            return this.InvokeCall<System.Int32>(name:  "getSessionId", sig:  "()I", args:  null);
        }
        public bool isConnecting()
        {
            return this.InvokeCall<System.Boolean>(name:  "isConnecting", sig:  "()Z", args:  null);
        }
        public bool isConnectionCallbacksRegistered(object arg_object_1)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = arg_object_1;
            return this.InvokeCall<System.Boolean>(name:  "isConnectionCallbacksRegistered", sig:  "(Lcom/google/android/gms/common/api/GoogleApiClient$ConnectionCallbacks;)Z", args:  null);
        }
        public bool isConnectionFailedListenerRegistered(object arg_object_1)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = arg_object_1;
            return this.InvokeCall<System.Boolean>(name:  "isConnectionFailedListenerRegistered", sig:  "(Lcom/google/android/gms/common/api/GoogleApiClient$OnConnectionFailedListener;)Z", args:  null);
        }
        public void reconnect()
        {
            this.InvokeCallVoid(name:  "reconnect", sig:  "()V", args:  null);
        }
        public void registerConnectionCallbacks(object arg_object_1)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = arg_object_1;
            this.InvokeCallVoid(name:  "registerConnectionCallbacks", sig:  "(Lcom/google/android/gms/common/api/GoogleApiClient$ConnectionCallbacks;)V", args:  null);
        }
        public void registerConnectionFailedListener(object arg_object_1)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = arg_object_1;
            this.InvokeCallVoid(name:  "registerConnectionFailedListener", sig:  "(Lcom/google/android/gms/common/api/GoogleApiClient$OnConnectionFailedListener;)V", args:  null);
        }
        public void stopAutoManage(object arg_object_1)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = arg_object_1;
            this.InvokeCallVoid(name:  "stopAutoManage", sig:  "(Landroid/support/v4/app/FragmentActivity;)V", args:  null);
        }
        public void unregisterConnectionCallbacks(object arg_object_1)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = arg_object_1;
            this.InvokeCallVoid(name:  "unregisterConnectionCallbacks", sig:  "(Lcom/google/android/gms/common/api/GoogleApiClient$ConnectionCallbacks;)V", args:  null);
        }
        public void unregisterConnectionFailedListener(object arg_object_1)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = arg_object_1;
            this.InvokeCallVoid(name:  "unregisterConnectionFailedListener", sig:  "(Lcom/google/android/gms/common/api/GoogleApiClient$OnConnectionFailedListener;)V", args:  null);
        }
        public bool hasConnectedApi(object arg_object_1)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = arg_object_1;
            return this.InvokeCall<System.Boolean>(name:  "hasConnectedApi", sig:  "(Lcom/google/android/gms/common/api/Api;)Z", args:  null);
        }
        public object getLooper()
        {
            return this.InvokeCall<System.Object>(name:  "getLooper", sig:  "()Landroid/os/Looper;", args:  null);
        }
        public bool isConnected()
        {
            return this.InvokeCall<System.Boolean>(name:  "isConnected", sig:  "()Z", args:  null);
        }
    
    }

}

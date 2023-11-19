using UnityEngine;

namespace Com.Google.Android.Gms.Common.Api
{
    public class PendingResult<R> : JavaObjWrapper
    {
        // Fields
        private const string CLASS_NAME = "com/google/android/gms/common/api/PendingResult";
        
        // Methods
        public PendingResult<R>(IntPtr ptr)
        {
            if(this != null)
            {
                    return;
            }
        
        }
        public PendingResult<R>()
        {
            if(this != null)
            {
                    return;
            }
        
        }
        public R await(long arg_long_1, object arg_object_2)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = arg_long_1;
            typeof(System.Object[]).__il2cppRuntimeField_28 = arg_object_2;
            if(this != null)
            {
                    return (object)this;
            }
            
            return (object)this;
        }
        public R await()
        {
            if(this == null)
            {
                
            }
        
        }
        public bool isCanceled()
        {
            if(this != null)
            {
                    return this.InvokeCall<System.Boolean>(name:  "isCanceled", sig:  "()Z", args:  null);
            }
            
            return this.InvokeCall<System.Boolean>(name:  "isCanceled", sig:  "()Z", args:  null);
        }
        public void cancel()
        {
            this.InvokeCallVoid(name:  "cancel", sig:  "()V", args:  null);
        }
        public void setResultCallback(Com.Google.Android.Gms.Common.Api.ResultCallback<R> arg_ResultCallback_1)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = arg_ResultCallback_1;
            this.InvokeCallVoid(name:  "setResultCallback", sig:  "(Lcom/google/android/gms/common/api/ResultCallback;)V", args:  null);
        }
        public void setResultCallback(Com.Google.Android.Gms.Common.Api.ResultCallback<R> arg_ResultCallback_1, long arg_long_2, object arg_object_3)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = arg_ResultCallback_1;
            typeof(System.Object[]).__il2cppRuntimeField_28 = arg_long_2;
            typeof(System.Object[]).__il2cppRuntimeField_30 = arg_object_3;
            this.InvokeCallVoid(name:  "setResultCallback", sig:  "(Lcom/google/android/gms/common/api/ResultCallback;JLjava/util/concurrent/TimeUnit;)V", args:  null);
        }
    
    }

}

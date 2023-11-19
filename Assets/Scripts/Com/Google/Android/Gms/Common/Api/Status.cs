using UnityEngine;

namespace Com.Google.Android.Gms.Common.Api
{
    public class Status : JavaObjWrapper, Result
    {
        // Fields
        private const string CLASS_NAME = "com/google/android/gms/common/api/Status";
        
        // Properties
        public static object CREATOR { get; }
        public static string NULL { get; }
        public static int CONTENTS_FILE_DESCRIPTOR { get; }
        public static int PARCELABLE_WRITE_RETURN_VALUE { get; }
        
        // Methods
        public Status(IntPtr ptr)
        {
        
        }
        public Status(int arg_int_1, string arg_string_2, object arg_object_3)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = arg_int_1;
            typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_28 = arg_string_2;
            typeof(System.Object[]).__il2cppRuntimeField_30 = arg_object_3;
            this.CreateInstance(clazzName:  "com/google/android/gms/common/api/Status", args:  null);
        }
        public Status(int arg_int_1, string arg_string_2)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = arg_int_1;
            typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_28 = arg_string_2;
            this.CreateInstance(clazzName:  "com/google/android/gms/common/api/Status", args:  null);
        }
        public Status(int arg_int_1)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = arg_int_1;
            typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
            this.CreateInstance(clazzName:  "com/google/android/gms/common/api/Status", args:  null);
        }
        public static object get_CREATOR()
        {
            return Google.Developers.JavaObjWrapper.GetStaticObjectField<Com.Google.Android.Gms.Games.Stats.StatsObject>(clsName:  0, name:  "com/google/android/gms/common/api/Status", sig:  "CREATOR");
        }
        public static string get_NULL()
        {
            return Google.Developers.JavaObjWrapper.GetStaticStringField(clsName:  0, name:  "com/google/android/gms/common/api/Status");
        }
        public static int get_CONTENTS_FILE_DESCRIPTOR()
        {
            return Google.Developers.JavaObjWrapper.GetStaticIntField(clsName:  0, name:  "com/google/android/gms/common/api/Status");
        }
        public static int get_PARCELABLE_WRITE_RETURN_VALUE()
        {
            return Google.Developers.JavaObjWrapper.GetStaticIntField(clsName:  0, name:  "com/google/android/gms/common/api/Status");
        }
        public bool equals(object arg_object_1)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = arg_object_1;
            return this.InvokeCall<System.Boolean>(name:  "equals", sig:  "(Ljava/lang/Object;)Z", args:  null);
        }
        public string toString()
        {
            return this.InvokeCall<System.String>(name:  "toString", sig:  "()Ljava/lang/String;", args:  null);
        }
        public int hashCode()
        {
            return this.InvokeCall<System.Int32>(name:  "hashCode", sig:  "()I", args:  null);
        }
        public bool isInterrupted()
        {
            return this.InvokeCall<System.Boolean>(name:  "isInterrupted", sig:  "()Z", args:  null);
        }
        public Com.Google.Android.Gms.Common.Api.Status getStatus()
        {
            return this.InvokeCall<Com.Google.Android.Gms.Common.Api.Status>(name:  "getStatus", sig:  "()Lcom/google/android/gms/common/api/Status;", args:  null);
        }
        public bool isCanceled()
        {
            return this.InvokeCall<System.Boolean>(name:  "isCanceled", sig:  "()Z", args:  null);
        }
        public int describeContents()
        {
            return this.InvokeCall<System.Int32>(name:  "describeContents", sig:  "()I", args:  null);
        }
        public object getResolution()
        {
            return this.InvokeCall<System.Object>(name:  "getResolution", sig:  "()Landroid/app/PendingIntent;", args:  null);
        }
        public int getStatusCode()
        {
            return this.InvokeCall<System.Int32>(name:  "getStatusCode", sig:  "()I", args:  null);
        }
        public string getStatusMessage()
        {
            return this.InvokeCall<System.String>(name:  "getStatusMessage", sig:  "()Ljava/lang/String;", args:  null);
        }
        public bool hasResolution()
        {
            return this.InvokeCall<System.Boolean>(name:  "hasResolution", sig:  "()Z", args:  null);
        }
        public void startResolutionForResult(object arg_object_1, int arg_int_2)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = arg_object_1;
            typeof(System.Object[]).__il2cppRuntimeField_28 = arg_int_2;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            this.InvokeCallVoid(name:  "startResolutionForResult", sig:  "(Landroid/app/Activity;I)V", args:  null);
        }
        public void writeToParcel(object arg_object_1, int arg_int_2)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = arg_object_1;
            typeof(System.Object[]).__il2cppRuntimeField_28 = arg_int_2;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            this.InvokeCallVoid(name:  "writeToParcel", sig:  "(Landroid/os/Parcel;I)V", args:  null);
        }
        public bool isSuccess()
        {
            return this.InvokeCall<System.Boolean>(name:  "isSuccess", sig:  "()Z", args:  null);
        }
    
    }

}

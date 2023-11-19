using UnityEngine;

namespace Com.Google.Android.Gms.Common
{
    public class ConnectionResult : JavaObjWrapper
    {
        // Fields
        private const string CLASS_NAME = "com/google/android/gms/common/ConnectionResult";
        
        // Properties
        public static int SUCCESS { get; }
        public static int SERVICE_MISSING { get; }
        public static int SERVICE_VERSION_UPDATE_REQUIRED { get; }
        public static int SERVICE_DISABLED { get; }
        public static int SIGN_IN_REQUIRED { get; }
        public static int INVALID_ACCOUNT { get; }
        public static int RESOLUTION_REQUIRED { get; }
        public static int NETWORK_ERROR { get; }
        public static int INTERNAL_ERROR { get; }
        public static int SERVICE_INVALID { get; }
        public static int DEVELOPER_ERROR { get; }
        public static int LICENSE_CHECK_FAILED { get; }
        public static int CANCELED { get; }
        public static int TIMEOUT { get; }
        public static int INTERRUPTED { get; }
        public static int API_UNAVAILABLE { get; }
        public static int SIGN_IN_FAILED { get; }
        public static int SERVICE_UPDATING { get; }
        public static int SERVICE_MISSING_PERMISSION { get; }
        public static int DRIVE_EXTERNAL_STORAGE_REQUIRED { get; }
        public static object CREATOR { get; }
        public static string NULL { get; }
        public static int CONTENTS_FILE_DESCRIPTOR { get; }
        public static int PARCELABLE_WRITE_RETURN_VALUE { get; }
        
        // Methods
        public ConnectionResult(IntPtr ptr)
        {
        
        }
        public ConnectionResult(int arg_int_1, object arg_object_2, string arg_string_3)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = arg_int_1;
            typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_28 = arg_object_2;
            typeof(System.Object[]).__il2cppRuntimeField_30 = arg_string_3;
            this.CreateInstance(clazzName:  "com/google/android/gms/common/ConnectionResult", args:  null);
        }
        public ConnectionResult(int arg_int_1, object arg_object_2)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = arg_int_1;
            typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_28 = arg_object_2;
            this.CreateInstance(clazzName:  "com/google/android/gms/common/ConnectionResult", args:  null);
        }
        public ConnectionResult(int arg_int_1)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = arg_int_1;
            typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
            this.CreateInstance(clazzName:  "com/google/android/gms/common/ConnectionResult", args:  null);
        }
        public static int get_SUCCESS()
        {
            return Google.Developers.JavaObjWrapper.GetStaticIntField(clsName:  0, name:  "com/google/android/gms/common/ConnectionResult");
        }
        public static int get_SERVICE_MISSING()
        {
            return Google.Developers.JavaObjWrapper.GetStaticIntField(clsName:  0, name:  "com/google/android/gms/common/ConnectionResult");
        }
        public static int get_SERVICE_VERSION_UPDATE_REQUIRED()
        {
            return Google.Developers.JavaObjWrapper.GetStaticIntField(clsName:  0, name:  "com/google/android/gms/common/ConnectionResult");
        }
        public static int get_SERVICE_DISABLED()
        {
            return Google.Developers.JavaObjWrapper.GetStaticIntField(clsName:  0, name:  "com/google/android/gms/common/ConnectionResult");
        }
        public static int get_SIGN_IN_REQUIRED()
        {
            return Google.Developers.JavaObjWrapper.GetStaticIntField(clsName:  0, name:  "com/google/android/gms/common/ConnectionResult");
        }
        public static int get_INVALID_ACCOUNT()
        {
            return Google.Developers.JavaObjWrapper.GetStaticIntField(clsName:  0, name:  "com/google/android/gms/common/ConnectionResult");
        }
        public static int get_RESOLUTION_REQUIRED()
        {
            return Google.Developers.JavaObjWrapper.GetStaticIntField(clsName:  0, name:  "com/google/android/gms/common/ConnectionResult");
        }
        public static int get_NETWORK_ERROR()
        {
            return Google.Developers.JavaObjWrapper.GetStaticIntField(clsName:  0, name:  "com/google/android/gms/common/ConnectionResult");
        }
        public static int get_INTERNAL_ERROR()
        {
            return Google.Developers.JavaObjWrapper.GetStaticIntField(clsName:  0, name:  "com/google/android/gms/common/ConnectionResult");
        }
        public static int get_SERVICE_INVALID()
        {
            return Google.Developers.JavaObjWrapper.GetStaticIntField(clsName:  0, name:  "com/google/android/gms/common/ConnectionResult");
        }
        public static int get_DEVELOPER_ERROR()
        {
            return Google.Developers.JavaObjWrapper.GetStaticIntField(clsName:  0, name:  "com/google/android/gms/common/ConnectionResult");
        }
        public static int get_LICENSE_CHECK_FAILED()
        {
            return Google.Developers.JavaObjWrapper.GetStaticIntField(clsName:  0, name:  "com/google/android/gms/common/ConnectionResult");
        }
        public static int get_CANCELED()
        {
            return Google.Developers.JavaObjWrapper.GetStaticIntField(clsName:  0, name:  "com/google/android/gms/common/ConnectionResult");
        }
        public static int get_TIMEOUT()
        {
            return Google.Developers.JavaObjWrapper.GetStaticIntField(clsName:  0, name:  "com/google/android/gms/common/ConnectionResult");
        }
        public static int get_INTERRUPTED()
        {
            return Google.Developers.JavaObjWrapper.GetStaticIntField(clsName:  0, name:  "com/google/android/gms/common/ConnectionResult");
        }
        public static int get_API_UNAVAILABLE()
        {
            return Google.Developers.JavaObjWrapper.GetStaticIntField(clsName:  0, name:  "com/google/android/gms/common/ConnectionResult");
        }
        public static int get_SIGN_IN_FAILED()
        {
            return Google.Developers.JavaObjWrapper.GetStaticIntField(clsName:  0, name:  "com/google/android/gms/common/ConnectionResult");
        }
        public static int get_SERVICE_UPDATING()
        {
            return Google.Developers.JavaObjWrapper.GetStaticIntField(clsName:  0, name:  "com/google/android/gms/common/ConnectionResult");
        }
        public static int get_SERVICE_MISSING_PERMISSION()
        {
            return Google.Developers.JavaObjWrapper.GetStaticIntField(clsName:  0, name:  "com/google/android/gms/common/ConnectionResult");
        }
        public static int get_DRIVE_EXTERNAL_STORAGE_REQUIRED()
        {
            return Google.Developers.JavaObjWrapper.GetStaticIntField(clsName:  0, name:  "com/google/android/gms/common/ConnectionResult");
        }
        public static object get_CREATOR()
        {
            return Google.Developers.JavaObjWrapper.GetStaticObjectField<Com.Google.Android.Gms.Games.Stats.StatsObject>(clsName:  0, name:  "com/google/android/gms/common/ConnectionResult", sig:  "CREATOR");
        }
        public static string get_NULL()
        {
            return Google.Developers.JavaObjWrapper.GetStaticStringField(clsName:  0, name:  "com/google/android/gms/common/ConnectionResult");
        }
        public static int get_CONTENTS_FILE_DESCRIPTOR()
        {
            return Google.Developers.JavaObjWrapper.GetStaticIntField(clsName:  0, name:  "com/google/android/gms/common/ConnectionResult");
        }
        public static int get_PARCELABLE_WRITE_RETURN_VALUE()
        {
            return Google.Developers.JavaObjWrapper.GetStaticIntField(clsName:  0, name:  "com/google/android/gms/common/ConnectionResult");
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
        public int describeContents()
        {
            return this.InvokeCall<System.Int32>(name:  "describeContents", sig:  "()I", args:  null);
        }
        public object getResolution()
        {
            return this.InvokeCall<System.Object>(name:  "getResolution", sig:  "()Landroid/app/PendingIntent;", args:  null);
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
        public int getErrorCode()
        {
            return this.InvokeCall<System.Int32>(name:  "getErrorCode", sig:  "()I", args:  null);
        }
        public string getErrorMessage()
        {
            return this.InvokeCall<System.String>(name:  "getErrorMessage", sig:  "()Ljava/lang/String;", args:  null);
        }
        public bool isSuccess()
        {
            return this.InvokeCall<System.Boolean>(name:  "isSuccess", sig:  "()Z", args:  null);
        }
    
    }

}

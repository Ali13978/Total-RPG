using UnityEngine;

namespace GooglePlayGames.Android
{
    internal class TokenResult : JavaObjWrapper, Result
    {
        // Methods
        public TokenResult(IntPtr ptr)
        {
        
        }
        public Com.Google.Android.Gms.Common.Api.Status getStatus()
        {
            return (Com.Google.Android.Gms.Common.Api.Status)new Com.Google.Android.Gms.Common.Api.Status(ptr:  this.InvokeCall<System.IntPtr>(name:  "getStatus", sig:  "()Lcom/google/android/gms/common/api/Status;", args:  null));
        }
        public int getStatusCode()
        {
            return this.InvokeCall<System.Int32>(name:  "getStatusCode", sig:  "()I", args:  null);
        }
        public string getAuthCode()
        {
            return this.InvokeCall<System.String>(name:  "getAuthCode", sig:  "()Ljava/lang/String;", args:  null);
        }
        public string getEmail()
        {
            return this.InvokeCall<System.String>(name:  "getEmail", sig:  "()Ljava/lang/String;", args:  null);
        }
        public string getIdToken()
        {
            return this.InvokeCall<System.String>(name:  "getIdToken", sig:  "()Ljava/lang/String;", args:  null);
        }
    
    }

}

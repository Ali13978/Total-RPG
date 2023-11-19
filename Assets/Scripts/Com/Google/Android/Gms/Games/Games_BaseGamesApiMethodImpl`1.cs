using UnityEngine;

namespace Com.Google.Android.Gms.Games
{
    public class Games_BaseGamesApiMethodImpl<R> : JavaObjWrapper
    {
        // Fields
        private const string CLASS_NAME = "com/google/android/gms/games/Games$BaseGamesApiMethodImpl";
        
        // Methods
        public Games_BaseGamesApiMethodImpl<R>(IntPtr ptr)
        {
            if(this != null)
            {
                    return;
            }
        
        }
        public Games_BaseGamesApiMethodImpl<R>(Com.Google.Android.Gms.Common.Api.GoogleApiClient arg_GoogleApiClient_1)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = arg_GoogleApiClient_1;
            this.CreateInstance(clazzName:  "com/google/android/gms/games/Games$BaseGamesApiMethodImpl", args:  null);
        }
    
    }

}

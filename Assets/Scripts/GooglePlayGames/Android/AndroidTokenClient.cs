using UnityEngine;

namespace GooglePlayGames.Android
{
    internal class AndroidTokenClient : TokenClient
    {
        // Fields
        private const string TokenFragmentClass = "com.google.games.bridge.TokenFragment";
        private const string FetchTokenSignature = "(Landroid/app/Activity;ZZZZLjava/lang/String;Z[Ljava/lang/String;ZLjava/lang/String;)Lcom/google/android/gms/common/api/PendingResult;";
        private const string FetchTokenMethod = "fetchToken";
        private const string GetAnotherAuthCodeMethod = "getAnotherAuthCode";
        private const string GetAnotherAuthCodeSignature = "(Landroid/app/Activity;ZLjava/lang/String;)Lcom/google/android/gms/common/api/PendingResult;";
        private bool requestEmail;
        private bool requestAuthCode;
        private bool requestIdToken;
        private System.Collections.Generic.List<string> oauthScopes;
        private string webClientId;
        private bool forceRefresh;
        private bool hidePopups;
        private string accountName;
        private string email;
        private string authCode;
        private string idToken;
        private static System.Action <>f__am$cache0;
        
        // Methods
        public AndroidTokenClient()
        {
        
        }
        public static UnityEngine.AndroidJavaObject CreateInvisibleView()
        {
            var val_4;
            typeof(System.Object[]).__il2cppRuntimeField_20 = GooglePlayGames.Android.AndroidTokenClient.GetActivity();
            if(null == 0)
            {
                goto label_6;
            }
            
            UnityEngine.AndroidJavaClass val_6 = null;
            if((mem[null + 258]) == 0)
            {
                goto label_7;
            }
            
            var val_4 = mem[null + 152];
            var val_5 = 0;
            val_4 = val_4 + 8;
            label_9:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_8;
            }
            
            val_5 = val_5 + 1;
            val_4 = val_4 + 16;
            if(val_5 < (mem[null + 258]))
            {
                goto label_9;
            }
            
            label_7:
            val_4 = new UnityEngine.AndroidJavaClass(className:  "com.google.games.bridge.TokenFragment");
            goto label_10;
            label_8:
            val_6 = val_6 + (((mem[null + 152] + 8)) << 4);
            label_10:
            label_6:
            if(55 == 55)
            {
                    return (UnityEngine.AndroidJavaObject)CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "createInvisibleView", args:  null);
            }
            
            if(0 == 0)
            {
                    return (UnityEngine.AndroidJavaObject)CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "createInvisibleView", args:  null);
            }
            
            return (UnityEngine.AndroidJavaObject)CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "createInvisibleView", args:  null);
        }
        public static UnityEngine.AndroidJavaObject GetActivity()
        {
            var val_3;
            if(null == 0)
            {
                goto label_2;
            }
            
            UnityEngine.AndroidJavaClass val_5 = null;
            if((mem[null + 258]) == 0)
            {
                goto label_3;
            }
            
            var val_3 = mem[null + 152];
            var val_4 = 0;
            val_3 = val_3 + 8;
            label_5:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_4;
            }
            
            val_4 = val_4 + 1;
            val_3 = val_3 + 16;
            if(val_4 < (mem[null + 258]))
            {
                goto label_5;
            }
            
            label_3:
            val_3 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
            goto label_6;
            label_4:
            val_5 = val_5 + (((mem[null + 152] + 8)) << 4);
            label_6:
            label_2:
            if(41 == 41)
            {
                    return (UnityEngine.AndroidJavaObject)GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
            }
            
            if(0 == 0)
            {
                    return (UnityEngine.AndroidJavaObject)GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
            }
            
            return (UnityEngine.AndroidJavaObject)GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
        }
        public void SetRequestAuthCode(bool flag, bool forceRefresh)
        {
            this.requestAuthCode = flag;
            this.forceRefresh = forceRefresh;
        }
        public void SetRequestEmail(bool flag)
        {
            this.requestEmail = flag;
        }
        public void SetRequestIdToken(bool flag)
        {
            this.requestIdToken = flag;
        }
        public void SetWebClientId(string webClientId)
        {
            this.webClientId = webClientId;
        }
        public void SetHidePopups(bool flag)
        {
            this.hidePopups = flag;
        }
        public void SetAccountName(string accountName)
        {
            this.accountName = accountName;
        }
        public void AddOauthScopes(string[] scopes)
        {
            System.Collections.Generic.List<System.String> val_2;
            if(scopes == null)
            {
                    return;
            }
            
            val_2 = this.oauthScopes;
            if(val_2 == null)
            {
                    System.Collections.Generic.List<System.String> val_1 = null;
                val_2 = val_1;
                val_1 = new System.Collections.Generic.List<System.String>();
                this.oauthScopes = val_2;
                if(null == 0)
            {
                    val_2 = 0;
            }
            
            }
            
            val_2.AddRange(collection:  scopes);
        }
        public void Signout()
        {
            System.Action val_2;
            this.authCode = 0;
            this.idToken = 0;
            this.email = 0;
            val_2 = GooglePlayGames.Android.AndroidTokenClient.<>f__am$cache0;
            if(val_2 == null)
            {
                    GooglePlayGames.Android.AndroidTokenClient.<>f__am$cache0 = new System.Action(object:  0, method:  static System.Void GooglePlayGames.Android.AndroidTokenClient::<Signout>m__0());
                val_2 = GooglePlayGames.Android.AndroidTokenClient.<>f__am$cache0;
            }
            
            GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  0);
        }
        public void FetchTokens(bool silent, System.Action<int> callback)
        {
            if(null != 0)
            {
                    typeof(AndroidTokenClient.<FetchTokens>c__AnonStorey0).__il2cppRuntimeField_10 = silent;
                typeof(AndroidTokenClient.<FetchTokens>c__AnonStorey0).__il2cppRuntimeField_18 = callback;
            }
            else
            {
                    mem[16] = silent;
                mem[24] = callback;
            }
            
            typeof(AndroidTokenClient.<FetchTokens>c__AnonStorey0).__il2cppRuntimeField_20 = this;
            System.Action val_4 = new System.Action(object:  new System.Object(), method:  System.Void AndroidTokenClient.<FetchTokens>c__AnonStorey0::<>m__0());
            GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  0);
        }
        internal void DoFetchToken(bool silent, System.Action<int> callback)
        {
            UnityEngine.AndroidJavaClass val_32;
            int val_33;
            int val_34;
            int val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            if(null != 0)
            {
                    typeof(AndroidTokenClient.<DoFetchToken>c__AnonStorey1).__il2cppRuntimeField_10 = callback;
            }
            else
            {
                    mem[16] = callback;
            }
            
            typeof(AndroidTokenClient.<DoFetchToken>c__AnonStorey1).__il2cppRuntimeField_18 = this;
            UnityEngine.jvalue[] val_2 = UnityEngine.AndroidJNIHelper.CreateJNIArgArray(args:  0);
            val_32 = null;
            val_32 = new UnityEngine.AndroidJavaClass(className:  "com.google.games.bridge.TokenFragment");
            UnityEngine.AndroidJavaObject val_4 = GooglePlayGames.Android.AndroidTokenClient.GetActivity();
            val_33 = val_2.Length;
            if(val_33 == 0)
            {
                    val_33 = val_2.Length;
            }
            
            val_2[0] = val_4.GetRawObject();
            if(val_33 <= 1)
            {
                    val_33 = val_2.Length;
            }
            
            val_2[1] = silent;
            if(val_33 <= 2)
            {
                    val_33 = val_2.Length;
            }
            
            val_2[2] = this.requestAuthCode;
            if(val_33 <= 3)
            {
                    val_33 = val_2.Length;
            }
            
            val_2[3] = this.requestEmail;
            val_2[4] = this.requestIdToken;
            val_34 = val_2.Length;
            if(val_34 <= 5)
            {
                    val_34 = val_2.Length;
            }
            
            val_2[5] = UnityEngine.AndroidJNI.NewStringUTF(bytes:  0);
            val_2[6] = this.forceRefresh;
            T[] val_10 = this.oauthScopes.ToArray();
            val_35 = val_2.Length;
            if(val_35 <= 7)
            {
                    val_35 = val_2.Length;
            }
            
            val_2[7] = UnityEngine.AndroidJNIHelper.ConvertToJNIArray(array:  0);
            val_2[8] = this.hidePopups;
            val_2[9] = UnityEngine.AndroidJNI.NewStringUTF(bytes:  0);
            Com.Google.Android.Gms.Common.Api.PendingResult<GooglePlayGames.Android.TokenResult> val_15 = new Com.Google.Android.Gms.Common.Api.PendingResult<GooglePlayGames.Android.TokenResult>(ptr:  UnityEngine.AndroidJNI.CallStaticObjectMethod(clazz:  0, methodID:  GetRawClass(), args:  UnityEngine.AndroidJNI.GetStaticMethodID(clazz:  0, name:  GetRawClass(), sig:  "fetchToken")));
            System.Action<System.Int32, System.String, System.String, System.String> val_16 = new System.Action<System.Int32, System.String, System.String, System.String>(object:  new System.Object(), method:  System.Void AndroidTokenClient.<DoFetchToken>c__AnonStorey1::<>m__0(int rc, string authCode, string email, string idToken));
            GooglePlayGames.Android.TokenResultCallback val_17 = new GooglePlayGames.Android.TokenResultCallback(callback:  null);
            setResultCallback(arg_ResultCallback_1:  null);
            val_36 = 0;
            if(val_4 != null)
            {
                    var val_32 = 0;
                val_32 = val_32 + 1;
                val_37 = val_4;
            }
            
            val_38 = 360;
            if((342 != 342) && (val_36 != 0))
            {
                    val_39 = 0;
                val_38 = 360;
            }
            else
            {
                    val_39 = val_36;
            }
            
            if(null == 0)
            {
                goto label_27;
            }
            
            UnityEngine.AndroidJavaClass val_35 = null;
            if((mem[null + 258]) == 0)
            {
                goto label_28;
            }
            
            var val_33 = mem[null + 152];
            var val_34 = 0;
            val_33 = val_33 + 8;
            label_30:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_29;
            }
            
            val_34 = val_34 + 1;
            val_33 = val_33 + 16;
            if(val_34 < (mem[null + 258]))
            {
                goto label_30;
            }
            
            label_28:
            val_40 = val_32;
            goto label_31;
            label_29:
            val_35 = val_35 + (((mem[null + 152] + 8)) << 4);
            label_31:
            label_27:
            if((360 != 360) && (val_39 != 0))
            {
                    val_41 = 0;
                val_42 = 414;
            }
            else
            {
                    val_42 = 414;
                val_41 = val_39;
            }
            
            label_52:
            UnityEngine.AndroidJNIHelper.DeleteJNIArgArray(args:  0, jniArgs:  null);
            if(414 == 414)
            {
                    return;
            }
            
            if(val_41 == 0)
            {
                    return;
            }
            
            label_53:
            if( != )
            {
                goto label_51;
            }
            
            goto label_52;
            label_51:
            mem[8] = ;
            goto label_53;
        }
        public string GetEmail()
        {
            return (string)this.email;
        }
        public string GetAuthCode()
        {
            return (string)this.authCode;
        }
        public void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, System.Action<string> callback)
        {
            UnityEngine.AndroidJavaClass val_29;
            int val_30;
            System.Action<System.Int32, System.String, System.String, System.String> val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            if(null != 0)
            {
                    typeof(AndroidTokenClient.<GetAnotherServerAuthCode>c__AnonStorey2).__il2cppRuntimeField_10 = callback;
            }
            else
            {
                    mem[16] = callback;
            }
            
            typeof(AndroidTokenClient.<GetAnotherServerAuthCode>c__AnonStorey2).__il2cppRuntimeField_18 = this;
            UnityEngine.jvalue[] val_2 = UnityEngine.AndroidJNIHelper.CreateJNIArgArray(args:  0);
            val_29 = null;
            val_29 = new UnityEngine.AndroidJavaClass(className:  "com.google.games.bridge.TokenFragment");
            UnityEngine.AndroidJavaObject val_4 = GooglePlayGames.Android.AndroidTokenClient.GetActivity();
            val_30 = val_2.Length;
            if(val_30 == 0)
            {
                    val_30 = val_2.Length;
            }
            
            val_2[0] = val_4.GetRawObject();
            val_2[1] = reAuthenticateIfNeeded;
            val_2[2] = UnityEngine.AndroidJNI.NewStringUTF(bytes:  0);
            Com.Google.Android.Gms.Common.Api.PendingResult<GooglePlayGames.Android.TokenResult> val_12 = new Com.Google.Android.Gms.Common.Api.PendingResult<GooglePlayGames.Android.TokenResult>(ptr:  UnityEngine.AndroidJNI.CallStaticObjectMethod(clazz:  0, methodID:  GetRawClass(), args:  UnityEngine.AndroidJNI.GetStaticMethodID(clazz:  0, name:  GetRawClass(), sig:  "getAnotherAuthCode")));
            val_31 = null;
            val_31 = new System.Action<System.Int32, System.String, System.String, System.String>(object:  new System.Object(), method:  System.Void AndroidTokenClient.<GetAnotherServerAuthCode>c__AnonStorey2::<>m__0(int rc, string authCode, string email, string idToken));
            GooglePlayGames.Android.TokenResultCallback val_14 = new GooglePlayGames.Android.TokenResultCallback(callback:  val_31);
            setResultCallback(arg_ResultCallback_1:  null);
            val_32 = 0;
            if(val_4 != null)
            {
                    var val_29 = 0;
                val_29 = val_29 + 1;
                val_33 = val_4;
            }
            
            val_34 = 217;
            if((199 != 199) && (val_32 != 0))
            {
                    val_35 = 0;
                val_34 = 217;
            }
            else
            {
                    val_35 = val_32;
            }
            
            if(null == 0)
            {
                goto label_19;
            }
            
            UnityEngine.AndroidJavaClass val_32 = null;
            if((mem[null + 258]) == 0)
            {
                goto label_20;
            }
            
            var val_30 = mem[null + 152];
            var val_31 = 0;
            val_30 = val_30 + 8;
            label_22:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_21;
            }
            
            val_31 = val_31 + 1;
            val_30 = val_30 + 16;
            if(val_31 < (mem[null + 258]))
            {
                goto label_22;
            }
            
            label_20:
            val_36 = val_29;
            goto label_23;
            label_21:
            val_32 = val_32 + (((mem[null + 152] + 8)) << 4);
            label_23:
            label_19:
            if((217 != 217) && (val_35 != 0))
            {
                    val_37 = 0;
                val_38 = 271;
            }
            else
            {
                    val_38 = 271;
                val_37 = val_35;
            }
            
            label_44:
            UnityEngine.AndroidJNIHelper.DeleteJNIArgArray(args:  0, jniArgs:  null);
            if(271 == 271)
            {
                    return;
            }
            
            if(val_37 == 0)
            {
                    return;
            }
            
            label_45:
            if( != )
            {
                goto label_43;
            }
            
            goto label_44;
            label_43:
            mem[8] = ;
            goto label_45;
        }
        public string GetIdToken()
        {
            return (string)this.idToken;
        }
        private static void <Signout>m__0()
        {
            UnityEngine.Debug.Log(message:  0);
            UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.google.games.bridge.TokenFragment");
            typeof(System.Object[]).__il2cppRuntimeField_20 = GooglePlayGames.Android.AndroidTokenClient.GetActivity();
            CallStatic(methodName:  "signOut", args:  null);
        }
    
    }

}

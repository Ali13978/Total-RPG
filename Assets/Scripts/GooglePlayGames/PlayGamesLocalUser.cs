using UnityEngine;

namespace GooglePlayGames
{
    public class PlayGamesLocalUser : PlayGamesUserProfile, ILocalUser, IUserProfile
    {
        // Fields
        internal GooglePlayGames.PlayGamesPlatform mPlatform;
        private string emailAddress;
        private GooglePlayGames.BasicApi.PlayerStats mStats;
        
        // Properties
        public UnityEngine.SocialPlatforms.IUserProfile[] friends { get; }
        public bool authenticated { get; }
        public bool underage { get; }
        public string userName { get; }
        public string id { get; }
        public bool isFriend { get; }
        public UnityEngine.SocialPlatforms.UserState state { get; }
        public string AvatarURL { get; }
        public string Email { get; }
        
        // Methods
        internal PlayGamesLocalUser(GooglePlayGames.PlayGamesPlatform plaf)
        {
            null = null;
            this = new System.Object();
            mem[1152921511901617456] = "localUser";
            mem[1152921511901617464] = System.String.Empty;
            mem[1152921511901617472] = System.String.Empty;
            mem[1152921511901617480] = 0;
            this.mPlatform = plaf;
            this.emailAddress = 0;
            this.mStats = 0;
        }
        public void Authenticate(System.Action<bool> callback)
        {
            this.mPlatform.Authenticate(callback:  callback, silent:  false);
        }
        public void Authenticate(System.Action<bool, string> callback)
        {
            this.mPlatform.Authenticate(callback:  callback, silent:  false);
        }
        public void Authenticate(System.Action<bool> callback, bool silent)
        {
            silent = silent;
            this.mPlatform.Authenticate(callback:  callback, silent:  silent);
        }
        public void Authenticate(System.Action<bool, string> callback, bool silent)
        {
            silent = silent;
            this.mPlatform.Authenticate(callback:  callback, silent:  silent);
        }
        public void LoadFriends(System.Action<bool> callback)
        {
            this.mPlatform.LoadFriends(user:  callback, callback:  callback);
        }
        public UnityEngine.SocialPlatforms.IUserProfile[] get_friends()
        {
            if(this.mPlatform != null)
            {
                    return this.mPlatform.GetFriends();
            }
            
            return this.mPlatform.GetFriends();
        }
        public string GetIdToken()
        {
            if(this.mPlatform != null)
            {
                    return this.mPlatform.GetIdToken();
            }
            
            return this.mPlatform.GetIdToken();
        }
        public bool get_authenticated()
        {
            if(this.mPlatform != null)
            {
                    return this.mPlatform.IsAuthenticated();
            }
            
            return this.mPlatform.IsAuthenticated();
        }
        public bool get_underage()
        {
            return true;
        }
        public string get_userName()
        {
            var val_7;
            GooglePlayGames.PlayGamesPlatform val_8;
            string val_9;
            val_7 = null;
            val_7 = null;
            val_8 = this.mPlatform;
            val_9 = System.String.Empty;
            if(val_8.IsAuthenticated() == false)
            {
                    return val_9;
            }
            
            val_9 = this.mPlatform.GetUserDisplayName();
            if((val_8.Equals(value:  val_9)) == true)
            {
                    return val_9;
            }
            
            val_8 = this.mPlatform.GetUserId();
            this.ResetIdentity(displayName:  val_9, playerId:  val_8, avatarUrl:  this.mPlatform.GetUserImageUrl());
            return val_9;
        }
        public string get_id()
        {
            var val_7;
            GooglePlayGames.PlayGamesPlatform val_8;
            string val_9;
            val_7 = null;
            val_7 = null;
            val_8 = this.mPlatform;
            val_9 = System.String.Empty;
            if(val_8.IsAuthenticated() == false)
            {
                    return val_9;
            }
            
            val_9 = this.mPlatform.GetUserId();
            if((val_8.Equals(value:  val_9)) == true)
            {
                    return val_9;
            }
            
            val_8 = this.mPlatform.GetUserDisplayName();
            this.ResetIdentity(displayName:  val_8, playerId:  val_9, avatarUrl:  this.mPlatform.GetUserImageUrl());
            return val_9;
        }
        public bool get_isFriend()
        {
            return true;
        }
        public UnityEngine.SocialPlatforms.UserState get_state()
        {
            return 0;
        }
        public string get_AvatarURL()
        {
            var val_7;
            GooglePlayGames.PlayGamesPlatform val_8;
            string val_9;
            val_7 = null;
            val_7 = null;
            val_8 = this.mPlatform;
            val_9 = System.String.Empty;
            if(val_8.IsAuthenticated() == false)
            {
                    return val_9;
            }
            
            val_9 = this.mPlatform.GetUserImageUrl();
            if((val_8.Equals(value:  val_9)) == true)
            {
                    return val_9;
            }
            
            val_8 = this.mPlatform.GetUserDisplayName();
            this.ResetIdentity(displayName:  val_8, playerId:  this.mPlatform.GetUserId(), avatarUrl:  val_9);
            return val_9;
        }
        public string get_Email()
        {
            var val_5;
            string val_8;
            var val_9;
            val_5 = this;
            if(this.mPlatform.IsAuthenticated() != false)
            {
                    if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    this.emailAddress = this.mPlatform.GetUserEmail();
                this.emailAddress = System.String.__il2cppRuntimeField_static_fields;
            }
            
            }
            
            if(this.mPlatform.IsAuthenticated() != false)
            {
                    val_8 = this.emailAddress;
                return (string)System.String.__il2cppRuntimeField_static_fields;
            }
            
            val_5 = 1152921504608284672;
            val_9 = null;
            val_9 = null;
            return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        public void GetStats(System.Action<GooglePlayGames.BasicApi.CommonStatusCodes, GooglePlayGames.BasicApi.PlayerStats> callback)
        {
            var val_5;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_5 = val_1;
                typeof(PlayGamesLocalUser.<GetStats>c__AnonStorey0).__il2cppRuntimeField_10 = callback;
            }
            else
            {
                    val_5 = 16;
                mem[16] = callback;
            }
            
            typeof(PlayGamesLocalUser.<GetStats>c__AnonStorey0).__il2cppRuntimeField_18 = this;
            if(this.mStats != null)
            {
                    if(this.mStats.Valid != false)
            {
                    val_5.Invoke(arg1:  0, arg2:  this.mStats);
                return;
            }
            
            }
            
            this.mPlatform.GetPlayerStats(callback:  new System.Action<GooglePlayGames.BasicApi.CommonStatusCodes, GooglePlayGames.BasicApi.PlayerStats>(object:  val_1, method:  System.Void PlayGamesLocalUser.<GetStats>c__AnonStorey0::<>m__0(GooglePlayGames.BasicApi.CommonStatusCodes rc, GooglePlayGames.BasicApi.PlayerStats stats)));
        }
    
    }

}

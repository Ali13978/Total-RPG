using UnityEngine;

namespace TzarGames.Vkontakte
{
    public class PlatformManager : MonoBehaviour
    {
        // Fields
        private TzarGames.Vkontakte.VK_Application vkApp;
        private bool applicationInitialized;
        private TzarGames.Vkontakte.VK_User user;
        private TzarGames.Vkontakte.VK_User[] friends;
        private int[] friendAppUsers;
        private System.Collections.Generic.List<TzarGames.Vkontakte.VK_Requests> requests;
        
        // Properties
        public bool ProcessingRequest { get; }
        public TzarGames.Vkontakte.VK_User User { get; }
        public bool Initialized { get; }
        public TzarGames.Vkontakte.VK_Application ApplicationData { get; }
        
        // Methods
        public PlatformManager()
        {
            this.vkApp = new TzarGames.Vkontakte.VK_Application();
            this.requests = new System.Collections.Generic.List<TzarGames.Vkontakte.VK_Requests>();
        }
        public void StartInitialization()
        {
            if((this.requests.Contains(item:  0)) != false)
            {
                    return;
            }
            
            this.requests.Add(item:  0);
            UnityEngine.Application.ExternalCall(functionName:  0, args:  "vk_initApplication");
        }
        public void DownloadUserData(string userId)
        {
            if((this.requests.Contains(item:  1)) != false)
            {
                    return;
            }
            
            this.requests.Add(item:  1);
            TzarGames.Vkontakte.PlatformManager.sendGetUserInfo(userID:  this.requests);
        }
        public bool get_ProcessingRequest()
        {
            return (bool)(this.requests.Count > 0) ? 1 : 0;
        }
        public TzarGames.Vkontakte.VK_User get_User()
        {
            return (TzarGames.Vkontakte.VK_User)this.user;
        }
        public bool get_Initialized()
        {
            return (bool)this.applicationInitialized;
        }
        public string GetAuthorizationKey()
        {
            if(this.applicationInitialized == false)
            {
                    return 0;
            }
            
            if(this.vkApp != null)
            {
                    return (string)this.vkApp.auth_key;
            }
            
            return (string)this.vkApp.auth_key;
        }
        public TzarGames.Vkontakte.VK_Application get_ApplicationData()
        {
            return (TzarGames.Vkontakte.VK_Application)this.vkApp;
        }
        public void vk_initApplication(string jsonArray)
        {
            string val_26;
            if((this.requests.Contains(item:  0)) != false)
            {
                    bool val_2 = this.requests.Remove(item:  0);
            }
            
            JSONObject val_3 = new JSONObject(str:  jsonArray, strict:  false);
            if(null != 0)
            {
                    if((HasField(name:  "api_id")) != false)
            {
                    JSONObject val_5 = GetField(name:  "api_id");
                this.vkApp.api_id = val_5.str;
            }
            
                if((HasField(name:  "api_settings")) != false)
            {
                    JSONObject val_7 = GetField(name:  "api_settings");
                this.vkApp.api_settings = val_7.str;
            }
            
                if((HasField(name:  "viewer_id")) != false)
            {
                    JSONObject val_9 = GetField(name:  "viewer_id");
                this.vkApp.viewer_id = val_9.str;
            }
            
                if((HasField(name:  "viewer_type")) != false)
            {
                    JSONObject val_11 = GetField(name:  "viewer_type");
                this.vkApp.viewer_type = val_11.str;
            }
            
                if((HasField(name:  "sid")) != false)
            {
                    JSONObject val_13 = GetField(name:  "sid");
                this.vkApp.sid = val_13.str;
            }
            
                if((HasField(name:  "secret")) != false)
            {
                    JSONObject val_15 = GetField(name:  "secret");
                this.vkApp.secret = val_15.str;
            }
            
                if((HasField(name:  "access_token")) != false)
            {
                    JSONObject val_17 = GetField(name:  "access_token");
                this.vkApp.access_token = val_17.str;
            }
            
                if((HasField(name:  "user_id")) != false)
            {
                    JSONObject val_19 = GetField(name:  "user_id");
                this.vkApp.user_id = val_19.str;
            }
            
                if((HasField(name:  "group_id")) != false)
            {
                    JSONObject val_21 = GetField(name:  "group_id");
                this.vkApp.group_id = val_21.str;
            }
            
                val_26 = "is_app_user";
                if((HasField(name:  "is_app_user")) != false)
            {
                    JSONObject val_23 = GetField(name:  "is_app_user");
                val_26 = val_23.str;
                this.vkApp.is_app_user = val_26;
            }
            
                if((HasField(name:  "auth_key")) != false)
            {
                    val_26 = this.vkApp;
                JSONObject val_25 = GetField(name:  "auth_key");
                this.vkApp.auth_key = val_25.str;
            }
            
                this.applicationInitialized = true;
                return;
            }
            
            UnityEngine.Debug.Log(message:  0);
        }
        private static void sendGetUserInfo(string userID)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = X1;
            UnityEngine.Application.ExternalCall(functionName:  0, args:  "vk_getUserInfo");
        }
        private void vk_loadUserInfo(string jsonResponse)
        {
            var val_5;
            System.Collections.Generic.List<TzarGames.Vkontakte.VK_Requests> val_6;
            var val_7;
            var val_8;
            object val_9;
            val_5 = this;
            val_6 = this.requests;
            val_7 = val_6;
            if((val_7.Contains(item:  1)) != false)
            {
                    val_6 = this.requests;
                val_7 = val_6;
            }
            
            if(this.applicationInitialized == false)
            {
                goto label_4;
            }
            
            TzarGames.Vkontakte.VK_User[] val_3 = TzarGames.Vkontakte.PlatformManager.getVkUsersFromJson(jsonResponse:  val_7.Remove(item:  1));
            if(val_3 == null)
            {
                goto label_5;
            }
            
            if(val_3.Length == 0)
            {
                goto label_6;
            }
            
            if(val_3.Length >= 2)
            {
                goto label_7;
            }
            
            this.user = val_3[0];
            return;
            label_4:
            val_8 = "loadUserInfo: application not initialized";
            val_9 = 0;
            goto label_14;
            label_5:
            val_8 = "failed to load user info";
            val_9 = 0;
            goto label_14;
            label_6:
            val_8 = "0 users loaded";
            val_9 = 0;
            label_14:
            UnityEngine.Debug.Log(message:  val_9);
            return;
            label_7:
            val_5 = 0 + "Users loaded: "("Users loaded: ");
            UnityEngine.Debug.Log(message:  0);
        }
        private static TzarGames.Vkontakte.VK_User[] getVkUsersFromJson(string jsonResponse)
        {
            var val_21;
            var val_22;
            string val_23;
            var val_24;
            float val_25;
            JSONObject val_1 = new JSONObject(str:  X1, strict:  false);
            val_21 = 0;
            if(null == 0)
            {
                    return (TzarGames.Vkontakte.VK_User[])val_21;
            }
            
            val_21 = 0;
            if(Count < 1)
            {
                    return (TzarGames.Vkontakte.VK_User[])val_21;
            }
            
            val_22 = Count;
            val_21 = null;
            if(Count < 1)
            {
                    return (TzarGames.Vkontakte.VK_User[])val_21;
            }
            
            do
            {
                JSONObject val_5 = Item[0];
                if(val_5 != null)
            {
                    TzarGames.Vkontakte.VK_User val_6 = null;
                val_23 = val_6;
                val_6 = new TzarGames.Vkontakte.VK_User();
                typeof(TzarGames.Vkontakte.VK_User[]).__il2cppRuntimeField_20 = val_23;
                if((val_5.HasField(name:  "uid")) != false)
            {
                    val_24 = typeof(TzarGames.Vkontakte.VK_User[]).__il2cppRuntimeField_20;
                val_23 = val_5.GetField(name:  "uid");
                val_25 = val_8.n;
                typeof(TzarGames.Vkontakte.VK_User).__il2cppRuntimeField_10 = (int)val_25;
            }
            
                if((val_5.HasField(name:  "first_name")) != false)
            {
                    val_24 = typeof(TzarGames.Vkontakte.VK_User[]).__il2cppRuntimeField_20;
                JSONObject val_10 = val_5.GetField(name:  "first_name");
                val_23 = val_10.str;
                typeof(TzarGames.Vkontakte.VK_User).__il2cppRuntimeField_18 = val_23;
            }
            
                if((val_5.HasField(name:  "last_name")) != false)
            {
                    val_24 = typeof(TzarGames.Vkontakte.VK_User[]).__il2cppRuntimeField_20;
                JSONObject val_12 = val_5.GetField(name:  "last_name");
                val_23 = val_12.str;
                typeof(TzarGames.Vkontakte.VK_User).__il2cppRuntimeField_20 = val_23;
            }
            
                if((val_5.HasField(name:  "online")) != false)
            {
                    val_24 = typeof(TzarGames.Vkontakte.VK_User[]).__il2cppRuntimeField_20;
                val_23 = val_5.GetField(name:  "online");
                val_25 = val_14.n;
                typeof(TzarGames.Vkontakte.VK_User).__il2cppRuntimeField_28 = (val_25 > 0f) ? 1 : 0;
            }
            
                if((val_5.HasField(name:  "photo_medium")) != false)
            {
                    val_24 = typeof(TzarGames.Vkontakte.VK_User[]).__il2cppRuntimeField_20;
                JSONObject val_17 = val_5.GetField(name:  "photo_medium");
                val_23 = val_17.str;
                typeof(TzarGames.Vkontakte.VK_User).__il2cppRuntimeField_30 = val_23;
            }
            
                if((val_5.HasField(name:  "photo_200")) != false)
            {
                    val_23 = typeof(TzarGames.Vkontakte.VK_User[]).__il2cppRuntimeField_20;
                JSONObject val_19 = val_5.GetField(name:  "photo_200");
                typeof(TzarGames.Vkontakte.VK_User).__il2cppRuntimeField_40 = val_19.str;
            }
            
            }
            
                val_22 = 0 + 1;
            }
            while(val_22 < Count);
            
            return (TzarGames.Vkontakte.VK_User[])val_21;
        }
        private void vk_loadFriends(string jsonResponse)
        {
            System.Collections.Generic.List<TzarGames.Vkontakte.VK_Requests> val_5;
            var val_6;
            val_5 = this.requests;
            val_6 = val_5;
            if((val_6.Contains(item:  2)) != false)
            {
                    val_5 = this.requests;
                val_6 = val_5;
            }
            
            TzarGames.Vkontakte.VK_User[] val_3 = TzarGames.Vkontakte.PlatformManager.getVkUsersFromJson(jsonResponse:  val_6.Remove(item:  2));
            this.friends = val_3;
            if(val_3 != null)
            {
                    string val_4 = 0 + "friends loaded: "("friends loaded: ");
                UnityEngine.Debug.Log(message:  0);
                return;
            }
            
            UnityEngine.Debug.Log(message:  0);
        }
        public void DownloadFriendsInfo()
        {
            if((this.requests.Contains(item:  2)) != false)
            {
                    return;
            }
            
            this.requests.Add(item:  2);
            UnityEngine.Application.ExternalCall(functionName:  0, args:  "vk_getFriends");
        }
        public void DownloadFriendAppUsers()
        {
            if((this.requests.Contains(item:  3)) != false)
            {
                    return;
            }
            
            this.requests.Add(item:  3);
            UnityEngine.Application.ExternalCall(functionName:  0, args:  "vk_getFriendsAppUsers");
        }
        private void vk_loadAppUsers(string jsonResponse)
        {
            string val_8 = jsonResponse;
            if((this.requests.Contains(item:  3)) != false)
            {
                    bool val_2 = this.requests.Remove(item:  3);
            }
            
            JSONObject val_3 = new JSONObject(str:  val_8 = jsonResponse, strict:  false);
            if(null == 0)
            {
                    return;
            }
            
            int val_4 = Count;
            val_8 = null;
            this.friendAppUsers = val_8;
            if(Count < 1)
            {
                    return;
            }
            
            do
            {
                JSONObject val_6 = Item[0];
                this.friendAppUsers[0] = (int)val_6.n;
                val_8 = 0 + 1;
            }
            while(val_8 < Count);
        
        }
        public TzarGames.Vkontakte.VK_User[] GetFriendAppUsers()
        {
            var val_2;
            System.Collections.Generic.List<TzarGames.Vkontakte.VK_User> val_1 = new System.Collections.Generic.List<TzarGames.Vkontakte.VK_User>();
            if(((((this.friends == null) || (this.friends.Length < 1)) || (this.friendAppUsers == null)) || (this.friendAppUsers.Length < 1)) || (this.friendAppUsers.Length < 1))
            {
                goto label_5;
            }
            
            label_15:
            val_2 = 0;
            goto label_7;
            label_14:
            val_2 = 1;
            label_7:
            if(val_2 >= this.friends.Length)
            {
                goto label_9;
            }
            
            if(this.friends[0x1][0].uid != this.friendAppUsers[0])
            {
                goto label_14;
            }
            
            Add(item:  this.friends[1]);
            goto label_14;
            label_9:
            if((0 + 1) < this.friendAppUsers.Length)
            {
                goto label_15;
            }
            
            label_5:
            if(null != 0)
            {
                    return ToArray();
            }
            
            return ToArray();
        }
    
    }

}

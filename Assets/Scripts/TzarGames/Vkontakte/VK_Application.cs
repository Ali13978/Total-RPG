using UnityEngine;

namespace TzarGames.Vkontakte
{
    public class VK_Application
    {
        // Fields
        public string api_id;
        public string api_settings;
        public string viewer_id;
        public string viewer_type;
        public string sid;
        public string secret;
        public string access_token;
        public string user_id;
        public string group_id;
        public string is_app_user;
        public string auth_key;
        
        // Methods
        public VK_Application()
        {
            this.api_id = "wrong api_id";
            this.api_settings = "wrong api_settings";
            this.viewer_id = "wrong viewer_id";
            this.viewer_type = "wrong viewer_type";
            this.sid = "wrong sid";
            this.secret = "wrong secret";
            this.access_token = "wrong access_token";
            this.user_id = "wrong user_id";
            this.group_id = "wrong group_id";
            this.is_app_user = "wrong is_app_user";
            this.auth_key = "wrong auth_key";
        }
    
    }

}

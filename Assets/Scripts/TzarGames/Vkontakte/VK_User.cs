using UnityEngine;

namespace TzarGames.Vkontakte
{
    public class VK_User
    {
        // Fields
        public int uid;
        public string first_name;
        public string last_name;
        public bool online;
        public string photo_medium_url;
        public UnityEngine.Texture photo_medium_image;
        public string photo_200;
        
        // Methods
        public VK_User()
        {
            var val_1;
            this.uid = 0;
            this.first_name = "UnknownFirstName";
            this.last_name = "UnknownLastName";
            val_1 = null;
            val_1 = null;
            this.photo_medium_url = System.String.Empty;
            this.photo_200 = System.String.Empty;
        }
    
    }

}

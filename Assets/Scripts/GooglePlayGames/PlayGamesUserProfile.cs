using UnityEngine;

namespace GooglePlayGames
{
    public class PlayGamesUserProfile : IUserProfile
    {
        // Fields
        private string mDisplayName;
        private string mPlayerId;
        private string mAvatarUrl;
        private bool mImageLoading;
        private UnityEngine.Texture2D mImage;
        
        // Properties
        public string userName { get; }
        public string id { get; }
        public bool isFriend { get; }
        public UnityEngine.SocialPlatforms.UserState state { get; }
        public UnityEngine.Texture2D image { get; }
        public string AvatarURL { get; }
        
        // Methods
        internal PlayGamesUserProfile(string displayName, string playerId, string avatarUrl)
        {
            val_1 = new System.Object();
            this.mDisplayName = displayName;
            this.mPlayerId = val_1;
            this.mAvatarUrl = avatarUrl;
            this.mImageLoading = false;
        }
        protected void ResetIdentity(string displayName, string playerId, string avatarUrl)
        {
            this.mDisplayName = displayName;
            this.mPlayerId = playerId;
            if((System.String.op_Inequality(a:  0, b:  this.mAvatarUrl)) != false)
            {
                    this.mImage = 0;
                this.mAvatarUrl = avatarUrl;
            }
            
            this.mImageLoading = false;
        }
        public string get_userName()
        {
            return (string)this.mDisplayName;
        }
        public string get_id()
        {
            return (string)this.mPlayerId;
        }
        public bool get_isFriend()
        {
            return true;
        }
        public UnityEngine.SocialPlatforms.UserState get_state()
        {
            return 0;
        }
        public UnityEngine.Texture2D get_image()
        {
            System.Collections.IEnumerator val_6;
            if(this.mImageLoading == true)
            {
                    return (UnityEngine.Texture2D)this.mImage;
            }
            
            if(0 != this.mImage)
            {
                    return (UnityEngine.Texture2D)this.mImage;
            }
            
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                    return (UnityEngine.Texture2D)this.mImage;
            }
            
            string val_4 = 0 + "Starting to load image: "("Starting to load image: ");
            UnityEngine.Debug.Log(message:  0);
            this.mImageLoading = true;
            System.Collections.IEnumerator val_5 = this.LoadImage();
            val_6 = null;
            GooglePlayGames.OurUtils.PlayGamesHelperObject.RunCoroutine(action:  val_6);
            return (UnityEngine.Texture2D)this.mImage;
        }
        public string get_AvatarURL()
        {
            return (string)this.mAvatarUrl;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        internal System.Collections.IEnumerator LoadImage()
        {
            typeof(PlayGamesUserProfile.<LoadImage>c__Iterator0).__il2cppRuntimeField_18 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public override bool Equals(object obj)
        {
            var val_4;
            if(obj != null)
            {
                    if((System.Object.ReferenceEquals(objA:  0, objB:  this)) != false)
            {
                    val_4 = 1;
                return (bool)val_4;
            }
            
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        public override int GetHashCode()
        {
            string val_2 = this.mPlayerId;
            val_2 = val_2 ^ (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            return (int)val_2;
        }
        public override string ToString()
        {
            return System.String.Format(format:  0, arg0:  "[Player: \'{0}\' (id {1})]", arg1:  this.mDisplayName);
        }
    
    }

}

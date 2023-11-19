using UnityEngine;

namespace GooglePlayGames
{
    internal class PlayGamesClientFactory
    {
        // Methods
        public PlayGamesClientFactory()
        {
        
        }
        internal static GooglePlayGames.BasicApi.IPlayGamesClient GetPlatformPlayGamesClient(GooglePlayGames.BasicApi.PlayGamesClientConfiguration config)
        {
            var val_7;
            string val_8;
            var val_9;
            string val_10;
            val_7 = 0;
            if(UnityEngine.Application.isEditor != false)
            {
                    val_8 = null;
                GooglePlayGames.OurUtils.Logger.d(msg:  val_8);
                GooglePlayGames.BasicApi.DummyClient val_4 = null;
                val_9 = val_4;
                val_4 = new GooglePlayGames.BasicApi.DummyClient();
                return (GooglePlayGames.BasicApi.IPlayGamesClient)val_9;
            }
            
            val_10 = null;
            GooglePlayGames.OurUtils.Logger.d(msg:  val_10);
            GooglePlayGames.Native.NativeClient val_6 = null;
            val_9 = val_6;
            val_6 = new GooglePlayGames.Native.NativeClient(configuration:  new GooglePlayGames.BasicApi.PlayGamesClientConfiguration() {mEnableSavedGames = X1, mScopes = X1, mRequestAuthCode = X1 + 16, mForceRefresh = X1 + 16, mHidePopups = X1 + 16, mRequestEmail = X1 + 16, mRequestIdToken = X1 + 16, mAccountName = X1 + 16, mInvitationDelegate = X1 + 32, mMatchDelegate = X1 + 32}, clientImpl:  new GooglePlayGames.Android.AndroidClient());
            return (GooglePlayGames.BasicApi.IPlayGamesClient)val_9;
        }
    
    }

}

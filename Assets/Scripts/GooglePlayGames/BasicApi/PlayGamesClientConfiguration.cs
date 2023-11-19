using UnityEngine;

namespace GooglePlayGames.BasicApi
{
    public struct PlayGamesClientConfiguration
    {
        // Fields
        public static readonly GooglePlayGames.BasicApi.PlayGamesClientConfiguration DefaultConfiguration;
        private readonly bool mEnableSavedGames;
        private readonly string[] mScopes;
        private readonly bool mRequestAuthCode;
        private readonly bool mForceRefresh;
        private readonly bool mHidePopups;
        private readonly bool mRequestEmail;
        private readonly bool mRequestIdToken;
        private readonly string mAccountName;
        private readonly GooglePlayGames.BasicApi.InvitationReceivedDelegate mInvitationDelegate;
        private readonly GooglePlayGames.BasicApi.Multiplayer.MatchDelegate mMatchDelegate;
        
        // Properties
        public bool EnableSavedGames { get; }
        public bool IsHidingPopups { get; }
        public bool IsRequestingAuthCode { get; }
        public bool IsForcingRefresh { get; }
        public bool IsRequestingEmail { get; }
        public bool IsRequestingIdToken { get; }
        public string AccountName { get; }
        public string[] Scopes { get; }
        public GooglePlayGames.BasicApi.InvitationReceivedDelegate InvitationDelegate { get; }
        public GooglePlayGames.BasicApi.Multiplayer.MatchDelegate MatchDelegate { get; }
        
        // Methods
        private PlayGamesClientConfiguration(GooglePlayGames.BasicApi.PlayGamesClientConfiguration.Builder builder)
        {
        
        }
        public bool get_EnableSavedGames()
        {
            return (bool)this.mRequestAuthCode;
        }
        public bool get_IsHidingPopups()
        {
            return (bool)this;
        }
        public bool get_IsRequestingAuthCode()
        {
            return (bool)this.mInvitationDelegate;
        }
        public bool get_IsForcingRefresh()
        {
            return (bool)this;
        }
        public bool get_IsRequestingEmail()
        {
            return (bool)this;
        }
        public bool get_IsRequestingIdToken()
        {
            return (bool)this;
        }
        public string get_AccountName()
        {
            return (string)this.mMatchDelegate;
        }
        public string[] get_Scopes()
        {
            return (System.String[])this.mAccountName;
        }
        public GooglePlayGames.BasicApi.InvitationReceivedDelegate get_InvitationDelegate()
        {
            return (GooglePlayGames.BasicApi.InvitationReceivedDelegate)this;
        }
        public GooglePlayGames.BasicApi.Multiplayer.MatchDelegate get_MatchDelegate()
        {
            return (GooglePlayGames.BasicApi.Multiplayer.MatchDelegate)this;
        }
        private static PlayGamesClientConfiguration()
        {
            PlayGamesClientConfiguration.Builder val_1 = new PlayGamesClientConfiguration.Builder();
            GooglePlayGames.BasicApi.PlayGamesClientConfiguration.DefaultConfiguration.__il2cppRuntimeField_20 = 0;
            GooglePlayGames.BasicApi.PlayGamesClientConfiguration.DefaultConfiguration.__il2cppRuntimeField_10 = 0;
            GooglePlayGames.BasicApi.PlayGamesClientConfiguration.DefaultConfiguration = 0;
        }
    
    }

}

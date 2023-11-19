using UnityEngine;

namespace GooglePlayGames
{
    internal interface TokenClient
    {
        // Methods
        public abstract string GetEmail(); // 0
        public abstract string GetAuthCode(); // 0
        public abstract string GetIdToken(); // 0
        public abstract void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, System.Action<string> callback); // 0
        public abstract void Signout(); // 0
        public abstract void SetRequestAuthCode(bool flag, bool forceRefresh); // 0
        public abstract void SetRequestEmail(bool flag); // 0
        public abstract void SetRequestIdToken(bool flag); // 0
        public abstract void SetWebClientId(string webClientId); // 0
        public abstract void SetAccountName(string accountName); // 0
        public abstract void AddOauthScopes(string[] scopes); // 0
        public abstract void SetHidePopups(bool flag); // 0
        public abstract void FetchTokens(bool silent, System.Action<int> callback); // 0
    
    }

}

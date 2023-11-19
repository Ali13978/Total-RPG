using UnityEngine;

namespace GooglePlayGames
{
    internal interface IClientImpl
    {
        // Methods
        public abstract GooglePlayGames.Native.PInvoke.PlatformConfiguration CreatePlatformConfiguration(GooglePlayGames.BasicApi.PlayGamesClientConfiguration clientConfig); // 0
        public abstract GooglePlayGames.TokenClient CreateTokenClient(bool reset); // 0
        public abstract void GetPlayerStats(IntPtr apiClientPtr, System.Action<GooglePlayGames.BasicApi.CommonStatusCodes, GooglePlayGames.BasicApi.PlayerStats> callback); // 0
        public abstract void SetGravityForPopups(IntPtr apiClient, GooglePlayGames.BasicApi.Gravity gravity); // 0
    
    }

}

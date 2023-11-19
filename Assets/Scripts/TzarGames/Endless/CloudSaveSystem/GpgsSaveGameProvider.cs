using UnityEngine;

namespace TzarGames.Endless.CloudSaveSystem
{
    internal class GpgsSaveGameProvider : ICloudSaveGameProvider
    {
        // Methods
        public GpgsSaveGameProvider()
        {
        
        }
        public void GetSaveGames(System.Action<TzarGames.Endless.CloudSaveSystem.ICloudGetSaveGameListResult> callback)
        {
            typeof(GpgsSaveGameProvider.<GetSaveGames>c__AnonStorey0).__il2cppRuntimeField_10 = callback;
            TzarGames.Endless.CloudSaveSystem.GpgsSaveGameProvider.checkAuth(callback:  new System.Action<System.Boolean>(object:  new System.Object(), method:  System.Void GpgsSaveGameProvider.<GetSaveGames>c__AnonStorey0::<>m__0(bool result)) = new System.Action<System.Boolean>(object:  new System.Object(), method:  System.Void GpgsSaveGameProvider.<GetSaveGames>c__AnonStorey0::<>m__0(bool result)));
        }
        private static void checkAuth(System.Action<bool> callback)
        {
            var val_4;
            UnityEngine.SocialPlatforms.ILocalUser val_1 = UnityEngine.Social.localUser;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = val_1;
            if(((val_1 & 1) & 1) != 0)
            {
                    X1.Invoke(obj:  true);
                return;
            }
            
            X1.Invoke(obj:  false);
        }
        public void Write(string file, System.TimeSpan playedTime, string description, byte[] data, System.Action<TzarGames.Endless.CloudSaveSystem.ICloudSaveWriteResult> callback)
        {
            if(null != 0)
            {
                    typeof(GpgsSaveGameProvider.<Write>c__AnonStorey1).__il2cppRuntimeField_10 = file;
                typeof(GpgsSaveGameProvider.<Write>c__AnonStorey1).__il2cppRuntimeField_18 = playedTime._ticks;
                typeof(GpgsSaveGameProvider.<Write>c__AnonStorey1).__il2cppRuntimeField_20 = description;
                typeof(GpgsSaveGameProvider.<Write>c__AnonStorey1).__il2cppRuntimeField_28 = data;
            }
            else
            {
                    mem[16] = file;
                mem[24] = playedTime._ticks;
                mem[32] = description;
                mem[40] = data;
            }
            
            typeof(GpgsSaveGameProvider.<Write>c__AnonStorey1).__il2cppRuntimeField_30 = callback;
            TzarGames.Endless.CloudSaveSystem.GpgsSaveGameProvider.checkAuth(callback:  new System.Action<System.Boolean>(object:  new System.Object(), method:  System.Void GpgsSaveGameProvider.<Write>c__AnonStorey1::<>m__0(bool result)) = new System.Action<System.Boolean>(object:  new System.Object(), method:  System.Void GpgsSaveGameProvider.<Write>c__AnonStorey1::<>m__0(bool result)));
        }
        public void Read(string file, System.Action<TzarGames.Endless.CloudSaveSystem.ICloudSaveReadResult> callback)
        {
            if(null != 0)
            {
                    typeof(GpgsSaveGameProvider.<Read>c__AnonStorey2).__il2cppRuntimeField_10 = file;
            }
            else
            {
                    mem[16] = file;
            }
            
            typeof(GpgsSaveGameProvider.<Read>c__AnonStorey2).__il2cppRuntimeField_18 = callback;
            TzarGames.Endless.CloudSaveSystem.GpgsSaveGameProvider.checkAuth(callback:  new System.Action<System.Boolean>(object:  new System.Object(), method:  System.Void GpgsSaveGameProvider.<Read>c__AnonStorey2::<>m__0(bool result)) = new System.Action<System.Boolean>(object:  new System.Object(), method:  System.Void GpgsSaveGameProvider.<Read>c__AnonStorey2::<>m__0(bool result)));
        }
        public bool IsReady()
        {
            var val_3;
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = UnityEngine.Social.localUser;
        }
        public void Initialize()
        {
        
        }
        private static void gpgs_read(string file, System.Action<TzarGames.Endless.CloudSaveSystem.ICloudSaveReadResult> callback)
        {
            object val_1 = new System.Object();
            typeof(GpgsSaveGameProvider.<gpgs_read>c__AnonStorey3).__il2cppRuntimeField_10 = X2;
            typeof(GpgsSaveGameProvider.<gpgs_read>c__AnonStorey3).__il2cppRuntimeField_18 = new System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, System.Byte[]>(object:  val_1, method:  System.Void GpgsSaveGameProvider.<gpgs_read>c__AnonStorey3::<>m__0(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus status, byte[] data));
            System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> val_3 = new System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>(object:  val_1, method:  System.Void GpgsSaveGameProvider.<gpgs_read>c__AnonStorey3::<>m__1(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus status, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata game));
            UnityEngine.Debug.Log(message:  0);
            TzarGames.Endless.CloudSaveSystem.GpgsSaveGameProvider.gpgs_readSavedGame(filename:  0, callback:  callback);
        }
        private static void gpgs_write(string file, System.TimeSpan playedTime, string description, byte[] saveData, System.Action<TzarGames.Endless.CloudSaveSystem.ICloudSaveWriteResult> callback)
        {
            object val_1 = new System.Object();
            if(null != 0)
            {
                    typeof(GpgsSaveGameProvider.<gpgs_write>c__AnonStorey4).__il2cppRuntimeField_10 = X5;
                typeof(GpgsSaveGameProvider.<gpgs_write>c__AnonStorey4).__il2cppRuntimeField_20 = description;
                typeof(GpgsSaveGameProvider.<gpgs_write>c__AnonStorey4).__il2cppRuntimeField_28 = saveData;
                typeof(GpgsSaveGameProvider.<gpgs_write>c__AnonStorey4).__il2cppRuntimeField_30 = callback;
            }
            else
            {
                    mem[16] = X5;
                mem[32] = description;
                mem[40] = saveData;
                mem[48] = callback;
            }
            
            typeof(GpgsSaveGameProvider.<gpgs_write>c__AnonStorey4).__il2cppRuntimeField_18 = 0;
            typeof(GpgsSaveGameProvider.<gpgs_write>c__AnonStorey4).__il2cppRuntimeField_38 = new System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>(object:  val_1, method:  System.Void GpgsSaveGameProvider.<gpgs_write>c__AnonStorey4::<>m__0(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus status, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata game));
            System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> val_3 = new System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>(object:  val_1, method:  System.Void GpgsSaveGameProvider.<gpgs_write>c__AnonStorey4::<>m__1(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus status, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata game));
            UnityEngine.Debug.Log(message:  0);
            TzarGames.Endless.CloudSaveSystem.GpgsSaveGameProvider.gpgs_readSavedGame(filename:  0, callback:  playedTime._ticks);
        }
        private static void gpgs_readSavedGame(string filename, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> callback)
        {
            var val_4;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = GooglePlayGames.PlayGamesPlatform.Instance.SavedGame;
        }
        private static void gpgs_writeSavedGame(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata game, System.TimeSpan playedTime, string description, byte[] savedData, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> callback)
        {
            var val_13;
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_13 = GooglePlayGames.PlayGamesPlatform.Instance.SavedGame;
        }
        private static void gpgs_getSaveGames(System.Action<TzarGames.Endless.CloudSaveSystem.ICloudGetSaveGameListResult> callback)
        {
            var val_6;
            typeof(GpgsSaveGameProvider.<gpgs_getSaveGames>c__AnonStorey5).__il2cppRuntimeField_10 = X1;
            System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, System.Collections.Generic.List<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>> val_4 = new System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, System.Collections.Generic.List<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>>(object:  new System.Object(), method:  System.Void GpgsSaveGameProvider.<gpgs_getSaveGames>c__AnonStorey5::<>m__0(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus status, System.Collections.Generic.List<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> list));
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_6 = GooglePlayGames.PlayGamesPlatform.Instance.SavedGame;
            goto mem[.ctor(object:  val_1, method:  System.Void GpgsSaveGameProvider.<gpgs_getSaveGames>c__AnonStorey5::<>m__0(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus status, System.Collections.Generic.List<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> list))];
        }
    
    }

}

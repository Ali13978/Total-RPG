using UnityEngine;

namespace TzarGames.Endless.CloudSaveSystem
{
    public static class CloudSaveGame
    {
        // Fields
        private static TzarGames.Endless.CloudSaveSystem.ICloudSaveGameProvider _provider;
        
        // Methods
        private static TzarGames.Endless.CloudSaveSystem.ICloudSaveGameProvider getProvider()
        {
            TzarGames.Endless.CloudSaveSystem.ICloudSaveGameProvider val_2;
            TzarGames.Endless.CloudSaveSystem.ICloudSaveGameProvider val_3 = TzarGames.Endless.CloudSaveSystem.CloudSaveGame._provider;
            if(val_3 != null)
            {
                    return val_3;
            }
            
            object val_1 = null;
            val_2 = val_1;
            val_1 = new System.Object();
            TzarGames.Endless.CloudSaveSystem.CloudSaveGame._provider = val_2;
            val_3 = TzarGames.Endless.CloudSaveSystem.CloudSaveGame._provider;
            return val_3;
        }
        public static void GetSaveGames(System.Action<TzarGames.Endless.CloudSaveSystem.ICloudGetSaveGameListResult> callback)
        {
            var val_3;
            TzarGames.Endless.CloudSaveSystem.ICloudSaveGameProvider val_1 = TzarGames.Endless.CloudSaveSystem.CloudSaveGame.getProvider();
            if(val_1 == null)
            {
                    return;
            }
            
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = val_1;
        }
        public static void Write(string file, System.TimeSpan playedTime, string description, byte[] data, System.Action<TzarGames.Endless.CloudSaveSystem.ICloudSaveWriteResult> callback)
        {
            var val_3;
            TzarGames.Endless.CloudSaveSystem.ICloudSaveGameProvider val_1 = TzarGames.Endless.CloudSaveSystem.CloudSaveGame.getProvider();
            if(val_1 == null)
            {
                    return;
            }
            
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = val_1;
        }
        public static void Read(string file, System.Action<TzarGames.Endless.CloudSaveSystem.ICloudSaveReadResult> callback)
        {
            var val_3;
            TzarGames.Endless.CloudSaveSystem.ICloudSaveGameProvider val_1 = TzarGames.Endless.CloudSaveSystem.CloudSaveGame.getProvider();
            if(val_1 == null)
            {
                    return;
            }
            
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = val_1;
        }
        public static bool IsReady()
        {
            var val_3;
            TzarGames.Endless.CloudSaveSystem.ICloudSaveGameProvider val_1 = TzarGames.Endless.CloudSaveSystem.CloudSaveGame.getProvider();
            if(val_1 == null)
            {
                    return false;
            }
            
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = val_1;
        }
        public static void Initialize()
        {
            var val_3;
            TzarGames.Endless.CloudSaveSystem.ICloudSaveGameProvider val_1 = TzarGames.Endless.CloudSaveSystem.CloudSaveGame.getProvider();
            if(val_1 == null)
            {
                    return;
            }
            
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = val_1;
        }
    
    }

}

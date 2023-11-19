using UnityEngine;

namespace TzarGames.Endless
{
    public class AppSettings
    {
        // Fields
        private const string SFX_VOLUME_KEY = "SFX_VOLUME_KEY";
        private const string MUSIC_VOLUME_KEY = "MUSIC_VOLUME_KEY";
        private const string GAME_ALLOW_MULTIPLAYER_IN_LOBBY = "GAME_ALLOW_MULTIPLAYER_IN_LOBBY";
        
        // Properties
        public static float SfxVolume { get; set; }
        public static float MusicVolume { get; set; }
        public static bool AllowMultiplayerInLobby { get; set; }
        
        // Methods
        public AppSettings()
        {
        
        }
        public static float get_SfxVolume()
        {
            return UnityEngine.PlayerPrefs.GetFloat(key:  0, defaultValue:  1f);
        }
        public static void set_SfxVolume(float value)
        {
            UnityEngine.PlayerPrefs.SetFloat(key:  0, value:  value);
        }
        public static float get_MusicVolume()
        {
            return UnityEngine.PlayerPrefs.GetFloat(key:  0, defaultValue:  1f);
        }
        public static void set_MusicVolume(float value)
        {
            UnityEngine.PlayerPrefs.SetFloat(key:  0, value:  value);
        }
        public static bool get_AllowMultiplayerInLobby()
        {
            return (bool)((UnityEngine.PlayerPrefs.GetInt(key:  0, defaultValue:  1653208320)) > 0) ? 1 : 0;
        }
        public static void set_AllowMultiplayerInLobby(bool value)
        {
            var val_1 = W1 & 1;
            UnityEngine.PlayerPrefs.SetInt(key:  0, value:  1653208320);
        }
        [TzarGames.Common.ConsoleCommand]
        private static void setVsyncCount(int mode)
        {
            UnityEngine.QualitySettings.vSyncCount = 0;
        }
        [TzarGames.Common.ConsoleCommand]
        private static void setTargetFramerate(int frameRate)
        {
            UnityEngine.Application.targetFrameRate = 0;
        }
    
    }

}

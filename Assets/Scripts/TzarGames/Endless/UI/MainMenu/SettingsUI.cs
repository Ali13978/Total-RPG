using UnityEngine;

namespace TzarGames.Endless.UI.MainMenu
{
    public class SettingsUI : UIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI version;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject socialAuthButton;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject restorePurchasesButton;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Slider sfxSlider;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Slider musicSlider;
        private float lastSfxVolume;
        private float lastMusicVolume;
        [UnityEngine.SerializeField]
        private UnityEngine.Audio.AudioMixer musicMixer;
        [UnityEngine.SerializeField]
        private UnityEngine.Audio.AudioMixer sfxMixer;
        [UnityEngine.SerializeField]
        private float mixerMinValue;
        [UnityEngine.SerializeField]
        private float checkUpdateInterval;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.MainMenu.RestoreSaveDataUI restoreSaveUI;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Toggle lobbyMultiplayerToggle;
        private float lastCheckTime;
        [UnityEngine.SerializeField]
        private string privacyPolicyUrl;
        
        // Methods
        public SettingsUI()
        {
            this.mixerMinValue = -80f;
            this.checkUpdateInterval = 7.346868E-41f;
        }
        private void Update()
        {
            float val_1 = UnityEngine.Time.time;
            val_1 = val_1 - this.lastCheckTime;
            if(val_1 < this.checkUpdateInterval)
            {
                    return;
            }
            
            this.lastCheckTime = UnityEngine.Time.time;
            this.check();
        }
        private float getMixerValue(float volume)
        {
            volume = 1f - volume;
            volume = -(volume * this.mixerMinValue);
            return (float)volume;
        }
        private void check()
        {
            float val_6 = System.Math.Abs(this.lastSfxVolume - V0.16B);
            if(val_6 > 0.0001f)
            {
                    this.lastSfxVolume = val_6;
                TzarGames.Endless.AppSettings.SfxVolume = val_6;
                float val_6 = this.lastSfxVolume;
                val_6 = 1f - val_6;
                val_6 = -(val_6 * this.mixerMinValue);
                bool val_3 = this.sfxMixer.SetFloat(name:  "volume", value:  val_6);
            }
            
            val_6 = this.lastMusicVolume - val_6;
            float val_7 = System.Math.Abs(val_6);
            if(val_7 <= 0.0001f)
            {
                    return;
            }
            
            this.lastMusicVolume = val_7;
            TzarGames.Endless.AppSettings.MusicVolume = val_7;
            float val_8 = this.lastMusicVolume;
            val_8 = 1f - val_8;
            bool val_5 = this.musicMixer.SetFloat(name:  "volume", value:  -(val_8 * this.mixerMinValue));
        }
        protected override void Start()
        {
            this.Start();
            this.version.text = TzarGames.Endless.EndlessGameState.Instance.Version;
            if(TzarGames.Endless.SocialSystem.Instance.CanSignOut != true)
            {
                    this.socialAuthButton.SetActive(value:  false);
            }
            
            this.restorePurchasesButton.SetActive(value:  TzarGames.Common.UnityInAppManager.SupportsRestoringPurchases);
            float val_8 = TzarGames.Endless.AppSettings.SfxVolume;
            float val_9 = TzarGames.Endless.AppSettings.MusicVolume;
            this.lastMusicVolume = val_9;
            this.lastSfxVolume = val_9;
            float val_16 = this.lastMusicVolume;
            val_16 = 1f - val_16;
            bool val_11 = this.musicMixer.SetFloat(name:  "volume", value:  -(val_16 * this.mixerMinValue));
            float val_17 = this.lastSfxVolume;
            val_17 = 1f - val_17;
            bool val_13 = this.sfxMixer.SetFloat(name:  "volume", value:  -(val_17 * this.mixerMinValue));
            this.lobbyMultiplayerToggle.isOn = TzarGames.Endless.AppSettings.AllowMultiplayerInLobby;
        }
        public void OnLobbyMultiplayerToggleChanged(bool on)
        {
            bool val_1 = on;
            TzarGames.Endless.AppSettings.AllowMultiplayerInLobby = false;
        }
        public void RestoreFromCloud()
        {
            this.restoreSaveUI.StartRestoring();
            goto typeof(TzarGames.Endless.UI.MainMenu.SettingsUI).__il2cppRuntimeField_160;
        }
        public void RestorePurchases()
        {
            TzarGames.Common.UnityInAppManager.Instance.RestorePurchases();
        }
        public void FacebookLogin()
        {
            if(TzarGames.Endless.FacebookPlatform.IsLoggedIn != false)
            {
                    return;
            }
            
            TzarGames.Endless.FacebookPlatform.Login(callback:  0);
        }
        public void OpenPrivacyPolicy()
        {
            UnityEngine.Application.OpenURL(url:  0);
        }
    
    }

}

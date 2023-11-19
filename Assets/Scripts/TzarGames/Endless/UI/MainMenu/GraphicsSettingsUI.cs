using UnityEngine;

namespace TzarGames.Endless.UI.MainMenu
{
    public class GraphicsSettingsUI : UIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Toggle lowQuality;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Toggle shadows;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Toggle colorEnhance;
        
        // Methods
        public GraphicsSettingsUI()
        {
        
        }
        protected override void OnVisible()
        {
            this.OnVisible();
            this.lowQuality.isOn = AppSettings.GraphicsSettings.LowQuality;
        }
        public void OnLowQualityChanged(bool value)
        {
            bool val_1 = value;
            AppSettings.GraphicsSettings.LowQuality = false;
        }
    
    }

}

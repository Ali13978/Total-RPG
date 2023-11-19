using UnityEngine;

namespace TzarGames.Endless.UI.MainMenu
{
    public class PrivacySettingsUI : UIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset privacyPolicyPage;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Toggle enableDataCollection;
        
        // Methods
        public PrivacySettingsUI()
        {
        
        }
        protected override void OnVisible()
        {
            this.OnVisible();
            this.enableDataCollection.isOn = TzarGames.Common.Privacy.CanCollectData;
        }
        public void OnAllowDataCollectChanged(bool value)
        {
            value = value;
            TzarGames.Common.Privacy.CanCollectData = false;
        }
        public void OpenPrivacyPolicyPage()
        {
            string val_1 = TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
            UnityEngine.Application.OpenURL(url:  0);
        }
    
    }

}

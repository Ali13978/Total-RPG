using UnityEngine;

namespace TzarGames.Endless.UI.MainMenu
{
    public class RateAppUI : UIBase
    {
        // Fields
        public const string RateAppPressedKey = "RATE_APP_BUTTON_PRESSED";
        [UnityEngine.SerializeField]
        private string androidLink;
        
        // Methods
        public RateAppUI()
        {
            this.androidLink = "market://details?id=com.tzargamestudio.endless";
        }
        public void Rate()
        {
            UnityEngine.Application.OpenURL(url:  0);
            TzarGames.Endless.EndlessGameState val_1 = TzarGames.Endless.EndlessGameState.Instance;
            if(0 == val_1)
            {
                    return;
            }
            
            if((val_1.CommonSaveGameData.HasInt(id:  "RATE_APP_BUTTON_PRESSED")) == true)
            {
                    return;
            }
            
            val_1.CommonSaveGameData.SetInt(id:  "RATE_APP_BUTTON_PRESSED", val:  1);
            if(val_1.IsItSafeStateToSaveGame() == false)
            {
                    return;
            }
            
            val_1.SaveGame();
        }
    
    }

}

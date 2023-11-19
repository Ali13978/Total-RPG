using UnityEngine;

namespace TzarGames.Endless.UI.MainMenu
{
    public class MainUI : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase mainMenu;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.MainMenu.LoadingUI loading;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.MainMenu.CreateCharacterUI createCharacterMenu;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.MainMenu.SettingsUI settingsUI;
        
        // Methods
        public MainUI()
        {
        
        }
        private void Start()
        {
            System.Action val_6;
            TzarGames.Endless.UI.MainMenu.CreateCharacterUI val_7;
            bool val_2 = UnityEngine.Object.op_Equality(x:  0, y:  TzarGames.Endless.EndlessGameState.Instance);
            if(val_2 != false)
            {
                    return;
            }
            
            val_6 = val_2.needToCreateCharacter();
            if(val_6 != false)
            {
                    this.createCharacterMenu.SetCancelState(enable:  false);
                System.Action val_5 = null;
                val_6 = val_5;
                val_5 = new System.Action(object:  this, method:  System.Void TzarGames.Endless.UI.MainMenu.MainUI::CreateCharacterMenu_OnGoToNextScene());
                this.createCharacterMenu.add_OnGoToNextScene(value:  val_6);
                this.createCharacterMenu.<AutoSelectCharacter>k__BackingField = true;
                this.createCharacterMenu.nextMenu = 0;
                val_7 = this.createCharacterMenu;
                if(val_7 != null)
            {
                goto typeof(TzarGames.Common.UI.UIBase).__il2cppRuntimeField_160;
            }
            
            }
            else
            {
                    this.createCharacterMenu.SetCancelState(enable:  true);
                val_7 = this.mainMenu;
                if(val_7 != null)
            {
                goto typeof(TzarGames.Common.UI.UIBase).__il2cppRuntimeField_160;
            }
            
            }
        
        }
        private bool needToCreateCharacter()
        {
            var val_6;
            var val_7;
            val_6 = TzarGames.Endless.EndlessGameState.Instance;
            if(val_6.CharacterCount >= 1)
            {
                    val_6 = TzarGames.Endless.EndlessGameState.Instance;
                var val_5 = (val_6.SelectedCharacter == 0) ? 1 : 0;
                return (bool)val_7;
            }
            
            val_7 = 1;
            return (bool)val_7;
        }
        private void CreateCharacterMenu_OnGoToNextScene()
        {
            this.createCharacterMenu.remove_OnGoToNextScene(value:  new System.Action(object:  this, method:  System.Void TzarGames.Endless.UI.MainMenu.MainUI::CreateCharacterMenu_OnGoToNextScene()));
            TzarGames.Endless.EndlessGameState.Instance.LoadGameOrLobbyScene();
        }
        public void CloseSettings()
        {
            TzarGames.Endless.UI.MainMenu.CreateCharacterUI val_2;
            if(this.settingsUI.needToCreateCharacter() != false)
            {
                    val_2 = this.createCharacterMenu;
                if(val_2 != null)
            {
                goto typeof(TzarGames.Common.UI.UIBase).__il2cppRuntimeField_160;
            }
            
            }
            else
            {
                    val_2 = this.mainMenu;
                if(val_2 != null)
            {
                goto typeof(TzarGames.Common.UI.UIBase).__il2cppRuntimeField_160;
            }
            
            }
        
        }
    
    }

}

using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class GameplayMenuUI : GameUIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase pauseMenuForGame;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase pauseMenuForLobby;
        
        // Methods
        public GameplayMenuUI()
        {
        
        }
        public void ExitToMainMenu()
        {
            TzarGames.Endless.EndlessGameState.Instance.ExitToMainMenu();
            if(this.pauseMenuForLobby == null)
            {
                
            }
        
        }
        public override void NotifyShown()
        {
            TzarGames.Common.UI.UIBase val_3;
            this.NotifyShown();
            if(TzarGames.Endless.EndlessGameState.Instance.IsInLobby() != false)
            {
                    val_3 = this.pauseMenuForLobby;
                if(val_3 != null)
            {
                goto typeof(TzarGames.Common.UI.UIBase).__il2cppRuntimeField_160;
            }
            
            }
            else
            {
                    val_3 = this.pauseMenuForLobby;
            }
        
        }
    
    }

}

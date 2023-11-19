using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class StageCompleteUI : GameUIBase
    {
        // Methods
        public StageCompleteUI()
        {
        
        }
        public void ReturnToLobby()
        {
            TzarGames.Endless.EndlessGameState.Instance.CompleteCurrentStageAndExitToLobby();
        }
    
    }

}

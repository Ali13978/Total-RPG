using UnityEngine;

namespace TzarGames.Endless
{
    public class EndlessPromoGameManager : EndlessStoryGameManager
    {
        // Fields
        private UnityEngine.Transform lastCheckpoint;
        private object lastPlayerData;
        
        // Methods
        public EndlessPromoGameManager()
        {
            val_1 = new TzarGames.Endless.EndlessGameManager();
        }
        [TzarGames.Common.ConsoleCommand]
        public void FinishPromoLevel()
        {
            TzarGames.Endless.EndlessGameState.Instance.CompleteCurrentPromoStageAndLoadNextLevel();
        }
    
    }

}

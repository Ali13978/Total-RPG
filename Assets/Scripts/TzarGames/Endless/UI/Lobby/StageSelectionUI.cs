using UnityEngine;

namespace TzarGames.Endless.UI.Lobby
{
    public class StageSelectionUI : UIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.IntCounterUI counter;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI lowerStageText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI upperStageText;
        
        // Methods
        public StageSelectionUI()
        {
        
        }
        public void SetLowerStageMode()
        {
            var val_11;
            int val_12;
            TzarGames.Endless.ICharacterInfo val_2 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_11 = val_2;
            this.counter.MaxValue = val_2 - 1;
            if(this.counter != null)
            {
                    val_12 = this.counter.MaxValue;
            }
            else
            {
                    val_12 = 0.MaxValue;
            }
            
            this.counter.CurrentValue = val_12;
            this.counter.MinValue = TzarGames.Endless.EndlessGameState.Instance.MinimumStageToGoDown;
            this.lowerStageText.gameObject.SetActive(value:  true);
            this.upperStageText.gameObject.SetActive(value:  false);
        }
        public void SetUpperStageMode()
        {
            var val_11;
            var val_12;
            int val_13;
            TzarGames.Endless.ICharacterInfo val_2 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_11 = val_2;
            this.counter.MaxValue = val_2;
            TzarGames.Endless.ICharacterInfo val_5 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_12 = val_5;
            this.counter.MinValue = val_5;
            if(this.counter != null)
            {
                    val_13 = this.counter.MinValue;
            }
            else
            {
                    val_13 = 0.MinValue;
            }
            
            this.counter.CurrentValue = val_13;
            this.lowerStageText.gameObject.SetActive(value:  false);
            this.upperStageText.gameObject.SetActive(value:  true);
        }
        public void OnGotoStageAccepted()
        {
            var val_9;
            var val_10;
            int val_1 = this.counter.CurrentValue;
            if((TzarGames.Endless.EndlessGameState.Instance.CanGoToStage(stageNumber:  val_1)) != false)
            {
                    TzarGames.Endless.ICharacterInfo val_6 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
                var val_9 = 0;
                val_9 = val_9 + 1;
                val_9 = val_6;
            }
            else
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            if(val_6 > val_1)
            {
                    val_10 = 1;
            }
            else
            {
                    val_10 = 0;
            }
            
            TzarGames.Endless.EndlessGameState.Instance.GotoStage(stage:  val_1, toLobby:  false);
        }
    
    }

}

using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class StatisticsUI : GameUIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Slider progressSlider;
        [UnityEngine.SerializeField]
        private int maxStage;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.StatisticsUiElement Deaths;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.StatisticsUiElement Kills;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.StatisticsUiElement BossesKilled;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.StatisticsUiElement DestroyedThings;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.StatisticsUiElement ChestsOpened;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.StatisticsUiElement Waves;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.StatisticsUiElement MaxWaves;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.StatisticsUiElement QuestsCompleted;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.StatisticsUiElement Hits;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.StatisticsUiElement CriticalHits;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.StatisticsUiElement ShieldBlocks;
        
        // Methods
        public StatisticsUI()
        {
            this.maxStage = 100;
        }
        public override void NotifyShown()
        {
            var val_8;
            var val_9;
            this.NotifyShown();
            TzarGames.Endless.EndlessGameState val_1 = TzarGames.Endless.EndlessGameState.Instance;
            if(0 == val_1)
            {
                    return;
            }
            
            TzarGames.Endless.ICharacterInfo val_4 = val_1.SelectedCharacter;
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_8 = val_4;
            float val_9 = (float)(double)val_4;
            val_9 = val_9 / (float)this.maxStage;
            TzarGames.Endless.ICharacterInfo val_6 = val_1.SelectedCharacter;
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_9 = val_6;
            this.Deaths.Update(value:  val_4);
            this.Kills.Update(value:  val_4);
            this.BossesKilled.Update(value:  val_4);
            this.DestroyedThings.Update(value:  val_4);
            this.ChestsOpened.Update(value:  val_4);
            this.Waves.Update(value:  val_4);
            this.MaxWaves.Update(value:  val_4);
            this.QuestsCompleted.Update(value:  val_4);
            this.Hits.Update(value:  val_4);
            this.CriticalHits.Update(value:  val_4);
            this.ShieldBlocks.Update(value:  val_6);
        }
    
    }

}

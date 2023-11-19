using UnityEngine;

namespace TzarGames.Endless
{
    public class StageNumberUI : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI text;
        
        // Methods
        public StageNumberUI()
        {
        
        }
        private void Start()
        {
            var val_6;
            string val_7;
            if(0 == TzarGames.Endless.EndlessGameState.Instance)
            {
                goto label_3;
            }
            
            TzarGames.Endless.ICharacterInfo val_4 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_6 = val_4;
            goto label_9;
            label_3:
            val_7 = "0";
            goto label_11;
            label_9:
            val_7 = ;
            label_11:
            this.text.text = val_4;
        }
    
    }

}

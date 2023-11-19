using UnityEngine;

namespace TzarGames.Endless.Quests
{
    public class QuestActivator : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.Quests.EndlessQuest _quest;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject _gameObject;
        
        // Methods
        public QuestActivator()
        {
        
        }
        private void Start()
        {
            UnityEngine.Object val_8;
            TzarGames.Endless.EndlessGameState val_1 = TzarGames.Endless.EndlessGameState.Instance;
            val_8 = 1152921504721543168;
            if(0 == val_1)
            {
                    return;
            }
            
            val_8 = val_1.CurrentQuest;
            if(0 == val_8)
            {
                    return;
            }
            
            val_8 = this._quest;
            if(val_1.CurrentQuest != val_8)
            {
                    return;
            }
            
            this._gameObject.SetActive(value:  true);
        }
    
    }

}

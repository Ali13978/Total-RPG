using UnityEngine;

namespace TzarGames.Endless.Quests
{
    [Serializable]
    internal class QuestStageInfo : QuestsBase, IStageQuestsInfo
    {
        // Fields
        [UnityEngine.SerializeField]
        private bool _initialized;
        [UnityEngine.SerializeField]
        private int questListId;
        
        // Properties
        public int QuestListId { get; set; }
        public TzarGames.Endless.Quests.IQuestInfo[] QuestList { get; }
        public int QuestCount { get; }
        
        // Methods
        public QuestStageInfo()
        {
            if(this._initialized == true)
            {
                    return;
            }
            
            this._initialized = true;
        }
        public int get_QuestListId()
        {
            return (int)this.questListId;
        }
        public void set_QuestListId(int value)
        {
            this.questListId = value;
        }
        public TzarGames.Endless.Quests.IQuestInfo[] get_QuestList()
        {
            if(this != null)
            {
                    return this.ToArray();
            }
            
            return this.ToArray();
        }
        public int get_QuestCount()
        {
            if(this != null)
            {
                    return this.Count;
            }
            
            return this.Count;
        }
    
    }

}

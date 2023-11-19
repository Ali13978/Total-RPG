using UnityEngine;

namespace TzarGames.Endless.Quests
{
    public interface IStageQuestsInfo
    {
        // Properties
        public abstract int QuestListId { get; set; }
        public abstract TzarGames.Endless.Quests.IQuestInfo[] QuestList { get; }
        public abstract int QuestCount { get; }
        
        // Methods
        public abstract int get_QuestListId(); // 0
        public abstract void set_QuestListId(int value); // 0
        public abstract TzarGames.Endless.Quests.IQuestInfo[] get_QuestList(); // 0
        public abstract int get_QuestCount(); // 0
    
    }

}

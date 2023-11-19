using UnityEngine;

namespace TzarGames.Endless.Quests
{
    [Serializable]
    internal class RepeatingQuestInfo
    {
        // Fields
        public TzarGames.Endless.Quests.EndlessQuest Quest;
        public uint MinimumStage;
        public uint Interval;
        
        // Methods
        public RepeatingQuestInfo()
        {
            this.Interval = 5;
        }
    
    }

}

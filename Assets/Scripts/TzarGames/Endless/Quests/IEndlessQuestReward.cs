using UnityEngine;

namespace TzarGames.Endless.Quests
{
    public interface IEndlessQuestReward
    {
        // Properties
        public abstract TzarGames.Endless.Quests.EndlessQuest Quest { get; }
        public abstract int Gold { get; }
        public abstract int Ruby { get; }
        public abstract int Xp { get; }
        public abstract TzarGames.GameFramework.Item[] Items { get; }
        
        // Methods
        public abstract TzarGames.Endless.Quests.EndlessQuest get_Quest(); // 0
        public abstract int get_Gold(); // 0
        public abstract int get_Ruby(); // 0
        public abstract int get_Xp(); // 0
        public abstract TzarGames.GameFramework.Item[] get_Items(); // 0
    
    }

}

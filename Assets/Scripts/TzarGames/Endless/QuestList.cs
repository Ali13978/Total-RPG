using UnityEngine;

namespace TzarGames.Endless
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class QuestList : CommonAsset
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.Quests.EndlessQuest[] quests;
        [UnityEngine.SerializeField]
        private int minimumStage;
        
        // Properties
        public TzarGames.Endless.Quests.EndlessQuest[] Quests { get; }
        public int MinimumStage { get; }
        
        // Methods
        public QuestList()
        {
        
        }
        public TzarGames.Endless.Quests.EndlessQuest[] get_Quests()
        {
            return (TzarGames.Endless.Quests.EndlessQuest[])this.quests;
        }
        public int get_MinimumStage()
        {
            return (int)this.minimumStage;
        }
    
    }

}

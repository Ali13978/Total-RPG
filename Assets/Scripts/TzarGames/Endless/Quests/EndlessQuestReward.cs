using UnityEngine;

namespace TzarGames.Endless.Quests
{
    internal class EndlessQuestReward : IEndlessQuestReward
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.Endless.Quests.EndlessQuest <Quest>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private int <Gold>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private int <Ruby>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private int <Xp>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.GameFramework.Item[] <Items>k__BackingField;
        
        // Properties
        public TzarGames.Endless.Quests.EndlessQuest Quest { get; set; }
        public int Gold { get; set; }
        public int Ruby { get; set; }
        public int Xp { get; set; }
        public TzarGames.GameFramework.Item[] Items { get; set; }
        
        // Methods
        public EndlessQuestReward()
        {
        
        }
        public TzarGames.Endless.Quests.EndlessQuest get_Quest()
        {
            return (TzarGames.Endless.Quests.EndlessQuest)this.<Quest>k__BackingField;
        }
        public void set_Quest(TzarGames.Endless.Quests.EndlessQuest value)
        {
            this.<Quest>k__BackingField = value;
        }
        public int get_Gold()
        {
            return (int)this.<Gold>k__BackingField;
        }
        public void set_Gold(int value)
        {
            this.<Gold>k__BackingField = value;
        }
        public int get_Ruby()
        {
            return (int)this.<Ruby>k__BackingField;
        }
        public void set_Ruby(int value)
        {
            this.<Ruby>k__BackingField = value;
        }
        public int get_Xp()
        {
            return (int)this.<Xp>k__BackingField;
        }
        public void set_Xp(int value)
        {
            this.<Xp>k__BackingField = value;
        }
        public TzarGames.GameFramework.Item[] get_Items()
        {
            return (TzarGames.GameFramework.Item[])this.<Items>k__BackingField;
        }
        public void set_Items(TzarGames.GameFramework.Item[] value)
        {
            this.<Items>k__BackingField = value;
        }
    
    }

}

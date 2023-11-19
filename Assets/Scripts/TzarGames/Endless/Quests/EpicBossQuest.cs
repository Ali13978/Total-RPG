using UnityEngine;

namespace TzarGames.Endless.Quests
{
    [TzarGames.GameFramework.GroupNameAttribute]
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class EpicBossQuest : KillBossQuest
    {
        // Fields
        [UnityEngine.SerializeField]
        private int stage;
        
        // Properties
        public int Stage { get; }
        
        // Methods
        public EpicBossQuest()
        {
            mem[1152921510790601920] = 1000;
            mem[1152921510790601924] = 1056964608;
            mem[1152921510790601928] = 1000;
            val_1 = new TzarGames.Common.CommonAsset();
        }
        public int get_Stage()
        {
            return (int)this.stage;
        }
    
    }

}

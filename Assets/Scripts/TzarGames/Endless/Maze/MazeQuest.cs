using UnityEngine;

namespace TzarGames.Endless.Maze
{
    public class MazeQuest : EndlessQuest
    {
        // Fields
        [UnityEngine.SerializeField]
        private int horizontalCells;
        [UnityEngine.SerializeField]
        private int verticalCells;
        [UnityEngine.SerializeField]
        private bool limitEnemyCount;
        [UnityEngine.SerializeField]
        private int enemyLimit;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <MazePassed>k__BackingField;
        private const string completed_key = "MAZE_QUEST_COMPLETED";
        
        // Properties
        public int HorizontalCells { get; }
        public int VerticalCells { get; }
        public bool MazePassed { get; set; }
        public bool LimitEnemyCount { get; }
        public int EnemyLimit { get; }
        
        // Methods
        public MazeQuest()
        {
            this.horizontalCells = 15;
            this.verticalCells = 15;
            this.enemyLimit = 10;
            mem[1152921510739415344] = 1000;
            mem[1152921510739415348] = 1056964608;
            mem[1152921510739415352] = 1000;
            val_1 = new TzarGames.Common.CommonAsset();
        }
        public int get_HorizontalCells()
        {
            return (int)this.horizontalCells;
        }
        public int get_VerticalCells()
        {
            return (int)this.verticalCells;
        }
        public bool get_MazePassed()
        {
            return (bool)this.<MazePassed>k__BackingField;
        }
        public void set_MazePassed(bool value)
        {
            this.<MazePassed>k__BackingField = value;
        }
        public bool get_LimitEnemyCount()
        {
            return (bool)this.limitEnemyCount;
        }
        public int get_EnemyLimit()
        {
            return (int)this.enemyLimit;
        }
        public override bool CanBeCompleted()
        {
            if(X8 == 0)
            {
                    return false;
            }
            
            return (bool)((this.<MazePassed>k__BackingField) == true) ? 1 : 0;
        }
        public override TzarGames.Common.SerializableData SerializeInstance()
        {
            TzarGames.Common.SerializableData val_1 = this.SerializeInstance();
            val_1.SetString(id:  "MAZE_QUEST_COMPLETED", stringValue:  this.<MazePassed>k__BackingField);
            return val_1;
        }
        public override void Deserialize(TzarGames.Common.SerializableData data)
        {
            this.Deserialize(data:  data);
            string val_1 = data.GetString(id:  "MAZE_QUEST_COMPLETED");
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            this.<MazePassed>k__BackingField = System.Boolean.Parse(value:  0);
        }
    
    }

}

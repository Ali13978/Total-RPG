using UnityEngine;

namespace TzarGames.Endless
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class StageEventInfo : CommonAsset
    {
        // Fields
        [UnityEngine.SerializeField]
        private string key;
        [UnityEngine.SerializeField]
        private float chancePercent;
        [UnityEngine.SerializeField]
        private int minimumStage;
        [UnityEngine.SerializeField]
        private int maximumStage;
        [UnityEngine.SerializeField]
        private int stageInterval_Min;
        [UnityEngine.SerializeField]
        private int stageInterval_Max;
        
        // Properties
        public string Key { get; }
        public float ChancePercent { get; }
        public int StageInterval_Min { get; }
        public int StageInterval_Max { get; }
        public int MinimumStage { get; }
        public int MaximumStage { get; }
        
        // Methods
        public StageEventInfo()
        {
            this.stageInterval_Max = 3;
            this.chancePercent = 25f;
            this.maximumStage = 2147483647;
            this.key = "CHANGE_ME";
        }
        public string get_Key()
        {
            return (string)this.key;
        }
        public float get_ChancePercent()
        {
            return (float)this.chancePercent;
        }
        public int get_StageInterval_Min()
        {
            return (int)this.stageInterval_Min;
        }
        public int get_StageInterval_Max()
        {
            return (int)this.stageInterval_Max;
        }
        public int get_MinimumStage()
        {
            return (int)this.minimumStage;
        }
        public int get_MaximumStage()
        {
            return (int)this.maximumStage;
        }
    
    }

}

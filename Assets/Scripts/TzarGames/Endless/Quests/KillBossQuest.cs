using UnityEngine;

namespace TzarGames.Endless.Quests
{
    [TzarGames.GameFramework.GroupNameAttribute]
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class KillBossQuest : EndlessQuest
    {
        // Fields
        public TzarGames.Common.LocalizedStringAsset IntroMessage;
        public TzarGames.Common.LocalizedStringAsset CompletedMessage;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <BossKilled>k__BackingField;
        private const string killboss_key = "KILLBOSS_QUEST_COMPLETED";
        
        // Properties
        public bool BossKilled { get; set; }
        
        // Methods
        public KillBossQuest()
        {
            mem[1152921510790825920] = 1000;
            mem[1152921510790825924] = 1056964608;
            mem[1152921510790825928] = 1000;
            val_1 = new TzarGames.Common.CommonAsset();
        }
        public bool get_BossKilled()
        {
            return (bool)this.<BossKilled>k__BackingField;
        }
        public void set_BossKilled(bool value)
        {
            this.<BossKilled>k__BackingField = value;
        }
        public override bool CanBeCompleted()
        {
            if(X8 == 0)
            {
                    return false;
            }
            
            return (bool)((this.<BossKilled>k__BackingField) == true) ? 1 : 0;
        }
        public override TzarGames.Common.SerializableData SerializeInstance()
        {
            TzarGames.Common.SerializableData val_1 = this.SerializeInstance();
            val_1.SetString(id:  "KILLBOSS_QUEST_COMPLETED", stringValue:  this.<BossKilled>k__BackingField);
            return val_1;
        }
        public override void Deserialize(TzarGames.Common.SerializableData data)
        {
            this.Deserialize(data:  data);
            string val_1 = data.GetString(id:  "KILLBOSS_QUEST_COMPLETED");
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            this.<BossKilled>k__BackingField = System.Boolean.Parse(value:  0);
        }
        public bool GetBossStateFromSerializedData(TzarGames.Common.SerializableData data, out bool killed)
        {
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                    return System.Boolean.TryParse(value:  0, result: out  data.GetString(id:  "KILLBOSS_QUEST_COMPLETED"));
            }
            
            killed = false;
            return false;
        }
    
    }

}

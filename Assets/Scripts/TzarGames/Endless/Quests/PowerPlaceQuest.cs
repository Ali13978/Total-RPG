using UnityEngine;

namespace TzarGames.Endless.Quests
{
    [TzarGames.GameFramework.GroupNameAttribute]
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class PowerPlaceQuest : EndlessQuest
    {
        // Fields
        public TzarGames.Common.LocalizedStringAsset IntroMessage;
        public TzarGames.Common.LocalizedStringAsset CompletedMessage;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <IsPowerPlaceCompleted>k__BackingField;
        private const string powerplace_key = "POWERPLACEQUEST_COMPLETED";
        
        // Properties
        public bool IsPowerPlaceCompleted { get; set; }
        
        // Methods
        public PowerPlaceQuest()
        {
            mem[1152921510793211024] = 1000;
            mem[1152921510793211028] = 1056964608;
            mem[1152921510793211032] = 1000;
            val_1 = new TzarGames.Common.CommonAsset();
        }
        public bool get_IsPowerPlaceCompleted()
        {
            return (bool)this.<IsPowerPlaceCompleted>k__BackingField;
        }
        public void set_IsPowerPlaceCompleted(bool value)
        {
            this.<IsPowerPlaceCompleted>k__BackingField = value;
        }
        public override bool CanBeCompleted()
        {
            if(X8 == 0)
            {
                    return false;
            }
            
            return (bool)((this.<IsPowerPlaceCompleted>k__BackingField) == true) ? 1 : 0;
        }
        public override TzarGames.Common.SerializableData SerializeInstance()
        {
            TzarGames.Common.SerializableData val_1 = this.SerializeInstance();
            val_1.SetString(id:  "POWERPLACEQUEST_COMPLETED", stringValue:  this.<IsPowerPlaceCompleted>k__BackingField);
            return val_1;
        }
        public override void Deserialize(TzarGames.Common.SerializableData data)
        {
            this.Deserialize(data:  data);
            string val_1 = data.GetString(id:  "POWERPLACEQUEST_COMPLETED");
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            this.<IsPowerPlaceCompleted>k__BackingField = System.Boolean.Parse(value:  0);
        }
    
    }

}

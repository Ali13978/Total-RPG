using UnityEngine;

namespace TzarGames.Endless.Quests
{
    [TzarGames.GameFramework.GroupNameAttribute]
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class DestroyCocoonQuest : EndlessQuest
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset introMessage;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset completedMessage;
        [UnityEngine.SerializeField]
        private UnityEngine.Sprite indicatorSprite;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <AllCocoonsDestroyed>k__BackingField;
        private const string cocoon_key = "COCOONQUEST_COMPLETED";
        
        // Properties
        public string IntroMessage { get; }
        public string CompletedMessage { get; }
        public UnityEngine.Sprite IndicatorSprite { get; }
        public bool AllCocoonsDestroyed { get; set; }
        
        // Methods
        public DestroyCocoonQuest()
        {
            mem[1152921510783997664] = 1000;
            mem[1152921510783997668] = 1056964608;
            mem[1152921510783997672] = 1000;
            val_1 = new TzarGames.Common.CommonAsset();
        }
        public string get_IntroMessage()
        {
            return TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
        }
        public string get_CompletedMessage()
        {
            return TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
        }
        public UnityEngine.Sprite get_IndicatorSprite()
        {
            return (UnityEngine.Sprite)this.indicatorSprite;
        }
        public bool get_AllCocoonsDestroyed()
        {
            return (bool)this.<AllCocoonsDestroyed>k__BackingField;
        }
        public void set_AllCocoonsDestroyed(bool value)
        {
            this.<AllCocoonsDestroyed>k__BackingField = value;
        }
        public override bool CanBeCompleted()
        {
            if(X8 == 0)
            {
                    return false;
            }
            
            return (bool)((this.<AllCocoonsDestroyed>k__BackingField) == true) ? 1 : 0;
        }
        public override TzarGames.Common.SerializableData SerializeInstance()
        {
            TzarGames.Common.SerializableData val_1 = this.SerializeInstance();
            val_1.SetString(id:  "COCOONQUEST_COMPLETED", stringValue:  this.<AllCocoonsDestroyed>k__BackingField);
            return val_1;
        }
        public override void Deserialize(TzarGames.Common.SerializableData data)
        {
            this.Deserialize(data:  data);
            string val_1 = data.GetString(id:  "COCOONQUEST_COMPLETED");
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            this.<AllCocoonsDestroyed>k__BackingField = System.Boolean.Parse(value:  0);
        }
    
    }

}

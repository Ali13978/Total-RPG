using UnityEngine;

namespace TzarGames.Endless.Quests
{
    [TzarGames.GameFramework.GroupNameAttribute]
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class DestroyCrystalQuest : EndlessQuest
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset introMessage;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset completedMessage;
        [UnityEngine.SerializeField]
        private UnityEngine.Sprite indicatorSprite;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <AllPortalsDestroyed>k__BackingField;
        private const string portal_key = "CRYSTALQUEST_COMPLETED";
        
        // Properties
        public string IntroMessage { get; }
        public string CompletedMessage { get; }
        public UnityEngine.Sprite IndicatorSprite { get; }
        public bool AllPortalsDestroyed { get; set; }
        
        // Methods
        public DestroyCrystalQuest()
        {
            mem[1152921510786706384] = 1000;
            mem[1152921510786706388] = 1056964608;
            mem[1152921510786706392] = 1000;
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
        public bool get_AllPortalsDestroyed()
        {
            return (bool)this.<AllPortalsDestroyed>k__BackingField;
        }
        public void set_AllPortalsDestroyed(bool value)
        {
            this.<AllPortalsDestroyed>k__BackingField = value;
        }
        public override bool CanBeCompleted()
        {
            if(X8 == 0)
            {
                    return false;
            }
            
            return (bool)((this.<AllPortalsDestroyed>k__BackingField) == true) ? 1 : 0;
        }
        public override TzarGames.Common.SerializableData SerializeInstance()
        {
            TzarGames.Common.SerializableData val_1 = this.SerializeInstance();
            val_1.SetString(id:  "CRYSTALQUEST_COMPLETED", stringValue:  this.<AllPortalsDestroyed>k__BackingField);
            return val_1;
        }
        public override void Deserialize(TzarGames.Common.SerializableData data)
        {
            this.Deserialize(data:  data);
            string val_1 = data.GetString(id:  "CRYSTALQUEST_COMPLETED");
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            this.<AllPortalsDestroyed>k__BackingField = System.Boolean.Parse(value:  0);
        }
    
    }

}

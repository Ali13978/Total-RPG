using UnityEngine;

namespace TzarGames.Endless.Quests
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public abstract class Quest : CommonAsset
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset localizedName;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset description;
        private const string status_serialize_property = "STATUS";
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.Endless.Quests.QuestStatus <Status>k__BackingField;
        
        // Properties
        public TzarGames.Endless.Quests.QuestStatus Status { get; set; }
        
        // Methods
        protected Quest()
        {
        
        }
        public TzarGames.Endless.Quests.QuestStatus get_Status()
        {
            return (TzarGames.Endless.Quests.QuestStatus)this.<Status>k__BackingField;
        }
        public void set_Status(TzarGames.Endless.Quests.QuestStatus value)
        {
            this.<Status>k__BackingField = value;
        }
        public abstract bool CanBeCompleted(); // 0
        public virtual TzarGames.Common.SerializableData SerializeInstance()
        {
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            SetString(id:  "STATUS", stringValue:  this.<Status>k__BackingField.ToString());
            return (TzarGames.Common.SerializableData)new TzarGames.Common.SerializableData();
        }
        public bool GetStatusFromSerializedData(TzarGames.Common.SerializableData data, out TzarGames.Endless.Quests.QuestStatus status)
        {
            var val_8;
            var val_9;
            var val_10;
            string val_1 = data.GetString(id:  "STATUS");
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    val_9 = 0;
                val_10 = 0;
            }
            else
            {
                    val_8 = System.Enum.Parse(enumType:  0, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
                UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
                val_10 = 1;
            }
            
            status = null;
            return (bool)val_10;
        }
        public virtual void Deserialize(TzarGames.Common.SerializableData data)
        {
            TzarGames.Endless.Quests.QuestStatus val_1 = 0;
            if((this.GetStatusFromSerializedData(data:  data, status: out  val_1)) != false)
            {
                    this.<Status>k__BackingField = val_1;
                return;
            }
            
            string val_4 = this.Name;
            this = 0 + "Failed to deserialize ";
            UnityEngine.Debug.LogError(message:  0);
        }
        public string GetLocalizedName()
        {
            if(0 != this.localizedName)
            {
                    return TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
            }
            
            return "NOT LOCALIZED";
        }
        public virtual string GetDescription()
        {
            var val_2;
            if(0 != this.description)
            {
                    return TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
            }
            
            val_2 = null;
            val_2 = null;
            return (string)System.String.Empty;
        }
    
    }

}

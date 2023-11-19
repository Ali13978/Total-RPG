using UnityEngine;

namespace TzarGames.Endless.Quests
{
    [TzarGames.GameFramework.GroupNameAttribute]
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class BringStageItemQuest : EndlessQuest
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.Items.BringQuestItem[] items;
        [UnityEngine.SerializeField]
        private int randomPointCount;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset introMessage;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset completedMessage;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.Endless.Items.BringQuestItem <Item>k__BackingField;
        private uint stage;
        private const string item_id_key = "BRING_ITEM_KEY";
        private const string item_stage_key = "BRING_STAGE_KEY";
        
        // Properties
        public string IntroMessage { get; }
        public string CompletedMessage { get; }
        public int RandomPointCount { get; }
        public TzarGames.Endless.Items.BringQuestItem Item { get; set; }
        
        // Methods
        public BringStageItemQuest()
        {
            this.randomPointCount = 7;
            mem[1152921510777845280] = 1000;
            mem[1152921510777845284] = 1056964608;
            mem[1152921510777845288] = 1000;
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
        public int get_RandomPointCount()
        {
            return (int)this.randomPointCount;
        }
        public TzarGames.Endless.Items.BringQuestItem get_Item()
        {
            return (TzarGames.Endless.Items.BringQuestItem)this.<Item>k__BackingField;
        }
        private void set_Item(TzarGames.Endless.Items.BringQuestItem value)
        {
            this.<Item>k__BackingField = value;
        }
        public override bool CanBeCompleted()
        {
            var val_10;
            var val_11;
            val_10 = 0;
            if(X1 == 0)
            {
                    return (bool)val_10;
            }
            
            TzarGames.GameFramework.InventoryBag val_4 = TzarGames.Endless.EndlessGameManager.GetPlayerCharacterByCharacterInfo(characterInfo:  0).TemplateInstance.Inventory.HiddenBag;
            val_11 = 0;
            goto label_6;
            label_21:
            val_11 = 1;
            label_6:
            if(val_11 >= val_5.Length)
            {
                goto label_8;
            }
            
            TzarGames.GameFramework.ItemInstance val_10 = val_4.GetAllNonconsumableItems()[1];
            if((val_10.GetOriginalTemplate() != (this.<Item>k__BackingField)) || (((TzarGames.Endless.Items.StageItem.GetItemInstanceStage(item:  0, stage: out  val_10)) == false) || (this.stage != 0)))
            {
                goto label_21;
            }
            
            if(val_4 != null)
            {
                    val_4.RemoveItem(itemInstance:  val_10);
            }
            else
            {
                    0.RemoveItem(itemInstance:  val_10);
            }
            
            if((val_4.ContainsNonConsumableItem(itemInstance:  val_10)) == false)
            {
                    return (bool)val_10;
            }
            
            UnityEngine.Debug.LogError(message:  0);
            goto label_21;
            label_8:
            val_10 = 0;
            return (bool)val_10;
        }
        public override void Initialize()
        {
            this.<Item>k__BackingField = this.items[(long)UnityEngine.Random.Range(min:  0, max:  0)];
        }
        public override TzarGames.Common.SerializableData SerializeInstance()
        {
            var val_5;
            TzarGames.Common.SerializableData val_1 = this.SerializeInstance();
            val_1.SetString(id:  "BRING_ITEM_KEY", stringValue:  this.<Item>k__BackingField);
            TzarGames.Endless.ICharacterInfo val_3 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_5 = val_3;
            val_1.SetString(id:  "BRING_STAGE_KEY", stringValue:  val_3);
            return val_1;
        }
        public override void Deserialize(TzarGames.Common.SerializableData data)
        {
            var val_15;
            var val_17;
            var val_18;
            TzarGames.Endless.Items.BringQuestItem val_19;
            this.Deserialize(data:  data);
            val_15 = data.GetString(id:  "BRING_ITEM_KEY");
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                goto label_4;
            }
            
            string val_3 = this.Name;
            goto label_5;
            label_4:
            val_17 = val_15;
            val_15 = System.Int32.Parse(s:  0);
            val_18 = 0;
            label_10:
            if(val_18 >= this.items.Length)
            {
                goto label_7;
            }
            
            if(val_18 >= this.items.Length)
            {
                    val_17 = 0;
            }
            
            val_19 = this.items[0];
            val_18 = val_18 + 1;
            if(val_19 != val_15)
            {
                goto label_10;
            }
            
            this.<Item>k__BackingField = val_19;
            goto label_11;
            label_7:
            val_19 = this.<Item>k__BackingField;
            label_11:
            if(0 == val_19)
            {
                    string val_6 = this.Name;
                val_15 = 0 + "Failed to deserialize ";
                UnityEngine.Debug.LogError(message:  0);
            }
            
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    if((System.UInt32.TryParse(s:  0, result: out  data.GetString(id:  "BRING_STAGE_KEY"))) != false)
            {
                    return;
            }
            
            }
            
            string val_13 = this.name;
            label_5:
            string val_14 = 0 + "Failed to deserialize ";
            UnityEngine.Debug.LogError(message:  0);
        }
        public override string GetDescription()
        {
            if((this.<Item>k__BackingField) != null)
            {
                    return this.<Item>k__BackingField.Story;
            }
            
            return this.<Item>k__BackingField.Story;
        }
    
    }

}

using UnityEngine;

namespace TzarGames.Endless.Items
{
    public class StageItem : Item
    {
        // Fields
        private const string key = "STAGE_ITEM_KEY";
        
        // Methods
        public StageItem()
        {
        
        }
        public static bool GetItemInstanceStage(TzarGames.GameFramework.ItemInstance item, out uint stage)
        {
            var val_6;
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    if((System.UInt32.TryParse(s:  0, result: out  mem[1152921510711329856].GetString(id:  "STAGE_ITEM_KEY"))) != false)
            {
                    val_6 = 1;
                return (bool)val_6;
            }
            
            }
            
            val_6 = 0;
            mem2[0] = 0;
            return (bool)val_6;
        }
        private static void SetItemInstanceStage(TzarGames.GameFramework.ItemInstance item, uint stage)
        {
            stage + 80.SetString(id:  "STAGE_ITEM_KEY", stringValue:  ???);
        }
        protected override TzarGames.GameFramework.ItemInstance CreateCustomItemInstance()
        {
            var val_7;
            TzarGames.GameFramework.ItemInstance val_1 = this.CreateCustomItemInstance();
            if(0 == TzarGames.Endless.EndlessGameState.Instance)
            {
                    return val_1;
            }
            
            TzarGames.Endless.ICharacterInfo val_5 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_7 = val_5;
            TzarGames.Endless.Items.StageItem.SetItemInstanceStage(item:  val_5, stage:  val_1);
            return val_1;
        }
    
    }

}

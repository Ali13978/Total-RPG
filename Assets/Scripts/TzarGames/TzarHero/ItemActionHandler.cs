using UnityEngine;

namespace TzarGames.TzarHero
{
    public class ItemActionHandler : ActionHandler
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Item item;
        [UnityEngine.SerializeField]
        private bool removeItemAfterAction;
        
        // Methods
        public ItemActionHandler()
        {
        
        }
        public override TzarGames.GameFramework.IObjectActionResult CanBePerformed(TzarGames.GameFramework.IActionPerformer performer, TzarGames.GameFramework.IActionTarget target)
        {
            var val_6;
            var val_7;
            if(null != 0)
            {
                    typeof(TzarGames.GameFramework.ObjectActionResult).__il2cppRuntimeField_10 = 0;
            }
            else
            {
                    mem[16] = 0;
            }
            
            typeof(TzarGames.GameFramework.ObjectActionResult).__il2cppRuntimeField_18 = "Error: can be performed only by a character";
            return (TzarGames.GameFramework.IObjectActionResult)new System.Object();
            label_13:
            if( >= val_4.Length)
            {
                goto label_9;
            }
            
            if( >= val_4.Length)
            {
                    val_6 = 0;
            }
            
             =  + 1;
            if(([0].GetItemCountByID(id:  this.item)) <= 0)
            {
                goto label_13;
            }
            
            val_7 = 1;
            goto label_14;
            label_9:
            val_7 = 0;
            label_14:
            typeof(TzarGames.GameFramework.ObjectActionResult).__il2cppRuntimeField_10 = val_7;
            return (TzarGames.GameFramework.IObjectActionResult)new System.Object();
        }
        public override TzarGames.GameFramework.IObjectActionResult Perform(TzarGames.GameFramework.IActionPerformer performer, TzarGames.GameFramework.IActionTarget target)
        {
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            TzarGames.GameFramework.InventoryBag val_17;
            var val_18;
            TzarGames.GameFramework.Item val_19;
            var val_20;
            var val_21;
            val_13 = performer;
            val_14 = this;
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_15 = val_14;
            if((val_14 & 1) == 0)
            {
                    return (TzarGames.GameFramework.IObjectActionResult)val_14;
            }
            
            if(this.removeItemAfterAction == false)
            {
                    return (TzarGames.GameFramework.IObjectActionResult)val_14;
            }
            
            object val_2 = null;
            val_14 = val_2;
            val_2 = new System.Object();
            val_16 = 0;
            val_17 = val_16.TemplateInstance.Inventory;
            val_18 = 0;
            var val_14 = 0;
            label_18:
            if(val_14 >= val_7.Length)
            {
                goto label_14;
            }
            
            if(val_14 >= val_7.Length)
            {
                    val_18 = 0;
            }
            
            val_17 = val_17.GetAllBags()[0];
            val_14 = val_14 + 1;
            if((val_17.GetItemCountByID(id:  this.item)) < 1)
            {
                goto label_18;
            }
            
            val_19 = this.item;
            if(this.item == null)
            {
                    val_19 = this.item;
            }
            
            if(this.item.ConsumptionType == 0)
            {
                goto label_20;
            }
            
            System.Collections.Generic.List<TzarGames.GameFramework.ItemInstance> val_9 = val_17.GetAllItemInstancesById(id:  val_19);
            if(val_9 != null)
            {
                    if(val_9.Count != 0)
            {
                goto label_37;
            }
            
            }
            
            if(null == 0)
            {
                goto label_25;
            }
            
            typeof(TzarGames.GameFramework.ObjectActionResult).__il2cppRuntimeField_10 = 0;
            val_20 = 1152921504904716312;
            typeof(TzarGames.GameFramework.ObjectActionResult).__il2cppRuntimeField_18 = "No item Error";
            goto label_26;
            label_14:
            if(null != 0)
            {
                    typeof(TzarGames.GameFramework.ObjectActionResult).__il2cppRuntimeField_10 = 0;
            }
            else
            {
                    mem[16] = 0;
            }
            
            typeof(TzarGames.GameFramework.ObjectActionResult).__il2cppRuntimeField_18 = "Unknown error";
            return (TzarGames.GameFramework.IObjectActionResult)val_14;
            label_20:
            if((val_17.RemoveConsumableItem(item:  val_19, count:  1)) == true)
            {
                goto label_39;
            }
            
            typeof(TzarGames.GameFramework.ObjectActionResult).__il2cppRuntimeField_10 = 0;
            if(null == 0)
            {
                goto label_33;
            }
            
            val_21 = val_14;
            typeof(TzarGames.GameFramework.ObjectActionResult).__il2cppRuntimeField_18 = "No item Error";
            goto label_34;
            label_25:
            mem[16] = 0;
            val_20 = 24;
            mem[24] = "No item Error";
            label_26:
            UnityEngine.Debug.LogError(message:  0);
            label_37:
            val_17.RemoveItem(itemInstance:  val_9.Item[0]);
            label_39:
            typeof(TzarGames.GameFramework.ObjectActionResult).__il2cppRuntimeField_10 = 1;
            return (TzarGames.GameFramework.IObjectActionResult)val_14;
            label_33:
            val_21 = 24;
            mem[24] = "No item Error";
            label_34:
            UnityEngine.Debug.LogError(message:  0);
            return (TzarGames.GameFramework.IObjectActionResult)val_14;
        }
    
    }

}

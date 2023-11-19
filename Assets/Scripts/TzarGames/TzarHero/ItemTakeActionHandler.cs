using UnityEngine;

namespace TzarGames.TzarHero
{
    public class ItemTakeActionHandler : ActionHandler
    {
        // Methods
        public ItemTakeActionHandler()
        {
        
        }
        public override TzarGames.GameFramework.IObjectActionResult CanBePerformed(TzarGames.GameFramework.IActionPerformer performer, TzarGames.GameFramework.IActionTarget target)
        {
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
        }
        public override TzarGames.GameFramework.IObjectActionResult Perform(TzarGames.GameFramework.IActionPerformer performer, TzarGames.GameFramework.IActionTarget target)
        {
            var val_6;
            var val_7;
            var val_8;
            TzarGames.GameFramework.IItemReceiver val_9;
            val_6 = target;
            val_7 = this;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_8 = val_7;
            if((val_7 & 1) == 0)
            {
                    return (TzarGames.GameFramework.IObjectActionResult)val_7;
            }
            
            object val_2 = null;
            val_7 = val_2;
            val_2 = new System.Object();
            val_9 = 0;
            if(performer != null)
            {
                    val_9 = performer;
                val_9 = 0;
            }
            
            val_6 = 0;
            val_6.GetComponent<TzarGames.TzarHero.TH_Dropped>().TakeBy(itemReceiver:  val_9);
            typeof(TzarGames.GameFramework.ObjectActionResult).__il2cppRuntimeField_10 = 1;
            return (TzarGames.GameFramework.IObjectActionResult)val_7;
        }
    
    }

}

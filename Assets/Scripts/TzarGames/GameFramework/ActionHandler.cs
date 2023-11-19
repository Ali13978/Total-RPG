using UnityEngine;

namespace TzarGames.GameFramework
{
    public abstract class ActionHandler : CommonAsset
    {
        // Methods
        protected ActionHandler()
        {
        
        }
        public abstract TzarGames.GameFramework.IObjectActionResult CanBePerformed(TzarGames.GameFramework.IActionPerformer performer, TzarGames.GameFramework.IActionTarget target); // 0
        public abstract TzarGames.GameFramework.IObjectActionResult Perform(TzarGames.GameFramework.IActionPerformer performer, TzarGames.GameFramework.IActionTarget target); // 0
    
    }

}

using UnityEngine;

namespace TzarGames.Endless.Quests
{
    public class NewWorldPortal : MonoBehaviour
    {
        // Methods
        public NewWorldPortal()
        {
        
        }
        public void TeleportToNewWorld(TzarGames.GameFramework.ActionEventData actionData)
        {
            var val_6;
            UnityEngine.UI.Extensions.BoundTooltipItem val_1 = UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>();
            if(0 == val_1)
            {
                    return;
            }
            
            TzarGames.GameFramework.IActionPerformer val_4 = actionData.Performer;
            val_6 = 0;
            val_1.Teleport(character:  null);
        }
        public void TeleportToHome(TzarGames.GameFramework.ActionEventData actionData)
        {
            UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>().Teleport();
        }
    
    }

}

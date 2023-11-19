using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class NotificationBehaviour : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private float tempMessageDefaultTime;
        [UnityEngine.SerializeField]
        private UnityEngine.Sprite defaultSprite;
        private TzarGames.Endless.UI.NotificationEntryUI entry;
        private TzarGames.Endless.UI.NotificationUI lastNotificationUI;
        
        // Methods
        public NotificationBehaviour()
        {
            this.tempMessageDefaultTime = 5f;
        }
        public void ShowTempLocalizedMessage(TzarGames.Common.LocalizedStringAsset message)
        {
            float val_5;
            UnityEngine.Sprite val_6;
            string val_7;
            UnityEngine.UI.Extensions.BoundTooltipItem val_1 = UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>();
            if(0 == val_1)
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            string val_4 = TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
            if(0 == this.defaultSprite)
            {
                    val_5 = this.tempMessageDefaultTime;
                val_6 = 0;
                val_7 = val_4;
            }
            else
            {
                    val_5 = this.tempMessageDefaultTime;
                val_7 = val_4;
                val_6 = this.defaultSprite;
            }
            
            val_1.AddTempNotificationWithIcon(message:  val_7, icon:  val_6, time:  val_5);
        }
        public void SetConstantLocalizedMessage(TzarGames.Common.LocalizedStringAsset message)
        {
            this.SetConstantMessage(message:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
        }
        public void SetConstantMessage(string message)
        {
            string val_7 = message;
            if(0 == this.entry)
            {
                    UnityEngine.UI.Extensions.BoundTooltipItem val_2 = UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>();
                if(0 != val_2)
            {
                    this.lastNotificationUI = val_2;
                val_7 = val_2.AddConstantNotification(message:  val_7 = message);
                this.entry = val_7;
                if(0 != val_7)
            {
                    return;
            }
            
            }
            
                UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            this.entry.text.text = val_7;
        }
        public void RemoveConstantMessage()
        {
            if(0 == this.entry)
            {
                    return;
            }
            
            if(0 == this.lastNotificationUI)
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            this = this.lastNotificationUI;
            this.RemoveConstantNotification(entryUi:  this.entry);
            this.entry = 0;
            this.lastNotificationUI = 0;
        }
    
    }

}

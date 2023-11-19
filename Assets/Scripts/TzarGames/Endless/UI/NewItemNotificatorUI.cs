using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class NewItemNotificatorUI : MonoBehaviour, IItemNotificatorHandler
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.NotificationUI notificationUI;
        [UnityEngine.SerializeField]
        private float showTime;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset newArmorSetText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset newWeaponText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset newShieldText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset otherItemText;
        
        // Methods
        public NewItemNotificatorUI()
        {
            this.showTime = 15f;
        }
        private void OnEnable()
        {
            TzarGames.Common.EventSystem.Event<TzarGames.TzarHero.ICharacterEvents>.AddHandler(obj:  0);
        }
        private void OnDisable()
        {
            TzarGames.Common.EventSystem.Event<TzarGames.TzarHero.ICharacterEvents>.RemoveHandler(obj:  0);
        }
        public void OnNewItemsAvailable(TzarGames.GameFramework.Item[] items)
        {
            var val_8;
            goto label_1;
            label_27:
            0 = 1;
            label_1:
            if(0 >= items.Length)
            {
                    return;
            }
            
            val_8 = 1;
            if(items[val_8].AvailableOnShop == false)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                goto label_10;
            }
            
            string val_3 = 0 + "Localized name is null for ";
            UnityEngine.Debug.LogError(message:  0);
            goto label_27;
            label_10:
            this.notificationUI.AddTempNotificationWithIcon(message:  System.String.Format(format:  0, arg0:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0)), icon:  0, time:  this.showTime);
            goto label_27;
        }
    
    }

}

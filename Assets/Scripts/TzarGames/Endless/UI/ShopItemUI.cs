using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class ShopItemUI : InventoryItemInfo
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Image disabledImage;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI existInInventory;
        
        // Properties
        public bool Disabled { get; set; }
        public bool ExistInInventory { get; set; }
        
        // Methods
        public ShopItemUI()
        {
        
        }
        public bool get_Disabled()
        {
            UnityEngine.GameObject val_1 = this.disabledImage.gameObject;
            if(val_1 != null)
            {
                    return val_1.activeSelf;
            }
            
            return val_1.activeSelf;
        }
        public void set_Disabled(bool value)
        {
            this.disabledImage.gameObject.SetActive(value:  value);
        }
        public bool get_ExistInInventory()
        {
            UnityEngine.GameObject val_1 = this.existInInventory.gameObject;
            if(val_1 != null)
            {
                    return val_1.activeSelf;
            }
            
            return val_1.activeSelf;
        }
        public void set_ExistInInventory(bool value)
        {
            this.existInInventory.gameObject.SetActive(value:  value);
        }
    
    }

}

using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class HealingPotionHudUI : GameUIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.TH_Health healingItem;
        [UnityEngine.SerializeField]
        private UnityEngine.RectTransform container;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI counter;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Image cooldownIcon;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onUsed;
        private TzarGames.Endless.PlayerCharacter playerCharacter;
        
        // Methods
        public HealingPotionHudUI()
        {
        
        }
        protected override void OnPlayerOwnerSet(TzarGames.GameFramework.Player owner)
        {
            this.OnPlayerOwnerSet(owner:  owner);
            this.playerCharacter = 0;
            0.TemplateInstance.Inventory.DefaultBag.add_OnItemsChanged(value:  new System.Action<TzarGames.GameFramework.InventoryBag>(object:  this, method:  System.Void TzarGames.Endless.UI.HealingPotionHudUI::DefaultBagOnOnItemsChanged(TzarGames.GameFramework.InventoryBag inventoryBag)));
        }
        private void Update()
        {
            if(this.container.gameObject.activeSelf == false)
            {
                    return;
            }
            
            float val_4 = this.playerCharacter.HealingPotionCooldownTime;
            val_4 = this.cooldownIcon.fillAmount - val_4;
            if(System.Math.Abs(val_4) <= 0.0001f)
            {
                    return;
            }
            
            this.cooldownIcon.fillAmount = val_4;
        }
        public override void NotifyShown()
        {
            this.NotifyShown();
            this.refreshItems();
        }
        private void DefaultBagOnOnItemsChanged(TzarGames.GameFramework.InventoryBag inventoryBag)
        {
            this.refreshItems();
        }
        private void refreshItems()
        {
            TzarGames.Common.UI.TextUI val_11;
            int val_5 = this.playerCharacter.TemplateInstance.Inventory.DefaultBag.GetConsumableItemCount(itemId:  this.healingItem.Id);
            bool val_7 = this.container.gameObject.activeSelf;
            if(val_5 != 0)
            {
                    if(val_7 != true)
            {
                    this.container.gameObject.SetActive(value:  true);
            }
            
                val_11 = this.counter;
                val_11.text = val_5;
                return;
            }
            
            if(val_7 == false)
            {
                    return;
            }
            
            val_11 = this.container.gameObject;
            val_11.SetActive(value:  false);
        }
        public void OnUseClick()
        {
            int val_10 = this.healingItem.Id;
            if((this.playerCharacter.TemplateInstance.Inventory.DefaultBag.GetConsumableItemCount(itemId:  val_10 = this.healingItem.Id)) < 1)
            {
                    return;
            }
            
            val_10 = this.healingItem;
            if((this.playerCharacter & 1) == 0)
            {
                    return;
            }
            
            if((this.playerCharacter.TemplateInstance.Inventory.DefaultBag.RemoveConsumableItem(item:  this.healingItem, count:  1)) != false)
            {
                    this.refreshItems();
            }
            
            this.onUsed.Invoke();
        }
    
    }

}

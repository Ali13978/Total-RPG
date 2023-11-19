using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class MaskInventoryUI : GameUIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.Masks.MaskRewardInfo maskRewardInfo;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.MaskGroupUI[] maskGroups;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.InventoryItemInfo itemInfo;
        [UnityEngine.SerializeField]
        private UnityEngine.RectTransform itemInfoContainer;
        
        // Methods
        public MaskInventoryUI()
        {
        
        }
        protected override void Awake()
        {
            var val_3;
            this.Awake();
            val_3 = 0;
            goto label_1;
            label_7:
            add_OnMaskClicked(value:  X21);
            val_3 = 1;
            label_1:
            if(val_3 >= this.maskGroups.Length)
            {
                    return;
            }
            
            TzarGames.Endless.UI.MaskGroupUI val_3 = this.maskGroups[1];
            val_3.add_OnGetRewardClicked(value:  new System.Action<TzarGames.Endless.UI.MaskGroupUI>(object:  this, method:  System.Void TzarGames.Endless.UI.MaskInventoryUI::MaskGroup_OnGetRewardClicked(TzarGames.Endless.UI.MaskGroupUI maskGroupUI)));
            System.Action<TzarGames.Endless.UI.MaskItemUI> val_2 = new System.Action<TzarGames.Endless.UI.MaskItemUI>(object:  this, method:  System.Void TzarGames.Endless.UI.MaskInventoryUI::MaskGroup_MaskClicked(TzarGames.Endless.UI.MaskItemUI maskItemUi));
            if(val_3 != null)
            {
                goto label_7;
            }
            
            goto label_7;
        }
        public override void NotifyShown()
        {
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            this.NotifyShown();
            this.itemInfo.Item = 0;
            this.itemInfoContainer.gameObject.SetActive(value:  false);
            TzarGames.GameFramework.Player val_2 = this.PlayerOwner;
            val_18 = 0;
            TzarGames.GameFramework.InventoryBag val_8 = 0.TemplateInstance.Inventory.HiddenBag;
            val_19 = 0;
            goto label_13;
            label_60:
            val_8.interactable = false;
            val_19 = 1;
            label_13:
            if(val_19 >= this.maskGroups.Length)
            {
                    return;
            }
            
            if(val_19 >= this.maskGroups.Length)
            {
                    val_18 = 0;
            }
            
            TzarGames.Endless.UI.MaskGroupUI val_18 = this.maskGroups[1];
            val_20 = 0;
            goto label_18;
            label_33:
            this.maskGroups.Collected = false;
            val_20 = 1;
            label_18:
            if(val_20 >= this.maskGroups[0x1][0].maskIcons.Length)
            {
                goto label_21;
            }
            
            if(val_20 >= this.maskGroups[0x1][0].maskIcons.Length)
            {
                    val_18 = 0;
            }
            
            TzarGames.Endless.UI.MaskItemUI val_19 = this.maskGroups[0x1][0].maskIcons[1];
            System.Collections.Generic.List<TzarGames.GameFramework.ItemInstance> val_9 = 0.TemplateInstance.Inventory.GetBagByName(bagName:  "MASKS_BAG").GetAllItemInstancesById(id:  this.maskGroups[0x1][0].maskIcons[0x1][0].maskItem);
            if((val_9 == null) || (val_9.Count < 1))
            {
                goto label_29;
            }
            
            if(val_19 != null)
            {
                goto label_33;
            }
            
            goto label_33;
            label_29:
            if(val_19 != null)
            {
                goto label_33;
            }
            
            goto label_33;
            label_21:
            TzarGames.Endless.UI.MaskItemUI val_20 = this.maskGroups[0x1][0].maskIcons[0];
            MaskGroup val_11 = this.maskRewardInfo.GetGroupOfMask(targetMask:  this.maskGroups[0x1][0].maskIcons[0].maskItem);
            System.Collections.Generic.List<TzarGames.GameFramework.ItemInstance> val_12 = val_8.GetAllItemInstancesById(id:  val_11.HiddenRewardItem);
            if((val_12 == null) || (val_12.Count < 1))
            {
                goto label_43;
            }
            
            if(this.maskGroups[0x1][0].getRewardButton != null)
            {
                goto label_60;
            }
            
            goto label_60;
            label_43:
            var val_22 = 0;
            label_52:
            if(val_22 >= this.maskGroups[0x1][0].maskIcons.Length)
            {
                goto label_49;
            }
            
            val_22 = val_22 + 1;
            if(this.maskGroups[0x1][0].maskIcons[0].Collected == true)
            {
                goto label_52;
            }
            
            val_21 = 0;
            goto label_53;
            label_49:
            val_21 = 1;
            label_53:
            TzarGames.Endless.EndlessGameState val_15 = TzarGames.Endless.EndlessGameState.Instance;
            if(0 != val_15)
            {
                    val_21 = val_21 & val_15.IsItSafeStateToSaveGame();
            }
            
            if(this.maskGroups[0x1][0].getRewardButton != null)
            {
                goto label_60;
            }
            
            goto label_60;
        }
        private void MaskGroup_OnGetRewardClicked(TzarGames.Endless.UI.MaskGroupUI maskGroupUI)
        {
            TzarGames.Endless.UI.MaskItemUI val_3 = maskGroupUI.maskIcons[0];
            MaskGroup val_1 = this.maskRewardInfo.GetGroupOfMask(targetMask:  maskGroupUI.maskIcons[0].maskItem);
            TzarGames.GameFramework.Player val_2 = this.PlayerOwner;
            MaskInventoryUI.MaskRewardUtility.RewardPlayer(player:  val_2, group:  val_2);
            maskGroupUI.getRewardButton.interactable = false;
        }
        private void MaskGroup_MaskClicked(TzarGames.Endless.UI.MaskItemUI maskItemUi)
        {
            TzarGames.GameFramework.Player val_1 = this.PlayerOwner;
            System.Collections.Generic.List<TzarGames.GameFramework.ItemInstance> val_5 = 0.TemplateInstance.Inventory.GetBagByName(bagName:  "MASKS_BAG").GetAllItemInstancesById(id:  maskItemUi.maskItem);
            if(val_5 != null)
            {
                    if(val_5.Count != 0)
            {
                    this.itemInfoContainer.gameObject.SetActive(value:  true);
                this.itemInfo.Item = val_5.Item[0].GetTemplateInstance();
                this.itemInfo.UpdateData(template:  this.itemInfo.Item, ownerLevel:  0.Level);
                return;
            }
            
            }
            
            this.itemInfoContainer.gameObject.SetActive(value:  false);
            this.itemInfo.Item = 0;
        }
    
    }

}

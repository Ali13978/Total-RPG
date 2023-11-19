using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class InventoryUI : InventoryBaseUI
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase inventoryWindow;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase dialogWindow;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.InventoryUI.ItemTab inventoryTab;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.InventoryUI.ItemTab maskTab;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Button wearButton;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Button wearLeftButton;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Button unwearButton;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Button sellButton;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI sellDialogText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset sellDialogMessage;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Button useButton;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset itemInfoLevel;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.InventoryItemInfo itemInfo;
        [UnityEngine.SerializeField]
        private UnityEngine.RectTransform itemInfoContainer;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Events.ItemEvent onItemUse;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Events.ItemEvent onItemWear;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Events.ItemEvent onItemUnwear;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Events.ItemEvent onItemSell;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onCannotWear;
        private TzarGames.Endless.UI.InventoryUI.ItemTab currentTab;
        
        // Methods
        public InventoryUI()
        {
        
        }
        public override void NotifyShown()
        {
            this.NotifyShown();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.showTabRoutine(tab:  this.inventoryTab));
        }
        public void ShowInvenoryTab()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.showTabRoutine(tab:  this.inventoryTab));
        }
        public void ShowMaskTab()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.showTabRoutine(tab:  this.maskTab));
        }
        private void showTab(TzarGames.Endless.UI.InventoryUI.ItemTab tab)
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.showTabRoutine(tab:  tab));
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator showTabRoutine(TzarGames.Endless.UI.InventoryUI.ItemTab tab)
        {
            if(null != 0)
            {
                    typeof(InventoryUI.<showTabRoutine>c__Iterator0).__il2cppRuntimeField_10 = tab;
            }
            else
            {
                    mem[16] = tab;
            }
            
            typeof(InventoryUI.<showTabRoutine>c__Iterator0).__il2cppRuntimeField_18 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public void OnUseClicked()
        {
            var val_35;
            TzarGames.GameFramework.Item val_36;
            var val_37;
            var val_38;
            object val_39;
            var val_40;
            var val_41;
            var val_42;
            TzarGames.GameFramework.Events.ItemEvent val_43;
            TzarGames.GameFramework.Player val_1 = this.PlayerOwner;
            val_35 = 0;
            TzarGames.Endless.UI.InventoryItemUI val_3 = this.LastSelected;
            if(val_3.item.ConsumptionType != 1)
            {
                goto label_7;
            }
            
            TzarGames.Endless.UI.InventoryItemUI val_6 = this.LastSelected;
            val_36 = TemplateInstance.Inventory.GetBagOfItemInstance(itemInstance:  val_6.itemInstance);
            if(val_36 == null)
            {
                goto label_35;
            }
            
            TzarGames.Endless.UI.InventoryItemUI val_8 = this.LastSelected;
            TzarGames.GameFramework.Item val_9 = val_8.itemInstance.GetTemplateInstance();
            if(val_9 == null)
            {
                goto label_37;
            }
            
            TzarGames.Endless.UI.InventoryItemUI val_10 = this.LastSelected;
            TzarGames.Endless.UI.InventoryItemUI val_11 = this.LastSelected;
            TzarGames.Endless.UI.InventoryItemUI val_12 = this.LastSelected;
            var val_35 = 0;
            val_35 = val_35 + 1;
            val_37 = val_9;
            goto label_24;
            label_7:
            TzarGames.Endless.UI.InventoryItemUI val_13 = this.LastSelected;
            val_36 = val_13.item;
            if(val_13.item.ConsumptionType == 0)
            {
                goto label_27;
            }
            
            val_38 = "Wrong type";
            val_39 = 0;
            goto label_56;
            label_27:
            TzarGames.Endless.UI.InventoryItemUI val_16 = this.LastSelected;
            val_40 = TemplateInstance.Inventory.GetBagOfConsumableItem(item:  val_16.item);
            if(val_40 == null)
            {
                goto label_35;
            }
            
            TzarGames.Endless.UI.InventoryItemUI val_18 = this.LastSelected;
            if(val_18.item == null)
            {
                goto label_37;
            }
            
            TzarGames.Endless.UI.InventoryItemUI val_19 = this.LastSelected;
            TzarGames.Endless.UI.InventoryItemUI val_20 = this.LastSelected;
            bool val_21 = val_40.RemoveConsumableItem(item:  val_20.item, count:  1);
            TzarGames.Endless.EndlessGameState val_22 = TzarGames.Endless.EndlessGameState.Instance;
            if((0 == val_22) || (val_22.IsItSafeStateToSaveGame() == false))
            {
                goto label_46;
            }
            
            TzarGames.GameFramework.GameManager val_25 = TzarGames.GameFramework.GameManager.Instance;
            if(val_25 == null)
            {
                goto label_49;
            }
            
            val_41 = null;
            val_41 = null;
            val_25 = (((TzarGames.GameFramework.GameManager.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.EndlessGameManager.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_41) ? (val_25) : 0;
            goto label_53;
            label_35:
            val_38 = "No bag found";
            val_39 = 0;
            goto label_56;
            label_37:
            val_38 = "Item is not usable";
            val_39 = 0;
            label_56:
            UnityEngine.Debug.LogError(message:  val_39);
            return;
            label_24:
            if((val_9 & 1) != 0)
            {
                    TzarGames.Endless.UI.InventoryItemUI val_27 = this.LastSelected;
                val_36.RemoveItem(itemInstance:  val_27.itemInstance);
                TzarGames.Endless.EndlessGameState val_28 = TzarGames.Endless.EndlessGameState.Instance;
                if((0 != val_28) && (val_28.IsItSafeStateToSaveGame() != false))
            {
                    TzarGames.GameFramework.GameManager val_31 = TzarGames.GameFramework.GameManager.Instance;
                if(val_31 != null)
            {
                    val_42 = null;
                val_42 = null;
                val_31 = (((TzarGames.GameFramework.GameManager.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.EndlessGameManager.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_42) ? (val_31) : 0;
            }
            
                0.SaveGameWithPlayerData();
            }
            
                this.LastSelected = 0;
            }
            
            val_43 = this.onItemUse;
            val_43.Invoke(arg0:  val_12.item);
            goto label_79;
            label_49:
            label_53:
            0.SaveGameWithPlayerData();
            label_46:
            TzarGames.Endless.UI.InventoryItemUI val_32 = this.LastSelected;
            this.onItemUse.Invoke(arg0:  val_32.item);
            TzarGames.Endless.UI.InventoryItemUI val_33 = this.LastSelected;
            if((val_40.GetConsumableItemCount(itemId:  val_33.item)) == 0)
            {
                    this.LastSelected = 0;
            }
            
            label_79:
            this.RefreshItems();
        }
        public void OnWearClicked()
        {
            this.wear(slot:  0);
        }
        public void OnWearLeftClicked()
        {
            this.wear(slot:  1);
        }
        private void wear(int slot)
        {
            var val_17;
            TzarGames.GameFramework.Player val_1 = this.PlayerOwner;
            TzarGames.Endless.UI.InventoryItemUI val_3 = this.LastSelected;
            if((0.TemplateInstance & 1) == 0)
            {
                goto label_7;
            }
            
            TzarGames.TzarHero.TH_CharacterTemplate val_4 = 0.TemplateInstance;
            TzarGames.Endless.UI.InventoryItemUI val_5 = this.LastSelected;
            TzarGames.Endless.EndlessGameState val_6 = TzarGames.Endless.EndlessGameState.Instance;
            if((0 == val_6) || (val_6.IsItSafeStateToSaveGame() == false))
            {
                goto label_15;
            }
            
            TzarGames.GameFramework.GameManager val_9 = TzarGames.GameFramework.GameManager.Instance;
            if(val_9 == null)
            {
                goto label_18;
            }
            
            val_17 = null;
            val_17 = null;
            val_9 = (((TzarGames.GameFramework.GameManager.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.EndlessGameManager.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_17) ? (val_9) : 0;
            goto label_22;
            label_7:
            this.onCannotWear.Invoke();
            return;
            label_18:
            label_22:
            0.SaveGameWithPlayerData();
            label_15:
            TzarGames.Endless.UI.InventoryItemUI val_12 = this.LastSelected;
            TzarGames.GameFramework.ItemInstance val_17 = val_12.itemInstance;
            val_17 = 0.TemplateInstance.IsItemActivated(item:  val_17);
            this.LastSelected.IsActivated = val_17;
            if(this.LastSelected.IsActivated == false)
            {
                    return;
            }
            
            TzarGames.Endless.UI.InventoryItemUI val_16 = this.LastSelected;
            this.onItemWear.Invoke(arg0:  val_16.item);
        }
        public void OnUnwearClicked()
        {
            var val_21;
            if(0 == this.LastSelected)
            {
                    return;
            }
            
            TzarGames.GameFramework.Player val_4 = this.PlayerOwner;
            TzarGames.TzarHero.TH_CharacterTemplate val_5 = 0.TemplateInstance;
            TzarGames.Endless.UI.InventoryItemUI val_6 = this.LastSelected;
            TzarGames.TzarHero.TH_CharacterTemplate val_7 = 0.TemplateInstance;
            TzarGames.Endless.UI.InventoryItemUI val_8 = this.LastSelected;
            TzarGames.Endless.EndlessGameState val_9 = TzarGames.Endless.EndlessGameState.Instance;
            if((0 != val_9) && (val_9.IsItSafeStateToSaveGame() != false))
            {
                    TzarGames.GameFramework.GameManager val_12 = TzarGames.GameFramework.GameManager.Instance;
                if(val_12 != null)
            {
                    val_21 = null;
                val_21 = null;
                val_12 = (((TzarGames.GameFramework.GameManager.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.EndlessGameManager.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_21) ? (val_12) : 0;
            }
            
                0.SaveGameWithPlayerData();
            }
            
            TzarGames.Endless.UI.InventoryItemUI val_15 = this.LastSelected;
            TzarGames.GameFramework.ItemInstance val_21 = val_15.itemInstance;
            val_21 = 0.TemplateInstance.IsItemActivated(item:  val_21);
            this.LastSelected.IsActivated = val_21;
            if(this.LastSelected.IsActivated != false)
            {
                    return;
            }
            
            TzarGames.Endless.UI.InventoryItemUI val_20 = this.LastSelected;
            this.onItemUnwear.Invoke(arg0:  val_20.item);
        }
        public void OnSellClicked()
        {
            TzarGames.Common.UI.UIBase val_9;
            var val_10;
            val_9 = this;
            val_10 = 0;
            if(TzarGames.GameFramework.GameManager.Instance != null)
            {
                    val_10 = 0;
            }
            
            if(0 == )
            {
                    return;
            }
            
            TzarGames.Endless.UI.InventoryItemUI val_5 = this.LastSelected;
            int val_6 = GetItemSellCost(item:  val_5.item);
            this.sellDialogText.text = System.String.Format(format:  0, arg0:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
            val_9 = this.dialogWindow;
        }
        public void CancelDialog()
        {
            if(this.dialogWindow == null)
            {
                
            }
        
        }
        public void OnConfirmSellClicked()
        {
            this.SellItem();
            this.CancelDialog();
        }
        public void SellItem()
        {
            var val_13;
            TzarGames.GameFramework.ItemInstance val_14;
            if(0 == this.LastSelected)
            {
                    return;
            }
            
            val_13 = 0;
            if(TzarGames.GameFramework.GameManager.Instance != null)
            {
                    val_13 = 0;
            }
            
            if(0 == )
            {
                    return;
            }
            
            TzarGames.Endless.UI.InventoryItemUI val_8 = this.LastSelected;
            TzarGames.Endless.UI.InventoryItemUI val_9 = this.LastSelected;
            if(val_8.itemInstance == null)
            {
                goto label_14;
            }
            
            val_14 = val_9.itemInstance;
            SellItemInstance(itemInstance:  val_14);
            goto label_16;
            label_14:
            if(0 == val_9.item)
            {
                goto label_19;
            }
            
            TzarGames.Endless.UI.InventoryItemUI val_11 = this.LastSelected;
            val_14 = val_11.item;
            SellConsumableItem(item:  val_14, count:  1);
            label_16:
            TzarGames.Endless.UI.InventoryItemUI val_12 = this.LastSelected;
            this.LastSelected = 0;
            this.RefreshItems();
            this.onItemSell.Invoke(arg0:  val_12.item);
            return;
            label_19:
            UnityEngine.Debug.LogError(message:  0);
        }
        public void OnDestroyClick()
        {
            var val_13;
            var val_14;
            var val_15;
            TzarGames.GameFramework.Player val_1 = this.PlayerOwner;
            val_13 = 0;
            TzarGames.Endless.UI.InventoryItemUI val_3 = this.LastSelected;
            val_14 = TemplateInstance.Inventory.GetBagOfItemInstance(itemInstance:  val_3.itemInstance);
            if(val_14 == null)
            {
                    return;
            }
            
            val_1.PlayerComponent = val_14.IsItemInstanceLocked(itemInstance:  val_3.itemInstance);
            if(val_1.PlayerComponent != false)
            {
                    return;
            }
            
            val_14.RemoveItem(itemInstance:  val_3.itemInstance);
            TzarGames.Endless.EndlessGameState val_8 = TzarGames.Endless.EndlessGameState.Instance;
            if((0 != val_8) && (val_8.IsItSafeStateToSaveGame() != false))
            {
                    TzarGames.GameFramework.GameManager val_11 = TzarGames.GameFramework.GameManager.Instance;
                if(val_11 != null)
            {
                    val_14 = 1152921504861052928;
                val_15 = null;
                val_15 = null;
                val_11 = (((TzarGames.GameFramework.GameManager.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.EndlessGameManager.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_15) ? (val_11) : 0;
            }
            
                0.SaveGameWithPlayerData();
            }
            
            this.LastSelected.IsActivated = false;
            this.RefreshItems();
        }
        public override void UpdateUI()
        {
            var val_46;
            var val_47;
            var val_48;
            var val_49;
            var val_50;
            var val_51;
            var val_52;
            UnityEngine.UI.Button val_53;
            var val_54;
            var val_55;
            var val_56;
            UnityEngine.UI.Button val_57;
            UnityEngine.UI.Button val_58;
            var val_59;
            var val_60;
            TzarGames.GameFramework.Player val_1 = this.PlayerOwner;
            val_46 = 0;
            val_47 = 0;
            if(0 == this.LastSelected)
            {
                goto label_7;
            }
            
            TzarGames.Endless.UI.InventoryItemUI val_5 = this.LastSelected;
            TzarGames.Endless.UI.InventoryItemUI val_6 = this.LastSelected;
            if(val_5.itemInstance == null)
            {
                goto label_10;
            }
            
            if(this.LastSelected.IsActivated == false)
            {
                goto label_12;
            }
            
            this.wearButton.interactable = false;
            UnityEngine.GameObject val_10 = this.wearButton.gameObject;
            if((TemplateInstance & 1) == 0)
            {
                goto label_18;
            }
            
            val_10.SetActive(value:  false);
            val_48 = this.unwearButton.gameObject;
            val_49 = 1;
            goto label_21;
            label_7:
            this.wearButton.interactable = false;
            this.useButton.gameObject.SetActive(value:  false);
            this.itemInfo.Item = 0;
            this.itemInfoContainer.gameObject.SetActive(value:  false);
            this.sellButton.interactable = false;
            goto label_29;
            label_10:
            if(val_6.item == null)
            {
                goto label_32;
            }
            
            val_50 = 1;
            goto label_33;
            label_12:
            TzarGames.Endless.UI.InventoryItemUI val_15 = this.LastSelected;
            if(val_15.item == null)
            {
                goto label_40;
            }
            
            val_51 = TemplateInstance & 1;
            goto label_43;
            label_18:
            val_10.SetActive(value:  true);
            val_48 = this.unwearButton.gameObject;
            val_49 = 0;
            label_21:
            val_48.SetActive(value:  false);
            val_52 = 0;
            goto label_47;
            label_32:
            val_50 = 0;
            label_33:
            this.useButton.gameObject.SetActive(value:  false);
            this.sellButton.interactable = true;
            this.unwearButton.gameObject.SetActive(value:  false);
            val_53 = this.wearButton;
            if(val_53 != null)
            {
                goto label_80;
            }
            
            goto label_52;
            label_40:
            val_51 = 0;
            label_43:
            this.wearButton.gameObject.SetActive(value:  true);
            this.wearButton.interactable = false;
            this.unwearButton.gameObject.SetActive(value:  false);
            val_54 = 0;
            if(TzarGames.GameFramework.GameManager.Instance != null)
            {
                    val_54 = 0;
            }
            
            val_47 = 0;
            if(0 != )
            {
                    val_52 = CanSellItemInstance(itemInstance:  val_6.itemInstance);
            }
            else
            {
                    val_52 = 0;
            }
            
            label_47:
            this.sellButton.interactable = false;
            if(val_6.itemInstance.GetTemplateInstance() == null)
            {
                goto label_71;
            }
            
            TzarGames.Endless.UI.InventoryItemUI val_27 = this.LastSelected;
            if(val_27.item == null)
            {
                goto label_73;
            }
            
            if((TemplateInstance & 1) == 0)
            {
                goto label_78;
            }
            
            val_55 = 1;
            goto label_79;
            label_71:
            val_53 = this.useButton;
            if(val_53 != null)
            {
                goto label_80;
            }
            
            label_52:
            label_80:
            val_56 = val_53.gameObject;
            val_55 = 0;
            goto label_85;
            label_73:
            val_56 = this.useButton.gameObject;
            val_55 = 1;
            goto label_85;
            label_78:
            val_55 = 0;
            label_79:
            label_85:
            this.useButton.gameObject.SetActive(value:  false);
            this.itemInfoContainer.gameObject.SetActive(value:  true);
            TzarGames.Endless.UI.InventoryItemUI val_33 = this.LastSelected;
            this.itemInfo.UpdateData(template:  val_33.item, ownerLevel:  Level, levelInfoFormat:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
            label_29:
            if(0 == this.LastSelected)
            {
                goto label_95;
            }
            
            TzarGames.Endless.UI.InventoryItemUI val_39 = this.LastSelected;
            if(val_39.itemInstance == null)
            {
                goto label_95;
            }
            
            val_57 = this.wearButton;
            goto label_96;
            label_95:
            val_57 = this;
            this.wearButton.interactable = false;
            label_96:
            val_58 = this.wearButton;
            if(val_58.interactable == false)
            {
                goto label_107;
            }
            
            val_58 = this.LastSelected;
            if(val_41.item == null)
            {
                goto label_107;
            }
            
            TzarGames.Endless.UI.InventoryItemUI val_43 = this.LastSelected;
            val_58 = val_43.itemInstance;
            if((TemplateInstance & 1) == 0)
            {
                goto label_107;
            }
            
            val_59 = this.wearLeftButton.gameObject;
            val_60 = 1;
            goto label_110;
            label_107:
            val_59 = this.wearLeftButton.gameObject;
            val_60 = 0;
            label_110:
            val_59.SetActive(value:  false);
            this.UpdateUI();
        }
    
    }

}

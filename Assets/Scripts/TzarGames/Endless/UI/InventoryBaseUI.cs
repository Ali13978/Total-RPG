using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class InventoryBaseUI : GameUIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.RectTransform container;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.InventoryItemUI itemPrefab;
        protected System.Collections.Generic.List<TzarGames.Endless.UI.InventoryItemUI> items;
        private TzarGames.Endless.PlayerCharacter _playerCharacter;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.Endless.UI.InventoryItemUI <LastSelected>k__BackingField;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI goldText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI rubyText;
        private bool needRefreshItems;
        
        // Properties
        protected TzarGames.Endless.UI.InventoryItemUI LastSelected { get; set; }
        
        // Methods
        public InventoryBaseUI()
        {
            this.needRefreshItems = true;
            this.items = new System.Collections.Generic.List<TzarGames.Endless.UI.InventoryItemUI>();
        }
        protected TzarGames.Endless.UI.InventoryItemUI get_LastSelected()
        {
            return (TzarGames.Endless.UI.InventoryItemUI)this.<LastSelected>k__BackingField;
        }
        protected void set_LastSelected(TzarGames.Endless.UI.InventoryItemUI value)
        {
            this.<LastSelected>k__BackingField = value;
        }
        protected virtual void Start()
        {
        
        }
        public override void NotifyShown()
        {
            this.NotifyShown();
            if(this.needRefreshItems != false)
            {
                    this.needRefreshItems = false;
                this.RefreshItems();
            }
        
        }
        private UnityEngine.Transform getContainerForItem(TzarGames.GameFramework.Item item)
        {
            return (UnityEngine.Transform)this.container;
        }
        public void RefreshItems()
        {
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            val_30 = 1152921504721543168;
            val_31 = 0;
            if(0 != (this.<LastSelected>k__BackingField))
            {
                    val_31 = this.<LastSelected>k__BackingField.ItemInstance;
            }
            
            UnityEngine.RectTransform val_30 = this.container;
            val_30 = val_30.childCount - 1;
            if((val_30 & 2147483648) == 0)
            {
                    do
            {
                UnityEngine.Transform val_4 = this.container.GetChild(index:  val_30);
                if(val_4 != null)
            {
                    val_4.SetParent(parent:  0);
            }
            else
            {
                    0.SetParent(parent:  0);
            }
            
                UnityEngine.GameObject val_5 = val_4.gameObject;
                TzarGames.GameFramework.GameManager.DestroyInstance(obj:  0);
                val_30 = val_30 - 1;
            }
            while((val_30 & 2147483648) == 0);
            
            }
            
            this.items.Clear();
            if(0 != this._playerCharacter)
            {
                goto label_16;
            }
            
            TzarGames.GameFramework.Player val_7 = this.PlayerOwner;
            val_32 = 0;
            this._playerCharacter = ;
            if(0 == )
            {
                goto label_23;
            }
            
            System.Action<TzarGames.GameFramework.InventoryBag> val_13 = new System.Action<TzarGames.GameFramework.InventoryBag>(object:  this, method:  System.Void TzarGames.Endless.UI.InventoryBaseUI::DefaultBagOnOnItemsChanged(TzarGames.GameFramework.InventoryBag inventoryBag));
            this._playerCharacter.TemplateInstance.Inventory.DefaultBag.add_OnItemsChanged(value:  val_13);
            label_16:
            val_33 = 0;
            goto label_32;
            label_39:
            this.createItem(item:  System.Void TzarGames.Endless.UI.InventoryBaseUI::DefaultBagOnOnItemsChanged(TzarGames.GameFramework.InventoryBag inventoryBag), itemInstance:  val_13, activated:  IsItemActivated(item:  val_13), count:  1);
            val_33 = 1;
            label_32:
            if(val_33 >= val_17.Length)
            {
                goto label_34;
            }
            
            TzarGames.GameFramework.Item val_20 = this._playerCharacter.TemplateInstance.Inventory.DefaultBag.GetAllNonconsumableItems()[1].GetOriginalTemplate();
            if(this._playerCharacter.TemplateInstance != null)
            {
                goto label_39;
            }
            
            goto label_39;
            label_34:
            val_34 = 0;
            goto label_44;
            label_48:
            this.createItem(item:  this._playerCharacter.TemplateInstance.Inventory.DefaultBag.GetAllConsumableItems()[907345920].InitializationCallback, itemInstance:  0, activated:  false, count:  2034993648);
            val_34 = 1;
            label_44:
            if(val_34 >= val_25.Length)
            {
                goto label_46;
            }
            
            if(val_34 < val_25.Length)
            {
                goto label_48;
            }
            
            goto label_48;
            label_46:
            if(val_31 == null)
            {
                    return;
            }
            
            List.Enumerator<T> val_27 = this.items.GetEnumerator();
            val_30 = 1152921510936785648;
            label_53:
            if((0 & 1) == 0)
            {
                goto label_51;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_28 = 0.InitializationCallback;
            if(val_28.ItemInstance != val_31)
            {
                goto label_53;
            }
            
            this.selectItem(itemUI:  val_28);
            label_51:
            val_35 = 0;
            val_32 = 1;
            val_36 = public System.Void List.Enumerator<TzarGames.Endless.UI.InventoryItemUI>::Dispose();
            0.Dispose();
            if(( & 1) != 0)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_36 = 0;
            return;
            label_23:
            UnityEngine.Debug.LogError(message:  0);
        }
        private void DefaultBagOnOnItemsChanged(TzarGames.GameFramework.InventoryBag inventoryBag)
        {
            this.needRefreshItems = true;
        }
        private void createItem(TzarGames.GameFramework.Item item, TzarGames.GameFramework.ItemInstance itemInstance, bool activated, int count)
        {
            TzarGames.GameFramework.Item val_7;
            TzarGames.GameFramework.ItemConsumptionType val_8;
            TzarGames.Endless.UI.SkillUpgradeUI val_1 = TzarGames.GameFramework.GameManager.MakeInstance<TzarGames.Endless.UI.SkillUpgradeUI>(obj:  0);
            val_1.transform.SetParent(parent:  this.container, worldPositionStays:  false);
            if(val_1 != null)
            {
                    val_1.ItemIcon = item.Sprite;
                val_1.IsActivated = activated;
                val_1.ItemInstance = itemInstance;
            }
            else
            {
                    val_1.ItemIcon = item.Sprite;
                val_1.IsActivated = activated;
                val_1.ItemInstance = itemInstance;
            }
            
            val_1.Selected = false;
            val_1.add_OnItemClicked(value:  new System.Action<TzarGames.Endless.UI.InventoryItemUI>(object:  this, method:  System.Void TzarGames.Endless.UI.InventoryBaseUI::onItemClicked(TzarGames.Endless.UI.InventoryItemUI itemUI)));
            if(itemInstance != null)
            {
                    val_7 = itemInstance.GetTemplateInstance();
            }
            else
            {
                    val_7 = item;
            }
            
            val_1.Item = val_7;
            val_8 = item.ConsumptionType;
            if(val_8 != 0)
            {
                    val_1.ShowCount = false;
            }
            else
            {
                    val_1.ShowCount = true;
                val_8;
                val_1.Count = count;
            }
            
            this.items.Add(item:  val_1);
        }
        public virtual void UpdateUI()
        {
            var val_4;
            TzarGames.Common.UI.TextUI val_17;
            var val_18;
            val_17 = this;
            if(this.PlayerOwner == null)
            {
                    return;
            }
            
            List.Enumerator<T> val_2 = this.items.GetEnumerator();
            do
            {
                label_10:
                if((0 & 1) == 0)
            {
                goto label_27;
            }
            
                System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_5 = val_4.InitializationCallback;
            }
            while(val_5.ItemInstance == null);
            
            TzarGames.GameFramework.ItemInstance val_17 = val_5.ItemInstance;
            val_17 = this._playerCharacter.TemplateInstance.IsItemActivated(item:  val_17);
            val_5.IsActivated = val_17;
            goto label_10;
            label_27:
            val_4.Dispose();
            this.goldText.text = this._playerCharacter.Gold;
            if(0 == TzarGames.Endless.EndlessGameState.Instance)
            {
                    return;
            }
            
            if(0 == this.rubyText)
            {
                    return;
            }
            
            val_17 = this.rubyText;
            TzarGames.Endless.ICharacterInfo val_15 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_18 = val_15;
            val_17.text = val_15;
        }
        private void onItemClicked(TzarGames.Endless.UI.InventoryItemUI itemUI)
        {
            this.selectItem(itemUI:  itemUI);
            goto typeof(TzarGames.Endless.UI.InventoryBaseUI).__il2cppRuntimeField_1B0;
        }
        private void selectItem(TzarGames.Endless.UI.InventoryItemUI itemUI)
        {
            TzarGames.Endless.UI.InventoryItemUI val_2 = this.<LastSelected>k__BackingField;
            if(0 != val_2)
            {
                    val_2 = this.<LastSelected>k__BackingField;
                val_2.Selected = false;
            }
            
            itemUI.Selected = true;
            this.<LastSelected>k__BackingField = itemUI;
            goto typeof(TzarGames.Endless.UI.InventoryBaseUI).__il2cppRuntimeField_1C0;
        }
        protected virtual void HandleItemClick(TzarGames.Endless.UI.InventoryItemUI itemUI)
        {
        
        }
        protected override void OnPlayerOwnerSet(TzarGames.GameFramework.Player owner)
        {
            if(0 == this._playerCharacter)
            {
                    return;
            }
            
            this._playerCharacter.TemplateInstance.Inventory.DefaultBag.remove_OnItemsChanged(value:  new System.Action<TzarGames.GameFramework.InventoryBag>(object:  this, method:  System.Void TzarGames.Endless.UI.InventoryBaseUI::DefaultBagOnOnItemsChanged(TzarGames.GameFramework.InventoryBag inventoryBag)));
            this._playerCharacter = 0;
        }
    
    }

}

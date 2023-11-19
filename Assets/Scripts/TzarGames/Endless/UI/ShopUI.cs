using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class ShopUI : GameUIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.ItemDatabaseData itemDatabase;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.ShopItemUI shopItemPrefab;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase shopWindow;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase dialogWindow;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Extensions.HorizontalScrollSnap itemScroll;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Button buyButton;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject itemRestrictButton;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI goldText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI rubyText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset requiredLevelText;
        [UnityEngine.SerializeField]
        private UnityEngine.Transform tabContainer;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Button weaponTabButton;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject shieldsTabButton;
        private int currentSelectedItem;
        private System.Collections.Generic.List<TzarGames.Endless.UI.ShopItemUI> availableItems;
        private System.Collections.Generic.List<TzarGames.Endless.UI.ShopItemUI> selectedItems;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onNotEnoughGold;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onNotEnoughRuby;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Events.ItemEvent onBuy;
        private bool initialized;
        private bool pendingShowFirstTab;
        
        // Methods
        public ShopUI()
        {
            this.currentSelectedItem = 0;
            this.availableItems = new System.Collections.Generic.List<TzarGames.Endless.UI.ShopItemUI>();
            this.pendingShowFirstTab = true;
            this.selectedItems = new System.Collections.Generic.List<TzarGames.Endless.UI.ShopItemUI>();
        }
        public override void NotifyShown()
        {
            var val_6;
            this.NotifyShown();
            if(this.pendingShowFirstTab != false)
            {
                    this.pendingShowFirstTab = false;
                this.ShowWeapons(button:  this.weaponTabButton);
            }
            
            TzarGames.GameFramework.Player val_1 = this.PlayerOwner;
            if(val_1.PlayerComponent != null)
            {
                    val_6 = null;
                val_6 = null;
                var val_2 = (((TzarGames.GameFramework.IPlayerComponent.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.PlayerCharacter.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_6) ? val_1.PlayerComponent : 0;
            }
            
            System.Type val_6 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_6 = 0.PlayerTemplateInstance.CanWearItemType(t:  val_6);
            this.shieldsTabButton.SetActive(value:  val_6);
            this.updateUI();
        }
        public void ShowWeapons(UnityEngine.UI.Button button)
        {
            this.showItemsOfType<TzarGames.GameFramework.Weapon>(selectedTab:  button, sort:  true, attributeTypes:  0);
        }
        public void ShowArmor(UnityEngine.UI.Button button)
        {
            this.showItemsOfType<TzarGames.Endless.Items.ArmorSet>(selectedTab:  button, sort:  true, attributeTypes:  0);
        }
        public void ShowShields(UnityEngine.UI.Button button)
        {
            this.showItemsOfType<TzarGames.GameFramework.Shield>(selectedTab:  button, sort:  true, attributeTypes:  0);
        }
        public void ShowOtherItems(UnityEngine.UI.Button button)
        {
            typeof(System.Type[]).__il2cppRuntimeField_20 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            this.showItemsOfType<TzarGames.GameFramework.Item>(selectedTab:  button, sort:  false, attributeTypes:  null);
        }
        public void ShowArtefacts(UnityEngine.UI.Button button)
        {
            typeof(System.Type[]).__il2cppRuntimeField_20 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            this.showItemsOfType<TzarGames.GameFramework.Item>(selectedTab:  button, sort:  false, attributeTypes:  null);
        }
        private void showItemsOfType<T>(UnityEngine.UI.Button selectedTab, bool sort, System.Type[] attributeTypes)
        {
            var val_14;
            var val_24;
            var val_39;
            var val_40;
            var val_44;
            UnityEngine.GameObject val_45;
            var val_46;
            this.currentSelectedItem = 0;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            TzarGames.GameFramework.Player val_2 = this.PlayerOwner;
            val_39 = 0;
            goto label_5;
            label_21:
            UnityEngine.Object.DontDestroyOnLoad(target:  0);
            val_39 = 1;
            label_5:
            if(val_39 >= this.availableItems.Count)
            {
                goto label_7;
            }
            
            TzarGames.Endless.UI.ShopItemUI val_5 = this.availableItems.Item[1];
            val_5.gameObject.SetActive(value:  false);
            UnityEngine.Transform val_7 = val_5.transform;
            UnityEngine.Vector3 val_8 = val_7.localScale;
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, rhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z})) != false)
            {
                    val_7.localScale = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            }
            
            val_7.SetParent(parent:  0, worldPositionStays:  false);
            UnityEngine.GameObject val_10 = val_5.gameObject;
            goto label_21;
            label_7:
            this.itemScroll.RemoveAllChildren(ChildrenRemoved: out  0);
            this.selectedItems.Clear();
            List.Enumerator<T> val_12 = this.availableItems.GetEnumerator();
            goto label_33;
            label_34:
            var val_38 = 0;
            label_30:
            if(val_38 >= attributeTypes.Length)
            {
                goto label_26;
            }
            
            val_38 = val_38 + 1;
            if((this.availableItems.Item.HasAttributeOfType(type:  attributeTypes[0])) == true)
            {
                goto label_30;
            }
            
            do
            {
                label_33:
                if((0 & 1) == 0)
            {
                goto label_95;
            }
            
                System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_17 = val_14.InitializationCallback;
            }
            while(val_17.Item == null);
            
            if(attributeTypes != null)
            {
                goto label_34;
            }
            
            label_26:
            System.Collections.Generic.List<T> val_20 = val_17.Item.GetAttributesOfType<TzarGames.Endless.Items.Attributes.PlayerClassItemAttribute>();
            if((val_20 == null) || (val_20.Count < 1))
            {
                goto label_38;
            }
            
            List.Enumerator<T> val_22 = val_20.GetEnumerator();
            val_40 = 0;
            goto label_39;
            label_43:
            val_40 = val_40 | ((val_20 == val_22.current) ? 1 : 0);
            label_39:
            if((0 & 1) == 0)
            {
                goto label_40;
            }
            
            TzarGames.Endless.PlayerClass val_27 = val_24.InitializationCallback.Class;
            TzarGames.Endless.PlayerClass val_28 = val_2.PlayerComponent.PlayerTemplateInstance.Class;
            goto label_43;
            label_40:
            var val_39 = 0;
            val_39 = val_39 + 1;
            if(428 == 428)
            {
                
            }
            else
            {
                    if(null != 0)
            {
                
            }
            
            }
            
            if((val_40 & 1) == 0)
            {
                goto label_33;
            }
            
            label_38:
            this.selectedItems.Add(item:  val_17);
            goto label_33;
            label_95:
            var val_40 = 0;
            val_40 = val_40 + 1;
            if(sort != false)
            {
                    this.selectedItems.Sort(comparison:  new System.Comparison<TzarGames.Endless.UI.ShopItemUI>(object:  0, method:  __RuntimeMethodHiddenParam + 48 + 8));
            }
            
            int val_30 = this.selectedItems.Count;
            val_44 = 0;
            goto label_69;
            label_81:
            __RuntimeMethodHiddenParam + 48 + 8.SetActive(value:  true);
            val_44 = 1;
            label_69:
            if(val_44 >= this.selectedItems.Count)
            {
                goto label_71;
            }
            
            val_45 = this.selectedItems.Item[1].gameObject;
            UnityEngine.GameObject[].__il2cppRuntimeField_gc_desc.__il2cppRuntimeField_20 = val_45;
            val_45 = UnityEngine.GameObject[].__il2cppRuntimeField_gc_desc.__il2cppRuntimeField_20;
            if(val_45.gameObject != null)
            {
                goto label_81;
            }
            
            goto label_81;
            label_71:
            this.itemScroll.AddChilds(childs:  null);
            this.itemScroll.UpdateLayout();
            val_46 = 0;
            goto label_85;
            label_94:
            this.itemScroll.interactable = true;
            val_46 = 1;
            label_85:
            if(val_46 >= val_35.Length)
            {
                goto label_87;
            }
            
            T val_41 = this.tabContainer.GetComponentsInChildren<UnityEngine.UI.Button>()[1];
            if(0 != selectedTab)
            {
                goto label_94;
            }
            
            goto label_94;
            label_87:
            this.updateUI();
        }
        public void InitializeItems()
        {
            var val_4;
            System.Collections.Generic.List<TzarGames.Endless.UI.ShopItemUI> val_5;
            if(this.initialized == true)
            {
                    return;
            }
            
            this.refreshItems();
            val_4 = 0;
            goto label_2;
            label_8:
            val_4 = 1;
            label_2:
            val_5 = this.availableItems;
            if(val_4 >= val_5.Count)
            {
                goto label_4;
            }
            
            this.availableItems.Item[1].gameObject.SetActive(value:  false);
            goto label_8;
            label_4:
            this.initialized = true;
        }
        private void refreshItems()
        {
            var val_3;
            var val_17;
            var val_18;
            List.Enumerator<T> val_1 = this.availableItems.GetEnumerator();
            label_10:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_4 = val_3.InitializationCallback;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
            val_4.transform.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            UnityEngine.GameObject val_7 = val_4.gameObject;
            TzarGames.GameFramework.GameManager.DestroyInstance(obj:  0);
            goto label_10;
            label_2:
            val_3.Dispose();
            this.availableItems.Clear();
            this.selectedItems.Clear();
            this.itemScroll.RemoveAllChildren(ChildrenRemoved: out  0);
            System.Collections.Generic.List<TzarGames.GameFramework.Item> val_9 = new System.Collections.Generic.List<TzarGames.GameFramework.Item>(collection:  1152921511004696496);
            List.Enumerator<T> val_10 = GetEnumerator();
            label_26:
            if((0 & 1) == 0)
            {
                goto label_19;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_11 = 0.InitializationCallback;
            if(val_11.AvailableOnShop == false)
            {
                goto label_26;
            }
            
            TzarGames.Endless.UI.ShopItemUI val_14 = this.createInstance(item:  val_11);
            if(0 == val_14)
            {
                goto label_26;
            }
            
            this.availableItems.Add(item:  val_14);
            goto label_26;
            label_19:
            val_17 = 0;
            val_18 = 1;
            0.Dispose();
            this.itemScroll.UpdateLayout();
            this.currentSelectedItem = 0;
            this.updateUI();
        }
        private void updateUI()
        {
            var val_17;
            int val_18;
            var val_19;
            var val_20;
            val_17 = this;
            if(this.availableItems.Count == 0)
            {
                    return;
            }
            
            val_18 = this.currentSelectedItem;
            TzarGames.Endless.UI.ShopItemUI val_2 = this.availableItems.Item[val_18];
            if(0 == TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter)
            {
                    return;
            }
            
            TzarGames.Endless.PlayerCharacter val_5 = TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter;
            this.itemRestrictButton.SetActive(value:  (~val_5.PlayerTemplateInstance.IsLevelRestrictionDisabled) & 1);
            val_18 = this.goldText;
            val_18.text = val_5.Gold;
            if(0 != TzarGames.Endless.EndlessGameState.Instance)
            {
                    TzarGames.Endless.ICharacterInfo val_13 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
                var val_17 = 0;
                val_17 = val_17 + 1;
                val_19 = val_13;
                val_18;
                this.rubyText.text = val_13;
            }
            
            List.Enumerator<T> val_15 = this.selectedItems.GetEnumerator();
            label_24:
            if((0 & 1) == 0)
            {
                goto label_23;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_16 = 0.InitializationCallback;
            val_16.updateItemExistance(itemUi:  val_16);
            goto label_24;
            label_23:
            val_17 = 0;
            val_20 = 1;
            0.Dispose();
            if((val_20 & 1) != 0)
            {
                    return;
            }
            
            if(val_17 == 0)
            {
                    return;
            }
        
        }
        private TzarGames.Endless.UI.ShopItemUI createInstance(TzarGames.GameFramework.Item item)
        {
            TzarGames.Endless.UI.SkillUpgradeUI val_1 = TzarGames.GameFramework.GameManager.MakeInstance<TzarGames.Endless.UI.SkillUpgradeUI>(obj:  0);
            val_1.UpdateData(template:  item, ownerLevel:  TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter.Level, levelInfoFormat:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
            val_1.Disabled = false;
            val_1.updateItemExistance(itemUi:  val_1);
            return (TzarGames.Endless.UI.ShopItemUI)val_1;
        }
        private void updateItemExistance(TzarGames.Endless.UI.ShopItemUI itemUi)
        {
            var val_7;
            if((TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter.TemplateInstance.Inventory.DefaultBag.GetItemCountByID(id:  itemUi.Item)) >= 1)
            {
                    val_7 = 1;
            }
            else
            {
                    val_7 = 0;
            }
            
            itemUi.ExistInInventory = false;
        }
        public void NotifyItemIndexChanged(int index)
        {
            this.currentSelectedItem = index;
            this.updateUI();
        }
        public void ShowBuyDialog()
        {
            if(this.dialogWindow == null)
            {
                
            }
        
        }
        public void ShowShop()
        {
            if(this.dialogWindow == null)
            {
                
            }
        
        }
        public void OnBuyClick()
        {
            TzarGames.Endless.UI.ShopItemUI val_1 = this.selectedItems.Item[this.currentSelectedItem];
            TzarGames.GameFramework.Item val_2 = val_1.Item;
            TzarGames.GameFramework.Item val_3 = val_1.Item;
            this.BuyItem();
        }
        public void BuyItem()
        {
            TzarGames.GameFramework.Events.ItemEvent val_8;
            TzarGames.Endless.UI.ShopItemUI val_1 = this.selectedItems.Item[this.currentSelectedItem];
            TzarGames.GameFramework.GameManager val_2 = TzarGames.GameFramework.GameManager.Instance;
            val_8 = 0;
            if(0 == )
            {
                goto label_18;
            }
            
            TzarGames.Endless.PurchaseStatus val_6 = BuyItem(item:  val_1.Item);
            if(val_6 == 0)
            {
                goto label_12;
            }
            
            if(val_6 == 2)
            {
                goto label_13;
            }
            
            if(val_6 != 3)
            {
                goto label_18;
            }
            
            this.onNotEnoughGold.Invoke();
            goto label_18;
            label_13:
            this.onNotEnoughRuby.Invoke();
            goto label_18;
            label_12:
            val_8 = this.onBuy;
            val_8.Invoke(arg0:  val_1.Item);
            label_18:
            this.updateUI();
            this.ShowShop();
        }
        [UnityEngine.ContextMenu]
        public void UnloadResources()
        {
            UnityEngine.Debug.Log(message:  0);
        }
        private static int <showItemsOfType`1>m__0<T>(TzarGames.Endless.UI.ShopItemUI x, TzarGames.Endless.UI.ShopItemUI y)
        {
            var val_6;
            var val_7;
            val_6 = __RuntimeMethodHiddenParam;
            TzarGames.GameFramework.Item val_1 = y.Item;
            TzarGames.GameFramework.Item val_2 = val_6.Item;
            if(val_1.MinimumLevel > val_2.MinimumLevel)
            {
                    val_7 = 1;
                return (int)(val_3.MinimumLevel < val_4.MinimumLevel) ? -1 : 0;
            }
            
            TzarGames.GameFramework.Item val_3 = y.Item;
            val_6 = val_6.Item;
            return (int)(val_3.MinimumLevel < val_4.MinimumLevel) ? -1 : 0;
        }
    
    }

}

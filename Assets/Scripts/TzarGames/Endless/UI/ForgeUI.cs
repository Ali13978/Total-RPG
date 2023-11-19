using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class ForgeUI : InventoryBaseUI
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject enchanceContaner;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.LayoutGroup resourceLayoutGroup;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI itemLevel;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Image enchanceIcon;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI goldCost;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI hammerCost;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI rubyCost;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Toggle rubyUsageCheckbox;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject goldContainer;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject rubyContainer;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject hammerContainer;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI nameText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI damageText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI armorText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI nextDamageText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI nextArmorText;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Button enchanceButton;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onNotEnoughGold;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onNotEnoughRuby;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Events.ItemInstanceEvent onEnchanced;
        
        // Methods
        public ForgeUI()
        {
        
        }
        public override void NotifyShown()
        {
            this.activateWidgets(activate:  false);
            this.NotifyShown();
        }
        public override void UpdateUI()
        {
            this.UpdateUI();
            this.updateEnchanceUI();
        }
        public void OnEnchanceClick()
        {
            TzarGames.GameFramework.ItemInstance val_13;
            var val_14;
            UnityEngine.Events.UnityEvent val_15;
            val_13 = 1152921504721543168;
            if(0 == 34799616)
            {
                    return;
            }
            
            if(0 == TzarGames.GameFramework.GameManager.Instance)
            {
                    return;
            }
            
            val_14 = 0;
            if(TzarGames.GameFramework.GameManager.Instance != null)
            {
                    val_14 = 0;
            }
            
            val_13 = ItemInstance;
            TzarGames.Endless.PurchaseStatus val_11 = EnchanceItem(item:  val_13, useRubyDiscount:  this.rubyUsageCheckbox.isOn);
            this.RefreshItems();
            if(val_11 == 0)
            {
                goto label_17;
            }
            
            if(val_11 == 2)
            {
                goto label_18;
            }
            
            if(val_11 != 3)
            {
                    return;
            }
            
            val_15 = this.onNotEnoughGold;
            if(val_15 != null)
            {
                goto label_24;
            }
            
            goto label_21;
            label_17:
            this.onEnchanced.Invoke(arg0:  this.ItemInstance);
            return;
            label_18:
            val_15 = this.onNotEnoughRuby;
            if(val_15 != null)
            {
                goto label_24;
            }
            
            label_21:
            label_24:
            val_15.Invoke();
        }
        protected override void HandleItemClick(TzarGames.Endless.UI.InventoryItemUI itemUI)
        {
            goto typeof(TzarGames.Endless.UI.ForgeUI).__il2cppRuntimeField_1B0;
        }
        private void activateWidgets(bool activate)
        {
            this.enchanceIcon.gameObject.SetActive(value:  activate);
            this.goldCost.gameObject.SetActive(value:  activate);
            this.enchanceButton.gameObject.SetActive(value:  activate);
            this.damageText.gameObject.SetActive(value:  activate);
            bool val_10 = activate;
            this.armorText.gameObject.SetActive(value:  val_10);
            this.enchanceContaner.SetActive(value:  val_10);
            bool val_11 = activate;
            this.goldContainer.SetActive(value:  val_11);
            this.hammerContainer.SetActive(value:  val_11);
            this.rubyContainer.SetActive(value:  activate);
            this.rubyUsageCheckbox.gameObject.SetActive(value:  activate);
            this.itemLevel.gameObject.SetActive(value:  activate);
        }
        private void updateEnchanceUI()
        {
            var val_38;
            object val_39;
            var val_40;
            TzarGames.Common.UI.TextUI val_41;
            TzarGames.Common.UI.TextUI val_43;
            var val_44;
            int val_45;
            if((0 == 34799616) || (ItemInstance == null))
            {
                goto label_10;
            }
            
            TzarGames.GameFramework.Item val_5 = ItemInstance.GetTemplateInstance();
            if((TzarGames.Endless.ItemEnchancement.IsItemCanBeEnchanced(item:  0)) == false)
            {
                goto label_10;
            }
            
            this.activateWidgets(activate:  true);
            this.itemLevel.text = val_5.Level.ToString();
            this.nameText.text = val_5;
            val_38 = 1152921504910733312;
            val_39 = 0;
            goto label_18;
            label_10:
            this.activateWidgets(activate:  false);
            return;
            label_18:
            this.damageText.gameObject.SetActive(value:  false);
            this.nextDamageText.gameObject.SetActive(value:  false);
            this.armorText.gameObject.SetActive(value:  true);
            this.nextArmorText.gameObject.SetActive(value:  true);
            if(val_5 != null)
            {
                    val_40 = null;
                val_40 = null;
                var val_15 = (((TzarGames.GameFramework.Item.__il2cppRuntimeField_typeHierarchy + (TzarGames.GameFramework.Armor.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_40) ? (val_5) : 0;
            }
            
            float val_17 = 0.Defence;
            val_38 = 1152921504608444416;
            val_39 = "{0:0.0}";
            this.armorText.text = System.String.Format(format:  0, arg0:  "{0:0.0}");
            val_41 = this.nextArmorText;
            float val_19 = TzarGames.Endless.ItemEnchancement.GetArmorDefenceForNextLevel(instance:  0);
            text = System.String.Format(format:  0, arg0:  null);
            this.enchanceIcon.sprite = ItemIcon;
            TzarGames.GameFramework.ItemInstance val_30 = this.enchanceIcon.ItemInstance;
            this.goldContainer.SetActive(value:  true);
            val_43 = this.goldCost;
            val_43.text = System.String.Format(format:  0, arg0:  "{0}");
            if((TzarGames.Endless.ItemEnchancement.GetCostForEnchancement(itemInstance:  0).OnlyGoldRequired()) != false)
            {
                    this.rubyUsageCheckbox.gameObject.SetActive(value:  false);
                this.rubyContainer.gameObject.SetActive(value:  false);
                this.hammerContainer.SetActive(value:  false);
            }
            else
            {
                    if(val_31.RubyCostForHammerDiscount >= 1)
            {
                    val_44 = 1;
            }
            else
            {
                    val_44 = 0;
            }
            
                this.rubyUsageCheckbox.gameObject.SetActive(value:  false);
                val_38 = this.rubyUsageCheckbox.isOn;
                if(val_38 != false)
            {
                    this.rubyContainer.SetActive(value:  true);
                this.hammerContainer.SetActive(value:  true);
                this.rubyCost.text = val_31 + 24;
                val_43 = this.hammerCost;
                val_45 = val_31.HammerCountWithDiscount;
            }
            else
            {
                    this.rubyContainer.SetActive(value:  false);
                this.hammerContainer.SetActive(value:  true);
                val_43 = this.hammerCost;
                val_45 = val_31.HammerCount;
            }
            
                val_43.text = val_45;
            }
            
            if(this.resourceLayoutGroup != null)
            {
                    return;
            }
        
        }
    
    }

}

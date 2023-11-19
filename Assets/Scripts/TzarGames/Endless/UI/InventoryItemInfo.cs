using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class InventoryItemInfo : MonoBehaviour, IPoolable
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Image iconImage;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI itemNameText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI itemDescriptionText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI sellCost;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI costText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI rubyCostText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI levelText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI damageText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI damageModificatorText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI defenceText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI defenceModificatorText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI attackSpeedText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI speedText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI hpRegen;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI hpBoost;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI critChance;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI critMultiplier;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI shieldBlockChance;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset defaultLevelFormat;
        private TzarGames.GameFramework.Item _item;
        private UnityEngine.Coroutine itemAnimationCoroutine;
        
        // Properties
        public TzarGames.GameFramework.Item Item { get; set; }
        public string Cost { get; set; }
        public string RubyCost { get; set; }
        public string RequiredLevel { get; set; }
        public string Damage { get; set; }
        public string DamageModificator { get; set; }
        public string Defence { get; set; }
        public string DefenceModificator { get; set; }
        public string AttackSpeed { get; set; }
        public string Speed { get; set; }
        public string HpRegen { get; set; }
        public string HpBoost { get; set; }
        public string CritChance { get; set; }
        public string CritMultiplier { get; set; }
        public string ShieldBlockChance { get; set; }
        public string ItemName { get; set; }
        public UnityEngine.Sprite ItemIcon { get; set; }
        public string ItemDescription { get; set; }
        
        // Methods
        public InventoryItemInfo()
        {
        
        }
        public TzarGames.GameFramework.Item get_Item()
        {
            return (TzarGames.GameFramework.Item)this._item;
        }
        public void set_Item(TzarGames.GameFramework.Item value)
        {
            if(0 == this._item)
            {
                    return;
            }
            
            this._item = value;
            this.updateSpriteAnimationState();
        }
        private void updateSpriteAnimationState()
        {
            if(0 != this._item)
            {
                    if(this.itemAnimationCoroutine != null)
            {
                    this.StopCoroutine(routine:  this.itemAnimationCoroutine);
                this.itemAnimationCoroutine = 0;
            }
            
                TzarGames.GameFramework.AnimatedIconItemComponent val_2 = this._item.GetComponent<TzarGames.GameFramework.AnimatedIconItemComponent>();
                if(0 == val_2)
            {
                    return;
            }
            
                this.itemAnimationCoroutine = this.StartCoroutine(routine:  this.itemAnimation(item:  val_2, animComponent:  val_2));
                return;
            }
            
            if(this.itemAnimationCoroutine == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.itemAnimationCoroutine);
        }
        private void OnEnable()
        {
            this.updateSpriteAnimationState();
        }
        private void OnDisable()
        {
            if(this.itemAnimationCoroutine == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.itemAnimationCoroutine);
            this.itemAnimationCoroutine = 0;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator itemAnimation(TzarGames.GameFramework.Item item, TzarGames.GameFramework.AnimatedIconItemComponent animComponent)
        {
            if(null != 0)
            {
                    typeof(InventoryItemInfo.<itemAnimation>c__Iterator0).__il2cppRuntimeField_10 = animComponent;
            }
            else
            {
                    mem[16] = animComponent;
            }
            
            typeof(InventoryItemInfo.<itemAnimation>c__Iterator0).__il2cppRuntimeField_28 = this;
            return (System.Collections.IEnumerator)new InventoryItemInfo.<itemAnimation>c__Iterator0();
        }
        public string get_Cost()
        {
            if(0 == this.costText)
            {
                    return 0;
            }
            
            if(this.costText != null)
            {
                    return this.costText.text;
            }
            
            return this.costText.text;
        }
        public void set_Cost(string value)
        {
            if(0 == this.costText)
            {
                    return;
            }
            
            this.costText.text = value;
        }
        public string get_RubyCost()
        {
            if(0 == this.rubyCostText)
            {
                    return 0;
            }
            
            if(this.rubyCostText != null)
            {
                    return this.rubyCostText.text;
            }
            
            return this.rubyCostText.text;
        }
        public void set_RubyCost(string value)
        {
            if(0 == this.rubyCostText)
            {
                    return;
            }
            
            this.rubyCostText.text = value;
        }
        public string get_RequiredLevel()
        {
            if(0 == this.levelText)
            {
                    return 0;
            }
            
            if(this.levelText != null)
            {
                    return this.levelText.text;
            }
            
            return this.levelText.text;
        }
        public void set_RequiredLevel(string value)
        {
            if(0 == this.levelText)
            {
                    return;
            }
            
            this.levelText.text = value;
        }
        public string get_Damage()
        {
            if(0 == this.damageText)
            {
                    return 0;
            }
            
            if(this.damageText != null)
            {
                    return this.damageText.text;
            }
            
            return this.damageText.text;
        }
        public void set_Damage(string value)
        {
            if(0 == this.damageText)
            {
                    return;
            }
            
            this.damageText.text = value;
        }
        public string get_DamageModificator()
        {
            if(0 == this.damageModificatorText)
            {
                    return 0;
            }
            
            if(this.damageModificatorText != null)
            {
                    return this.damageModificatorText.text;
            }
            
            return this.damageModificatorText.text;
        }
        public void set_DamageModificator(string value)
        {
            if(0 == this.damageModificatorText)
            {
                    return;
            }
            
            this.damageModificatorText.text = value;
        }
        public string get_Defence()
        {
            if(0 == this.defenceText)
            {
                    return 0;
            }
            
            if(this.defenceText != null)
            {
                    return this.defenceText.text;
            }
            
            return this.defenceText.text;
        }
        public void set_Defence(string value)
        {
            if(0 == this.defenceText)
            {
                    return;
            }
            
            this.defenceText.text = value;
        }
        public string get_DefenceModificator()
        {
            if(0 == this.defenceModificatorText)
            {
                    return 0;
            }
            
            if(this.defenceModificatorText != null)
            {
                    return this.defenceModificatorText.text;
            }
            
            return this.defenceModificatorText.text;
        }
        public void set_DefenceModificator(string value)
        {
            if(0 == this.defenceModificatorText)
            {
                    return;
            }
            
            this.defenceModificatorText.text = value;
        }
        public string get_AttackSpeed()
        {
            if(0 == this.attackSpeedText)
            {
                    return 0;
            }
            
            if(this.attackSpeedText != null)
            {
                    return this.attackSpeedText.text;
            }
            
            return this.attackSpeedText.text;
        }
        public void set_AttackSpeed(string value)
        {
            if(0 == this.attackSpeedText)
            {
                    return;
            }
            
            this.attackSpeedText.text = value;
        }
        public string get_Speed()
        {
            if(0 == this.speedText)
            {
                    return 0;
            }
            
            if(this.speedText != null)
            {
                    return this.speedText.text;
            }
            
            return this.speedText.text;
        }
        public void set_Speed(string value)
        {
            if(0 == this.speedText)
            {
                    return;
            }
            
            this.speedText.text = value;
        }
        public string get_HpRegen()
        {
            if(0 == this.hpRegen)
            {
                    return 0;
            }
            
            if(this.hpRegen != null)
            {
                    return this.hpRegen.text;
            }
            
            return this.hpRegen.text;
        }
        public void set_HpRegen(string value)
        {
            if(0 == this.hpRegen)
            {
                    return;
            }
            
            this.hpRegen.text = value;
        }
        public string get_HpBoost()
        {
            if(0 == this.hpBoost)
            {
                    return 0;
            }
            
            if(this.hpBoost != null)
            {
                    return this.hpBoost.text;
            }
            
            return this.hpBoost.text;
        }
        public void set_HpBoost(string value)
        {
            if(0 == this.hpBoost)
            {
                    return;
            }
            
            this.hpBoost.text = value;
        }
        public string get_CritChance()
        {
            if(0 == this.critChance)
            {
                    return 0;
            }
            
            if(this.critChance != null)
            {
                    return this.critChance.text;
            }
            
            return this.critChance.text;
        }
        public void set_CritChance(string value)
        {
            if(0 == this.critChance)
            {
                    return;
            }
            
            this.critChance.text = value;
        }
        public string get_CritMultiplier()
        {
            if(0 == this.critMultiplier)
            {
                    return 0;
            }
            
            if(this.critMultiplier != null)
            {
                    return this.critMultiplier.text;
            }
            
            return this.critMultiplier.text;
        }
        public void set_CritMultiplier(string value)
        {
            if(0 == this.critMultiplier)
            {
                    return;
            }
            
            this.critMultiplier.text = value;
        }
        public string get_ShieldBlockChance()
        {
            if(0 == this.shieldBlockChance)
            {
                    return 0;
            }
            
            if(this.shieldBlockChance != null)
            {
                    return this.shieldBlockChance.text;
            }
            
            return this.shieldBlockChance.text;
        }
        public void set_ShieldBlockChance(string value)
        {
            if(0 == this.shieldBlockChance)
            {
                    return;
            }
            
            this.shieldBlockChance.text = value;
        }
        public string get_ItemName()
        {
            if(0 == this.itemNameText)
            {
                    return 0;
            }
            
            if(this.itemNameText != null)
            {
                    return this.itemNameText.text;
            }
            
            return this.itemNameText.text;
        }
        public void set_ItemName(string value)
        {
            if(0 == this.itemNameText)
            {
                    return;
            }
            
            this.itemNameText.text = value;
        }
        public UnityEngine.Sprite get_ItemIcon()
        {
            if(0 == this.iconImage)
            {
                    return 0;
            }
            
            if(this.iconImage != null)
            {
                    return this.iconImage.sprite;
            }
            
            return this.iconImage.sprite;
        }
        public void set_ItemIcon(UnityEngine.Sprite value)
        {
            if(0 == this.iconImage)
            {
                    return;
            }
            
            this.iconImage.sprite = value;
        }
        public string get_ItemDescription()
        {
            if(0 == this.itemDescriptionText)
            {
                    return 0;
            }
            
            if(this.itemDescriptionText != null)
            {
                    return this.itemDescriptionText.text;
            }
            
            return this.itemDescriptionText.text;
        }
        public void set_ItemDescription(string value)
        {
            var val_6;
            var val_7;
            if(0 == this.itemDescriptionText)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    val_6 = this.itemDescriptionText.gameObject;
                val_7 = 0;
            }
            else
            {
                    this.itemDescriptionText.text = value;
                val_6 = this.itemDescriptionText.gameObject;
                val_7 = 1;
            }
            
            val_6.SetActive(value:  true);
        }
        public void ShowGoldCost(bool show)
        {
            if(0 == this.costText)
            {
                    return;
            }
            
            this.costText.gameObject.SetActive(value:  show);
        }
        public void ShowRubyCost(bool show)
        {
            if(0 == this.rubyCostText)
            {
                    return;
            }
            
            this.rubyCostText.gameObject.SetActive(value:  show);
        }
        public void ShowRequiredLevel(bool show)
        {
            if(0 == this.levelText)
            {
                    return;
            }
            
            this.levelText.gameObject.SetActive(value:  show);
        }
        public void ShowDamage(bool show)
        {
            if(0 == this.damageText)
            {
                    return;
            }
            
            this.damageText.gameObject.SetActive(value:  show);
        }
        public void ShowDamageModificator(bool show)
        {
            if(0 == this.damageModificatorText)
            {
                    return;
            }
            
            this.damageModificatorText.gameObject.SetActive(value:  show);
        }
        public void ShowDefence(bool show)
        {
            if(0 == this.defenceText)
            {
                    return;
            }
            
            this.defenceText.gameObject.SetActive(value:  show);
        }
        public void ShowDefenceModificator(bool show)
        {
            if(0 == this.defenceModificatorText)
            {
                    return;
            }
            
            this.defenceModificatorText.gameObject.SetActive(value:  show);
        }
        public void ShowAttackSpeed(bool show)
        {
            if(0 == this.attackSpeedText)
            {
                    return;
            }
            
            this.attackSpeedText.gameObject.SetActive(value:  show);
        }
        public void ShowSpeed(bool show)
        {
            if(0 == this.speedText)
            {
                    return;
            }
            
            this.speedText.gameObject.SetActive(value:  show);
        }
        public void ShowHpRegen(bool show)
        {
            if(0 == this.hpRegen)
            {
                    return;
            }
            
            this.hpRegen.gameObject.SetActive(value:  show);
        }
        public void ShowHpBoost(bool show)
        {
            if(0 == this.hpBoost)
            {
                    return;
            }
            
            this.hpBoost.gameObject.SetActive(value:  show);
        }
        public void ShowCritChance(bool show)
        {
            if(0 == this.critChance)
            {
                    return;
            }
            
            this.critChance.gameObject.SetActive(value:  show);
        }
        public void ShowCritMultiplier(bool show)
        {
            if(0 == this.critMultiplier)
            {
                    return;
            }
            
            this.critMultiplier.gameObject.SetActive(value:  show);
        }
        public void ShowShieldBlockChance(bool show)
        {
            if(0 == this.shieldBlockChance)
            {
                    return;
            }
            
            this.shieldBlockChance.gameObject.SetActive(value:  show);
        }
        public void UpdateData(TzarGames.GameFramework.Item template, uint ownerLevel)
        {
            this.UpdateData(template:  template, ownerLevel:  ownerLevel, levelInfoFormat:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
        }
        public void UpdateData(TzarGames.GameFramework.Item template, uint ownerLevel, string levelInfoFormat)
        {
            UnityEngine.Sprite val_43;
            float val_44;
            var val_45;
            string val_46;
            var val_47;
            var val_48;
            var val_49;
            var val_50;
            TzarGames.GameFramework.CharacteristicModificator val_51;
            this.Item = template;
            if(template != null)
            {
                    val_43 = template.Sprite;
                this.ItemIcon = val_43;
            }
            else
            {
                    val_43 = 1;
                this.ItemIcon = val_43;
            }
            
            this.ItemName = template;
            if(template != null)
            {
                    this.ItemDescription = template;
            }
            else
            {
                    this.ItemDescription = template;
            }
            
            if(template.Cost > 0f)
            {
                    this.ShowGoldCost(show:  true);
                this.Cost = System.String.Format(format:  0, arg0:  "{0:N0}");
            }
            else
            {
                    this.ShowGoldCost(show:  false);
            }
            
            val_44 = template.PremiumCost;
            if(val_44 > 0f)
            {
                    this.ShowRubyCost(show:  true);
                this.RubyCost = System.String.Format(format:  0, arg0:  "{0:N0}");
            }
            else
            {
                    this.ShowRubyCost(show:  false);
            }
            
            val_45 = 0;
            this.ShowDefence(show:  true);
            if(template.AdditionalModificators.DefenceModificators.Count >= 1)
            {
                    this.ShowDefenceModificator(show:  true);
                TzarGames.GameFramework.CharacteristicModificator val_7 = template.AdditionalModificators.DefenceModificators.Item[0];
                this.DefenceModificator = val_7.getModificatorText(modificator:  val_7, options:  0);
            }
            else
            {
                    this.ShowDefenceModificator(show:  false);
            }
            
            val_46 = template;
            if(val_46 == null)
            {
                goto label_36;
            }
            
            var val_43 = 0;
            val_43 = val_43 + 1;
            val_47 = val_46;
            val_44 = 0.0001f;
            if(System.Math.Abs(Defence) <= val_44)
            {
                goto label_36;
            }
            
            var val_45 = 0;
            val_45 = val_45 + 1;
            val_48 = val_46;
            goto label_40;
            label_36:
            val_49 = 0;
            goto label_41;
            label_40:
            var val_46 = 0;
            val_46 = val_46 + 1;
            val_50 = val_46;
            int val_13 = TzarGames.Endless.EndlessUtils.GetIntPercent(floatPercent:  val_44);
            val_46 = System.String.Format(format:  0, arg0:  (val_44 > 0f) ? "+{0:0}%" : "{0:0}%");
            this.ShieldBlockChance = val_46;
            val_49 = 1;
            label_41:
            this.ShowShieldBlockChance(show:  true);
            if(template.MinimumLevel > ownerLevel)
            {
                    this.ShowRequiredLevel(show:  true);
                this.RequiredLevel = System.String.Format(format:  0, arg0:  levelInfoFormat);
            }
            else
            {
                    this.ShowRequiredLevel(show:  false);
            }
            
            this.ShowDamage(show:  false);
            val_51 = 0;
            if(template.AdditionalModificators.DamageModificators.Count >= 1)
            {
                    this.ShowDamageModificator(show:  true);
                TzarGames.GameFramework.CharacteristicModificator val_17 = template.AdditionalModificators.DamageModificators.Item[0];
                this.DamageModificator = val_17.getModificatorText(modificator:  val_17, options:  0);
            }
            else
            {
                    this.ShowDamageModificator(show:  false);
            }
            
            if(val_51 != 0)
            {
                goto label_64;
            }
            
            if(template.AdditionalModificators.AttackSpeedModificators.Count < 1)
            {
                goto label_72;
            }
            
            val_51 = template.AdditionalModificators.AttackSpeedModificators.Item[0];
            if(val_51 == null)
            {
                goto label_72;
            }
            
            label_64:
            this.ShowAttackSpeed(show:  true);
            this.AttackSpeed = this.getModificatorText(modificator:  val_51, options:  0);
            goto label_73;
            label_72:
            this.ShowAttackSpeed(show:  false);
            label_73:
            if(template.AdditionalModificators.WalkingSpeedModificators.Count >= 1)
            {
                    this.ShowSpeed(show:  true);
                TzarGames.GameFramework.CharacteristicModificator val_23 = template.AdditionalModificators.WalkingSpeedModificators.Item[0];
                this.Speed = val_23.getModificatorText(modificator:  val_23, options:  0);
            }
            else
            {
                    this.ShowSpeed(show:  false);
            }
            
            if(template.AdditionalModificators.HitPointsRegenModificators.Count >= 1)
            {
                    this.ShowHpRegen(show:  true);
                TzarGames.GameFramework.CharacteristicModificator val_26 = template.AdditionalModificators.HitPointsRegenModificators.Item[0];
                this.HpRegen = val_26.getModificatorText(modificator:  val_26, options:  0);
            }
            else
            {
                    this.ShowHpRegen(show:  false);
            }
            
            if(template.AdditionalModificators.HitPointsModificators.Count >= 1)
            {
                    this.ShowHpBoost(show:  true);
                TzarGames.GameFramework.CharacteristicModificator val_29 = template.AdditionalModificators.HitPointsModificators.Item[0];
                this.HpBoost = val_29.getModificatorText(modificator:  val_29, options:  0);
            }
            else
            {
                    this.ShowHpBoost(show:  false);
            }
            
            if(template.AdditionalModificators.CritChanceModificators.Count >= 1)
            {
                    this.ShowCritChance(show:  true);
                TzarGames.GameFramework.CharacteristicModificator val_32 = template.AdditionalModificators.CritChanceModificators.Item[0];
                this.CritChance = val_32.getModificatorText(modificator:  val_32, options:  1);
            }
            else
            {
                    this.ShowCritChance(show:  false);
            }
            
            if(template.AdditionalModificators.CritMultipliierModificators.Count >= 1)
            {
                    this.ShowCritMultiplier(show:  true);
                TzarGames.GameFramework.CharacteristicModificator val_35 = template.AdditionalModificators.CritMultipliierModificators.Item[0];
                this.CritMultiplier = val_35.getModificatorText(modificator:  val_35, options:  2);
                return;
            }
            
            this.ShowCritMultiplier(show:  false);
        }
        private string getModificatorText(TzarGames.GameFramework.CharacteristicModificator modificator, TzarGames.Endless.UI.ModificatorDisplayOptions options = 0)
        {
            var val_11;
            var val_12;
            float val_13;
            var val_14;
            string val_15;
            var val_16;
            val_11 = options;
            if(modificator != null)
            {
                    val_12 = modificator;
                val_13 = val_12.Value;
            }
            else
            {
                    val_12 = 0;
                val_13 = val_12.Value;
            }
            
            if(modificator.Operator > 3)
            {
                goto label_5;
            }
            
            if((25486464 + (modificator.Operator) << 2) == 5)
            {
                goto label_6;
            }
            
            if((25486464 + (modificator.Operator) << 2) == 6)
            {
                goto label_7;
            }
            
            if((25486464 + (modificator.Operator) << 2) != 0)
            {
                    return (string)System.String.Format(format:  0, arg0:  val_15 = (val_8 < 1) ? "{0}%" : "+{0}%");
            }
            
            label_5:
            System.ArgumentOutOfRangeException val_3 = null;
            val_14 = val_3;
            val_3 = new System.ArgumentOutOfRangeException();
            label_6:
            val_15 = mem[val_4 > 0 ? "+{0:0.0}" : "{0:0.0}"];
            val_15 = (modificator.Value > 0f) ? "+{0:0.0}" : "{0:0.0}";
            if(val_14 != 1)
            {
                goto label_14;
            }
            
            val_15 = 0 + val_15;
            goto label_14;
            label_7:
            if(val_11 == 2)
            {
                    val_15 = "x{0}";
            }
            else
            {
                    int val_8 = TzarGames.Endless.EndlessUtils.FloatToPercent(val:  modificator.Value);
                val_13 = (float)val_8;
                val_15 = mem[val_8 < 1 ? "{0}%" : "+{0}%"];
            }
            
            label_14:
            val_16 = val_13;
            return (string)System.String.Format(format:  0, arg0:  val_15);
        }
        public void OnPushedToPool()
        {
            this.iconImage.sprite = 0;
            TzarGames.Endless.UI.InventoryItemInfo.enableTexts(itemInfo:  this.iconImage, on:  true);
        }
        public void OnPulledFromPool()
        {
            TzarGames.Endless.UI.InventoryItemInfo.enableTexts(itemInfo:  this, on:  false);
        }
        private static void enableTexts(TzarGames.Endless.UI.InventoryItemInfo itemInfo, bool on)
        {
            var val_4;
            if(on != false)
            {
                    val_4 = W2 & 1;
                TzarGames.Endless.UI.InventoryItemInfo.enableText(t:  itemInfo, on:  on + 32);
                TzarGames.Endless.UI.InventoryItemInfo.enableText(t:  itemInfo, on:  on + 40);
                TzarGames.Endless.UI.InventoryItemInfo.enableText(t:  itemInfo, on:  on + 48);
                TzarGames.Endless.UI.InventoryItemInfo.enableText(t:  itemInfo, on:  on + 56);
                TzarGames.Endless.UI.InventoryItemInfo.enableText(t:  itemInfo, on:  on + 64);
                TzarGames.Endless.UI.InventoryItemInfo.enableText(t:  itemInfo, on:  on + 72);
                TzarGames.Endless.UI.InventoryItemInfo.enableText(t:  itemInfo, on:  on + 80);
                TzarGames.Endless.UI.InventoryItemInfo.enableText(t:  itemInfo, on:  on + 96);
                TzarGames.Endless.UI.InventoryItemInfo.enableText(t:  itemInfo, on:  on + 112);
                TzarGames.Endless.UI.InventoryItemInfo.enableText(t:  itemInfo, on:  on + 120);
                TzarGames.Endless.UI.InventoryItemInfo.enableText(t:  itemInfo, on:  on + 128);
                TzarGames.Endless.UI.InventoryItemInfo.enableText(t:  itemInfo, on:  on + 136);
                TzarGames.Endless.UI.InventoryItemInfo.enableText(t:  itemInfo, on:  on + 144);
                TzarGames.Endless.UI.InventoryItemInfo.enableText(t:  itemInfo, on:  on + 152);
            }
            else
            {
                    val_4 = W2 & 1;
                TzarGames.Endless.UI.InventoryItemInfo.enableText(t:  itemInfo, on:  true);
                TzarGames.Endless.UI.InventoryItemInfo.enableText(t:  itemInfo, on:  true);
                TzarGames.Endless.UI.InventoryItemInfo.enableText(t:  itemInfo, on:  false);
                TzarGames.Endless.UI.InventoryItemInfo.enableText(t:  itemInfo, on:  true);
                TzarGames.Endless.UI.InventoryItemInfo.enableText(t:  itemInfo, on:  true);
                TzarGames.Endless.UI.InventoryItemInfo.enableText(t:  itemInfo, on:  false);
                TzarGames.Endless.UI.InventoryItemInfo.enableText(t:  itemInfo, on:  false);
                TzarGames.Endless.UI.InventoryItemInfo.enableText(t:  itemInfo, on:  true);
                TzarGames.Endless.UI.InventoryItemInfo.enableText(t:  itemInfo, on:  false);
                TzarGames.Endless.UI.InventoryItemInfo.enableText(t:  itemInfo, on:  true);
                TzarGames.Endless.UI.InventoryItemInfo.enableText(t:  itemInfo, on:  false);
                TzarGames.Endless.UI.InventoryItemInfo.enableText(t:  itemInfo, on:  false);
                TzarGames.Endless.UI.InventoryItemInfo.enableText(t:  itemInfo, on:  false);
                TzarGames.Endless.UI.InventoryItemInfo.enableText(t:  itemInfo, on:  true);
            }
            
            var val_1 = W2 & 1;
            TzarGames.Endless.UI.InventoryItemInfo.enableText(t:  itemInfo, on:  on + 160);
        }
        private static void enableText(TzarGames.Common.UI.TextUI t, bool on)
        {
            if(0 == on)
            {
                    return;
            }
            
            on.enabled = W2 & 1;
        }
    
    }

}

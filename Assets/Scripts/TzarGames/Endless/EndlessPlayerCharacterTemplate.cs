using UnityEngine;

namespace TzarGames.Endless
{
    public class EndlessPlayerCharacterTemplate : TH_CharacterTemplate
    {
        // Fields
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private TzarGames.Endless.Items.ArmorSet defaultArmorSet;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Weapon defaultWeapon;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Characteristic blockChance;
        [UnityEngine.SerializeField]
        private float blockChanceCoefficient;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Characteristic influenceResistance;
        [UnityEngine.SerializeField]
        private float influenceResistanceCoefficent;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Characteristic critResistance;
        [UnityEngine.SerializeField]
        private float critResistanceCoefficent;
        [UnityEngine.SerializeField]
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat healingPotionUsageInterval;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredULong gold;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredBool isLevelRestrictionDisabled;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.GameFramework.ItemInstance <ActiveWeaponInstance>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.GameFramework.ItemInstance <ActiveSecondWeaponInstance>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.GameFramework.ItemInstance <ShieldInstance>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.GameFramework.ItemInstance <ArmorSetItemInstance>k__BackingField;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat skillCooldownCoefficient;
        [UnityEngine.SerializeField]
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat skillCommonCoefficient;
        [UnityEngine.SerializeField]
        private UnityEngine.RuntimeAnimatorController animatorController;
        public const int MAXIMUM_CHARACTERISTIC_UPGRADE_LEVEL = 10;
        public const int MAX_SKILL_UPGRADE_LEVEL = 10;
        public const string MASKS_BAG_NAME = "MASKS_BAG";
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.Endless.PlayerClass <Class>k__BackingField;
        private System.Collections.Generic.List<TzarGames.Endless.EndlessPlayerCharacterTemplate.SkillUpgrade> skillUpgrades;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private TzarGames.Endless.EndlessPlayerCharacterTemplate.CharacteristicUpgrage damageUpgrade;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.EndlessPlayerCharacterTemplate.CharacteristicUpgrage defenceUpgrade;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.EndlessPlayerCharacterTemplate.CharacteristicUpgrage attackSpeedUpgrade;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.EndlessPlayerCharacterTemplate.CharacteristicUpgrage speedUpgrade;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.EndlessPlayerCharacterTemplate.CharacteristicUpgrage hpUpgrade;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.EndlessPlayerCharacterTemplate.CharacteristicUpgrage hpRegenUpgrade;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.EndlessPlayerCharacterTemplate.CharacteristicUpgrage critMultiplierUpgrade;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.EndlessPlayerCharacterTemplate.CharacteristicUpgrage critChanceUpgrade;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.EndlessPlayerCharacterTemplate.CharacteristicUpgrage blockChanceUpgrade;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.EndlessPlayerCharacterTemplate.CharacteristicUpgrage influenceResistanceUpgrade;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.EndlessPlayerCharacterTemplate.CharacteristicUpgrage critResistanceUpgrade;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private long <ConsumedLevelUpgradePoints>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private int <AdditionalUpgradePoints>k__BackingField;
        
        // Properties
        public TzarGames.GameFramework.ItemInstance ActiveWeaponInstance { get; set; }
        public TzarGames.GameFramework.ItemInstance ActiveSecondWeaponInstance { get; set; }
        public TzarGames.GameFramework.ItemInstance ShieldInstance { get; set; }
        public TzarGames.GameFramework.ItemInstance ArmorSetItemInstance { get; set; }
        public TzarGames.Endless.PlayerClass Class { get; set; }
        public TzarGames.Endless.Items.ArmorSet DefaultArmorSet { get; }
        public TzarGames.GameFramework.Weapon DefaultWeapon { get; }
        public UnityEngine.RuntimeAnimatorController AnimatorController { get; }
        public TzarGames.Endless.EndlessPlayerCharacterTemplate.ICharacteristicUpgrade DamageUpgrade { get; }
        public TzarGames.Endless.EndlessPlayerCharacterTemplate.ICharacteristicUpgrade DefenceUpgrade { get; }
        public TzarGames.Endless.EndlessPlayerCharacterTemplate.ICharacteristicUpgrade AttackSpeedUpgrade { get; }
        public TzarGames.Endless.EndlessPlayerCharacterTemplate.ICharacteristicUpgrade SpeedUpgrade { get; }
        public TzarGames.Endless.EndlessPlayerCharacterTemplate.ICharacteristicUpgrade HitPointsUpgrade { get; }
        public TzarGames.Endless.EndlessPlayerCharacterTemplate.ICharacteristicUpgrade HitPointsRegenUpgrade { get; }
        public TzarGames.Endless.EndlessPlayerCharacterTemplate.ICharacteristicUpgrade CritMultiplierUpgrade { get; }
        public TzarGames.Endless.EndlessPlayerCharacterTemplate.ICharacteristicUpgrade CritChanceUpgrade { get; }
        public TzarGames.Endless.EndlessPlayerCharacterTemplate.ICharacteristicUpgrade BlockChanceUpgrade { get; }
        public TzarGames.Endless.EndlessPlayerCharacterTemplate.ICharacteristicUpgrade InfluenceResistanceUpgrade { get; }
        public TzarGames.Endless.EndlessPlayerCharacterTemplate.ICharacteristicUpgrade CritResistanceUpgrade { get; }
        public long ConsumedLevelUpgradePoints { get; set; }
        public int AdditionalUpgradePoints { get; set; }
        public long AvailableUpgradePoints { get; }
        public float BlockChance { get; }
        public TzarGames.GameFramework.Characteristic BlockChanceCharacteristic { get; }
        public TzarGames.GameFramework.Characteristic InfluenceResistanceCharacteristic { get; }
        public float InfluenceResistance { get; }
        public TzarGames.GameFramework.Characteristic CritResistanceCharacteristic { get; }
        public float CritResistance { get; }
        public bool IsLevelRestrictionDisabled { get; set; }
        public ulong Gold { get; set; }
        public float HealingPotionUsageInterval { get; }
        
        // Methods
        public EndlessPlayerCharacterTemplate()
        {
            var val_5;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_6;
            var val_8;
            var val_9;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredULong val_10;
            var val_13;
            var val_14;
            var val_16;
            var val_17;
            this.blockChance = new TzarGames.GameFramework.Characteristic(baseValue:  0f);
            this.influenceResistance = new TzarGames.GameFramework.Characteristic(baseValue:  0f);
            this.critResistance = new TzarGames.GameFramework.Characteristic(baseValue:  0f);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  3f);
            mem[1152921510639483072] = val_5;
            this.healingPotionUsageInterval = val_6;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredULong val_7 = CodeStage.AntiCheat.ObscuredTypes.ObscuredULong.op_Implicit(value:  0);
            mem[1152921510639483120] = val_8;
            mem[1152921510639483104] = val_9;
            this.gold = val_10;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_11 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            this.isLevelRestrictionDisabled = val_11;
            mem[1152921510639483136] = val_11.inited;
            mem[1152921510639483137] = val_11.fakeValue;
            mem[1152921510639483138] = val_11.fakeValueActive;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_12 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  0.05f);
            mem[1152921510639483192] = val_13;
            mem2[0] = val_14;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_15 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  0.05f);
            mem[1152921510639483224] = val_16;
            mem2[0] = val_17;
            this.skillUpgrades = new System.Collections.Generic.List<SkillUpgrade>();
        }
        public TzarGames.GameFramework.ItemInstance get_ActiveWeaponInstance()
        {
            return (TzarGames.GameFramework.ItemInstance)this.<ActiveWeaponInstance>k__BackingField;
        }
        private void set_ActiveWeaponInstance(TzarGames.GameFramework.ItemInstance value)
        {
            this.<ActiveWeaponInstance>k__BackingField = value;
        }
        public TzarGames.GameFramework.ItemInstance get_ActiveSecondWeaponInstance()
        {
            return (TzarGames.GameFramework.ItemInstance)this.<ActiveSecondWeaponInstance>k__BackingField;
        }
        private void set_ActiveSecondWeaponInstance(TzarGames.GameFramework.ItemInstance value)
        {
            this.<ActiveSecondWeaponInstance>k__BackingField = value;
        }
        public TzarGames.GameFramework.ItemInstance get_ShieldInstance()
        {
            return (TzarGames.GameFramework.ItemInstance)this.<ShieldInstance>k__BackingField;
        }
        private void set_ShieldInstance(TzarGames.GameFramework.ItemInstance value)
        {
            this.<ShieldInstance>k__BackingField = value;
        }
        public TzarGames.GameFramework.ItemInstance get_ArmorSetItemInstance()
        {
            return (TzarGames.GameFramework.ItemInstance)this.<ArmorSetItemInstance>k__BackingField;
        }
        private void set_ArmorSetItemInstance(TzarGames.GameFramework.ItemInstance value)
        {
            this.<ArmorSetItemInstance>k__BackingField = value;
        }
        public TzarGames.Endless.PlayerClass get_Class()
        {
            return (TzarGames.Endless.PlayerClass)this.<Class>k__BackingField;
        }
        private void set_Class(TzarGames.Endless.PlayerClass value)
        {
            this.<Class>k__BackingField = value;
        }
        public TzarGames.Endless.Items.ArmorSet get_DefaultArmorSet()
        {
            return (TzarGames.Endless.Items.ArmorSet)this.defaultArmorSet;
        }
        public TzarGames.GameFramework.Weapon get_DefaultWeapon()
        {
            return (TzarGames.GameFramework.Weapon)this.defaultWeapon;
        }
        public UnityEngine.RuntimeAnimatorController get_AnimatorController()
        {
            return (UnityEngine.RuntimeAnimatorController)this.animatorController;
        }
        public TzarGames.Endless.EndlessPlayerCharacterTemplate.ICharacteristicUpgrade get_DamageUpgrade()
        {
            return (ICharacteristicUpgrade)this.damageUpgrade;
        }
        public TzarGames.Endless.EndlessPlayerCharacterTemplate.ICharacteristicUpgrade get_DefenceUpgrade()
        {
            return (ICharacteristicUpgrade)this.defenceUpgrade;
        }
        public TzarGames.Endless.EndlessPlayerCharacterTemplate.ICharacteristicUpgrade get_AttackSpeedUpgrade()
        {
            return (ICharacteristicUpgrade)this.attackSpeedUpgrade;
        }
        public TzarGames.Endless.EndlessPlayerCharacterTemplate.ICharacteristicUpgrade get_SpeedUpgrade()
        {
            return (ICharacteristicUpgrade)this.speedUpgrade;
        }
        public TzarGames.Endless.EndlessPlayerCharacterTemplate.ICharacteristicUpgrade get_HitPointsUpgrade()
        {
            return (ICharacteristicUpgrade)this.hpUpgrade;
        }
        public TzarGames.Endless.EndlessPlayerCharacterTemplate.ICharacteristicUpgrade get_HitPointsRegenUpgrade()
        {
            return (ICharacteristicUpgrade)this.hpRegenUpgrade;
        }
        public TzarGames.Endless.EndlessPlayerCharacterTemplate.ICharacteristicUpgrade get_CritMultiplierUpgrade()
        {
            return (ICharacteristicUpgrade)this.critMultiplierUpgrade;
        }
        public TzarGames.Endless.EndlessPlayerCharacterTemplate.ICharacteristicUpgrade get_CritChanceUpgrade()
        {
            return (ICharacteristicUpgrade)this.critChanceUpgrade;
        }
        public TzarGames.Endless.EndlessPlayerCharacterTemplate.ICharacteristicUpgrade get_BlockChanceUpgrade()
        {
            return (ICharacteristicUpgrade)this.blockChanceUpgrade;
        }
        public TzarGames.Endless.EndlessPlayerCharacterTemplate.ICharacteristicUpgrade get_InfluenceResistanceUpgrade()
        {
            return (ICharacteristicUpgrade)this.influenceResistanceUpgrade;
        }
        public TzarGames.Endless.EndlessPlayerCharacterTemplate.ICharacteristicUpgrade get_CritResistanceUpgrade()
        {
            return (ICharacteristicUpgrade)this.critResistanceUpgrade;
        }
        public long get_ConsumedLevelUpgradePoints()
        {
            return (long)this.<ConsumedLevelUpgradePoints>k__BackingField;
        }
        private void set_ConsumedLevelUpgradePoints(long value)
        {
            this.<ConsumedLevelUpgradePoints>k__BackingField = value;
        }
        public int get_AdditionalUpgradePoints()
        {
            return (int)this.<AdditionalUpgradePoints>k__BackingField;
        }
        private void set_AdditionalUpgradePoints(int value)
        {
            this.<AdditionalUpgradePoints>k__BackingField = value;
        }
        public long get_AvailableUpgradePoints()
        {
            uint val_1 = this.Level;
            long val_2 = this.<ConsumedLevelUpgradePoints>k__BackingField;
            val_2 = val_1 - val_2;
            val_1 = val_2 + (this.<AdditionalUpgradePoints>k__BackingField);
            return (long)val_1;
        }
        public void AddAdditionalUpgradePoint(int pointCount)
        {
            int val_1 = this.<AdditionalUpgradePoints>k__BackingField;
            val_1 = val_1 + pointCount;
            this.<AdditionalUpgradePoints>k__BackingField = val_1;
        }
        private bool consumeUpgradePoint(int pointCount)
        {
            var val_7;
            int val_3 = UnityEngine.Mathf.Max(a:  0, b:  this.Level - (this.<ConsumedLevelUpgradePoints>k__BackingField));
            val_7 = 0;
            if(((this.<AdditionalUpgradePoints>k__BackingField) + val_3) < pointCount)
            {
                    return (bool)val_7;
            }
            
            long val_7 = this.<ConsumedLevelUpgradePoints>k__BackingField;
            if(val_3 >= pointCount)
            {
                goto label_4;
            }
            
            int val_6 = pointCount - val_3;
            this.<ConsumedLevelUpgradePoints>k__BackingField = val_7 + (val_3 << );
            if(val_6 < 1)
            {
                goto label_6;
            }
            
            val_6 = (this.<AdditionalUpgradePoints>k__BackingField) - val_6;
            this.<AdditionalUpgradePoints>k__BackingField = val_6;
            goto label_6;
            label_4:
            val_7 = val_7 + (pointCount << );
            this.<ConsumedLevelUpgradePoints>k__BackingField = val_7;
            label_6:
            val_7 = 1;
            return (bool)val_7;
        }
        public override void Initialize()
        {
            this.blockChance.Init();
            this.influenceResistance.Init();
            this.critResistance.Init();
            this.Initialize();
            this.initUpgrade(upgrade:  this.damageUpgrade, characteristic:  this.DamageCharacteristic);
            this.initUpgrade(upgrade:  this.defenceUpgrade, characteristic:  this.DefenceCharacteristic);
            this.initUpgrade(upgrade:  this.speedUpgrade, characteristic:  this.WalkingSpeedCharacteristic);
            this.initUpgrade(upgrade:  this.attackSpeedUpgrade, characteristic:  this.AttackSpeedCharacteristic);
            this.initUpgrade(upgrade:  this.hpUpgrade, characteristic:  this.HitPointsCharacteristic);
            this.initUpgrade(upgrade:  this.hpRegenUpgrade, characteristic:  this.HitPointsRegenerationSpeedCharacteristic);
            this.initUpgrade(upgrade:  this.critChanceUpgrade, characteristic:  this.CritChanceCharacteristic);
            this.initUpgrade(upgrade:  this.critMultiplierUpgrade, characteristic:  this.CritMultiplierCharacteristic);
            this.initUpgrade(upgrade:  this.blockChanceUpgrade, characteristic:  this.blockChance);
            this.initUpgrade(upgrade:  this.influenceResistanceUpgrade, characteristic:  this.influenceResistance);
            this.initUpgrade(upgrade:  this.critResistanceUpgrade, characteristic:  this.critResistance);
            TzarGames.GameFramework.InventoryBag val_10 = this.Inventory.CreateBag(name:  "MASKS_BAG");
        }
        public override void ResetTemplate()
        {
            var val_2;
            var val_3;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredULong val_4;
            this.ResetTemplate();
            this.blockChance.ClearAllModificators();
            this.influenceResistance.ClearAllModificators();
            this.critResistance.ClearAllModificators();
            CodeStage.AntiCheat.ObscuredTypes.ObscuredULong val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredULong.op_Implicit(value:  0);
            mem[1152921510643740224] = val_2;
            mem[1152921510643740208] = val_3;
            this.<ArmorSetItemInstance>k__BackingField = 0;
            this.<ActiveSecondWeaponInstance>k__BackingField = 0;
            this.<ShieldInstance>k__BackingField = 0;
            this.<ActiveWeaponInstance>k__BackingField = 0;
            this.gold = val_4;
        }
        protected override void setupModificators()
        {
            this.setupModificators();
            this.blockChance.minValue = 0f;
            this.blockChance.maxValue = 95f;
            this.blockChance.clampMinimum = true;
            this.blockChance.clampMaximum = true;
            this.blockChance.applyModificatorsWhenBaseIsLessOrEqualZero = false;
            this.influenceResistance.minValue = 0f;
            this.influenceResistance.maxValue = 95f;
            this.influenceResistance.clampMinimum = true;
            this.influenceResistance.clampMaximum = true;
            this.influenceResistance.applyModificatorsWhenBaseIsLessOrEqualZero = false;
            this.critResistance.minValue = 0f;
            this.critResistance.maxValue = 95f;
            this.critResistance.clampMinimum = true;
            this.critResistance.clampMaximum = true;
            this.critResistance.applyModificatorsWhenBaseIsLessOrEqualZero = false;
        }
        public override void Update()
        {
            this.Update();
            this.blockChance.Update();
            this.influenceResistance.Update();
            this.critResistance.Update();
        }
        public float get_BlockChance()
        {
            float val_3 = this.blockChanceCoefficient;
            val_3 = val_3 * (float)(double)this.Level;
            val_3 = this.blockChance.Value + val_3;
            return (float)val_3;
        }
        public TzarGames.GameFramework.Characteristic get_BlockChanceCharacteristic()
        {
            return (TzarGames.GameFramework.Characteristic)this.blockChance;
        }
        public TzarGames.GameFramework.Characteristic get_InfluenceResistanceCharacteristic()
        {
            return (TzarGames.GameFramework.Characteristic)this.influenceResistance;
        }
        public float get_InfluenceResistance()
        {
            float val_3 = this.influenceResistanceCoefficent;
            val_3 = val_3 * (float)(double)this.Level;
            val_3 = this.influenceResistance.Value + val_3;
            return (float)val_3;
        }
        public TzarGames.GameFramework.Characteristic get_CritResistanceCharacteristic()
        {
            return (TzarGames.GameFramework.Characteristic)this.critResistance;
        }
        public float get_CritResistance()
        {
            float val_3 = this.critResistanceCoefficent;
            val_3 = val_3 * (float)(double)this.Level;
            val_3 = this.critResistance.Value + val_3;
            return (float)val_3;
        }
        private void initUpgrade(TzarGames.Endless.EndlessPlayerCharacterTemplate.CharacteristicUpgrage upgrade, TzarGames.GameFramework.Characteristic characteristic)
        {
            characteristic.AddModificator(modificator:  upgrade.Modificator);
            upgrade.PlayerTemplate = this;
            upgrade.UpgradeLevel = 0;
        }
        public bool get_IsLevelRestrictionDisabled()
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {inited = this.isLevelRestrictionDisabled, fakeValue = this.isLevelRestrictionDisabled, fakeValueActive = this.isLevelRestrictionDisabled});
        }
        public void set_IsLevelRestrictionDisabled(bool value)
        {
            value = value;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            this.isLevelRestrictionDisabled = val_1;
            mem[1152921510645209760] = val_1.inited;
            mem[1152921510645209761] = val_1.fakeValue;
            mem[1152921510645209762] = val_1.fakeValueActive;
        }
        public ulong get_Gold()
        {
            return (ulong)CodeStage.AntiCheat.ObscuredTypes.ObscuredULong.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredULong() {inited = false, fakeValueActive = false});
        }
        public void set_Gold(ulong value)
        {
            var val_2;
            var val_3;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredULong val_4;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredULong val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredULong.op_Implicit(value:  0);
            mem[1152921510645437792] = val_2;
            mem[1152921510645437776] = val_3;
            this.gold = val_4;
        }
        public float get_HealingPotionUsageInterval()
        {
            return (float)CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat() {hiddenValue = new CodeStage.AntiCheat.Common.ACTkByte4(), inited = false, fakeValueActive = false});
        }
        public void AddGold(int goldAdd)
        {
            ulong val_9;
            var val_10;
            if((goldAdd & 2147483648) == 0)
            {
                    val_9 = this.Gold + ((((long)goldAdd > (~this.Gold)) ? (~this.Gold) : goldAdd) << );
            }
            else
            {
                    val_10 = (long)UnityEngine.Mathf.Abs(value:  0);
                if(val_10 > this.Gold)
            {
                    val_10 = this.Gold;
            }
            
                val_9 = this.Gold - val_10;
            }
            
            this.Gold = val_9;
        }
        public void SetPlayerData(TzarGames.Endless.EndlessHeroData playerData, TzarGames.GameFramework.ItemDatabaseData itemDatabase)
        {
            int val_10;
            var val_16;
            var val_24;
            var val_33;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt val_34;
            TzarGames.GameFramework.Inventory val_66;
            int val_67;
            string val_68;
            var val_69;
            var val_71;
            if(playerData != null)
            {
                    this.<Class>k__BackingField = playerData.Class;
            }
            else
            {
                    this.<Class>k__BackingField = 1;
            }
            
            this.XP = CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
            this.Gold = CodeStage.AntiCheat.ObscuredTypes.ObscuredULong.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredULong() {inited = false, fakeValueActive = false});
            this.<ConsumedLevelUpgradePoints>k__BackingField = CodeStage.AntiCheat.ObscuredTypes.ObscuredLong.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredLong() {inited = false, fakeValueActive = false});
            this.<AdditionalUpgradePoints>k__BackingField = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
            var val_5 = (playerData.IsLevelRestrictionDisabled == true) ? 1 : 0;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_6 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            this.isLevelRestrictionDisabled = val_6;
            mem[1152921510646056000] = val_6.inited;
            mem[1152921510646056001] = val_6.fakeValue;
            mem[1152921510646056002] = val_6.fakeValueActive;
            val_66 = this.Inventory;
            List.Enumerator<T> val_8 = playerData.InventoryBags.GetEnumerator();
            val_67 = 0;
            goto label_94;
            label_97:
            val_68 = val_66.GetBagByName(bagName:  null);
            if(val_68 == null)
            {
                    val_68 = val_66.CreateBag(name:  val_68);
            }
            
            List.Enumerator<T> val_14 = X26.GetEnumerator();
            label_37:
            if((0 & 1) == 0)
            {
                goto label_95;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_17 = val_16.InitializationCallback;
            TzarGames.GameFramework.Item val_18 = itemDatabase.GetItemByID(id:  val_66);
            if(0 != val_18)
            {
                goto label_27;
            }
            
            string val_20 = 0 + "Item with ID " + UnityEngine.Object.__il2cppRuntimeField_cctor_finished;
            UnityEngine.Debug.LogError(message:  0);
            goto label_37;
            label_27:
            bool val_21 = val_68.RemoveAllConsumableItems(item:  val_18);
            val_68.AddConsumableItem(item:  val_18, count:  val_17);
            goto label_37;
            label_95:
            val_16.Dispose();
            if(0 == 308)
            {
                
            }
            else
            {
                    if(null != null)
            {
                    val_69 = 0;
            }
            else
            {
                    val_69 = 0;
            }
            
            }
            
            List.Enumerator<T> val_22 = val_10.InitializationCallback.GetEnumerator();
            do
            {
                label_90:
                if((0 & 1) == 0)
            {
                goto label_96;
            }
            
            }
            while((val_68.GetNonConsumableItemInstanceByID(itemInstanceID:  val_17)) != null);
            
            TzarGames.GameFramework.Item val_27 = itemDatabase.GetItemByID(id:  val_17);
            if(0 != val_27)
            {
                goto label_53;
            }
            
            string val_29 = 0 + "Item with ID " + UnityEngine.Object.__il2cppRuntimeField_cctor_finished;
            UnityEngine.Debug.LogError(message:  0);
            goto label_90;
            label_53:
            TzarGames.GameFramework.ItemInstance val_30 = new TzarGames.GameFramework.ItemInstance();
            CreateTemplateInstance(item:  val_27);
            SetInstanceID(newId:  val_27);
            TzarGames.GameFramework.Item val_31 = GetTemplateInstance();
            CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt val_32 = CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  0);
            mem2[0] = val_33;
            val_31.Level = val_34;
            typeof(TzarGames.GameFramework.ItemInstance).__il2cppRuntimeField_50 = val_31;
            TzarGames.Endless.ItemEnchancement.UpdateEnchancement(itemInstance:  null);
            val_68.AddNonconsumableItem(itemInstance:  null);
            if(((((val_31.Equals(value:  playerData.ArmorSetId)) == true) || ((val_31.Equals(value:  playerData.ShieldId)) == true)) || ((val_31.Equals(value:  playerData.WeaponId)) == true)) || ((val_24.InitializationCallback.Equals(value:  playerData.SecondWeaponId)) == true))
            {
                goto label_90;
            }
            
            goto label_90;
            label_96:
            val_24.Dispose();
            val_67 = 1152921504863076352;
            if(0 != 652)
            {
                    val_67 = 0;
                if(null != null)
            {
                    val_67 = 0;
            }
            
            }
            
            label_94:
            if((0 & 1) != 0)
            {
                goto label_97;
            }
            
            val_10.Dispose();
            if((val_66.GetItemInstanceByID(id:  playerData.ArmorSetId)) != null)
            {
                
            }
            else
            {
                    string val_44 = 0 + "Failed to find ArmorSet item with id: "("Failed to find ArmorSet item with id: ");
                UnityEngine.Debug.LogError(message:  0);
            }
            
            if((val_66.GetItemInstanceByID(id:  playerData.WeaponId)) != null)
            {
                
            }
            else
            {
                    string val_46 = 0 + "Failed to find weapon item with id: "("Failed to find weapon item with id: ");
                UnityEngine.Debug.LogError(message:  0);
            }
            
            TzarGames.GameFramework.ItemInstance val_47 = val_66.GetItemInstanceByID(id:  playerData.SecondWeaponId);
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    if((val_66.GetItemInstanceByID(id:  playerData.ShieldId)) != null)
            {
                
            }
            else
            {
                    string val_51 = 0 + "Failed to find shield item with id: "("Failed to find shield item with id: ");
                UnityEngine.Debug.LogError(message:  0);
            }
            
            }
            
            this.damageUpgrade.UpgradeLevel = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {inited = false, fakeValue = 268435457, fakeValueActive = false});
            this.damageUpgrade.Update();
            this.defenceUpgrade.UpgradeLevel = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
            this.defenceUpgrade.Update();
            this.speedUpgrade.UpgradeLevel = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
            this.speedUpgrade.Update();
            this.attackSpeedUpgrade.UpgradeLevel = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
            this.attackSpeedUpgrade.Update();
            this.hpRegenUpgrade.UpgradeLevel = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
            this.hpRegenUpgrade.Update();
            this.hpUpgrade.UpgradeLevel = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
            this.hpUpgrade.Update();
            this.critChanceUpgrade.UpgradeLevel = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
            this.critChanceUpgrade.Update();
            this.critMultiplierUpgrade.UpgradeLevel = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
            this.critMultiplierUpgrade.Update();
            this.blockChanceUpgrade.UpgradeLevel = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {inited = false, fakeValue = 268435457, fakeValueActive = false});
            this.blockChanceUpgrade.Update();
            this.influenceResistanceUpgrade.UpgradeLevel = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
            this.influenceResistanceUpgrade.Update();
            this.critResistanceUpgrade.UpgradeLevel = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
            this.critResistanceUpgrade.Update();
            this.skillUpgrades.Clear();
            val_71 = 0;
            goto label_171;
            label_179:
            ISkillUpgrade val_63 = this.CreateSkillUpgrade(skillId:  null, cooldDownLevel:  1152921504836825088, commonLevel:  val_62 + 24);
            val_71 = 1;
            label_171:
            if(val_71 >= playerData.SkillUpgrades.Count)
            {
                    return;
            }
            
            if(playerData.SkillUpgrades.Item[1] == null)
            {
                goto label_179;
            }
            
            goto label_179;
        }
        private void updateSkillUpgrade(TzarGames.Endless.EndlessPlayerCharacterTemplate.SkillUpgrade upgrade, TzarGames.TzarHero.Skills.CharacterSkill skillInstance)
        {
            var val_10;
            var val_11;
            var val_12;
            if(skillInstance != null)
            {
                    var val_10 = 0;
                val_10 = val_10 + 1;
                val_10 = skillInstance;
                if((skillInstance.HasModificator(modificator:  upgrade.<CommonModificator>k__BackingField)) != true)
            {
                    var val_11 = 0;
                val_11 = val_11 + 1;
                val_11 = skillInstance;
                skillInstance.AddModificator(modificator:  upgrade.<CommonModificator>k__BackingField);
            }
            
            }
            
            if(skillInstance != null)
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                val_12 = skillInstance;
                skillInstance.AddModificator(modificator:  upgrade.<CommonModificator>k__BackingField);
            }
            
            if((skillInstance.CooldownCharacteristic.IsModificatorApplied(modificator:  upgrade.<CooldownModificator>k__BackingField)) != false)
            {
                    return;
            }
            
            skillInstance.CooldownCharacteristic.AddModificator(modificator:  upgrade.<CooldownModificator>k__BackingField);
        }
        private void removeSkillUpgrade(TzarGames.TzarHero.Skills.CharacterSkill skillInstance)
        {
            if((this.GetSkillUpgradeBySkillId(skillId:  skillInstance.Id)) == null)
            {
                    return;
            }
        
        }
        public override void RemoveSkill(TzarGames.TzarHero.Skills.CharacterSkill skill)
        {
            TzarGames.TzarHero.Skills.CharacterSkill val_1 = this.GetSkillInstance(skill:  skill);
            this.removeSkillUpgrade(skillInstance:  skill);
            this.RemoveSkill(skill:  skill);
        }
        public TzarGames.Endless.EndlessPlayerCharacterTemplate.ISkillUpgrade GetSkillUpgradeBySkillId(int skillId)
        {
            var val_3;
            var val_4;
            val_3 = 0;
            label_5:
            if(val_3 >= this.skillUpgrades.Count)
            {
                goto label_2;
            }
            
            val_4 = this.skillUpgrades.Item[0];
            val_3 = val_3 + 1;
            if((val_2.<SkillId>k__BackingField) != skillId)
            {
                goto label_5;
            }
            
            return (ISkillUpgrade)val_4;
            label_2:
            val_4 = 0;
            return (ISkillUpgrade)val_4;
        }
        public TzarGames.Endless.EndlessPlayerCharacterTemplate.ISkillUpgrade CreateSkillUpgrade(int skillId)
        {
            return this.CreateSkillUpgrade(skillId:  skillId, cooldDownLevel:  0, commonLevel:  0);
        }
        private TzarGames.Endless.EndlessPlayerCharacterTemplate.ISkillUpgrade CreateSkillUpgrade(int skillId, int cooldDownLevel, int commonLevel)
        {
            var val_7;
            var val_8;
            object val_1 = new System.Object();
            typeof(EndlessPlayerCharacterTemplate.SkillUpgrade).__il2cppRuntimeField_50 = this;
            typeof(EndlessPlayerCharacterTemplate.SkillUpgrade).__il2cppRuntimeField_38 = skillId;
            TzarGames.GameFramework.CharacteristicModificator val_2 = new TzarGames.GameFramework.CharacteristicModificator();
            if(null != 0)
            {
                    val_7 = val_1;
                typeof(EndlessPlayerCharacterTemplate.SkillUpgrade).__il2cppRuntimeField_48 = val_2;
            }
            else
            {
                    val_7 = 72;
                mem[72] = val_2;
            }
            
            typeof(TzarGames.GameFramework.CharacteristicModificator).__il2cppRuntimeField_10 = 0;
            typeof(TzarGames.GameFramework.CharacteristicModificator).__il2cppRuntimeField_18 = 1;
            CooldownUpgradeLevel = cooldDownLevel;
            TzarGames.GameFramework.CharacteristicModificator val_3 = new TzarGames.GameFramework.CharacteristicModificator();
            if(null != 0)
            {
                    val_8 = val_1;
                typeof(EndlessPlayerCharacterTemplate.SkillUpgrade).__il2cppRuntimeField_40 = val_3;
            }
            else
            {
                    val_8 = 64;
                mem[64] = val_3;
            }
            
            typeof(TzarGames.GameFramework.CharacteristicModificator).__il2cppRuntimeField_10 = 0;
            typeof(TzarGames.GameFramework.CharacteristicModificator).__il2cppRuntimeField_18 = 1;
            CommonUpgradeLevel = commonLevel;
            this.skillUpgrades.Add(item:  val_1);
            TzarGames.TzarHero.Skills.CharacterSkill val_4 = this.GetSkillInstanceById(id:  skillId);
            bool val_5 = UnityEngine.Object.op_Inequality(x:  0, y:  val_4);
            if(val_5 != false)
            {
                    val_5.updateSkillUpgrade(upgrade:  val_1, skillInstance:  val_4);
                return (ISkillUpgrade)val_1;
            }
            
            string val_6 = 0 + "Failed to get skill instance with id: "("Failed to get skill instance with id: ");
            UnityEngine.Debug.LogError(message:  0);
            return (ISkillUpgrade)val_1;
        }
        public TzarGames.Endless.EndlessHeroData GetPlayerData()
        {
            var val_12;
            var val_13;
            var val_14;
            var val_16;
            var val_17;
            var val_18;
            var val_20;
            var val_21;
            var val_24;
            var val_25;
            var val_28;
            var val_29;
            var val_32;
            var val_33;
            var val_36;
            var val_37;
            var val_40;
            var val_41;
            var val_44;
            var val_45;
            var val_48;
            var val_49;
            var val_52;
            var val_53;
            var val_56;
            var val_57;
            var val_60;
            var val_61;
            var val_64;
            var val_65;
            var val_78;
            var val_79;
            string val_80;
            var val_81;
            var val_82;
            SkillUpgradeInfo val_83;
            val_78 = null;
            val_78 = null;
            uint val_2 = this.XP;
            typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_10 = 1;
            typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_1D0 = new System.Collections.Generic.List<TzarGames.Endless.EndlessBagSerializationInfo>();
            if((this.<ActiveWeaponInstance>k__BackingField) != null)
            {
                    typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_28 = this.<ActiveWeaponInstance>k__BackingField.GetInstanceID();
            }
            else
            {
                    val_79 = null;
                val_79 = null;
                typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_28 = System.String.Empty;
                UnityEngine.Debug.LogWarning(message:  0);
            }
            
            if((this.<ActiveSecondWeaponInstance>k__BackingField) == null)
            {
                goto label_14;
            }
            
            val_80 = this.<ActiveSecondWeaponInstance>k__BackingField.GetInstanceID();
            if(null != 0)
            {
                goto label_19;
            }
            
            goto label_16;
            label_14:
            val_81 = null;
            val_81 = null;
            val_80 = System.String.Empty;
            if(null != 0)
            {
                goto label_19;
            }
            
            label_16:
            label_19:
            typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_30 = val_80;
            if((this.<ShieldInstance>k__BackingField) != null)
            {
                    typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_38 = this.<ShieldInstance>k__BackingField.GetInstanceID();
            }
            
            ulong val_10 = this.Gold;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredULong val_11 = CodeStage.AntiCheat.ObscuredTypes.ObscuredULong.op_Implicit(value:  0);
            typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_58 = val_12;
            typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_78 = val_14;
            typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_68 = val_13;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredLong val_15 = CodeStage.AntiCheat.ObscuredTypes.ObscuredLong.op_Implicit(value:  0);
            typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_A0 = val_16;
            typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_80 = val_18;
            typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_90 = val_17;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_19 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
            typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_A8 = val_20;
            typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_B8 = val_21;
            int val_22 = this.damageUpgrade.UpgradeLevel;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_23 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
            typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_BC = val_24;
            typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_CC = val_25;
            int val_26 = this.defenceUpgrade.UpgradeLevel;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_27 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
            typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_D0 = val_28;
            typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_E0 = val_29;
            int val_30 = this.attackSpeedUpgrade.UpgradeLevel;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_31 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
            typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_F8 = val_32;
            typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_108 = val_33;
            int val_34 = this.speedUpgrade.UpgradeLevel;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_35 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
            typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_E4 = val_36;
            typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_F4 = val_37;
            int val_38 = this.hpUpgrade.UpgradeLevel;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_39 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
            typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_11C = val_40;
            mem[1152921504863981836] = val_41;
            int val_42 = this.hpRegenUpgrade.UpgradeLevel;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_43 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
            typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_120 = val_44;
            typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_130 = val_45;
            int val_46 = this.critChanceUpgrade.UpgradeLevel;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_47 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
            typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_144 = val_48;
            mem[1152921504863981876] = val_49;
            int val_50 = this.critMultiplierUpgrade.UpgradeLevel;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_51 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
            typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_158 = val_52;
            public System.String System.Object::ToString().__il2cppRuntimeField_FFFFFFFFFFFFFFFF = val_53;
            int val_54 = this.blockChanceUpgrade.UpgradeLevel;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_55 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
            typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_16C = val_56;
            mem[1152921504863981916] = val_57;
            int val_58 = this.influenceResistanceUpgrade.UpgradeLevel;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_59 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
            typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_170 = val_60;
            typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_180 = val_61;
            int val_62 = this.critResistanceUpgrade.UpgradeLevel;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_63 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
            val_82 = 0;
            typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_194 = val_65;
            mem[1152921504863981956] = val_64;
            goto label_38;
            label_58:
            val_82 = 1;
            System.String.Empty.__unknownFiledOffset_18 = CommonUpgradeLevel;
            label_38:
            if(val_82 >= this.skillUpgrades.Count)
            {
                goto label_40;
            }
            
            SkillUpgrade val_68 = this.skillUpgrades.Item[1];
            List.Enumerator<T> val_69 = typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_1C8.GetEnumerator();
            label_47:
            if((0 & 1) == 0)
            {
                goto label_44;
            }
            
            val_83 = val_12.InitializationCallback;
            if(val_2 != (val_68.<SkillId>k__BackingField))
            {
                goto label_47;
            }
            
            val_12.Dispose();
            goto label_48;
            label_44:
            val_12.Dispose();
            object val_71 = null;
            val_83 = val_71;
            val_71 = new System.Object();
            typeof(EndlessHeroData.SkillUpgradeInfo).__il2cppRuntimeField_10 = val_68.<SkillId>k__BackingField;
            typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_1C8.Add(item:  val_83);
            label_48:
            typeof(EndlessHeroData.SkillUpgradeInfo).__il2cppRuntimeField_14 = val_68.CooldownUpgradeLevel;
            if(val_68 != null)
            {
                goto label_58;
            }
            
            goto label_58;
            label_40:
            List.Enumerator<T> val_75 = this.Inventory.GetSerializedData<TzarGames.Endless.EndlessItemInstanceSerializationInfo, TzarGames.Endless.EndlessConsumableItemInstanceSerializationInfo>().GetEnumerator();
            label_67:
            if((0 & 1) == 0)
            {
                goto label_70;
            }
            
            TzarGames.Endless.EndlessBagSerializationInfo val_77 = new TzarGames.Endless.EndlessBagSerializationInfo(bagName:  this.skillUpgrades);
            if(null != 0)
            {
                    typeof(TzarGames.Endless.EndlessBagSerializationInfo).__il2cppRuntimeField_20 = this.skillUpgrades;
            }
            else
            {
                    mem[32] = this.skillUpgrades;
            }
            
            typeof(TzarGames.Endless.EndlessBagSerializationInfo).__il2cppRuntimeField_18 = 0.InitializationCallback;
            Add(item:  null);
            goto label_67;
            label_70:
            0.Dispose();
            if((0 & 1) != 0)
            {
                    return (TzarGames.Endless.EndlessHeroData)new TzarGames.Endless.EndlessHeroData(classType:  this.<Class>k__BackingField, armorSetId:  this.<ArmorSetItemInstance>k__BackingField.GetInstanceID(), weaponId:  System.String.Empty, secondWeaponId:  System.String.Empty, xp:  val_2, levelRestrictionDisabled:  CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {inited = this.isLevelRestrictionDisabled, fakeValue = this.isLevelRestrictionDisabled, fakeValueActive = this.isLevelRestrictionDisabled}));
            }
            
            if(null == 0)
            {
                    return (TzarGames.Endless.EndlessHeroData)new TzarGames.Endless.EndlessHeroData(classType:  this.<Class>k__BackingField, armorSetId:  this.<ArmorSetItemInstance>k__BackingField.GetInstanceID(), weaponId:  System.String.Empty, secondWeaponId:  System.String.Empty, xp:  val_2, levelRestrictionDisabled:  CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {inited = this.isLevelRestrictionDisabled, fakeValue = this.isLevelRestrictionDisabled, fakeValueActive = this.isLevelRestrictionDisabled}));
            }
            
            return (TzarGames.Endless.EndlessHeroData)new TzarGames.Endless.EndlessHeroData(classType:  this.<Class>k__BackingField, armorSetId:  this.<ArmorSetItemInstance>k__BackingField.GetInstanceID(), weaponId:  System.String.Empty, secondWeaponId:  System.String.Empty, xp:  val_2, levelRestrictionDisabled:  CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {inited = this.isLevelRestrictionDisabled, fakeValue = this.isLevelRestrictionDisabled, fakeValueActive = this.isLevelRestrictionDisabled}));
        }
        public override bool SetItemActive(TzarGames.GameFramework.ItemInstance itemInstance, bool active, int slot)
        {
            var val_12;
            var val_14;
            TzarGames.GameFramework.Item val_1 = itemInstance.GetTemplateInstance();
            val_12 = 0;
            var val_2 = (slot == 0) ? 1 : 0;
            if((active == false) || ((this.IsItemActivated(item:  itemInstance)) == false))
            {
                goto label_8;
            }
            
            var val_13 = this;
            if(val_13 == slot)
            {
                goto label_10;
            }
            
            label_8:
            val_13 = val_13.SetItemActive(itemInstance:  itemInstance, active:  active, slot:  slot);
            if(val_13 == false)
            {
                goto label_10;
            }
            
            if( == 0)
            {
                goto label_15;
            }
            
            this.onActivateWeapon(itemInstance:  itemInstance, isActive:  active, slot:  slot);
            goto label_23;
            label_10:
            if(( & ) == 1)
            {
                    val_14 = 0;
                this.<ActiveWeaponInstance>k__BackingField = this.<ActiveWeaponInstance>k__BackingField;
                return (bool)val_14;
            }
            
            val_14 = 0;
            return (bool)val_14;
            label_15:
            if(itemInstance.GetTemplateInstance() != null)
            {
                    this.onActivateArmorSet(itemInstance:  itemInstance, isActive:  active);
            }
            
            label_23:
            val_14 = 1;
            return (bool)val_14;
        }
        private void activateArmorCharacteristics(TzarGames.GameFramework.Armor armor, bool activate)
        {
            TzarGames.GameFramework.Characteristic val_1 = this.DefenceCharacteristic;
            TzarGames.GameFramework.CharacteristicModificator val_2 = armor.DefenceModificator;
            if(activate != false)
            {
                    val_1.AddModificator(modificator:  val_2);
                return;
            }
            
            val_1.UnregisterModificator(modificator:  val_2);
        }
        public override void ActivateWeaponModificators(TzarGames.GameFramework.Weapon weapon, bool activate)
        {
            activate = activate;
            this.ActivateWeaponModificators(weapon:  weapon, activate:  activate);
            if(activate != false)
            {
                    weapon.ApplyToTemplate(template:  this);
                return;
            }
            
            weapon.RemoveFromTemplate(template:  this);
        }
        private void removeActiveShield()
        {
            var val_3;
            if((this.<ShieldInstance>k__BackingField) == null)
            {
                    return;
            }
            
            this.<ShieldInstance>k__BackingField = 0;
            val_3 = 0;
            if((this.<ShieldInstance>k__BackingField.GetTemplateInstance()) != null)
            {
                    val_3 = 0;
            }
            
            this.activateArmorCharacteristics(armor:  null, activate:  false);
        }
        private void removeActiveWeapon(int slot)
        {
            var val_1 = (slot != 0) ? this.<ActiveSecondWeaponInstance>k__BackingField : this.<ActiveWeaponInstance>k__BackingField;
            if(val_1 == 0)
            {
                    return;
            }
            
            if(slot != 0)
            {
                    mem2[0] = 0;
            }
            else
            {
                    mem2[0] = 0;
            }
            
            if(val_1.GetTemplateInstance() != null)
            {
                
            }
        
        }
        private void onActivateWeapon(TzarGames.GameFramework.ItemInstance itemInstance, bool isActive, int slot)
        {
            TzarGames.GameFramework.ItemInstance val_3;
            if(isActive == false)
            {
                goto label_1;
            }
            
            if((this.<ActiveWeaponInstance>k__BackingField) == itemInstance)
            {
                    return;
            }
            
            if((this.<ActiveSecondWeaponInstance>k__BackingField) == itemInstance)
            {
                    return;
            }
            
            this.removeActiveWeapon(slot:  slot);
            if(slot == 0)
            {
                goto label_4;
            }
            
            this.<ActiveSecondWeaponInstance>k__BackingField = itemInstance;
            goto label_5;
            label_1:
            if(slot == 1)
            {
                goto label_6;
            }
            
            if(slot != 0)
            {
                goto label_10;
            }
            
            val_3 = this.<ActiveWeaponInstance>k__BackingField;
            goto label_8;
            label_6:
            val_3 = this.<ActiveSecondWeaponInstance>k__BackingField;
            label_8:
            if((val_3 != itemInstance) && (val_3 != null))
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            label_10:
            this.removeActiveWeapon(slot:  slot);
            return;
            label_4:
            this.<ActiveWeaponInstance>k__BackingField = itemInstance;
            label_5:
            if(slot != 0)
            {
                    this.removeActiveShield();
            }
        
        }
        private void onActivateShield(TzarGames.GameFramework.ItemInstance itemInstance, bool isActive)
        {
            var val_3;
            if(isActive == false)
            {
                goto label_1;
            }
            
            if((this.<ShieldInstance>k__BackingField) == itemInstance)
            {
                    return;
            }
            
            this.removeActiveShield();
            this.<ShieldInstance>k__BackingField = itemInstance;
            val_3 = 0;
            if(itemInstance.GetTemplateInstance() == null)
            {
                goto label_6;
            }
            
            val_3 = 0;
            goto label_6;
            label_1:
            if(((this.<ShieldInstance>k__BackingField) != itemInstance) && ((this.<ShieldInstance>k__BackingField) != null))
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            this.removeActiveShield();
            return;
            label_6:
            this.activateArmorCharacteristics(armor:  null, activate:  true);
            if((this.<ActiveSecondWeaponInstance>k__BackingField) == null)
            {
                    return;
            }
            
            this.removeActiveWeapon(slot:  1);
        }
        private void onActivateArmorSet(TzarGames.GameFramework.ItemInstance itemInstance, bool isActive)
        {
            var val_3;
            if(isActive == false)
            {
                goto label_1;
            }
            
            if((this.<ArmorSetItemInstance>k__BackingField) == itemInstance)
            {
                    return;
            }
            
            val_3 = 0;
            if(itemInstance.GetTemplateInstance() == null)
            {
                goto label_6;
            }
            
            val_3 = 0;
            goto label_6;
            label_1:
            if(((this.<ArmorSetItemInstance>k__BackingField) != itemInstance) && ((this.<ArmorSetItemInstance>k__BackingField) != null))
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            this.removeActiveArmorSet();
            return;
            label_6:
            this.removeActiveArmorSet();
            this.<ArmorSetItemInstance>k__BackingField = itemInstance;
            this.activateArmorCharacteristics(armor:  null, activate:  true);
        }
        private void removeActiveArmorSet()
        {
            var val_3;
            if((this.<ArmorSetItemInstance>k__BackingField) == null)
            {
                    return;
            }
            
            this.<ArmorSetItemInstance>k__BackingField = 0;
            val_3 = 0;
            if((this.<ArmorSetItemInstance>k__BackingField.GetTemplateInstance()) != null)
            {
                    val_3 = 0;
            }
            
            this.activateArmorCharacteristics(armor:  null, activate:  false);
        }
        public override bool CanActivateItem(TzarGames.GameFramework.ItemInstance itemInstance, int slot)
        {
            if(val_1.MinimumLevel > this.Level)
            {
                    if((CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {inited = this.isLevelRestrictionDisabled, fakeValue = this.isLevelRestrictionDisabled, fakeValueActive = this.isLevelRestrictionDisabled})) == false)
            {
                    return false;
            }
            
            }
            
            if(val_1.ConsumptionType == 0)
            {
                    return false;
            }
            
            if(itemInstance.GetOriginalTemplate() != null)
            {
                    return false;
            }
            
            if((this.<ActiveWeaponInstance>k__BackingField) == itemInstance)
            {
                    return false;
            }
            
            if(slot == 0)
            {
                    return this.CanActivateItem(itemInstance:  itemInstance, slot:  slot);
            }
            
            if(itemInstance.GetTemplateInstance() == null)
            {
                    return this.CanActivateItem(itemInstance:  itemInstance, slot:  slot);
            }
            
            if((this.<Class>k__BackingField) != 1)
            {
                    return false;
            }
            
            return this.CanActivateItem(itemInstance:  itemInstance, slot:  slot);
        }
        public bool HasBlockChanceCharacteristic()
        {
            return (bool)((this.<Class>k__BackingField) == 0) ? 1 : 0;
        }
        public override bool CanDeactivateItem(TzarGames.GameFramework.ItemInstance itemInstance)
        {
            if((this.<ActiveWeaponInstance>k__BackingField) == itemInstance)
            {
                    return false;
            }
            
            if((this.<ArmorSetItemInstance>k__BackingField) == itemInstance)
            {
                    return false;
            }
            
            return this.CanDeactivateItem(itemInstance:  itemInstance);
        }
        public bool CanWearItemType(System.Type t)
        {
            var val_8;
            var val_9;
            var val_10;
            val_8 = 1152921504911585280;
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            if(((t & 1) & 1) == 0)
            {
                    val_9 = null;
                if((System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())) != t)
            {
                    val_10 = 0;
                return (bool)((this.<Class>k__BackingField) == 0) ? 1 : 0;
            }
            
            }
            
            val_8 = 1152921504911798272;
            val_9 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            if(((t & 1) & 1) != 0)
            {
                    return (bool)((this.<Class>k__BackingField) == 0) ? 1 : 0;
            }
            
            val_9 = null;
            if((System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())) == t)
            {
                    return (bool)((this.<Class>k__BackingField) == 0) ? 1 : 0;
            }
            
            val_10 = 1;
            return (bool)((this.<Class>k__BackingField) == 0) ? 1 : 0;
        }
    
    }

}

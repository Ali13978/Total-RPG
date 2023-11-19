using UnityEngine;

namespace TzarGames.GameFramework
{
    public class CharacterTemplate : DatabaseRecord
    {
        // Fields
        [UnityEngine.HideInInspector]
        [UnityEngine.SerializeField]
        private int id;
        [UnityEngine.SerializeField]
        private string characterName;
        [UnityEngine.SerializeField]
        public TzarGames.Common.LocalizedStringAsset localizedName;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.CharacterGroup group;
        [UnityEngine.SerializeField]
        private System.Collections.Generic.List<TzarGames.Common.StringID> tags;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt _level;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt xp;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Characteristic hitPoints;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Characteristic hitPointsRegenerationSpeed;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Characteristic damage;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Characteristic attackSpeed;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Characteristic defence;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Characteristic walkingSpeed;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Characteristic xpRate;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Characteristic critChance;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Characteristic critMultiplier;
        [UnityEngine.SerializeField]
        private float hitPointsCoefficient;
        [UnityEngine.SerializeField]
        private float hitPointRegenSpeedCoefficient;
        [UnityEngine.SerializeField]
        private float damageCoefficient;
        [UnityEngine.SerializeField]
        private float attackSpeedCoefficient;
        [UnityEngine.SerializeField]
        private float defenceCoefficient;
        [UnityEngine.SerializeField]
        private float walkingSpeedCoefficient;
        [UnityEngine.SerializeField]
        private float critChanceCoefficient;
        [UnityEngine.SerializeField]
        private float critMultiplierCoefficient;
        private bool enableHitPointRegeneration;
        [UnityEngine.SerializeField]
        private bool enableUpdateStats;
        private TzarGames.GameFramework.Characteristic actualHitPoints;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.GameFramework.CharacterTemplate, int> OnXpChanged;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.GameFramework.CharacterTemplate.CharacterTemplateDelegate OnLevelUp;
        private TzarGames.GameFramework.Inventory inventory;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <IsInitialized>k__BackingField;
        public const float XpGrowRateDefault = 100;
        public const float XpRisePowerDefault = 1;
        private static float xpGrowRate;
        private static float xpPower;
        private static System.Collections.Generic.List<uint> xpSet;
        private static bool xpTableInitialized;
        public const uint MAX_TABLE_LEVEL = 1000;
        
        // Properties
        public string CharacterName { get; set; }
        public TzarGames.GameFramework.CharacterGroup Group { get; set; }
        public override int Id { get; set; }
        public TzarGames.GameFramework.Inventory Inventory { get; }
        public bool IsInitialized { get; set; }
        public bool EnableHitPointsRegeneration { get; set; }
        public uint Level { get; }
        public float HitPoints { get; }
        public static float XpGrowRate { get; set; }
        public static float XpRisePower { get; set; }
        public uint XP { get; set; }
        public float ActualHitPoints { get; set; }
        public TzarGames.GameFramework.Characteristic HitPointsCharacteristic { get; }
        public float HitPointsRegenerationSpeed { get; }
        public TzarGames.GameFramework.Characteristic HitPointsRegenerationSpeedCharacteristic { get; }
        public float Damage { get; }
        public TzarGames.GameFramework.Characteristic DamageCharacteristic { get; }
        public float AttackSpeed { get; }
        public TzarGames.GameFramework.Characteristic AttackSpeedCharacteristic { get; }
        public float WalkingSpeed { get; }
        public TzarGames.GameFramework.Characteristic WalkingSpeedCharacteristic { get; }
        public float Defence { get; }
        public TzarGames.GameFramework.Characteristic DefenceCharacteristic { get; }
        public float XpRate { get; }
        public TzarGames.GameFramework.Characteristic XpRateCharacteristic { get; }
        public float CritChance { get; }
        public TzarGames.GameFramework.Characteristic CritChanceCharacteristic { get; }
        public float CritMultiplier { get; }
        public TzarGames.GameFramework.Characteristic CritMultiplierCharacteristic { get; }
        
        // Methods
        public CharacterTemplate()
        {
            var val_2;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt val_3;
            var val_5;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt val_6;
            this.characterName = "Unknown character";
            CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  0);
            mem[1152921511298882416] = val_2;
            this._level = val_3;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  0);
            mem[1152921511298882436] = val_5;
            this.xp = val_6;
            this.hitPoints = new TzarGames.GameFramework.Characteristic();
            this.hitPointsRegenerationSpeed = new TzarGames.GameFramework.Characteristic();
            this.damage = new TzarGames.GameFramework.Characteristic();
            this.attackSpeed = new TzarGames.GameFramework.Characteristic();
            this.defence = new TzarGames.GameFramework.Characteristic();
            this.walkingSpeed = new TzarGames.GameFramework.Characteristic();
            this.xpRate = new TzarGames.GameFramework.Characteristic();
            this.critChance = new TzarGames.GameFramework.Characteristic();
            this.critMultiplier = new TzarGames.GameFramework.Characteristic();
            this.defenceCoefficient = 0.1f;
            this.walkingSpeedCoefficient = 0.1f;
            this.hitPointsCoefficient = val_6;
            this.critMultiplierCoefficient = 0.1f;
            this.enableHitPointRegeneration = true;
            this.enableUpdateStats = true;
            this.actualHitPoints = new TzarGames.GameFramework.Characteristic();
            this.inventory = new TzarGames.GameFramework.Inventory();
            this = new UnityEngine.ScriptableObject();
        }
        public string get_CharacterName()
        {
            return (string)this.characterName;
        }
        public void set_CharacterName(string value)
        {
            this.characterName = value;
        }
        public TzarGames.GameFramework.CharacterGroup get_Group()
        {
            return (TzarGames.GameFramework.CharacterGroup)this.group;
        }
        public void set_Group(TzarGames.GameFramework.CharacterGroup value)
        {
            this.group = value;
        }
        public override string ToString()
        {
            return (string)this.characterName;
        }
        public override int get_Id()
        {
            return (int)this.id;
        }
        public override void set_Id(int value)
        {
            this.id = value;
        }
        public void add_OnXpChanged(System.Action<TzarGames.GameFramework.CharacterTemplate, int> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnXpChanged);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511299831808 != this.OnXpChanged);
        
        }
        public void remove_OnXpChanged(System.Action<TzarGames.GameFramework.CharacterTemplate, int> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnXpChanged);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511299968384 != this.OnXpChanged);
        
        }
        public void add_OnLevelUp(TzarGames.GameFramework.CharacterTemplate.CharacterTemplateDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnLevelUp);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511300104968 != this.OnLevelUp);
        
        }
        public void remove_OnLevelUp(TzarGames.GameFramework.CharacterTemplate.CharacterTemplateDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnLevelUp);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511300241544 != this.OnLevelUp);
        
        }
        public TzarGames.GameFramework.Inventory get_Inventory()
        {
            return (TzarGames.GameFramework.Inventory)this.inventory;
        }
        public bool HasTag(string tag)
        {
            var val_6;
            var val_7;
            val_6 = 0;
            label_6:
            if(val_6 >= this.tags.Count)
            {
                goto label_2;
            }
            
            val_6 = val_6 + 1;
            if((this.tags.Item[0].Name.Equals(value:  tag)) == false)
            {
                goto label_6;
            }
            
            val_7 = 1;
            return (bool)val_7;
            label_2:
            val_7 = 0;
            return (bool)val_7;
        }
        public virtual void Initialize()
        {
            var val_1;
            this.hitPoints.Init();
            this.damage.Init();
            this.hitPointsRegenerationSpeed.Init();
            this.attackSpeed.Init();
            this.defence.Init();
            this.walkingSpeed.Init();
            this.actualHitPoints.Init();
            this.xpRate.Init();
            this.critChance.Init();
            this.critMultiplier.Init();
            this.<IsInitialized>k__BackingField = true;
            val_1 = null;
            val_1 = null;
            if(TzarGames.GameFramework.CharacterTemplate.xpTableInitialized != false)
            {
                    return;
            }
            
            TzarGames.GameFramework.CharacterTemplate.InitializeXpTable(force:  false);
        }
        public bool get_IsInitialized()
        {
            return (bool)this.<IsInitialized>k__BackingField;
        }
        private void set_IsInitialized(bool value)
        {
            this.<IsInitialized>k__BackingField = value;
        }
        public bool get_EnableHitPointsRegeneration()
        {
            return (bool)this.enableHitPointRegeneration;
        }
        public void set_EnableHitPointsRegeneration(bool value)
        {
            this.enableHitPointRegeneration = value;
        }
        public virtual void ResetTemplate()
        {
            var val_2;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt val_3;
            var val_5;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt val_6;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  0);
            mem[1152921511301323780] = val_2;
            this.xp = val_3;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  0);
            mem[1152921511301323760] = val_5;
            this._level = val_6;
            this.hitPoints.ClearAllModificators();
            this.hitPointsRegenerationSpeed.ClearAllModificators();
            this.damage.ClearAllModificators();
            this.attackSpeed.ClearAllModificators();
            this.defence.ClearAllModificators();
            this.walkingSpeed.ClearAllModificators();
            this.actualHitPoints.ClearAllModificators();
            this.xpRate.ClearAllModificators();
            this.critChance.ClearAllModificators();
            this.critMultiplier.ClearAllModificators();
        }
        protected virtual void setupModificators()
        {
            this.hitPoints.resetWhenModifiedToZero = true;
            this.hitPoints.resetValue = 0.01f;
            this.hitPoints.applyModificatorsWhenBaseIsLessOrEqualZero = false;
            this.actualHitPoints.resetWhenModifiedToZero = true;
            this.actualHitPoints.resetValue = 0.01f;
            this.actualHitPoints.applyModificatorsWhenBaseIsLessOrEqualZero = false;
            this.actualHitPoints.AllowTimeModificators = true;
            this.defence.AllowTimeModificators = true;
            this.defence.applyModificatorsWhenBaseIsLessOrEqualZero = true;
            this.xpRate.minValue = 0f;
            this.xpRate.resetValue = 1f;
            this.xpRate.applyModificatorsWhenBaseIsLessOrEqualZero = false;
            this.hitPointsRegenerationSpeed.resetWhenModifiedToZero = false;
            this.hitPointsRegenerationSpeed.applyModificatorsWhenBaseIsLessOrEqualZero = true;
            this.damage.resetWhenModifiedToZero = false;
            this.damage.applyModificatorsWhenBaseIsLessOrEqualZero = true;
            this.damage.clampMinimum = true;
            this.damage.minValue = 0f;
            this.attackSpeed.minValue = 0f;
            this.attackSpeed.clampMinimum = true;
            this.attackSpeed.applyModificatorsWhenBaseIsLessOrEqualZero = false;
            this.critChance.minValue = 0f;
            this.critChance.maxValue = 95f;
            this.critChance.clampMinimum = true;
            this.critChance.clampMaximum = true;
            this.critChance.applyModificatorsWhenBaseIsLessOrEqualZero = false;
            this.critMultiplier.minValue = 0f;
            this.critMultiplier.clampMinimum = true;
            this.critMultiplier.applyModificatorsWhenBaseIsLessOrEqualZero = false;
        }
        public virtual void Update()
        {
            if(this.enableUpdateStats == false)
            {
                    return;
            }
            
            this.damage.Update();
            this.hitPoints.Update();
            this.defence.Update();
            this.hitPointsRegenerationSpeed.Update();
            this.attackSpeed.Update();
            this.walkingSpeed.Update();
            this.actualHitPoints.Update();
            this.xpRate.Update();
            this.critChance.Update();
            this.critMultiplier.Update();
            if(this.enableHitPointRegeneration == false)
            {
                    return;
            }
            
            float val_3 = UnityEngine.Time.deltaTime;
            val_3 = this.HitPointsRegenerationSpeed * val_3;
            val_3 = this.actualHitPoints.Value + val_3;
            this.ActualHitPoints = val_3;
        }
        public uint get_Level()
        {
            return (uint)CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
        }
        public float get_HitPoints()
        {
            float val_1 = this.hitPoints.Value;
            float val_3 = (float)(double)CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
            val_3 = val_1 * val_3;
            val_3 = this.hitPointsCoefficient * val_3;
            val_3 = val_1 + val_3;
            return (float)val_3;
        }
        public static float get_XpGrowRate()
        {
            null = null;
            return (float)TzarGames.GameFramework.CharacterTemplate.MAX_TABLE_LEVEL;
        }
        public static void set_XpGrowRate(float value)
        {
            null = null;
            TzarGames.GameFramework.CharacterTemplate.MAX_TABLE_LEVEL = value;
        }
        public static float get_XpRisePower()
        {
            null = null;
            return (float)TzarGames.GameFramework.CharacterTemplate.xpPower;
        }
        public static void set_XpRisePower(float value)
        {
            null = null;
            TzarGames.GameFramework.CharacterTemplate.xpPower = value;
        }
        public static void InitializeXpTable(bool force = False)
        {
            var val_6;
            var val_7;
            var val_9;
            val_6 = W1;
            val_7 = null;
            val_7 = null;
            if(TzarGames.GameFramework.CharacterTemplate.xpTableInitialized != false)
            {
                    if((val_6 & 1) == 0)
            {
                    return;
            }
            
            }
            
            TzarGames.GameFramework.CharacterTemplate.xpSet.Clear();
            var val_1 = ((TzarGames.GameFramework.CharacterTemplate.__il2cppRuntimeField_10A & 1) != 0) ? 1 : 0;
            do
            {
                val_1 = val_1 & 1;
                TzarGames.GameFramework.CharacterTemplate.xpSet.Add(item:  TzarGames.GameFramework.CharacterTemplate.GetXpToLevel(level:  299892736));
                val_9 = null;
                val_6 = 0 + 1;
                var val_3 = ((TzarGames.GameFramework.CharacterTemplate.__il2cppRuntimeField_109 & 256) != 0) ? 1 : 0;
            }
            while(val_6 != 1000);
            
            val_9 = null;
            TzarGames.GameFramework.CharacterTemplate.xpTableInitialized = true;
        }
        public uint get_XP()
        {
            return (uint)CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
        }
        public void set_XP(uint value)
        {
            bool val_2;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt val_3;
            var val_15;
            var val_16;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  0);
            fakeValueActive = val_2;
            mem2[0] = val_3;
            uint val_4 = TzarGames.GameFramework.CharacterTemplate.GetLevelFromXp(xp:  299892736);
            val_2 = TzarGames.GameFramework.CharacterTemplate.__il2cppRuntimeField_cctor_finished;
            val_3 = this._level;
            if((CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {inited = true, fakeValue = 268435457, fakeValueActive = false})) == val_4)
            {
                    val_15 = 0;
            }
            else
            {
                    val_2 = this._level.fakeValueActive;
                val_3 = this._level.currentCryptoKey;
                var val_8 = (val_4 > 1000) ? 1000 : (val_4);
                CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt val_9 = CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  0);
                fakeValueActive = val_2;
                mem2[0] = val_3;
                this.ActualHitPoints = this.HitPoints;
            }
            
            val_2 = this.xp.fakeValueActive;
            val_3 = this.xp.currentCryptoKey;
            val_16 = CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
            if((val_16 != (CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {inited = true, fakeValue = 268435457, fakeValueActive = false}))) && (this.OnXpChanged != null))
            {
                    val_16;
                this.OnXpChanged.Invoke(arg1:  this, arg2:  this.xp - val_16);
            }
            
            if((((CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {inited = true, fakeValue = 268435457, fakeValueActive = false})) >= val_4) ? (-1) : 1) < 1)
            {
                    return;
            }
            
            if(this.OnLevelUp == null)
            {
                    return;
            }
            
            this.OnLevelUp.Invoke(template:  this);
        }
        public void ChangeXpBy(int amount)
        {
            uint val_9;
            if(amount == 0)
            {
                    return;
            }
            
            if(amount >= 1)
            {
                    uint val_1 = this.XP;
                val_9 = (((~val_1) >= (amount << )) ? amount : (!val_1)) + this.XP;
            }
            else
            {
                    int val_4 = UnityEngine.Mathf.Abs(value:  0);
                uint val_5 = this.XP;
                val_9 = this.XP - ((val_5 < val_4) ? (val_5) : (val_4));
            }
            
            this.XP = val_9;
        }
        public static uint GetXpForNextLevel(uint currentXp)
        {
            uint val_1 = TzarGames.GameFramework.CharacterTemplate.GetLevelFromXp(xp:  299892736);
            uint val_2 = val_1 + 1;
            return TzarGames.GameFramework.CharacterTemplate.GetXpToLevel(level:  val_1);
        }
        public static uint GetLevelFromXp(uint xp)
        {
            var val_11;
            int val_12;
            var val_13;
            System.Collections.Generic.List<System.UInt32> val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            val_11 = null;
            val_11 = null;
            int val_1 = TzarGames.GameFramework.CharacterTemplate.xpSet.Count;
            val_12 = ((val_1 < 0) ? (val_1 + 1) : (val_1)) >> 1;
            goto label_17;
            label_8:
            val_12 = ((TzarGames.GameFramework.CharacterTemplate.xpSet < 0) ? (TzarGames.GameFramework.CharacterTemplate.xpSet + 1) : TzarGames.GameFramework.CharacterTemplate.xpSet) >> 1;
            label_17:
            val_13 = null;
            val_13 = null;
            val_14 = TzarGames.GameFramework.CharacterTemplate.xpSet;
            val_15 = val_14.Item[val_12];
            if(val_15 > W1)
            {
                goto label_8;
            }
            
            if(val_15 >= W1)
            {
                goto label_9;
            }
            
            val_16 = null;
            val_16 = null;
            val_14 = val_12 + 1;
            if(val_14 < TzarGames.GameFramework.CharacterTemplate.xpSet.Count)
            {
                    val_17 = null;
                val_17 = null;
                val_15 = TzarGames.GameFramework.CharacterTemplate.xpSet.Item[val_14];
            }
            
            if(val_15 < W1)
            {
                goto label_17;
            }
            
            var val_7 = (val_15 <= W1) ? (val_14) : (val_12);
            return (uint)val_18;
            label_9:
            val_18 = val_12;
            return (uint)val_18;
        }
        public static uint GetXpToLevel(uint level)
        {
            null = null;
            float val_2 = (float)(double)W1 + 1;
            val_2 = (float)(double)W1 * val_2;
            val_2 = val_2 * TzarGames.GameFramework.CharacterTemplate.MAX_TABLE_LEVEL;
            return (uint)null;
        }
        public float GetXpProgressNormalized()
        {
            uint val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
            0 = null;
            uint val_2 = TzarGames.GameFramework.CharacterTemplate.GetXpToLevel(level:  299892736);
            float val_8 = (float)(double)(CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {inited = true, fakeValue = 268435457, fakeValueActive = false})) - val_2;
            val_8 = val_8 / ((float)(double)(TzarGames.GameFramework.CharacterTemplate.GetXpForNextLevel(currentXp:  CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {inited = true, fakeValue = 268435457, fakeValueActive = false}))) - val_2);
            return (float)val_8;
        }
        public float get_ActualHitPoints()
        {
            if(this.actualHitPoints != null)
            {
                    return this.actualHitPoints.Value;
            }
            
            return this.actualHitPoints.Value;
        }
        public void set_ActualHitPoints(float value)
        {
            this.actualHitPoints.Value = UnityEngine.Mathf.Clamp(value:  value, min:  -3.402823E+38f, max:  this.HitPoints);
        }
        public TzarGames.GameFramework.Characteristic get_HitPointsCharacteristic()
        {
            return (TzarGames.GameFramework.Characteristic)this.hitPoints;
        }
        public float get_HitPointsRegenerationSpeed()
        {
            float val_5 = this.hitPointRegenSpeedCoefficient;
            float val_4 = (float)(double)CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
            val_4 = this.hitPointsRegenerationSpeed.BaseValue * val_4;
            val_5 = val_5 * val_4;
            val_5 = this.hitPointsRegenerationSpeed.Value + val_5;
            return (float)val_5;
        }
        public TzarGames.GameFramework.Characteristic get_HitPointsRegenerationSpeedCharacteristic()
        {
            return (TzarGames.GameFramework.Characteristic)this.hitPointsRegenerationSpeed;
        }
        public float get_Damage()
        {
            float val_5 = this.damageCoefficient;
            float val_4 = (float)(double)CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
            val_4 = this.damage.BaseValue * val_4;
            val_5 = val_5 * val_4;
            val_5 = this.damage.Value + val_5;
            return (float)val_5;
        }
        public TzarGames.GameFramework.Characteristic get_DamageCharacteristic()
        {
            return (TzarGames.GameFramework.Characteristic)this.damage;
        }
        public float get_AttackSpeed()
        {
            float val_5 = this.attackSpeedCoefficient;
            float val_4 = (float)(double)CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
            val_4 = this.attackSpeed.BaseValue * val_4;
            val_5 = val_5 * val_4;
            val_5 = this.attackSpeed.Value + val_5;
            return (float)val_5;
        }
        public TzarGames.GameFramework.Characteristic get_AttackSpeedCharacteristic()
        {
            return (TzarGames.GameFramework.Characteristic)this.attackSpeed;
        }
        public float get_WalkingSpeed()
        {
            var val_4 = this;
            float val_1 = this.walkingSpeed.Value;
            if(System.Math.Abs(val_1) <= 0.0001f)
            {
                    return 0f;
            }
            
            float val_6 = this.walkingSpeedCoefficient;
            float val_5 = (float)(double)CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
            val_5 = this.walkingSpeed.BaseValue * val_5;
            val_6 = val_6 * val_5;
            val_6 = val_1 + val_6;
            return 0f;
        }
        public TzarGames.GameFramework.Characteristic get_WalkingSpeedCharacteristic()
        {
            return (TzarGames.GameFramework.Characteristic)this.walkingSpeed;
        }
        public float get_Defence()
        {
            float val_5 = this.defenceCoefficient;
            float val_4 = (float)(double)CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
            val_4 = this.defence.BaseValue * val_4;
            val_5 = val_5 * val_4;
            val_5 = this.defence.Value + val_5;
            return (float)val_5;
        }
        public TzarGames.GameFramework.Characteristic get_DefenceCharacteristic()
        {
            return (TzarGames.GameFramework.Characteristic)this.defence;
        }
        public float get_XpRate()
        {
            if(this.xpRate != null)
            {
                    return this.xpRate.Value;
            }
            
            return this.xpRate.Value;
        }
        public TzarGames.GameFramework.Characteristic get_XpRateCharacteristic()
        {
            return (TzarGames.GameFramework.Characteristic)this.xpRate;
        }
        public float get_CritChance()
        {
            TzarGames.GameFramework.Characteristic val_4;
            float val_5;
            float val_5 = this.critChanceCoefficient;
            float val_4 = (float)(double)CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
            val_4 = this.critChance.BaseValue * val_4;
            val_5 = val_5 * val_4;
            val_5 = this.critChance.Value + val_5;
            if(val_5 < 0)
            {
                    val_5 = this.critChance.minValue;
            }
            
            if(val_5 <= this.critChance.maxValue)
            {
                    return val_5;
            }
            
            val_4 = this.critChance;
            val_5 = this.critChance.maxValue;
            return val_5;
        }
        public TzarGames.GameFramework.Characteristic get_CritChanceCharacteristic()
        {
            return (TzarGames.GameFramework.Characteristic)this.critChance;
        }
        public float get_CritMultiplier()
        {
            float val_5 = this.critMultiplierCoefficient;
            float val_4 = (float)(double)CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
            val_4 = this.critMultiplier.BaseValue * val_4;
            val_5 = val_5 * val_4;
            val_5 = this.critMultiplier.Value + val_5;
            return (float)val_5;
        }
        public TzarGames.GameFramework.Characteristic get_CritMultiplierCharacteristic()
        {
            return (TzarGames.GameFramework.Characteristic)this.critMultiplier;
        }
        private static CharacterTemplate()
        {
            TzarGames.GameFramework.CharacterTemplate.MAX_TABLE_LEVEL = 1120403456;
            TzarGames.GameFramework.CharacterTemplate.xpPower = 1f;
            TzarGames.GameFramework.CharacterTemplate.xpSet = new System.Collections.Generic.List<System.UInt32>();
            TzarGames.GameFramework.CharacterTemplate.xpTableInitialized = false;
        }
    
    }

}

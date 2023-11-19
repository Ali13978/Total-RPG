using UnityEngine;
private class EndlessPlayerCharacterTemplate.SkillUpgrade : EndlessPlayerCharacterTemplate.ISkillUpgrade
{
    // Fields
    private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt cooldownUpgradeLevel;
    private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt commonUpgradeLevel;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private int <SkillId>k__BackingField;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private TzarGames.GameFramework.CharacteristicModificator <CommonModificator>k__BackingField;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private TzarGames.GameFramework.CharacteristicModificator <CooldownModificator>k__BackingField;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private TzarGames.Endless.EndlessPlayerCharacterTemplate <PlayerTemplate>k__BackingField;
    
    // Properties
    public int SkillId { get; set; }
    public TzarGames.GameFramework.CharacteristicModificator CommonModificator { get; set; }
    public TzarGames.GameFramework.CharacteristicModificator CooldownModificator { get; set; }
    public TzarGames.Endless.EndlessPlayerCharacterTemplate PlayerTemplate { get; set; }
    public int CooldownUpgradeLevel { get; set; }
    public int CommonUpgradeLevel { get; set; }
    
    // Methods
    public EndlessPlayerCharacterTemplate.SkillUpgrade(TzarGames.Endless.EndlessPlayerCharacterTemplate template, int skillId)
    {
        this.<PlayerTemplate>k__BackingField = template;
        this.<SkillId>k__BackingField = skillId;
    }
    public int get_SkillId()
    {
        return (int)this.<SkillId>k__BackingField;
    }
    private void set_SkillId(int value)
    {
        this.<SkillId>k__BackingField = value;
    }
    public TzarGames.GameFramework.CharacteristicModificator get_CommonModificator()
    {
        return (TzarGames.GameFramework.CharacteristicModificator)this.<CommonModificator>k__BackingField;
    }
    public void set_CommonModificator(TzarGames.GameFramework.CharacteristicModificator value)
    {
        this.<CommonModificator>k__BackingField = value;
    }
    public TzarGames.GameFramework.CharacteristicModificator get_CooldownModificator()
    {
        return (TzarGames.GameFramework.CharacteristicModificator)this.<CooldownModificator>k__BackingField;
    }
    public void set_CooldownModificator(TzarGames.GameFramework.CharacteristicModificator value)
    {
        this.<CooldownModificator>k__BackingField = value;
    }
    public TzarGames.Endless.EndlessPlayerCharacterTemplate get_PlayerTemplate()
    {
        return (TzarGames.Endless.EndlessPlayerCharacterTemplate)this.<PlayerTemplate>k__BackingField;
    }
    private void set_PlayerTemplate(TzarGames.Endless.EndlessPlayerCharacterTemplate value)
    {
        this.<PlayerTemplate>k__BackingField = value;
    }
    public int get_CooldownUpgradeLevel()
    {
        return (int)CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
    }
    public void set_CooldownUpgradeLevel(int value)
    {
        var val_3;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_4;
        int val_1 = UnityEngine.Mathf.Clamp(value:  0, min:  value, max:  0);
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
        mem[1152921510650620752] = val_3;
        this.cooldownUpgradeLevel = val_4;
        this.<CooldownModificator>k__BackingField.Value = this.GetCooldownUpgradeBonusForLevel(level:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {inited = true, fakeValue = 268435457, fakeValueActive = false}));
    }
    public int get_CommonUpgradeLevel()
    {
        return (int)CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
    }
    public void set_CommonUpgradeLevel(int value)
    {
        var val_3;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_4;
        int val_1 = UnityEngine.Mathf.Clamp(value:  0, min:  value, max:  0);
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
        mem[1152921510650852964] = val_3;
        this.commonUpgradeLevel = val_4;
        this.<CommonModificator>k__BackingField.Value = this.GetCommonUpgradeBonusForLevel(level:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {inited = true, fakeValue = 268435457, fakeValueActive = false}));
    }
    public float GetCommonUpgradeBonusForLevel(int level)
    {
        TzarGames.Endless.EndlessPlayerCharacterTemplate val_1 = (this.<PlayerTemplate>k__BackingField) + 568;
        float val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat() {hiddenValue = new CodeStage.AntiCheat.Common.ACTkByte4(), inited = false, fakeValueActive = false});
        val_2 = (float)level * val_2;
        val_2 = val_2 + 1f;
        return (float)val_2;
    }
    public float GetCooldownUpgradeBonusForLevel(int level)
    {
        TzarGames.Endless.EndlessPlayerCharacterTemplate val_1 = (this.<PlayerTemplate>k__BackingField) + 536;
        float val_4 = (float)level;
        val_4 = val_4 * (CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat() {hiddenValue = new CodeStage.AntiCheat.Common.ACTkByte4(), inited = false, fakeValueActive = false}));
        val_4 = 1f - val_4;
        return (float)UnityEngine.Mathf.Max(a:  val_4, b:  0f);
    }
    public void AddCooldownUpgrade(int levelAddition)
    {
        if((this.CanUpgradeCooldownByLevel(levelAddition:  levelAddition)) == false)
        {
                return;
        }
        
        if((this.<PlayerTemplate>k__BackingField.consumeUpgradePoint(pointCount:  levelAddition)) == false)
        {
                return;
        }
        
        this.CooldownUpgradeLevel = this.CooldownUpgradeLevel + levelAddition;
    }
    public void AddCommonUpgrade(int levelAddition)
    {
        if((this.CanUpgradeCommonByLevel(levelAddition:  levelAddition)) == false)
        {
                return;
        }
        
        if((this.<PlayerTemplate>k__BackingField.consumeUpgradePoint(pointCount:  levelAddition)) == false)
        {
                return;
        }
        
        this.CommonUpgradeLevel = this.CommonUpgradeLevel + levelAddition;
    }
    public bool CanUpgradeCommonByLevel(int levelAddition)
    {
        var val_5;
        if((this.CommonUpgradeLevel + levelAddition) <= 10)
        {
                long val_5 = this.<PlayerTemplate>k__BackingField.<ConsumedLevelUpgradePoints>k__BackingField;
            val_5 = (this.<PlayerTemplate>k__BackingField.Level) - val_5;
            val_5 = val_5 + (this.<PlayerTemplate>k__BackingField.<AdditionalUpgradePoints>k__BackingField);
            var val_4 = ((long)levelAddition <= val_5) ? 1 : 0;
            return (bool)val_5;
        }
        
        val_5 = 0;
        return (bool)val_5;
    }
    public bool CanUpgradeCooldownByLevel(int levelAddition)
    {
        var val_5;
        if((this.CooldownUpgradeLevel + levelAddition) <= 10)
        {
                long val_5 = this.<PlayerTemplate>k__BackingField.<ConsumedLevelUpgradePoints>k__BackingField;
            val_5 = (this.<PlayerTemplate>k__BackingField.Level) - val_5;
            val_5 = val_5 + (this.<PlayerTemplate>k__BackingField.<AdditionalUpgradePoints>k__BackingField);
            var val_4 = ((long)levelAddition <= val_5) ? 1 : 0;
            return (bool)val_5;
        }
        
        val_5 = 0;
        return (bool)val_5;
    }
    public int GetRequiredPointsToUpgdateCommon(int levelAddition)
    {
        return (int)levelAddition;
    }
    public int GetRequiredPointsToUpgdateCooldown(int levelAddition)
    {
        return (int)levelAddition;
    }

}

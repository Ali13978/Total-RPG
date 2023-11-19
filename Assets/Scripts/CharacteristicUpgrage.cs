using UnityEngine;
[Serializable]
private class EndlessPlayerCharacterTemplate.CharacteristicUpgrage : EndlessPlayerCharacterTemplate.ICharacteristicUpgrade
{
    // Fields
    public TzarGames.Endless.EndlessPlayerCharacterTemplate PlayerTemplate;
    private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt upgradeLevel;
    [UnityEngine.SerializeField]
    private CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat UpgradeCoefficient;
    public TzarGames.GameFramework.CharacteristicModificator Modificator;
    
    // Properties
    public int UpgradeLevel { get; set; }
    
    // Methods
    public EndlessPlayerCharacterTemplate.CharacteristicUpgrage()
    {
        var val_2;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_3;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  1f);
        mem[1152921510651955168] = val_2;
        this.UpgradeCoefficient = val_3;
        if(null != 0)
        {
                Value = 0f;
            typeof(TzarGames.GameFramework.CharacteristicModificator).__il2cppRuntimeField_10 = 0;
        }
        else
        {
                Value = 0f;
            mem[16] = 0;
        }
        
        typeof(TzarGames.GameFramework.CharacteristicModificator).__il2cppRuntimeField_18 = 0;
        this.Modificator = new TzarGames.GameFramework.CharacteristicModificator();
    }
    public int get_UpgradeLevel()
    {
        return (int)CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
    }
    public void set_UpgradeLevel(int value)
    {
        var val_2;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
        mem[1152921510652220088] = val_2;
        this.upgradeLevel = val_3;
    }
    public float GetBonusValueForLevel(int level)
    {
        float val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat() {hiddenValue = new CodeStage.AntiCheat.Common.ACTkByte4(), inited = false, fakeValueActive = false});
        val_1 = (float)level * val_1;
        return (float)val_1;
    }
    public bool CanUpgradeCharacteristicByLevel(int upgradeLevel)
    {
        return this.canUpgradeCharacteristic(requiredPoints:  upgradeLevel, level:  upgradeLevel);
    }
    public int GetRequiredPointsForUpgrade(int upgradeLevel)
    {
        return (int)upgradeLevel;
    }
    public bool AddUpgrade(int level)
    {
        var val_4;
        if((this.canUpgradeCharacteristic(requiredPoints:  level, level:  level)) != false)
        {
                bool val_3 = this.upgradeCharacteristic(requiredPoints:  level, level:  level, coeff:  CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat() {hiddenValue = new CodeStage.AntiCheat.Common.ACTkByte4(), inited = false, fakeValueActive = false}));
            val_4 = 1;
            return (bool)val_4;
        }
        
        val_4 = 0;
        return (bool)val_4;
    }
    private bool canUpgradeCharacteristic(int requiredPoints, int level)
    {
        var val_5;
        long val_5 = this.PlayerTemplate.<ConsumedLevelUpgradePoints>k__BackingField;
        val_5 = this.PlayerTemplate.Level - val_5;
        val_5 = val_5 + (this.PlayerTemplate.<AdditionalUpgradePoints>k__BackingField);
        if(val_5 >= (requiredPoints << ))
        {
                return (bool)((this.UpgradeLevel + level) < 11) ? 1 : 0;
        }
        
        val_5 = 0;
        return (bool)((this.UpgradeLevel + level) < 11) ? 1 : 0;
    }
    private bool upgradeCharacteristic(int requiredPoints, int level, float coeff)
    {
        var val_4;
        if((this.PlayerTemplate.consumeUpgradePoint(pointCount:  requiredPoints)) != false)
        {
                this.UpgradeLevel = this.UpgradeLevel + level;
            this.Update();
            val_4 = 1;
            return (bool)val_4;
        }
        
        val_4 = 0;
        return (bool)val_4;
    }
    public void Update()
    {
        this.Modificator.Value = this.GetBonusValueForLevel(level:  this.UpgradeLevel);
    }

}

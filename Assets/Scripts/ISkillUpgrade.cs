using UnityEngine;
public interface EndlessPlayerCharacterTemplate.ISkillUpgrade
{
    // Properties
    public abstract int SkillId { get; }
    public abstract int CooldownUpgradeLevel { get; }
    public abstract int CommonUpgradeLevel { get; }
    
    // Methods
    public abstract int get_SkillId(); // 0
    public abstract int get_CooldownUpgradeLevel(); // 0
    public abstract int get_CommonUpgradeLevel(); // 0
    public abstract void AddCooldownUpgrade(int levelAddition); // 0
    public abstract void AddCommonUpgrade(int levelAddition); // 0
    public abstract bool CanUpgradeCommonByLevel(int levelAddition); // 0
    public abstract bool CanUpgradeCooldownByLevel(int levelAddition); // 0
    public abstract int GetRequiredPointsToUpgdateCommon(int levelAddition); // 0
    public abstract int GetRequiredPointsToUpgdateCooldown(int levelAddition); // 0
    public abstract float GetCommonUpgradeBonusForLevel(int level); // 0
    public abstract float GetCooldownUpgradeBonusForLevel(int level); // 0

}

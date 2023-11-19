using UnityEngine;
public interface EndlessPlayerCharacterTemplate.ICharacteristicUpgrade
{
    // Properties
    public abstract int UpgradeLevel { get; }
    
    // Methods
    public abstract bool CanUpgradeCharacteristicByLevel(int upgradeLevel); // 0
    public abstract int GetRequiredPointsForUpgrade(int upgradeLevel); // 0
    public abstract bool AddUpgrade(int level); // 0
    public abstract int get_UpgradeLevel(); // 0
    public abstract float GetBonusValueForLevel(int level); // 0

}

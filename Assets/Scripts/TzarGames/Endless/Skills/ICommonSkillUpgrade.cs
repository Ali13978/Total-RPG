using UnityEngine;

namespace TzarGames.Endless.Skills
{
    public interface ICommonSkillUpgrade
    {
        // Properties
        public abstract TzarGames.GameFramework.CharacteristicModificator Modificator { get; }
        
        // Methods
        public abstract TzarGames.GameFramework.CharacteristicModificator get_Modificator(); // 0
        public abstract string GetUpgradeLabelWithBonus(float bonus); // 0
    
    }

}

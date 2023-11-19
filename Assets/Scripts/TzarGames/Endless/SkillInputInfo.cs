using UnityEngine;

namespace TzarGames.Endless
{
    [Serializable]
    internal class SkillInputInfo
    {
        // Fields
        public string ButtonName;
        public TzarGames.TzarHero.Skills.CharacterSkill Skill;
        
        // Methods
        public SkillInputInfo()
        {
            this.ButtonName = "Skill name";
        }
    
    }

}

using UnityEngine;

namespace TzarGames.GameFramework.Skills
{
    public class SkillAttachPoints : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Skills.Skill skill;
        public UnityEngine.Transform[] Points;
        
        // Properties
        public TzarGames.GameFramework.Skills.Skill Skill { get; }
        
        // Methods
        public SkillAttachPoints()
        {
        
        }
        public TzarGames.GameFramework.Skills.Skill get_Skill()
        {
            return (TzarGames.GameFramework.Skills.Skill)this.skill;
        }
    
    }

}

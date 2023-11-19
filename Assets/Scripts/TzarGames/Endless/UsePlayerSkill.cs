using UnityEngine;

namespace TzarGames.Endless
{
    public class UsePlayerSkill : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.Skills.CharacterSkill defaultSkill;
        
        // Methods
        public UsePlayerSkill()
        {
        
        }
        public void SetDefaultSkill(TzarGames.TzarHero.Skills.CharacterSkill skill)
        {
            this.defaultSkill = skill;
        }
        public void UseDefaultSkill()
        {
            this.Use(skill:  this.defaultSkill);
        }
        public void Use(TzarGames.TzarHero.Skills.CharacterSkill skill)
        {
            TzarGames.Endless.PlayerCharacter val_1 = TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter;
            if(0 == val_1)
            {
                    return;
            }
            
            bool val_4 = val_1.UseSkill(skill:  skill);
        }
    
    }

}

using UnityEngine;

namespace TzarGames.TzarHero.Skills
{
    public class UseCharacterSkill : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.TH_Character character;
        
        // Methods
        public UseCharacterSkill()
        {
        
        }
        public void UseSkill(TzarGames.TzarHero.Skills.CharacterSkill skill)
        {
            if(0 == this.character)
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            bool val_2 = this.character.UseSkill(skill:  skill);
        }
    
    }

}

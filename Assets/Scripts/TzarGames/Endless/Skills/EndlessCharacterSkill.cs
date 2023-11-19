using UnityEngine;

namespace TzarGames.Endless.Skills
{
    public class EndlessCharacterSkill : CharacterSkill
    {
        // Methods
        public EndlessCharacterSkill()
        {
        
        }
        protected override void OnStarted()
        {
            this.OnStarted();
            if(this.Character == null)
            {
                    return;
            }
        
        }
    
    }

}

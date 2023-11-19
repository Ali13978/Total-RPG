using UnityEngine;

namespace TzarGames.TzarHero
{
    public class ModificatorGroupHandler : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.ModificatorGroup modificators;
        
        // Methods
        public ModificatorGroupHandler()
        {
        
        }
        public void ApplyToCharacter(TzarGames.TzarHero.TH_Character character)
        {
            if(0 == character)
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            this.modificators.ApplyToTemplate(template:  character.TemplateInstance);
        }
        public void RemoveFromCharacter(TzarGames.TzarHero.TH_Character character)
        {
            if(0 == character)
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            this.modificators.RemoveFromTemplate(template:  character.TemplateInstance);
        }
    
    }

}

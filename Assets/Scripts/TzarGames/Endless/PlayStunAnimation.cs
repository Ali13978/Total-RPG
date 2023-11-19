using UnityEngine;

namespace TzarGames.Endless
{
    public class PlayStunAnimation : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.TH_Character character;
        [UnityEngine.SerializeField]
        private string animName;
        
        // Methods
        public PlayStunAnimation()
        {
        
        }
        private void Reset()
        {
            this.character = this.GetComponent<TzarGames.TzarHero.TH_Character>();
        }
        private void Start()
        {
            this.character.add_OnStun(value:  new TH_Character.dlgCharacterEvent(object:  this, method:  System.Void TzarGames.Endless.PlayStunAnimation::CharacterOnOnStun(TzarGames.TzarHero.TH_Character character)));
            this.character.add_OnExitFromStun(value:  new TH_Character.dlgCharacterEvent(object:  this, method:  System.Void TzarGames.Endless.PlayStunAnimation::CharacterOnOnExitFromStun(TzarGames.TzarHero.TH_Character character)));
        }
        private void CharacterOnOnExitFromStun(TzarGames.TzarHero.TH_Character character)
        {
            if(character.Animation == null)
            {
                
            }
        
        }
        private void OnDestroy()
        {
            if(0 == this.character)
            {
                    return;
            }
            
            this.character.remove_OnStun(value:  new TH_Character.dlgCharacterEvent(object:  this, method:  System.Void TzarGames.Endless.PlayStunAnimation::CharacterOnOnStun(TzarGames.TzarHero.TH_Character character)));
            this.character.remove_OnExitFromStun(value:  new TH_Character.dlgCharacterEvent(object:  this, method:  System.Void TzarGames.Endless.PlayStunAnimation::CharacterOnOnExitFromStun(TzarGames.TzarHero.TH_Character character)));
        }
        private void CharacterOnOnStun(TzarGames.TzarHero.TH_Character character)
        {
            if(character.Animation == null)
            {
                
            }
        
        }
    
    }

}

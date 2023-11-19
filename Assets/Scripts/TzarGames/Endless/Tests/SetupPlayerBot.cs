using UnityEngine;

namespace TzarGames.Endless.Tests
{
    public class SetupPlayerBot : MonoBehaviour
    {
        // Methods
        public SetupPlayerBot()
        {
        
        }
        private void Start()
        {
        
        }
        public void SetPlayerCharacterFromOwner(TzarGames.GameFramework.Player player)
        {
            var val_2 = 0;
            this.setupCharacter(playerCharacter:  null);
        }
        private void setupCharacter(TzarGames.Endless.PlayerCharacterBase playerCharacter)
        {
            UnityEngine.Object val_6;
            if(this.enabled == false)
            {
                    return;
            }
            
            val_6 = playerCharacter.GetComponent<TzarGames.Endless.EndlessEnemyAI>();
            if(0 == val_6)
            {
                    val_6 = playerCharacter.gameObject.AddComponent<TzarGames.Endless.EndlessEnemyAI>();
            }
            
            val_6.SetControlledCharacter(character:  playerCharacter);
        }
    
    }

}

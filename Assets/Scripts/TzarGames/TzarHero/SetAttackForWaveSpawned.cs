using UnityEngine;

namespace TzarGames.TzarHero
{
    public class SetAttackForWaveSpawned : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.TH_Character target;
        
        // Methods
        public SetAttackForWaveSpawned()
        {
        
        }
        public void AttackCharacterBySpawnedCharacter(TzarGames.GameFramework.TzarBehaviour spawnedObject)
        {
            if(spawnedObject == null)
            {
                    return;
            }
        
        }
    
    }

}

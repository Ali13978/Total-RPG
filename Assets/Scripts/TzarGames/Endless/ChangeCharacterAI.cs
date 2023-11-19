using UnityEngine;

namespace TzarGames.Endless
{
    public class ChangeCharacterAI : MonoBehaviour
    {
        // Fields
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private TzarGames.Endless.EndlessAiBehaviourType aiType;
        [UnityEngine.SerializeField]
        private bool changeRadius;
        [UnityEngine.SerializeField]
        private float radius;
        [UnityEngine.SerializeField]
        private UnityEngine.Transform defendPoint;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.CharacterAI.AiBehaviour aiBehaviour;
        
        // Methods
        public ChangeCharacterAI()
        {
            this.radius = 5f;
        }
        public void ChangeForCharacter(TzarGames.GameFramework.TzarBehaviour tzarBehaviour)
        {
            var val_4;
            bool val_5;
            if(tzarBehaviour == null)
            {
                    return;
            }
            
            val_4 = tzarBehaviour.GetComponent<TzarGames.Endless.EndlessEnemyAI>();
            val_1.aiType = this.aiType;
            val_1.targetCharacter = 0;
            if(val_1.isGoingToDefendPosition != false)
            {
                    val_1.isGoingToDefendPosition = false;
            }
            
            if(this.aiType == 2)
            {
                    val_1.defendPosition = this.defendPoint;
                val_5 = this.changeRadius;
            }
            else
            {
                    val_5 = this.aiType >> 32;
            }
            
            val_5 = val_5 & 255;
            if(val_5 != 0)
            {
                    val_1.radius = this.radius;
            }
            
            TzarGames.TzarHero.CharacterAI val_2 = tzarBehaviour.GetComponent<TzarGames.TzarHero.CharacterAI>();
            if(0 == val_2)
            {
                    return;
            }
            
            val_2.Behaviour = this.aiBehaviour;
        }
    
    }

}

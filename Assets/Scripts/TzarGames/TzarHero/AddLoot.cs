using UnityEngine;

namespace TzarGames.TzarHero
{
    public class AddLoot : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.TH_Character character;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Loot[] loots;
        
        // Methods
        public AddLoot()
        {
        
        }
        private void Reset()
        {
            this.character = this.GetComponent<TzarGames.TzarHero.TH_Character>();
        }
        private void Start()
        {
            goto label_0;
            label_7:
            X21.AddLoot(loot:  X20);
            0 = 1;
            label_0:
            if(0 >= this.loots.Length)
            {
                    return;
            }
            
            TzarGames.GameFramework.Loot val_2 = this.loots[1];
            if(this.character.TemplateInstance != null)
            {
                goto label_7;
            }
            
            goto label_7;
        }
    
    }

}

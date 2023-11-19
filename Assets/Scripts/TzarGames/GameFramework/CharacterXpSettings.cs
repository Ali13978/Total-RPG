using UnityEngine;

namespace TzarGames.GameFramework
{
    public class CharacterXpSettings : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private bool changeXpGrowRate;
        [UnityEngine.SerializeField]
        private float xpGrowRate;
        [UnityEngine.SerializeField]
        private bool changeXpRisePower;
        [UnityEngine.SerializeField]
        private float xpRisePower;
        
        // Methods
        public CharacterXpSettings()
        {
            this.changeXpGrowRate = true;
            this.xpGrowRate = 100f;
            this.changeXpRisePower = true;
            this.xpRisePower = 1f;
        }
        private void Awake()
        {
            float val_1;
            if(this.changeXpGrowRate != false)
            {
                    val_1 = this.xpGrowRate;
                TzarGames.GameFramework.CharacterTemplate.XpGrowRate = val_1;
            }
            
            if(this.changeXpRisePower != false)
            {
                    val_1 = this.xpRisePower;
                TzarGames.GameFramework.CharacterTemplate.XpRisePower = val_1;
            }
            
            TzarGames.GameFramework.CharacterTemplate.InitializeXpTable(force:  false);
        }
    
    }

}

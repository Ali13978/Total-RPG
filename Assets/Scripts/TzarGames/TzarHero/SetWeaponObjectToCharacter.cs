using UnityEngine;

namespace TzarGames.TzarHero
{
    public class SetWeaponObjectToCharacter : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.TH_Character targetCharacter;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.WeaponObject weaponObject;
        [UnityEngine.SerializeField]
        private bool melee;
        
        // Methods
        public SetWeaponObjectToCharacter()
        {
        
        }
        private void Reset()
        {
            this.targetCharacter = this.GetComponent<TzarGames.TzarHero.TH_Character>();
        }
        private void Start()
        {
            var val_3;
            if(this.melee != false)
            {
                    val_3 = this.targetCharacter.MeleeCombatSystem;
                val_1.WeaponObject = this.weaponObject;
                return;
            }
            
            val_3 = this.targetCharacter.RangeCombatSystem;
            val_2.WeaponObject = this.weaponObject;
        }
    
    }

}

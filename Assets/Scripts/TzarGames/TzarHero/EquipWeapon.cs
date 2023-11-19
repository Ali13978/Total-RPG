using UnityEngine;

namespace TzarGames.TzarHero
{
    public class EquipWeapon : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Weapon weaponTemplate;
        [UnityEngine.SerializeField]
        private int slot;
        
        // Methods
        public EquipWeapon()
        {
        
        }
        public void EquipWeaponOnCharacter(TzarGames.TzarHero.TH_Character character)
        {
            TzarGames.TzarHero.EquipWeapon.CreateWeaponInstanceAndEquipOnCharacter(weaponTemplate:  this, slot:  this.weaponTemplate, character:  this.slot);
        }
        public static void CreateWeaponInstanceAndEquipOnCharacter(TzarGames.GameFramework.Weapon weaponTemplate, int slot, TzarGames.TzarHero.TH_Character character)
        {
            if((X3.GetActiveWeaponInstance(slot:  character)) != null)
            {
                    TzarGames.TzarHero.TH_CharacterTemplate val_2 = X3.TemplateInstance;
            }
            
            TzarGames.GameFramework.ItemInstance val_3 = slot.CreateItemInstance();
            X3.TemplateInstance.Inventory.DefaultBag.AddNonconsumableItem(itemInstance:  val_3);
            if(X3 != 0)
            {
                    X3.SetActiveWeaponInstance(weaponInstance:  val_3, slot:  character);
            }
            else
            {
                    0.SetActiveWeaponInstance(weaponInstance:  val_3, slot:  character);
            }
            
            if(X3.TemplateInstance == null)
            {
                
            }
        
        }
    
    }

}

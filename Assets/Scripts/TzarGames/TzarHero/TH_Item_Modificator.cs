using UnityEngine;

namespace TzarGames.TzarHero
{
    public class TH_Item_Modificator : TH_Item, IUsableByCharacter
    {
        // Methods
        public TH_Item_Modificator()
        {
            val_1 = new TzarGames.GameFramework.Item();
        }
        public bool ApplyToCharacter(TzarGames.TzarHero.TH_Character character)
        {
            X19.ApplyToTemplate(template:  character.characterTemplateInstance);
            return true;
        }
        public bool MustBeDestroyedAfterUse()
        {
            return true;
        }
        public override bool CanBeStoredInInventory()
        {
            return false;
        }
    
    }

}

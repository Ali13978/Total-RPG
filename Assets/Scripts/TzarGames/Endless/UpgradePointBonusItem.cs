using UnityEngine;

namespace TzarGames.Endless
{
    public class UpgradePointBonusItem : TH_Item, IUsableByCharacter
    {
        // Fields
        [UnityEngine.SerializeField]
        private int points;
        
        // Methods
        public UpgradePointBonusItem()
        {
            this.points = 1;
        }
        public bool ApplyToCharacter(TzarGames.TzarHero.TH_Character character)
        {
            int val_2;
            var val_3;
            val_2 = this;
            if(character != null)
            {
                    val_2 = this.points;
                character.PlayerTemplateInstance.AddAdditionalUpgradePoint(pointCount:  val_2);
                val_3 = 1;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        public bool MustBeDestroyedAfterUse()
        {
            return true;
        }
        public override bool CanBeStoredInInventory()
        {
            return true;
        }
    
    }

}

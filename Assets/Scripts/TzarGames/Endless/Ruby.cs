using UnityEngine;

namespace TzarGames.Endless
{
    public class Ruby : TH_Item, IUsableByCharacter
    {
        // Methods
        public Ruby()
        {
        
        }
        public bool ApplyToCharacter(TzarGames.TzarHero.TH_Character character)
        {
            var val_4;
            var val_5;
            if(character != null)
            {
                    TzarGames.GameFramework.GameManager val_1 = TzarGames.GameFramework.GameManager.Instance;
                if(val_1 != null)
            {
                    val_4 = null;
            }
            
                if(val_1 != null)
            {
                    val_4 = null;
            }
            
                val_5 = 1;
                AddRubyToPlayer(player:  character.PlayerOwner, count:  1);
                return (bool)val_5;
            }
            
            val_5 = 0;
            return (bool)val_5;
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

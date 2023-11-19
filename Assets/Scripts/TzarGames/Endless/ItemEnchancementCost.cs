using UnityEngine;

namespace TzarGames.Endless
{
    public class ItemEnchancementCost
    {
        // Fields
        public int Gold;
        public int HammerCount;
        public int RubyCostForHammerDiscount;
        public int HammerCountWithDiscount;
        
        // Methods
        public ItemEnchancementCost()
        {
        
        }
        public bool OnlyGoldRequired()
        {
            if(this.HammerCount != 0)
            {
                    return false;
            }
            
            int val_4 = this.RubyCostForHammerDiscount;
            val_4 = val_4 >> 32;
            return (bool)((val_4 == 0) ? 1 : 0) & ((val_4 == 0) ? 1 : 0);
        }
    
    }

}

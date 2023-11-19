using UnityEngine;

namespace SA.IOSNative.StoreKit
{
    public static class SK_Util
    {
        // Methods
        public static float GetPriceByTier(SA.IOSNative.StoreKit.PriceTier priceTier)
        {
            var val_3;
            var val_1 = W1 + 1;
            float val_3 = (float)val_1;
            if(val_1 <= 50)
            {
                    val_3 = val_3 + (-0.01f);
                return (float)val_3;
            }
            
            if(val_1 <= 60)
            {
                    val_3 = val_3 + (-50f);
                val_3 = val_3 * 5f;
                val_3 = val_3 + 50f;
                val_3 = val_3 + (-0.01f);
                return (float)val_3;
            }
            
            if((W1 - 60) <= 26)
            {
                    val_3 = mem[25809168 + ((W1 - 60)) << 2];
                val_3 = 25809168 + ((W1 - 60)) << 2;
            }
            else
            {
                    val_3 = 0;
            }
            
            if((0 & 1) == 0)
            {
                    return 0f;
            }
            
            return 0f;
        }
    
    }

}

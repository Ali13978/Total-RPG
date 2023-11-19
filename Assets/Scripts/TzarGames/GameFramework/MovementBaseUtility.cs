using UnityEngine;

namespace TzarGames.GameFramework
{
    public static class MovementBaseUtility
    {
        // Methods
        public static bool UseRelativePosition(TzarGames.GameFramework.UPrimitiveComponent MovementBase)
        {
            return TzarGames.GameFramework.MovementBaseUtility.IsDynamicBase(MovementBase:  MovementBase);
        }
        public static bool IsDynamicBase(TzarGames.GameFramework.UPrimitiveComponent MovementBase)
        {
            var val_3;
            if(0 != X1)
            {
                    var val_2 = ((X1 + 24) == 2) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
    
    }

}

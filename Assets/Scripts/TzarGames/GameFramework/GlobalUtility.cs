using UnityEngine;

namespace TzarGames.GameFramework
{
    public static class GlobalUtility
    {
        // Fields
        public const float MAXPOSITIONERRORSQUARED = 0.03;
        public const float MAXCLIENTUPDATEINTERVAL = 0.25;
        public const bool ClientAuthorativePosition = False;
        public const float CLIENTADJUSTUPDATECOST = 180;
        public const float CurrentNetSpeed = 2600;
        
        // Methods
        public static bool ExceedsAllowablePositionError(UnityEngine.Vector3 LocDiff)
        {
            return (bool)((UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = LocDiff.x, y = LocDiff.y, z = LocDiff.z}, rhs:  new UnityEngine.Vector3() {x = LocDiff.x, y = LocDiff.y, z = LocDiff.z})) > 0.03f) ? 1 : 0;
        }
        public static bool WithinUpdateDelayBounds(float LastUpdateTime)
        {
            double val_1 = TzarGames.GameFramework.GameManagerNetSyncBase.NetworkTime;
            val_1 = val_1 - (double)LastUpdateTime;
            return (bool)(val_1 < 0) ? 1 : 0;
        }
        public static string LogVector3(UnityEngine.Vector3 vec)
        {
            return (string)System.String.Format(format:  0, arg0:  "{0},{1},{2}", arg1:  vec.x, arg2:  vec.y);
        }
    
    }

}

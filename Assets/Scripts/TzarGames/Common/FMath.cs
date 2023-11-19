using UnityEngine;

namespace TzarGames.Common
{
    internal static class FMath
    {
        // Fields
        public const float SMALL_NUMBER = 1E-08;
        public const float KINDA_SMALL_NUMBER = 0.0001;
        public const float BIG_NUMBER = 3.4E+38;
        public const float EULERS_NUMBER = 2.718282;
        
        // Properties
        public static float PI { get; }
        public static int INDEX_NONE { get; }
        
        // Methods
        public static float Fmod(float x, float y)
        {
            float val_5 = y;
            float val_4 = (float)(int)x / (int)val_5;
            val_4 = val_4 * val_5;
            val_5 = System.Math.Abs(x) - val_4;
            float val_2 = UnityEngine.Mathf.Sign(f:  x);
            val_2 = val_5 * val_2;
            return (float)val_2;
        }
        public static bool IsZero(UnityEngine.Vector3 vector)
        {
            var val_1 = (vector.x == 0f) ? 1 : 0;
            val_1 = val_1 & ((vector.y == 0f) ? 1 : 0);
            return (bool)((vector.z == 0f) ? 1 : 0) & val_1;
        }
        public static float get_PI()
        {
            return 3.141593f;
        }
        public static int get_INDEX_NONE()
        {
            return 0;
        }
        public static UnityEngine.Vector3 SafeNormalPrecise(UnityEngine.Vector3 V)
        {
            float val_7;
            if(V.x < 0)
            {
                    UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
                return new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            }
            
            if(S12 >= _TYPE_MAX_)
            {
                    val_7 = V.x;
            }
            
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = V.x, y = V.y, z = V.z}, d:  1f / val_7);
            return new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        public static UnityEngine.Vector3 ClampMaxSizePrecise(UnityEngine.Vector3 V, float MaxSize)
        {
            float val_4;
            float val_8;
            float val_9;
            float val_10;
            float val_11;
            val_4 = 0.0001f;
            if(MaxSize < 0)
            {
                    UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            }
            else
            {
                    val_8 = V.x;
                val_9 = V.y;
                val_10 = V.z;
                if(val_4 <= (MaxSize * MaxSize))
            {
                    return new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_10};
            }
            
                if(S13 >= _TYPE_MAX_)
            {
                    val_11 = val_4;
            }
            
                MaxSize = MaxSize / val_11;
                val_4 = val_8;
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4, y = val_9, z = val_10}, d:  MaxSize);
            }
            
            val_8 = val_3.x;
            val_9 = val_3.y;
            val_10 = val_3.z;
            return new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_10};
        }
        public static UnityEngine.Vector3 SafeNormal2D(UnityEngine.Vector3 src, float Tolerance = 1E-08)
        {
            float val_6;
            float val_1 = src.z * src.z;
            val_1 = val_1 + (src.x * src.x);
            val_6 = 1f;
            if(val_1 != val_6)
            {
                goto label_1;
            }
            
            if(src.y != 0f)
            {
                goto label_2;
            }
            
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            label_1:
            if(val_1 >= 0)
            {
                goto label_4;
            }
            
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            label_2:
            val_6 = 0f;
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            label_4:
            float val_4 = TzarGames.Common.FMath.InvSqrt(x:  val_1);
            float val_5 = src.x * val_4;
            src.z = src.z * val_4;
            val_6 = 0f;
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public static float InvSqrt(float x)
        {
            float val_1;
            if(x >= _TYPE_MAX_)
            {
                    val_1 = x;
            }
            
            val_1 = 1f / val_1;
            return (float)val_1;
        }
    
    }

}

using UnityEngine;

namespace GooglePlayGames.Native
{
    internal static class CallbackUtils
    {
        // Methods
        internal static System.Action<T> ToOnGameThread<T>(System.Action<T> toConvert)
        {
            var val_1;
            var val_2;
            var val_3;
            val_1 = __RuntimeMethodHiddenParam;
            if((X2 + 48) != 0)
            {
                    mem2[0] = val_1;
            }
            else
            {
                    mem[16] = val_1;
                val_1 = mem[16];
            }
            
            if(val_1 != 0)
            {
                    val_2 = mem[X2 + 48 + 40];
                val_2 = X2 + 48 + 40;
                val_3 = X2 + 48 + 24;
                return (System.Action<T>)val_3;
            }
            
            val_2 = mem[X2 + 48 + 16 + 8];
            val_2 = X2 + 48 + 16 + 8;
            val_3 = val_2;
            return (System.Action<T>)val_3;
        }
        internal static System.Action<T1, T2> ToOnGameThread<T1, T2>(System.Action<T1, T2> toConvert)
        {
            var val_1;
            var val_2;
            var val_3;
            val_1 = __RuntimeMethodHiddenParam;
            if((X2 + 48) != 0)
            {
                    mem2[0] = val_1;
            }
            else
            {
                    mem[16] = val_1;
                val_1 = mem[16];
            }
            
            if(val_1 != 0)
            {
                    val_2 = mem[X2 + 48 + 40];
                val_2 = X2 + 48 + 40;
                val_3 = X2 + 48 + 24;
                return (System.Action<T1, T2>)val_3;
            }
            
            val_2 = mem[X2 + 48 + 16 + 8];
            val_2 = X2 + 48 + 16 + 8;
            val_3 = val_2;
            return (System.Action<T1, T2>)val_3;
        }
        internal static System.Action<T1, T2, T3> ToOnGameThread<T1, T2, T3>(System.Action<T1, T2, T3> toConvert)
        {
            var val_1;
            var val_2;
            var val_3;
            val_1 = __RuntimeMethodHiddenParam;
            if((X2 + 48) != 0)
            {
                    mem2[0] = val_1;
            }
            else
            {
                    mem[16] = val_1;
                val_1 = mem[16];
            }
            
            if(val_1 != 0)
            {
                    val_2 = mem[X2 + 48 + 40];
                val_2 = X2 + 48 + 40;
                val_3 = X2 + 48 + 24;
                return (System.Action<T1, T2, T3>)val_3;
            }
            
            val_2 = mem[X2 + 48 + 16 + 8];
            val_2 = X2 + 48 + 16 + 8;
            val_3 = val_2;
            return (System.Action<T1, T2, T3>)val_3;
        }
        private static void <ToOnGameThread`1>m__0<T>(T )
        {
        
        }
        private static void <ToOnGameThread`2>m__1<T1, T2>(T1 , T2 )
        {
        
        }
        private static void <ToOnGameThread`3>m__2<T1, T2, T3>(T1 , T2 , T3 )
        {
        
        }
    
    }

}

using UnityEngine;

namespace LlockhamIndustries.ExtensionMethods
{
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static class ArrayExtensionMethods
    {
        // Methods
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static T[] Insert<T>(T[] Array, T Item, int Index)
        {
            var val_6;
            var val_7;
            if(Index == 0)
            {
                goto label_1;
            }
            
            if(Item == null)
            {
                goto label_2;
            }
            
            int val_1 = UnityEngine.Mathf.Clamp(value:  0, min:  __RuntimeMethodHiddenParam, max:  0);
            var val_2 = (X4 + 48) + 1;
            val_7 = X4 + 48 + 8;
            val_6 = 0;
            var val_6 = 0;
            var val_4 = (val_7 + (val_1 << 3)) + 32;
            goto label_5;
            label_13:
            val_6 = 1;
            label_5:
            if(val_6 >= (X4 + 48 + 8 + 24))
            {
                    return (T[])val_7;
            }
            
            if(val_1 != val_6)
            {
                goto label_8;
            }
            
            mem2[0] = Index;
            goto label_13;
            label_8:
            var val_5 = val_7 + 8;
            mem2[0] = System.Object.__il2cppRuntimeField_byval_arg;
            val_6 = val_6 + 1;
            goto label_13;
            label_1:
            val_7 = Item;
            return (T[])val_7;
            label_2:
            val_7 = X4 + 48 + 8;
            mem2[0] = Index;
            return (T[])val_7;
        }
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static T[] Add<T>(T[] Array, T Item)
        {
            var val_5;
            var val_6;
            val_5 = __RuntimeMethodHiddenParam;
            val_6 = Item;
            if(val_5 == 0)
            {
                    return (T[])val_6;
            }
            
            if(val_6 != null)
            {
                    val_5 = ???;
            }
            else
            {
                    val_6 = X3 + 48 + 16;
                mem2[0] = val_5;
                return (T[])val_6;
            }
        
        }
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static bool Contains<T>(T[] Array, T Item)
        {
            var val_2 = 0;
            if(Item == null)
            {
                    return (bool);
            }
            
            if(__RuntimeMethodHiddenParam == 0)
            {
                    return (bool);
            }
            
            val_2 = 0;
            if(W8 < 1)
            {
                    return (bool);
            }
            
            var val_2 = 0 + 1;
            val_2 = 0;
            return (bool);
        }
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static T[] Remove<T>(T[] Array, T Item)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            if(((Item == null) || (__RuntimeMethodHiddenParam == 0)) || (W8 < 1))
            {
                goto label_2;
            }
            
            var val_1 = (X3 + 48) - 1;
            var val_10 = X3 + 48 + 8;
            if((X3 + 48) < 1)
            {
                goto label_3;
            }
            
            val_6 = 0;
            var val_8 = 0;
            var val_9 = 0;
            label_15:
            val_7 = 1;
            val_8 = val_9;
            var val_2 = val_6 & 1;
            if((val_2 & 1) != 0)
            {
                goto label_10;
            }
            
            object val_3 = Item + 8;
            val_8 = val_8;
            if((X3 + 48) == 0)
            {
                goto label_10;
            }
            
            if(val_7 >= val_2)
            {
                    val_9 = mem[(Item + 8) + 32];
                val_9 = (Item + 8) + 32;
            }
            
            val_8 = val_8;
            if(((((Item + 8) + 32) & 1) & 1) == 0)
            {
                goto label_10;
            }
            
            val_6 = 1;
            goto label_11;
            label_10:
            object val_5 = Item + 8;
            mem2[0] = val_7;
            label_11:
            val_8 = val_8 + 1;
            val_9 = val_9 + 1;
            if((val_9 + 2) < (val_10 + 0))
            {
                goto label_15;
            }
            
            goto label_16;
            label_2:
            val_10 = Item;
            return (T[])val_10;
            label_3:
            val_6 = 0;
            label_16:
            val_10 = (val_6 != 1) ? (val_10) : Item;
            return (T[])val_10;
        }
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static T[] RemoveAt<T>(T[] Array, int Index)
        {
            var val_4;
            if(Index == 0)
            {
                goto label_1;
            }
            
            if((Index + 24) < 1)
            {
                goto label_2;
            }
            
            if(((__RuntimeMethodHiddenParam & 2147483648) != 0) || ((Index + 24) <= __RuntimeMethodHiddenParam))
            {
                goto label_4;
            }
            
            var val_1 = (Index + 24) - 1;
            val_4 = X3 + 48;
            if((Index + 24) < 1)
            {
                    return (T[])val_4;
            }
            
            var val_4 = 0;
            var val_5 = 0;
            do
            {
                if(__RuntimeMethodHiddenParam != val_5)
            {
                    int val_2 = Index + 0;
                var val_3 = val_4 + 0;
                val_4 = val_4 + 1;
                mem2[0] = (Index + 0) + 32;
            }
            
                val_5 = val_5 + 1;
            }
            while(val_5 < (Index + 24));
            
            return (T[])val_4;
            label_1:
            val_4 = 0;
            return (T[])val_4;
            label_4:
            UnityEngine.Debug.LogError(message:  0);
            label_2:
            val_4 = Index;
            return (T[])val_4;
        }
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static T[] Resize<T>(T[] Array, int Size)
        {
            var val_3;
            var val_4;
            val_3 = X3;
            if(Size == 0)
            {
                goto label_1;
            }
            
            var val_3 = X3 + 48;
            val_4 = val_3;
            val_3 = 0;
            goto label_2;
            label_9:
            val_3 = val_4 + ((X23) << 3);
            val_3 = 1;
            mem2[0] = ???;
            label_2:
            if(val_3 >= (UnityEngine.Mathf.Min(a:  0, b:  X3 + 48 + 24)))
            {
                    return (T[])val_4;
            }
            
            int val_2 = Size + 8;
            if(val_3 < (X3 + 48 + 24))
            {
                goto label_9;
            }
            
            goto label_9;
            label_1:
            val_4 = 0;
            return (T[])val_4;
        }
    
    }

}

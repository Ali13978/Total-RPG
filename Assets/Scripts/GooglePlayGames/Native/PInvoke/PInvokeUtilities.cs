using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal static class PInvokeUtilities
    {
        // Fields
        private static readonly System.DateTime UnixEpoch;
        
        // Methods
        internal static System.Runtime.InteropServices.HandleRef CheckNonNull(System.Runtime.InteropServices.HandleRef reference)
        {
            if((GooglePlayGames.Native.PInvoke.PInvokeUtilities.IsNull(reference:  new System.Runtime.InteropServices.HandleRef() {handle = reference.handle})) != true)
            {
                    return new System.Runtime.InteropServices.HandleRef() {wrapper = reference.handle, handle = X2};
            }
            
            System.InvalidOperationException val_2 = new System.InvalidOperationException();
        }
        internal static bool IsNull(System.Runtime.InteropServices.HandleRef reference)
        {
            IntPtr val_2;
            IntPtr val_1 = System.Runtime.InteropServices.HandleRef.ToIntPtr(value:  new System.Runtime.InteropServices.HandleRef() {handle = reference.handle});
            val_2 = null;
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.IsNull(pointer:  val_2);
        }
        internal static bool IsNull(IntPtr pointer)
        {
            return false;
        }
        internal static System.DateTime FromMillisSinceUnixEpoch(long millisSinceEpoch)
        {
            null = null;
            System.TimeSpan val_1 = System.TimeSpan.FromMilliseconds(value:  (double)X1);
            return new System.DateTime() {ticks = new System.TimeSpan() {}, kind = val_1._ticks};
        }
        internal static string OutParamsToString(GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutStringMethod outStringMethod)
        {
            var val_7;
            var val_8;
            val_7 = X1;
            UIntPtr val_1 = val_7.Invoke(out_bytes:  0, out_size:  0);
            val_8 = 0;
            if((0 & 1) != 0)
            {
                    return (string)val_8;
            }
            
            GooglePlayGames.BasicApi.ResponseStatus val_2 = val_1.Status;
            UIntPtr val_3 = val_7.Invoke(out_bytes:  null, out_size:  val_1);
            val_7 = System.Text.Encoding.UTF8;
            GooglePlayGames.BasicApi.ResponseStatus val_6 = val_1.Status - 1;
            val_8 = val_7;
            return (string)val_8;
        }
        internal static T[] OutParamsToArray<T>(GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutMethod<T> outMethod)
        {
            var val_3;
            var val_4;
            val_3 = X2;
            if(((-1016966824) & 1) != 0)
            {
                    val_3 = mem[X2 + 48 + 8];
                val_3 = X2 + 48 + 8;
                val_4 = val_3;
                return (T[])val_4;
            }
            
            ulong val_1 = __RuntimeMethodHiddenParam.ToUInt64();
            if((val_1 & 9223372036854775808) == 0)
            {
                    ulong val_2 = val_1 & 4294967295;
                val_4 = X2 + 48 + 8;
                return (T[])val_4;
            }
        
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        internal static System.Collections.Generic.IEnumerable<T> ToEnumerable<T>(UIntPtr size, System.Func<UIntPtr, T> getElement)
        {
            if((X3 + 48) != 0)
            {
                    mem2[0] = getElement;
                mem2[0] = __RuntimeMethodHiddenParam;
            }
            else
            {
                    mem[24] = getElement;
                mem[32] = __RuntimeMethodHiddenParam;
            }
            
            mem2[0] = -2;
            return (System.Collections.Generic.IEnumerable<T>)X3 + 48;
        }
        internal static System.Collections.Generic.IEnumerator<T> ToEnumerator<T>(UIntPtr size, System.Func<UIntPtr, T> getElement)
        {
            var val_2;
            var val_3;
            val_2 = getElement;
            var val_3 = 1179403647;
            if(mem[282584257676929] == 0)
            {
                goto label_4;
            }
            
            var val_1 = mem[282584257676823];
            var val_2 = 0;
            val_1 = val_1 + 8;
            label_6:
            if(((mem[282584257676823] + 8) + -8) == (X3 + 48 + 8))
            {
                goto label_5;
            }
            
            val_2 = val_2 + 1;
            val_1 = val_1 + 16;
            if(val_2 < mem[282584257676929])
            {
                goto label_6;
            }
            
            label_4:
            val_3 = 0;
            val_2 = X3 + 48 + 8;
            goto ((1179403647 + ((mem[282584257676823] + 8)) << 4) + 272);
            label_5:
            val_3 = val_3 + (((mem[282584257676823] + 8)) << 4);
            val_3 = val_3 + 272;
            goto ((1179403647 + ((mem[282584257676823] + 8)) << 4) + 272);
        }
        internal static UIntPtr ArrayToSizeT<T>(T[] array)
        {
            var val_1;
            if(__RuntimeMethodHiddenParam != 0)
            {
                    val_1 = 0;
                return (UIntPtr)val_1;
            }
            
            val_1 = 0;
            return (UIntPtr)val_1;
        }
        internal static long ToMilliseconds(System.TimeSpan span)
        {
            var val_2;
            if(V0.16B > (9.22337203685478E+18))
            {
                    val_2 = 9223372036854775807;
                return (long)System.Convert.ToInt64(value:  V0.16B);
            }
            
            if(V0.16B >= 0)
            {
                    return (long)System.Convert.ToInt64(value:  V0.16B);
            }
            
            val_2 = -9223372036854775808;
            return (long)System.Convert.ToInt64(value:  V0.16B);
        }
        private static PInvokeUtilities()
        {
            System.DateTime val_1 = System.DateTime.SpecifyKind(value:  new System.DateTime() {ticks = new System.TimeSpan()}, kind:  0);
            GooglePlayGames.Native.PInvoke.PInvokeUtilities.UnixEpoch = val_1.ticks._ticks;
            GooglePlayGames.Native.PInvoke.PInvokeUtilities.UnixEpoch.__il2cppRuntimeField_8 = val_1.kind;
        }
    
    }

}

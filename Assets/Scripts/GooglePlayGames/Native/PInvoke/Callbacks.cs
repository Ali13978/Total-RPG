using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal static class Callbacks
    {
        // Fields
        internal static readonly System.Action<GooglePlayGames.Native.Cwrapper.CommonErrorStatus.UIStatus> NoopUICallback;
        
        // Methods
        internal static IntPtr ToIntPtr<T>(System.Action<T> callback, System.Func<IntPtr, T> conversionFunction)
        {
            if((X3 + 48) != 0)
            {
                    mem2[0] = __RuntimeMethodHiddenParam;
            }
            else
            {
                    mem[16] = __RuntimeMethodHiddenParam;
            }
            
            mem2[0] = conversionFunction;
            System.Action<System.IntPtr> val_1 = new System.Action<System.IntPtr>(object:  X3 + 48, method:  X3 + 48 + 16);
            return GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr(callback:  0);
        }
        internal static IntPtr ToIntPtr<T, P>(System.Action<T, P> callback, System.Func<IntPtr, P> conversionFunction)
        {
            if((X3 + 48) != 0)
            {
                    mem2[0] = __RuntimeMethodHiddenParam;
            }
            else
            {
                    mem[16] = __RuntimeMethodHiddenParam;
            }
            
            mem2[0] = conversionFunction;
            return GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr(callback:  0);
        }
        internal static IntPtr ToIntPtr(System.Delegate callback)
        {
            if(X1 == 0)
            {
                    return (IntPtr)0;
            }
            
            System.Runtime.InteropServices.GCHandle val_1 = System.Runtime.InteropServices.GCHandle.Alloc(value:  0);
            int val_2 = val_1.handle & 4294967295;
            return System.Runtime.InteropServices.GCHandle.ToIntPtr(value:  new System.Runtime.InteropServices.GCHandle());
        }
        internal static T IntPtrToTempCallback<T>(IntPtr handle)
        {
            goto X2 + 48;
        }
        private static T IntPtrToCallback<T>(IntPtr handle, bool unpinHandle)
        {
            var val_4;
            var val_5;
            var val_6;
            if((GooglePlayGames.Native.PInvoke.PInvokeUtilities.IsNull(pointer:  0)) != false)
            {
                    val_4 = 0;
                return (object)val_4;
            }
            
            System.Runtime.InteropServices.GCHandle val_2 = System.Runtime.InteropServices.GCHandle.FromIntPtr(value:  0);
            if(val_2.handle == 0)
            {
                goto label_5;
            }
            
            val_4 = ;
            if(val_2.handle == 0)
            {
                goto label_6;
            }
            
            val_5 = 0;
            val_6 = 120;
            goto label_7;
            label_6:
            label_5:
            val_5 = 0;
            val_4 = 0;
            val_6 = 120;
            label_7:
            if((__RuntimeMethodHiddenParam & 1) != 0)
            {
                    val_2.handle.Free();
            }
            
            if(val_6 == 120)
            {
                    return (object)val_4;
            }
            
            if(val_5 == 0)
            {
                    return (object)val_4;
            }
            
            return (object)val_4;
        }
        internal static T IntPtrToPermanentCallback<T>(IntPtr handle)
        {
            goto X2 + 48;
        }
        [AOT.MonoPInvokeCallbackAttribute]
        internal static void InternalShowUICallback(GooglePlayGames.Native.Cwrapper.CommonErrorStatus.UIStatus status, IntPtr data)
        {
            string val_1 = 0 + "Showing UI Internal callback: "("Showing UI Internal callback: ");
            GooglePlayGames.OurUtils.Logger.d(msg:  0);
            GooglePlayGames.Native.PInvoke.Callbacks.IntPtrToTempCallback<System.Action<MultiplayerStatus>>(handle:  0).Invoke(obj:  data);
        }
        internal static void PerformInternalCallback(string callbackName, GooglePlayGames.Native.PInvoke.Callbacks.Type callbackType, IntPtr response, IntPtr userData)
        {
            string val_1 = 0 + "Entering internal callback for ";
            GooglePlayGames.OurUtils.Logger.d(msg:  0);
            if(response != 0)
            {
                    System.Action<MultiplayerStatus> val_4 = GooglePlayGames.Native.PInvoke.Callbacks.IntPtrToTempCallback<System.Action<MultiplayerStatus>>(handle:  0);
            }
            else
            {
                    System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom, GooglePlayGames.Native.PInvoke.MultiplayerParticipant, System.Byte[], System.Boolean> val_5 = GooglePlayGames.Native.PInvoke.Callbacks.IntPtrToPermanentCallback<System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom, GooglePlayGames.Native.PInvoke.MultiplayerParticipant, System.Byte[], System.Boolean>>(handle:  0);
            }
            
            if(val_5 == null)
            {
                    return;
            }
            
            val_5.Invoke(obj:  userData);
        }
        internal static void PerformInternalCallback<T>(string callbackName, GooglePlayGames.Native.PInvoke.Callbacks.Type callbackType, T param1, IntPtr param2, IntPtr userData)
        {
            var val_4;
            string val_1 = 0 + "Entering internal callback for ";
            GooglePlayGames.OurUtils.Logger.d(msg:  0);
            if(param1 != null)
            {
                    val_4 = 0;
            }
            else
            {
                    val_4 = 0;
            }
            
            GooglePlayGames.OurUtils.Logger.d(msg:  0);
            if(val_4 == 0)
            {
                    return;
            }
        
        }
        internal static System.Action<T> AsOnGameThreadCallback<T>(System.Action<T> toInvokeOnGameThread)
        {
            mem2[0] = __RuntimeMethodHiddenParam;
            return (System.Action<T>)X2 + 48 + 16 + 8;
        }
        internal static System.Action<T1, T2> AsOnGameThreadCallback<T1, T2>(System.Action<T1, T2> toInvokeOnGameThread)
        {
            mem2[0] = __RuntimeMethodHiddenParam;
            return (System.Action<T1, T2>)X2 + 48 + 16 + 8;
        }
        internal static void AsCoroutine(System.Collections.IEnumerator routine)
        {
            GooglePlayGames.OurUtils.PlayGamesHelperObject.RunCoroutine(action:  0);
        }
        internal static byte[] IntPtrAndSizeToByteArray(IntPtr data, UIntPtr dataLength)
        {
            if((???.ToUInt64()) == 0)
            {
                    return (System.Byte[])0;
            }
            
            GooglePlayGames.BasicApi.ResponseStatus val_2 = ???.Status;
            0 = null;
            GooglePlayGames.BasicApi.ResponseStatus val_3 = ???.Status;
            System.Runtime.InteropServices.Marshal.Copy(source:  0, destination:  dataLength, startIndex:  460851360, length:  0);
            return (System.Byte[])0;
        }
        private static Callbacks()
        {
            GooglePlayGames.Native.PInvoke.Callbacks.NoopUICallback = new System.Action<UIStatus>(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.Callbacks::<NoopUICallback>m__0(GooglePlayGames.Native.Cwrapper.CommonErrorStatus.UIStatus status));
        }
        private static void <NoopUICallback>m__0(GooglePlayGames.Native.Cwrapper.CommonErrorStatus.UIStatus status)
        {
            string val_1 = 0 + "Received UI callback: "("Received UI callback: ");
            GooglePlayGames.OurUtils.Logger.d(msg:  0);
        }
    
    }

}

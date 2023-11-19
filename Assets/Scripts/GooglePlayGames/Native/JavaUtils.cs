using UnityEngine;

namespace GooglePlayGames.Native
{
    [System.Runtime.CompilerServices.ExtensionAttribute]
    internal static class JavaUtils
    {
        // Fields
        private static System.Reflection.ConstructorInfo IntPtrConstructor;
        
        // Methods
        internal static UnityEngine.AndroidJavaObject JavaObjectFromPointer(IntPtr jobject)
        {
            System.Reflection.ConstructorInfo val_6;
            var val_7;
            var val_8;
            val_7 = 0;
            if((System.IntPtr.op_Equality(value1:  0, value2:  X1)) == true)
            {
                    return (UnityEngine.AndroidJavaObject)val_7;
            }
            
            val_8 = null;
            val_8 = null;
            val_6 = GooglePlayGames.Native.JavaUtils.IntPtrConstructor;
            typeof(System.Object[]).__il2cppRuntimeField_20 = X1;
            object val_3 = val_6.Invoke(parameters:  null);
            val_7 = 0;
            if(val_3 == null)
            {
                    return (UnityEngine.AndroidJavaObject)val_7;
            }
            
            val_7 = val_3;
            val_7 = 0;
            return (UnityEngine.AndroidJavaObject)val_7;
        }
        [System.Runtime.CompilerServices.ExtensionAttribute]
        internal static UnityEngine.AndroidJavaObject NullSafeCall(UnityEngine.AndroidJavaObject target, string methodName, object[] args)
        {
            return (UnityEngine.AndroidJavaObject)methodName.Call<UnityEngine.AndroidJavaObject>(methodName:  args, args:  X3);
        }
        private static JavaUtils()
        {
            typeof(System.Type[]).__il2cppRuntimeField_20 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            GooglePlayGames.Native.JavaUtils.IntPtrConstructor = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()).GetConstructor(bindingAttr:  36, binder:  0, types:  null, modifiers:  0);
        }
    
    }

}

using UnityEngine;

namespace Com.Google.Android.Gms.Common.Api
{
    public abstract class ResultCallbackProxy<R> : JavaInterfaceProxy, ResultCallback<R>
    {
        // Fields
        private const string CLASS_NAME = "com/google/android/gms/common/api/ResultCallback";
        
        // Methods
        public ResultCallbackProxy<R>()
        {
            if(this != null)
            {
                    return;
            }
        
        }
        public abstract void OnResult(R arg_Result_1); // 0
        public void onResult(R arg_Result_1)
        {
            if(this == null)
            {
                
            }
        
        }
        public void onResult(UnityEngine.AndroidJavaObject arg_Result_1)
        {
            System.Type val_13;
            var val_14;
            IntPtr val_15;
            var val_16;
            IntPtr val_1 = arg_Result_1.GetRawObject();
            if(val_1 != 0)
            {
                    val_13 = val_1.GetType();
            }
            else
            {
                    val_13 = val_1.GetType();
            }
            
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            typeof(System.Type[]).__il2cppRuntimeField_20 = val_13;
            System.Reflection.ConstructorInfo val_6 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()).GetConstructor(types:  null);
            if(val_6 == null)
            {
                goto label_11;
            }
            
            val_13 = null;
            val_14 = 0;
            typeof(System.Object[]).__il2cppRuntimeField_20 = val_13;
            object val_7 = val_6.Invoke(parameters:  null);
            val_15 = mem[__RuntimeMethodHiddenParam + 24 + 168 + 16];
            val_15 = __RuntimeMethodHiddenParam + 24 + 168 + 16;
            val_16 = 0;
            if(val_7 == null)
            {
                goto label_18;
            }
            
            val_16 = val_7;
            if(val_16 != null)
            {
                goto label_18;
            }
            
            val_16 = 0;
            goto label_18;
            label_11:
            object val_11 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()).GetConstructor(types:  null).Invoke(parameters:  null);
            val_16 = 0;
            if(val_11 != null)
            {
                    val_16 = val_11;
                if(val_16 == null)
            {
                    val_16 = 0;
            }
            
            }
            
            val_15 = null;
            val_14 = val_16;
            System.Runtime.InteropServices.Marshal.PtrToStructure(ptr:  0, structure:  val_15);
            label_18:
            if(this != null)
            {
                    return;
            }
        
        }
    
    }

}

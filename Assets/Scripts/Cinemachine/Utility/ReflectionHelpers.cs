using UnityEngine;

namespace Cinemachine.Utility
{
    [Cinemachine.DocumentationSortingAttribute]
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static class ReflectionHelpers
    {
        // Methods
        public static void CopyFields(object src, object dst, System.Reflection.BindingFlags bindingAttr = 52)
        {
            var val_5;
            var val_6;
            object val_8;
            val_5 = W3;
            if(dst == null)
            {
                    return;
            }
            
            if(bindingAttr == 0)
            {
                    return;
            }
            
            val_5 = dst.GetType();
            val_6 = 0;
            goto label_3;
            label_14:
            val_6 = 1;
            label_3:
            if(val_6 >= null)
            {
                    return;
            }
            
            System.Type val_2 = val_5 + 8;
            bool val_4 = 1.IsStatic;
            if(val_4 == true)
            {
                goto label_14;
            }
            
            val_8 = (val_1 + 8) + 32;
            if(val_6 >= val_4)
            {
                    val_8 = mem[(val_1 + 8) + 32];
                val_8 = (val_1 + 8) + 32;
            }
            
            (val_1 + 8) + 32.SetValue(obj:  bindingAttr, value:  val_8);
            goto label_14;
        }
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static T AccessInternalField<T>(System.Type type, object obj, string memberName)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            val_7 = X4;
            val_8 = __RuntimeMethodHiddenParam;
            val_9 = 0;
            if(obj == null)
            {
                    return (object)val_9;
            }
            
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                    return (object)val_9;
            }
            
            var val_3 = (memberName == null) ? 40 : 36;
            val_8 = obj;
            if(val_8 != null)
            {
                    val_6 = mem[X4 + 48];
                val_6 = X4 + 48;
                val_9 = 0;
                if(val_8 != (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                    return (object)val_9;
            }
            
                val_7 = mem[X4 + 48 + 8];
                val_7 = X4 + 48 + 8;
                if(val_8 != null)
            {
                    val_9 = val_8;
                if(val_9 != null)
            {
                    return (object)val_9;
            }
            
            }
            
            }
            
            val_9 = 0;
            return (object)val_9;
        }
        public static object GetParentObject(string path, object obj)
        {
            object val_4 = obj;
            goto label_0;
            label_14:
            var val_1 = 25372892 - 1;
            val_4 = System.String.Join(separator:  0, value:  ".", startIndex:  val_4 = obj, count:  1);
            label_0:
            typeof(System.Char[]).__il2cppRuntimeField_20 = 46;
            System.String[] val_3 = val_4.Split(separator:  null);
            if(val_3.Length == 1)
            {
                    return (object)X2;
            }
            
            System.Type val_4 = X2.GetType();
            string val_5 = val_3[0];
            if(val_3 != null)
            {
                goto label_14;
            }
            
            goto label_14;
        }
        public static string GetFieldPath<TType, TValue>(System.Linq.Expressions.Expression<System.Func<TType, TValue>> expr)
        {
            var val_14;
            string val_15;
            int val_16;
            if(__RuntimeMethodHiddenParam.Body.NodeType != 23)
            {
                goto label_3;
            }
            
            System.Linq.Expressions.Expression val_3 = __RuntimeMethodHiddenParam.Body;
            System.Collections.Generic.List<System.String> val_4 = new System.Collections.Generic.List<System.String>();
            if(val_3 != null)
            {
                    val_14 = 1152921509076290944;
                do
            {
                Add(item:  val_3.Member);
            }
            while(val_3.Expression != null);
            
            }
            
            System.Text.StringBuilder val_7 = new System.Text.StringBuilder();
            val_15 = public System.Int32 System.Collections.Generic.List<System.String>::get_Count();
            val_16 = Count - 1;
            if((val_16 & 2147483648) == 0)
            {
                    val_14 = 1152921509085010416;
                do
            {
                val_15 = Item[val_16];
                System.Text.StringBuilder val_10 = Append(value:  val_15);
                if(val_16 > 0)
            {
                    val_15 = 46;
                System.Text.StringBuilder val_11 = Append(value:  '.');
            }
            
                val_16 = val_16 - 1;
            }
            while((val_16 & 2147483648) == 0);
            
            }
            
            if(null != 0)
            {
                goto mem[null + 320];
            }
            
            goto mem[null + 320];
            label_3:
            System.InvalidOperationException val_12 = new System.InvalidOperationException();
        }
    
    }

}

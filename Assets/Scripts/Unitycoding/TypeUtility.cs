using UnityEngine;

namespace Unitycoding
{
    public static class TypeUtility
    {
        // Fields
        private static System.Reflection.Assembly[] assembliesLookup;
        private static System.Collections.Generic.Dictionary<string, System.Type> typeLookup;
        private static System.Func<System.Type, string> <>f__am$cache0;
        private static System.Func<System.Reflection.Assembly, System.Collections.Generic.IEnumerable<System.Type>> <>f__am$cache1;
        
        // Methods
        private static TypeUtility()
        {
            var val_8;
            Unitycoding.TypeUtility.assembliesLookup = Unitycoding.TypeUtility.GetLoadedAssemblies();
            System.Collections.Generic.List<System.Reflection.Assembly> val_2 = new System.Collections.Generic.List<System.Reflection.Assembly>();
            val_8 = 0;
            goto label_1;
            label_10:
            val_8 = 1;
            label_1:
            if(val_8 >= val_1.Length)
            {
                goto label_3;
            }
            
            if((val_1.Length + 32.Name.Contains(value:  "Editor")) == true)
            {
                goto label_10;
            }
            
            Add(item:  val_1.Length + 32);
            goto label_10;
            label_3:
            Unitycoding.TypeUtility.assembliesLookup = ToArray();
            Unitycoding.TypeUtility.typeLookup = new System.Collections.Generic.Dictionary<System.String, System.Type>();
        }
        public static System.Reflection.Assembly[] GetLoadedAssemblies()
        {
            System.AppDomain val_1 = System.AppDomain.CurrentDomain;
            if(val_1 != null)
            {
                    return val_1.GetAssemblies();
            }
            
            return val_1.GetAssemblies();
        }
        public static string[] GetSubTypeNames(System.Type baseType)
        {
            var val_4;
            var val_5;
            val_4 = null;
            if((Unitycoding.TypeUtility.<>f__am$cache0) == null)
            {
                    val_5 = null;
                val_5 = null;
                Unitycoding.TypeUtility.<>f__am$cache0 = new System.Func<System.Type, System.String>(object:  0, method:  static System.String Unitycoding.TypeUtility::<GetSubTypeNames>m__0(System.Type x));
                val_4 = null;
            }
            
            val_4 = null;
            System.Collections.Generic.IEnumerable<TResult> val_3 = System.Linq.Enumerable.Select<System.Type, System.String>(source:  0, selector:  Unitycoding.TypeUtility.GetSubTypes(baseType:  null));
            return System.Linq.Enumerable.ToArray<System.Type>(source:  0);
        }
        public static System.Type[] GetSubTypes(System.Type baseType)
        {
            var val_6;
            var val_7;
            typeof(TypeUtility.<GetSubTypes>c__AnonStorey0).__il2cppRuntimeField_10 = X1;
            val_6 = null;
            val_6 = null;
            if((Unitycoding.TypeUtility.<>f__am$cache1) == null)
            {
                    val_7 = null;
                val_7 = null;
                Unitycoding.TypeUtility.<>f__am$cache1 = new System.Func<System.Reflection.Assembly, System.Collections.Generic.IEnumerable<System.Type>>(object:  0, method:  static System.Collections.Generic.IEnumerable<System.Type> Unitycoding.TypeUtility::<GetSubTypes>m__1(System.Reflection.Assembly assembly));
                val_6 = null;
            }
            
            val_6 = null;
            System.Func<System.Type, System.Boolean> val_4 = new System.Func<System.Type, System.Boolean>(object:  new System.Object(), method:  System.Boolean TypeUtility.<GetSubTypes>c__AnonStorey0::<>m__0(System.Type type));
            System.Collections.Generic.IEnumerable<TSource> val_5 = System.Linq.Enumerable.Where<UnityEngine.UI.ExtensionsToggle>(source:  0, predicate:  System.Linq.Enumerable.SelectMany<System.Reflection.Assembly, System.Type>(source:  0, selector:  Unitycoding.TypeUtility.assembliesLookup));
            return System.Linq.Enumerable.ToArray<System.Type>(source:  0);
        }
        public static System.Type GetMemberType(System.Type type, string name)
        {
            string val_7 = X2;
            if((name.GetField(name:  val_7 = X2)) != null)
            {
                
            }
            else
            {
                    if((name.GetProperty(name:  val_7)) == null)
            {
                    return 0;
            }
            
            }
            
            val_7 = ???;
            goto typeof(System.Reflection.PropertyInfo).__il2cppRuntimeField_220;
        }
        public static System.Type GetType(string name)
        {
            var val_5;
            string val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            System.Type val_1 = 0;
            val_5 = null;
            val_5 = null;
            val_6 = X1;
            if((Unitycoding.TypeUtility.typeLookup.TryGetValue(key:  val_6, value: out  val_1)) != false)
            {
                    val_7 = val_1;
                return (System.Type)val_7;
            }
            
            val_8 = null;
            val_8 = null;
            val_9 = 0;
            goto label_8;
            label_15:
            val_9 = 1;
            label_8:
            if(val_9 >= Unitycoding.TypeUtility.assembliesLookup.Length)
            {
                    return (System.Type)val_7;
            }
            
            if(val_9 >= Unitycoding.TypeUtility.assembliesLookup.Length)
            {
                    val_6 = 0;
            }
            
            val_10 = mem[Unitycoding.TypeUtility.assembliesLookup.Length + 32 + 464 + 8];
            val_10 = Unitycoding.TypeUtility.assembliesLookup.Length + 32 + 464 + 8;
            val_11 = 0;
            goto label_13;
            label_20:
            val_11 = 1;
            label_13:
            if(val_11 >= (Unitycoding.TypeUtility.assembliesLookup.Length + 32 + 24))
            {
                goto label_15;
            }
            
            if(val_11 >= (Unitycoding.TypeUtility.assembliesLookup.Length + 32 + 24))
            {
                    val_10 = 0;
            }
            
            var val_3 = (Unitycoding.TypeUtility.assembliesLookup.Length + 32) + 8;
            if((System.String.op_Equality(a:  0, b:  (Unitycoding.TypeUtility.assembliesLookup.Length + 32 + 8) + 32)) == false)
            {
                goto label_20;
            }
            
            val_12 = null;
            val_12 = null;
            Unitycoding.TypeUtility.typeLookup.Add(key:  X1, value:  (Unitycoding.TypeUtility.assembliesLookup.Length + 32 + 8) + 32);
            val_7 = mem[(Unitycoding.TypeUtility.assembliesLookup.Length + 32 + 8) + 32];
            val_7 = (Unitycoding.TypeUtility.assembliesLookup.Length + 32 + 8) + 32;
            return (System.Type)val_7;
        }
        private static string <GetSubTypeNames>m__0(System.Type x)
        {
            if(X1 == 0)
            {
                
            }
        
        }
        private static System.Collections.Generic.IEnumerable<System.Type> <GetSubTypes>m__1(System.Reflection.Assembly assembly)
        {
            if(X1 == 0)
            {
                
            }
        
        }
    
    }

}

using UnityEngine;

namespace SA.IOSDeploy
{
    public class ISD_LibHandler : MonoBehaviour
    {
        // Properties
        public static System.Collections.Generic.List<SA.IOSDeploy.Lib> AvailableLibraries { get; }
        
        // Methods
        public ISD_LibHandler()
        {
        
        }
        public static System.Collections.Generic.List<SA.IOSDeploy.Lib> get_AvailableLibraries()
        {
            float val_8;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            System.Collections.Generic.List<System.String> val_4 = new System.Collections.Generic.List<System.String>(collection:  System.Enum.GetNames(enumType:  0));
            SA.IOSDeploy.ISD_Settings val_5 = SA.IOSDeploy.ISD_Settings.Instance;
            List.Enumerator<T> val_6 = val_5.Libraries.GetEnumerator();
            label_13:
            if((0 & 1) == 0)
            {
                goto label_7;
            }
            
            bool val_11 = Contains(item:  SA.IOSDeploy.ISD_LibHandler.stringValueOf(value:  val_8.InitializationCallback));
            if(val_11 == false)
            {
                goto label_13;
            }
            
            bool val_14 = Remove(item:  SA.IOSDeploy.ISD_LibHandler.stringValueOf(value:  val_11));
            goto label_13;
            label_7:
            val_8.Dispose();
            val_29 = 1152921504609562624;
            System.Type val_15 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            System.Collections.IEnumerator val_17 = System.Enum.GetValues(enumType:  0).GetEnumerator();
            do
            {
                label_39:
                var val_29 = 0;
                val_29 = val_29 + 1;
                val_30 = val_17;
                if(((val_17 & 1) & 1) == 0)
            {
                goto label_48;
            }
            
                var val_30 = 0;
                val_30 = val_30 + 1;
                val_31 = val_17;
                UnityEngine.Vector2 val_21 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8});
                UnityEngine.Vector2 val_23 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y});
            }
            while((Contains(item:  null.ToString())) == false);
            
            object val_26 = new System.Object();
            typeof(SA.IOSDeploy.Lib).__il2cppRuntimeField_14 = null;
            Add(item:  null);
            goto label_39;
            label_49:
            if(null == 1)
            {
                    label_48:
                if(val_17 != null)
            {
                    var val_31 = 0;
                val_31 = val_31 + 1;
                val_32 = val_17;
            }
            
                if(0 == 235)
            {
                    return (System.Collections.Generic.List<SA.IOSDeploy.Lib>)new System.Collections.Generic.List<SA.IOSDeploy.Lib>();
            }
            
                if(null == 0)
            {
                    return (System.Collections.Generic.List<SA.IOSDeploy.Lib>)new System.Collections.Generic.List<SA.IOSDeploy.Lib>();
            }
            
                return (System.Collections.Generic.List<SA.IOSDeploy.Lib>)new System.Collections.Generic.List<SA.IOSDeploy.Lib>();
            }
            
            goto label_49;
        }
        public static string[] BaseLibrariesArray()
        {
            System.Collections.Generic.List<T> val_9;
            var val_10;
            System.Collections.Generic.List<System.String> val_3 = new System.Collections.Generic.List<System.String>(capacity:  SA.IOSDeploy.ISD_LibHandler.AvailableLibraries.Capacity);
            List.Enumerator<T> val_5 = SA.IOSDeploy.ISD_LibHandler.AvailableLibraries.GetEnumerator();
            label_6:
            if((0 & 1) == 0)
            {
                goto label_3;
            }
            
            Add(item:  SA.IOSDeploy.ISD_LibHandler.stringValueOf(value:  0.InitializationCallback));
            goto label_6;
            label_3:
            val_9 = 0;
            val_10 = 1;
            0.Dispose();
            return (System.String[])ToArray();
        }
        public static string stringValueOf(SA.IOSDeploy.iOSLibrary value)
        {
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            if((???) != 0)
            {
                    val_11 = ???.GetType();
            }
            else
            {
                    val_11 = ???.GetType();
            }
            
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y});
            System.Reflection.FieldInfo val_6 = val_11.GetField(name:  null.ToString());
            val_12 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            if(val_6 == null)
            {
                goto label_9;
            }
            
            val_13 = val_6;
            val_12 = null;
            if(val_13 != null)
            {
                goto label_10;
            }
            
            val_12 = 0;
            label_9:
            val_13 = 0;
            label_10:
            if(7254272 >= 1)
            {
                    val_14 = 64;
                val_15 = val_14;
                return (string)val_15;
            }
            
            val_14 = null;
            val_15 = null.ToString();
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y});
            return (string)val_15;
        }
        public static object enumValueOf(string value)
        {
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            var val_11 = 0;
            label_13:
            if(val_11 >= val_2.Length)
            {
                goto label_6;
            }
            
            string val_10 = System.Enum.GetNames(enumType:  0)[0];
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            val_11 = val_11 + 1;
            if((SA.IOSDeploy.ISD_LibHandler.stringValueOf(value:  System.Enum.Parse(enumType:  0, value:  val_1)).Equals(value:  X1)) == false)
            {
                goto label_13;
            }
            
            return System.Enum.Parse(enumType:  0, value:  val_1);
            label_6:
            System.ArgumentException val_8 = new System.ArgumentException(message:  0 + "The string is not a description or value of the specified enum...\n " + X1);
        }
    
    }

}

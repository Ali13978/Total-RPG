using UnityEngine;

namespace SA.IOSDeploy
{
    public class ISD_FrameworkHandler : MonoBehaviour
    {
        // Fields
        private static System.Collections.Generic.List<SA.IOSDeploy.Framework> _DefaultFrameworks;
        
        // Properties
        public static System.Collections.Generic.List<SA.IOSDeploy.Framework> AvailableFrameworks { get; }
        public static System.Collections.Generic.List<SA.IOSDeploy.Framework> DefaultFrameworks { get; }
        
        // Methods
        public ISD_FrameworkHandler()
        {
        
        }
        public static System.Collections.Generic.List<SA.IOSDeploy.Framework> get_AvailableFrameworks()
        {
            float val_8;
            var val_44;
            var val_45;
            var val_46;
            System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            System.Collections.Generic.List<System.String> val_4 = new System.Collections.Generic.List<System.String>(collection:  System.Enum.GetNames(enumType:  0));
            SA.IOSDeploy.ISD_Settings val_5 = SA.IOSDeploy.ISD_Settings.Instance;
            List.Enumerator<T> val_6 = val_5.Frameworks.GetEnumerator();
            label_15:
            if((0 & 1) == 0)
            {
                goto label_7;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_10 = val_8.InitializationCallback + 20;
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8});
            mem2[0] = null;
            if((Contains(item:  val_10.ToString())) == false)
            {
                goto label_15;
            }
            
            UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y});
            mem2[0] = null;
            bool val_17 = Remove(item:  val_10.ToString());
            goto label_15;
            label_63:
            List.Enumerator<T> val_19 = SA.IOSDeploy.ISD_FrameworkHandler.DefaultFrameworks.GetEnumerator();
            label_29:
            if((0 & 1) == 0)
            {
                goto label_21;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_21 = val_8.InitializationCallback + 20;
            UnityEngine.Vector2 val_23 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8, y = val_16.y});
            mem2[0] = null;
            if((Contains(item:  val_21.ToString())) == false)
            {
                goto label_29;
            }
            
            UnityEngine.Vector2 val_27 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y});
            mem2[0] = null;
            bool val_28 = Remove(item:  val_21.ToString());
            goto label_29;
            label_64:
            System.Type val_29 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            System.Collections.IEnumerator val_31 = System.Enum.GetValues(enumType:  0).GetEnumerator();
            do
            {
                label_54:
                var val_43 = 0;
                val_43 = val_43 + 1;
                val_44 = val_31;
                if(((val_31 & 1) & 1) == 0)
            {
                goto label_65;
            }
            
                var val_44 = 0;
                val_44 = val_44 + 1;
                val_45 = val_31;
                UnityEngine.Vector2 val_35 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y});
                UnityEngine.Vector2 val_37 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y});
            }
            while((Contains(item:  null.ToString())) == false);
            
            object val_40 = new System.Object();
            typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_14 = null;
            typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_19 = 0;
            Add(item:  null);
            goto label_54;
            label_66:
            if(null != 1)
            {
                goto label_55;
            }
            
            label_65:
            if(val_31 != null)
            {
                    var val_45 = 0;
                val_45 = val_45 + 1;
                val_46 = val_31;
            }
            
            if(0 == 369)
            {
                    return (System.Collections.Generic.List<SA.IOSDeploy.Framework>)new System.Collections.Generic.List<SA.IOSDeploy.Framework>();
            }
            
            if(null == 0)
            {
                    return (System.Collections.Generic.List<SA.IOSDeploy.Framework>)new System.Collections.Generic.List<SA.IOSDeploy.Framework>();
            }
            
            return (System.Collections.Generic.List<SA.IOSDeploy.Framework>)new System.Collections.Generic.List<SA.IOSDeploy.Framework>();
            label_7:
            val_8.Dispose();
            goto label_63;
            label_21:
            val_8.Dispose();
            goto label_64;
            label_55:
            goto label_66;
        }
        public static System.Collections.Generic.List<string> GetImportedFrameworks()
        {
            System.Func<TSource, System.Boolean> val_14;
            string val_15;
            var val_16;
            var val_17;
            var val_18;
            string val_19;
            object val_1 = new System.Object();
            System.IO.DirectoryInfo val_4 = new System.IO.DirectoryInfo(path:  UnityEngine.Application.dataPath);
            typeof(System.String[]).__il2cppRuntimeField_20 = ".framework";
            typeof(ISD_FrameworkHandler.<GetImportedFrameworks>c__AnonStorey0).__il2cppRuntimeField_10 = null;
            if(null != 0)
            {
                    val_14 = GetFiles(searchPattern:  "*", searchOption:  1);
            }
            else
            {
                    val_14 = GetFiles(searchPattern:  "*", searchOption:  1);
            }
            
            System.Func<System.IO.FileInfo, System.Boolean> val_8 = new System.Func<System.IO.FileInfo, System.Boolean>(object:  val_1, method:  System.Boolean ISD_FrameworkHandler.<GetImportedFrameworks>c__AnonStorey0::<>m__0(System.IO.FileInfo f));
            System.Collections.Generic.IEnumerable<TSource> val_9 = System.Linq.Enumerable.Where<UnityEngine.UI.ExtensionsToggle>(source:  0, predicate:  val_14);
            TSource[] val_10 = System.Linq.Enumerable.ToArray<System.Type>(source:  0);
            System.Func<System.IO.DirectoryInfo, System.Boolean> val_11 = new System.Func<System.IO.DirectoryInfo, System.Boolean>(object:  val_1, method:  System.Boolean ISD_FrameworkHandler.<GetImportedFrameworks>c__AnonStorey0::<>m__1(System.IO.DirectoryInfo f));
            val_15 = System.Linq.Enumerable.Where<UnityEngine.UI.ExtensionsToggle>(source:  0, predicate:  GetDirectories(searchPattern:  "*", searchOption:  1));
            val_16 = 0;
            goto label_8;
            label_14:
            val_15 = System.Boolean ISD_FrameworkHandler.<GetImportedFrameworks>c__AnonStorey0::<>m__1(System.IO.DirectoryInfo f);
            Add(item:  val_15);
            val_16 = 1;
            label_8:
            if(val_16 >= val_10.Length)
            {
                goto label_10;
            }
            
            if(val_16 >= val_10.Length)
            {
                    val_17 = 0;
            }
            
            TSource val_14 = val_10[1];
            if(null != 0)
            {
                goto label_14;
            }
            
            goto label_14;
            label_10:
            val_18 = 0;
            goto label_15;
            label_21:
            val_19 = val_10;
            Add(item:  val_19);
            val_18 = 1;
            label_15:
            if(val_18 >= val_13.Length)
            {
                    return (System.Collections.Generic.List<System.String>)new System.Collections.Generic.List<System.String>();
            }
            
            if(val_18 >= val_13.Length)
            {
                    val_19 = 0;
            }
            
            TSource val_15 = System.Linq.Enumerable.ToArray<System.Type>(source:  0)[1];
            if(null != 0)
            {
                goto label_21;
            }
            
            goto label_21;
        }
        public static System.Collections.Generic.List<string> GetImportedLibraries()
        {
            string val_9;
            var val_10;
            System.IO.DirectoryInfo val_4 = new System.IO.DirectoryInfo(path:  UnityEngine.Application.dataPath);
            typeof(System.String[]).__il2cppRuntimeField_20 = ".a";
            typeof(System.String[]).__il2cppRuntimeField_28 = ".dylib";
            typeof(ISD_FrameworkHandler.<GetImportedLibraries>c__AnonStorey1).__il2cppRuntimeField_10 = null;
            System.Func<System.IO.FileInfo, System.Boolean> val_6 = new System.Func<System.IO.FileInfo, System.Boolean>(object:  new System.Object(), method:  System.Boolean ISD_FrameworkHandler.<GetImportedLibraries>c__AnonStorey1::<>m__0(System.IO.FileInfo f));
            val_9 = System.Linq.Enumerable.Where<UnityEngine.UI.ExtensionsToggle>(source:  0, predicate:  GetFiles(searchPattern:  "*", searchOption:  1));
            val_10 = 0;
            goto label_10;
            label_16:
            val_9 = System.Boolean ISD_FrameworkHandler.<GetImportedLibraries>c__AnonStorey1::<>m__0(System.IO.FileInfo f);
            Add(item:  val_9);
            val_10 = 1;
            label_10:
            if(val_10 >= val_8.Length)
            {
                    return (System.Collections.Generic.List<System.String>)new System.Collections.Generic.List<System.String>();
            }
            
            if(val_10 >= val_8.Length)
            {
                    val_9 = 0;
            }
            
            TSource val_9 = System.Linq.Enumerable.ToArray<System.Type>(source:  0)[1];
            if(null != 0)
            {
                goto label_16;
            }
            
            goto label_16;
        }
        public static System.Collections.Generic.List<SA.IOSDeploy.Framework> get_DefaultFrameworks()
        {
            System.Collections.Generic.List<SA.IOSDeploy.Framework> val_19;
            var val_20;
            var val_21;
            val_20 = null;
            val_20 = null;
            if(SA.IOSDeploy.ISD_FrameworkHandler._DefaultFrameworks == null)
            {
                    val_21 = null;
                val_21 = null;
                SA.IOSDeploy.ISD_FrameworkHandler._DefaultFrameworks = new System.Collections.Generic.List<SA.IOSDeploy.Framework>();
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_14 = 28;
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_19 = 0;
                Add(item:  new System.Object());
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_14 = 6;
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_19 = 0;
                Add(item:  new System.Object());
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_14 = 8;
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_19 = 0;
                Add(item:  new System.Object());
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_14 = 11;
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_19 = 0;
                Add(item:  new System.Object());
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_14 = 20;
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_19 = 0;
                Add(item:  new System.Object());
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_14 = 22;
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_19 = 0;
                Add(item:  new System.Object());
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_14 = 23;
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_19 = 0;
                Add(item:  new System.Object());
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_14 = 25;
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_19 = 0;
                Add(item:  new System.Object());
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_14 = 29;
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_19 = 0;
                Add(item:  new System.Object());
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_14 = 33;
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_19 = 0;
                Add(item:  new System.Object());
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_14 = 42;
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_19 = 0;
                Add(item:  new System.Object());
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_14 = 51;
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_19 = 0;
                Add(item:  new System.Object());
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_14 = 64;
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_19 = 0;
                Add(item:  new System.Object());
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_14 = 65;
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_19 = 0;
                Add(item:  new System.Object());
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_14 = 70;
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_19 = 0;
                Add(item:  new System.Object());
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_14 = 80;
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_19 = 0;
                Add(item:  new System.Object());
                object val_18 = null;
                val_19 = SA.IOSDeploy.ISD_FrameworkHandler._DefaultFrameworks;
                val_18 = new System.Object();
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_14 = 82;
                typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_19 = 0;
                Add(item:  val_18);
                val_20 = null;
            }
            
            val_20 = null;
            return (System.Collections.Generic.List<SA.IOSDeploy.Framework>)SA.IOSDeploy.ISD_FrameworkHandler._DefaultFrameworks;
        }
        public static string[] BaseFrameworksArray()
        {
            System.Collections.Generic.List<System.String> val_3 = new System.Collections.Generic.List<System.String>(capacity:  SA.IOSDeploy.ISD_FrameworkHandler.AvailableFrameworks.Capacity);
            List.Enumerator<T> val_5 = SA.IOSDeploy.ISD_FrameworkHandler.AvailableFrameworks.GetEnumerator();
            label_9:
            if((0 & 1) == 0)
            {
                goto label_13;
            }
            
            var val_10 = 0.InitializationCallback;
            val_10 = val_10 + 20;
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            mem2[0] = null;
            Add(item:  val_10.ToString());
            goto label_9;
            label_13:
            0.Dispose();
            return (System.String[])ToArray();
        }
        private static ISD_FrameworkHandler()
        {
        
        }
    
    }

}

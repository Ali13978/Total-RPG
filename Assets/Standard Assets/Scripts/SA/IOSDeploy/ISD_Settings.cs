using UnityEngine;

namespace SA.IOSDeploy
{
    public class ISD_Settings : ScriptableObject
    {
        // Fields
        public const string VERSION_NUMBER = "3.4/21";
        public bool IsfwSettingOpen;
        public bool IsLibSettingOpen;
        public bool IslinkerSettingOpne;
        public bool IscompilerSettingsOpen;
        public bool IsPlistSettingsOpen;
        public bool IsLanguageSettingOpen;
        public bool IsDefFrameworksOpen;
        public bool IsDefLibrariesOpen;
        public bool IsBuildSettingsOpen;
        public int ToolbarIndex;
        public bool enableBitCode;
        public bool enableTestability;
        public bool generateProfilingCode;
        public System.Collections.Generic.List<SA.IOSDeploy.Framework> Frameworks;
        public System.Collections.Generic.List<SA.IOSDeploy.Lib> Libraries;
        public System.Collections.Generic.List<SA.IOSDeploy.Flag> Flags;
        public System.Collections.Generic.List<SA.IOSDeploy.Variable> PlistVariables;
        public System.Collections.Generic.List<SA.IOSDeploy.VariableId> VariableDictionary;
        public System.Collections.Generic.List<string> langFolders;
        public System.Collections.Generic.List<SA.IOSDeploy.AssetFile> Files;
        private const string ISDAssetName = "ISD_Settings";
        private const string ISDAssetExtension = ".asset";
        private static SA.IOSDeploy.ISD_Settings instance;
        
        // Properties
        public static SA.IOSDeploy.ISD_Settings Instance { get; }
        
        // Methods
        public ISD_Settings()
        {
            this.IsLanguageSettingOpen = true;
            this.Frameworks = new System.Collections.Generic.List<SA.IOSDeploy.Framework>();
            this.Libraries = new System.Collections.Generic.List<SA.IOSDeploy.Lib>();
            this.Flags = new System.Collections.Generic.List<SA.IOSDeploy.Flag>();
            this.PlistVariables = new System.Collections.Generic.List<SA.IOSDeploy.Variable>();
            this.VariableDictionary = new System.Collections.Generic.List<SA.IOSDeploy.VariableId>();
            this.langFolders = new System.Collections.Generic.List<System.String>();
            this.Files = new System.Collections.Generic.List<SA.IOSDeploy.AssetFile>();
        }
        public static SA.IOSDeploy.ISD_Settings get_Instance()
        {
            SA.IOSDeploy.ISD_Settings val_6;
            var val_7;
            val_6 = SA.IOSDeploy.ISD_Settings.instance;
            if(0 != val_6)
            {
                    return (SA.IOSDeploy.ISD_Settings)SA.IOSDeploy.ISD_Settings.instance;
            }
            
            val_7 = 0;
            if((UnityEngine.Resources.Load(path:  0)) != null)
            {
                    val_7 = 0;
            }
            
            SA.IOSDeploy.ISD_Settings.instance = ;
            if(0 != SA.IOSDeploy.ISD_Settings.instance)
            {
                    return (SA.IOSDeploy.ISD_Settings)SA.IOSDeploy.ISD_Settings.instance;
            }
            
            SA.IOSDeploy.ISD_Settings.instance = UnityEngine.ScriptableObject.CreateInstance<LlockhamIndustries.Decals.DynamicDecalSettings>();
            return (SA.IOSDeploy.ISD_Settings)SA.IOSDeploy.ISD_Settings.instance;
        }
        public void AddVariable(SA.IOSDeploy.Variable var)
        {
            var val_7;
            var val_8;
            List.Enumerator<T> val_2 = System.Linq.Enumerable.ToList<UnityEngine.Component>(source:  0).GetEnumerator();
            label_8:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            if((X22.Equals(value:  var.Name)) == false)
            {
                goto label_8;
            }
            
            bool val_6 = this.PlistVariables.Remove(item:  0.InitializationCallback);
            goto label_8;
            label_2:
            val_7 = 0;
            val_8 = 1;
            0.Dispose();
            this.PlistVariables.Add(item:  var);
        }
        public void AddVariableToDictionary(string uniqueIdKey, SA.IOSDeploy.Variable var)
        {
            if(null != 0)
            {
                    typeof(SA.IOSDeploy.VariableId).__il2cppRuntimeField_18 = uniqueIdKey;
            }
            else
            {
                    mem[24] = uniqueIdKey;
            }
            
            typeof(SA.IOSDeploy.VariableId).__il2cppRuntimeField_10 = var;
            this.VariableDictionary.Add(item:  new System.Object());
        }
        public void RemoveVariable(SA.IOSDeploy.Variable v, System.Collections.IList ListWithThisVariable)
        {
            var val_7;
            SA.IOSDeploy.Variable val_13;
            System.Collections.Generic.List<SA.IOSDeploy.Variable> val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            val_13 = v;
            SA.IOSDeploy.ISD_Settings val_1 = SA.IOSDeploy.ISD_Settings.Instance;
            if((val_1.PlistVariables.Contains(item:  val_13)) != false)
            {
                    SA.IOSDeploy.ISD_Settings val_3 = SA.IOSDeploy.ISD_Settings.Instance;
                val_14 = val_3.PlistVariables;
                bool val_4 = val_14.Remove(item:  val_13);
                return;
            }
            
            List.Enumerator<T> val_5 = this.VariableDictionary.GetEnumerator();
            label_11:
            if((0 & 1) == 0)
            {
                goto label_20;
            }
            
            if(((X23 & 1) & 1) == 0)
            {
                goto label_11;
            }
            
            val_15 = public System.Boolean System.Collections.Generic.List<SA.IOSDeploy.VariableId>::Remove(SA.IOSDeploy.VariableId item);
            bool val_10 = this.VariableDictionary.Remove(item:  val_7.InitializationCallback);
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_15 = 6;
            val_16 = ListWithThisVariable;
            val_18 = mem[val_10 + 8];
            val_18 = val_10 + 8;
            if((ListWithThisVariable & 1) != 0)
            {
                    var val_14 = 0;
                val_14 = val_14 + 1;
                val_18 = 9;
                val_19 = ListWithThisVariable;
            }
            
            label_20:
            val_14 = 0;
            val_17 = 1;
            val_7.Dispose();
            if((val_17 & 1) != 0)
            {
                    return;
            }
            
            if(val_14 == 0)
            {
                    return;
            }
        
        }
        public SA.IOSDeploy.Variable getVariableByKey(string uniqueIdKey)
        {
            var val_6;
            List.Enumerator<T> val_1 = this.VariableDictionary.GetEnumerator();
            label_5:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_2 = 0.InitializationCallback;
            if((Equals(value:  uniqueIdKey)) == false)
            {
                goto label_5;
            }
            
            0.Dispose();
            return (SA.IOSDeploy.Variable)val_6;
            label_2:
            0.Dispose();
            val_6 = 0;
            return (SA.IOSDeploy.Variable)val_6;
        }
        public SA.IOSDeploy.Variable GetVariableByName(string name)
        {
            string val_5;
            var val_6;
            val_5 = name;
            SA.IOSDeploy.ISD_Settings val_1 = SA.IOSDeploy.ISD_Settings.Instance;
            List.Enumerator<T> val_2 = val_1.PlistVariables.GetEnumerator();
            label_6:
            if((0 & 1) == 0)
            {
                goto label_3;
            }
            
            val_6 = 0.InitializationCallback;
            if((X21.Equals(value:  val_5)) == false)
            {
                goto label_6;
            }
            
            0.Dispose();
            return (SA.IOSDeploy.Variable)val_6;
            label_3:
            0.Dispose();
            val_6 = 0;
            return (SA.IOSDeploy.Variable)val_6;
        }
        public string getKeyFromVariable(SA.IOSDeploy.Variable var)
        {
            var val_4;
            List.Enumerator<T> val_1 = this.VariableDictionary.GetEnumerator();
            label_5:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_2 = 0.InitializationCallback;
            if((0 & 1) == 0)
            {
                goto label_5;
            }
            
            0.Dispose();
            return (string)val_4;
            label_2:
            0.Dispose();
            val_4 = 0;
            return (string)val_4;
        }
        public bool ContainsPlistVarWithName(string name)
        {
            string val_5;
            var val_6;
            val_5 = name;
            SA.IOSDeploy.ISD_Settings val_1 = SA.IOSDeploy.ISD_Settings.Instance;
            List.Enumerator<T> val_2 = val_1.PlistVariables.GetEnumerator();
            label_6:
            if((0 & 1) == 0)
            {
                goto label_3;
            }
            
            if((0.InitializationCallback.Equals(value:  val_5)) == false)
            {
                goto label_6;
            }
            
            0.Dispose();
            val_6 = 1;
            return (bool)val_6;
            label_3:
            0.Dispose();
            val_6 = 0;
            return (bool)val_6;
        }
        public bool ContainsFramework(SA.IOSDeploy.iOSFramework framework)
        {
            SA.IOSDeploy.iOSFramework val_6;
            var val_7;
            val_6 = framework;
            SA.IOSDeploy.ISD_Settings val_1 = SA.IOSDeploy.ISD_Settings.Instance;
            List.Enumerator<T> val_2 = val_1.Frameworks.GetEnumerator();
            label_6:
            if((0 & 1) == 0)
            {
                goto label_3;
            }
            
            var val_6 = 0.InitializationCallback;
            val_6 = val_6 + 20;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            mem2[0] = null;
            if((val_6.Equals(obj:  val_6)) == false)
            {
                goto label_6;
            }
            
            0.Dispose();
            val_7 = 1;
            return (bool)val_7;
            label_3:
            0.Dispose();
            val_7 = 0;
            return (bool)val_7;
        }
        public SA.IOSDeploy.Framework GetFramework(SA.IOSDeploy.iOSFramework framework)
        {
            SA.IOSDeploy.iOSFramework val_7;
            var val_8;
            val_7 = framework;
            SA.IOSDeploy.ISD_Settings val_1 = SA.IOSDeploy.ISD_Settings.Instance;
            List.Enumerator<T> val_2 = val_1.Frameworks.GetEnumerator();
            label_6:
            if((0 & 1) == 0)
            {
                goto label_3;
            }
            
            val_8 = 0.InitializationCallback;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            mem2[0] = null;
            if((val_8 + 20.Equals(obj:  val_7)) == false)
            {
                goto label_6;
            }
            
            0.Dispose();
            return (SA.IOSDeploy.Framework)val_8;
            label_3:
            0.Dispose();
            val_8 = 0;
            return (SA.IOSDeploy.Framework)val_8;
        }
        public SA.IOSDeploy.Framework AddFramework(SA.IOSDeploy.iOSFramework framework, bool embaded = False)
        {
            SA.IOSDeploy.Framework val_5 = this.GetFramework(framework:  framework);
            if(val_5 != null)
            {
                    return val_5;
            }
            
            object val_2 = null;
            val_5 = val_2;
            val_2 = new System.Object();
            typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_14 = framework;
            typeof(SA.IOSDeploy.Framework).__il2cppRuntimeField_19 = embaded;
            SA.IOSDeploy.ISD_Settings val_4 = SA.IOSDeploy.ISD_Settings.Instance;
            val_4.Frameworks.Add(item:  val_5);
            return val_5;
        }
        public bool ContainsLibWithName(string name)
        {
            string val_6;
            var val_7;
            val_6 = name;
            SA.IOSDeploy.ISD_Settings val_1 = SA.IOSDeploy.ISD_Settings.Instance;
            List.Enumerator<T> val_2 = val_1.Libraries.GetEnumerator();
            label_6:
            if((0 & 1) == 0)
            {
                goto label_3;
            }
            
            if((SA.IOSDeploy.ISD_LibHandler.stringValueOf(value:  0.InitializationCallback).Equals(value:  val_6)) == false)
            {
                goto label_6;
            }
            
            0.Dispose();
            val_7 = 1;
            return (bool)val_7;
            label_3:
            0.Dispose();
            val_7 = 0;
            return (bool)val_7;
        }
        public SA.IOSDeploy.Lib GetLibrary(SA.IOSDeploy.iOSLibrary library)
        {
            SA.IOSDeploy.iOSLibrary val_6;
            var val_7;
            val_6 = library;
            List.Enumerator<T> val_1 = GetEnumerator();
            label_6:
            if((0 & 1) == 0)
            {
                goto label_3;
            }
            
            val_7 = 0.InitializationCallback;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            mem2[0] = null;
            if((val_7 + 20.Equals(obj:  val_6)) == false)
            {
                goto label_6;
            }
            
            0.Dispose();
            return (SA.IOSDeploy.Lib)val_7;
            label_3:
            0.Dispose();
            val_7 = 0;
            return (SA.IOSDeploy.Lib)val_7;
        }
        public SA.IOSDeploy.Lib AddLibrary(SA.IOSDeploy.iOSLibrary library)
        {
            SA.IOSDeploy.Lib val_4 = this.GetLibrary(library:  library);
            if(val_4 != null)
            {
                    return val_4;
            }
            
            object val_2 = null;
            val_4 = val_2;
            val_2 = new System.Object();
            typeof(SA.IOSDeploy.Lib).__il2cppRuntimeField_14 = library;
            SA.IOSDeploy.ISD_Settings val_3 = SA.IOSDeploy.ISD_Settings.Instance;
            val_3.Libraries.Add(item:  val_4);
            return val_4;
        }
        public void AddLinkerFlag(string s)
        {
            SA.IOSDeploy.ISD_Settings val_10;
            var val_11;
            var val_12;
            object val_1 = null;
            typeof(SA.IOSDeploy.Flag).__il2cppRuntimeField_10 = 1;
            val_1 = new System.Object();
            if(null != 0)
            {
                    typeof(SA.IOSDeploy.Flag).__il2cppRuntimeField_18 = s;
            }
            else
            {
                    mem[24] = s;
            }
            
            typeof(SA.IOSDeploy.Flag).__il2cppRuntimeField_20 = 1;
            List.Enumerator<T> val_2 = this.Flags.GetEnumerator();
            label_9:
            if((0 & 1) == 0)
            {
                goto label_4;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_3 = 0.InitializationCallback;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            mem2[0] = null;
            if(((val_3 + 32.Equals(obj:  1)) == false) || ((val_3.Equals(value:  s)) == false))
            {
                goto label_9;
            }
            
            label_4:
            val_10 = this;
            val_11 = 0;
            val_12 = 1;
            0.Dispose();
            this.Flags.Add(item:  val_1);
        }
    
    }

}
